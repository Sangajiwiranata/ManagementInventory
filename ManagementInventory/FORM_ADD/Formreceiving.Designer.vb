<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreceiving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formreceiving))
        Me.DGVRCV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.jmlhitem = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.topdays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Acknowledged = New System.Windows.Forms.Label()
        Me.Approve = New System.Windows.Forms.Label()
        Me.lblalamat = New System.Windows.Forms.TextBox()
        Me.lblemailsuplier = New System.Windows.Forms.TextBox()
        Me.lbltlpsuplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsuplier = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnopo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtremaks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.lblprice = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtitemno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.lblnamaitem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGVRCV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVRCV
        '
        Me.DGVRCV.AllowUserToOrderColumns = True
        Me.DGVRCV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVRCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRCV.Location = New System.Drawing.Point(17, 231)
        Me.DGVRCV.Name = "DGVRCV"
        Me.DGVRCV.ReadOnly = True
        Me.DGVRCV.Size = New System.Drawing.Size(864, 233)
        Me.DGVRCV.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.jmlhitem)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.topdays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Acknowledged)
        Me.GroupBox1.Controls.Add(Me.Approve)
        Me.GroupBox1.Controls.Add(Me.lblalamat)
        Me.GroupBox1.Controls.Add(Me.lblemailsuplier)
        Me.GroupBox1.Controls.Add(Me.lbltlpsuplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtsuplier)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtnopo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.txtremaks)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 188)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'jmlhitem
        '
        Me.jmlhitem.AutoSize = True
        Me.jmlhitem.Location = New System.Drawing.Point(653, 22)
        Me.jmlhitem.Name = "jmlhitem"
        Me.jmlhitem.Size = New System.Drawing.Size(45, 13)
        Me.jmlhitem.TabIndex = 52
        Me.jmlhitem.Text = "Label16"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(19, 150)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker2.TabIndex = 51
        Me.DateTimePicker2.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(650, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Label14"
        Me.Label14.Visible = False
        '
        'topdays
        '
        Me.topdays.Location = New System.Drawing.Point(115, 68)
        Me.topdays.Name = "topdays"
        Me.topdays.Size = New System.Drawing.Size(55, 20)
        Me.topdays.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "TOP"
        '
        'Acknowledged
        '
        Me.Acknowledged.AutoSize = True
        Me.Acknowledged.Location = New System.Drawing.Point(760, 149)
        Me.Acknowledged.Name = "Acknowledged"
        Me.Acknowledged.Size = New System.Drawing.Size(89, 13)
        Me.Acknowledged.TabIndex = 36
        Me.Acknowledged.Text = "Acknowledgedby"
        Me.Acknowledged.Visible = False
        '
        'Approve
        '
        Me.Approve.AutoSize = True
        Me.Approve.Location = New System.Drawing.Point(686, 149)
        Me.Approve.Name = "Approve"
        Me.Approve.Size = New System.Drawing.Size(47, 13)
        Me.Approve.TabIndex = 37
        Me.Approve.Text = "Approve"
        Me.Approve.Visible = False
        '
        'lblalamat
        '
        Me.lblalamat.Location = New System.Drawing.Point(413, 93)
        Me.lblalamat.Multiline = True
        Me.lblalamat.Name = "lblalamat"
        Me.lblalamat.Size = New System.Drawing.Size(232, 50)
        Me.lblalamat.TabIndex = 46
        '
        'lblemailsuplier
        '
        Me.lblemailsuplier.Location = New System.Drawing.Point(413, 70)
        Me.lblemailsuplier.Name = "lblemailsuplier"
        Me.lblemailsuplier.Size = New System.Drawing.Size(145, 20)
        Me.lblemailsuplier.TabIndex = 45
        '
        'lbltlpsuplier
        '
        Me.lbltlpsuplier.Location = New System.Drawing.Point(413, 45)
        Me.lbltlpsuplier.Name = "lbltlpsuplier"
        Me.lbltlpsuplier.Size = New System.Drawing.Size(145, 20)
        Me.lbltlpsuplier.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Address"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 91)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2021, 2, 10, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Date "
        '
        'txtsuplier
        '
        Me.txtsuplier.Location = New System.Drawing.Point(413, 21)
        Me.txtsuplier.Name = "txtsuplier"
        Me.txtsuplier.Size = New System.Drawing.Size(177, 20)
        Me.txtsuplier.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(295, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 15)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(296, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 15)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Phone Number "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(295, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Supplier"
        '
        'txtnopo
        '
        Me.txtnopo.Location = New System.Drawing.Point(115, 46)
        Me.txtnopo.Name = "txtnopo"
        Me.txtnopo.Size = New System.Drawing.Size(152, 20)
        Me.txtnopo.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "PO - Number"
        '
        'btnclose
        '
        Me.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(816, 9)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 44)
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
        Me.btnsave.Location = New System.Drawing.Point(768, 9)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(42, 43)
        Me.btnsave.TabIndex = 24
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(112, 118)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(51, 15)
        Me.lbluser.TabIndex = 13
        Me.lbluser.Text = "UserID"
        '
        'txtremaks
        '
        Me.txtremaks.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtremaks.Location = New System.Drawing.Point(293, 146)
        Me.txtremaks.Multiline = True
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(349, 25)
        Me.txtremaks.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create By "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remarks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(115, 20)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(152, 20)
        Me.txtno.TabIndex = 4
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(607, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Total Amount  : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.btndelete)
        Me.GroupBox2.Controls.Add(Me.lblprice)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.lblqty)
        Me.GroupBox2.Controls.Add(Me.btninsert)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.lblunit)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtitemno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.label20)
        Me.GroupBox2.Controls.Add(Me.lblnamaitem)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 470)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 79)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(388, 45)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(104, 20)
        Me.btndelete.TabIndex = 36
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'lblprice
        '
        Me.lblprice.Location = New System.Drawing.Point(264, 47)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(104, 20)
        Me.lblprice.TabIndex = 28
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(704, 15)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(141, 24)
        Me.lbltotal.TabIndex = 25
        Me.lbltotal.Text = "lbltotal"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(707, 48)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(138, 24)
        Me.lblqty.TabIndex = 26
        Me.lblqty.Text = "totalqty"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblqty.Visible = False
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(544, 19)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(43, 21)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        Me.btninsert.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(341, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Qty"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(388, 19)
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
        Me.lblunit.Size = New System.Drawing.Size(62, 22)
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
        Me.Label9.Location = New System.Drawing.Point(3, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(890, 35)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "RECEIVING"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Formreceiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(897, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVRCV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Formreceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVRCV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVRCV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnopo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lbluser As Label
    Friend WithEvents txtremaks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblqty As Label
    Friend WithEvents btninsert As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblunit As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtitemno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents label20 As Label
    Friend WithEvents lblnamaitem As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtsuplier As TextBox
    Friend WithEvents lblprice As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblalamat As TextBox
    Friend WithEvents lblemailsuplier As TextBox
    Friend WithEvents lbltlpsuplier As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents Acknowledged As Label
    Friend WithEvents Approve As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents topdays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents jmlhitem As Label
End Class
