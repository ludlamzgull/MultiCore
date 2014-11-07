Option Strict Off
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Class BonfireAlertBox
    Inherits Control

    Private exitLocation As Point
    Private overExit As Boolean

    Enum Style
        _Error
        _Success
        _Warning
        _Notice
    End Enum

    Private _alertStyle As Style
    Public Property AlertStyle As Style
        Get
            Return _alertStyle
        End Get
        Set(ByVal value As Style)
            _alertStyle = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)

        Dim borderColor, innerColor, textColor As Color
        Select Case _alertStyle
            Case Style._Error
                borderColor = Color.FromArgb(250, 195, 195)
                innerColor = Color.FromArgb(255, 235, 235)
                textColor = Color.FromArgb(220, 90, 90)
            Case Style._Notice
                borderColor = Color.FromArgb(180, 215, 230)
                innerColor = Color.FromArgb(235, 245, 255)
                textColor = Color.FromArgb(80, 145, 180)
            Case Style._Success
                borderColor = Color.FromArgb(180, 220, 130)
                innerColor = Color.FromArgb(235, 245, 225)
                textColor = Color.FromArgb(95, 145, 45)
            Case Style._Warning
                borderColor = Color.FromArgb(220, 215, 140)
                innerColor = Color.FromArgb(250, 250, 220)
                textColor = Color.FromArgb(145, 135, 110)
        End Select

        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
        G.FillRectangle(New SolidBrush(innerColor), mainRect)
        G.DrawRectangle(New Pen(borderColor), mainRect)

        Dim styleText As String = Nothing
        Select Case _alertStyle
            Case Style._Error
                styleText = "Error!"
            Case Style._Notice
                styleText = "Notice!"
            Case Style._Success
                styleText = "Success!"
            Case Style._Warning
                styleText = "Warning!"
        End Select

        Dim styleFont As New Font(Font.FontFamily, Font.Size, FontStyle.Bold)
        Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
        G.DrawString(styleText, styleFont, New SolidBrush(textColor), New Point(10, textY))
        G.DrawString(Text, Font, New SolidBrush(textColor), New Point(10 + G.MeasureString(styleText, styleFont).Width + 4, textY))

        Dim exitFont As New Font("Marlett", 6)
        Dim exitY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString("r", exitFont).Height / 2) + 1
        exitLocation = New Point(Width - 26, exitY - 3)
        G.DrawString("r", exitFont, New SolidBrush(textColor), New Point(Width - 23, exitY))

    End Sub

End Class

