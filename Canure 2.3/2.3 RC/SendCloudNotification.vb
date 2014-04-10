Imports Utilities.FTP
Imports System.Windows.Forms
Public Class SendCloudNotification
    Dim base64EncryptedString As String
    Dim decryptedData As Encryption.Data
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "mess.age", TextBox2.Text, False)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Saving SendCloudNotification data and starting BackgroundWorker", True)
        BackgroundWorker1.RunWorkerAsync()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Me.Text = "SendCloudNotification (Sending)"
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Connecting to cloud server", True)
        Dim pass As String
        pass = Decrypt(My.Settings.syncpassword)
        Dim ftp As New FTPclient(My.Settings.syncftpserver, My.Settings.syncusername, pass)
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Pushing notification to server", True)
            ftp.Upload(Application.StartupPath & "/" & "mess.age", "/" & TextBox1.Text & "/messages/mess.age")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Conforming if notification sent or not", True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while sending [" & ex.Message & "]", True)
            MsgBox("Error occured while sending [" & ex.Message & "]")
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Notification successfully sent", True)

        Kill(Application.StartupPath & "/" & "mess.age")
        Me.Close()
    End Sub
    Public Function Decrypt(ByVal eText As String) As String
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
        Dim key As New Encryption.Data("synclock")
        Dim encryptedData As New Encryption.Data
        encryptedData.Base64 = base64EncryptedString
        decryptedData = sym.Decrypt(encryptedData, key)
        Return decryptedData.ToString
    End Function
End Class