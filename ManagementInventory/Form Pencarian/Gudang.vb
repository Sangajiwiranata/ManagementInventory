Imports MySql.Data.MySqlClient
Public Class Gudang
    Sub TAMPILBARANG()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT
	            idbarang,namabarang,jenisbarang,
	            SUM(CASE 
	            WHEN lokasi = '" & lblidgudang.Text & "'	THEN
		            masuk - keluar
		            ELSE 0 END) as saldototal, price, lokasi FROM
	            tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True


        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next
        'DataGridView1.Columns(6).HeaderText = "Group"
        'DataGridView1.Columns(7).HeaderText = "Supplier"
    End Sub
    Sub comboboxstore()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            txtlocation.Items.Add(DR.Item(1))
        Loop

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.DataSource = Nothing
        txtlocation.Items.Clear()
        comboboxstore()
        DS = New DataSet
        TAMPILBARANG()
        'txtlocation.Text = ""

        'DataGridView1.DataSource = Nothing
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DataGridView1.Columns(1).Width = 290
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 130
        DataGridView1.Columns(5).Width = 170
        'DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(0).HeaderText = "No-Item"
        DataGridView1.Columns(1).HeaderText = "Description"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "##,0.00"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "##,0.00"

        If Form1MenuUtama.StatusDept.Text <> "IT" Then
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
        End If
    End Sub

    Private Sub txtlocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlocation.SelectedIndexChanged
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store ='" & txtlocation.Text & "'", Konn)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            lblidgudang.Text = DR.Item("id_store")
        End If
    End Sub

    Private Sub lblidgudang_TextChanged(sender As Object, e As EventArgs) Handles lblidgudang.TextChanged, Label2.TextChanged
        'buatKolom()
        TAMPILBARANG()
        Dim intI As Integer
        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(3).Value = "0" Then
                    DataGridView1.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

    End Sub
End Class