Option Strict Off
Imports Microsoft.VisualBasic
Public Class ServerPlugin
    Implements IServerNetwork

    Sub New(_networkHost As IServerNetworkHost, _uiHost As IServerUIHost)
        NetworkHost = _networkHost
        UIHost = _uiHost

        InitializePlugin()
    End Sub

#Region " IServerNetwork "
    Public Sub ListnerAdded(listner As IListener) Implements IServerNetwork.ListenerAdded

    End Sub
    Public Sub ListnerRemoved(listner As IListener) Implements IServerNetwork.ListenerRemoved

    End Sub

    Public Sub ClientPipeCreated(client As IClient, pipeName As String) Implements IServerNetwork.ClientPipeCreated

    End Sub

    Public Sub ClientPipeDestroyed(client As IClient, pipeName As String) Implements IServerNetwork.ClientPipeClosed

    End Sub

    Public Sub ClientReadPacket(client As IClient, pipeName As String, params() As Object) Implements IServerNetwork.ClientReadPacket
        Select Case DirectCast(params(0), CommandType)
            Case CommandType.MiscCommand
                HandleMiscCommand(params)
            Case CommandType.Column
                UIHost.SetClientColumnValue(client, params(1), Nothing, params(2))
        End Select
    End Sub

    Public Sub ClientStateChanged(client As IClient, connected As Boolean) Implements IServerNetwork.ClientStateChanged

    End Sub

    Public Sub HostListenFailed(listner As IListener) Implements IServerNetwork.ListenerFailed

    End Sub

    Public Sub HostStateChanged(listner As IListener) Implements IServerNetwork.ListenerStateChanged

    End Sub

#End Region

End Class
