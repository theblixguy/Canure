'Lets import the ammos
Imports System.Runtime.InteropServices

Public Class Form1
    'Set the values for the Aero Params
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    'Import the function from the user32 libraries
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    'Create a new browser control
    Dim brw As New Browser
    'Create a structure for the Aero Margin Params
    <StructLayout(LayoutKind.Sequential)> _
Public Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    'Import DwmExtendFrameIntoClientArea() function from DWMAPI to apply Aero
    <DllImport("dwmapi.dll", PreserveSig:=False)> _
    Public Shared Sub DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef margins As MARGINS)
    End Sub
    'Imports the DwmIsCompositionEnabled() function from DWMAPI so we can check if the system has Aero
    <DllImport("dwmapi.dll", PreserveSig:=False)> _
    Public Shared Function DwmIsCompositionEnabled() As Boolean
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Check if Aero is enabled by user
        If My.Settings.aero = True Then
            'Yes, then why wait? Apply Aero!
            ApplyAero()
            'Add an browser control to the first tab
            PageCollection1.Add(New TabPages.TabPage("New Tab", brw))
            'Set the tab color
            PageCollection1.TabColor = My.Settings.tabclr
            PageCollection1.Refresh()
            'Fill in the browser control
            brw.Dock = DockStyle.Fill
            'Check where is the destination
            If My.Settings.hpage = True Then
                'Homepage
                brw.WebKitBrowser1.Navigate(My.Settings.homepg)
            Else
                'New Page
                brw.WebKitBrowser1.DocumentText = My.Resources.new_page
            End If

        Else
            'No Aero, ok, then just fire up that boring interface
            'Add an browser control to the first tab
            PageCollection1.Add(New TabPages.TabPage("New Tab", brw))
            'Fill in the browser control
            brw.Dock = DockStyle.Fill
            'Check where is the destination
            If My.Settings.hpage = True Then
                'Homepage
                brw.WebKitBrowser1.Navigate(My.Settings.homepg)
            Else
                'New Page
                brw.WebKitBrowser1.DocumentText = My.Resources.new_page
            End If
        End If
    End Sub

    Private Sub ApplyAero()
        'Here's how we apply Aero on Canure
        Try
            'Check if Aero is enabled on system
            If DwmIsCompositionEnabled() = True Then
                'Yes
                Dim margins As New MARGINS()
                'Decalre the margins
                margins.Top = 37
                margins.Left = 7
                margins.Bottom = 15
                margins.Right = 7
                'Apply Aero!
                DwmExtendFrameIntoClientArea(Me.Handle, margins)
                'Set back color to black, so that no aero-bug appear
                Me.BackColor = Color.Black
            Else
                'No
                'Then just do nothing and change the back color to control
                Me.BackColor = SystemColors.Control
            End If
        Catch ex As Exception
            'Oops, an critical error
            'Pop an box to notify the error
            MsgBox("Canure cannot run because of AErr[1] in Canure", MsgBoxStyle.Critical, "Error")
            'Exit
            Application.Exit()
        End Try

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'Show the notification icon
        Form9.Show()
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        'Add a new tab
        PageCollection1.Add(New TabPages.TabPage("New Tab", brw))
        'Set the tab color
        PageCollection1.TabColor = My.Settings.tabclr
        PageCollection1.Update()
    End Sub
    Private Sub PageCollection1_PageClosing(ByVal page As TabPages.TabPage, ByRef cancel As Boolean) Handles PageCollection1.PageClosing
        If PageCollection1.Count <= 1 Then

        End If
    End Sub
End Class
