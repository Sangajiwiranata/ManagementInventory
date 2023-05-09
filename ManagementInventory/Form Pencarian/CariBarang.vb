Imports MySql.Data.MySqlClient
Public Class CariBarang
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, jumlahbarang, hargabarang, totalharga, id_store from tblbarang where namabarang Like'%" & TextBox1.Text & "%' and id_store='" & "1" & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub TAMPILBARANG()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, jumlahbarang, hargabarang, totalharga, id_store from tblbarang where id_store='" & FormTransfer.idstorekeluar.Text & "' or id_store='" & FormSR.idstorekeluar.Text & "'  or id_store='" & FormPR.idstorekeluar.Text & "' or id_store='" & FormDirectUse.idstorekeluar.Text & "' or id_store='" & PREDIT.Label9.Text & "' or id_store='" & PO_EDIT.Label2.Text & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
    End Sub
    Sub TAMPILBARANGUSER()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select idbarang, namabarang, jenisbarang, jumlahbarang, hargabarang from tblbarang where id_store='" & FormTransfer.idstorekeluar.Text & "' or id_store='" & FormSR.idstorekeluar.Text & "'  or id_store='" & FormPR.idstorekeluar.Text & "' or id_store='" & FormDirectUse.idstorekeluar.Text & "' or id_store='" & PREDIT.Label9.Text & "' or id_store='" & PO_EDIT.Label2.Text & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 400
        DataGridView1.Columns(3).Width = 50
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        'DataGridView1.Columns(3).DefaultCellStyle.Format = "**************"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).HeaderText = "Price"
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cariItem()
    End Sub

    Sub TAMPILBARANG_SR()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT
	            idbarang,namabarang,jenisbarang,
	            SUM(CASE 
	            WHEN lokasi = '" & FormSR.idstorekeluar.Text & "'	THEN
		            masuk - keluar
		            ELSE 0 END) as saldototal, price, lokasi FROM
	            tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next

        Dim intI As Integer
        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(3).Value = "0" Then
                    DataGridView1.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub
    Sub TAMPILBARANG_SR_edit()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT
	            idbarang,namabarang,jenisbarang,
	            SUM(CASE 
	            WHEN lokasi = '" & SR_EDIT.idstorekeluar.Text & "'	THEN
		            masuk - keluar
		            ELSE 0 END) as saldototal, price, lokasi FROM
	            tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next

        Dim intI As Integer
        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(3).Value = "0" Then
                    DataGridView1.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub TAMPILBARANG_Transfer()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT
	            idbarang,namabarang,jenisbarang,
	            SUM(CASE 
	            WHEN lokasi = '" & FormTransfer.idstorekeluar.Text & "'	THEN
		            masuk - keluar
		            ELSE 0 END) as saldototal, price, lokasi FROM
	            tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next

        Dim intI As Integer
        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(3).Value = "0" Then
                    DataGridView1.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub TAMPILBARANG_DP()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT
	            idbarang,namabarang,jenisbarang,
	            SUM(CASE 
	            WHEN lokasi = '" & "1" & "'	THEN
		            masuk - keluar
		            ELSE 0 END) as saldototal, price, lokasi FROM
	            tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next

        Dim intI As Integer
        For intI = DataGridView1.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If DataGridView1.Rows(intI).Cells(3).Value = "0" Then
                    DataGridView1.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub TAMPILBARANG_PR()
        Call KONEKDB()
        DA = New MySqlDataAdapter("SELECT * from view_brgtransaksi Where lokasi='" & "1" & "' or lokasi is null", Konn)
        'DA = New MySqlDataAdapter("SELECT
        '     idbarang,namabarang,jenisbarang,
        '     SUM(CASE 
        '     WHEN lokasi = '" & "1" & "' or lokasi = '" & "" & "' 	THEN
        '      masuk - keluar
        '      ELSE 0 END) as saldototal, price, lokasi FROM
        '     tbl_transaksibarang	GROUP BY idbarang ", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tblbarang")
        DataGridView1.DataSource = (DS.Tables("tblbarang"))
        DataGridView1.ReadOnly = True

        DataGridView1.Columns(6).Visible = False

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(3).Width = 50

        DataGridView1.Columns(0).HeaderText = "No Item"
        DataGridView1.Columns(1).HeaderText = "Name Item"
        DataGridView1.Columns(2).HeaderText = "Unit"
        DataGridView1.Columns(3).HeaderText = "On-Hand"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(4).HeaderText = "Price"
        DataGridView1.Columns(5).HeaderText = "Amount"
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(baris).Cells(3).Value.ToString = "" Then
                DataGridView1.Rows(baris).Cells(3).Value = "0"
                'DataGridView1.Rows(baris).Cells(5).Value = "0"
            End If
            DataGridView1.Rows(baris).Cells(5).Value = DataGridView1.Rows(baris).Cells(3).Value * DataGridView1.Rows(baris).Cells(4).Value
        Next
    End Sub
    Private Sub CariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormSR.TAMPILBARANG()
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Call KONEKDB()

        Dim frmCollection = System.Windows.Forms.Application.OpenForms
        If frmCollection.OfType(Of PO_EDIT).Any Then
            '=====================>Purchase Order Edit<================================
            PO_EDIT.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            PO_EDIT.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            PO_EDIT.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            PO_EDIT.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        ElseIf frmCollection.OfType(Of FormPR).Any Then
            '=====================>Purchase Requisition<================================
            FormPR.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            FormPR.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormPR.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormPR.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "#,###.00")
        ElseIf frmCollection.OfType(Of FormSR).Any Then
            '=====================>Store Requisition<================================
            FormSR.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            FormSR.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormSR.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormSR.lblstock.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            FormSR.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        ElseIf frmCollection.OfType(Of PREDIT).Any Then
            '=====================>Purchase Requisition Edit<================================
            PREDIT.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            PREDIT.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            PREDIT.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            PREDIT.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "#,###.00")
            PREDIT.TextBox1.Visible = True
        ElseIf frmCollection.OfType(Of FormPO).Any Then
            '=====================>Purchase Order<================================
            FormPO.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            FormPO.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormPO.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormPO.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        ElseIf frmCollection.OfType(Of Formreceiving).Any Then
            '=====================>Receiving<================================
            Formreceiving.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Formreceiving.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Formreceiving.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Formreceiving.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        ElseIf frmCollection.OfType(Of FormTransfer).Any Then
            '=====================>Transfer<================================
            FormTransfer.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            FormTransfer.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormTransfer.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormTransfer.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
            FormTransfer.lblstock.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        ElseIf frmCollection.OfType(Of FormDirectUse).Any Then
            '=====================>Direct Purchase<================================
            FormDirectUse.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            FormDirectUse.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormDirectUse.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormDirectUse.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
            FormDirectUse.txtqty.Select()
        ElseIf frmCollection.OfType(Of DirectPurchaseEdit).Any Then
            '=====================>Direct Purchase Edit<================================
            DirectPurchaseEdit.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            DirectPurchaseEdit.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            DirectPurchaseEdit.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            DirectPurchaseEdit.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
            DirectPurchaseEdit.TextBox1.Visible = True
            DirectPurchaseEdit.TextBox1.Focus()
        ElseIf frmCollection.OfType(Of SR_EDIT).Any Then
            '=====================>Store Requisition Edit<================================
            SR_EDIT.lblnamaitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            SR_EDIT.txtitemno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            SR_EDIT.lblunit.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            SR_EDIT.lblprice.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
            SR_EDIT.TextBox1.Visible = True
            SR_EDIT.TextBox1.Focus()
        End If
        Me.Close()
    End Sub

    Private Sub btncloase_Click(sender As Object, e As EventArgs) Handles btncloase.Click
        Me.Close()
    End Sub
End Class