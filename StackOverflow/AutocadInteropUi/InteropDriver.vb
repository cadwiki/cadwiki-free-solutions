Imports System.IO
Imports System.Runtime.InteropServices
Imports Autodesk.AutoCAD.Interop
Imports Autodesk.AutoCAD.Interop.Common

Public Class InteropDriver

    Private autocad2022ProgId As String = "AutoCAD.Application.24.1"
    Private App As AcadApplication

    Public Function StartAutoCADApp(autocadProcessInfo As ProcessStartInfo) As Boolean

        If Not File.Exists(autocadProcessInfo.FileName) Then
            Dim errorString As String = "AutoCAD program path: " + autocadProcessInfo.FileName + " does not exist."
            MessageBox.Show(errorString)
            Throw New Exception(errorString)
        End If

        Dim pr As Process = Process.Start(autocadProcessInfo)
            pr.WaitForInputIdle()
            Dim appAcad As AcadApplication = Nothing
            While appAcad Is Nothing
                Try
                    appAcad = CType(Marshal.GetActiveObject(autocad2022ProgId), AcadApplication)
                Catch ex As Exception
                    Debug.WriteLine("Error: " + ex.Message)
                    Threading.Thread.Sleep(1000)
                End Try
            End While
            App = appAcad
            MessageFilter.Register()
            SetAutoCADWindowToNormal()
            Return True
    End Function

    Public Function GetRunningAutoCADInstance() As AcadApplication
        Dim appAcad As AcadApplication = Nothing
        Try
            appAcad = CType(Marshal.GetActiveObject(autocad2022ProgId), AcadApplication)
        Catch ex As Exception
            Debug.WriteLine("Error: " + ex.Message)
        End Try
        App = appAcad
        Return appAcad
    End Function

    Friend Sub CallScript(scriptPath As String)
        If App Is Nothing Then
            App = GetRunningAutoCADInstance()
            If App Is Nothing Then
                Throw New Exception("Could not retrieve running Autocad instance. Try using the 'Launch Autocad' button first.")
            End If
        End If
        Dim formattedFilePath As String = scriptPath.Replace("\", "\\")
        Dim command As String = "(command-s ""script"" """ + formattedFilePath + """)"
        App.ActiveDocument.SendCommand(command + vbLf)
    End Sub

    Public Function SetAutoCADWindowToNormal() As Boolean
        If App Is Nothing Then
            Return False
        End If
        App.WindowState = AcWindowState.acNorm
        Return True
    End Function
End Class
