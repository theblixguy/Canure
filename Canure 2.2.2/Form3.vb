Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lang As String
        lang = ComboBox1.SelectedItem

        ' We can select any of the following languages
        '----------------------------------------------------
        'CSS
        'C++
        'HTML
        'JavaScript
        'Java
        'Text
        '.NET
        'C#
        'Xml
        '----------------------------------------------------

        Select Case lang
            'Lest apply the language template
            Case "C++"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.CPlusPlus
            Case "C#"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.CSharp
            Case "JavaScript"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.JavaScript
            Case "Java"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Jass
            Case "VB.NET"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.VBNET
            Case "HTML"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html
            Case "CSS"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.CSS
            Case "Text"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Text
            Case "XML"
                Form2.TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Xml
        End Select
    End Sub
End Class