Option Strict Off
Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Public Class Recovery


    Private Sub UserControl1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        Dim MyWidth As Integer = Me.Width / 6

        MCName.Width = MyWidth - 20
        MCID.Width = MyWidth - 40
        MCSource.Width = MyWidth - 20
        MCHost.Width = MyWidth + 60
        MCUsername.Width = MyWidth + 10
        MCPassword.Width = MyWidth - 15

    End Sub

    Private Sub CopyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyDataToolStripMenuItem.Click

        My.Computer.Clipboard.SetText(ListView1.SelectedItems(0).SubItems(0).Text & "-" & ListView1.SelectedItems(0).SubItems(1).Text & "-" & ListView1.SelectedItems(0).SubItems(2).Text & "-" & ListView1.SelectedItems(0).SubItems(3).Text & "-" & ListView1.SelectedItems(0).SubItems(4).Text & "-" & ListView1.SelectedItems(0).SubItems(5).Text)

    End Sub

    Private Sub ExportDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportDataToolStripMenuItem.Click

        If Not My.Computer.FileSystem.DirectoryExists(CurDir() & "\Logs\") Then
            My.Computer.FileSystem.CreateDirectory(CurDir() & "\Logs\")
        End If
        Dim MyFileName As String = InputBox("Please enter a file name.")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(CurDir() & "\Logs\" & MyFileName & ".html", False)
        file.WriteLine(RichTextBox1.Text)
        For Each item As ListViewItem In ListView1.Items
            file.WriteLine("<tr><td><h4>" & item.SubItems(0).Text & "</h4><td><h4>" & item.SubItems(1).Text & "</h4><td><h4>" & item.SubItems(2).Text & "</h4><td><h4>" & item.SubItems(3).Text & "</h4><td><h4>" & item.SubItems(4).Text & "</h4><td><h4>" & item.SubItems(5).Text & "</h4></td></tr>")
        Next
        file.WriteLine("</table><p><small>Generated on " & DateValue(Now).ToLongDateString & " at " & TimeValue(Now) & " by MultiCore (Using Aeonhacks CSS Source)</small></p></div></body></html>")
        file.Close()

        MessageBox.Show("Logs have been saved as a .html file in the logs folder!" & vbNewLine & _
                        CurDir() & "\Logs\" & MyFileName & ".html", "Client Logs", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDataToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
