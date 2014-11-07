<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StressMulti
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StressTesting1 = New MyNanoPluginNew.StressTesting()
        Me.OverallStress1 = New MyNanoPluginNew.OverallStress()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(702, 408)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.StressTesting1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stress Testing"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.OverallStress1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overall Stress"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StressTesting1
        '
        Me.StressTesting1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StressTesting1.Location = New System.Drawing.Point(3, 3)
        Me.StressTesting1.Name = "StressTesting1"
        Me.StressTesting1.Size = New System.Drawing.Size(688, 376)
        Me.StressTesting1.TabIndex = 0
        '
        'OverallStress1
        '
        Me.OverallStress1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverallStress1.Location = New System.Drawing.Point(3, 3)
        Me.OverallStress1.Name = "OverallStress1"
        Me.OverallStress1.Size = New System.Drawing.Size(688, 376)
        Me.OverallStress1.TabIndex = 0
        '
        'StressMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "StressMulti"
        Me.Size = New System.Drawing.Size(702, 408)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StressTesting1 As MyNanoPluginNew.StressTesting
    Friend WithEvents OverallStress1 As MyNanoPluginNew.OverallStress

End Class
