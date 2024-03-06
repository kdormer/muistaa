Imports System.Data.OleDb
Imports System.IO

Public Class Deck
    Private _deckName As String 'Name of deck
    Private _cards As Integer 'Amount of cards deck contains
    Private _creationDate As String 'Date, to the second, deck was created
    Private _user As String 'User ID
    Private _deckID As String 'Unique ID of deck

    '|Properties are used to prevent exposure of variables to global scope|

    Public Property deckName() As String
        Get
            Return _deckName
        End Get
        Set(value As String)
            _deckName = value
        End Set
    End Property

    Public Property cards() As Integer
        Get
            Return _cards
        End Get
        Set(value As Integer)
            _cards = value
        End Set
    End Property

    Public Property creationDate() As String
        Get
            Return _creationDate
        End Get
        Set(value As String)
            _creationDate = value
        End Set
    End Property

    Public Property user() As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property

    Public Property deckID() As String
        Get
            Return _deckID
        End Get
        Set(value As String)
            _deckID = value
        End Set
    End Property

    Public Sub New() 'Default constructor 
        InitializeComponent() 'Required by designer
    End Sub

    Public Sub New(deckName As String) 'Constructor initializes fields and labels
        InitializeComponent() 'Required by designer
        Me._user = Session.userID
        Me._deckName = deckName
        Me._cards = 0
        Me._deckID = Session.HashInput(_deckName) 'Unique ID for Deck object
        Me._creationDate = Session.ReturnCalculatedDateTime(0)
        lblDeckName.Text = deckName
        lblCards.Text = _cards.ToString()
        storeDeckInDatabase() 'Stores newly created deck in database

    End Sub

    Private Sub storeDeckInDatabase() 'Procedure to store deck in database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        cmd.Connection = databaseConnection

        cmd.CommandText = "INSERT INTO tblDecks VALUES (@ID, @User, @DeckName, @Cards, @CreationDate)"
        cmd.CommandType = CommandType.Text

        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = Me._deckID
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Me._user
        cmd.Parameters.Add("@DeckName", OleDbType.VarChar, 255).Value = Me._deckName
        cmd.Parameters.Add("@Cards", OleDbType.VarChar, 255).Value = Me._cards
        cmd.Parameters.Add("@CreationDate", OleDbType.VarChar, 255).Value = Me._creationDate

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message) 'Display exception message
        End Try

        databaseConnection.Close()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        cntxtOptionsMenu.Show(btnOptions, 0, btnOptions.Height) 'Display options menu when options button is pressed 
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Dim renameForm As New frmRenameDeck(Me) 'Pass current deck instance to rename form for renaming in label and database
        renameForm.ShowDialog() 'Open renameForm in modal view
    End Sub


    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click 'Deletes deck control from frmHome and deck and its cards from database when delete option is pressed
        frmHome.Controls.Remove(Me) 'Removes control
        Session.DeckCount -= 1 'Removes one from the Session's deck count

        deleteDeckFromDb() 'Deletes deck from database
        deleteCardsFromDb() 'Deletes deck's cards from database

    End Sub

    Private Sub lblDeckName_MouseEnter(sender As Object, e As EventArgs) Handles lblDeckName.MouseEnter 'Underlines deck label when mouse hovers over it
        lblDeckName.Font = New Font(lblDeckName.Font.Name, lblDeckName.Font.SizeInPoints, FontStyle.Underline)
    End Sub

    Private Sub lblDeckName_MouseLeave(sender As Object, e As EventArgs) Handles lblDeckName.MouseLeave 'Get rid of underline when mouse leaves label
        lblDeckName.Font = New Font(lblDeckName.Font.Name, lblDeckName.Font.SizeInPoints, FontStyle.Regular)
    End Sub

    Class CardData 'Inner class used in a structure-like fashion to pass cards and their data across procedures and classes
        Public front As String
        Public back As String
        Public nextRevision As String
        Public box As Integer
        Public totalRevisions As Integer
        Public user As String
        Public deck As String
        Public cardID As String
    End Class

    Private Sub lblDeckName_MouseClick(sender As Object, e As MouseEventArgs) Handles lblDeckName.MouseClick
        'When deck name label is clicked, fetches all cards that need revising from database and displays them
        If Session.DeckCount = 0 Or Me.cards = 0 Then 'If there are no cards to be fetched, exit subroutine to prevent exceptions
            Exit Sub
        End If

        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader

        cmd.CommandText = "SELECT Front, Back, NextRevision, Box, TotalRevisions, User, Deck, ID FROM tblCards WHERE User = @User AND Deck = @Deck"
        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection

        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Me._user 'Unique user ID
        cmd.Parameters.Add("@Deck", OleDbType.VarChar, 255).Value = Me._deckID 'Unique deck ID

        databaseConnection.Open()
        reader = cmd.ExecuteReader() 'Executes query and stores data in a row format within reader

        Dim cards As New List(Of CardData) 'List of cards to be displayed

        Do While reader.HasRows() 'While reader has rows of data, make and add to list of cards a new CardData object with said rows of data
            Try
                reader.Read()
                Dim card As CardData = New CardData
                card.front = reader.Item("Front").ToString()
                card.back = reader.Item("Back").ToString()
                card.nextRevision = reader.Item("NextRevision").ToString()
                card.box = reader.Item("Box").ToString()
                card.totalRevisions = reader.Item("TotalRevisions").ToString()
                card.user = reader.Item("User").ToString()
                card.deck = reader.Item("Deck").ToString()
                card.cardID = reader.Item("ID").ToString()

                If Session.dateReached(card.nextRevision) = True Then
                    'If card's next revision date has been reached, it is added to list to be displayed and revised
                    cards.Add(card)
                End If

            Catch ex As Exception
                Exit Do 'Break loop when there are no more cards to be added to the list 
            End Try
        Loop

        displayCards(cards) 'Display and revise cards

    End Sub

    Private Sub displayCards(ByRef cards As List(Of CardData))
        'Procedure to display and revise cards
        Dim flashCardDisplay As New frmFlashCard(cards, Me._deckID) 'Instantiates frmFlashCard and passes list of cards to be revised

        If cards.Count > 0 Then 'If cards list isn't empty, display frmFlashCard in modal window
            flashCardDisplay.ShowDialog()
        End If
    End Sub

    Private Sub AddCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCardToolStripMenuItem.Click
        'Procedure to create new flashcard when add card option is clicked
        Dim flashCardCreationForm As New frmCreateFlashCard(Me) 'Instantiates card creation form and passes deck for card to be added to (Me = this instance)
        flashCardCreationForm.ShowDialog() 'Displays card creation form in modal window
    End Sub

    Private Sub deleteDeckFromDb() 'Deletes deck from database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.CommandText = "DELETE FROM tblDecks WHERE ID = @ID AND User = @User"

        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = Me.deckID
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Me.user 'User ID included in query to ensure decks with same name owned by different users aren't deleted

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message) 'Display exception message
        End Try

        databaseConnection.Close()
    End Sub

    Private Sub deleteCardsFromDb() 'Deletes cards within deck from database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.CommandText = "DELETE FROM tblCards WHERE Deck = @Deck AND @User = @User"

        cmd.Parameters.Add("@Deck", OleDbType.VarChar, 255).Value = Me.deckID
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Me.user

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message) 'Display exception message
        End Try

        databaseConnection.Close()
    End Sub
End Class
