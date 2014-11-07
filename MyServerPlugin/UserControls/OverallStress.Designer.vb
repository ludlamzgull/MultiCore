<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverallStress
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Graph1 = New MyNanoPluginNew.Graph()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Graph1
        '
        Me.Graph1.BorderColor = System.Drawing.Color.Gray
        Me.Graph1.DataColumnForeColor = System.Drawing.Color.Gray
        Me.Graph1.DataSmoothing = True
        Me.Graph1.DataSmoothingLevel = CType(1, Byte)
        Me.Graph1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Graph1.DrawDataColumn = True
        Me.Graph1.DrawHorizontalLines = True
        Me.Graph1.DrawHoverData = True
        Me.Graph1.DrawHoverLine = True
        Me.Graph1.DrawLineGraph = False
        Me.Graph1.DrawVerticalLines = False
        Me.Graph1.FillColor = System.Drawing.Color.White
        Me.Graph1.FormatString = Nothing
        Me.Graph1.GraphBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph1.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Graph1.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Graph1.HoverBorderColor = System.Drawing.Color.ForestGreen
        Me.Graph1.HoverFillColor = System.Drawing.Color.White
        Me.Graph1.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.Graph1.HoverLabelFillColor = System.Drawing.Color.White
        Me.Graph1.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.Graph1.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Graph1.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Graph1.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Graph1.Location = New System.Drawing.Point(0, 0)
        Me.Graph1.Name = "Graph1"
        Me.Graph1.OverrideMax = False
        Me.Graph1.OverrideMaxValue = 100.0!
        Me.Graph1.OverrideMin = False
        Me.Graph1.OverrideMinValue = 0.0!
        Me.Graph1.SidePadding = True
        Me.Graph1.Size = New System.Drawing.Size(774, 427)
        Me.Graph1.TabIndex = 7
        Me.Graph1.Text = "Graph1"
        Me.Graph1.Values = New Single(-1) {}
        Me.Graph1.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TrackBar1.Location = New System.Drawing.Point(0, 427)
        Me.TrackBar1.Maximum = 9
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(774, 45)
        Me.TrackBar1.TabIndex = 6
        '
        'OverallStress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Graph1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "OverallStress"
        Me.Size = New System.Drawing.Size(774, 472)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Graph1 As MyNanoPluginNew.Graph
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar

End Class
