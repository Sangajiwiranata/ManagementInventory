<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINT_PO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ReportPOBaru = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportPOBaru
        '
        Me.ReportPOBaru.ActiveViewIndex = -1
        Me.ReportPOBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportPOBaru.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportPOBaru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportPOBaru.Location = New System.Drawing.Point(0, 0)
        Me.ReportPOBaru.Name = "ReportPOBaru"
        Me.ReportPOBaru.Size = New System.Drawing.Size(921, 450)
        Me.ReportPOBaru.TabIndex = 0
        Me.ReportPOBaru.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PRINT_PO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 450)
        Me.Controls.Add(Me.ReportPOBaru)
        Me.Name = "PRINT_PO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINT_PO"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportPOBaru As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
