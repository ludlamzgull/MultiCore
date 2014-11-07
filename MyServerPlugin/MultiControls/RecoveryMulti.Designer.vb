<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoveryMulti
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
        Me.Recovery1 = New MyNanoPluginNew.Recovery()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LiveLogs1 = New MyNanoPluginNew.LiveLogs()
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
        Me.TabControl1.ItemSize = New System.Drawing.Size(110, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(759, 402)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Recovery1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(751, 376)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stored Passwords"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Recovery1
        '
        Me.Recovery1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Recovery1.Location = New System.Drawing.Point(3, 3)
        Me.Recovery1.Name = "Recovery1"
        Me.Recovery1.Size = New System.Drawing.Size(745, 370)
        Me.Recovery1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LiveLogs1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(751, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Load Passwords"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LiveLogs1
        '
        Me.LiveLogs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiveLogs1.Location = New System.Drawing.Point(3, 3)
        Me.LiveLogs1.Name = "LiveLogs1"
        Me.LiveLogs1.Size = New System.Drawing.Size(745, 370)
        Me.LiveLogs1.TabIndex = 0
        '
        'RecoveryMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "RecoveryMulti"
        Me.Size = New System.Drawing.Size(759, 402)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Recovery1 As MyNanoPluginNew.Recovery
    Friend WithEvents LiveLogs1 As MyNanoPluginNew.LiveLogs

End Class
