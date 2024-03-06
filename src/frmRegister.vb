Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmRegister
    Private inputProcessed As Boolean

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        inputProcessed = processInput()
        If inputProcessed = True Then 'If input is valid
            tmrProgress.Start() 'Starts progress bar
        End If
    End Sub

    Private Function processInput() 'Validate and store user's account details input
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtLastName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim email As String = txtEmail.Text
        Dim userID As String = Session.HashInput(username) 'Creates unique identifier for user

        'Returns false, ending function if an input is invalid
        'If all inputs are valid, the details will be stored and true will be returned

        If firstName.Length() < 3 Or firstName.Length() > 12 Then
            MsgBox("Invalid first name! Your first name can be between 3 and 12 characters long.")
            Return False


        ElseIf lastName.Length() < 3 Or lastName.Length() > 12 Then
            MsgBox("Invalid last name! Your last name can be between 3 and 12 characters long.")
            Return False


        ElseIf username.Length() < 3 Or username.Length() > 12 Then
            MsgBox("Invalid username! Your username can only be between 3 and 12 characters long.")
            Return False


        ElseIf email.Length() < 4 Or email.Length() > 64 Then
            MsgBox("Invalid email! Your email needs to be between 4 and 64 characters long.")
            Return False

        ElseIf Session.isEmail(email) = False Then
            MsgBox("Invalid email!")
            Return False

        ElseIf password.Length() < 4 Or password.Length() > 64 Then
            MsgBox("Invalid password! Your password needs to be between 4 and 64 characters.")
            Return False
        End If

        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        databaseConnection.Open()

        Dim sql As String = "INSERT INTO tblUser VALUES (@UserID, @Username, @Email, @Password, @FirstName, @LastName)"
        Dim cmd As New OleDbCommand(sql, databaseConnection)

        cmd.Parameters.Add("@UserID", OleDbType.VarChar, 255).Value = userID
        cmd.Parameters.Add("@Username", OleDbType.VarChar, 255).Value = username
        cmd.Parameters.Add("@Email", OleDbType.VarChar, 255).Value = email
        cmd.Parameters.Add("@Password", OleDbType.VarChar, 255).Value = Session.HashInput(password) 'Hash stored in DB rather than plaintext for more security
        cmd.Parameters.Add("@FirstName", OleDbType.VarChar, 255).Value = firstName
        cmd.Parameters.Add("@LastName", OleDbType.VarChar, 255).Value = lastName

        Try
            cmd.ExecuteNonQuery()
        Catch ex As OleDbException 'Nine times out of ten, this exception will be triggered by duplication of data within the db
            MsgBox("User already exists! Please login to use Musitaa.")
            Return False
        Catch e As Exception
            MsgBox("Error creating user. Check database exists.")
        End Try

        databaseConnection.Close()

        Return True
    End Function

    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        'Once progress bar reaches 100, form will close, allowing user to login with new account
        registerProgress.Increment(10) 'Increment progress bar's progress by 10
        If registerProgress.Value = 100 Then
            tmrProgress.Stop()
            MsgBox("Registration successful! Please login to begin using Musitaa.")
            Close()
        End If
    End Sub
End Class