<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPO))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVPO = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.jmlhitem = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Approved = New System.Windows.Forms.Label()
        Me.Acknowledged = New System.Windows.Forms.Label()
        Me.DateNow = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtremaks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Delto = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsuplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nedeed = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnopr = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.daterex = New System.Windows.Forms.DateTimePicker()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.amount = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtdischarga = New System.Windows.Forms.TextBox()
        Me.txtppn = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.TextBox()
        Me.txtitemno = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.lblnamaitem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGVPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "PR Number"
        '
        'DGVPO
        '
        Me.DGVPO.AllowUserToAddRows = False
        Me.DGVPO.AllowUserToOrderColumns = True
        Me.DGVPO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPO.Location = New System.Drawing.Point(17, 259)
        Me.DGVPO.Name = "DGVPO"
        Me.DGVPO.Size = New System.Drawing.Size(921, 195)
        Me.DGVPO.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.jmlhitem)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Approved)
        Me.GroupBox1.Controls.Add(Me.Acknowledged)
        Me.GroupBox1.Controls.Add(Me.DateNow)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtremaks)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.credit)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblqty)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btninsert)
        Me.GroupBox1.Controls.Add(Me.txtfax)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Delto)
        Me.GroupBox1.Controls.Add(Me.txtnohp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsuplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nedeed)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtnopr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.daterex)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 216)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(716, 97)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 54
        Me.DateTimePicker1.Visible = False
        '
        'jmlhitem
        '
        Me.jmlhitem.AutoSize = True
        Me.jmlhitem.Location = New System.Drawing.Point(713, 156)
        Me.jmlhitem.Name = "jmlhitem"
        Me.jmlhitem.Size = New System.Drawing.Size(45, 13)
        Me.jmlhitem.TabIndex = 51
        Me.jmlhitem.Text = "Label25"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(679, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Label14"
        '
        'Approved
        '
        Me.Approved.AutoSize = True
        Me.Approved.Location = New System.Drawing.Point(494, 18)
        Me.Approved.Name = "Approved"
        Me.Approved.Size = New System.Drawing.Size(53, 13)
        Me.Approved.TabIndex = 50
        Me.Approved.Text = "Approved"
        '
        'Acknowledged
        '
        Me.Acknowledged.AutoSize = True
        Me.Acknowledged.Location = New System.Drawing.Point(568, 18)
        Me.Acknowledged.Name = "Acknowledged"
        Me.Acknowledged.Size = New System.Drawing.Size(78, 13)
        Me.Acknowledged.TabIndex = 50
        Me.Acknowledged.Text = "Acknowledged"
        '
        'DateNow
        '
        Me.DateNow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNow.Location = New System.Drawing.Point(136, 49)
        Me.DateNow.Name = "DateNow"
        Me.DateNow.Size = New System.Drawing.Size(88, 20)
        Me.DateNow.TabIndex = 47
        Me.DateNow.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(175, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "/Days"
        '
        'txtremaks
        '
        Me.txtremaks.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtremaks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtremaks.Location = New System.Drawing.Point(421, 179)
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(446, 20)
        Me.txtremaks.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(307, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 15)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Remarks"
        '
        'credit
        '
        Me.credit.Location = New System.Drawing.Point(136, 153)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(33, 20)
        Me.credit.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 15)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Term Of Payment"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(421, 125)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(275, 21)
        Me.txtalamat.TabIndex = 38
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(307, 154)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 15)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Delivery To"
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(594, 95)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(81, 24)
        Me.lblqty.TabIndex = 26
        Me.lblqty.Text = "totalqty"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblqty.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(307, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Address"
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(597, 72)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(63, 21)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        Me.btninsert.Visible = False
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(421, 99)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(157, 20)
        Me.txtfax.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(307, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Email"
        '
        'Delto
        '
        Me.Delto.Location = New System.Drawing.Point(421, 153)
        Me.Delto.Name = "Delto"
        Me.Delto.Size = New System.Drawing.Size(141, 20)
        Me.Delto.TabIndex = 34
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(421, 73)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(157, 20)
        Me.txtnohp.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(307, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Phone Number"
        '
        'txtsuplier
        '
        Me.txtsuplier.Location = New System.Drawing.Point(421, 44)
        Me.txtsuplier.Name = "txtsuplier"
        Me.txtsuplier.Size = New System.Drawing.Size(275, 20)
        Me.txtsuplier.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Supplier"
        '
        'nedeed
        '
        Me.nedeed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.nedeed.Location = New System.Drawing.Point(136, 126)
        Me.nedeed.Name = "nedeed"
        Me.nedeed.Size = New System.Drawing.Size(88, 20)
        Me.nedeed.TabIndex = 28
        Me.nedeed.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Delivery Date"
        '
        'txtnopr
        '
        Me.txtnopr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnopr.Location = New System.Drawing.Point(136, 74)
        Me.txtnopr.Name = "txtnopr"
        Me.txtnopr.Size = New System.Drawing.Size(152, 20)
        Me.txtnopr.TabIndex = 26
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(873, 18)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(43, 43)
        Me.btnclose.TabIndex = 22
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(823, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(44, 42)
        Me.btnsave.TabIndex = 24
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(418, 16)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(51, 15)
        Me.lbluser.TabIndex = 13
        Me.lbluser.Text = "UserID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create By "
        '
        'daterex
        '
        Me.daterex.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.daterex.Location = New System.Drawing.Point(136, 100)
        Me.daterex.Name = "daterex"
        Me.daterex.Size = New System.Drawing.Size(88, 20)
        Me.daterex.TabIndex = 11
        Me.daterex.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(136, 20)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(152, 20)
        Me.txtno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request-No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(586, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Total Amount  "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.amount)
        Me.GroupBox2.Controls.Add(Me.discount)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.lblunit)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblprice)
        Me.GroupBox2.Controls.Add(Me.txtitemno)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.label20)
        Me.GroupBox2.Controls.Add(Me.lblnamaitem)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 460)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 175)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.Location = New System.Drawing.Point(433, 21)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(36, 13)
        Me.amount.TabIndex = 39
        Me.amount.Text = "amout"
        Me.amount.Visible = False
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Location = New System.Drawing.Point(243, 21)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(47, 13)
        Me.discount.TabIndex = 38
        Me.discount.Text = "discount"
        Me.discount.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtdischarga)
        Me.GroupBox3.Controls.Add(Me.txtppn)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 66)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount And PPN"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(64, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 15)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "%"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(244, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 15)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "%"
        '
        'txtdischarga
        '
        Me.txtdischarga.Location = New System.Drawing.Point(15, 34)
        Me.txtdischarga.Name = "txtdischarga"
        Me.txtdischarga.Size = New System.Drawing.Size(44, 20)
        Me.txtdischarga.TabIndex = 32
        '
        'txtppn
        '
        Me.txtppn.Location = New System.Drawing.Point(191, 33)
        Me.txtppn.Name = "txtppn"
        Me.txtppn.Size = New System.Drawing.Size(47, 20)
        Me.txtppn.TabIndex = 30
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 15)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "Discount"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(188, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 15)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "PPN"
        '
        'txttotal
        '
        Me.txttotal.AutoSize = True
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(760, 25)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(39, 15)
        Me.txttotal.TabIndex = 29
        Me.txttotal.Text = "Total"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(730, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 15)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "Rp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(223, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Qty"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(286, 47)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(57, 20)
        Me.txtqty.TabIndex = 21
        '
        'lblunit
        '
        Me.lblunit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(75, 74)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(137, 22)
        Me.lblunit.TabIndex = 20
        Me.lblunit.Text = "Unit"
        Me.lblunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Unit "
        '
        'lblprice
        '
        Me.lblprice.Location = New System.Drawing.Point(307, 78)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(137, 20)
        Me.lblprice.TabIndex = 15
        '
        'txtitemno
        '
        Me.txtitemno.Location = New System.Drawing.Point(75, 47)
        Me.txtitemno.Name = "txtitemno"
        Me.txtitemno.Size = New System.Drawing.Size(137, 20)
        Me.txtitemno.TabIndex = 15
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(269, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(11, 15)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(269, 79)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 15)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = ": Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(223, 79)
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
        Me.Label9.Location = New System.Drawing.Point(16, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(922, 22)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "PURCHASE ORDER"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(954, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVPO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGVPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DGVPO As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents credit As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtfax As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsuplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nedeed As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnopr As TextBox
    Friend WithEvents btnclose As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lbluser As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents daterex As DateTimePicker
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents txtremaks As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateNow As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txttotal As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Delto As TextBox
    Friend WithEvents Approved As Label
    Friend WithEvents Acknowledged As Label
    Friend WithEvents lblprice As TextBox
    Friend WithEvents txtppn As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtdischarga As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents discount As Label
    Friend WithEvents amount As Label
    Friend WithEvents jmlhitem As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
