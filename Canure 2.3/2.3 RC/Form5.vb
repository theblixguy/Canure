Public Class Form5

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        RadButton1.Enabled = False
        RadButton2.Enabled = True
        My.Settings.datasend = True
        My.Settings.Save()
        Me.ControlBox = True
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        RadButton2.Enabled = False
        RadButton1.Enabled = True
        My.Settings.datasend = False
        My.Settings.Save()
        Me.ControlBox = True
    End Sub
End Class