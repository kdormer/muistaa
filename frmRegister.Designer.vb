<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.registerProgress = New System.Windows.Forms.ProgressBar()
        Me.tmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(12, 31)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(360, 2)
        Me.lblDivider.TabIndex = 5
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblRegister.Location = New System.Drawing.Point(154, 9)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(46, 13)
        Me.lblRegister.TabIndex = 6
        Me.lblRegister.Text = "Register"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(120, 44)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 64)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(127, 20)
        Me.txtFirstName.TabIndex = 8
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLastName.Location = New System.Drawing.Point(120, 103)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 123)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(127, 20)
        Me.txtLastName.TabIndex = 10
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblUsername.Location = New System.Drawing.Point(120, 159)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 17)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(123, 179)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(127, 20)
        Me.txtUsername.TabIndex = 12
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassword.Location = New System.Drawing.Point(120, 267)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 17)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "Password:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(123, 233)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtEmail.TabIndex = 14
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(120, 213)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "Email:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(123, 287)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(127, 20)
        Me.txtPassword.TabIndex = 16
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(123, 323)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(127, 26)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'registerProgress
        '
        Me.registerProgress.Location = New System.Drawing.Point(12, 355)
        Me.registerProgress.Name = "registerProgress"
        Me.registerProgress.Size = New System.Drawing.Size(360, 22)
        Me.registerProgress.TabIndex = 18
        '
        'tmrProgress
        '
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 389)
        Me.Controls.Add(Me.registerProgress)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblDivider)
        Me.Name = "frmRegister"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDivider As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents registerProgress As ProgressBar
    Friend WithEvents tmrProgress As Timer
End Class
