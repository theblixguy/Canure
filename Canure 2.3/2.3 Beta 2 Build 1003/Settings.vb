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
        MetroForm.WebKitBrowser1.UserAgent = My.Settings.useragent

    End Sub

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox3.Text = My.Settings.useragent
        TextBox4.Text = My.Settings.bpaorefreshrate
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            My.Settings.ExpandURLWhenHover = True
            My.Settings.Save()
            MetroForm.ExpandURLWhenHover = True
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            My.Settings.ExpandURLWhenHover = False
            My.Settings.Save()
            MetroForm.ExpandURLWhenHover = False
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim adrs As String '// Allocates variable to store the URL
            adrs = TextBox1.Text '// Gives the variable the value of the specified URL in the function
            If adrs.Contains("https://") Then
                MsgBox("CheckIfHTTPS() returns 0x00, IS_HTTPS_TRUE", MsgBoxStyle.Information, "CheckIfHTTPS")
            Else
                MsgBox("CheckIfHTTPS() returns 0x01, IS_HTTPS_FALSE", MsgBoxStyle.Information, "CheckIfHTTPS")
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MetroForm.UrlIsValid(TextBox2.Text) = True Then
                MsgBox("IsValidURL() returns 0x00, HOST_EXISTS", MsgBoxStyle.Information, "IsValidURL")
            Else
                MsgBox("IsValidURL() returns 0x01, HOST_EXISTS_FALSE", MsgBoxStyle.Information, "IsValidURL")
            End If
        End If
    End Sub
    

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub Settings_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(New Drawing.Pen(Drawing.Color.Black), New Drawing.Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
        GC.Collect()
    End Sub

    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
       
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        My.Settings.useragent = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        My.Settings.bpaorefreshrate = TextBox1.Text
        My.Settings.Save()
    End Sub
End Class