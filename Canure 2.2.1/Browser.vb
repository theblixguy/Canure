Imports System.Xml

Public Class Browser
    'Declare the variables that we need
    Dim curl As String
    Dim fcio As Bitmap
    Dim urlf As String
    Private Sub NewTabToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem1.Click
        'Creaes a new tab
        Dim brw As New Browser
        brw.WebKitBrowser1.DocumentText = My.Resources.new_page
        brw.ToolStrip1.BackColor = My.Settings.cboxclr
        Form1.PageCollection1.Add(New TabPages.TabPage("New Tab", brw))
    End Sub
    Private Sub ToolStripComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripComboBox1.KeyDown
        'Checks the keystrockes that user fired
        If (e.Control = True And e.KeyCode = Keys.Enter) Then
            'Control + Enter, that means navigate to .com URL
            Dim strnav1 As String
            strnav1 = ToolStripComboBox1.Text
            WebKitBrowser1.Navigate("http://www." & strnav1 & ".com")
        ElseIf e.KeyCode = Keys.Enter Then
            'Enter, that means simple naviate
            Dim strnav As String
            strnav = ToolStripComboBox1.Text
            Me.WebKitBrowser1.Navigate(strnav)
            'Add the URL to URL box
            ToolStripComboBox1.Items.Add(strnav)
            'Check if user is trying to open a special page
            If ToolStripComboBox1.Text = "about:plugins" Then 'Plugins page
                WebKitBrowser1.DocumentText = My.Resources.abtplgins
            ElseIf ToolStripComboBox1.Text = "about:credits" Then 'Credits page
                WebKitBrowser1.DocumentText = My.Resources.abt_credits
            End If
        End If
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        'Close a tab
        Form1.PageCollection1.Remove(Form1.PageCollection1.CurrentPage)
    End Sub

    Private Sub WebKitBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        'Updates the status of webpage
        ToolStripComboBox1.Text = e.Url.ToString
        urlf = e.Url.ToString
        ToolStripButton3.Enabled = True
        Form1.PageCollection1.CurrentPage.Text = Me.WebKitBrowser1.DocumentTitle
        Form1.PageCollection1.Refresh()
        stat.Text = "Done"
        If PrivateBrowsingToolStripMenuItem.Checked = False Then
            SaveHistory()
        End If
    End Sub
    Private Sub WebKitBrowser1_Error(ByVal sender As Object, ByVal e As WebKit.WebKitBrowserErrorEventArgs)
        'Shit, an error
        WebKitBrowser1.DocumentText = My.Resources.Err
        stat.Text = "Done"
    End Sub

    Private Sub WebKitBrowser1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Refresh the page
        If e.KeyCode = Keys.F5 Then
            WebKitBrowser1.Refresh()
        End If
    End Sub
    Private Sub WebKitBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs)
        'Updates the status of the webpage
        stat.Text = "Navigating to : " & e.Url.Host
        If e.Url.Scheme = Uri.UriSchemeHttps Then
            ToolStripComboBox1.BackColor = Color.LightGreen
        Else
            ToolStripComboBox1.BackColor = Color.White
        End If

        urlf = e.Url.Host
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub WebKitBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
        'COnnecting to the webpage
        stat.Text = "Connecting to : " & e.Url.Host
        ToolStripButton3.Enabled = False
    End Sub
    Private Sub ToolStripComboBox1_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.TextUpdate
        'Fire up Google Instant (our way!)
        If My.Settings.googleins = True Then
            WebKitBrowser1.Navigate("http://www.google.com/search?hl=en&source=hp&q=" & ToolStripComboBox1.Text.ToString)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Go back in history
        WebKitBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'Go forward in history
        WebKitBrowser1.GoForward()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        'Open a new window (Beware, a bug in-here!)
        Dim a As New Form1
        a.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Show PrintDialog
        WebKitBrowser1.ShowPrintDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'Show PrintPreview Dialog
        WebKitBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'Save the webpage stream
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, WebKitBrowser1.DocumentText, False)
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'Open a webpage for viewing
        Dim src As String
        src = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        WebKitBrowser1.DocumentText = src
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Fire up the SaveWebpage box
        SaveFileDialog1.ShowDialog()
    End Sub
    Private Sub FavoritesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesToolStripMenuItem.Click
        'Show the favorites box
        Favorites.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        'Show the history box
        History.Show()
    End Sub
    Private Sub SaveHistory()
        'Here, we save history data
        With lvwWebSites.Items.Add(WebKitBrowser1.DocumentTitle)
            .SubItems.Add(urlf)
        End With

        Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "History.xml", System.Text.Encoding.UTF8)
        With wtrXML
            .Formatting = Formatting.Indented
            .WriteStartDocument()
            .WriteStartElement("Histories")
            Dim objListViewItem As New ListViewItem
            For Each objListViewItem In lvwWebSites.Items
                .WriteStartElement("History")
                .WriteElementString("Name", objListViewItem.Text)
                .WriteElementString("URL", objListViewItem.SubItems(1).Text)
                .WriteEndElement()
            Next
            .WriteEndElement()
            .WriteEndDocument()
            .Flush()
            .Close()
        End With
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'Add and favorite
        Favorites.Show()
        Favorites.txtURL.Text = WebKitBrowser1.Url.ToString
        Favorites.txtWebSite.Text = WebKitBrowser1.DocumentTitle
    End Sub
    Private Sub ReportABugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportABugToolStripMenuItem.Click
        'Show the bug-report box
        Form6.Show()
    End Sub

    Private Sub ABoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABoutToolStripMenuItem.Click
        'Show the about box
        Form7.Show()
    End Sub

    Private Sub ResetCanureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCanureToolStripMenuItem.Click
        'Show the Reset Canure box
        Form8.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Input website address into ToolStripComboBox1
        Try
            ' Get the URL of the favicon
            ' url.Host will return such string as www.google.com
            Dim iconURL = "http://" & urlf & "/favicon.ico"

            ' Download the favicon
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim stream As System.IO.Stream = response.GetResponseStream()
            Dim favicon = Image.FromStream(stream)

            ' Display the favicon
            fcio = favicon

        Catch ex As Exception : End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Got the favicon!
        On Error Resume Next
        ToolStripLabel1.Image = fcio
    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click
        'hides the URL so user can type easily
        curl = ToolStripComboBox1.Text
        ToolStripComboBox1.Text = Nothing
    End Sub

    Private Sub ToolStripComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.LostFocus
        'unhides the previous URL
        ToolStripComboBox1.Text = curl
    End Sub
    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        'Vanish Canure :D
        Form1.Visible = False
        Form1.ShowInTaskbar = False
        Form1.NotifyIcon1.Visible = True
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        'Stop navigation
        WebKitBrowser1.Stop()
    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem.Click
        'Fire up the view source box
        Form2.Show()
        'Set the labguage
        Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html
        'Set the source of the webpage
        Form2.TextEditor1.Text = WebKitBrowser1.DocumentText
    End Sub

    Private Sub DeveloperToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeveloperToolsToolStripMenuItem.Click
        'SHow the Dev Tools
        Form2.Show()
        Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Open the open dialog
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub WebpageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebpageToolStripMenuItem.Click
        'Open the open dialog to select an webpage to open
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub MediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaToolStripMenuItem.Click
        'Open the open dialog to select an media to open
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub PageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageToolStripMenuItem.Click
        'Working here
    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        'Navigate to the media
        WebKitBrowser1.Navigate("file:\\\" & OpenFileDialog2.FileName)
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        'Cut the text in URL box
        ToolStripComboBox1.SelectedText.Remove(ToolStripComboBox1.SelectionStart, ToolStripComboBox1.SelectionLength)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'Copy the URL to CLipboard
        Clipboard.SetText(ToolStripComboBox1.Text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        'Paste the text
        ToolStripComboBox1.Text = Clipboard.GetText
    End Sub

    Private Sub PasteGoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteGoToolStripMenuItem.Click
        'Paste the URL and then navigate to it
        ToolStripComboBox1.Text = Clipboard.GetText
        WebKitBrowser1.Navigate(Clipboard.GetText)
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        'Select the whole URL
        ToolStripComboBox1.SelectAll()
    End Sub

    Private Sub ToolStripComboBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripComboBox1.MouseDown
        'Show the URL Context menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip2.Show(Parent.PointToScreen(e.Location))
        End If
    End Sub

    Private Sub ToolStripButton4_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.ButtonClick
        'Fire up the Settings window
        Form4.Show()
    End Sub
End Class
