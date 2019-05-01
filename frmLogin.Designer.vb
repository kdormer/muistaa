<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.prgLogin = New System.Windows.Forms.ProgressBar()
        Me.tmrLogin = New System.Windows.Forms.Timer(Me.components)
        Me.btnForgot = New System.Windows.Forms.Button()
        Me.lblDivider2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(139, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(87, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Login or Register"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(123, 64)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(127, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(12, 31)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(360, 2)
        Me.lblDivider.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblUsername.Location = New System.Drawing.Point(120, 44)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 17)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPassword.Location = New System.Drawing.Point(120, 99)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 17)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(123, 119)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(127, 20)
        Me.txtPassword.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(123, 156)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 31)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(123, 290)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(127, 31)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'prgLogin
        '
        Me.prgLogin.Location = New System.Drawing.Point(123, 203)
        Me.prgLogin.Name = "prgLogin"
        Me.prgLogin.Size = New System.Drawing.Size(127, 21)
        Me.prgLogin.TabIndex = 10
        '
        'tmrLogin
        '
        '
        'btnForgot
        '
        Me.btnForgot.Location = New System.Drawing.Point(123, 327)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(127, 31)
        Me.btnForgot.TabIndex = 11
        Me.btnForgot.Text = "Forgot Password"
        Me.btnForgot.UseVisualStyleBackColor = True
        '
        'lblDivider2
        '
        Me.lblDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider2.Location = New System.Drawing.Point(12, 285)
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(360, 2)
        Me.lblDivider2.TabIndex = 12
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lblDivider2)
        Me.Controls.Add(Me.btnForgot)
        Me.Controls.Add(Me.prgLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmLogin"
        Me.Text = "Login or Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblDivider As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents prgLogin As ProgressBar
    Friend WithEvents tmrLogin As Timer
    Friend WithEvents btnForgot As Button
    Friend WithEvents lblDivider2 As Label
End Class
