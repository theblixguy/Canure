Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports MetroUI_Form.WinApi
Imports System.Drawing
Imports System.Xml
Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Taskbar


Public Class MetroForm

#Region "Window Behavior"

#Region "Fields"
    Private dwmMargins As Dwm.MARGINS
    Private _marginOk As Boolean
    Private _aeroEnabled As Boolean = False
#End Region
#Region "Ctor"
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)

        InitializeComponent()

        DoubleBuffered = True

    End Sub
#End Region
#Region "Props"
    Public ReadOnly Property AeroEnabled() As Boolean
        Get
            Return _aeroEnabled
        End Get
    End Property
#End Region
#Region "Methods"
    Public Shared Function LoWord(ByVal dwValue As Integer) As Integer
        Return dwValue And &HFFFF
    End Function
    ''' <summary>
    ''' Equivalent to the HiWord C Macro
    ''' </summary>
    ''' <param name="dwValue"></param>
    ''' <returns></returns>
    Public Shared Function HiWord(ByVal dwValue As Integer) As Integer
        Return (dwValue >> 16) And &HFFFF
    End Function
#End Region
    Dim frm2 As New Form4
    Dim prog As Double
    Dim tbp As TaskbarManager
    Dim Category As New JumpListCustomCategory("Recently Visited")

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dwm.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
    End Sub

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        Dim WM_NCCALCSIZE As Integer = &H83
        Dim WM_NCHITTEST As Integer = &H84
        Dim result As IntPtr

        Dim dwmHandled As Integer = Dwm.DwmDefWindowProc(m.HWnd, m.Msg, m.WParam, m.LParam, result)

        If dwmHandled = 1 Then
            m.Result = result
            Exit Sub
        End If

        If m.Msg = WM_NCCALCSIZE AndAlso CInt(m.WParam) = 1 Then
            Dim nccsp As NCCALCSIZE_PARAMS = _
              DirectCast(Marshal.PtrToStructure(m.LParam, _
              GetType(NCCALCSIZE_PARAMS)), NCCALCSIZE_PARAMS)

            ' Adjust (shrink) the client rectangle to accommodate the border:
            nccsp.rect0.Top += 0
            nccsp.rect0.Bottom += 0
            nccsp.rect0.Left += 0
            nccsp.rect0.Right += 0

            If Not _marginOk Then
                'Set what client area would be for passing to DwmExtendIntoClientArea. Also remember that at least one of these values NEEDS TO BE > 1, else it won't work.
                dwmMargins.cyTopHeight = 0
                dwmMargins.cxLeftWidth = 0
                dwmMargins.cyBottomHeight = 3
                dwmMargins.cxRightWidth = 0
                _marginOk = True
            End If

            Marshal.StructureToPtr(nccsp, m.LParam, False)

            m.Result = IntPtr.Zero
        ElseIf m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = 0 Then
            m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam)
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Private Function HitTestNCA(ByVal hwnd As IntPtr, ByVal wparam _
                                      As IntPtr, ByVal lparam As IntPtr) As IntPtr
        Dim HTNOWHERE As Integer = 0
        Dim HTCLIENT As Integer = 1
        Dim HTCAPTION As Integer = 2
        Dim HTGROWBOX As Integer = 4
        Dim HTSIZE As Integer = HTGROWBOX
        Dim HTMINBUTTON As Integer = 8
        Dim HTMAXBUTTON As Integer = 9
        Dim HTLEFT As Integer = 10
        Dim HTRIGHT As Integer = 11
        Dim HTTOP As Integer = 12
        Dim HTTOPLEFT As Integer = 13
        Dim HTTOPRIGHT As Integer = 14
        Dim HTBOTTOM As Integer = 15
        Dim HTBOTTOMLEFT As Integer = 16
        Dim HTBOTTOMRIGHT As Integer = 17
        Dim HTREDUCE As Integer = HTMINBUTTON
        Dim HTZOOM As Integer = HTMAXBUTTON
        Dim HTSIZEFIRST As Integer = HTLEFT
        Dim HTSIZELAST As Integer = HTBOTTOMRIGHT

        Dim p As New Point(LoWord(CInt(lparam)), HiWord(CInt(lparam)))

        Dim topleft As Rectangle = RectangleToScreen(New Rectangle(0, 0, _
                                   dwmMargins.cxLeftWidth, dwmMargins.cxLeftWidth))

        If topleft.Contains(p) Then
            Return New IntPtr(HTTOPLEFT)
        End If

        Dim topright As Rectangle = _
          RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, 0, _
          dwmMargins.cxRightWidth, dwmMargins.cxRightWidth))

        If topright.Contains(p) Then
            Return New IntPtr(HTTOPRIGHT)
        End If

        Dim botleft As Rectangle = _
           RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
           dwmMargins.cxLeftWidth, dwmMargins.cyBottomHeight))

        If botleft.Contains(p) Then
            Return New IntPtr(HTBOTTOMLEFT)
        End If

        Dim botright As Rectangle = _
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
            Height - dwmMargins.cyBottomHeight, _
            dwmMargins.cxRightWidth, dwmMargins.cyBottomHeight))

        If botright.Contains(p) Then
            Return New IntPtr(HTBOTTOMRIGHT)
        End If

        Dim top As Rectangle = _
            RectangleToScreen(New Rectangle(0, 0, Width, dwmMargins.cxLeftWidth))

        If top.Contains(p) Then
            Return New IntPtr(HTTOP)
        End If

        Dim cap As Rectangle = _
            RectangleToScreen(New Rectangle(0, dwmMargins.cxLeftWidth, _
            Width, dwmMargins.cyTopHeight - dwmMargins.cxLeftWidth))

        If cap.Contains(p) Then
            Return New IntPtr(HTCAPTION)
        End If

        Dim left As Rectangle = _
            RectangleToScreen(New Rectangle(0, 0, dwmMargins.cxLeftWidth, Height))

        If left.Contains(p) Then
            Return New IntPtr(HTLEFT)
        End If

        Dim right As Rectangle = _
            RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
            0, dwmMargins.cxRightWidth, Height))

        If right.Contains(p) Then
            Return New IntPtr(HTRIGHT)
        End If

        Dim bottom As Rectangle = _
            RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
            Width, dwmMargins.cyBottomHeight))

        If bottom.Contains(p) Then
            Return New IntPtr(HTBOTTOM)
        End If

        Return New IntPtr(HTCLIENT)
    End Function

    Private Const BorderWidth As Integer = 6

    Private _resizeDir As ResizeDirection = ResizeDirection.None

    Private Sub MetroForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Exiting Canure with the reason [" & e.CloseReason.ToString & "]", True)
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/" & "bm.tst")
        Application.Exit()
    End Sub

    Private Sub MetroForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "bm.tst", "DO_NOT_DELETE:BROWSER_MODE_CHECK_FILE", False)
        WebKitBrowser1.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.13 (KHTML, like Gecko) Canure/2.3.0.0"
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> New instance of Canure is created", True)
        If System.IO.File.Exists(Application.StartupPath & "/" & "first.run") Then
            Me.Visible = False
            Me.ShowInTaskbar = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Detected the first run file. Firing up First Run Window.", True)
            Form1.Show()
        Else
            Try
                If Not Command() = Nothing Then
                    Dim pathStart As String = Command.IndexOf(""""c) + 1
                    Dim path As String = Command.Substring(pathStart, Command.LastIndexOf(""""c) - pathStart)
                    WebKitBrowser1.Navigate(path)
                Else
                    Me.Visible = True
                    Me.ShowInTaskbar = True
                    WebKitBrowser1.DocumentText = My.Resources.welcome.ToString
                End If

            Catch ex As Exception
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while initializing main window <" & ex.InnerException.ToString & ">", True)
            End Try

        End If
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'Nothing
    End Sub

    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 4
        TopRight = 8
        Right = 16
        BottomRight = 32
        Bottom = 64
        BottomLeft = 128
    End Enum

    Private Property resizeDir() As ResizeDirection
        Get
            Return _resizeDir
        End Get
        Set(ByVal value As ResizeDirection)
            _resizeDir = value

            'Change cursor
            Select Case value
                Case ResizeDirection.Left
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Right
                    Me.Cursor = Cursors.SizeWE

                Case ResizeDirection.Top
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.Bottom
                    Me.Cursor = Cursors.SizeNS

                Case ResizeDirection.BottomLeft
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.TopRight
                    Me.Cursor = Cursors.SizeNESW

                Case ResizeDirection.BottomRight
                    Me.Cursor = Cursors.SizeNWSE

                Case ResizeDirection.TopLeft
                    Me.Cursor = Cursors.SizeNWSE

                Case Else
                    Me.Cursor = Cursors.Default
            End Select
        End Set
    End Property

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Nothing
    End Sub

    Private Sub MoveControl(ByVal hWnd As IntPtr)
        ReleaseCapture()
        SendMessage(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub ResizeForm(ByVal direction As ResizeDirection)
        Dim dir As Integer = -1
        Select Case direction
            Case ResizeDirection.Left
                dir = HTLEFT
            Case ResizeDirection.TopLeft
                dir = HTTOPLEFT
            Case ResizeDirection.Top
                dir = HTTOP
            Case ResizeDirection.TopRight
                dir = HTTOPRIGHT
            Case ResizeDirection.Right
                dir = HTRIGHT
            Case ResizeDirection.BottomRight
                dir = HTBOTTOMRIGHT
            Case ResizeDirection.Bottom
                dir = HTBOTTOM
            Case ResizeDirection.BottomLeft
                dir = HTBOTTOMLEFT
        End Select

        If dir <> -1 Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, dir, 0)
        End If

    End Sub

    <DllImport("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14
#End Region

    Dim lm As Boolean = False
    Private Sub WebKitBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebKitBrowser1.DocumentCompleted
        Try
            Dim item As New JumpListItem(Application.ExecutablePath)
            Category.AddJumpListItems(item)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Website loading completed", True)
            TextBox1.Text = WebKitBrowser1.Url.Host
            PictureBox3.Image = My.Resources.go
            PictureBox6.Visible = True
            WriteHistory(WebKitBrowser1.DocumentTitle, WebKitBrowser1.Url.AbsoluteUri)
        Catch ex As Exception : End Try

    End Sub

    Private Sub WebKitBrowser1_DownloadBegin(ByVal sender As Object, ByVal e As WebKit.FileDownloadBeginEventArgs) Handles WebKitBrowser1.DownloadBegin
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Download event fired. Browser cannot handle these events currently but the download is going on silently and is being saved in Canure's folder.", True)
        MsgBox("Download has started. Canure cannot handle the event currently but the file is downloading and being saved in Canure's folder", MsgBoxStyle.Information, "Event Unhandle Notify")
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            GC.Collect()
        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If TextBox1.Text = "canure:welcome" Then
            WebKitBrowser1.DocumentText = My.Resources.welcome.ToString
        ElseIf TextBox1.Text = "canure:fkerr" Then
            WebKitBrowser1.DocumentText = My.Resources.Err.ToString
        ElseIf TextBox1.Text = "canure:plugins" Then
            WebKitBrowser1.DocumentText = My.Resources.abtplgins.ToString
        ElseIf TextBox1.Text = "canure:tdps" Then
            Form5.Show()
        Else
            WebKitBrowser1.Navigate(TextBox1.Text)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Navigating to website", True)
        End If

    End Sub

    Private Sub WebKitBrowser1_Error(ByVal sender As Object, ByVal e As WebKit.WebKitBrowserErrorEventArgs) Handles WebKitBrowser1.Error
        WebKitBrowser1.Stop()
        WebKitBrowser1.DocumentText = My.Resources.Err.ToString
    End Sub
    Private Sub WebKitBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebKitBrowser1.Navigating

        PictureBox6.Visible = False
        PictureBox3.Image = My.Resources.cancel
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "canure:welcome" Then
                WebKitBrowser1.DocumentText = My.Resources.welcome.ToString
            ElseIf TextBox1.Text = "canure:fkerr" Then
                WebKitBrowser1.DocumentText = My.Resources.Err.ToString
            ElseIf TextBox1.Text = "canure:plugins" Then
                WebKitBrowser1.DocumentText = My.Resources.abtplgins.ToString
            ElseIf TextBox1.Text = "canure:tdps" Then
                Form5.Show()
            Else
                Form2.Dispose()
                Form3.Dispose()
                WebKitBrowser1.Navigate(TextBox1.Text)
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Navigating to website", True)
            End If
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        Try
            TextBox1.Text = WebKitBrowser1.Url.AbsoluteUri
        Catch ex As Exception : End Try

    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        Try
            TextBox1.Text = WebKitBrowser1.Url.Host
        Catch ex As Exception : End Try

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WebKitBrowser1.Reload()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebKitBrowser1.GoBack()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebKitBrowser1.GoForward()
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.back1
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.back
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources._next
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.Metro_Forward_Black_32
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.Enabled = False
        frm2.Width = Me.Width
        frm2.Left = CInt(Me.Left + ((Me.Width - frm2.Width) / 2))
        frm2.Top = CInt(Me.Top + ((Me.Height - frm2.Height) / 2))
        frm2.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Fired up the AddFav function", True)
        Try
            Favorites.Show()
            Favorites.Visible = False
            With Favorites.lvwWebSites.Items.Add(WebKitBrowser1.DocumentTitle)
                .SubItems.Add(WebKitBrowser1.Url.AbsoluteUri)
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
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Failed to direct save favorite data <" & ex.Message & ">", True)
            End Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Favorite added. Disposing Favorite Window handle", True)
            Favorites.CloseHandle(Favorites.Handle)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while saving/disposing fav <" & ex.InnerException.ToString & ">", True)
        End Try
    End Sub

    Private Sub WebKitBrowser1_NewWindowRequest(ByVal sender As Object, ByVal e As WebKit.NewWindowRequestEventArgs) Handles WebKitBrowser1.NewWindowRequest
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> NewWindowRequest event fired. Brower doesnt handle these requests (currently) due to bug in engine.", True)
        MsgBox(e.Url.ToString)
    End Sub

    Private Sub WebKitBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles WebKitBrowser1.ProgressChanged

        Try

            tbp.Instance.SetProgressState(TaskbarProgressBarState.Normal, Me.Handle)
            tbp.Instance.SetProgressValue(e.ProgressPercentage, 100)
            ProgressBar1.Value = e.ProgressPercentage

        Catch ex As Exception : End Try

    End Sub

    Private Sub WebKitBrowser1_ProgressFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebKitBrowser1.ProgressFinished
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
        Panel4.Visible = False
        Panel4.BackColor = Panel2.BackColor
        Try
            tbp.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, Me.Handle)
        Catch ex As Exception : End Try

    End Sub

    Private Sub WebKitBrowser1_ProgressStarted(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebKitBrowser1.ProgressStarted
        Panel4.BackColor = Panel2.BackColor
        ProgressBar1.Visible = True
        Panel4.Visible = True

    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel1.Visible = False
        TextEditor1.Text = Nothing
        GC.Collect()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebKitBrowser1.DocumentText = TextEditor1.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextEditor1.Undo()
    End Sub

    Private Sub Button3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.DoubleClick
        TextEditor1.Redo()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If lm = True Then
            lm = False
            Button2.ForeColor = Color.Black
        ElseIf lm = False Then
            lm = True
            Button2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextEditor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEditor1.Click

    End Sub

    Private Sub TextEditor1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEditor1.TextChanged
        If lm = True Then
            WebKitBrowser1.DocumentText = TextEditor1.Text
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ViewSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSource.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Firing up Developer tools panel", True)
        Panel1.Visible = True
        TextEditor1.Text = WebKitBrowser1.DocumentText.ToString
        TextEditor1.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.Html
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub MetroForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Panel2.BackColor = My.Settings.headerclr
        Panel4.BackColor = My.Settings.headerclr
    End Sub

    Private Sub CreateJumplist()
        Try
            Dim JList As JumpList
            JList = JumpList.CreateJumpList()
            JList.ClearAllUserTasks()


            'Add 2 Links to the Usertasks with a Separator
            Dim Link0 As New JumpListLink(Application.ExecutablePath, "New Window")
            Dim Link1 As New JumpListLink(Application.StartupPath & "/" & "bugrpt.exe", "Bug Reporter")
            Link1.Arguments = "/AuthGranted"
            JList.AddUserTasks(Link0)
            JList.AddUserTasks(Link1)
            'Create a Custom Category and Add an Item to it 

            JList.AddCustomCategories(Category)
            Category.AddJumpListItems(New JumpListLink(Application.ExecutablePath, "Demo (Dont click)"))
            'to control which category Recent/Frequent is displayed 
            JList.KnownCategoryToDisplay = JumpListKnownCategoryType.Recent

            JList.Refresh()
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Exception during Jumplist initialization <" & ex.ToString & ">", True)
        End Try
        
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Width - BorderWidth > e.Location.X AndAlso e.Location.X > BorderWidth AndAlso e.Location.Y > BorderWidth Then
                MoveControl(Me.Handle)
            Else
                If Me.WindowState <> FormWindowState.Maximized Then
                    ResizeForm(resizeDir)
                End If
            End If
        End If
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave

    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        'Calculate which direction to resize based on mouse position

        If e.Location.X < BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopLeft

        ElseIf e.Location.X < BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomLeft

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.BottomRight

        ElseIf e.Location.X > Me.Width - BorderWidth And e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.TopRight

        ElseIf e.Location.X < BorderWidth Then
            resizeDir = ResizeDirection.Left

        ElseIf e.Location.X > Me.Width - BorderWidth Then
            resizeDir = ResizeDirection.Right

        ElseIf e.Location.Y < BorderWidth Then
            resizeDir = ResizeDirection.Top

        ElseIf e.Location.Y > Me.Height - BorderWidth Then
            resizeDir = ResizeDirection.Bottom

        Else
            resizeDir = ResizeDirection.None
        End If
    End Sub

    Public Sub WriteHistory(ByVal WebPageTitle As String, ByVal WebPageURL As String)
        History.Show()
        History.Visible = False
        'Add History details (Webpage URL and Title)
        With History.lvwWebSites.Items.Add(WebPageTitle)
            .SubItems.Add(WebPageURL)
        End With

        'Save History details
        Try
            Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & "History.xml", System.Text.Encoding.UTF8)
            With wtrXML
                .Formatting = Formatting.Indented
                .WriteStartDocument()
                .WriteStartElement("WebSites")
                Dim objListViewItem As New ListViewItem
                For Each objListViewItem In History.lvwWebSites.Items
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
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/" & "applog.txt", Environment.NewLine & "[" & Date.Now & "] -> Error occured while writing to history <" & ex.InnerException.ToString & ">", True)
        End Try
        Favorites.CloseHandle(History.Handle)
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class