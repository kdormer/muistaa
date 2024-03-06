Imports System.IO

Public Class frmCreateDeck
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim deckName As String = txtDeckName.Text 'Collect desired deck name from input text box

        If Session.DeckCount < 13 Then 'frmHome can only store 13 before GUI gives unpredictable behaviour
            If deckName.Length > 0 And deckName.Length <= 20 Then 'Input validation
                Dim deck As New Deck(deckName) 'Instantiate new deck object
                deck.Location = New System.Drawing.Point(212, 74 + (Session.DeckCount * 37)) 'Calculates where to position component based upon how many already exist
                deck.creationDate = Session.ReturnCurrentDate()

                Session.DeckCount += 1 'Increments deck count when new deck is created
                frmHome.Controls.Add(deck) 'Adds deck component to home form

                Close() 'Close deck creation form
            Else
                MsgBox("Invalid deck name!")
            End If

        Else
            MsgBox("Deck limit reached. Delete a current deck to create another one.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class