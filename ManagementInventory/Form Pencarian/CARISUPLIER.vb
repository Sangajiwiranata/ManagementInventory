Imports MySql.Data.MySqlClient
Public Class CARISUPLIER
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblsuplier where suplier Like'%" & TXTCARI.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVSUPLIER.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILSUPLIER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblsuplier", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblsuplier")
        DGVSUPLIER.DataSource = (DS.Tables("tblsuplier"))
        DGVSUPLIER.ReadOnly = True
        DGVSUPLIER.RowHeadersVisible = False
        DGVSUPLIER.Columns(0).Width = 60
        DGVSUPLIER.Columns(1).Width = 150
        DGVSUPLIER.Columns(4).Width = 250

        DGVSUPLIER.Columns(0).HeaderText = "ID Suplier"
        DGVSUPLIER.Columns(1).HeaderText = "Name Suplier"
        DGVSUPLIER.Columns(2).HeaderText = "Phone Number"
        DGVSUPLIER.Columns(3).HeaderText = "Email"
        DGVSUPLIER.Columns(4).HeaderText = "Address"
        DGVSUPLIER.Columns(5).HeaderText = "Suplier Type"
    End Sub
    Private Sub CARISUPLIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILSUPLIER()
        TXTCARI.Text = ""
        TXTCARI.Focus()
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        CARIITEM()
    End Sub

    Private Sub DGVSUPLIER_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVSUPLIER.CellMouseDoubleClick
        '============> Purchase Order <============
        FormPO.txtsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(1).Value
        FormPO.txtnohp.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(2).Value
        FormPO.txtfax.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(3).Value
        FormPO.txtalamat.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(4).Value
        FormPO.txtnopr.Enabled = True
        '============> Receiving <============
        Formreceiving.txtsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(1).Value
        Formreceiving.lbltlpsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(2).Value
        Formreceiving.lblemailsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(3).Value
        Formreceiving.lblalamat.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(4).Value
        '============> Direct Purchase <============
        FormDirectUse.txtsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(1).Value
        FormDirectUse.lbltlpsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(2).Value
        FormDirectUse.lblemailsuplier.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(3).Value
        FormDirectUse.lblalamat.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(4).Value
        '============> Tambah Master Item <============
        Formtambahbarang.SUPLIER.Text = DGVSUPLIER.Rows(e.RowIndex).Cells(1).Value
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class