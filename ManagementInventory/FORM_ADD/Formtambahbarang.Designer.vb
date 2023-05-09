<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formtambahbarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NOITEM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GROUP = New System.Windows.Forms.ComboBox()
        Me.NAMAITEM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UNIT = New System.Windows.Forms.ComboBox()
        Me.PRICE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SUPLIER = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.INPUT = New System.Windows.Forms.Button()
        Me.TUTUP = New System.Windows.Forms.Button()
        Me.QTY = New System.Windows.Forms.Label()
        Me.AMOUNT = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Item"
        '
        'NOITEM
        '
        Me.NOITEM.Location = New System.Drawing.Point(123, 96)
        Me.NOITEM.Name = "NOITEM"
        Me.NOITEM.Size = New System.Drawing.Size(155, 20)
        Me.NOITEM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(332, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category"
        '
        'GROUP
        '
        Me.GROUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GROUP.FormattingEnabled = True
        Me.GROUP.Location = New System.Drawing.Point(412, 151)
        Me.GROUP.Name = "GROUP"
        Me.GROUP.Size = New System.Drawing.Size(155, 21)
        Me.GROUP.TabIndex = 5
        '
        'NAMAITEM
        '
        Me.NAMAITEM.Location = New System.Drawing.Point(123, 122)
        Me.NAMAITEM.Name = "NAMAITEM"
        Me.NAMAITEM.Size = New System.Drawing.Size(155, 20)
        Me.NAMAITEM.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit"
        '
        'UNIT
        '
        Me.UNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UNIT.FormattingEnabled = True
        Me.UNIT.Location = New System.Drawing.Point(412, 69)
        Me.UNIT.Name = "UNIT"
        Me.UNIT.Size = New System.Drawing.Size(155, 21)
        Me.UNIT.TabIndex = 2
        '
        'PRICE
        '
        Me.PRICE.Location = New System.Drawing.Point(412, 99)
        Me.PRICE.Name = "PRICE"
        Me.PRICE.Size = New System.Drawing.Size(155, 20)
        Me.PRICE.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(332, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price"
        '
        'SUPLIER
        '
        Me.SUPLIER.Location = New System.Drawing.Point(412, 125)
        Me.SUPLIER.Name = "SUPLIER"
        Me.SUPLIER.Size = New System.Drawing.Size(155, 20)
        Me.SUPLIER.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(332, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Supplier"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(757, 220)
        Me.DataGridView1.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(69, 188)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(698, 20)
        Me.TextBox5.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Search "
        '
        'INPUT
        '
        Me.INPUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.INPUT.Location = New System.Drawing.Point(667, 69)
        Me.INPUT.Name = "INPUT"
        Me.INPUT.Size = New System.Drawing.Size(83, 28)
        Me.INPUT.TabIndex = 15
        Me.INPUT.Text = "ADD"
        Me.INPUT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.INPUT.UseVisualStyleBackColor = True
        '
        'TUTUP
        '
        Me.TUTUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TUTUP.Location = New System.Drawing.Point(667, 103)
        Me.TUTUP.Name = "TUTUP"
        Me.TUTUP.Size = New System.Drawing.Size(83, 24)
        Me.TUTUP.TabIndex = 18
        Me.TUTUP.Text = "CLOSE"
        Me.TUTUP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.TUTUP.UseVisualStyleBackColor = True
        '
        'QTY
        '
        Me.QTY.AutoSize = True
        Me.QTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTY.Location = New System.Drawing.Point(301, 72)
        Me.QTY.Name = "QTY"
        Me.QTY.Size = New System.Drawing.Size(14, 13)
        Me.QTY.TabIndex = 19
        Me.QTY.Text = "0"
        Me.QTY.Visible = False
        '
        'AMOUNT
        '
        Me.AMOUNT.AutoSize = True
        Me.AMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMOUNT.Location = New System.Drawing.Point(301, 96)
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Size = New System.Drawing.Size(14, 13)
        Me.AMOUNT.TabIndex = 20
        Me.AMOUNT.Text = "0"
        Me.AMOUNT.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(760, 28)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ADD MASTER ITEM"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(301, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "0"
        Me.Label9.Visible = False
        '
        'txtMinimum
        '
        Me.txtMinimum.Location = New System.Drawing.Point(123, 148)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.Size = New System.Drawing.Size(155, 20)
        Me.txtMinimum.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Minimum Qty"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ID Descrption"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(301, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "0"
        Me.Label12.Visible = False
        '
        'Formtambahbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMinimum)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AMOUNT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.QTY)
        Me.Controls.Add(Me.TUTUP)
        Me.Controls.Add(Me.INPUT)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SUPLIER)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PRICE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UNIT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NAMAITEM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GROUP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NOITEM)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Formtambahbarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NOITEM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GROUP As ComboBox
    Friend WithEvents NAMAITEM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UNIT As ComboBox
    Friend WithEvents PRICE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SUPLIER As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents INPUT As Button
    Friend WithEvents TUTUP As Button
    Friend WithEvents QTY As Label
    Friend WithEvents AMOUNT As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
