Imports MySql.Data.MySqlClient
Public Class MinimumStock
    Sub TAMPILKAN()
        KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, jumlahbarang, minimum from tblbarang", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")

        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 220
        DataGridView1.Columns(3).Width = 70


        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp,  ###,###,###.00"
        'DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp,  ###,###,###.00"

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Description"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "OnHand"

        'DataGridView1.Columns(5).HeaderText = "Group"
        DataGridView1.Columns(4).HeaderText = "Minimum"
    End Sub
    Private Sub MinimumStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILKAN()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class