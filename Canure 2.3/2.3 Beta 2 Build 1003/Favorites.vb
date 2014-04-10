'Lets import the required things
Imports System.Xml, System.Text
Imports System.Windows.Forms


Public Class Favorites
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean
    'Here goes the main function that controls the Load or Save of the favorites

    Private Sub Favourites(ByVal LoadOrSave As Boolean)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Favorites window fired. Loading favorites.", True)
        Try
            Select Case LoadOrSave

                Case True 'Load
                    Try
                        lvwWebSites.Items.Clear()
                        Dim rdrXML As New XmlTextReader(My.Application.Info.DirectoryPath & "\" & "Websites.xml")
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
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading favorite data failed! <" & ex.ToString & ">", True)
                    End Try
                Case False 'Save

                    Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "Websites.xml", System.Text.Encoding.UTF8)
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

    Private Sub Favorites_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Disposing favorite window handle (to avoid lock)", True)
        CloseHandle(Me.Handle)
    End Sub
    Private Sub frmFavorites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading favorite data [frmFavorites::Load]", True)
            'Lets try load the favorite data
            Favourites(True)
        Catch ex As Exception
            'Oops, an error occured. Pop up an box to notify the user
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Loading favorite data failed <" & ex.InnerException.ToString & ">", True)
            MsgBox("The Favourites data failed to load [" & ex.Message & "]", MsgBoxStyle.Exclamation, "FavLoad Error")
            'Create an favorite file so this doesn't occur next time
            IO.File.Create(Application.StartupPath & "/" & "Websites.xml")
        End Try
    End Sub
    Private Sub lvwWebSites_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwWebSites.SelectedIndexChanged
        'Show the URL and Title for the selected webpage
        If lvwWebSites.SelectedItems.Count = 1 Then
            For Each item As ListViewItem In lvwWebSites.SelectedItems
                txtWebSite.Text = item.Text
                txtURL.Text = item.SubItems(1).Text
            Next
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Add Favorite details (Webpage URL and Title)
        With lvwWebSites.Items.Add(txtWebSite.Text)
            .SubItems.Add(txtURL.Text)
        End With

        'Save Favorite details
        Try
            Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "Websites.xml", System.Text.Encoding.UTF8)
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
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while saving data <" & ex.InnerException.ToString & ">", True)
        End Try

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Remove the favorite
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
        'Save the changes
        Favourites(False)
    End Sub

    Private Sub Favorites_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Favorites_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Favorites_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Public Function RemoveDuplicates(ByVal lstView As ListView) As Boolean


        Dim itemI As ListViewItem


        Dim itemJ As ListViewItem


        Dim progress As Integer


        Dim count As Integer


        Dim ProgressDupCounter As Integer = lstView.Items.Count


        For i As Integer = lstView.Items.Count - 1 To 0 Step -1


            itemI = lstView.Items(i)


            progress = progress + 1


            ' start one after hence +1


            For z As Integer = i + 1 To lstView.Items.Count - 1 Step 1


                itemJ = lstView.Items(z)


                If itemI.Text = itemJ.Text Then


                    'duplicate found, now delete duplicate


                    lstView.Items.Remove(itemJ)


                    count = count + 1
                    Exit For
                End If
            Next z

        Next (i)

    End Function

    Private Sub Favorites_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RemoveDuplicates(lvwWebSites)
        Favourites(False)
        Panel1.BackColor = My.Settings.headerclr

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Close()
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
End Class