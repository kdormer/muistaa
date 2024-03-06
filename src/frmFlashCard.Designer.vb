<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlashCard
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
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblDivider2 = New System.Windows.Forms.Label()
        Me.lblFront = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblMiddleDivider = New System.Windows.Forms.Label()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(4, 38)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(725, 2)
        Me.lblDivider.TabIndex = 4
        '
        'lblDivider2
        '
        Me.lblDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider2.Location = New System.Drawing.Point(4, 568)
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(725, 2)
        Me.lblDivider2.TabIndex = 5
        '
        'lblFront
        '
        Me.lblFront.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFront.Location = New System.Drawing.Point(4, 112)
        Me.lblFront.Name = "lblFront"
        Me.lblFront.Size = New System.Drawing.Size(725, 31)
        Me.lblFront.TabIndex = 6
        Me.lblFront.Text = "FRONT"
        Me.lblFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBack
        '
        Me.lblBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBack.Location = New System.Drawing.Point(4, 406)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(725, 31)
        Me.lblBack.TabIndex = 7
        Me.lblBack.Text = "BACK"
        Me.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBack.Visible = False
        '
        'lblMiddleDivider
        '
        Me.lblMiddleDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMiddleDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiddleDivider.Location = New System.Drawing.Point(48, 266)
        Me.lblMiddleDivider.Name = "lblMiddleDivider"
        Me.lblMiddleDivider.Size = New System.Drawing.Size(632, 2)
        Me.lblMiddleDivider.TabIndex = 8
        Me.lblMiddleDivider.Visible = False
        '
        'btnHard
        '
        Me.btnHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnHard.Location = New System.Drawing.Point(376, 581)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(75, 32)
        Me.btnHard.TabIndex = 9
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'btnEasy
        '
        Me.btnEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnEasy.Location = New System.Drawing.Point(276, 581)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(75, 32)
        Me.btnEasy.TabIndex = 10
        Me.btnEasy.Text = "Easy"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(276, 526)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(175, 39)
        Me.btnShowAnswer.TabIndex = 11
        Me.btnShowAnswer.Text = "Show answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'frmFlashCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 616)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.lblMiddleDivider)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblFront)
        Me.Controls.Add(Me.lblDivider2)
        Me.Controls.Add(Me.lblDivider)
        Me.Name = "frmFlashCard"
        Me.Text = "Muistaa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDivider As Label
    Friend WithEvents lblDivider2 As Label
    Friend WithEvents lblFront As Label
    Friend WithEvents lblBack As Label
    Friend WithEvents lblMiddleDivider As Label
    Friend WithEvents btnHard As Button
    Friend WithEvents btnEasy As Button
    Friend WithEvents btnShowAnswer As Button
End Class
