<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CommandLink1 = New Vista_Api.CommandLink
        Me.CommandLink2 = New Vista_Api.CommandLink
        Me.CommandLink3 = New Vista_Api.CommandLink
        Me.CommandLink4 = New Vista_Api.CommandLink
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you having trouble while running Canure? Resetting Canure might help you out!" & _
            ""
        '
        'CommandLink1
        '
        Me.CommandLink1.BackColor = System.Drawing.Color.White
        Me.CommandLink1.Description = "Deletes all data including history, cache and cookies"
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Location = New System.Drawing.Point(12, 61)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(388, 60)
        Me.CommandLink1.TabIndex = 1
        Me.CommandLink1.TabStop = False
        Me.CommandLink1.Text = "Delete Browser Data"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'CommandLink2
        '
        Me.CommandLink2.BackColor = System.Drawing.Color.White
        Me.CommandLink2.Description = "Resets all settings to default ones"
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Location = New System.Drawing.Point(12, 127)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(388, 60)
        Me.CommandLink2.TabIndex = 2
        Me.CommandLink2.TabStop = False
        Me.CommandLink2.Text = "Reset settings"
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'CommandLink3
        '
        Me.CommandLink3.BackColor = System.Drawing.Color.White
        Me.CommandLink3.Description = "Restarts Canure so that all changes take place immediately"
        Me.CommandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink3.Location = New System.Drawing.Point(12, 200)
        Me.CommandLink3.Name = "CommandLink3"
        Me.CommandLink3.Size = New System.Drawing.Size(388, 60)
        Me.CommandLink3.TabIndex = 3
        Me.CommandLink3.TabStop = False
        Me.CommandLink3.Text = "Restart Canure"
        Me.CommandLink3.UseVisualStyleBackColor = True
        '
        'CommandLink4
        '
        Me.CommandLink4.BackColor = System.Drawing.Color.White
        Me.CommandLink4.Description = ""
        Me.CommandLink4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink4.Location = New System.Drawing.Point(162, 279)
        Me.CommandLink4.Name = "CommandLink4"
        Me.CommandLink4.Size = New System.Drawing.Size(77, 41)
        Me.CommandLink4.TabIndex = 4
        Me.CommandLink4.TabStop = False
        Me.CommandLink4.Text = "Ok"
        Me.CommandLink4.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 333)
        Me.Controls.Add(Me.CommandLink4)
        Me.Controls.Add(Me.CommandLink3)
        Me.Controls.Add(Me.CommandLink2)
        Me.Controls.Add(Me.CommandLink1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Canure"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommandLink1 As Vista_Api.CommandLink
    Friend WithEvents CommandLink2 As Vista_Api.CommandLink
    Friend WithEvents CommandLink3 As Vista_Api.CommandLink
    Friend WithEvents CommandLink4 As Vista_Api.CommandLink
End Class
