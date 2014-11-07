Option Strict Off
Imports System.Net
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class PluginInfo



    Private Sub PluginInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = ("Loading News...")

        Dim T As New Threading.Thread(AddressOf GetNews)
        T.Start()

    End Sub

    Sub GetNews()
        Using Google As New WebClient
            RichTextBox1.Text = Google.DownloadString("http://www.lazyshare.net/Nano/News.txt")
        End Using
    End Sub

    Sub DownloadUpdate()

        Try
            Dim UpdateCheck As String
            Status("Checking for new updates...")
            Using Google As New WebClient
                UpdateCheck = Google.DownloadString("http://www.lazyshare.net/Nano/MultiCore" & UpdateVersion + 1 & ".rar")
            End Using


            If UpdateCheck = "Nothing." Then
                MessageBox.Show("There are no new MultiCore updates.", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Status("Idle.")
            Else
                Using clientdown As New WebClient()
                    AddHandler clientdown.DownloadProgressChanged, AddressOf ShowDownloadProgress
                    AddHandler clientdown.DownloadFileCompleted, AddressOf OnDownloadComplete
                    clientdown.DownloadFileAsync(New Uri("http://www.lazyshare.net/Nano/MultiCore" & UpdateVersion + 1 & ".rar"), CurDir() & "\MultiCore" & UpdateVersion + 1 & ".rar", Stopwatch.StartNew)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("There are no new MultiCore updates.", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Status("Idle.")
        End Try

    End Sub

    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            ProgressBar1.Value = 0
            Status("Idle.")
            MessageBox.Show("Update has been downloaded, you can now extract the files.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Sub Status(Text As String)
        ToolStripStatusLabel1.Text = Text
    End Sub

    Private Sub ShowDownloadProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = e.ProgressPercentage
        Dim Stringlel As String = (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#)).ToString("#")
        ToolStripStatusLabel1.Text = "Downloading... ( " & Math.Round(Stringlel / 1000 / 1000, 2) & "MB/s) (" & Math.Round(e.BytesReceived / 1000 / 1000, 2) & "MB)" & " ) ( " & e.ProgressPercentage & "% )"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DownloadUpdate()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
