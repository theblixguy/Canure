﻿Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public NotInheritable Class Effects
    Private Sub New()
    End Sub
    Public Enum Effect
        Roll
        Slide
        Center
        Blend
    End Enum

    Public Shared Sub Animate(ByVal ctl As Control, ByVal effect__1 As Effect, ByVal msec As Integer, ByVal angle As Integer)
        Dim flags As Integer = effmap(CInt(effect__1))
        If ctl.Visible Then
            flags = flags Or &H10000
            angle += 180
        Else
            If ctl.TopLevelControl Is ctl Then
                flags = flags Or &H20000
            ElseIf effect__1 = Effect.Blend Then
                Throw New ArgumentException()
            End If
        End If
        flags = flags Or dirmap((angle Mod 360) \ 45)
        Dim ok As Boolean = AnimateWindow(ctl.Handle, msec, flags)
        If Not ok Then
            Throw New Exception("Animation failed")
        End If
        ctl.Visible = Not ctl.Visible
    End Sub

    Private Shared dirmap As Integer() = {1, 5, 4, 6, 2, 10, _
     8, 9}
    Private Shared effmap As Integer() = {0, &H40000, &H10, &H80000}

    <DllImport("user32.dll")> _
    Private Shared Function AnimateWindow(ByVal handle As IntPtr, ByVal msec As Integer, ByVal flags As Integer) As Boolean
    End Function
End Class