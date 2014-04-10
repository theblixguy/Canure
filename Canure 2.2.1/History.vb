'Import what we need to get working
Imports System.Xml, System.Text
Public Class History

    'Function that controls the History Load/Save data
    Private Sub Favourites(ByVal LoadOrSave As Boolean) 'We know we're using 'Favourites' instead of 'History' :P
        Select Case LoadOrSave
            Case True 'Load
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
            Case False 'Save
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
        End Select
    End Sub
   Private Sub frmFavorites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load the history data
            Favourites(True)
        Catch ex As Exception
            'darn, again an error
            MsgBox("The History data failed to load [" & ex.Message & "]", MsgBoxStyle.Exclamation, "HisLoad Error")
            'Fix the error by creating the history data file
            IO.File.Create(Application.StartupPath & "/" & "History.xml")
        End Try
    End Sub

    Private Sub CommandLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink1.Click
        'Remove the selected history item
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
        'Sync the data
        Favourites(False)
    End Sub

    Private Sub CommandLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandLink2.Click
        'Remove all history items
        lvwWebSites.Items.Clear()
        'Sync.
        Favourites(False)
    End Sub

    Private Sub CopyURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyURLToolStripMenuItem.Click
        'Copies the selected history item's URL to clipboard
        If lvwWebSites.SelectedItems.Count = 1 Then
            For Each item As ListViewItem In lvwWebSites.SelectedItems
                Clipboard.SetText(item.SubItems.Item(1).Text)
            Next
        End If
    End Sub

End Class