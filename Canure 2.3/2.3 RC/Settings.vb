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

        If My.Settings.useJS = True Then
            RadDropDownList2.SelectedIndex = 0
        Else
            RadDropDownList2.SelectedIndex = 1
        End If
        If My.Settings.useJava = True Then
            RadDropDownList3.SelectedIndex = 0
        Else
            RadDropDownList3.SelectedIndex = 1
        End If
        If My.Settings.useplugins = True Then
            RadDropDownList4.SelectedIndex = 0
        Else
            RadDropDownList4.SelectedIndex = 1
        End If
        If My.Settings.enableGrammarCheck = True Then
            RadDropDownList5.SelectedIndex = 0
        Else
            RadDropDownList5.SelectedIndex = 1
        End If
        If My.Settings.EnableAcceleratedCompositing = True Then
            RadDropDownList6.SelectedIndex = 0
        Else
            RadDropDownList6.SelectedIndex = 1
        End If
        If My.Settings.EnableContinousSpellCheck = True Then
            RadDropDownList7.SelectedIndex = 0
        Else
            RadDropDownList7.SelectedIndex = 1
        End If
        If My.Settings.httppipeline = True Then
            RadDropDownList8.SelectedIndex = 0
        Else
            RadDropDownList8.SelectedIndex = 1
        End If
        If My.Settings.NotifyNetworkChange = True Then
            RadDropDownList9.SelectedIndex = 0
        Else
            RadDropDownList9.SelectedIndex = 1
        End If
        If My.Settings.Theme = "Blue" Then
            RadDropDownList10.SelectedIndex = 0
        Else
            RadDropDownList10.SelectedIndex = 1
        End If
        TextBox5.Text = My.Settings.rv_2
        TextBox6.Text = My.Settings.rv_1
        TextBox7.Text = My.Settings.rv_3
        TextBox8.Text = My.Settings.rv_6
        TextBox9.Text = My.Settings.rv_5
        TextBox10.Text = My.Settings.rv_4
        RadSpinEditor1.Value = My.Settings.NotifyNetworkChangeInterval
        If My.Settings.headerclr = SystemColors.MenuHighlight Then
            RadDropDownList1.SelectedIndex = 0
        ElseIf My.Settings.headerclr = Color.Purple Then
            RadDropDownList1.SelectedIndex = 1
        ElseIf My.Settings.headerclr = Color.Magenta Then
            RadDropDownList1.SelectedIndex = 2
        ElseIf My.Settings.headerclr = Color.Red Then
            RadDropDownList1.SelectedIndex = 3
        ElseIf My.Settings.headerclr = Color.DarkOrange Then
            RadDropDownList1.SelectedIndex = 4
        ElseIf My.Settings.headerclr = Color.Silver Then
            RadDropDownList1.SelectedIndex = 5
        ElseIf My.Settings.headerclr = Color.LawnGreen Then
            RadDropDownList1.SelectedIndex = 6
        End If
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

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
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

    Private Sub RadToggleButton2_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
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

    Private Sub RadDropDownList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList2.SelectedIndexChanged
        If RadDropDownList2.SelectedItem.Text = "True" Then
            My.Settings.useJS = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList2.SelectedItem.Text = "False" Then
            My.Settings.useJS = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList3.SelectedIndexChanged
        If RadDropDownList3.SelectedItem.Text = "True" Then
            My.Settings.useJava = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList3.SelectedItem.Text = "False" Then
            My.Settings.useJava = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList4.SelectedIndexChanged
        If RadDropDownList4.SelectedItem.Text = "True" Then
            My.Settings.useplugins = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList4.SelectedItem.Text = "False" Then
            My.Settings.useplugins = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList5.SelectedIndexChanged
        If RadDropDownList5.SelectedItem.Text = "True" Then
            My.Settings.enableGrammarCheck = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList5.SelectedItem.Text = "False" Then
            My.Settings.enableGrammarCheck = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList6.SelectedIndexChanged
        If RadDropDownList6.SelectedItem.Text = "True" Then
            My.Settings.EnableAcceleratedCompositing = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList6.SelectedItem.Text = "False" Then
            My.Settings.EnableAcceleratedCompositing = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList7.SelectedIndexChanged
        If RadDropDownList7.SelectedItem.Text = "True" Then
            My.Settings.EnableContinousSpellCheck = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList7.SelectedItem.Text = "False" Then
            My.Settings.EnableContinousSpellCheck = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadDropDownList8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList8.SelectedIndexChanged
        If RadDropDownList8.SelectedItem.Text = "True" Then
            My.Settings.httppipeline = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList8.SelectedItem.Text = "False" Then
            My.Settings.httppipeline = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        My.Settings.rv_2 = TextBox5.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        My.Settings.rv_1 = TextBox6.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        My.Settings.rv_3 = TextBox7.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        My.Settings.rv_6 = TextBox8.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        My.Settings.rv_5 = TextBox9.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        My.Settings.rv_4 = TextBox10.Text
        My.Settings.sdrequirerecache = True
        My.Settings.Save()
    End Sub

    Private Sub RadDropDownList9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList9.SelectedIndexChanged
        If RadDropDownList9.SelectedItem.Text = "True" Then
            My.Settings.NotifyNetworkChange = True
            My.Settings.Save()
            MetroForm.LoadPrefs()
        ElseIf RadDropDownList9.SelectedItem.Text = "False" Then
            My.Settings.NotifyNetworkChange = False
            My.Settings.Save()
            MetroForm.LoadPrefs()
        End If
    End Sub

    Private Sub RadSpinEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSpinEditor1.ValueChanged
        My.Settings.NotifyNetworkChangeInterval = RadSpinEditor1.Value
        My.Settings.Save()
        MetroForm.LoadPrefs()
    End Sub

    Private Sub RadDropDownList10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList10.SelectedIndexChanged
        If RadDropDownList10.SelectedItem.Text = "Blue" Then
            My.Settings.Theme = "Blue"
            My.Settings.Save()
            MetroForm.ApplyOverallTheme()
        ElseIf RadDropDownList10.SelectedItem.Text = "Green" Then
            My.Settings.Theme = "Green"
            My.Settings.Save()
            MetroForm.ApplyOverallTheme()
        End If
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged
        ApplyHeaderTheme()
    End Sub

    Private Sub RadButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton5.Click
        InstallUIFonts()
    End Sub

    Public Sub InstallUIFonts()
        Try
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo.FileName = Application.StartupPath & "/" & "fontinstaller.exe"
            proc.StartInfo.Verb = "runas"
            proc.Start()
        Catch ex As Exception : End Try
    End Sub
End Class