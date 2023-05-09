<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSupplier
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
        Me.supplierlistpr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'supplierlistpr
        '
        Me.supplierlistpr.ActiveViewIndex = -1
        Me.supplierlistpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.supplierlistpr.Cursor = System.Windows.Forms.Cursors.Default
        Me.supplierlistpr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.supplierlistpr.Location = New System.Drawing.Point(0, 0)
        Me.supplierlistpr.Name = "supplierlistpr"
        Me.supplierlistpr.Size = New System.Drawing.Size(800, 450)
        Me.supplierlistpr.TabIndex = 0
        Me.supplierlistpr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.supplierlistpr)
        Me.Name = "ReportSupplier"
        Me.Text = "ReportSupplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents supplierlistpr As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
