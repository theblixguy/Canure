﻿Imports System.Runtime.InteropServices
Imports System
Imports System.Windows.Forms

Public Class Form4
    Private _mousedown As Boolean
    Private _mousepos As Drawing.Point
    Private _mousedown1 As Boolean
    Private _mousepos1 As Drawing.Point
    Dim Ntp As New NewTabPage
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
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        _mousedown = True
        _mousepos = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If _mousedown Then
            Me.Panel1.Location = PointToClient(Me.Panel1.PointToScreen(New Drawing.Point(e.X -
      _mousepos.X, e.Y - _mousepos.Y)))
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        _mousedown = False
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        _mousedown1 = True
        _mousepos1 = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If _mousedown1 Then
            Me.Panel2.Location = PointToClient(Me.Panel2.PointToScreen(New Drawing.Point(e.X -
      _mousepos1.X, e.Y - _mousepos1.Y)))
        End If
    End Sub

    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        _mousedown1 = False
    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        _mousedown1 = True
        _mousepos1 = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If _mousedown1 Then
            Me.Panel3.Location = PointToClient(Me.Panel3.PointToScreen(New Drawing.Point(e.X -
      _mousepos1.X, e.Y - _mousepos1.Y)))
        End If
    End Sub

    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        _mousedown1 = False
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form3.Show()
        Form3.Location = MetroForm.Location
        Form3.Size = MetroForm.Size
        Dim frm2 As New Form2
        frm2.Left = CInt(MetroForm.Left + ((MetroForm.Width - frm2.Width) / 2))
        frm2.Top = CInt(MetroForm.Top + ((MetroForm.Height - frm2.Height) / 2))
        frm2.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        MetroForm.PictureBox8.Enabled = True
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        MetroForm.PictureBox8.Enabled = True
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Animating window using the Animate API", True)
        Dim f2 As New Favorites
        AnimateWindow(f2.Handle, 1000, AnimateWindowFlags.AW_BLEND)
        f2.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MetroForm.PictureBox8.Enabled = True
        Dim f3 As New Sync
        AnimateWindow(f3.Handle, 1000, AnimateWindowFlags.AW_BLEND)
        f3.Show()
    End Sub

    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        _mousedown1 = True
        _mousepos1 = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        If _mousedown1 Then
            Me.Panel4.Location = PointToClient(Me.Panel4.PointToScreen(New Drawing.Point(e.X -
      _mousepos1.X, e.Y - _mousepos1.Y)))
        End If
    End Sub

    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseUp
        _mousedown1 = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Try
            Me.Hide()
            MetroForm.PictureBox8.Enabled = True
            Shell(Application.StartupPath & "/" & "bugrpt.exe")
        Catch ex As Exception
            MsgBox("Cannot find the bug reporter executable. Please make sure it's present in Canure's folder.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Panel5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseDown
        _mousedown1 = True
        _mousepos1 = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove
        If _mousedown1 Then
            Me.Panel5.Location = PointToClient(Me.Panel5.PointToScreen(New Drawing.Point(e.X -
      _mousepos1.X, e.Y - _mousepos1.Y)))
        End If
    End Sub

    Private Sub Panel5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseUp
        _mousedown1 = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Hide()
        MetroForm.PictureBox8.Enabled = True
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Animating window using the Animate API", True)
        Dim f4 As New History
        AnimateWindow(f4.Handle, 1000, AnimateWindowFlags.AW_BLEND)
        f4.Show()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Hide()
        MetroForm.PictureBox8.Enabled = True
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Animating window using the Animate API", True)
        Dim f5 As New Settings
        AnimateWindow(f5.Handle, 1000, AnimateWindowFlags.AW_BLEND)
        f5.Show()

    End Sub

    Private Sub Panel6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseDown
        _mousedown1 = True
        _mousepos1 = New Drawing.Point(e.X, e.Y)
    End Sub

    Private Sub Panel6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseMove
        If _mousedown1 Then
            Me.Panel6.Location = PointToClient(Me.Panel6.PointToScreen(New Drawing.Point(e.X -
      _mousepos1.X, e.Y - _mousepos1.Y)))
        End If
    End Sub

    Private Sub Panel6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseUp
        _mousedown1 = False
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        MetroForm.WebKitBrowser1.IncreaseZoom()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        MetroForm.WebKitBrowser1.DecreaseZoom()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        If RadButton2.Text = "Show" Then
            MetroForm.WebKitBrowser1.Stop()
            Ntp.Location = MetroForm.WebKitBrowser1.Location
            Ntp.Size = MetroForm.WebKitBrowser1.Size
            MetroForm.Controls.Add(Ntp)
            Ntp.Visible = True
            Ntp.BringToFront()
            MetroForm.PictureBox8.Enabled = True
            Me.Hide()
            RadButton2.Text = "Hide"
        ElseIf RadButton2.Text = "Hide" Then
            Try
                MetroForm.Controls.Remove(Ntp)
            Catch ex As Exception : End Try
            RadButton2.Text = "Show"
        End If
    End Sub

    Private Sub RadButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton4.Click
        If MetroForm.WebKitBrowser1.IsBusy = False Then
            MetroForm.TextBox2.Text = shop.BLL.Utility.GoogleUrlShortnerApi.Shorten(MetroForm.WebKitBrowser1.Url.AbsoluteUri)
            MetroForm.Panel7.BackColor = MetroForm.Panel2.BackColor
            MetroForm.Panel7.Visible = True
            Me.Hide()
        Else
            Me.Hide()
            MsgBox("Canure is currently busy loading and rendering the current page and it's resources. Try again when loading is completed.", MsgBoxStyle.Information, "Shorten URL")
        End If
    End Sub

    Private Sub RadButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton5.Click
        Me.Hide()
        MetroForm.WebKitBrowser1.ShowPrintDialog()
    End Sub

    Private Sub RadButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton6.Click
        Me.Hide()
        MetroForm.WebKitBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub RadButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton7.Click
        Me.Hide()
        MetroForm.WebKitBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub RadButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton8.Click
        Me.Hide()
        MetroForm.WebKitBrowser1.ShowDownloader()
    End Sub
End Class