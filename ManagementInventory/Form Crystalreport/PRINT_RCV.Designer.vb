<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINT_RCV
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
        Me.ReportRcvBaru = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportRcvBaru
        '
        Me.ReportRcvBaru.ActiveViewIndex = -1
        Me.ReportRcvBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportRcvBaru.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportRcvBaru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportRcvBaru.Location = New System.Drawing.Point(0, 0)
        Me.ReportRcvBaru.Name = "ReportRcvBaru"
        Me.ReportRcvBaru.Size = New System.Drawing.Size(800, 450)
        Me.ReportRcvBaru.TabIndex = 0
        Me.ReportRcvBaru.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PRINT_RCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportRcvBaru)
        Me.Name = "PRINT_RCV"
        Me.Text = "PRINT_RCV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportRcvBaru As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
