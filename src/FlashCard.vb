Imports System.Data.OleDb

Public Class FlashCard
    Inherits Card

    Public Sub New(ByVal front As String, ByVal back As String, ByVal box As Integer, ByVal deck As Deck) 'Constructor initializes fields, increments variables and stores card in database
        MyBase.New(front, back, box, deck) 'Calls parent class subroutine from Card
        deck.cards += 1 'Increments card count for deck card is added to
        deck.lblCards.Text += 1 'Increments label displaying card count
        storeCardInDatabase() 'Stores card in database
        updateDeckInDatabase(deck) 'Updates total card number for deck card is added to
    End Sub

    Protected Overrides Sub storeCardInDatabase() 'Procedure to store new flashcard in database (overrided from parent class)
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        cmd.Connection = databaseConnection

        cmd.CommandText = "INSERT INTO tblCards VALUES (@ID, @User, @Front, @Back, @CreationDate, @TotalRevisions, @NextRevision, @Deck, @Box)"
        cmd.CommandType = CommandType.Text

        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = Session.HashInput(DateTime.Now().ToString()) 'Unique ID created by hashing current date, no two cards can have exact same date to the second
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Session.userID
        cmd.Parameters.Add("@Front", OleDbType.VarChar, 255).Value = Me.front
        cmd.Parameters.Add("@Back", OleDbType.VarChar, 255).Value = Me.back
        cmd.Parameters.Add("@CreationDate", OleDbType.VarChar, 255).Value = DateTime.Now()
        cmd.Parameters.Add("@TotalRevisions", OleDbType.VarChar, 255).Value = Me.totalRevisions
        cmd.Parameters.Add("@NextRevision", OleDbType.VarChar, 255).Value = Me.nextRevision
        cmd.Parameters.Add("@Deck", OleDbType.VarChar, 255).Value = Me.deck
        cmd.Parameters.Add("@Box", OleDbType.VarChar, 255).Value = Me._box

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message) 'Display exception message
        End Try

        databaseConnection.Close()
    End Sub

    Private Sub updateDeckInDatabase(ByVal deck As Deck) 'Updates card number for the deck the new card is added to
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        cmd.Connection = databaseConnection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE tblDecks SET Cards = @Cards WHERE ID = @ID"

        cmd.Parameters.Add("@Cards", OleDbType.VarChar, 255).Value = deck.cards
        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = deck.deckID

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message) 'Display exception message
        End Try

        databaseConnection.Close()
    End Sub


End Class
