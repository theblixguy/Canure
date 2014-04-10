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
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.MouseGestures1 = New MouseGestures.MouseGestures(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.PictureBox12)
        Me.Panel2.Controls.Add(Me.Label2)
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
        'PictureBox12
        '
        Me.PictureBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Location = New System.Drawing.Point(833, 7)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox12.TabIndex = 30
        Me.PictureBox12.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe WP Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(854, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "A error occured . . . . "
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
        Me.TextBox1.BackColor = System.Drawing.Color.White
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
        Me.ProgressBar1.Location = New System.Drawing.Point(72, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(113, 17)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ProgressBar1)
        Me.Panel4.Location = New System.Drawing.Point(0, 565)
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
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "navigating"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Controls.Add(Me.PictureBox10)
        Me.Panel3.Controls.Add(Me.PictureBox9)
        Me.Panel3.Location = New System.Drawing.Point(499, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(91, 26)
        Me.Panel3.TabIndex = 29
        Me.Panel3.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.MetroUI_Form.My.Resources.Resources.save
        Me.PictureBox11.Location = New System.Drawing.Point(60, 1)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 5
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.MetroUI_Form.My.Resources.Resources.search
        Me.PictureBox10.Location = New System.Drawing.Point(32, 1)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 4
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.MetroUI_Form.My.Resources.Resources.folder
        Me.PictureBox9.Location = New System.Drawing.Point(4, 1)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 3
        Me.PictureBox9.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "HTML (*.html)|*.html"
        Me.SaveFileDialog1.Title = "Save Webpage"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(703, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(332, 21)
        Me.Panel5.TabIndex = 30
        Me.Panel5.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Segoe WP N Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.PictureBox13)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(872, 569)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(163, 21)
        Me.Panel6.TabIndex = 32
        Me.Panel6.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe WP N Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepPink
        Me.Label6.Location = New System.Drawing.Point(150, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "x"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 1
        Me.PictureBox13.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe WP N Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepPink
        Me.Label5.Location = New System.Drawing.Point(21, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Checking for updates"
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.PictureBox14)
        Me.Panel7.Controls.Add(Me.TextBox2)
        Me.Panel7.Location = New System.Drawing.Point(131, 31)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 23)
        Me.Panel7.TabIndex = 33
        Me.Panel7.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe WP N Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Shortened"
        '
        'PictureBox14
        '
        Me.PictureBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(180, 1)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 31
        Me.PictureBox14.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox2.Location = New System.Drawing.Point(67, 1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "urlurlurlurl"
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerReportsProgress = True
        Me.BackgroundWorker3.WorkerSupportsCancellation = True
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel8.Controls.Add(Me.PictureBox15)
        Me.Panel8.Location = New System.Drawing.Point(835, 142)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 325)
        Me.Panel8.TabIndex = 34
        '
        'PictureBox15
        '
        Me.PictureBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(178, 3)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 31
        Me.PictureBox15.TabStop = False
        '
        'MetroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 590)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MetroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canure 2.3 Beta 3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MouseGestures1 As MouseGestures.MouseGestures
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
End Class
