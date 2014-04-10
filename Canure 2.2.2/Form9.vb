Public Class Form9
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Show the password or hide it with an '*'
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox1.PasswordChar = Nothing
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'kets validate the password and restore canure
        Dim pass As String
        pass = My.Settings.bosspass
        If TextBox1.Text = pass Then
            Try
                Form1.Visible = True
                Form1.WindowState = FormWindowState.Normal
                Form1.ShowInTaskbar = True
                Form1.NotifyIcon1.Visible = False
            Catch ex As Exception
                'Oops, error (The error is Aero-related so we have to close canure)
                MsgBox("An fatal error occured in Canure. Program will now exit", MsgBoxStyle.Critical, "FATAL")
                'Application.Exit()
                'Why don't we restart Canure :)
                Application.Restart()
            End Try
        Else
            'Incorrect password
            MsgBox("Incorrect password. Please try again", MsgBoxStyle.Exclamation, "Error")
            Form1.NotifyIcon1.Visible = True
        End If

        'Just an manual override to get the password
        If TextBox1.Text = "ScriptEx(Settings.GetPass)" Then
            MsgBox("Congrats! You just executed an hack to retrieve the password.", MsgBoxStyle.Information, "ScriptEx")
            TextBox1.Text = pass
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Hide again
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Exit
        Application.Exit()
    End Sub
End Class