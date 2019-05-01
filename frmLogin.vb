Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'When form closes and the user has logged in correctly, Session fields are initialized
        If Session.isLoggedIn = True Then
            Session.username = txtUsername.Text
            Session.passwordHash = Session.HashInput(txtPassword.Text)
            Session.userID = Session.HashInput(Session.username)
            frmHome.Show() 'Opens frmHome after logging in correctly
        ElseIf Session.isLoggedIn = False Then
            MsgBox("Please log in or register to use Muistaa.")
            Application.Exit() 'Closes program
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.ShowDialog() 'Opens registration form when register button is clicked
    End Sub

    Private Sub tmrLogin_Tick(sender As Object, e As EventArgs) Handles tmrLogin.Tick
        prgLogin.Increment(10)
        If prgLogin.Value = 100 Then
            tmrLogin.Stop()
            Close() 'Triggers closing event which opens main form
        End If
    End Sub

    Private Function processInput() 'Function to validate input
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username.Length() < 3 Or username.Length() > 12 Then
            MsgBox("Invalid username! Your username can only be between 3 and 12 characters long.")
            Return False
        ElseIf password.Length() < 4 Or password.Length() > 64 Then
            MsgBox("Invalid password! Your password needs to be between 4 and 64 characters.")
            Return False
        End If

        Return True
    End Function

    Private Function checkLoginDetails(ByVal username As String, ByVal password As String) 'Fetches entered data from database and ensures inputted data matches account details
        Dim databaseConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbMuistaa.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader

        cmd.CommandText = "SELECT Username, Password FROM tblUser WHERE Username = @Username AND Password = @Password"
        cmd.CommandType = CommandType.Text
        cmd.Connection = databaseConnection
        cmd.Parameters.Add("@Username", OleDbType.VarChar, 255).Value = username
        cmd.Parameters.Add("@Password", OleDbType.VarChar, 255).Value = Session.HashInput(password)

        databaseConnection.Open()
        reader = cmd.ExecuteReader()

        Dim dbUsername As String
        Dim dbPassword As String

        If reader.HasRows() Then
            reader.Read()
            dbUsername = reader.Item("Username").ToString()
            dbPassword = reader.Item("Password").ToString()

            If dbUsername = username And dbPassword = Session.HashInput(password) Then
                Return True 'Username and password hash match
            End If

        Else
            Return False 'Data doesn't match or there is no data matching the user's input
        End If

        reader.Close()
        databaseConnection.Close()
        Return False
    End Function

    Private Sub login(ByVal u As String, ByVal p As String) 'Procedure to commence login after validating input and checking login details are correct
        If processInput() = True Then
            If checkLoginDetails(u, p) = True Then
                Session.isLoggedIn = True
                tmrLogin.Start() 'Executes progress bar which will trigger event to log in user and open home form once it reaches 100
            Else
                MsgBox("Incorrect login details!")
            End If
        End If
    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        frmPasswordReset.ShowDialog() 'Open forgotten password form in a modal window
    End Sub
End Class