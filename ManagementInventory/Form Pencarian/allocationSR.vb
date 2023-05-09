Imports MySql.Data.MySqlClient
Public Class allocationSR
    Sub CARICOA()
        KONEKDB()
        DA = New MySqlDataAdapter("Select id_coa, departement, main_coa, sub_coa_expenses, allocation_expenses,HeaderID from tbl_coa where departement Like'%" & TextBox1.Text & "%' or main_coa Like'%" & TextBox1.Text & "%' or sub_coa_expenses Like'%" & TextBox1.Text & "%' or allocation_expenses Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select id_coa, departement, main_coa, sub_coa_expenses, allocation_expenses,HeaderID from tbl_coa where HeaderID>='" & "300" & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nopr")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nopr"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        'DGV.Columns(2).Width = 120
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DGV.Columns(0).HeaderText = "No-COA"
        DGV.Columns(1).HeaderText = "Departemt"
        DGV.Columns(2).HeaderText = "Main COA"
        DGV.Columns(3).HeaderText = "Sub COA Expenses"
        DGV.Columns(4).HeaderText = "Allocation Expenses"
        DGV.Columns(5).HeaderText = "Allocation ID"
        DGV.Columns(5).Visible = False


    End Sub
    Private Sub allocationSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        SR_EDIT.DGVSR.CurrentRow.Cells(6).Value = DGV.Rows(e.RowIndex).Cells(0).Value
        SR_EDIT.DGVSR.CurrentRow.Cells(7).Value = DGV.Rows(e.RowIndex).Cells(1).Value
        SR_EDIT.DGVSR.CurrentRow.Cells(8).Value = DGV.Rows(e.RowIndex).Cells(2).Value
        SR_EDIT.DGVSR.CurrentRow.Cells(9).Value = DGV.Rows(e.RowIndex).Cells(3).Value
        SR_EDIT.DGVSR.CurrentRow.Cells(10).Value = DGV.Rows(e.RowIndex).Cells(5).Value
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TAMPILSUPLIER()
        Else
            CARICOA()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class