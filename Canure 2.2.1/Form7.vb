Public Class Form7
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'WARNING : Because our servers are under-development, we are removing the CheckForUpdate() function call. This is an bogus function
        Label2.Visible = True
        PictureBox3.Visible = False
        Timer1.Enabled = False
    End Sub
    Private Sub Form7_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Start the update check
        Timer1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Open the website
        System.Diagnostics.Process.Start("http://www.blixcorp.com/")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'Open the website of Canure
        System.Diagnostics.Process.Start("http://www.canure.weebly.com/")
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        'Open the sourceforge project page of Canure
        System.Diagnostics.Process.Start("http://sourceforge.net/projects/canure/")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'Open the license
        Form10.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Join page is under development, so an detour to handle that
        MsgBox("Sorry but Canure recieved a #Under Maintainence# message from <JOIN_SVR_ADRS>.", MsgBoxStyle.Exclamation, "Error")
    End Sub
End Class