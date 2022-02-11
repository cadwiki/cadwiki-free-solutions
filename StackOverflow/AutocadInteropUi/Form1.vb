Imports System.Reflection
Imports Autodesk.AutoCAD.Interop

Public Class Form1

    Public driver As New InteropDriver()

    Private Sub ButtonButtonLaunchAutocad_Click(sender As Object, e As EventArgs) Handles ButtonLaunchAutocad.Click
        Dim acadLocation As String = "C:\Program Files\Autodesk\AutoCAD 2022\acad.exe"
        Dim processInfo As ProcessStartInfo = New ProcessStartInfo With {
            .FileName = acadLocation
        }
        driver.StartAutoCADApp(processInfo)
    End Sub

    Private Sub ButtonCallScript_Click(sender As Object, e As EventArgs) Handles ButtonCallScript.Click
        Dim scriptPath As String = "C:\Autocad\test.scr"
        driver.CallScript(scriptPath)
    End Sub

End Class
