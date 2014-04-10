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
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtWebSite = New System.Windows.Forms.TextBox
        Me.lvwWebSites = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.CommandLink1 = New Vista_Api.CommandLink
        Me.CommandLink2 = New Vista_Api.CommandLink
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(73, 399)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(509, 23)
        Me.txtURL.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "URL:"
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(73, 370)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(509, 23)
        Me.txtWebSite.TabIndex = 42
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.Location = New System.Drawing.Point(8, 11)
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(574, 343)
        Me.lvwWebSites.TabIndex = 41
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Web Site"
        '
        'CommandLink1
        '
        Me.CommandLink1.BackColor = System.Drawing.Color.White
        Me.CommandLink1.Description = Nothing
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Location = New System.Drawing.Point(15, 437)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(154, 44)
        Me.CommandLink1.TabIndex = 47
        Me.CommandLink1.TabStop = False
        Me.CommandLink1.Text = "Add Webpage"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'CommandLink2
        '
        Me.CommandLink2.BackColor = System.Drawing.Color.White
        Me.CommandLink2.Description = Nothing
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Location = New System.Drawing.Point(175, 437)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(159, 41)
        Me.CommandLink2.TabIndex = 48
        Me.CommandLink2.TabStop = False
        Me.CommandLink2.Text = "Delete Webpage"
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'frmFavorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(590, 490)
        Me.Controls.Add(Me.CommandLink2)
        Me.Controls.Add(Me.CommandLink1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWebSite)
        Me.Controls.Add(Me.lvwWebSites)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFavorites"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favorites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CommandLink1 As Vista_Api.CommandLink
    Friend WithEvents CommandLink2 As Vista_Api.CommandLink
End Class
