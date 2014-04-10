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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.CopuURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lvwWebSites = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtWebSite = New Telerik.WinControls.UI.RadTextBox()
        Me.txtURL = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.txtWebSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtURL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PictureBox1.Image = Global.MetroUI_Form.My.Resources.Resources.favs
        Me.PictureBox1.Location = New System.Drawing.Point(255, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MetroUI_Form.My.Resources.Resources.cancel
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
        'RadTitleBar1
        '
        Me.RadTitleBar1.Caption = "Favorites"
        Me.RadTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadTitleBar1.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        Me.RadTitleBar1.Size = New System.Drawing.Size(590, 31)
        Me.RadTitleBar1.TabIndex = 65
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "Favorites"
        Me.RadTitleBar1.ThemeName = "TelerikMetro"
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopuURLToolStripMenuItem, Me.OpenInBrowserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 48)
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvwWebSites.Location = New System.Drawing.Point(7, 37)
        Me.lvwWebSites.MultiSelect = False
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(574, 314)
        Me.lvwWebSites.TabIndex = 52
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
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(69, 357)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(509, 23)
        Me.txtWebSite.TabIndex = 66
        Me.txtWebSite.TabStop = False
        Me.txtWebSite.ThemeName = "TelerikMetro"
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(69, 387)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(509, 23)
        Me.txtURL.TabIndex = 67
        Me.txtURL.TabStop = False
        Me.txtURL.ThemeName = "TelerikMetro"
        '
        'Favorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(590, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.txtWebSite)
        Me.Controls.Add(Me.lvwWebSites)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
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
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.txtWebSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtURL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopuURLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtWebSite As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtURL As Telerik.WinControls.UI.RadTextBox
End Class
