Imports System.Data.OleDb

Public Class frmHome

    Private decks As New List(Of Deck) 'stores all decks fetched from database

    Private Sub btnCreateDeck_Click(sender As Object, e As EventArgs) Handles btnCreateDeck.Click
        frmCreateDeck.ShowDialog() 'Opens deck creation form in modal window
    End Sub

    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown 'Event executes when home form has finished loading
        getDecksFromDb() 'Fetches user's decks from database
        displayDecks() 'Displays decks as components on frmHome
    End Sub

    Private Sub getDecksFromDb() 'Procedure to fetch user's decks from the database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT ID, DeckName, Cards, User, CreationDate FROM tblDecks WHERE User = @User"
        cmd.Connection = databaseConnection

        cmd.Parameters.Add("User", OleDbType.VarChar, 255).Value = Session.userID

        databaseConnection.Open()
        reader = cmd.ExecuteReader()

        Do While reader.HasRows()
            Try
                reader.Read()
                Dim deck As New Deck

                deck.deckID = reader.Item("ID").ToString()
                deck.deckName = reader.Item("DeckName").ToString()
                deck.cards = Integer.Parse(reader.Item("Cards").ToString)
                deck.user = reader.Item("User").ToString()
                deck.creationDate = reader.Item("CreationDate").ToString()
                deck.lblDeckName.Text = deck.deckName
                deck.lblCards.Text = deck.cards

                decks.Add(deck)

            Catch ex As Exception
                Exit Do
            End Try
        Loop

        databaseConnection.Close()
    End Sub

    Private Sub displayDecks() 'adds user's decks from database to home form
        For Each deck In decks
            If Session.DeckCount < 13 Then 'frmHome can store a maximum of 13 decks
                deck.Location = New System.Drawing.Point(212, 74 + (Session.DeckCount * 37)) 'Calculates where to place deck based on how many have been placed already
                Session.DeckCount += 1 'Increments Session deck count after adding deck to frmHome
                Controls.Add(deck) 'Adds deck component itself to frmHome
            End If
        Next
    End Sub
End Class
