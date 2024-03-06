<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deck
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblDeckName = New System.Windows.Forms.Label()
        Me.lblCards = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblDivider2 = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.cntxtOptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntxtOptionsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDeckName
        '
        Me.lblDeckName.AutoSize = True
        Me.lblDeckName.Location = New System.Drawing.Point(3, 13)
        Me.lblDeckName.Name = "lblDeckName"
        Me.lblDeckName.Size = New System.Drawing.Size(67, 13)
        Me.lblDeckName.TabIndex = 0
        Me.lblDeckName.Text = "DECKNAME"
        '
        'lblCards
        '
        Me.lblCards.AutoSize = True
        Me.lblCards.Location = New System.Drawing.Point(223, 13)
        Me.lblCards.Name = "lblCards"
        Me.lblCards.Size = New System.Drawing.Size(44, 13)
        Me.lblCards.TabIndex = 2
        Me.lblCards.Text = "CARDS"
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(0, 3)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(406, 2)
        Me.lblDivider.TabIndex = 4
        '
        'lblDivider2
        '
        Me.lblDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider2.Location = New System.Drawing.Point(-3, 38)
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(406, 2)
        Me.lblDivider2.TabIndex = 5
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(322, 8)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 6
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'cntxtOptionsMenu
        '
        Me.cntxtOptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameToolStripMenuItem, Me.AddCardToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cntxtOptionsMenu.Name = "cntxtOptionsMenu"
        Me.cntxtOptionsMenu.Size = New System.Drawing.Size(123, 70)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'AddCardToolStripMenuItem
        '
        Me.AddCardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddCardToolStripMenuItem.Name = "AddCardToolStripMenuItem"
        Me.AddCardToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddCardToolStripMenuItem.Text = "Add card"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Deck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblDivider2)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblCards)
        Me.Controls.Add(Me.lblDeckName)
        Me.Name = "Deck"
        Me.Size = New System.Drawing.Size(406, 40)
        Me.cntxtOptionsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDeckName As Label
    Friend WithEvents lblCards As Label
    Friend WithEvents lblDivider As Label
    Friend WithEvents lblDivider2 As Label
    Friend WithEvents btnOptions As Button
    Friend WithEvents cntxtOptionsMenu As ContextMenuStrip
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
