<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormREPORTRECEIVING
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormREPORTRECEIVING))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBtgl = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Item = New System.Windows.Forms.Label()
        Me.ReportRCV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CBtgl)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Item)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 78)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'CBtgl
        '
        Me.CBtgl.AutoSize = True
        Me.CBtgl.Location = New System.Drawing.Point(206, 21)
        Me.CBtgl.Name = "CBtgl"
        Me.CBtgl.Size = New System.Drawing.Size(15, 14)
        Me.CBtgl.TabIndex = 11
        Me.CBtgl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 20)
        Me.TextBox1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(91, 18)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker2.TabIndex = 6
        Me.DateTimePicker2.Value = New Date(2021, 2, 17, 0, 0, 0, 0)
        '
        'Item
        '
        Me.Item.AutoSize = True
        Me.Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.Location = New System.Drawing.Point(18, 47)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(67, 13)
        Me.Item.TabIndex = 4
        Me.Item.Text = "Name Item"
        '
        'ReportRCV
        '
        Me.ReportRCV.ActiveViewIndex = -1
        Me.ReportRCV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportRCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportRCV.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportRCV.Location = New System.Drawing.Point(0, 85)
        Me.ReportRCV.Name = "ReportRCV"
        Me.ReportRCV.ShowLogo = False
        Me.ReportRCV.Size = New System.Drawing.Size(800, 362)
        Me.ReportRCV.TabIndex = 7
        Me.ReportRCV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormREPORTRECEIVING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportRCV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormREPORTRECEIVING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Item As Label
    Friend WithEvents ReportRCV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CBtgl As CheckBox
End Class
