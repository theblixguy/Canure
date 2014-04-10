'Lets import the required things
Imports System.Xml, System.Text
Public Class Favorites

    'Here goes the main function that controls the Load or Save of the favorites

    Private Sub Favourites(ByVal LoadOrSave As Boolean)
        Select Case LoadOrSave

            Case True 'Load
                lvwWebSites.Items.Clear()
                Dim rdrXML As New XmlTextReader(My.Application.Info.DirectoryPath & "\" & "WebSites.xml")
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

            Case False 'Save

                Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "WebSites.xml", System.Text.Encoding.UTF8)
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
    End Sub
    Private Sub frmFavorites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Lets try load the favorite data
            Favourites(True)
        Catch ex As Exception
            'Oops, an error occured. Pop up an box to notify the user
            MsgBox("The Favourites data failed to load [" & ex.Message & "]", MsgBoxStyle.Exclamation, "FavLoad Error")
            'Create an favorite file so this doesn't occur next time
            IO.File.Create(Application.StartupPath & "/" & "WebSites.xml")
        End Try
    End Sub

    Private Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        'Add Favorite details (Webpage URL and Title)
        With lvwWebSites.Items.Add(txtWebSite.Text)
            .SubItems.Add(txtURL.Text)
        End With

        'Save Favorite details
        Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "WebSites.xml", System.Text.Encoding.UTF8)
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
    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink2.Click
        'Remove the favorite
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
        'Save the changes
        Favourites(False)
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
End Class