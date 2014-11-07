Option Strict Off

Public Class StressTesting


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Graph1.DataSmoothingLevel = TrackBar1.Value + 1
    End Sub

    Private Sub Graph1_Click(sender As Object, e As EventArgs) Handles Graph1.Click

    End Sub
End Class
