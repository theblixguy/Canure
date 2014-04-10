Imports System.Drawing
Imports System.Windows.Forms

Public Class Settings
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim isRestartRequired As Boolean = False
    Dim base64EncryptedString As String
    Dim decryptedData As Encryption.Data
    Private Sub ApplyHeaderTheme()
        If RadDropDownList1.SelectedItem.Text = "Blue" Then
            MetroForm.Panel2.BackColor = SystemColors.MenuHighlight
            My.Settings.headerclr = SystemColors.MenuHighlight
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Purple" Then
            MetroForm.Panel2.BackColor = Color.Purple
            My.Settings.headerclr = Color.Purple
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Pink" Then
            MetroForm.Panel2.BackColor = Color.Magenta
            My.Settings.headerclr = Color.Magenta
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Red" Then
            MetroForm.Panel2.BackColor = Color.Red
            My.Settings.headerclr = Color.Red
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Orange" Then
            MetroForm.Panel2.BackColor = Color.DarkOrange
            My.Settings.headerclr = Color.DarkOrange
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Silver" Then
            MetroForm.Panel2.BackColor = Color.Silver
            My.Settings.headerclr = Color.Silver
            My.Settings.Save()
        ElseIf RadDropDownList1.SelectedItem.Text = "Green" Then
            MetroForm.Panel2.BackColor = Color.LawnGreen
            My.Settings.headerclr = Color.LawnGreen
            My.Settings.Save()
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Changed header color to <" & MetroForm.Panel2.BackColor.ToArgb & ">", True)
    End Sub

    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
    End Sub


    Private Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox3.Text = My.Settings.useragent
        Try
            RadTrackBar1.Value = CInt(My.Settings.bpaorefreshrate)
        Catch ex As Exception : End Try
        RadTitleBar1.Text = "Settings"
        RadLabel1.Text = My.Settings.hdrthinstripclr.ToString
        RadLabel2.Text = My.Settings.qkacessmenu.ToString
        If My.Settings.showbpaostartup = True Then
            RadToggleButton1.IsChecked = True
        Else
            RadToggleButton1.IsChecked = False
        End If
        If My.Settings.solcentre = True Then
            RadToggleButton2.IsChecked = True
        Else
            RadToggleButton2.IsChecked = False
        End If
        RadTextBox1.Text = My.Settings.syncusername
        RadTextBox2.Text = My.Settings.syncpassword
        RadTextBox3.Text = My.Settings.syncftpserver

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

    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        My.Settings.useragent = TextBox3.Text
        My.Settings.Save()
    End Sub


    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplyHeaderTheme()
        MetroForm.WebKitBrowser1.UserAgent = My.Settings.useragent
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        ApplyHeaderTheme()
        MetroForm.WebKitBrowser1.UserAgent = My.Settings.useragent
    End Sub

    Private Sub RadTrackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadTrackBar1.ValueChanged
        Try
            Dim val As Integer
            val = RadTrackBar1.Value
            My.Settings.bpaorefreshrate = val
            My.Settings.Save()
        Catch ex As Exception : End Try
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        If RadCheckBox1.Checked = CheckState.Checked Then
            My.Settings.ExpandURLWhenHover = True
            My.Settings.Save()
            MetroForm.ExpandURLWhenHover = True
        ElseIf RadCheckBox1.Checked = CheckState.Unchecked Then
            My.Settings.ExpandURLWhenHover = False
            My.Settings.Save()
            MetroForm.ExpandURLWhenHover = False
        End If
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        RadColorDialog1.ShowDialog()
        RadLabel1.Text = My.Settings.hdrthinstripclr.ToString
        My.Settings.hdrthinstripclr = RadColorDialog1.SelectedColor
        My.Settings.Save()
        isRestartRequired = True
    End Sub

    Private Sub RadButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton4.Click
        RadColorDialog2.ShowDialog()
        My.Settings.qkacessmenu = RadColorDialog2.SelectedColor
        My.Settings.Save()
        RadLabel2.Text = My.Settings.qkacessmenu.ToString
        isRestartRequired = True
    End Sub

    Private Sub RadToggleButton1_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadToggleButton1.ToggleStateChanged
        If RadToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
            My.Settings.showbpaostartup = True
            My.Settings.Save()
        ElseIf RadToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
            My.Settings.showbpaostartup = False
            My.Settings.Save()
        End If
        isRestartRequired = True
    End Sub

    Private Sub RadToggleButton2_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadToggleButton2.ToggleStateChanged
        If RadToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
            My.Settings.solcentre = True
            My.Settings.Save()
        ElseIf RadToggleButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
            My.Settings.solcentre = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        My.Settings.syncusername = RadTextBox1.Text
        My.Settings.syncpassword = Encrypt(RadTextBox2.Text)
        My.Settings.syncftpserver = RadTextBox3.Text
        My.Settings.Save()
    End Sub

    Public Function Encrypt(ByVal dText As String) As String
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
        Dim key As New Encryption.Data("synclock")
        Dim encryptedData As Encryption.Data
        encryptedData = sym.Encrypt(New Encryption.Data(dText), key)
        base64EncryptedString = encryptedData.ToBase64
        Return base64EncryptedString
    End Function

    Public Function Decrypt(ByVal eText As String) As String
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
        Dim key As New Encryption.Data("synclock")
        Dim encryptedData As New Encryption.Data
        encryptedData.Base64 = base64EncryptedString
        decryptedData = sym.Decrypt(encryptedData, key)
        Return decryptedData.ToString
    End Function

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        My.Settings.homepage = TextBox4.Text
        My.Settings.Save()
    End Sub
End Class