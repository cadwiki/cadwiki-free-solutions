Imports System.Reflection
Imports Autodesk.AutoCAD.Interop

Public Class Form1

    Public driver As New InteropDriver()

    'https://stackoverflow.com/questions/71080767/run-a-script-within-autocad-from-excel/71086948#71086948
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
