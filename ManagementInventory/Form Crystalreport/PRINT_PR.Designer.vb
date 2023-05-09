<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINT_PR
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
        Me.ReportPR = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportPR
        '
        Me.ReportPR.ActiveViewIndex = -1
        Me.ReportPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportPR.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportPR.Location = New System.Drawing.Point(0, 0)
        Me.ReportPR.Name = "ReportPR"
        Me.ReportPR.Size = New System.Drawing.Size(800, 450)
        Me.ReportPR.TabIndex = 0
        Me.ReportPR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PRINT_PR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportPR)
        Me.Name = "PRINT_PR"
        Me.Text = "PRINT_PR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportPR As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
