Imports MySql.Data.MySqlClient
Public Class coa_inventory
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select id_coa, main_coa, sub_coa_expenses, HeaderID from tbl_coa where HeaderID Between'" & "1300" & "' and '" & "1312" & "'", Konn)
        'DA = New MySqlDataAdapter("Select * from tbl_coa", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nopr")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nopr"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        'DGV.Columns(2).Width = 120
        'DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.

        DGV.Columns(0).Width = 90
        DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGV.Columns(0).HeaderText = "No-COA"
        DGV.Columns(1).HeaderText = "Main COA"
        DGV.Columns(2).HeaderText = "COA Expenses"
        DGV.Columns(3).HeaderText = "ID Jurnal"

        DGV.Columns(2).Visible = False
        'DGV.Columns(3).Visible = False
    End Sub

    Private Sub coa_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        RCV_EDIT.coaexpenses.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        RCV_EDIT.idcoa.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        RCV_EDIT.maincoa.Text = DGV.Rows(e.RowIndex).Cells(2).Value.ToString
        RCV_EDIT.LBLIDReport.Text = DGV.Rows(e.RowIndex).Cells(3).Value

        DirectPurchaseEdit.coaexpenses.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        DirectPurchaseEdit.idcoa.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DirectPurchaseEdit.maincoa.Text = DGV.Rows(e.RowIndex).Cells(2).Value.ToString
        DirectPurchaseEdit.LBLIDReport.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Me.Close()
    End Sub
End Class