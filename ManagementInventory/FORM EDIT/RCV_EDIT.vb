Imports MySql.Data.MySqlClient
Public Class RCV_EDIT

    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitung = hitung + DGVRCV.Rows(i).Cells(5).Value
            lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
        Next
    End Sub

    Sub kondisiawal()
        txtitemno.Enabled = False
        txtnopo.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        DateTimePicker1.Enabled = False
        txtno.Enabled = False
        Label8.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = True
        Label7.Text = ""
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        DateTimePicker2.Enabled = False
        TextBox1.Enabled = False
        isiform()
        rumusCariitem()
        rumusSubtotal()
    End Sub
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblreceivingdetail Where norcv='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVRCV.DataSource = (DS.Tables(0))
        DGVRCV.ReadOnly = True

        DGVRCV.RowHeadersVisible = False
        DGVRCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVRCV.Columns(0).Width = 80
        DGVRCV.Columns(1).Width = 400
        DGVRCV.Columns(3).Width = 50



        DGVRCV.Columns(0).HeaderText = "No Item"
        DGVRCV.Columns(1).HeaderText = "Description"
        DGVRCV.Columns(2).HeaderText = "Unit"
        DGVRCV.Columns(3).HeaderText = "OnHand"
        DGVRCV.Columns(4).HeaderText = "Price"
        DGVRCV.Columns(5).HeaderText = "Amount"
    End Sub
    Private Sub PREDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()

        DGVRCV.Columns(4).DefaultCellStyle.Format = "0,000.00"
        DGVRCV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVRCV.Columns(5).DefaultCellStyle.Format = "0,000.00"
        DGVRCV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If Form1MenuUtama.StatusLevel.Text = "USER" Then
            CheckBox1.Visible = False
            CheckBox2.Visible = False
        ElseIf Form1MenuUtama.StatusLevel.Text = "GENSUPV" Then
            CheckBox2.Visible = False
        End If
        If coaexpenses.Text <> "" Then
            GroupBox2.Enabled = False
        End If

    End Sub

        Private Sub show_Click(sender As Object, e As EventArgs)
            isiform()
        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
            If CheckBox1.Checked Then
            Label7.Text = Form1MenuUtama.StatusUser.Text
            CheckBox1.Enabled = False

            End If
        End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If CheckBox1.Checked Then
            Dim update As String = "update tblreceiving set approved ='" & Label7.Text & "' where norcv='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If

        If Label7.Text <> "" Then
            Dim updatecoa As String = "update tblreceiving set id_coa ='" & idcoa.Text & "', maincoa ='" & maincoa.Text & "', subcoa ='" & coaexpenses.Text & "'  where norcv='" & txtno.Text & "'"
            CMD = New MySqlCommand(updatecoa, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If

        If CheckBox2.Checked Then
            Dim update As String = "update tblreceiving set Acknowledged ='" & Label8.Text & "' where norcv='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()


            '======== Insert To TBL AP LIST
            Dim simpanaplist As String = "insert into tbl_ap_list values('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & txtno.Text & "','" & CDbl(lbltotal.Text) & "','" & "0" & "','" & CDbl(lbltotal.Text) & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "')"
            CMD = New MySqlCommand(simpanaplist, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            For baris As Integer = 0 To DGVRCV.Rows.Count - 1
                Dim simpanDetailaplist As String = "insert into tbl_ap_listdetail values('" & txtno.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & DGVRCV.Rows(baris).Cells(0).Value & "','" & DGVRCV.Rows(baris).Cells(1).Value & "','" & DGVRCV.Rows(baris).Cells(2).Value & "','" & DGVRCV.Rows(baris).Cells(3).Value & "','" & CDec(DGVRCV.Rows(baris).Cells(4).Value) & "','" & CDec(DGVRCV.Rows(baris).Cells(5).Value) & "', '" & "1" & "')"
                CMD = New MySqlCommand(simpanDetailaplist, Konn)
                CMD.ExecuteNonQuery()

                Dim transaksibarangMasuk As String = "insert into tbl_transaksibarang values('" & DGVRCV.Rows(baris).Cells(0).Value & "','" & DGVRCV.Rows(baris).Cells(1).Value & "','" & DGVRCV.Rows(baris).Cells(2).Value & "','" & DGVRCV.Rows(baris).Cells(4).Value & "','" & DGVRCV.Rows(baris).Cells(3).Value & "','" & "0" & "','" & "1" & "')"
                CMD = New MySqlCommand(transaksibarangMasuk, Konn)
                CMD.ExecuteNonQuery()
            Next

            Dim simpanjurnal As String = "insert into tbljurnal values('" & LBLIDReport.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & idcoa.Text & "','" & maincoa.Text & "','" & CDbl(lbltotal.Text) & "','" & "0" & "','" & "" & "')"
            CMD = New MySqlCommand(simpanjurnal, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            Dim simpanjurnal2 As String = "insert into tbljurnal values('" & "2000" & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & "200-001-001" & "','" & "Account Payable Trade" & "','" & "0" & "','" & CDbl(lbltotal.Text) & "','" & "" & "')"
            CMD = New MySqlCommand(simpanjurnal2, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            For baris2 As Integer = 0 To DGVRCV.Rows.Count - 1
                Dim updateqty As String = "update tblpodetail set status ='" & "Done" & "' where nopo='" & txtnopo.Text & "' and noitem='" & DGVRCV.Rows(baris2).Cells(0).Value & "'"
                CMD = New MySqlCommand(updateqty, Konn)
                CMD.ExecuteNonQuery()
            Next


        End If
        For baris As Integer = 0 To DGVRCV.Rows.Count - 1
            Dim updateqty As String = "update tblreceivingdetail set qty ='" & DGVRCV.Rows(baris).Cells(3).Value & "' where norcv='" & txtno.Text & "' and noitem='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateqty, Konn)
            CMD.ExecuteNonQuery()

            Dim updateprice As String = "update tblreceivingdetail set price ='" & DGVRCV.Rows(baris).Cells(4).Value & "' where norcv='" & txtno.Text & "' and noitem='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateprice, Konn)
            CMD.ExecuteNonQuery()

            Dim updateamount As String = "update tblreceivingdetail set amount ='" & DGVRCV.Rows(baris).Cells(5).Value & "' where norcv='" & txtno.Text & "' and noitem='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateamount, Konn)
            CMD.ExecuteNonQuery()
        Next
        Dim updateqtypr As String = "update tblreceiving set qtytotal ='" & lblqty.Text & "', amount='" & CDbl(lbltotal.Text) & "' where norcv='" & txtno.Text & "'"
        CMD = New MySqlCommand(updateqtypr, Konn)
        CMD.ExecuteNonQuery()

        MsgBox("Update Successful", MsgBoxStyle.Information, "Information")
        Me.Close()
        RCV_LIST.kondisiAwal()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            If coaexpenses.Text = "" Then
                MsgBox("Please Input Alocation Expenses", MsgBoxStyle.Exclamation, "Information!!")
                CheckBox2.Checked = False
            Else
                Label8.Text = Form1MenuUtama.StatusUser.Text
                CheckBox2.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        kondisiawal()
        Me.Close()
    End Sub

    Private Sub coaexpenses_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles coaexpenses.MouseDoubleClick
        If Label8.Text <> "" Then
            MsgBox("Document Can't Edit", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
        Else
            If Label7.Text <> "" Then
                coa_inventory.ShowDialog()
            Else
                MsgBox("Please Approved By Dept Head", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
            End If
        End If
    End Sub

    Private Sub DGVRCV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVRCV.CellMouseClick
        If Label8.Text <> "" Then

        Else
            txtitemno.Text = DGVRCV.Rows(e.RowIndex).Cells(0).Value
            lblnamaitem.Text = DGVRCV.Rows(e.RowIndex).Cells(1).Value
            lblunit.Text = DGVRCV.Rows(e.RowIndex).Cells(2).Value
            txtqty.Text = DGVRCV.Rows(e.RowIndex).Cells(3).Value
            lblprice.Text = Format(DGVRCV.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
            amount.Text = DGVRCV.CurrentRow.Cells(4).Value
            discount.Text = DGVRCV.CurrentRow.Cells(4).Value
            txtdischarga.Text = ""
            txtppn.Text = ""
        End If

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
                DGVRCV.CurrentRow.Cells(4).Value = DGVRCV.CurrentRow.Cells(4).Value - Val(txtdischarga.Text * DGVRCV.CurrentRow.Cells(4).Value * 0.01)
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
                discount.Text = DGVRCV.CurrentRow.Cells(4).Value
                rumusSubtotal()
            End If
        End If
    End Sub
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitungItem = hitungItem + DGVRCV.Rows(i).Cells(3).Value
            lblqty.Text = hitungItem
        Next
    End Sub

    Private Sub txtppn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtppn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtppn.Text = "" Or txtppn.Text = "0" Then
                DGVRCV.CurrentRow.Cells(4).Value = discount.Text
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
            Else
                DGVRCV.CurrentRow.Cells(4).Value = Val(txtppn.Text * DGVRCV.CurrentRow.Cells(4).Value * 0.01) + DGVRCV.CurrentRow.Cells(4).Value
                DGVRCV.CurrentRow.Cells(5).Value = DGVRCV.CurrentRow.Cells(3).Value * DGVRCV.CurrentRow.Cells(4).Value
                rumusSubtotal()
                'GroupBox2.Enabled = False
            End If
        End If
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
End Class