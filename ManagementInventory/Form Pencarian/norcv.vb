Imports MySql.Data.MySqlClient
Public Class norcv
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select norcv from tblreceiving where norcv Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select norcv from tblreceiving", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nosr")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nosr"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DGV.Columns(0).HeaderText = "Receiving List"

    End Sub
    Private Sub norcv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Call KONEKDB()
        If ReleaseRCV.txtno.Text <> "" Then
            ReleaseRCV.DGVRCV.Columns.Clear()
            ReleaseRCV.txtno.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            ReleaseRCV.isiform()
            ReleaseRCV.Tampilkan()
            ReleaseRCV.rumusSubtotal()
            Me.Close()
        Else
            ReleaseRCV.txtno.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            ReleaseRCV.isiform()
            ReleaseRCV.Tampilkan()
            ReleaseRCV.rumusSubtotal()
            Me.Close()
        End If
    End Sub
End Class