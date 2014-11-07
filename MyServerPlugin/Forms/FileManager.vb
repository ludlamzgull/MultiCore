Option Strict Off
Imports Microsoft.VisualBasic

Public Class FileManager
    Private _Message As String
    Public Property Message() As String
        Get
            Return _Message
        End Get
        Set(ByVal value As String)
            _Message = value
        End Set
    End Property


    Sub DownloadFile(Download As String)

        For Each Client As IClient In Clients2
            SendMiscCommandUpload(Client, Download)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListBox1.Items.Count - 2 < 0 Then Return

        Dim ItemName As String = ListBox1.Items(ListBox1.Items.Count - 2)

        ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)

        ListView1.Items.Clear()

        For Each Client As IClient In Clients2
            SendMiscCommandManage(Client, ItemName)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub FileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_DoubleClick_1(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        If ListView1.SelectedItems(0).SubItems(0).Text = "[File]" Then

            Dim ItemName As String = ListView1.SelectedItems(0).SubItems(2).Text
            If MsgBox("Would you like to download this file?", MsgBoxStyle.YesNo, "File Manager") = MsgBoxResult.Yes Then
                DownloadFile(ItemName)
            End If

        Else

            If ListView1.SelectedItems.Count < 1 Then Return

            Dim ItemName As String = ListView1.SelectedItems(0).SubItems(2).Text

            ListView1.Items.Clear()

            ListBox1.Items.Add(ItemName)

            For Each Client As IClient In Clients2
                SendMiscCommandManage(Client, ItemName)
            Next

        End If
    End Sub
End Class