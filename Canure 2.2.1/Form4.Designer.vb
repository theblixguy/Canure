<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CommandLink2 = New Vista_Api.CommandLink
        Me.CommandLink1 = New Vista_Api.CommandLink
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.CommandLink6 = New Vista_Api.CommandLink
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CommandLink5 = New Vista_Api.CommandLink
        Me.Label8 = New System.Windows.Forms.Label
        Me.CommandLink4 = New Vista_Api.CommandLink
        Me.Label7 = New System.Windows.Forms.Label
        Me.CommandLink3 = New Vista_Api.CommandLink
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Setting = New System.Windows.Forms.ColumnHeader
        Me.Value = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CommandLink8 = New Vista_Api.CommandLink
        Me.CommandLink7 = New Vista_Api.CommandLink
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label19 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.CommandLink9 = New Vista_Api.CommandLink
        Me.Label18 = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(651, 350)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CommandLink2)
        Me.TabPage1.Controls.Add(Me.CommandLink1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(643, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Basic"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(17, 231)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(597, 35)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Use Google Instant. Google Instant accelerates your search experiance by sending " & _
            "keystrokes as you type to Google, so you can find things more quickly."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Google"})
        Me.ComboBox1.Location = New System.Drawing.Point(18, 203)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 8
        '
        'CommandLink2
        '
        Me.CommandLink2.BackColor = System.Drawing.Color.White
        Me.CommandLink2.Description = Nothing
        Me.CommandLink2.Enabled = False
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Location = New System.Drawing.Point(136, 123)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(105, 50)
        Me.CommandLink2.TabIndex = 7
        Me.CommandLink2.TabStop = False
        Me.CommandLink2.Text = "Disabled"
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'CommandLink1
        '
        Me.CommandLink1.BackColor = System.Drawing.Color.White
        Me.CommandLink1.Description = Nothing
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Location = New System.Drawing.Point(18, 123)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(105, 50)
        Me.CommandLink1.TabIndex = 6
        Me.CommandLink1.TabStop = False
        Me.CommandLink1.Text = "Enabled"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(541, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Auto-recovery helps in recovering tabs incase of accidental closing of tabs due t" & _
            "o an bug or error."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auto-recovery"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(519, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "http://www.google.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Homepage"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.CommandLink6)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.CommandLink5)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.CommandLink4)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CommandLink3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(643, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appearance"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(112, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "is Light Steel Blue"
        '
        'CommandLink6
        '
        Me.CommandLink6.BackColor = System.Drawing.Color.White
        Me.CommandLink6.Description = Nothing
        Me.CommandLink6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink6.Location = New System.Drawing.Point(18, 200)
        Me.CommandLink6.Name = "CommandLink6"
        Me.CommandLink6.Size = New System.Drawing.Size(98, 41)
        Me.CommandLink6.TabIndex = 11
        Me.CommandLink6.TabStop = False
        Me.CommandLink6.Text = "Change"
        Me.CommandLink6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Controlbox Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(69, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "is Light Steel Blue"
        '
        'CommandLink5
        '
        Me.CommandLink5.BackColor = System.Drawing.Color.White
        Me.CommandLink5.Description = Nothing
        Me.CommandLink5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink5.Location = New System.Drawing.Point(93, 116)
        Me.CommandLink5.Name = "CommandLink5"
        Me.CommandLink5.Size = New System.Drawing.Size(68, 45)
        Me.CommandLink5.TabIndex = 7
        Me.CommandLink5.TabStop = False
        Me.CommandLink5.Text = "Off"
        Me.CommandLink5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(47, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "is turned on"
        '
        'CommandLink4
        '
        Me.CommandLink4.BackColor = System.Drawing.Color.White
        Me.CommandLink4.Description = Nothing
        Me.CommandLink4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink4.Location = New System.Drawing.Point(19, 116)
        Me.CommandLink4.Name = "CommandLink4"
        Me.CommandLink4.Size = New System.Drawing.Size(68, 45)
        Me.CommandLink4.TabIndex = 5
        Me.CommandLink4.TabStop = False
        Me.CommandLink4.Text = "On"
        Me.CommandLink4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Aero"
        '
        'CommandLink3
        '
        Me.CommandLink3.BackColor = System.Drawing.Color.White
        Me.CommandLink3.Description = Nothing
        Me.CommandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink3.Location = New System.Drawing.Point(19, 37)
        Me.CommandLink3.Name = "CommandLink3"
        Me.CommandLink3.Size = New System.Drawing.Size(98, 41)
        Me.CommandLink3.TabIndex = 2
        Me.CommandLink3.TabStop = False
        Me.CommandLink3.Text = "Change"
        Me.CommandLink3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tab Color"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(643, 322)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Under the hood"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Setting, Me.Value})
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(21, 18)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(601, 287)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'Setting
        '
        Me.Setting.Text = "Setting"
        Me.Setting.Width = 403
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(615, 181)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = resources.GetString("Label13.Text")
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CheckBox2)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.CommandLink8)
        Me.TabPage4.Controls.Add(Me.CommandLink7)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(643, 322)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other Customizations"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(142, 196)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 19)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Password to restore:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(142, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(223, 23)
        Me.TextBox2.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(16, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(606, 34)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = resources.GetString("Label16.Text")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Stealth Mode Password"
        '
        'CommandLink8
        '
        Me.CommandLink8.BackColor = System.Drawing.Color.White
        Me.CommandLink8.Description = Nothing
        Me.CommandLink8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink8.Location = New System.Drawing.Point(232, 37)
        Me.CommandLink8.Name = "CommandLink8"
        Me.CommandLink8.Size = New System.Drawing.Size(197, 42)
        Me.CommandLink8.TabIndex = 4
        Me.CommandLink8.TabStop = False
        Me.CommandLink8.Text = "Open a blank page"
        Me.CommandLink8.UseVisualStyleBackColor = True
        '
        'CommandLink7
        '
        Me.CommandLink7.BackColor = System.Drawing.Color.White
        Me.CommandLink7.Description = Nothing
        Me.CommandLink7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink7.Location = New System.Drawing.Point(19, 37)
        Me.CommandLink7.Name = "CommandLink7"
        Me.CommandLink7.Size = New System.Drawing.Size(197, 42)
        Me.CommandLink7.TabIndex = 3
        Me.CommandLink7.TabStop = False
        Me.CommandLink7.Text = "Open the Home page"
        Me.CommandLink7.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Startup"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PictureBox2)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.ProgressBar1)
        Me.TabPage5.Controls.Add(Me.CommandLink9)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(643, 322)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "WebScan"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(125, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 15)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Idle"
        Me.Label19.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(128, 150)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(340, 16)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'CommandLink9
        '
        Me.CommandLink9.BackColor = System.Drawing.Color.White
        Me.CommandLink9.Description = Nothing
        Me.CommandLink9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink9.Location = New System.Drawing.Point(17, 75)
        Me.CommandLink9.Name = "CommandLink9"
        Me.CommandLink9.Size = New System.Drawing.Size(211, 42)
        Me.CommandLink9.TabIndex = 5
        Me.CommandLink9.TabStop = False
        Me.CommandLink9.Text = "Check current webpage"
        Me.CommandLink9.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(17, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(580, 32)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "WebScan is an online service, powered by Phishtank, that scans an webpage for dan" & _
            "gerous malware and infiltrations. "
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(98, 139)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 374)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommandLink2 As Vista_Api.CommandLink
    Friend WithEvents CommandLink1 As Vista_Api.CommandLink
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CommandLink3 As Vista_Api.CommandLink
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CommandLink4 As Vista_Api.CommandLink
    Friend WithEvents CommandLink5 As Vista_Api.CommandLink
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CommandLink6 As Vista_Api.CommandLink
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CommandLink8 As Vista_Api.CommandLink
    Friend WithEvents CommandLink7 As Vista_Api.CommandLink
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Setting As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CommandLink9 As Vista_Api.CommandLink
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
