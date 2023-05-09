<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransfer))
        Me.Approved = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.ComboBox()
        Me.Acknowledged = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVSR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idstoremasuk = New System.Windows.Forms.Label()
        Me.idstorekeluar = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ANOTHERSTORE = New System.Windows.Forms.ComboBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtremaks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.daterex = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtitemno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblnamaitem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGVSR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Approved
        '
        Me.Approved.AutoSize = True
        Me.Approved.Location = New System.Drawing.Point(552, 104)
        Me.Approved.Name = "Approved"
        Me.Approved.Size = New System.Drawing.Size(53, 13)
        Me.Approved.TabIndex = 51
        Me.Approved.Text = "Approved"
        '
        'txtlocation
        '
        Me.txtlocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtlocation.FormattingEnabled = True
        Me.txtlocation.Location = New System.Drawing.Point(111, 72)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(101, 21)
        Me.txtlocation.TabIndex = 27
        '
        'Acknowledged
        '
        Me.Acknowledged.AutoSize = True
        Me.Acknowledged.Location = New System.Drawing.Point(626, 104)
        Me.Acknowledged.Name = "Acknowledged"
        Me.Acknowledged.Size = New System.Drawing.Size(78, 13)
        Me.Acknowledged.TabIndex = 52
        Me.Acknowledged.Text = "Acknowledged"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "From Store"
        '
        'DGVSR
        '
        Me.DGVSR.AllowUserToOrderColumns = True
        Me.DGVSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSR.Location = New System.Drawing.Point(13, 169)
        Me.DGVSR.Name = "DGVSR"
        Me.DGVSR.Size = New System.Drawing.Size(907, 291)
        Me.DGVSR.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.idstoremasuk)
        Me.GroupBox1.Controls.Add(Me.idstorekeluar)
        Me.GroupBox1.Controls.Add(Me.Approved)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.Acknowledged)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.ANOTHERSTORE)
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.txtremaks)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.daterex)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 134)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(559, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'idstoremasuk
        '
        Me.idstoremasuk.AutoSize = True
        Me.idstoremasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idstoremasuk.Location = New System.Drawing.Point(218, 99)
        Me.idstoremasuk.Name = "idstoremasuk"
        Me.idstoremasuk.Size = New System.Drawing.Size(0, 15)
        Me.idstoremasuk.TabIndex = 53
        '
        'idstorekeluar
        '
        Me.idstorekeluar.AutoSize = True
        Me.idstorekeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idstorekeluar.Location = New System.Drawing.Point(218, 73)
        Me.idstorekeluar.Name = "idstorekeluar"
        Me.idstorekeluar.Size = New System.Drawing.Size(0, 15)
        Me.idstorekeluar.TabIndex = 53
        '
        'btnclose
        '
        Me.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(853, 18)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(49, 44)
        Me.btnclose.TabIndex = 22
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(800, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(47, 43)
        Me.btnsave.TabIndex = 24
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ANOTHERSTORE
        '
        Me.ANOTHERSTORE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ANOTHERSTORE.FormattingEnabled = True
        Me.ANOTHERSTORE.Location = New System.Drawing.Point(111, 99)
        Me.ANOTHERSTORE.Name = "ANOTHERSTORE"
        Me.ANOTHERSTORE.Size = New System.Drawing.Size(101, 21)
        Me.ANOTHERSTORE.TabIndex = 15
        '
        'lbluser
        '
        Me.lbluser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(355, 15)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(175, 25)
        Me.lbluser.TabIndex = 13
        Me.lbluser.Text = "UserID"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtremaks
        '
        Me.txtremaks.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtremaks.Location = New System.Drawing.Point(272, 77)
        Me.txtremaks.Multiline = True
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(258, 43)
        Me.txtremaks.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create By : "
        '
        'daterex
        '
        Me.daterex.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.daterex.Location = New System.Drawing.Point(111, 47)
        Me.daterex.Name = "daterex"
        Me.daterex.Size = New System.Drawing.Size(85, 20)
        Me.daterex.TabIndex = 11
        Me.daterex.Value = New Date(2021, 2, 10, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remarks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(111, 20)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(116, 20)
        Me.txtno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Req. Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Store"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request-No"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(555, 44)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(69, 23)
        Me.btndelete.TabIndex = 28
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(664, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Total Amount  : "
        '
        'lblstock
        '
        Me.lblstock.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.Location = New System.Drawing.Point(445, 44)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(104, 21)
        Me.lblstock.TabIndex = 28
        Me.lblstock.Text = "Stock"
        Me.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(761, 15)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(141, 24)
        Me.lbltotal.TabIndex = 25
        Me.lbltotal.Text = "lbltotal"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(399, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 15)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "SOH"
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(764, 48)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(138, 24)
        Me.lblqty.TabIndex = 26
        Me.lblqty.Text = "totalqty"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblqty.Visible = False
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(555, 17)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(69, 23)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Qty"
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(269, 46)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(119, 19)
        Me.lblprice.TabIndex = 22
        Me.lblprice.Text = "Price"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(445, 19)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(104, 20)
        Me.txtqty.TabIndex = 21
        '
        'lblunit
        '
        Me.lblunit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(269, 17)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(119, 22)
        Me.lblunit.TabIndex = 20
        Me.lblunit.Text = "Unit"
        Me.lblunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(218, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Unit "
        '
        'txtitemno
        '
        Me.txtitemno.Location = New System.Drawing.Point(75, 47)
        Me.txtitemno.Name = "txtitemno"
        Me.txtitemno.Size = New System.Drawing.Size(137, 20)
        Me.txtitemno.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(218, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Price"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(14, 48)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(58, 15)
        Me.label20.TabIndex = 16
        Me.label20.Text = "No-Item"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblstock)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblqty)
        Me.GroupBox2.Controls.Add(Me.btninsert)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblprice)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.lblunit)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtitemno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.label20)
        Me.GroupBox2.Controls.Add(Me.lblnamaitem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 466)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(908, 79)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'lblnamaitem
        '
        Me.lblnamaitem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblnamaitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamaitem.ForeColor = System.Drawing.Color.Red
        Me.lblnamaitem.Location = New System.Drawing.Point(14, 16)
        Me.lblnamaitem.Name = "lblnamaitem"
        Me.lblnamaitem.Size = New System.Drawing.Size(198, 24)
        Me.lblnamaitem.TabIndex = 15
        Me.lblnamaitem.Text = "Name Item"
        Me.lblnamaitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-1, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(933, 23)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "TRANSFER ANOTHER STORE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(931, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVSR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVSR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Approved As Label
    Friend WithEvents txtlocation As ComboBox
    Friend WithEvents Acknowledged As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents DGVSR As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnclose As Button
    Friend WithEvents ANOTHERSTORE As ComboBox
    Friend WithEvents lbluser As Label
    Friend WithEvents txtremaks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents daterex As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblstock As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblqty As Label
    Friend WithEvents btninsert As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblunit As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtitemno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents label20 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblnamaitem As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents idstoremasuk As Label
    Friend WithEvents idstorekeluar As Label
    Friend WithEvents Label11 As Label
End Class
