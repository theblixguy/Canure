Public Class Form4

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'Save the homepage link
        My.Settings.homepg = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        'Autorecovery On
        CommandLink1.Enabled = False
        CommandLink2.Enabled = True
        My.Settings.tabrec = True
        My.Settings.Save()
    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink2.Click
        'Autorecovery On
        CommandLink1.Enabled = True
        CommandLink2.Enabled = False
        My.Settings.tabrec = False
        My.Settings.Save()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Now lest just load all the settings!
        'Displat the homepage on the box
        TextBox1.Text = My.Settings.homepg
        'Check if tab recovery is On/Off
        If My.Settings.tabrec = True Then
            CommandLink1.Enabled = False
            CommandLink2.Enabled = True
        Else
            CommandLink1.Enabled = True
            CommandLink2.Enabled = False
        End If
        'Set the Search provider to 'Google'
        ComboBox1.SelectedItem = "Google"
        'Check if Google Instant is On/Off
        If My.Settings.googleins = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        'Nothing Important. Just forget it
        Label9.Text = "is " & My.Settings.tabclr.Name
        'Check if Aero is On/Off
        If My.Settings.aero = True Then
            CommandLink4.Enabled = False
            CommandLink5.Enabled = True
            Label8.Text = "is turned on"
            Label8.ForeColor = Color.ForestGreen
        Else
            CommandLink4.Enabled = True
            CommandLink5.Enabled = False
            Label8.Text = "is turned off"
            Label8.ForeColor = Color.Red
        End If
        'Nothing Important. Just forget it
        Label12.Text = "is " & My.Settings.cboxclr.Name
        'Check if to display homepage or blank page
        If My.Settings.hpage = True Then
            CommandLink7.Enabled = False
            CommandLink8.Enabled = True
        Else
            CommandLink7.Enabled = True
            CommandLink8.Enabled = False
        End If
        'Display the stealth-mode password
        TextBox2.Text = My.Settings.bosspass
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Enable/Disable Google Instant in real-time
        If CheckBox1.Checked = True Then
            My.Settings.googleins = True
            My.Settings.Save()
        Else
            My.Settings.googleins = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub CommandLink3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink3.Click
        'Open Color Picker to choose color for tabs
        ColorDialog1.ShowDialog()
        Try
            'Try setting the color
            Label9.Text = "is " & ColorDialog1.Color.Name
            My.Settings.tabclr = ColorDialog1.Color
            Form1.PageCollection1.TabColor = ColorDialog1.Color
            'Redraw the tabs
            Form1.PageCollection1.Refresh()
            'Save the color info
            My.Settings.Save()
        Catch ex As Exception
            'Ooops, error again
            MsgBox("Error setting color for the tab [" & ex.Message & "]", MsgBoxStyle.Critical, "Settings")
        End Try
    End Sub

    Private Sub CommandLink4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink4.Click
        'Switches to Aero On
        CommandLink4.Enabled = False
        CommandLink5.Enabled = True
        Label8.Text = "is turned on"
        Label8.ForeColor = Color.ForestGreen
        My.Settings.aero = True
        My.Settings.Save()
        'Restart Required. Ask user
        Form5.Show()
    End Sub

    Private Sub CommandLink5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink5.Click
        'Switches to Aero Off
        CommandLink4.Enabled = True
        CommandLink5.Enabled = False
        Label8.Text = "is turned off"
        Label8.ForeColor = Color.Red
        My.Settings.aero = False
        My.Settings.Save()
        'Restart Required. Ask user
        Form5.Show()
    End Sub

    Private Sub CommandLink6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink6.Click
        'Pop up the color picker again
        ColorDialog1.ShowDialog()
        Try
            'Apply the color for the main control box
            Label12.Text = "is " & ColorDialog1.Color.Name
            My.Settings.cboxclr = ColorDialog1.Color
            'Save the color
            My.Settings.Save()
            'Restart Required. Ask user
            Form5.Show()
        Catch ex As Exception
            MsgBox("Error setting color for the controlbox [" & ex.Message & "]", MsgBoxStyle.Critical, "Settings")
        End Try
    End Sub
    Private Sub PictureBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
        'Lets show user what's behind the eye
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            Label13.Visible = False
            PictureBox1.Visible = False
            ListView1.Visible = True
            AddSettings()
        End If
    End Sub

    Private Sub AddSettings()
        'Adds the settings (read-only). This is because if the user really want to see what is like to be behiund the AI, lets show them bogus info so they can't just forget and move ahead. AI part should not be modified :)
        With ListView1.Items.Add("Graphic Acceleration")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Use SSL 1")
            .SubItems.Add("False")
        End With
        With ListView1.Items.Add("Use SSL 2")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Use SSL 3")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Use TLS 1")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Send statastics to Blix on usage of Canure")
            .SubItems.Add("False")
        End With
        With ListView1.Items.Add("Use 2D Canvas")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Use DNS Pre-fetching")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Enable malware protection using the online WebScan Engine")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Enable malware protection using AI")
            .SubItems.Add("False")
        End With
        With ListView1.Items.Add("Use JavaScript")
            .SubItems.Add("Yes")
        End With
        With ListView1.Items.Add("Use Plug-ins")
            .SubItems.Add("Yes")
        End With
        With ListView1.Items.Add("Use Cookies")
            .SubItems.Add("Yes")
        End With
        With ListView1.Items.Add("Use Inter-Thread Call (ITC) architecture for tabs")
            .SubItems.Add("True")
        End With
        With ListView1.Items.Add("Use Inter-Process Call (IPC) architecture for tabs")
            .SubItems.Add("False")
        End With
        With ListView1.Items.Add("Show all settings")
            .SubItems.Add("Not Applicable")
        End With
    End Sub

    Private Sub CommandLink7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink7.Click
        'Switch to homepage at start
        CommandLink7.Enabled = False
        CommandLink8.Enabled = True
        My.Settings.hpage = True
        My.Settings.Save()
    End Sub

    Private Sub CommandLink8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink8.Click
        'Switch to blank-page at start
        CommandLink7.Enabled = True
        CommandLink8.Enabled = False
        My.Settings.hpage = False
        My.Settings.Save()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'Password for Stealth mode - Yes/No
        If CheckBox2.CheckState = CheckState.Checked Then
            TextBox2.PasswordChar = Nothing
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'Saves the password
        My.Settings.bosspass = TextBox2.Text
        My.Settings.Save()
    End Sub
    Private Sub CommandLink9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink9.Click
        'Lets connect to the server
        PictureBox2.Visible = True
        ProgressBar1.Value = 0
        Label19.ForeColor = Color.Black
        Label19.Visible = True
        CommandLink9.Enabled = False
        ProgressBar1.Visible = True
        'WARNING : ConnectServer() and ScanPage() functions are removed for security reason. These functions will be returned to the code soon. So for you statisfaction, we have added an bogus mockup of the feature
        Label19.Text = "Connecting to server.."
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'WARNING : ConnectServer() and ScanPage() functions are removed for security reason. These functions will be returned to the code soon. So for you statisfaction, we have added an bogus mockup of the feature
        ProgressBar1.PerformStep()
        If ProgressBar1.Value = 40 Then
            Timer1.Interval = 700
            ProgressBar1.Step = 10
            Label19.Text = "Scanning webpage.."
        ElseIf ProgressBar1.Value = 80 Then
            Timer1.Interval = 1200
            Label19.Text = "Sending data and fetching results.."
        ElseIf ProgressBar1.Value = 100 Then
            Label19.Text = "This webpage is safe!"
            Label19.ForeColor = Color.ForestGreen
            Timer1.Enabled = False
            CommandLink9.Enabled = True
            PictureBox2.Visible = False
        End If
    End Sub

End Class