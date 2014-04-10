<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetroForm))
        Me.WebKitBrowser1 = New WebKit.WebKitBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextEditor1 = New Storm.TextEditor.TextEditor()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebKitBrowser1
        '
        Me.WebKitBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebKitBrowser1.BackColor = System.Drawing.Color.White
        Me.WebKitBrowser1.Location = New System.Drawing.Point(2, 33)
        Me.WebKitBrowser1.Name = "WebKitBrowser1"
        Me.WebKitBrowser1.Size = New System.Drawing.Size(1030, 552)
        Me.WebKitBrowser1.TabIndex = 2
        Me.WebKitBrowser1.Url = Nothing
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextEditor1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 228)
        Me.Panel1.TabIndex = 18
        Me.Panel1.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Segoe WP Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(832, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Revert (SC)/Onward (DC)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Segoe WP Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(753, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Live Mode"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Segoe WP Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(700, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.TextEditor1.Location = New System.Drawing.Point(11, 35)
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
        Me.TextEditor1.ShowGutterMargin = False
        Me.TextEditor1.ShowLineNumbers = True
        Me.TextEditor1.ShowScopeIndicator = True
        Me.TextEditor1.ShowWhitespace = False
        Me.TextEditor1.Size = New System.Drawing.Size(1006, 187)
        Me.TextEditor1.SmoothScroll = True
        Me.TextEditor1.SplitView = True
        Me.TextEditor1.SplitViewHorizontalEdgeDistance = -4
        Me.TextEditor1.SplitViewVerticalEdgeDistance = -4
        Me.TextEditor1.TabGuideColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TextEditor1.TabIndex = 14
        Me.TextEditor1.TabSpaces = 4
        Me.TextEditor1.UseDottedMarginBorder = False
        Me.TextEditor1.WhitespaceColor = System.Drawing.SystemColors.ControlDark
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1007, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe WP", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "view source"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSource})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ViewSource
        '
        Me.ViewSource.Name = "ViewSource"
        Me.ViewSource.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ViewSource.Size = New System.Drawing.Size(128, 20)
        Me.ViewSource.Text = "ToolStripMenuItem1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-5, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 32)
        Me.Panel2.TabIndex = 20
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.MetroUI_Form.My.Resources.Resources.favs
        Me.PictureBox6.Location = New System.Drawing.Point(475, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.MetroUI_Form.My.Resources.Resources.settings
        Me.PictureBox8.Location = New System.Drawing.Point(993, 6)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 24
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1018, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.MetroUI_Form.My.Resources.Resources.refresh
        Me.PictureBox5.Location = New System.Drawing.Point(451, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.MetroUI_Form.My.Resources.Resources.go
        Me.PictureBox3.Location = New System.Drawing.Point(428, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe WP Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(62, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 22)
        Me.TextBox1.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MetroUI_Form.My.Resources.Resources.Metro_Forward_Black_32
        Me.PictureBox2.Location = New System.Drawing.Point(37, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MetroUI_Form.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(72, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(113, 17)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ProgressBar1)
        Me.Panel4.Location = New System.Drawing.Point(0, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(190, 25)
        Me.Panel4.TabIndex = 28
        Me.Panel4.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepPink
        Me.Label3.Location = New System.Drawing.Point(2, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "navigating"
        '
        'MetroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 590)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MetroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canure 2.3 Beta 1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebKitBrowser1 As WebKit.WebKitBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TextEditor1 As Storm.TextEditor.TextEditor
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
