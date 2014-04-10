Imports System.Net.Mail
Public Class Form6
    'Declare the variables
    Dim per As Integer 'This will contain the %
    Dim typ As String 'This will contain the Report Type
    Dim bugmsg As String ' This will contain the message
    Dim bosinfo As ApplicationServices.AssemblyInfo 'App info
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declare what we need
        typ = ComboBox1.Text 'Set the report type
        Label4.Visible = True
        bugmsg = TextBox1.Text 'Set the report text
        PictureBox2.Visible = True
        BackgroundWorker1.RunWorkerAsync() 'Send the report
        Button1.Enabled = False 'Disable the 'Send' button
        Timer1.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim msg As New MailMessage()
            BackgroundWorker1.ReportProgress(10)
            ' Your mail address and display name.
            ' This what will appear on the From field.
            ' If you used another credentials to access
            ' the SMTP server, the mail message would be
            ' sent from the mail specified in the From
            ' field on behalf of the real sender.
            msg.From = _
                New MailAddress("sft.bugfix@gmail.com")

            ' To addresses
            msg.To.Add(New MailAddress("sft.bugfix@gmail.com", "Blix Corporation"))

            ' You can specify CC and BCC addresses also

            ' Set to high priority
            msg.Priority = MailPriority.High
            BackgroundWorker1.ReportProgress(20)
            msg.Subject = "Canure 2.2.2 BugReport [" & typ & "]"

            ' You can specify a plain text or HTML contents
            msg.Body = bugmsg
            ' In order for the mail client to interpret message
            ' body correctly, we mark the body as HTML
            ' because we set the body to HTML contents.
            msg.IsBodyHtml = False

            ' Connecting to the server and configuring it
            Dim client As New SmtpClient()
            client.Host = "smtp.gmail.com"
            client.Port = 587
            client.EnableSsl = True
            BackgroundWorker1.ReportProgress(30)
            ' The server requires user's credentials
            ' not the default credentials
            client.UseDefaultCredentials = False
            ' Provide your credentials
            client.Credentials = New System.Net.NetworkCredential("sft.bugfix@gmail.com", "blixcorpqwerty1234")
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            BackgroundWorker1.ReportProgress(40)

            ' Use SendAsync to send the message asynchronously
            client.Send(msg)
            BackgroundWorker1.ReportProgress(90)
            Label4.Visible = True
            Timer1.Enabled = True
            BackgroundWorker1.ReportProgress(100)
        Catch ex As Exception
            BackgroundWorker1.CancelAsync()
            Timer1.Enabled = False
            Label4.Visible = False
            PictureBox2.Visible = False
            MsgBox("Failed to send the report. There might be some problem with your internet connection [" & ex.Message & "]", MsgBoxStyle.Critical, "Error")
            Button1.Enabled = True
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Show the %
        per = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Report Sent! Notify user ..
        BackgroundWorker1.CancelAsync()
        MsgBox("Thank you for helping us in improving Canure and fixing bugs. We will keep your report confidential and safe. ", MsgBoxStyle.Information, "Sent")
        Button1.Enabled = True
        PictureBox2.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Set the 'sending feedback' text
        Label4.Text = "Sending Feedback (" & per & "%)"
    End Sub
End Class