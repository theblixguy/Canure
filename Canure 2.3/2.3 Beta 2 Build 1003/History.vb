'Lets import the required things
Imports System.Xml, System.Text
Imports System.Windows.Forms


Public Class History

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean

    'Here goes the main function that controls the Load or Save of history

    Private Sub History(ByVal LoadOrSave As Boolean)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> History window fired. Loading history.", True)
        Try
            Select Case LoadOrSave

                Case True 'Load
                    Try
                        lvwWebSites.Items.Clear()
                        Dim rdrXML As New XmlTextReader(My.Application.Info.DirectoryPath & "\" & "History.xml")
                        rdrXML.MoveToContent()
                        Dim ElementName As String = ""
                        Dim NextItem As Boolean = True
                        Dim objListViewItem As ListViewItem = Nothing
                        Do While rdrXML.Read
                            If NextItem Then
                                objListViewItem = New ListViewItem
                                NextItem = False
                            End If
                            Select Case rdrXML.NodeType
                                Case XmlNodeType.Element
                                    ElementName = rdrXML.Name
                                Case XmlNodeType.Text
                                    If ElementName = "Name" Then
                                        objListViewItem.Text = rdrXML.Value
                                    End If
                                    If ElementName = "URL" Then
                                        objListViewItem.SubItems.Add(rdrXML.Value)
                                        lvwWebSites.Items.Add(objListViewItem)
                                        NextItem = True
                                    End If
                            End Select
                        Loop
                        rdrXML.Close()
                    Catch ex As Exception
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading history data failed! <" & ex.ToString & ">", True)
                    End Try
                Case False 'Save

                    Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "History.xml", System.Text.Encoding.UTF8)
                    With wtrXML
                        .Formatting = Formatting.Indented
                        .WriteStartDocument()
                        .WriteStartElement("WebSites")
                        Dim objListViewItem As New ListViewItem
                        For Each objListViewItem In lvwWebSites.Items
                            .WriteStartElement("WebSite")
                            .WriteElementString("Name", objListViewItem.Text)
                            .WriteElementString("URL", objListViewItem.SubItems(1).Text)
                            .WriteEndElement()
                        Next
                        .WriteEndElement()
                        .WriteEndDocument()
                        .Flush()
                        .Close()

                    End With
            End Select
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while handling unknown routine ??? <" & ex.InnerException.ToString & ">", True)
        End Try

    End Sub

    Private Sub History_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Disposing history window handle (to avoid lock)", True)
        CloseHandle(Me.Handle)
    End Sub

    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading history data [History::Load]", True)
            'Lets try load the favorite data
            History(True)
        Catch ex As Exception
            'Oops, an error occured. Pop up an box to notify the user
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading history data failed <" & ex.InnerException.ToString & ">", True)
            MsgBox("The history data failed to load [" & ex.Message & "]", MsgBoxStyle.Exclamation, "Load Error")
            'Create an new history file so this doesn't occur next time
            IO.File.Create(Application.StartupPath & "/" & "History.xml")
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Remove the history
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
        'Save the changes
        History(False)
    End Sub


 

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Saving history item as favorite", True)
        Try
            Dim wbname As String
            Dim wburl As String
            If lvwWebSites.SelectedItems.Count = 1 Then
                For Each item As ListViewItem In lvwWebSites.SelectedItems
                    wbname = item.Text
                    wburl = item.SubItems(1).Text
                Next
            End If

            Favorites.Show()
            Favorites.Visible = False
            With Favorites.lvwWebSites.Items.Add(wbname)
                .SubItems.Add(wburl)
            End With

            Try
                Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "Websites.xml", System.Text.Encoding.UTF8)
                With wtrXML
                    .Formatting = Formatting.Indented
                    .WriteStartDocument()
                    .WriteStartElement("WebSites")
                    Dim objListViewItem As New ListViewItem
                    For Each objListViewItem In Favorites.lvwWebSites.Items
                        .WriteStartElement("WebSite")
                        .WriteElementString("Name", objListViewItem.Text)
                        .WriteElementString("URL", objListViewItem.SubItems(1).Text)
                        .WriteEndElement()
                    Next
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Flush()
                    .Close()
                End With
            Catch ex As Exception
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Failed to history-to-favorite data <" & ex.Message & ">", True)
            End Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Favorite added. Disposing Favorite Window handle", True)
            Favorites.CloseHandle(Favorites.Handle)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while saving/disposing history-to-fav <" & ex.InnerException.ToString & ">", True)
        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Remove all history items
        lvwWebSites.Items.Clear()
        'Sync
        History(False)
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox3.Image = My.Resources.cancel
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox3.Image = My.Resources.cancel1
    End Sub

    Private Sub CopuURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopuURLToolStripMenuItem.Click
        'Copies the selected history item's URL to clipboard
        If lvwWebSites.SelectedItems.Count = 1 Then
            For Each item As ListViewItem In lvwWebSites.SelectedItems
                Clipboard.SetText(item.SubItems.Item(1).Text)
            Next
        End If
    End Sub

    Private Sub OpenInBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenInBrowserToolStripMenuItem.Click
        'Opens the selected history item in browser
        If lvwWebSites.SelectedItems.Count = 1 Then
            For Each item As ListViewItem In lvwWebSites.SelectedItems
                MetroForm.WebKitBrowser1.Navigate(item.SubItems.Item(1).Text)
            Next
        End If
    End Sub

    Private Sub lvwWebSites_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwWebSites.SelectedIndexChanged

    End Sub

    Private Sub History_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Favorites.RemoveDuplicates(lvwWebSites)
        History(False)
        Panel1.BackColor = My.Settings.headerclr
    End Sub


    Private Sub History_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub History_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub History_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub

    Private Sub History_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Invalidate()
    End Sub

    Private Sub History_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(New Drawing.Pen(Drawing.Color.Black), New Drawing.Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
        GC.Collect()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class