Imports System.Data.OleDb

Public Class frmRenameDeck
    Private deck As Deck 'Deck to be renamed

    Public Sub New(deckToBeRenamed As Deck) 'Constructor initializes form and deck field
        InitializeComponent()
        deck = deckToBeRenamed
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'If input is valid then deck is renamed in its component and in database
        If txtDeckName.Text.Length > 0 And txtDeckName.Text.Length <= 20 Then
            deck.deckName = txtDeckName.Text
            deck.lblDeckName.Text = txtDeckName.Text
            renameDeckInDb()
            Close()
        Else
            MsgBox("Invalid deck name!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() 'Close form if user presses cancel
    End Sub

    Private Sub renameDeckInDb() 'Procedure to rename deck in the database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.CommandText = "UPDATE tblDecks SET DeckName = @DeckName WHERE ID = @ID AND User = @User"

        cmd.Parameters.Add("@DeckName", OleDbType.VarChar, 255).Value = txtDeckName.Text
        cmd.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = deck.deckID
        cmd.Parameters.Add("@User", OleDbType.VarChar, 255).Value = Session.userID

        databaseConnection.Open()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        databaseConnection.Close()
    End Sub
End Class



