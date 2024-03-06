<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.btnCreateDeck = New System.Windows.Forms.Button()
        Me.lblDivider_2 = New System.Windows.Forms.Label()
        Me.lblDecks = New System.Windows.Forms.Label()
        Me.lblNewCards = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
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
        Me.lblDivider.TabIndex = 3
        '
        'btnCreateDeck
        '
        Me.btnCreateDeck.Location = New System.Drawing.Point(212, 581)
        Me.btnCreateDeck.Name = "btnCreateDeck"
        Me.btnCreateDeck.Size = New System.Drawing.Size(243, 33)
        Me.btnCreateDeck.TabIndex = 5
        Me.btnCreateDeck.Text = "Create Deck"
        Me.btnCreateDeck.UseVisualStyleBackColor = True
        '
        'lblDivider_2
        '
        Me.lblDivider_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider_2.Location = New System.Drawing.Point(-3, 576)
        Me.lblDivider_2.Name = "lblDivider_2"
        Me.lblDivider_2.Size = New System.Drawing.Size(725, 2)
        Me.lblDivider_2.TabIndex = 7
        '
        'lblDecks
        '
        Me.lblDecks.AutoSize = True
        Me.lblDecks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDecks.Location = New System.Drawing.Point(209, 54)
        Me.lblDecks.Name = "lblDecks"
        Me.lblDecks.Size = New System.Drawing.Size(47, 17)
        Me.lblDecks.TabIndex = 8
        Me.lblDecks.Text = "Decks"
        '
        'lblNewCards
        '
        Me.lblNewCards.AutoSize = True
        Me.lblNewCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNewCards.Location = New System.Drawing.Point(406, 54)
        Me.lblNewCards.Name = "lblNewCards"
        Me.lblNewCards.Size = New System.Drawing.Size(49, 17)
        Me.lblNewCards.TabIndex = 10
        Me.lblNewCards.Text = " Cards"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 616)
        Me.Controls.Add(Me.lblNewCards)
        Me.Controls.Add(Me.lblDecks)
        Me.Controls.Add(Me.lblDivider_2)
        Me.Controls.Add(Me.btnCreateDeck)
        Me.Controls.Add(Me.lblDivider)
        Me.Name = "frmHome"
        Me.Text = "Musitaa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDivider As Label
    Friend WithEvents btnCreateDeck As Button
    Friend WithEvents lblDivider_2 As Label
    Friend WithEvents lblDecks As Label
    Friend WithEvents lblNewCards As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
