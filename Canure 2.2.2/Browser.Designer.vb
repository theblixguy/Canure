<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.WebKitBrowser1 = New WebKit.WebKitBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.NewTabToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrivateBrowsingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebpageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetCanureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lvwWebSites = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasteGoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebKitBrowser1
        '
        Me.WebKitBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebKitBrowser1.BackColor = System.Drawing.Color.White
        Me.WebKitBrowser1.Location = New System.Drawing.Point(0, 22)
        Me.WebKitBrowser1.Name = "WebKitBrowser1"
        Me.WebKitBrowser1.Size = New System.Drawing.Size(897, 434)
        Me.WebKitBrowser1.TabIndex = 0
        Me.WebKitBrowser1.Url = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 451)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(897, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stat
        '
        Me.stat.BackColor = System.Drawing.Color.Transparent
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(35, 17)
        Me.stat.Text = "Done"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton2, Me.ToolStripLabel1, Me.ToolStripComboBox1, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Back"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Stop"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Forward"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel1.Text = "x"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(750, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Favorite"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem1, Me.NewWindowToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.ToolStripSeparator1, Me.PrivateBrowsingToolStripMenuItem, Me.DeveloperToolStripMenuItem, Me.PageToolStripMenuItem, Me.ToolStripSeparator3, Me.FavoritesToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetCanureToolStripMenuItem, Me.ReportABugToolStripMenuItem, Me.ABoutToolStripMenuItem, Me.HideToolStripMenuItem})
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton4.Text = "Tools"
        '
        'NewTabToolStripMenuItem1
        '
        Me.NewTabToolStripMenuItem1.Name = "NewTabToolStripMenuItem1"
        Me.NewTabToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NewTabToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.NewTabToolStripMenuItem1.Text = "New Tab"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseTabToolStripMenuItem.ShowShortcutKeys = False
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        Me.CloseTabToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(219, 6)
        '
        'PrivateBrowsingToolStripMenuItem
        '
        Me.PrivateBrowsingToolStripMenuItem.CheckOnClick = True
        Me.PrivateBrowsingToolStripMenuItem.Name = "PrivateBrowsingToolStripMenuItem"
        Me.PrivateBrowsingToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.PrivateBrowsingToolStripMenuItem.Text = "Private Browsing"
        '
        'DeveloperToolStripMenuItem
        '
        Me.DeveloperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSourceToolStripMenuItem, Me.DeveloperToolsToolStripMenuItem})
        Me.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        Me.DeveloperToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DeveloperToolStripMenuItem.Text = "Developer"
        '
        'ViewSourceToolStripMenuItem
        '
        Me.ViewSourceToolStripMenuItem.Name = "ViewSourceToolStripMenuItem"
        Me.ViewSourceToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ViewSourceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ViewSourceToolStripMenuItem.Text = "View Source"
        '
        'DeveloperToolsToolStripMenuItem
        '
        Me.DeveloperToolsToolStripMenuItem.Name = "DeveloperToolsToolStripMenuItem"
        Me.DeveloperToolsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DeveloperToolsToolStripMenuItem.Text = "Developer Tools"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.PageToolStripMenuItem.Text = "Page"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebpageToolStripMenuItem, Me.MediaToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'WebpageToolStripMenuItem
        '
        Me.WebpageToolStripMenuItem.Name = "WebpageToolStripMenuItem"
        Me.WebpageToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.WebpageToolStripMenuItem.Text = "Webpage"
        '
        'MediaToolStripMenuItem
        '
        Me.MediaToolStripMenuItem.Name = "MediaToolStripMenuItem"
        Me.MediaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MediaToolStripMenuItem.Text = "Media"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(219, 6)
        '
        'FavoritesToolStripMenuItem
        '
        Me.FavoritesToolStripMenuItem.Name = "FavoritesToolStripMenuItem"
        Me.FavoritesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.FavoritesToolStripMenuItem.Text = "Favorites"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(219, 6)
        '
        'ResetCanureToolStripMenuItem
        '
        Me.ResetCanureToolStripMenuItem.Name = "ResetCanureToolStripMenuItem"
        Me.ResetCanureToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ResetCanureToolStripMenuItem.Text = "Reset Canure"
        '
        'ReportABugToolStripMenuItem
        '
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        Me.ReportABugToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ReportABugToolStripMenuItem.Text = "Report a Issue"
        '
        'ABoutToolStripMenuItem
        '
        Me.ABoutToolStripMenuItem.Name = "ABoutToolStripMenuItem"
        Me.ABoutToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ABoutToolStripMenuItem.Text = "About"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        Me.HideToolStripMenuItem.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "HTML File (*.html, *.htm)|*.htm, *.html|WebArchive (*.webarchive)|*.webarchive"
        Me.OpenFileDialog1.Title = "Open a file"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "HTML Only (*.htm)|*.htm"
        Me.SaveFileDialog1.Title = "Save page"
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.Location = New System.Drawing.Point(157, 328)
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(19, 10)
        Me.lvwWebSites.TabIndex = 42
        Me.lvwWebSites.UseCompatibleStateImageBehavior = False
        Me.lvwWebSites.View = System.Windows.Forms.View.Details
        Me.lvwWebSites.Visible = False
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
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "All|*.*"
        Me.OpenFileDialog2.Title = "Open a file"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator6, Me.PasteGoToolStripMenuItem, Me.ToolStripSeparator5, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(134, 126)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(130, 6)
        '
        'PasteGoToolStripMenuItem
        '
        Me.PasteGoToolStripMenuItem.Name = "PasteGoToolStripMenuItem"
        Me.PasteGoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PasteGoToolStripMenuItem.Text = "Paste && Go"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(130, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lvwWebSites)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Name = "Browser"
        Me.Size = New System.Drawing.Size(897, 473)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebKitBrowser1 As WebKit.WebKitBrowser
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NewTabToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrivateBrowsingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportABugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResetCanureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeveloperToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebpageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteGoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
