Imports MySql.Data.MySqlClient
Public Class CariNoSR
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select nosr from tblsr where nosr Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select nosr from tblsr", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "nosr")
        DGV.ReadOnly = True
        DGV.DataSource = (DS.Tables("nosr"))
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DGV.Columns(0).HeaderText = "Store Requesition List"

    End Sub
    Private Sub CariNoSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Call KONEKDB()
        If ReleaseSR.txtno.Text <> "" Then
            ReleaseSR.DGVSR.Columns.Clear()
            ReleaseSR.txtno.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            ReleaseSR.isiform()
            ReleaseSR.Tampilkan()
            ReleaseSR.rumusSubtotal()
            Me.Close()
        Else
            ReleaseSR.txtno.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            ReleaseSR.isiform()
            ReleaseSR.Tampilkan()
            ReleaseSR.rumusSubtotal()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class