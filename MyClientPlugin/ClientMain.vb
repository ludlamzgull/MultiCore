Imports System.IO

Module ClientMain

#Region " Plugin Hosts "

    Public LoggingHost As IClientLoggingHost
    Public NetworkHost As IClientNetworkHost

#End Region

#Region " Send Pass "

    Public Sub SendCommand(ParamArray params As Object())

        Try

            NetworkHost.SendToServer(Nothing, True, params)

        Catch ex As Exception
            WriteError(ex, "Sending shit")
        End Try

    End Sub

#End Region

    Public Sub InitializePlugin()

    End Sub

End Module
