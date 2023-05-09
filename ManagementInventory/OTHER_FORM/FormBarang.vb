Imports MySql.Data.MySqlClient
Public Class FormBarang
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblbarang where namabarang Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILBARANG()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblbarang", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")

        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Description"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "OnHand"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        DataGridView1.Columns(6).HeaderText = "Group"
        DataGridView1.Columns(7).HeaderText = "Store"
        DataGridView1.Columns(8).HeaderText = "Supplier"

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub CariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TAMPILBARANG()
        TextBox1.Text = ""
        TextBox1.Focus()
        'Updatetotal()
    End Sub
    Sub Updatetotal()
        For baris As Integer = 0 To DataGridView1.Rows.Count - 2
            CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", Konn)
            DR.Read()
            DR = CMD.ExecuteReader


            CMD = New MySqlCommand("update tblbarang set totalharga='" & FormatCurrency(DR.Item("jumlahbarang")) * FormatCurrency(DR.Item("hargabarang")) & "' where idbarang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
            TAMPILBARANG()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class