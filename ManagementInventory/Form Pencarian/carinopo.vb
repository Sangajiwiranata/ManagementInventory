Imports MySql.Data.MySqlClient
Public Class carinopo

    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select nopo from tblpr where nopo Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select nopo from tblpo where Acknowledged <> '" & " " & "' and status>'" & "0" & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nopo")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nopo"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns(0).HeaderText = "No Purchase Order"
    End Sub
    Private Sub carinopo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub
    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Try
            Call KONEKDB()
            Formreceiving.txtnopo.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            Formreceiving.isiform()
            Formreceiving.isisupplier()
            Formreceiving.rumusSubtotal()
            Formreceiving.rumusCariitem()
            Formreceiving.ITEMTOTAL()

            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class