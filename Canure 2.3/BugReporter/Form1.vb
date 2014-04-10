Public Class Form1
    Private urlBugReport As String = "https://docs.google.com/spreadsheet/viewform?formkey=dE9MRTYzRWhfMl8tT2ZobVFRM19fUWc6MQ"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(urlBugReport)
    End Sub
End Class
