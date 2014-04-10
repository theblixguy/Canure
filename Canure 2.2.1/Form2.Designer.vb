<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextEditor1 = New Storm.TextEditor.TextEditor
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangeLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextEditor1
        '
        Me.TextEditor1.ActiveView = Storm.TextEditor.Editor.ActiveView.BottomRight
        Me.TextEditor1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEditor1.AutomaticLanguageDetection = True
        Me.TextEditor1.BracketBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextEditor1.BracketBold = False
        Me.TextEditor1.BracketBorderColor = System.Drawing.Color.Transparent
        Me.TextEditor1.BracketItalic = False
        Me.TextEditor1.BracketStrikethrough = False
        Me.TextEditor1.BracketUnderline = False
        Me.TextEditor1.BreakpointBackColor = System.Drawing.Color.DarkRed
        Me.TextEditor1.BreakpointForeColor = System.Drawing.Color.White
        Me.TextEditor1.CollapsedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextEditor1.CopyAsRTF = False
        Me.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.None
        Me.TextEditor1.EOLMarkerColor = System.Drawing.Color.ForestGreen
        Me.TextEditor1.ExpansionBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextEditor1.ExpansionSymbolColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextEditor1.FileName = ""
        Me.TextEditor1.FontName = "Consolas"
        Me.TextEditor1.GutterMarginColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextEditor1.GutterMarginWidth = 15
        Me.TextEditor1.HighlightActiveLine = False
        Me.TextEditor1.HighlightedLineColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TextEditor1.InactiveSelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextEditor1.InactiveSelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextEditor1.KeepTabs = False
        Me.TextEditor1.LineNumberBackColor = System.Drawing.SystemColors.Window
        Me.TextEditor1.LineNumberBorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TextEditor1.LineNumberForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TextEditor1.Location = New System.Drawing.Point(-2, 25)
        Me.TextEditor1.LockCursorUpdate = False
        Me.TextEditor1.Name = "TextEditor1"
        Me.TextEditor1.ParseOnPaste = False
        Me.TextEditor1.RowHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TextEditor1.RowPadding = 0
        Me.TextEditor1.Saved = False
        Me.TextEditor1.ScopeBackColor = System.Drawing.Color.Transparent
        Me.TextEditor1.ScopeIndicatorColor = System.Drawing.Color.Transparent
        Me.TextEditor1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor1.SelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditor1.ShowEOLMarker = False
        Me.TextEditor1.ShowGutterMargin = True
        Me.TextEditor1.ShowLineNumbers = True
        Me.TextEditor1.ShowScopeIndicator = True
        Me.TextEditor1.ShowWhitespace = False
        Me.TextEditor1.Size = New System.Drawing.Size(667, 347)
        Me.TextEditor1.SmoothScroll = True
        Me.TextEditor1.SplitView = False
        Me.TextEditor1.SplitViewHorizontalEdgeDistance = -4
        Me.TextEditor1.SplitViewVerticalEdgeDistance = -4
        Me.TextEditor1.TabGuideColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TextEditor1.TabIndex = 0
        Me.TextEditor1.TabSpaces = 4
        Me.TextEditor1.UseDottedMarginBorder = False
        Me.TextEditor1.WhitespaceColor = System.Drawing.SystemColors.ControlDark
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator1, Me.ChangeLanguageToolStripMenuItem, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'ChangeLanguageToolStripMenuItem
        '
        Me.ChangeLanguageToolStripMenuItem.Name = "ChangeLanguageToolStripMenuItem"
        Me.ChangeLanguageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ChangeLanguageToolStripMenuItem.ShowShortcutKeys = False
        Me.ChangeLanguageToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ChangeLanguageToolStripMenuItem.Text = "Change Language"
        Me.ChangeLanguageToolStripMenuItem.Visible = False
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = resources.GetString("OpenFileDialog1.Filter")
        Me.OpenFileDialog1.Title = "Open Source File"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.Title = "Save Source File"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 371)
        Me.Controls.Add(Me.TextEditor1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Developer Tools"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEditor1 As Storm.TextEditor.TextEditor
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
