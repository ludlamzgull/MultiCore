Option Strict Off
Imports Microsoft.VisualBasic

Module Functions

    Public Function ReadFile(ByVal sFile As String) As String
        On Error Resume Next
        Dim OpenFile As New System.IO.StreamReader(sFile)
        ReadFile = OpenFile.ReadToEnd.ToString
    End Function

    Public Function RegRead(ByVal hKey As String) As String
        Dim wshShell As Object = CreateObject("WScript.Shell")
        On Error Resume Next
        RegRead = wshShell.RegRead(hKey)
    End Function

    Public Function ReadLine(ByVal filename As String, _
    ByVal line As Integer) As String
        Try
            Dim lines As String() = My.Computer.FileSystem.ReadAllText( _
              filename, System.Text.Encoding.Default).Split(vbCrLf)
            If line > 0 Then
                Return lines(line - 1)
            ElseIf line < 0 Then
                Return lines(lines.Length + line - 1)
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
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
