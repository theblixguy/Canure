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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CommandLink1 = New Vista_Api.CommandLink
        Me.CommandLink2 = New Vista_Api.CommandLink
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You will need to restart Canure for the changes to take place. Would you like to " & _
            "do it now?"
        '
        'CommandLink1
        '
        Me.CommandLink1.BackColor = System.Drawing.Color.White
        Me.CommandLink1.Description = "Restarts Canure"
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Location = New System.Drawing.Point(12, 47)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(146, 53)
        Me.CommandLink1.TabIndex = 1
        Me.CommandLink1.TabStop = False
        Me.CommandLink1.Text = "Restart Now"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'CommandLink2
        '
        Me.CommandLink2.BackColor = System.Drawing.Color.White
        Me.CommandLink2.Description = "Postpones Restart"
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Location = New System.Drawing.Point(165, 47)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(135, 53)
        Me.CommandLink2.TabIndex = 2
        Me.CommandLink2.TabStop = False
        Me.CommandLink2.Text = "Restart Later"
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 109)
        Me.Controls.Add(Me.CommandLink2)
        Me.Controls.Add(Me.CommandLink1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restart Canure"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommandLink1 As Vista_Api.CommandLink
    Friend WithEvents CommandLink2 As Vista_Api.CommandLink
End Class
