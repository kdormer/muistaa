Imports System.Data.OleDb

Public Class frmPasswordReset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim email As String = txtEmail.Text 'Gets email from textbox
        Dim newPassword As String = txtPassword.Text 'Gets new password from textbox

        If newPassword.Length() > 3 And newPassword.Length < 64 And checkPassword(email, newPassword) = True Then
            'Validates input, emails password reset code and checks code is correct
            If checkResetCode(email) = True Then
                Try
                    storeNewPassword(email, Session.HashInput(newPassword)) 'Stores new password if reset code is correct
                    MsgBox("Password successfully reset!")
                    Close() 'Close form
                Catch ex As Exception
                    MsgBox(ex.Message) 'Display exception message
                End Try

            Else
                MsgBox("Reset code incorrect!")
            End If
        ElseIf Session.isEmail(email) = False Or email.Length < 4 Or email.Length > 64 Then 'Checks user's email against email regular expression and length check
            MsgBox("Invalid email!")
        ElseIf newPassword.Length() < 3 Or newPassword.Length() > 64 Then 'Input validation
            MsgBox("Invalid password! Length should be greater than 3 and less than 64.")
        End If
    End Sub

    Private Function checkPassword(ByVal email As String, ByVal pass As String)
        'Function checks new password is not the same as the old one and checks an account is registered under inputted email
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim password As String = Session.HashInput(pass)

        cmd.CommandText = "SELECT Email, Password FROM tblUser WHERE Email = @Email"
        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.Parameters.Add("@Email", OleDbType.VarChar, 255).Value = email


        databaseConnection.Open()
        reader = cmd.ExecuteReader()

        Dim dbEmail As String
        Dim dbPassword As String

        If reader.HasRows() Then
            reader.Read()
            dbEmail = reader.Item("Email").ToString()
            dbPassword = reader.Item("Password").ToString()

            If dbPassword = password Then
                MsgBox("New password must not be the old one!")
                Return False
            End If
        Else
            MsgBox("No account is registered with that email!")
            Return False
        End If

        Return True 'Password is different + account with that email exists
    End Function

    Private Sub storeNewPassword(ByVal email As String, ByVal password As String) 'procedure to update user's password to new one in the database
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand

        cmd.CommandText = "UPDATE tblUser SET [Password] = @Password WHERE Email = @Email"
        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.Parameters.Add("@Password", OleDbType.VarChar, 255).Value = password
        cmd.Parameters.Add("Email", OleDbType.VarChar, 255).Value = email

        databaseConnection.Open()
        cmd.ExecuteNonQuery()

        databaseConnection.Close()
    End Sub

    Private Function generateResetCode() As String 'Generates random reset code to be emailed to the user
        Const CodeLength As Integer = 10
        Dim charSetString As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890" 'Character set
        Dim charSet() As Char = charSetString.ToCharArray() 'Converts character set string to an array of characters
        Dim code(CodeLength) As String 'Creates array of 10 elements
        Dim ran As New Random 'Instantiates new Random object

        For i As Integer = 0 To CodeLength
            'Each element in code array becomes a random character from the character set
            code(i) = charSet((ran.Next(0, charSetString.Length())))
        Next

        Dim newCode As String = "" 'String to store code
        Dim sb As New System.Text.StringBuilder 'Instantiates new StringBuilder object

        For j As Integer = 0 To CodeLength 'Loops through each element in code array and adds character to newCode string
            newCode = sb.Append(code(j)).ToString().Replace(vbCr, "").Replace(vbLf, "")
        Next

        Return newCode
    End Function

    Private Function checkResetCode(ByVal email As String) 'Procedure to email random reset code to user and check user enters correct code
        Dim resetCode As String = generateResetCode() 'Generates random reset code
        Session.EmailString(email, "Password reset code", resetCode) 'Emails reset code to user's email
        MsgBox("Reset code sent!")

        Dim resetCodeForm As New frmPasswordResetCode(resetCode) 'Instantiates password reset code form
        resetCodeForm.ShowDialog() 'Shows form in a modal window

        If resetCodeForm.isCodeCorrect = True Then 'If entered reset code is correct then return true
            Return True
        Else
            Return False
        End If
    End Function
End Class


