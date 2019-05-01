Public Class frmCreateFlashCard
    Private deckToAddTo As Deck

    Public Sub New(deck As Deck) 'Constructor initializes field and component
        ' This call is required by the designer.
        InitializeComponent()
        deckToAddTo = deck
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (txtFront.Text.Length > 0 And txtFront.Text.Length <= 255) And (txtBack.Text.Length > 0 And txtBack.Text.Length <= 255) Then 'Input validation, 255 is max size for field in database
            Try
                Dim fCard As New FlashCard(txtFront.Text, txtBack.Text, 1, deckToAddTo) 'Flashcard stored in database upon creation
                Close()
            Catch ex As Exception
                MsgBox(ex.Message) 'Display exception message
            End Try
        Else
            MsgBox("Invalid flashcard!")
        End If
    End Sub
End Class