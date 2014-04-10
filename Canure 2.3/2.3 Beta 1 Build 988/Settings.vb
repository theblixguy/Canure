Imports System.Drawing
Imports System.Windows.Forms

Public Class Settings
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub ApplyHeaderTheme()
        If ComboBox1.SelectedItem = "Blue" Then
            MetroForm.Panel2.BackColor = SystemColors.MenuHighlight
            My.Settings.headerclr = SystemColors.MenuHighlight
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Purple" Then
            MetroForm.Panel2.BackColor = Color.Purple
            My.Settings.headerclr = Color.Purple
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Pink" Then
            MetroForm.Panel2.BackColor = Color.Magenta
            My.Settings.headerclr = Color.Magenta
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Red" Then
            MetroForm.Panel2.BackColor = Color.Red
            My.Settings.headerclr = Color.Red
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Orange" Then
            MetroForm.Panel2.BackColor = Color.DarkOrange
            My.Settings.headerclr = Color.DarkOrange
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Silver" Then
            MetroForm.Panel2.BackColor = Color.Silver
            My.Settings.headerclr = Color.Silver
            My.Settings.Save()
        ElseIf ComboBox1.SelectedItem = "Green" Then
            MetroForm.Panel2.BackColor = Color.LawnGreen
            My.Settings.headerclr = Color.LawnGreen
            My.Settings.Save()
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Changed header color to <" & MetroForm.Panel2.BackColor.ToArgb & ">", True)
    End Sub

    Private Sub Label11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseDown
        Panel18.BackColor = Color.Silver
    End Sub

    Private Sub Label11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseEnter
        Panel18.BackColor = Color.DarkGray
    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseLeave
        Panel18.BackColor = Color.Black
    End Sub

    Private Sub Label11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseUp
        Panel18.BackColor = Color.DarkGray
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        ApplyHeaderTheme()
    End Sub

    Private Sub Settings_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Settings_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Settings_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.DimGray
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.Black
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class