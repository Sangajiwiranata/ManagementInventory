<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPR))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtitemno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.lblnamaitem = New System.Windows.Forms.Label()
        Me.DGVPR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.Label()
        Me.jmlhitem = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.idstorekeluar = New System.Windows.Forms.Label()
        Me.Acknowledged = New System.Windows.Forms.Label()
        Me.Approve = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.dateneed = New System.Windows.Forms.DateTimePicker()
        Me.txtremaks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.daterex = New System.Windows.Forms.DateTimePicker()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblqty)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 607)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1271, 97)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(573, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 22)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(839, 59)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(795, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Total Amount  : "
        '
        'lblqty
        '
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(944, 53)
        Me.lblqty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(184, 30)
        Me.lblqty.TabIndex = 26
        Me.lblqty.Text = "totalqty"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblqty.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(940, 15)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(188, 30)
        Me.lbltotal.TabIndex = 25
        Me.lbltotal.Text = "lbltotal"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(747, 58)
        Me.btninsert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(84, 28)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        Me.btninsert.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(529, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Qty"
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(348, 53)
        Me.lblprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(156, 30)
        Me.lblprice.TabIndex = 22
        Me.lblprice.Text = "Price"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(573, 25)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(64, 22)
        Me.txtqty.TabIndex = 21
        '
        'lblunit
        '
        Me.lblunit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(348, 20)
        Me.lblunit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(156, 30)
        Me.lblunit.TabIndex = 20
        Me.lblunit.Text = "Unit"
        Me.lblunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(291, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Unit "
        '
        'txtitemno
        '
        Me.txtitemno.Location = New System.Drawing.Point(100, 58)
        Me.txtitemno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtitemno.Name = "txtitemno"
        Me.txtitemno.Size = New System.Drawing.Size(181, 22)
        Me.txtitemno.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(291, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Price"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(19, 59)
        Me.label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(68, 18)
        Me.label20.TabIndex = 16
        Me.label20.Text = "No-Item"
        '
        'lblnamaitem
        '
        Me.lblnamaitem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblnamaitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamaitem.ForeColor = System.Drawing.Color.Red
        Me.lblnamaitem.Location = New System.Drawing.Point(19, 20)
        Me.lblnamaitem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnamaitem.Name = "lblnamaitem"
        Me.lblnamaitem.Size = New System.Drawing.Size(264, 30)
        Me.lblnamaitem.TabIndex = 15
        Me.lblnamaitem.Text = "Name Item"
        Me.lblnamaitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVPR
        '
        Me.DGVPR.AllowUserToOrderColumns = True
        Me.DGVPR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPR.Location = New System.Drawing.Point(17, 224)
        Me.DGVPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVPR.Name = "DGVPR"
        Me.DGVPR.ReadOnly = True
        Me.DGVPR.RowHeadersWidth = 51
        Me.DGVPR.Size = New System.Drawing.Size(1269, 375)
        Me.DGVPR.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.jmlhitem)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.idstorekeluar)
        Me.GroupBox1.Controls.Add(Me.Acknowledged)
        Me.GroupBox1.Controls.Add(Me.Approve)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.dateneed)
        Me.GroupBox1.Controls.Add(Me.txtremaks)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.daterex)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 176)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 28)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoSize = True
        Me.ComboBox1.Location = New System.Drawing.Point(573, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(51, 17)
        Me.ComboBox1.TabIndex = 33
        Me.ComboBox1.Text = "Label5"
        '
        'jmlhitem
        '
        Me.jmlhitem.AutoSize = True
        Me.jmlhitem.Location = New System.Drawing.Point(1076, 148)
        Me.jmlhitem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.jmlhitem.Name = "jmlhitem"
        Me.jmlhitem.Size = New System.Drawing.Size(51, 17)
        Me.jmlhitem.TabIndex = 32
        Me.jmlhitem.Text = "Label5"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(1137, 23)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(55, 47)
        Me.btnsave.TabIndex = 31
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'idstorekeluar
        '
        Me.idstorekeluar.AutoSize = True
        Me.idstorekeluar.Location = New System.Drawing.Point(1175, 148)
        Me.idstorekeluar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idstorekeluar.Name = "idstorekeluar"
        Me.idstorekeluar.Size = New System.Drawing.Size(16, 17)
        Me.idstorekeluar.TabIndex = 30
        Me.idstorekeluar.Text = "0"
        Me.idstorekeluar.Visible = False
        '
        'Acknowledged
        '
        Me.Acknowledged.AutoSize = True
        Me.Acknowledged.Location = New System.Drawing.Point(143, 148)
        Me.Acknowledged.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Acknowledged.Name = "Acknowledged"
        Me.Acknowledged.Size = New System.Drawing.Size(114, 17)
        Me.Acknowledged.TabIndex = 29
        Me.Acknowledged.Text = "Acknowledgedby"
        Me.Acknowledged.Visible = False
        '
        'Approve
        '
        Me.Approve.AutoSize = True
        Me.Approve.Location = New System.Drawing.Point(44, 148)
        Me.Approve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Approve.Name = "Approve"
        Me.Approve.Size = New System.Drawing.Size(61, 17)
        Me.Approve.TabIndex = 29
        Me.Approve.Text = "Approve"
        Me.Approve.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(427, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(511, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnclose
        '
        Me.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(1200, 25)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(57, 48)
        Me.btnclose.TabIndex = 22
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(547, 55)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(60, 18)
        Me.lbluser.TabIndex = 13
        Me.lbluser.Text = "UserID"
        '
        'dateneed
        '
        Me.dateneed.Location = New System.Drawing.Point(161, 96)
        Me.dateneed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateneed.Name = "dateneed"
        Me.dateneed.Size = New System.Drawing.Size(201, 22)
        Me.dateneed.TabIndex = 12
        Me.dateneed.Value = New Date(2021, 2, 10, 14, 17, 0, 0)
        '
        'txtremaks
        '
        Me.txtremaks.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtremaks.Location = New System.Drawing.Point(427, 107)
        Me.txtremaks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtremaks.Multiline = True
        Me.txtremaks.Name = "txtremaks"
        Me.txtremaks.Size = New System.Drawing.Size(509, 57)
        Me.txtremaks.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(423, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create By : "
        '
        'daterex
        '
        Me.daterex.Location = New System.Drawing.Point(161, 60)
        Me.daterex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.daterex.Name = "daterex"
        Me.daterex.Size = New System.Drawing.Size(201, 22)
        Me.daterex.TabIndex = 11
        Me.daterex.Value = New Date(2021, 2, 10, 14, 17, 0, 0)
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(161, 25)
        Me.txtno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(241, 22)
        Me.txtno.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Delivery Date "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Request Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request-No"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-1, 4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1304, 28)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "PURCHASE REQUISITION"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1303, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGVPR)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormPR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblqty As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btninsert As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblprice As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblunit As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtitemno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents label20 As Label
    Friend WithEvents lblnamaitem As Label
    Friend WithEvents DGVPR As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbluser As Label
    Friend WithEvents dateneed As DateTimePicker
    Friend WithEvents txtremaks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents daterex As DateTimePicker
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Acknowledged As Label
    Friend WithEvents Approve As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents idstorekeluar As Label
    Friend WithEvents jmlhitem As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As Label
End Class
