Option Strict Off
Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Public Class LiveLogs

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Dim HTMLLogs As String = ""
        If My.Computer.FileSystem.DirectoryExists(CurDir() & "\Logs") Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(CurDir() & "\Logs")
                HTMLLogs += My.Computer.FileSystem.ReadAllText(foundFile)
            Next
            WebBrowser1.DocumentText = HTMLLogs
        Else
            MessageBox.Show("There is nothing to load :(", "How terrible", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
