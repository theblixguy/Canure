Imports System.Net
Imports System.IO
Imports System.Windows.Forms
Imports Utilities.FTP
Imports System.Xml
Imports System.Data
Imports System.Runtime.InteropServices

Public Class Sync

    <DllImport("user32.dll")> _
    Shared Function AnimateWindow(ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean
    End Function
    <Flags()> _
    Public Enum AnimateWindowFlags
        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000
    End Enum
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim base64EncryptedString As String
    Dim decryptedData As Encryption.Data

    Private Sub DisableTextboxes()
        RadButton1.Enabled = False
        RadButton2.Enabled = False
        RadTextBox1.Enabled = False
        RadTextBox2.Enabled = False
        RadTextBox3.Enabled = False
        RadTextBox4.Enabled = False
    End Sub

    Private Sub EnableTextboxes()
        RadButton1.Enabled = True
        RadButton2.Enabled = True
        RadTextBox1.Enabled = True
        RadTextBox2.Enabled = True
        RadTextBox3.Enabled = True
        RadTextBox4.Enabled = True
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Started. BackgroundWorker is now performing sync tasks", True)
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Connecting to Sync Host.", True)
            DisableTextboxes()
            Dim pass As String
            pass = Decrypt(My.Settings.syncpassword)
            Dim ftp As New FTPclient(My.Settings.syncftpserver, My.Settings.syncusername, pass)
            Dim txt As New TextBox
            Dim cst2 As New TextBox
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Verifying sync credentials.", True)
            ftp.Download("/" & RadTextBox1.Text & "/sync.ps", Application.StartupPath & "/" & "sync.ps", True)
            txt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "sync.ps")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "sync.ps")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Step 1: Merging sources XMLSchema1 + XMLSchema2", True)
            If RadTextBox2.Text = txt.Text Then
                ftp.Download("/" & RadTextBox1.Text & "/Websites.xml", Application.StartupPath & "/" & "Websites.sync", True)
                ftp.Download("/" & RadTextBox1.Text & "/History.xml", Application.StartupPath & "/" & "History.sync", True)
                Dim xmlreader1 As XmlTextReader = New XmlTextReader(Application.StartupPath & "/" & "Websites.sync")
                Dim xmlreader2 As New XmlTextReader(Application.StartupPath & "/" & "Websites.xml")
                Dim xmlreader3 As XmlTextReader = New XmlTextReader(Application.StartupPath & "/" & "History.sync")
                Dim xmlreader4 As New XmlTextReader(Application.StartupPath & "/" & "History.xml")
                Dim ds As New DataSet
                Dim ds2 As New DataSet
                Dim ds1 As New DataSet
                Dim ds3 As New DataSet
                ds.ReadXml(xmlreader1)
                ds2.ReadXml(xmlreader2)
                ds1.ReadXml(xmlreader3)
                ds3.ReadXml(xmlreader4)
                ds.Merge(ds2, False, MissingSchemaAction.Add)
                ds1.Merge(ds3, False, MissingSchemaAction.Add)
                xmlreader1.Close()
                xmlreader2.Close()
                xmlreader3.Close()
                xmlreader4.Close()

                Try
                    My.Computer.FileSystem.RenameFile(Application.StartupPath & "/" & "Websites.xml", "Websites.xml.bak")
                    My.Computer.FileSystem.RenameFile(Application.StartupPath & "/" & "History.xml", "History.xml.bak")
                Catch ex As System.IO.IOException : End Try

                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Step 2: Saving Schemas and data. Uploading back to sync server.", True)
                ds.WriteXml(Application.StartupPath & "/" & "Websites.xml")
                ds1.WriteXml(Application.StartupPath & "/" & "History.xml")
                ftp.FtpRename("/" & RadTextBox1.Text & "/Websites.xml", "/" & RadTextBox1.Text & "/Websites.bak")
                ftp.FtpRename("/" & RadTextBox1.Text & "/Websites.xml", "/" & RadTextBox1.Text & "/Websites.bak")
                ftp.FtpRename("/" & RadTextBox1.Text & "/History.xml", "/" & RadTextBox1.Text & "/History.bak")
                ftp.FtpDelete("/" & RadTextBox1.Text & "/History.bak")
                ftp.Upload(Application.StartupPath & "/" & "Websites.xml", "/" & RadTextBox1.Text & "/Websites.xml")
                ftp.Upload(Application.StartupPath & "/" & "History.xml", "/" & RadTextBox1.Text & "/History.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.sync")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.xml.bak")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.sync")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.xml.bak")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync completed.", True)

            Else
                EnableTextboxes()
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync failed. Firing up MsgBox to show possible reasons.", True)
                MsgBox("Error. 2 possible reasons : 1> Account doesn't exist. 2> Password is incorrect.", MsgBoxStyle.Critical, "Error")
                BackgroundWorker1.CancelAsync()
            End If
        Catch ex As Exception
            EnableTextboxes()
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Failed [!X!] <" & ex.InnerException.ToString & ">", True)
            MsgBox("Fatal error (" & ex.Message & ")", MsgBoxStyle.Critical, "Error")
            BackgroundWorker1.CancelAsync()
        End Try

    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Started. Connecting to sync host", True)
        Try
            Dim pass As String
            pass = Decrypt(My.Settings.syncpassword)
            Dim ftp As New FTPclient(My.Settings.syncftpserver, My.Settings.syncusername, pass)
            ftp.FtpCreateDirectory("/" & RadTextBox4.Text)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> SyncCreateAccount routine is being carried out.", True)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "sync.ps", RadTextBox3.Text, False)
            ftp.Upload(Application.StartupPath & "/" & "sync.ps", "/" & RadTextBox4.Text & "/sync.ps")
            ftp.Upload(Application.StartupPath & "/" & "Websites.xml", "/" & RadTextBox4.Text & "/Websites.xml")
            ftp.Upload(Application.StartupPath & "/" & "History.xml", "/" & RadTextBox4.Text & "/History.xml")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync over. Account has been created!", True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync failed. Looks like the account name exists <" & ex.InnerException.ToString & ">", True)
            MsgBox("Account creation failed. The account already exists, please try a different name. (" & ex.Message & ")", MsgBoxStyle.Critical, "Sync Error")
            BackgroundWorker2.CancelAsync()

        End Try

    End Sub


    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MsgBox("You account has been successfully created! Login to sync. (If you recieved a error before this message, then this message is a bug.)", MsgBoxStyle.Information, "Sync")
        EnableTextboxes()
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "sync.ps")
        RadButton1.Enabled = True
        RadWaitingBar1.Visible = False
        RadWaitingBar1.StopWaiting()
        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.xml.bak")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.xml.bak")
        Catch ex As Exception : End Try
        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Sync is now complete. (If you recieved a error before this message, then this message is a bug.)", MsgBoxStyle.Information, "Sync")
        EnableTextboxes()
        RadButton2.Enabled = True
        RadWaitingBar1.Visible = False
        RadWaitingBar1.StopWaiting()
        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.xml.bak")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.xml.bak")
        Catch ex As Exception : End Try
        BackgroundWorker1.CancelAsync()

    End Sub

    Private Sub Sync_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.xml.bak")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.sync")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.xml.bak")
        Catch ex As Exception : End Try
    End Sub
    Private Sub Sync_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            RadTextBox1.Text = My.Settings.username
        Catch ex As Exception : End Try
    End Sub
    Private Sub Sync_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Sync_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Sync_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub SyncStart()
        If RadTextBox1.TextLength > 5 And RadTextBox2.TextLength > 8 Then
            My.Settings.username = RadTextBox1.Text
            DisableTextboxes()
            RadWaitingBar1.Visible = True
            RadWaitingBar1.StartWaiting()
            BackgroundWorker1.RunWorkerAsync()
        Else
            EnableTextboxes()
            BackgroundWorker1.CancelAsync()
            MsgBox("Error. 2 possible reasons : 1> Account name should be more than 5 chars. 2> Password should be more than 8 chars", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub SyncCreateAccount()
        If RadTextBox4.TextLength > 5 And RadTextBox3.TextLength > 8 Then
            DisableTextboxes()
            RadWaitingBar1.Visible = True
            RadWaitingBar1.StartWaiting()
            BackgroundWorker2.RunWorkerAsync()
        Else
            EnableTextboxes()
            BackgroundWorker2.CancelAsync()
            MsgBox("Error. 2 possible reasons : 1> Account name should be more than 5 chars. 2> Password should be more than 8 chars", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        SyncStart()
    End Sub
    Public Function Decrypt(ByVal eText As String) As String
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
        Dim key As New Encryption.Data("synclock")
        Dim encryptedData As New Encryption.Data
        encryptedData.Base64 = base64EncryptedString
        decryptedData = sym.Decrypt(encryptedData, key)
        Return decryptedData.ToString
    End Function

    Private Sub Sync_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        DisableTextboxes()
    End Sub
End Class