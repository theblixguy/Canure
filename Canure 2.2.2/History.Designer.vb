<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.components = New System.ComponentModel.Container
        Me.lvwWebSites = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommandLink1 = New Vista_Api.CommandLink
        Me.CommandLink2 = New Vista_Api.CommandLink
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwWebSites.LabelWrap = False
        Me.lvwWebSites.Location = New System.Drawing.Point(8, 11)
        Me.lvwWebSites.MultiSelect = False
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(570, 393)
        Me.lvwWebSites.TabIndex = 41
        Me.lvwWebSites.UseCompatibleStateImageBehavior = False
        Me.lvwWebSites.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Website"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "URL"
        Me.ColumnHeader4.Width = 431
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyURLToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 26)
        '
        'CopyURLToolStripMenuItem
        '
        Me.CopyURLToolStripMenuItem.Name = "CopyURLToolStripMenuItem"
        Me.CopyURLToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CopyURLToolStripMenuItem.Text = "Copy URL"
        '
        'CommandLink1
        '
        Me.CommandLink1.BackColor = System.Drawing.Color.White
        Me.CommandLink1.Description = "Deletes the current item from the History"
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Location = New System.Drawing.Point(7, 412)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(259, 57)
        Me.CommandLink1.TabIndex = 46
        Me.CommandLink1.TabStop = False
        Me.CommandLink1.Text = "Delete"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'CommandLink2
        '
        Me.CommandLink2.BackColor = System.Drawing.Color.White
        Me.CommandLink2.Description = "Deletes all the items from the History"
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Location = New System.Drawing.Point(272, 412)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(259, 57)
        Me.CommandLink2.TabIndex = 47
        Me.CommandLink2.TabStop = False
        Me.CommandLink2.Text = "Delete All"
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(590, 476)
        Me.Controls.Add(Me.CommandLink2)
        Me.Controls.Add(Me.CommandLink1)
        Me.Controls.Add(Me.lvwWebSites)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "History"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CommandLink1 As Vista_Api.CommandLink
    Friend WithEvents CommandLink2 As Vista_Api.CommandLink
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
