Imports MySql.Data.MySqlClient
Public Class Formtambahbarang

    Sub cbxunit()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_unit", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            UNIT.Items.Add(DR.Item(1))
        Loop
    End Sub

    Sub cbxcatagory()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_catagory", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            GROUP.Items.Add(DR.Item(1))
        Loop
    End Sub
    Sub noOtomatis2()
        CMD = New MySqlCommand("select * from tblbarang where no in(select max(no) from tblbarang)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR.Close()
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "1"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 1) + 1
            urutanKode = +Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        Label12.Text = urutanKode
    End Sub
    Sub noOtomatis()
        DR.Close()
        CMD = New MySqlCommand("select * from tblbarang where idbarang in(select max(idbarang) from tblbarang)", Konn)
        Dim urutanKode As String
        Dim hitung As Long

        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "BRG" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            urutanKode = "BRG" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        NOITEM.Text = urutanKode
    End Sub
    Sub AKTIFKAN()
        GROUP.Enabled = True
        NAMAITEM.Enabled = True
        UNIT.Enabled = True
        txtMinimum.Enabled = True
        PRICE.Enabled = True
        SUPLIER.Enabled = True
    End Sub
    Sub KONDISIAWAL()
        noOtomatis2()
        txtMinimum.Text = ""
        GROUP.SelectedItem = 0
        NOITEM.Text = ""
        NAMAITEM.Text = ""
        UNIT.SelectedItem = 0
        PRICE.Text = ""
        TextBox1.Text = ""
        Label9.Text = "1"
        SUPLIER.Text = ""
        TUTUP.Text = "CLOSE"
        INPUT.Text = "ADD"


        TextBox1.Enabled = False
        GROUP.Enabled = False
        txtMinimum.Enabled = False
        NOITEM.Enabled = False
        NAMAITEM.Enabled = False
        UNIT.Enabled = False
        PRICE.Enabled = False
        SUPLIER.Enabled = False


        '======MEMANGGIL DATAGRIDVIEW======
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, jumlahbarang, hargabarang, totalharga from tblbarang where id_store='" & "1" & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Description"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
        DataGridView1.Columns(5).HeaderText = "Amount"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
    End Sub
    Private Sub Formtambahbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        cbxunit()
        cbxcatagory()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles INPUT.Click
        If INPUT.Text = "ADD" Then
            INPUT.Text = "SAVE"
            AKTIFKAN()
            noOtomatis()
            TUTUP.Text = "CANCEL"
        Else
            If GROUP.Text = "" Or NOITEM.Text = "" Or NAMAITEM.Text = "" Or UNIT.Text = "" Or PRICE.Text = "" Or SUPLIER.Text = "" Then
                MsgBox("Please fill all section", MsgBoxStyle.Information, "Information!!")
            Else
                Call KONEKDB()
                Dim inputData As String = "Insert into tblbarang values('" & Label12.Text & "','" & NOITEM.Text & "','" & NAMAITEM.Text & "','" & UNIT.Text & "', '" & QTY.Text & "', '" & PRICE.Text & "', '" & Val(QTY.Text) * Val(PRICE.Text) & "', '" & GROUP.Text & "','" & Label9.Text & "', '" & SUPLIER.Text & "', '" & txtMinimum.Text & "')"
                CMD = New MySqlCommand(inputData, Konn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Berhasil", MsgBoxStyle.Information, "Information!!")
                KONDISIAWAL()
            End If
        End If


    End Sub

    Private Sub CLOSE_Click(sender As Object, e As EventArgs) Handles TUTUP.Click
        If TUTUP.Text = "CANCEL" Then
            KONDISIAWAL()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SUPLIER_MouseClick(sender As Object, e As MouseEventArgs) Handles SUPLIER.MouseClick
        CARISUPLIER.ShowDialog()
    End Sub

    Private Sub PRICE_TextChanged(sender As Object, e As EventArgs) Handles PRICE.TextChanged

    End Sub


    'Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
    '    If MsgBox("Do you Want to delete this Item..?", MsgBoxStyle.YesNo, "Warning!!") = MsgBoxResult.No Then
    '        Exit Sub
    '    ElseIf DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
    '        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    '    End If
    'End Sub
End Class