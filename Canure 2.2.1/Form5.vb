Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the icon
        Me.Icon = Form1.Icon
    End Sub

    Private Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        'Restart canure
        Application.Restart()
    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink2.Click
        'Exit the window
        Me.Dispose()
    End Sub
End Class