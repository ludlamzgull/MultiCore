Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Public Class Remote

    Private _Message As String
    Public Property Message() As String
        Get
            Return _Message
        End Get
        Set(ByVal value As String)
            _Message = value
        End Set
    End Property

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        _Message = RichTextBox1.Text
        DialogResult = Windows.Forms.DialogResult.OK
        RichTextBox1.Clear()
    End Sub

    Private Sub Remote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class