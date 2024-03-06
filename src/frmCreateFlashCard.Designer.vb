<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateFlashCard
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
        Me.lblFront = New System.Windows.Forms.Label()
        Me.txtFront = New System.Windows.Forms.TextBox()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.txtBack = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFront
        '
        Me.lblFront.AutoSize = True
        Me.lblFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFront.Location = New System.Drawing.Point(12, 30)
        Me.lblFront.Name = "lblFront"
        Me.lblFront.Size = New System.Drawing.Size(86, 31)
        Me.lblFront.TabIndex = 0
        Me.lblFront.Text = "Front:"
        '
        'txtFront
        '
        Me.txtFront.Location = New System.Drawing.Point(18, 64)
        Me.txtFront.Multiline = True
        Me.txtFront.Name = "txtFront"
        Me.txtFront.Size = New System.Drawing.Size(497, 40)
        Me.txtFront.TabIndex = 1
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBack.Location = New System.Drawing.Point(12, 136)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(83, 31)
        Me.lblBack.TabIndex = 2
        Me.lblBack.Text = "Back:"
        '
        'txtBack
        '
        Me.txtBack.Location = New System.Drawing.Point(18, 170)
        Me.txtBack.Multiline = True
        Me.txtBack.Name = "txtBack"
        Me.txtBack.Size = New System.Drawing.Size(497, 40)
        Me.txtBack.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(18, 237)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 50)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add to Deck"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmCreateFlashCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 299)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBack)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.txtFront)
        Me.Controls.Add(Me.lblFront)
        Me.Name = "frmCreateFlashCard"
        Me.Text = "Create flashcard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFront As Label
    Friend WithEvents txtFront As TextBox
    Friend WithEvents lblBack As Label
    Friend WithEvents txtBack As TextBox
    Friend WithEvents btnAdd As Button
End Class
