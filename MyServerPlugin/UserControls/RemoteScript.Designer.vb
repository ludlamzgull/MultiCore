<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteScript
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.RMUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RMLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RMFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RMLanguage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RMStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RMUsername, Me.RMLocation, Me.RMFileName, Me.RMLanguage, Me.RMStatus})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 397)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'RMUsername
        '
        Me.RMUsername.Text = "Username"
        Me.RMUsername.Width = 75
        '
        'RMLocation
        '
        Me.RMLocation.Text = "File Location"
        Me.RMLocation.Width = 310
        '
        'RMFileName
        '
        Me.RMFileName.Text = "File Name"
        Me.RMFileName.Width = 90
        '
        'RMLanguage
        '
        Me.RMLanguage.Text = "Language"
        Me.RMLanguage.Width = 100
        '
        'RMStatus
        '
        Me.RMStatus.Text = "Status"
        Me.RMStatus.Width = 85
        '
        'RemoteScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Name = "RemoteScript"
        Me.Size = New System.Drawing.Size(760, 397)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents RMUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents RMLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents RMFileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents RMLanguage As System.Windows.Forms.ColumnHeader
    Friend WithEvents RMStatus As System.Windows.Forms.ColumnHeader

End Class
