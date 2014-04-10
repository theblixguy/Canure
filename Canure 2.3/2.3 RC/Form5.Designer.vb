<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(520, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "beta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "help us in improving canure"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(545, 106)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(147, 165)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(130, 24)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "I wanna opt in"
        Me.RadButton1.ThemeName = "TelerikMetro"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(8, 165)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(130, 24)
        Me.RadButton2.TabIndex = 6
        Me.RadButton2.Text = "I wanna opt out"
        Me.RadButton2.ThemeName = "TelerikMetro"
        '
        'RadTitleBar1
        '
        Me.RadTitleBar1.Caption = "Canure CIEP"
        Me.RadTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadTitleBar1.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        Me.RadTitleBar1.Size = New System.Drawing.Size(557, 31)
        Me.RadTitleBar1.TabIndex = 7
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "Canure CIEP"
        Me.RadTitleBar1.ThemeName = "TelerikMetro"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe WP N", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "under development"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
End Class
