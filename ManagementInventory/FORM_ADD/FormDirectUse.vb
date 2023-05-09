Imports MySql.Data.MySqlClient
Public Class FormDirectUse
    '======>MECARI TOTAL AMOUNT<=======
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitung = hitung + DGVRCV.Rows(i).Cells(5).Value
        Next
        lbltotal.Text = Format(hitung, "0,000.00")
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
        buatKolom()

    End Sub
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tbl_directpurchase where nodirect in(select max(nodirect) from tbl_directpurchase)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "DP" + Format(Now, "yyMMdd") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 10) + 1
            urutanKode = "DP" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    '======>PEMBUATAN COLOM DATAGRIDVIEW<=======
    Sub buatKolom()
        DGVRCV.Columns.Clear()
        DGVRCV.ReadOnly = True
        DGVRCV.Columns.Add("KodeBarang", "No Item")
        DGVRCV.Columns.Add("NamaBarang", "Description")
        DGVRCV.Columns.Add("Satuan", "Unit")
        DGVRCV.Columns.Add("Jumlah", "Qty")
        DGVRCV.Columns.Add("harga", "Price")
        DGVRCV.Columns.Add("total", "Amount")

        DGVRCV.RowHeadersVisible = False
        DGVRCV.Columns(1).Width = 450
        DGVRCV.Columns(4).Width = 170
        DGVRCV.Columns(2).Width = 60
        DGVRCV.Columns(3).Width = 90
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub FormDirectUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        noOtomatis()
        KONEKDB()

        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store = '" & "General Store" & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            idstorekeluar.Text = DR.Item(0)
        End If
    End Sub

    Private Sub txtsuplier_MouseClick(sender As Object, e As MouseEventArgs) Handles txtsuplier.MouseClick
        CARISUPLIER.ShowDialog()
    End Sub

    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        CariBarang.TAMPILBARANG_PR()
        CariBarang.ShowDialog()
        txtqty.Select()
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If txtitemno.Text = "" Then
                MsgBox("Please Input Item", MsgBoxStyle.Information, "Information!!")
            Else
                If DGVRCV.Rows(0).Index = 0 Then
                    For barisatas As Integer = 0 To DGVRCV.RowCount - 1
                        If txtitemno.Text = DGVRCV.Rows(barisatas).Cells(0).Value Then
                            MsgBox("The item already exists", MsgBoxStyle.Information, "Information!!")
                            'DGVPR.Rows(barisatas).Cells(3).Value = DGVPR.Rows(barisatas).Cells(3).Value + Val(txtqty.Text)
                            'DGVPR.Rows(barisatas).Cells(5).Value = DGVPR.Rows(barisatas).Cells(4).Value * DGVPR.Rows(barisatas).Cells(3).Value
                            'DGVPR.Rows.RemoveAt(DGVPR.CurrentCell.RowIndex)
                            'SendKeys.Send("{Down}")
                            rumusSubtotal()
                            rumusCariitem()
                            txtitemno.Text = ""
                            txtqty.Text = ""
                            lblnamaitem.Text = "NAME ITEM"
                            lblprice.Text = ""
                            lblunit.Text = ""
                            Exit Sub
                        End If
                    Next
                    '======== Insert To DataGridview
                    DGVRCV.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, txtqty.Text, lblprice.Text, Format(lblprice.Text * Val(txtqty.Text), "0,000.00"), txtremaks.Text})
                    rumusSubtotal()
                    rumusCariitem()
                    txtitemno.Text = ""
                    txtqty.Text = ""
                    lblnamaitem.Text = "NAME ITEM"
                    lblprice.Text = ""
                    lblunit.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        '=========== > SIMPAN < ================
        Call KONEKDB()
        If lbltotal.Text = "" Then
            MsgBox("Please Insert Item", MsgBoxStyle.Information, "Information")
        ElseIf txtsuplier.Text = "" Then
            MsgBox("Please Input Suplier", MsgBoxStyle.Information, "Information")
        Else

            noOtomatis()
            '======== Insert To TBL SR
            Dim simpansr As String = "insert into tbl_directpurchase values('" & txtno.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & txtsuplier.Text & "','" & lbltlpsuplier.Text & "','" & lblemailsuplier.Text & "','" & lblqty.Text & "','" & CDec(lbltotal.Text) & "','" & lbluser.Text & "','" & Approve.Text & "','" & Acknowledged.Text & "','" & txtremaks.Text & "','" & "" & "','" & "" & "','" & "" & "')"
            CMD = New MySqlCommand(simpansr, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            '======== Insert To TBL SR Detail 
            For baris As Integer = 0 To DGVRCV.Rows.Count - 2
                Dim simpanDetailsr As String = "insert into tbl_directpurchasedetail values('" & txtno.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & DGVRCV.Rows(baris).Cells(0).Value & "','" & DGVRCV.Rows(baris).Cells(1).Value & "','" & DGVRCV.Rows(baris).Cells(2).Value & "','" & DGVRCV.Rows(baris).Cells(3).Value & "','" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "','" & CDec(DGVRCV.Rows(baris).Cells(5).Value) & "')"
                CMD = New MySqlCommand(simpanDetailsr, Konn)
                CMD.ExecuteNonQuery()

                ''======Select TBL Barang
                'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'", Konn)
                'DR = CMD.ExecuteReader
                'DR.Read()

                ''=======>mengurangi Stock Gudang
                'Dim kurangiStock As String = "update tblbarang set jumlahbarang ='" & DR.Item("jumlahbarang") + DGVRCV.Rows(baris).Cells(3).Value & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
                'CMD = New MySqlCommand(kurangiStock, Konn)
                'DR.Close()
                'CMD.ExecuteNonQuery()


                'Dim EDITHARGA As String = "update tblbarang set hargabarang ='" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
                'CMD = New MySqlCommand(EDITHARGA, Konn)
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
            MsgBox("Direct Purchase Success", MsgBoxStyle.Information, "Information!!")
            DirectUse_List.kondisiAwal()
            Me.Close()
        End If
    End Sub

    Private Sub txtppn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtppn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtppn.Text = "" Or txtppn.Text = "0" Then
                DGVRCV.CurrentRow.Cells(4).Value = discount.Text
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
            Else
                DGVRCV.CurrentRow.Cells(4).Value = Format(txtppn.Text * DGVRCV.CurrentRow.Cells(4).Value * 0.01 + DGVRCV.CurrentRow.Cells(4).Value, "0,000.00")
                DGVRCV.CurrentRow.Cells(5).Value = Format(DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value, "0,000.00")
                rumusSubtotal()
            End If
        End If
    End Sub

    Private Sub DGVRCV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVRCV.CellMouseClick
        txtitemno.Text = DGVRCV.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVRCV.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVRCV.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVRCV.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = DGVRCV.Rows(e.RowIndex).Cells(4).Value
        amount.Text = DGVRCV.CurrentRow.Cells(4).Value
        discount.Text = DGVRCV.CurrentRow.Cells(4).Value
        txtdischarga.Text = ""
        txtppn.Text = ""
    End Sub

    Private Sub txtdischarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdischarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtdischarga.Text = "" Or txtdischarga.Text = "0" Then
                DGVRCV.CurrentRow.Cells(4).Value = amount.Text
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
                discount.Text = DGVRCV.CurrentRow.Cells(4).Value
                rumusSubtotal()
            Else
                DGVRCV.CurrentRow.Cells(4).Value = Format(DGVRCV.CurrentRow.Cells(4).Value - Val(txtdischarga.Text * DGVRCV.CurrentRow.Cells(4).Value * 0.01), "0,000.00")
                DGVRCV.CurrentRow.Cells(5).Value = Format(DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value, "0,000.00")
                discount.Text = DGVRCV.CurrentRow.Cells(4).Value
                rumusSubtotal()
            End If
        End If
    End Sub

    Private Sub lblprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblprice.KeyPress

        If e.KeyChar = Chr(13) Then
            Dim harga As Double
            'Dim totalharga As Double
            If discount.Text <> amount.Text Then
                DGVRCV.CurrentRow.Cells(4).Value = amount.Text
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
                discount.Text = DGVRCV.CurrentRow.Cells(4).Value
                rumusSubtotal()
            Else
                harga = lblprice.Text
                DGVRCV.CurrentRow.Cells(4).Value = Format(harga, "0,000.00")
                DGVRCV.CurrentRow.Cells(5).Value = Format(DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value, "0,000.00")
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""

                'txtdischarga.Enabled = False
                'txtppn.Enabled = False
            End If

            'DGVRCV.CurrentRow.Cells(5).Value = Format(totalharga, "0,000.00")
        End If
    End Sub

    Private Sub DGVRCV_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVRCV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Are You Sure to Delete this Item....?", "Delete Item", MessageBoxButtons.YesNo) = DialogResult.No Then

            Else
                If DGVRCV.CurrentRow.Index <> DGVRCV.NewRowIndex Then
                    DGVRCV.Rows.RemoveAt(DGVRCV.CurrentRow.Index)
                End If
            End If
        End If
    End Sub
End Class