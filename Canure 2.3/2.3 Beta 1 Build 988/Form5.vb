Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        My.Settings.datasend = True
        My.Settings.Save()
        Me.ControlBox = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button1.Enabled = True
        My.Settings.datasend = False
        My.Settings.Save()
        Me.ControlBox = True
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class