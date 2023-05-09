<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SRPRINT
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
        Me.CRVSR = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVSR
        '
        Me.CRVSR.ActiveViewIndex = -1
        Me.CRVSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVSR.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVSR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVSR.Location = New System.Drawing.Point(0, 0)
        Me.CRVSR.Name = "CRVSR"
        Me.CRVSR.Size = New System.Drawing.Size(800, 450)
        Me.CRVSR.TabIndex = 0
        Me.CRVSR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SRPRINT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CRVSR)
        Me.Name = "SRPRINT"
        Me.Text = "SRPRINT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVSR As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
