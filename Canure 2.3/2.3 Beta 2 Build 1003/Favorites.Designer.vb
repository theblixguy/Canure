<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favorites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Favorites))
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWebSite = New System.Windows.Forms.TextBox()
        Me.lvwWebSites = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopuURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(69, 386)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(509, 23)
        Me.txtURL.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "URL"
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(69, 357)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(509, 23)
        Me.txtWebSite.TabIndex = 42
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwWebSites.Location = New System.Drawing.Point(8, 42)
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(574, 296)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Web Site"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MetroUI_Form.My.Resources.Resources.add
        Me.PictureBox1.Location = New System.Drawing.Point(255, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MetroUI_Form.My.Resources.Resources.minus
        Me.PictureBox2.Location = New System.Drawing.Point(294, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 32)
        Me.Panel1.TabIndex = 62
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(568, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 63
        Me.PictureBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe WP", 12.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "favorites"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopuURLToolStripMenuItem, Me.OpenInBrowserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 48)
        '
        'CopuURLToolStripMenuItem
        '
        Me.CopuURLToolStripMenuItem.Name = "CopuURLToolStripMenuItem"
        Me.CopuURLToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CopuURLToolStripMenuItem.Text = "Copy URL"
        '
        'OpenInBrowserToolStripMenuItem
        '
        Me.OpenInBrowserToolStripMenuItem.Name = "OpenInBrowserToolStripMenuItem"
        Me.OpenInBrowserToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenInBrowserToolStripMenuItem.Text = "Open in Browser"
        '
        'Favorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(590, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWebSite)
        Me.Controls.Add(Me.lvwWebSites)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Favorites"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favorites"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopuURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
