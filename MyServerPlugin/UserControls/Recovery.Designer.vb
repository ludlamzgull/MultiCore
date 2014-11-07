<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recovery
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recovery))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MCName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MCID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MCSource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MCHost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MCUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MCPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MCName, Me.MCID, Me.MCSource, Me.MCHost, Me.MCUsername, Me.MCPassword})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(720, 414)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'MCName
        '
        Me.MCName.Text = "Client Name"
        Me.MCName.Width = 103
        '
        'MCID
        '
        Me.MCID.Text = "ID"
        Me.MCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MCID.Width = 47
        '
        'MCSource
        '
        Me.MCSource.Text = "Source"
        Me.MCSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MCSource.Width = 93
        '
        'MCHost
        '
        Me.MCHost.Text = "Host"
        Me.MCHost.Width = 176
        '
        'MCUsername
        '
        Me.MCUsername.Text = "Username"
        Me.MCUsername.Width = 117
        '
        'MCPassword
        '
        Me.MCPassword.Text = "Password"
        Me.MCPassword.Width = 113
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.CopyDataToolStripMenuItem, Me.ExportDataToolStripMenuItem, Me.ClearDataToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 82)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'CopyDataToolStripMenuItem
        '
        Me.CopyDataToolStripMenuItem.Name = "CopyDataToolStripMenuItem"
        Me.CopyDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CopyDataToolStripMenuItem.Text = "Copy Data"
        '
        'ExportDataToolStripMenuItem
        '
        Me.ExportDataToolStripMenuItem.Name = "ExportDataToolStripMenuItem"
        Me.ExportDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExportDataToolStripMenuItem.Text = "Export Data"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ClearDataToolStripMenuItem.Text = "Clear Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(119, 154)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(360, 170)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Recovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Recovery"
        Me.Size = New System.Drawing.Size(720, 414)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents MCName As System.Windows.Forms.ColumnHeader
    Friend WithEvents MCID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MCSource As System.Windows.Forms.ColumnHeader
    Friend WithEvents MCHost As System.Windows.Forms.ColumnHeader
    Friend WithEvents MCUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents MCPassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ClearDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
