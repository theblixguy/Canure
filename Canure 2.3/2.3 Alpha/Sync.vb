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
    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.check1
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.check
    End Sub
    Private Sub DisableTextboxes()

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub EnableTextboxes()

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Started. BackgroundWorker is now performing sync tasks", True)
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Connecting to Sync Host.", True)
            DisableTextboxes()
            Dim ftp As New FTPclient("host", "username", "password")
            Dim txt As New TextBox
            Dim cst2 As New TextBox
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Verifying sync credentials.", True)
            ftp.Download("/" & TextBox1.Text & "/sync.ps", Application.StartupPath & "/" & "sync.ps", True)
            txt.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "sync.ps")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "sync.ps")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Step 1: Merging sources XMLSchema1 + XMLSchema2", True)
            If TextBox2.Text = txt.Text Then
                ftp.Download("/" & TextBox1.Text & "/Websites.xml", Application.StartupPath & "/" & "Websites.sync", True)
                ftp.Download("/" & TextBox1.Text & "/History.xml", Application.StartupPath & "/" & "History.sync", True)
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
                ftp.FtpRename("/" & TextBox1.Text & "/Websites.xml", "/" & TextBox1.Text & "/Websites.bak")
                ftp.FtpDelete("/" & TextBox1.Text & "/Websites.bak")
                ftp.FtpRename("/" & TextBox1.Text & "/History.xml", "/" & TextBox1.Text & "/History.bak")
                ftp.FtpDelete("/" & TextBox1.Text & "/History.bak")
                ftp.Upload(Application.StartupPath & "/" & "Websites.xml", "/" & TextBox1.Text & "/Websites.xml")
                ftp.Upload(Application.StartupPath & "/" & "History.xml", "/" & TextBox1.Text & "/History.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.sync")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "Websites.xml.bak")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.sync")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "History.xml.bak")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync completed.", True)

            Else
                EnableTextboxes()
                PictureBox3.Visible = False
                PictureBox1.Visible = True
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync failed. Firing up MsgBox to show possible reasons.", True)
                MsgBox("Error. 2 possible reasons : 1> Account doesn't exist. 2> Password is incorrect.", MsgBoxStyle.Critical, "Error")
                BackgroundWorker1.CancelAsync()
            End If
        Catch ex As Exception
            EnableTextboxes()
            PictureBox3.Visible = False
            PictureBox1.Visible = True
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Failed [!X!] <" & ex.InnerException.ToString & ">", True)
            MsgBox("Fatal error (" & ex.Message & ")", MsgBoxStyle.Critical, "Error")
            BackgroundWorker1.CancelAsync()
        End Try

    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync Started. Connecting to sync host", True)
        Try
            Dim ftp As New FTPclient("demclub.com", "demclubc", "hrjk19tk")
            ftp.FtpCreateDirectory("/" & TextBox4.Text)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> SyncCreateAccount routine is being carried out.", True)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "sync.ps", TextBox3.Text, False)
            ftp.Upload(Application.StartupPath & "/" & "sync.ps", "/" & TextBox4.Text & "/sync.ps")
            ftp.Upload(Application.StartupPath & "/" & "Websites.xml", "/" & TextBox4.Text & "/Websites.xml")
            ftp.Upload(Application.StartupPath & "/" & "History.xml", "/" & TextBox4.Text & "/History.xml")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync over. Account has been created!", True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Sync failed. Looks like the account name exists <" & ex.InnerException.ToString & ">", True)
            MsgBox("Account creation failed. The account already exists, please try a different name. (" & ex.Message & ")", MsgBoxStyle.Critical, "Sync Error")
            BackgroundWorker2.CancelAsync()
            PictureBox2.Visible = True
            PictureBox4.Visible = False
        End Try

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TextBox4.TextLength > 5 And TextBox3.TextLength > 8 Then
            DisableTextboxes()
            PictureBox2.Visible = False
            PictureBox4.Visible = True
            BackgroundWorker2.RunWorkerAsync()
        Else
            EnableTextboxes()
            PictureBox2.Visible = True
            PictureBox4.Visible = False
            BackgroundWorker2.CancelAsync()
            MsgBox("Error. 2 possible reasons : 1> Account name should be more than 5 chars. 2> Password should be more than 8 chars", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.check1
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.check
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If TextBox1.TextLength > 5 And TextBox2.TextLength > 8 Then
            My.Settings.username = TextBox1.Text
            PictureBox3.Visible = True
            BackgroundWorker1.RunWorkerAsync()
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
            PictureBox3.Visible = False
            BackgroundWorker1.CancelAsync()
            MsgBox("Error. 2 possible reasons : 1> Account name should be more than 5 chars. 2> Password should be more than 8 chars", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MsgBox("You account has been successfully created! Login to sync. (If you recieved a error before this message, then this message is a bug.)", MsgBoxStyle.Information, "Sync")
        EnableTextboxes()
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "sync.ps")
        PictureBox2.Visible = True
        PictureBox4.Visible = False
        BackgroundWorker2.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Sync is now complete. (If you recieved a error before this message, then this message is a bug.)", MsgBoxStyle.Information, "Sync")
        EnableTextboxes()
        PictureBox1.Visible = True
        PictureBox3.Visible = False
        BackgroundWorker2.CancelAsync()
    End Sub
    Private Sub Sync_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            TextBox1.Text = My.Settings.username
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

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub Sync_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Panel1.BackColor = My.Settings.headerclr
    End Sub
End Class