Imports MySql.Data.MySqlClient
Public Class DirectPurchaseEdit
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitung = hitung + DGVPR.Rows(i).Cells(5).Value
        Next
        lbltotal.Text = Format(hitung, "0,000.00")
    End Sub

    Sub kondisiawal()
        txtsuplier.Enabled = False
        lbltlpsuplier.Enabled = False
        lblemailsuplier.Enabled = False
        Label14.Text = ""
        Label19.Text = ""
        'Label14.Visible = False
        txtqty.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        dateneed.Enabled = False
        'daterex.Enabled = False
        txtno.Enabled = False
        ComboBox1.Enabled = False
        Label7.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = True
        Label8.Text = ""
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        isiform()
        'BoxSupplier.Visible = False
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            Label7.Text = Form1MenuUtama.StatusUser.Text
            CheckBox1.Enabled = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
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
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tbl_directpurchasedetail Where norcv='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVPR.DataSource = (DS.Tables(0))
        'DGVPR.ReadOnly = True

        DGVPR.RowHeadersVisible = False
        DGVPR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVPR.Columns(0).Width = 80
        DGVPR.Columns(1).Width = 400
        DGVPR.Columns(3).Width = 50

        'DGVPR.Columns.Clear()
        DGVPR.Columns(0).HeaderText = "No Item"
        DGVPR.Columns(1).HeaderText = "Description"
        DGVPR.Columns(2).HeaderText = "Unit"
        DGVPR.Columns(3).HeaderText = "OnHand"
        DGVPR.Columns(4).HeaderText = "Price"
        DGVPR.Columns(5).HeaderText = "Amount"
        'DGVPR.Columns(6).HeaderText = "Supplier"

        itemJumlah()

    End Sub
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitungItem = hitungItem + DGVPR.Rows(i).Cells(3).Value
        Next
        lblqty.Text = hitungItem
    End Sub

    Private Sub DirectPurchaseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
        rumusSubtotal()
        Label9.Text = "1"
        DGVPR.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DGVPR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVPR.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DGVPR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If Form1MenuUtama.StatusLevel.Text = "USER" Then
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            'BoxSupplier.Visible = False
        ElseIf Form1MenuUtama.StatusLevel.Text = "GENSUPV" Then
            CheckBox2.Visible = False
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Sub itemJumlah()
        Dim jmlh1 As Integer
        jmlh1 = DGVPR.Rows.Count - 1
        'jmlh2 = DataGridView1.Rows.Count
        Label18.Text = jmlh1
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Dim updatebalance As String = "update tbl_directpurchase set balance = '" & Label18.Text & "' where nopr = '" & txtno.Text & "'"
        'CMD = New MySqlCommand(updatebalance, Konn)
        'CMD.ExecuteNonQuery()

        If CheckBox1.Checked Then
            Dim update As String = "update tbl_directpurchase set approved ='" & Label7.Text & "' where nodirect='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If

        If Label7.Text <> "" Then
            Dim updatecoa As String = "update tbl_directpurchase set idcoa ='" & idcoa.Text & "', maincoa ='" & maincoa.Text & "', subcoa ='" & coaexpenses.Text & "'  where nodirect='" & txtno.Text & "'"
            CMD = New MySqlCommand(updatecoa, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If


        If CheckBox2.Checked Then
            Dim update As String = "update tbl_directpurchase set Acknowledged ='" & Label8.Text & "' where nodirect='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            Dim insertAPList As String = "insert into tbl_ap_list values('" & txtsuplier.Text & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & txtno.Text & "','" & CDbl(lbltotal.Text) & "','" & "0" & "','" & CDbl(lbltotal.Text) & "','" & Format(Today, "yyyy-MM-dd") & "')"
            CMD = New MySqlCommand(insertAPList, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            'For baris2 As Integer = 0 To DGVPR.Rows.Count - 1
            '    Dim simpanDetail As String = "insert into tbl_ap_listdetail values('" & txtno.Text & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & DataGridView1.Rows(baris2).Cells(0).Value & "','" & DataGridView1.Rows(baris2).Cells(1).Value & "','" & DataGridView1.Rows(baris2).Cells(2).Value & "','" & DataGridView1.Rows(baris2).Cells(3).Value & "','" & CDbl(DataGridView1.Rows(baris2).Cells(4).Value) & "','" & CDbl(DataGridView1.Rows(baris2).Cells(5).Value) & "')"
            '    CMD = New MySqlCommand(simpanDetail, Konn)
            '    CMD.ExecuteNonQuery()
            '    DS = New DataSet
            'Next

            Dim simpanjurnal As String = "insert into tbljurnal values('" & LBLIDReport.Text & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & idcoa.Text & "','" & maincoa.Text & "','" & CDbl(lbltotal.Text) & "','" & "0" & "','" & "" & "')"
            CMD = New MySqlCommand(simpanjurnal, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            Dim simpanjurnal2 As String = "insert into tbljurnal values('" & "2000" & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & "200-001-001" & "','" & "Account Payable Trade" & "','" & "0" & "','" & CDbl(lbltotal.Text) & "','" & "" & "')"
            CMD = New MySqlCommand(simpanjurnal2, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            If LBLIDReport.Text = 1300 Then
                For baris2 As Integer = 0 To DGVPR.Rows.Count - 1
                    Dim transaksibarangKeluar As String = "insert into tbl_transaksibarang values('" & DGVPR.Rows(baris2).Cells(0).Value & "','" & DGVPR.Rows(baris2).Cells(1).Value & "','" & DGVPR.Rows(baris2).Cells(2).Value & "','" & CDbl(DGVPR.Rows(baris2).Cells(4).Value) & "','" & DGVPR.Rows(baris2).Cells(3).Value & "','" & "0" & "','" & "1" & "')"
                    CMD = New MySqlCommand(transaksibarangKeluar, Konn)
                    CMD.ExecuteNonQuery()
                Next
            End If
        End If

        For baris As Integer = 0 To DGVPR.Rows.Count - 1
            Dim updateqty As String = "update tbl_directpurchasedetail set qty ='" & DGVPR.Rows(baris).Cells(3).Value & "', amount='" & DGVPR.Rows(baris).Cells(5).Value & "' where norcv='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateqty, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        Next

        For baris2 As Integer = 0 To DGVPR.Rows.Count - 1
            KONEKDB()
            CMD = New MySqlCommand("select * from tbl_directpurchasedetail where norcv='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris2).Cells(0).Value & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpanDetail As String = "insert into tbl_directpurchasedetail values('" & txtno.Text & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & DGVPR.Rows(baris2).Cells(0).Value & "','" & DGVPR.Rows(baris2).Cells(1).Value & "','" & DGVPR.Rows(baris2).Cells(2).Value & "','" & DGVPR.Rows(baris2).Cells(3).Value & "','" & CDbl(DGVPR.Rows(baris2).Cells(4).Value) & "','" & CDbl(DGVPR.Rows(baris2).Cells(5).Value) & "')"
                CMD = New MySqlCommand(simpanDetail, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()

                'Continue For
            Else

            End If
        Next

        'For baris As Integer = 0 To DataGridView1.Rows.Count - 1
        '    Dim simpanDetail As String = "insert into tbl_directpurchasedetail values('" & txtno.Text & "','" & Format(dateneed.Value, "yyyy-MM-dd") & "','" & DataGridView1.Rows(baris).Cells(0).Value & "','" & DataGridView1.Rows(baris).Cells(1).Value & "','" & DataGridView1.Rows(baris).Cells(2).Value & "','" & DataGridView1.Rows(baris).Cells(3).Value & "','" & CDec(DataGridView1.Rows(baris).Cells(4).Value) & "','" & CDec(DataGridView1.Rows(baris).Cells(5).Value) & "')"
        '    CMD = New MySqlCommand(simpanDetail, Konn)
        '    CMD.ExecuteNonQuery()
        '    DS = New DataSet
        'Next

        Dim updateqtypr As String = "update tbl_directpurchase set qtytotal ='" & lblqty.Text & "', amount='" & CDec(lbltotal.Text) & "' where nodirect='" & txtno.Text & "'"
        CMD = New MySqlCommand(updateqtypr, Konn)
        DR.Close()
        CMD.ExecuteNonQuery()

        MsgBox("Update Success", MsgBoxStyle.Information, "Information!!")
        Me.Close()
        DirectUse_List.kondisiAwal()
    End Sub
    Private Sub DGVPR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPR.CellMouseClick
        txtqty.Enabled = True
        'txtitemno.Enabled = False
        txtitemno.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVPR.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVPR.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = Format(DGVPR.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        'Label16.Text = DGVPR.Rows(e.RowIndex).Cells(6).Value.ToString
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            DGVPR.CurrentRow.Cells(3).Value = txtqty.Text
            DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(4).Value * DGVPR.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
            txtqty.Enabled = False
            txtitemno.Enabled = True
        End If
    End Sub

    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        CariBarang.TAMPILBARANG_PR()
        CariBarang.Show()
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If DGVPR.Rows(0).Index = 0 Then
                For barisatas As Integer = 0 To DGVPR.RowCount - 1
                    If txtitemno.Text = DGVPR.Rows(barisatas).Cells(0).Value Then
                        MsgBox("Item already exists", MsgBoxStyle.Information, "Information!!")
                        txtitemno.Text = ""
                        TextBox1.Text = ""
                        lblnamaitem.Text = "NAME ITEM"
                        lblprice.Text = ""
                        lblunit.Text = ""
                        Exit Sub
                    End If
                Next
                Dim dt As DataTable = DirectCast(DGVPR.DataSource, DataTable)
                dt.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, TextBox1.Text, lblprice.Text, lblprice.Text * Val(TextBox1.Text)})
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                TextBox1.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                TextBox1.Visible = False
                itemJumlah()
            End If
        End If
    End Sub

    Sub hapusdatabase()
        Try

            Dim hapus As String
            For baris As Integer = 0 To DGVPR.Rows.Count - 1
                hapus = "delete from tbl_directpurchasedetail where norcv='" & txtno.Text & "' and noitem='" & Label14.Text & "'"
                CMD = New MySqlCommand(hapus, Konn)
                CMD.ExecuteNonQuery()
            Next
            itemJumlah()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVPR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPR.CellClick
        Label14.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
        Label19.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub txtdischarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdischarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtdischarga.Text = "" Or txtdischarga.Text = "0" Then
                DGVPR.CurrentRow.Cells(4).Value = amount.Text
                DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(3).Value * DGVPR.CurrentRow.Cells(4).Value
                discount.Text = DGVPR.CurrentRow.Cells(4).Value
                rumusSubtotal()
            Else
                DGVPR.CurrentRow.Cells(4).Value = DGVPR.CurrentRow.Cells(4).Value - Val(txtdischarga.Text * DGVPR.CurrentRow.Cells(4).Value * 0.01)
                DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(3).Value * DGVPR.CurrentRow.Cells(4).Value
                discount.Text = DGVPR.CurrentRow.Cells(4).Value
                rumusSubtotal()
            End If
        End If
    End Sub

    Private Sub DGVPR_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVPR.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Are You Sure to Delete '" & Label19.Text & "'?", "Caution!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                hapusdatabase()
                isiform()
                'rumusSubtotal()
                Label14.Text = ""
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
            Else
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""

            End If
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then

            If MessageBox.Show("Are You Sure to Delete '" & Label21.Text & "'?", "Caution!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then

            Else
                'If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                '    DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                '    rumusSubtotal()
                '    rumusCariitem()
                '    txtitemno.Text = ""
                '    txtqty.Text = ""
                '    lblnamaitem.Text = "NAME ITEM"
                '    lblprice.Text = ""
                '    lblunit.Text = ""
                'End If

            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Label21.Font = New Font(Label21.Font.FontFamily, Label21.Font.Size, FontStyle.Bold)
        Label21.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value

    End Sub

    Private Sub lblprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblprice.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            DGVPR.CurrentRow.Cells(4).Value = lblprice.Text
            DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(4).Value * DGVPR.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
        End If
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
End Class