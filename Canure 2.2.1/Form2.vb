
Public Class Form2
    Private Sub ChangeLanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLanguageToolStripMenuItem.Click
        'Pop up the change language box
        Form3.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Fire up the open file box
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'You selected an file, but what's the language? Autodetect!
        TextEditor1.AutomaticLanguageDetection = True
        TextEditor1.Open(OpenFileDialog1.FileName)
        TextEditor1.ReloadFile()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'Copy text
        TextEditor1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        'Paste text
        TextEditor1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        'Undo 
        TextEditor1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        'Redo
        TextEditor1.Redo()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit the window
        Me.Dispose()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Pop up the save box
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'Lets save the file
        Dim svsrc As String
        svsrc = TextEditor1.Text
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, svsrc, False)
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        'Lets debug the webpage
        If TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html Or TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.CSS Or TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.JavaScript Then
            'You selected an vliad language (HTML, CSS, JS)
            Dim src As String
            src = TextEditor1.Text
            'Create an debug window and open the page
            CreateTestWindow(src)
        Else
            'Invalid language
            Dim lng As String = TextEditor1.CurrentLanguage

            'notify the user that you are using an invalid language
            MsgBox(lng & " codes cannot be evaulated. Please use a different IDE to evaluate the code.", MsgBoxStyle.Exclamation, "Language not Supported")
        End If
    End Sub

    Private Sub CreateTestWindow(ByVal code As String)
        '// Create objects that we need
        Dim twin As New Form
        Dim wbrw As New WebKit.WebKitBrowser
        '// Window Properties
        twin.ShowInTaskbar = False
        twin.ShowIcon = False
        twin.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        twin.Size = New Size(800, 500)
        twin.Text = "Webpage Debug Window - Developer Tools"
        twin.Controls.Add(wbrw)
        wbrw.Dock = DockStyle.Fill
        '// Execute the code
        twin.Show()
        wbrw.DocumentText = code
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Perform startup tasks
        TextEditor1.AutomaticLanguageDetection = False
        TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html
        'Set the icon of the window
        Me.Icon = Form1.Icon
    End Sub
End Class