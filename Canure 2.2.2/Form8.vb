Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the icon
        Me.Icon = Form1.Icon
    End Sub

    Private Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        'Disable the selected option because the user has selected it
        CommandLink1.Enabled = False
    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink2.Click
        'Disable the selected option because the user has selected it
        CommandLink2.Enabled = False
    End Sub

    Private Sub CommandLink3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink3.Click
        'Disable the selected option because the user has selected it
        CommandLink3.Enabled = False
    End Sub

    Private Sub CommandLink4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink4.Click
        'Perform Reset!
        If CommandLink1.Enabled = False Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "History.xml", "", False)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "Websites.xml", "", False)
        End If
        If CommandLink2.Enabled = False Then
            My.Settings.aero = True
            My.Settings.googleins = False
            My.Settings.homepg = "http://www.google.com"
            My.Settings.hpage = True
            My.Settings.tabrec = False
            My.Settings.cboxclr = SystemColors.Control
            My.Settings.tabclr = Color.LightSteelBlue
            My.Settings.Save()
        End If
        If CommandLink3.Enabled = False Then
            Application.Restart()
        End If
        Me.Dispose()
    End Sub
End Class