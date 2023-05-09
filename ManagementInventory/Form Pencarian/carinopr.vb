Imports MySql.Data.MySqlClient
Public Class carinopr
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from View_PR where nopr Like'%" & TextBox1.Text & "%' or user Like'%" & TextBox1.Text & "%' or dept Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from View_PR where Acknowledged <> '" & " " & "' and balance <> '" & "0" & "' and supplier = '" & FormPO.txtsuplier.Text & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nopr")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nopr"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.Columns(0).Width = 150
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns(0).HeaderText = "No-PR"
        DGV.Columns(1).HeaderText = "Supplier"
        DGV.Columns(2).Visible = False
        DGV.Columns(3).Visible = False
    End Sub
    Private Sub carinopr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
        TextBox1.Text = ""
        TextBox1.Select()
    End Sub


    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        FormPO.txtnopr.Text = ""
        FormPO.DGVPO.Columns.Clear()
        FormPO.txtnopr.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        FormPO.isiform()
        FormPO.rumusSubtotal()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class