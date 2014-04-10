Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class NewTabPage
    Dim p19 As New PictureBox
    Dim p20 As New PictureBox
    Dim p1 As New PictureBox
    Dim p2 As New PictureBox
    Dim p23 As New PictureBox
    Dim p24 As New PictureBox
    Dim strNxt As String
    Dim ScreenshotSnapURL As String = "http://do.convertapi.com/web2image?curl="
    Dim thisproc As New Process
    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        PictureBox28.Image = My.Resources.button_clicked
    End Sub

    Private Sub PictureBox28_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.DragLeave
        PictureBox28.Image = My.Resources.button_normal
    End Sub

    Private Sub PictureBox28_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.LostFocus
        PictureBox28.Image = My.Resources.button_normal
    End Sub

    Private Sub PictureBox28_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox28.MouseClick
        If e.Button.Left Then
            MetroForm.WebKitBrowser1.Navigate("http://www.google.com/search?q=" & TextBox3.Text)
            Me.Dispose()
        End If
    End Sub

    Private Sub PictureBox28_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.MouseEnter
        PictureBox28.Image = My.Resources.button_hover
    End Sub

    Private Sub PictureBox28_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.MouseLeave
        PictureBox28.Image = My.Resources.button_normal
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.MouseClick
        MsgBox("Feature not yet implemented", MsgBoxStyle.Critical, "ERROR:FEATURE_NOT_IMPLEMENTED")
    End Sub

    Private Sub Label21_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label21.MouseEnter
        Label21.ForeColor = Color.Silver
    End Sub

    Private Sub Label21_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label21.MouseLeave
        Label21.ForeColor = Color.White
    End Sub

    Private Sub BackgroundWorker6_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        PictureBox4.Visible = False
        PictureBox3.Visible = True
        If My.Settings.sdrequirerecache = True Then
            Dim filepaths As String() = Directory.GetFiles(Application.StartupPath & "/" & "SpeedDialCache" & "/")
            For Each filePath As String In filepaths
                File.Delete(filePath)
            Next
            Label20.Text = "speed dial (generating thumbnails..)"
            p19.ImageLocation = ScreenshotSnapURL & My.Settings.rv_2
            p20.ImageLocation = ScreenshotSnapURL & My.Settings.rv_1
            p1.ImageLocation = ScreenshotSnapURL & My.Settings.rv_3
            p2.ImageLocation = ScreenshotSnapURL & My.Settings.rv_6
            p23.ImageLocation = ScreenshotSnapURL & My.Settings.rv_5
            p24.ImageLocation = ScreenshotSnapURL & My.Settings.rv_4
            p19.Load()
            p20.Load()
            p1.Load()
            p2.Load()
            p23.Load()
            p24.Load()
        Else
            p19.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv1.jpg"
            p20.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv2.jpg"
            p1.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv3.jpg"
            p2.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv4.jpg"
            p23.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv5.jpg"
            p24.ImageLocation = Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv6.jpg"
            p19.Load()
            p20.Load()
            p1.Load()
            p2.Load()
            p23.Load()
            p24.Load()
        End If
    End Sub

    Private Sub BackgroundWorker6_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker6.RunWorkerCompleted
        If My.Settings.sdrequirerecache = True Then
            Label20.Text = "speed dial (saving thumbnail to cache..)"
            PictureBox20.Image = p20.Image
            PictureBox19.Image = p19.Image
            PictureBox1.Image = p1.Image
            PictureBox2.Image = p2.Image
            PictureBox23.Image = p23.Image
            PictureBox24.Image = p24.Image
            p20.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            p19.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            p1.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            p2.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv4.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            p23.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            p24.Image.Save(Application.StartupPath & "/" & "SpeedDialCache" & "/" & "rv6.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            My.Settings.sdrequirerecache = False
            My.Settings.Save()
        Else
            PictureBox20.Image = p20.Image
            PictureBox19.Image = p19.Image
            PictureBox1.Image = p1.Image
            PictureBox2.Image = p2.Image
            PictureBox23.Image = p23.Image
            PictureBox24.Image = p24.Image
        End If
        Label20.Text = "speed dial"
        PictureBox4.Visible = True
        PictureBox3.Visible = False
        p20.Dispose()
        p19.Dispose()
        p1.Dispose()
        p2.Dispose()
        p23.Dispose()
        p24.Dispose()
        GC.Collect()
    End Sub

    Private Sub NewTabPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BackgroundWorker6.RunWorkerAsync()
        Timer4.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Size = MetroForm.WebKitBrowser1.Size
        Me.Location = MetroForm.WebKitBrowser1.Location
        thisproc = System.Diagnostics.Process.GetCurrentProcess()
        Dim a As DateTime
        Dim b As DateTime
        Dim c As TimeSpan
        a = DateTime.Now
        b = thisproc.StartTime
        c = a - b
        Label1.Text = "You've been browsing the web since " & c.Hours & " hrs " & c.Minutes & " mins " & c.Seconds & " secs"
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_1)
        Me.Dispose()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_2)
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_3)
        Me.Dispose()
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_4)
        Me.Dispose()
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_5)
        Me.Dispose()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MetroForm.WebKitBrowser1.Navigate(My.Settings.rv_6)
        Me.Dispose()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        My.Settings.sdrequirerecache = True
        BackgroundWorker6.RunWorkerAsync()
    End Sub
End Class
