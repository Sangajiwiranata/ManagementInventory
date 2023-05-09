Imports MySql.Data.MySqlClient
Public Class TRF_EDIT
    Sub kondisiawal()
        lblprice.Enabled = False
        txtlocation.Enabled = False
        department.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        daterex.Enabled = False
        txtno.Enabled = False
        'ComboBox1.Enabled = False
        Label8.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = True
        Label7.Text = ""
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        isiform()
        buatKolom()
    End Sub
    Sub buatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("KodeBarang", "No Item")
        DataGridView1.Columns.Add("NamaBarang", "Description")
        DataGridView1.Columns.Add("Satuan", "Unit")
        DataGridView1.Columns.Add("Jumlah", "Qty")
        DataGridView1.Columns.Add("harga", "Price")
        DataGridView1.Columns.Add("total", "Amount")

        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(4).Width = 170
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 90
        DataGridView1.Columns(5).Width = 200
    End Sub
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, qty, harga, total from tbl_trfdetail Where notrf='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVSR.DataSource = (DS.Tables(0))
        DGVSR.ReadOnly = True

        DGVSR.RowHeadersVisible = False
        'DGVSR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSR.Columns(0).Width = 80
        DGVSR.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVSR.Columns(3).Width = 50

        DGVSR.Columns(4).DefaultCellStyle.Format = "##,0.00"
        DGVSR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSR.Columns(5).DefaultCellStyle.Format = "##,0.00"
        DGVSR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



        DGVSR.Columns(0).HeaderText = "No Item"
        DGVSR.Columns(1).HeaderText = "Description"
        DGVSR.Columns(2).HeaderText = "Unit"
        DGVSR.Columns(3).HeaderText = "OnHand"
        DGVSR.Columns(4).HeaderText = "Price"
        DGVSR.Columns(5).HeaderText = "Amount"
    End Sub

    Private Sub TRF_EDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kondisiawal()

        If Form1MenuUtama.StatusDept.Text <> "IT" Then
            DGVSR.Columns(4).Visible = False
            DGVSR.Columns(5).Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label7.Text = Form1MenuUtama.StatusUser.Text
            CheckBox1.Enabled = False
        Else
            CheckBox1.Checked = False
            Label7.Text = ""

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        'Dim pesan As String

        If CheckBox2.Checked Then
            If Label7.Text = "" Then
                MsgBox("Please Approved", MsgBoxStyle.Critical, "Information")
                CheckBox2.Checked = False
            Else
                Label8.Text = Form1MenuUtama.StatusUser.Text
                CheckBox2.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If CheckBox1.Checked Then
            Dim update As String = "update tbl_trf set approved ='" & Label7.Text & "' where notrf='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            'TRF_LIST.kondisiAwal()
        End If

        If CheckBox2.Checked Then
            Dim update As String = "update tbl_trf set Acknowledged ='" & Label8.Text & "' where notrf='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
            'Me.Close()
            'TRF_LIST.kondisiAwal()
            For baris As Integer = 0 To DGVSR.Rows.Count - 1
                Dim transaksibarangMasuk As String = "insert into tbl_transaksibarang values('" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & CDbl(DGVSR.Rows(baris).Cells(4).Value) & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & "0" & "','" & idstoremasuk.Text & "')"
                CMD = New MySqlCommand(transaksibarangMasuk, Konn)
                CMD.ExecuteNonQuery()

                Dim transaksibarangKeluar As String = "insert into tbl_transaksibarang values('" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & CDbl(DGVSR.Rows(baris).Cells(4).Value) & "','" & "0" & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & idstorekeluar.Text & "')"
                CMD = New MySqlCommand(transaksibarangKeluar, Konn)
                CMD.ExecuteNonQuery()
            Next
            Me.Close()
        End If
        MsgBox("Update Success", MsgBoxStyle.Information, "Information!!")
        TRF_LIST.kondisiAwal()
    End Sub
End Class