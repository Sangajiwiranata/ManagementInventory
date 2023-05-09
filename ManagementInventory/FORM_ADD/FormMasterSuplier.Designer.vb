<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterSuplier
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idsuplier = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.namasuplier = New System.Windows.Forms.TextBox()
        Me.tlpn = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.INPUT = New System.Windows.Forms.Button()
        Me.TUTUP = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'idsuplier
        '
        Me.idsuplier.Location = New System.Drawing.Point(153, 71)
        Me.idsuplier.Name = "idsuplier"
        Me.idsuplier.Size = New System.Drawing.Size(100, 20)
        Me.idsuplier.TabIndex = 6
        '
        'alamat
        '
        Me.alamat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alamat.Location = New System.Drawing.Point(452, 71)
        Me.alamat.Multiline = True
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(253, 38)
        Me.alamat.TabIndex = 7
        '
        'type
        '
        Me.type.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.type.Location = New System.Drawing.Point(452, 115)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(116, 20)
        Me.type.TabIndex = 8
        '
        'namasuplier
        '
        Me.namasuplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.namasuplier.Location = New System.Drawing.Point(153, 94)
        Me.namasuplier.Name = "namasuplier"
        Me.namasuplier.Size = New System.Drawing.Size(191, 20)
        Me.namasuplier.TabIndex = 9
        '
        'tlpn
        '
        Me.tlpn.Location = New System.Drawing.Point(153, 117)
        Me.tlpn.Name = "tlpn"
        Me.tlpn.Size = New System.Drawing.Size(113, 20)
        Me.tlpn.TabIndex = 10
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(153, 140)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(178, 20)
        Me.email.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 242)
        Me.DataGridView1.TabIndex = 12
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(76, 170)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(712, 20)
        Me.cari.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Search "
        '
        'INPUT
        '
        Me.INPUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INPUT.Location = New System.Drawing.Point(632, 444)
        Me.INPUT.Name = "INPUT"
        Me.INPUT.Size = New System.Drawing.Size(75, 23)
        Me.INPUT.TabIndex = 15
        Me.INPUT.Text = "ADD"
        Me.INPUT.UseVisualStyleBackColor = True
        '
        'TUTUP
        '
        Me.TUTUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUTUP.Location = New System.Drawing.Point(713, 444)
        Me.TUTUP.Name = "TUTUP"
        Me.TUTUP.Size = New System.Drawing.Size(75, 23)
        Me.TUTUP.TabIndex = 16
        Me.TUTUP.Text = "CLOSE"
        Me.TUTUP.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(775, 30)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "ADD MASTER SUPPLIER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(551, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormMasterSuplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TUTUP)
        Me.Controls.Add(Me.INPUT)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.tlpn)
        Me.Controls.Add(Me.namasuplier)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.idsuplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMasterSuplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents idsuplier As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents namasuplier As TextBox
    Friend WithEvents tlpn As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents INPUT As Button
    Friend WithEvents TUTUP As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
