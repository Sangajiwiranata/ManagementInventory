Imports MySql.Data.MySqlClient
Public Class Formreceiving

    Sub isisupplier()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblpo where nopo='" & txtnopo.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            topdays.Text = DR.Item(4)
            txtsuplier.Text = DR.Item(5)
            lbltlpsuplier.Text = DR.Item(6)
            lblemailsuplier.Text = DR.Item(7)
            lblalamat.Text = DR.Item(8)
        End If
    End Sub
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblpodetail Where nopo='" & txtnopo.Text & "' and status='" & " " & "' ", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVRCV.DataSource = (DS.Tables(0))
        DGVRCV.ReadOnly = True

        DGVRCV.RowHeadersVisible = False
        DGVRCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVRCV.Columns(0).Width = 120
        DGVRCV.Columns(1).Width = 400
        DGVRCV.Columns(3).Width = 100

        DGVRCV.Columns(0).HeaderText = "No Item"
        DGVRCV.Columns(1).HeaderText = "Description"
        DGVRCV.Columns(2).HeaderText = "Unit"
        DGVRCV.Columns(4).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
        DGVRCV.Columns(5).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
        DGVRCV.Columns(3).HeaderText = "OnHand"
        DGVRCV.Columns(4).HeaderText = "Price"

        DGVRCV.Columns(5).HeaderText = "Amount"

        'ITEMTOTAL()
    End Sub
    '======>MECARI TOTAL AMOUNT<=======
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitung = hitung + DGVRCV.Rows(i).Cells(5).Value
            lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
        Next
    End Sub
    '======>MECARI TOTAL ITEM<=======
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitungItem = hitungItem + DGVRCV.Rows(i).Cells(3).Value
            lblqty.Text = hitungItem
        Next
    End Sub
    '======>KONDISI AWAL<=======
    Sub KONDISIAWAL()
        Approve.Text = ""
        Acknowledged.Text = ""
        lblnamaitem.Text = "NAME ITEM"
        lblalamat.Enabled = False
        lbltlpsuplier.Enabled = False
        lblemailsuplier.Enabled = False
        DateTimePicker1.Value = Today
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        txtnopo.Text = ""
        txtremaks.Text = ""
        txtsuplier.Text = ""
        lblemailsuplier.Text = ""
        lbltlpsuplier.Text = ""
        txtitemno.Text = ""
        lblalamat.Text = ""
        txtno.Text = ""
        txtqty.Text = ""
        lblunit.Text = ""
        lblprice.Text = ""
        lbltotal.Text = ""
        lblqty.Text = ""
        txtno.Enabled = False
        txtsuplier.Enabled = False
        txtitemno.Enabled = False
        'buatKolom()

    End Sub
    Private Sub Formreceiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    '======>PENOMORAN OTOMATIS<=======
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tblreceiving where norcv in(select max(norcv) from tblreceiving)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "RCV" + Format(Now, "yyMMdd") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 10) + 1
            urutanKode = "RCV" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    '======>PEMBUATAN COLOM DATAGRIDVIEW<=======
    'Sub buatKolom()
    '    DGVRCV.Columns.Clear()
    '    DGVRCV.ReadOnly = True
    '    DGVRCV.Columns.Add("KodeBarang", "No Item")
    '    DGVRCV.Columns.Add("NamaBarang", "Description")
    '    DGVRCV.Columns.Add("Satuan", "Unit")
    '    DGVRCV.Columns.Add("Jumlah", "Qty")
    '    DGVRCV.Columns.Add("harga", "Price")
    '    DGVRCV.Columns.Add("total", "Amount")

    '    DGVRCV.RowHeadersVisible = False
    '    DGVRCV.Columns(1).Width = 450
    '    DGVRCV.Columns(4).Width = 170
    '    DGVRCV.Columns(2).Width = 60
    '    DGVRCV.Columns(3).Width = 90
    'End Sub

    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        CariBarang.ShowDialog()
        txtqty.Focus()
    End Sub
    '======>MENYIMPAN KE DATAGRIDVIEW<=======
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Call KONEKDB()
        If txtitemno.Text = "" Then
            MsgBox("Please Input Item", MsgBoxStyle.Information, "Information")
        ElseIf txtqty.Text = "" Then
            MsgBox("Please Input Qty", MsgBoxStyle.Information, "Information")
        Else
            '======== Insert To DataGridview
            DGVRCV.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, txtqty.Text, lblprice.Text, FormatCurrency(lblprice.Text * Val(txtqty.Text))})
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        Call KONEKDB()
        If lbltotal.Text = "" Then
            MsgBox("Please Insert Item", MsgBoxStyle.Information, "Information")
        ElseIf txtnopo.Text = "" Then
            MsgBox("Please Input PO Number", MsgBoxStyle.Information, "Information")
        ElseIf txtsuplier.Text = "" Then
            MsgBox("Please Input Suplier", MsgBoxStyle.Information, "Information")
        Else
            DateTimePicker2.Value = Format(DateAdd(DateInterval.Day, Val(topdays.Text), DateTimePicker1.Value), "yyyy-MM-dd")
            noOtomatis()
            DR.Close()
            '======Select TBL Barang
            CMD = New MySqlCommand("select * from tblpo where nopo='" & txtnopo.Text & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()

            '=======>mengurangi Stock Gudang
            Dim updatestatus As String = "update tblpo set status='" & DR.Item("status") - jmlhitem.Text & "' where nopo='" & txtnopo.Text & "'"
            CMD = New MySqlCommand(updatestatus, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            '======== Insert To TBL SR
            Dim simpansr As String = "insert into tblreceiving values('" & txtno.Text & "','" & txtnopo.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "','" & txtsuplier.Text & "','" & lbltlpsuplier.Text & "','" & lblemailsuplier.Text & "','" & lblqty.Text & "','" & CDec(lbltotal.Text) & "','" & lbluser.Text & "','" & Approve.Text & "','" & Acknowledged.Text & "','" & txtremaks.Text & "','" & "" & "','" & "" & "','" & "" & "')"
            CMD = New MySqlCommand(simpansr, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            '======== Insert To TBL SR Detail 
            For baris As Integer = 0 To DGVRCV.Rows.Count - 2
                Dim simpanDetailsr As String = "insert into tblreceivingdetail values('" & txtno.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & DGVRCV.Rows(baris).Cells(0).Value & "','" & DGVRCV.Rows(baris).Cells(1).Value & "','" & DGVRCV.Rows(baris).Cells(2).Value & "','" & DGVRCV.Rows(baris).Cells(3).Value & "','" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "','" & CDec(DGVRCV.Rows(baris).Cells(5).Value) & "')"
                CMD = New MySqlCommand(simpanDetailsr, Konn)
                CMD.ExecuteNonQuery()

                'Dim simpanDetailsr2 As String = "insert into tbl_trfdetail values('" & txtno.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & "01" & "','" & DGVRCV.Rows(baris).Cells(0).Value & "','" & DGVRCV.Rows(baris).Cells(1).Value & "','" & DGVRCV.Rows(baris).Cells(2).Value & "','" & DGVRCV.Rows(baris).Cells(3).Value & "','" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "','" & CDec(DGVRCV.Rows(baris).Cells(5).Value) & "')"
                'CMD = New MySqlCommand(simpanDetailsr2, Konn)
                'CMD.ExecuteNonQuery()

                '======Select TBL Barang

                'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'", Konn)
                'DR = CMD.ExecuteReader
                'DR.Read()

                '=======>mengurangi Stock Gudang
                'Dim baranggudang As Integer = DR.Item("jumlahbarang")
                'Dim kurangiStock As String = "update tblbarang set jumlahbarang ='" & baranggudang + Val(DGVRCV.Rows(baris).Cells(3).Value) & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "' and id_store='" & "1" & "'"
                'CMD = New MySqlCommand(kurangiStock, Konn)
                'DR.Close()
                'CMD.ExecuteNonQuery()


                Dim EDITHARGA As String = "update tblbarang set hargabarang ='" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
                CMD = New MySqlCommand(EDITHARGA, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()

                '======Select TBL Barang
                'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'", Konn)
                'DR = CMD.ExecuteReader
                'DR.Read()
                'Dim EDITtotal As String = "update tblbarang set totalharga ='" & DR.Item("jumlahbarang") * DR.Item("hargabarang") & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'and id_store='" & "1" & "'"
                'CMD = New MySqlCommand(EDITtotal, Konn)
                'DR.Close()
                'CMD.ExecuteNonQuery()
            Next
            'If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            '    KONDISIAWAL()
            'Else
            '    PRINT_RCV.Show()
            '    PRINT_RCV.ReportRcvBaru.ReportSource = "PrintRcv.rpt"
            '    PRINT_RCV.ReportRcvBaru.SelectionFormula = "{@norcv}='" & txtno.Text & "'"
            '    PRINT_RCV.ReportRcvBaru.Refresh()
            'End If
            MsgBox("Input Receiving Success", MsgBoxStyle.Information, "Information!!")
            RCV_LIST.kondisiAwal()
            Me.Close()
        End If
    End Sub
    Sub ITEMTOTAL()
        Dim jmlh As Integer
        jmlh = DGVRCV.Rows.Count - 1
        jmlhitem.Text = jmlh
    End Sub
    Private Sub txtsuplier_MouseClick(sender As Object, e As MouseEventArgs) Handles txtsuplier.MouseClick
        CARISUPLIER.ShowDialog()
        txtitemno.Focus()
    End Sub

    Private Sub txtnopo_MouseClick(sender As Object, e As MouseEventArgs) Handles txtnopo.MouseClick
        carinopo.ShowDialog()
        txtitemno.Focus()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            If DGVRCV.CurrentRow.Index <> DGVRCV.NewRowIndex Then
                DGVRCV.Rows.RemoveAt(DGVRCV.CurrentRow.Index)
            End If
        End If
        ITEMTOTAL()
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            DGVRCV.CurrentRow.Cells(3).Value = txtqty.Text
            DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(4).Value * DGVRCV.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
        End If
    End Sub

    Private Sub DGVRCV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRCV.CellClick
        txtitemno.Text = DGVRCV.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVRCV.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVRCV.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVRCV.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = DGVRCV.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub lblprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblprice.KeyPress

        If e.KeyChar = Chr(13) Then
            DGVRCV.CurrentRow.Cells(4).Value = lblprice.Text
            DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(4).Value * DGVRCV.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
        End If
    End Sub
End Class