Imports MySql.Data.MySqlClient
Public Class Dept
    Sub Buatkolom()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select dept from tbl_dept", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DGV.DataSource = (DS.Tables("tbLsuplier"))
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.ColumnHeadersHeightSizeMode = False
        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.ColumnHeadersHeight = 35
        DGV.RowHeadersVisible = False
        'DGV.Columns(0).Width = 30
        'DGV.Columns(1).Width = 250
        'DGV.Columns(4).Width = 300

        'DGV.Columns(0).HeaderText = "Id Dept"
        DGV.Columns(0).HeaderText = "Deptartment"
        'DGV.Columns(2).HeaderText = "Phone Number"
        'DGV.Columns(3).HeaderText = "Email"
        'DGV.Columns(4).HeaderText = "Address"
        'DGV.Columns(5).HeaderText = "Type"
    End Sub
    Private Sub Dept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buatkolom()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        'FormPR.Button2.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        FormPR.ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        FormPR.Button2.Text = ""
        Me.Close()
    End Sub
End Class