Imports System.Windows.Forms
Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtext As String
        dtext = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/" & "sol.file")
        RichTextBox1.Text = dtext
    End Sub

    Private Sub RichTextBox1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        MetroForm.WebKitBrowser1.Navigate(e.LinkText)
    End Sub
End Class