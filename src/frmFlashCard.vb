Imports System.Data.OleDb

Public Class frmFlashCard

    Private cardList As New List(Of Deck.CardData) 'List of cards to be displayed and revised
    Private cardAnswer As Boolean? 'Nullable boolean type
    Private deckID As String

    Public Sub New(ByVal cards As List(Of Deck.CardData), deck As String) 'Constructor initializes component, list of cards to be displayed and ID of deck that cards belong to
        InitializeComponent() 'Call required by designer
        cardList = cards
        deckID = deck
    End Sub

    Private Sub displayCard(ByRef card As Deck.CardData) 'Procedure to display card
        lblFront.Text = card.front 'Sets front label to card's front string
        lblBack.Text = card.back 'Sets back label to card's back string
    End Sub

    Private Sub displayFlashCards() 'Procedure to display and revise all flashcards in the list
        Dim i As Integer = 0 'Used to index cardList

        While i < cardList.Count 'While i is less than the amount of cards in cardList
            btnEasy.Visible = False 'Hide buttons
            btnHard.Visible = False
            lblBack.Visible = False 'Hide back label
            cardAnswer = Nothing 'Set user's answer to card to null

            displayCard(cardList(i)) 'Display card

            btnShowAnswer.Visible = True

            While Not cardAnswer.HasValue 'While the user hasn't answered, continue executing GUI processes
                Application.DoEvents() 'Execute queued GUI processes - prevents while loop from pausing thread while waiting for user input
            End While

            cardList(i).totalRevisions += 1 'Increment total revisions of card
            cardList(i).box = Session.calculateNewBox(cardList(i), cardAnswer) 'Calculate card's new box based on user's answer
            cardList(i).nextRevision = Session.calculateNextCardRevision(cardList(i), cardAnswer) 'Calculate next revision time based on new box

            i += 1 'Increment i to repeat process for the next card
        End While

        Try
            updateCardsDatabase() 'Update cards in database with new details
        Catch ex As ArgumentOutOfRangeException 'This exception occurs when cardList contains no cards

        End Try

        Threading.Thread.Sleep(1000) 'Wait 1 second

        Close() 'Close frmFlashCard
    End Sub

    Private Sub updateCardsDatabase() 'Procedure to update card in database
        'Loops through cardList, updating database for each revised card
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        Dim i As Integer = 0

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE tblCards SET TotalRevisions = @TotalRevisions, NextRevision = @NextRevision, Box = @Box WHERE User = @User AND Deck = @Deck AND ID = @ID"
        cmd.Connection = databaseConnection

        cmd.Parameters.Add("@TotalRevisions", OleDbType.VarChar, 255).Value = cardList(i).totalRevisions
        cmd.Parameters.Add("@NextRevision", OleDbType.VarChar, 255).Value = cardList(i).nextRevision
        cmd.Parameters.Add("@Box", OleDbType.VarChar, 255).Value = cardList(i).box
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Session.userID
        cmd.Parameters.Add("@Deck", OleDbType.VarChar, 255).Value = deckID
        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = cardList(i).cardID

        databaseConnection.Open()

        While i < cardList.Count
            Try
                cmd.ExecuteNonQuery()
                i += 1
            Catch ex As Exception
                MsgBox(ex.Message) 'Display exception message
            End Try
        End While

        databaseConnection.Close()
    End Sub

    'cardAnswer uses three values to represent user's input
    'Nothing = not answered
    'True = recalled correctly with relative ease
    'False = recalled with much difficulty or didn't recall answer at all

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        cardAnswer = True
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        cardAnswer = False
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        'Once show answer is pressed, user can then answer
        lblMiddleDivider.Visible = True
        lblBack.Visible = True
        btnEasy.Visible = True
        btnHard.Visible = True
        btnShowAnswer.Visible = False
    End Sub

    Private Sub frmFlashCard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Once frmFlashCard has finished loading, display and revise flashcards
        displayFlashCards()
    End Sub
End Class
