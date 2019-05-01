Imports System.ComponentModel

Public Class frmPasswordResetCode
    Private code As String 'Stores correct password reset code
    Public isCodeCorrect As Boolean = False 'Boolean to store whether entered code is correct or not

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() 'Close form if user presses cancel button
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtCode.Text = code Then 'If entered code matches code variable then set isCodeCorrect to true
            isCodeCorrect = True
        End If
        Close()
    End Sub

    Public Sub New(code As String) 'Constructor initializes form and code variable
        ' This call is required by the designer.
        InitializeComponent()
        Me.code = code
    End Sub
End Class