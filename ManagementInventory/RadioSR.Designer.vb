<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadioSR
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
        Me.radiobuttonSR = New System.Windows.Forms.RadioButton()
        Me.RadiobuttonTrf = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Requisition = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radiobuttonSR
        '
        Me.radiobuttonSR.AutoSize = True
        Me.radiobuttonSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobuttonSR.Location = New System.Drawing.Point(56, 43)
        Me.radiobuttonSR.Name = "radiobuttonSR"
        Me.radiobuttonSR.Size = New System.Drawing.Size(145, 20)
        Me.radiobuttonSR.TabIndex = 0
        Me.radiobuttonSR.TabStop = True
        Me.radiobuttonSR.Text = "Store Requisition"
        Me.radiobuttonSR.UseVisualStyleBackColor = True
        '
        'RadiobuttonTrf
        '
        Me.RadiobuttonTrf.AutoSize = True
        Me.RadiobuttonTrf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadiobuttonTrf.Location = New System.Drawing.Point(56, 74)
        Me.RadiobuttonTrf.Name = "RadiobuttonTrf"
        Me.RadiobuttonTrf.Size = New System.Drawing.Size(182, 20)
        Me.RadiobuttonTrf.TabIndex = 0
        Me.RadiobuttonTrf.TabStop = True
        Me.RadiobuttonTrf.Text = "Transfer Another Store"
        Me.RadiobuttonTrf.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Requisition
        '
        Me.Requisition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requisition.Location = New System.Drawing.Point(12, 9)
        Me.Requisition.Name = "Requisition"
        Me.Requisition.Size = New System.Drawing.Size(290, 37)
        Me.Requisition.TabIndex = 6
        Me.Requisition.Text = "Requisition"
        Me.Requisition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobuttonSR)
        Me.GroupBox1.Controls.Add(Me.RadiobuttonTrf)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 161)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'RadioSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Requisition)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RadioSR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radiobuttonSR As RadioButton
    Friend WithEvents RadiobuttonTrf As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Requisition As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
