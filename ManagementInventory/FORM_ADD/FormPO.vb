Imports MySql.Data.MySqlClient
Public Class FormPO
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblprdetail Where nopr='" & txtnopr.Text & "' and supplier='" & txtsuplier.Text & "' and status='" & "" & "'", Konn)
        DS = New DataSet

        DA.Fill(DS)
        DGVPO.DataSource = (DS.Tables(0))
        DGVPO.ReadOnly = True

        DGVPO.RowHeadersVisible = False
        DGVPO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVPO.Columns(0).Width = 120
        DGVPO.Columns(1).Width = 400
        DGVPO.Columns(3).Width = 100
        DGVPO.Columns(0).HeaderText = "No Item"
        DGVPO.Columns(1).HeaderText = "Description"
        DGVPO.Columns(2).HeaderText = "Unit"
        DGVPO.Columns(4).DefaultCellStyle.Format = "#,###.##"
        DGVPO.Columns(5).DefaultCellStyle.Format = "#,###.##"
        DGVPO.Columns(3).HeaderText = "OnHand"
        DGVPO.Columns(4).HeaderText = "Price"

        DGVPO.Columns(5).HeaderText = "Amount"
        rumusCariitem()
        ITEMTOTAL()
        'amount.Text = DGVPO.CurrentRow.Cells(4).Value
        'discount.Text = DGVPO.CurrentRow.Cells(5).Value
    End Sub
    '======>Keluar Dari Form<=======
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    '======>MECARI Suplier<=======
    Private Sub txtsuplier_MouseClick(sender As Object, e As MouseEventArgs) Handles txtsuplier.MouseClick
        txtnopr.Text = ""
        CARISUPLIER.ShowDialog()
    End Sub
    '======>MECARI NO PR<=======
    Private Sub txtnopr_MouseClick(sender As Object, e As MouseEventArgs) Handles txtnopr.MouseClick
        If txtnopr.Text = "" Then
            carinopr.ShowDialog()
        Else
            txtnopr.Text = ""
            carinopr.ShowDialog()
        End If
    End Sub
    '======>MECARI GRANDTOTAL<=======
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVPO.Rows.Count - 1
            hitung = hitung + DGVPO.Rows(i).Cells(5).Value
            txttotal.Text = Format(hitung, "0,000.00")
        Next
    End Sub
    '======>MECARI TOTAL ITEM<=======
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVPO.Rows.Count - 1
            hitungItem = hitungItem + DGVPO.Rows(i).Cells(3).Value
            lblqty.Text = hitungItem
        Next
    End Sub
    '======>KONDISI AWAL<=======
    Sub KONDISIAWAL()
        Approved.Text = ""
        Approved.Visible = False
        Acknowledged.Text = ""
        Acknowledged.Visible = False
        Delto.Text = ""

        lblnamaitem.Text = "Name Item"
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        txtremaks.Text = ""
        txtsuplier.Text = ""
        txtnohp.Text = ""
        txtalamat.Text = ""
        txtfax.Text = ""
        txtfax.Enabled = False
        txtalamat.Enabled = False
        txtnohp.Enabled = False
        DateNow.Enabled = False
        DateNow.Value = Today
        daterex.Enabled = False
        nedeed.Text = ""
        daterex.Text = ""
        btnclose.Focus()
        credit.Text = ""
        txtnopr.Text = ""
        txtitemno.Text = ""
        txtno.Text = ""
        txtqty.Text = ""
        txttotal.Text = ""
        'lblqty.Text = ""
        lblunit.Text = ""
        lblprice.Text = ""
        txtno.Enabled = False
        txtitemno.Enabled = False
        txtdischarga.Enabled = False
        txtppn.Enabled = False
        txtnopr.Enabled = False

        'buatKolom()
    End Sub
    '======>PENOMORAN OTOMATIS<=======
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tblpo where nopo in(select max(nopo) from tblpo)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "PO" + Format(Now, "yyMMdd") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 10) + 1
            urutanKode = "PO" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    '======>PEMBUATAN COLOM DATAGRIDVIEW<=======
    'Sub buatKolom()
    '    'DGVPO.Columns.Clear()
    '    'DGVPO.Columns.Add("KodeBarang", "No Item")
    '    'DGVPO.Columns.Add("NamaBarang", "Description")
    '    'DGVPO.Columns.Add("Satuan", "Unit")
    '    'DGVPO.Columns.Add("Jumlah", "Qty")
    '    'DGVPO.Columns.Add("harga", "Price")
    '    'DGVPO.Columns.Add("total", "Amount")

    '    DGVPO.RowHeadersVisible = False
    '    DGVPO.Columns(1).Width = 450
    '    DGVPO.Columns(4).Width = 170
    '    DGVPO.Columns(2).Width = 60
    '    DGVPO.Columns(3).Width = 90

    'End Sub

    Sub ITEMTOTAL()
        Dim jmlh As Integer
        jmlh = DGVPO.Rows.Count
        jmlhitem.Text = jmlh
    End Sub
    '======>LOAD FORM<=======
    Private Sub FormPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        Label14.Visible = False



    End Sub
    '======>Memasukkan Item Ke DataGridView<=======
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        'Try
        '    If txtitemno.Text = "" Or txtqty.Text = "" Then
        '        MsgBox("Please Input Item And Input Qty", MsgBoxStyle.Information, "Information!!")
        '    Else
        '        DGVPO.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, txtqty.Text, lblprice.Text, FormatCurrency(lblprice.Text * Val(txtqty.Text))})
        '        rumusSubtotal()
        '        rumusCariitem()
        '        txtitemno.Text = ""
        '        txtqty.Text = ""
        '        lblnamaitem.Text = "NAME ITEM"
        '        lblprice.Text = ""
        '        lblunit.Text = ""
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Sub topdate()
        DateTimePicker1.Value = Format(DateAdd(DateInterval.Day, Val(credit.Text), daterex.Value), "yyyy-MM-dd")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txttotal.Text = "0" Then
            MsgBox("Please Insert Item", MsgBoxStyle.Information, "Information!!")
        ElseIf credit.Text = "" Then
            MsgBox("Please Input Term Of Payment", MsgBoxStyle.Information, "Information!!")
        ElseIf txtsuplier.Text = "" Then
            MsgBox("Please Input Suplier", MsgBoxStyle.Information, "Information!!")
        ElseIf Delto.Text = "" Then
            MsgBox("Please Input Delivery to", MsgBoxStyle.Information, "Information!!")
        Else
            topdate()
            noOtomatis()
            DR.Close()
            Dim simpanpo As String = "insert into tblpo values('" & txtno.Text & "','" & txtnopr.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & Format(nedeed.Value, "yyyy-MM-dd") & "','" & credit.Text & "','" & txtsuplier.Text & "','" & txtnohp.Text & "','" & txtfax.Text & "','" & txtalamat.Text & "','" & lblqty.Text & "','" & CDec(txttotal.Text) & "','" & lbluser.Text & "','" & Approved.Text & "','" & Acknowledged.Text & "','" & txtremaks.Text & "','" & Delto.Text & "','" & jmlhitem.Text & "' )"
            CMD = New MySqlCommand(simpanpo, Konn)
            CMD.ExecuteNonQuery()

            For baris As Integer = 0 To DGVPO.Rows.Count - 1
                Dim simpanDetail As String = "insert into tblpodetail values('" & txtno.Text & "','" & Format(DateNow.Value, "yyyy-MM-dd") & "','" & DGVPO.Rows(baris).Cells(0).Value & "','" & DGVPO.Rows(baris).Cells(1).Value & "','" & DGVPO.Rows(baris).Cells(2).Value & "','" & DGVPO.Rows(baris).Cells(3).Value & "','" & CDec(DGVPO.Rows(baris).Cells(4).Value) & "','" & CDec(DGVPO.Rows(baris).Cells(5).Value) & "', '" & "" & "')"
                CMD = New MySqlCommand(simpanDetail, Konn)
                CMD.ExecuteNonQuery()
            Next

            CMD = New MySqlCommand("select * from tblpr where nopr='" & txtnopr.Text & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()

            '=======>mengurangi Stock Gudang
            Dim kurangibalance As String = "update tblpr set balance ='" & DR.Item("balance") - jmlhitem.Text & "' where nopr='" & txtnopr.Text & "'"
            CMD = New MySqlCommand(kurangibalance, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            MsgBox("Input Purcase Order Succesfull", MsgBoxStyle.Question, "Purchase Requesition")
            Me.Close()
            POLIST.kondisiAwal()
        End If
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If txtqty.Text > DGVPO.CurrentRow.Cells(3).Value Then
                MsgBox("Please Change in Purchase Request", MsgBoxStyle.Critical, "Warning!!")
            Else
                DGVPO.CurrentRow.Cells(3).Value = txtqty.Text
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(4).Value * DGVPO.CurrentRow.Cells(3).Value
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                txtdischarga.Enabled = False
                txtppn.Enabled = False
            End If
        End If
    End Sub

    Private Sub DGVPO_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPO.CellMouseClick
        txtitemno.Text = DGVPO.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVPO.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVPO.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVPO.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = Format(DGVPO.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        amount.Text = DGVPO.CurrentRow.Cells(4).Value
        discount.Text = DGVPO.CurrentRow.Cells(4).Value
        txtdischarga.Text = ""
        txtppn.Text = ""
        txtdischarga.Enabled = True
        txtppn.Enabled = True
    End Sub

    Private Sub txtppn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtppn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtppn.Text = "" Or txtppn.Text = "0" Then
                DGVPO.CurrentRow.Cells(4).Value = discount.Text
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(3).Value * DGVPO.CurrentRow.Cells(4).Value
            Else
                DGVPO.CurrentRow.Cells(4).Value = Val(txtppn.Text * DGVPO.CurrentRow.Cells(4).Value * 0.01) + DGVPO.CurrentRow.Cells(4).Value
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(3).Value * DGVPO.CurrentRow.Cells(4).Value
                rumusSubtotal()
            End If
        End If
    End Sub

    Private Sub txtitemno_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseDoubleClick
        CariBarang.Show()
    End Sub

    Private Sub lblprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblprice.KeyPress
        If e.KeyChar = Chr(13) Then
            If discount.Text <> amount.Text Then
                DGVPO.CurrentRow.Cells(4).Value = amount.Text
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(3).Value * DGVPO.CurrentRow.Cells(4).Value
                discount.Text = DGVPO.CurrentRow.Cells(4).Value
                rumusSubtotal()
            Else
                DGVPO.CurrentRow.Cells(4).Value = lblprice.Text
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(4).Value * DGVPO.CurrentRow.Cells(3).Value
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                txtdischarga.Enabled = False
                txtppn.Enabled = False
            End If
        End If
    End Sub

    Private Sub DGVPO_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVPO.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

            Else
                If DGVPO.CurrentRow.Index <> DGVPO.NewRowIndex Then
                    DGVPO.Rows.RemoveAt(DGVPO.CurrentRow.Index)
                    rumusCariitem()
                    rumusSubtotal()
                    ITEMTOTAL()
                End If
            End If
        End If
    End Sub

    Private Sub txtdischarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdischarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtdischarga.Text = "" Or txtdischarga.Text = "0" Then
                DGVPO.CurrentRow.Cells(4).Value = amount.Text
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(3).Value * DGVPO.CurrentRow.Cells(4).Value
                discount.Text = DGVPO.CurrentRow.Cells(4).Value
                rumusSubtotal()
            Else
                DGVPO.CurrentRow.Cells(4).Value = DGVPO.CurrentRow.Cells(4).Value - Val(txtdischarga.Text * DGVPO.CurrentRow.Cells(4).Value * 0.01)
                DGVPO.CurrentRow.Cells(5).Value = DGVPO.CurrentRow.Cells(3).Value * DGVPO.CurrentRow.Cells(4).Value
                discount.Text = DGVPO.CurrentRow.Cells(4).Value
                rumusSubtotal()
            End If
        End If
    End Sub
End Class