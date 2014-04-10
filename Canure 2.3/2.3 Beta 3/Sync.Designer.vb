<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sync
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe WP", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "sync"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "username"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe WP", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(69, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "do"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe WP", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(370, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 36)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "create"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe WP", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepPink
        Me.Label6.Location = New System.Drawing.Point(314, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 36)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "sync"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "username"
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'RadTitleBar1
        '
        Me.RadTitleBar1.Caption = "Sync"
        Me.RadTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadTitleBar1.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        Me.RadTitleBar1.Size = New System.Drawing.Size(581, 31)
        Me.RadTitleBar1.TabIndex = 64
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "Sync"
        Me.RadTitleBar1.ThemeName = "TelerikMetro"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(86, 72)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(177, 23)
        Me.RadTextBox1.TabIndex = 65
        Me.RadTextBox1.TabStop = False
        Me.RadTextBox1.Text = "username"
        Me.RadTextBox1.ThemeName = "TelerikMetro"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(86, 107)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RadTextBox2.Size = New System.Drawing.Size(177, 23)
        Me.RadTextBox2.TabIndex = 66
        Me.RadTextBox2.TabStop = False
        Me.RadTextBox2.Text = "password"
        Me.RadTextBox2.ThemeName = "TelerikMetro"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Location = New System.Drawing.Point(392, 107)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RadTextBox3.Size = New System.Drawing.Size(177, 23)
        Me.RadTextBox3.TabIndex = 66
        Me.RadTextBox3.TabStop = False
        Me.RadTextBox3.Text = "password"
        Me.RadTextBox3.ThemeName = "TelerikMetro"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.Location = New System.Drawing.Point(392, 72)
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.Size = New System.Drawing.Size(177, 23)
        Me.RadTextBox4.TabIndex = 67
        Me.RadTextBox4.TabStop = False
        Me.RadTextBox4.Text = "username"
        Me.RadTextBox4.ThemeName = "TelerikMetro"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(86, 140)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(77, 24)
        Me.RadButton1.TabIndex = 68
        Me.RadButton1.Text = "Sync"
        Me.RadButton1.ThemeName = "TelerikMetro"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(392, 140)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(130, 24)
        Me.RadButton2.TabIndex = 69
        Me.RadButton2.Text = "Create Account"
        Me.RadButton2.ThemeName = "TelerikMetro"
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(0, 172)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(581, 10)
        Me.RadWaitingBar1.TabIndex = 70
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        Me.RadWaitingBar1.ThemeName = "TelerikMetro"
        Me.RadWaitingBar1.Visible = False
        Me.RadWaitingBar1.WaitingIndicatorSize = New System.Drawing.Size(50, 30)
        Me.RadWaitingBar1.WaitingSpeed = 100
        Me.RadWaitingBar1.WaitingStep = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(-9, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 32)
        Me.Panel1.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe WP", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chocolate
        Me.Label9.Location = New System.Drawing.Point(97, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(378, 20)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Sync is currently unavailable due to server maintainence"
        '
        'Sync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadWaitingBar1)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadTextBox4)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sync"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sync"
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
