Imports MySql.Data.MySqlClient
Public Class FormPR
    'Sub comboboxdept()
    '    KONEKDB()
    '    'DA = New MySqlDataAdapter("Select")
    '    CMD = New MySqlCommand("Select * from tbl_dept", Konn)
    '    DR = CMD.ExecuteReader
    '    Do While DR.Read
    '        ComboBox1.Items.Add(DR.Item(1))
    '    Loop
    'End Sub
    '======>MECARI GRANDTOTAL<=======
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitung = hitung + DGVPR.Rows(i).Cells(5).Value
            lbltotal.Text = Format(hitung, "#,###.00")
        Next
    End Sub
    '======>MECARI TOTAL ITEM<=======
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitungItem = hitungItem + DGVPR.Rows(i).Cells(3).Value
            lblqty.Text = hitungItem
        Next
    End Sub
    '======>KELUAR FORM<=======
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        PRLIST.kondisiAwal()
    End Sub
    '======>KONDISI AWAL<=======
    Sub KONDISIAWAL()
        ComboBox1.Text = ""
        Approve.Text = ""
        Acknowledged.Text = ""
        lblnamaitem.Text = "Name Item"
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        lblprice.Text = ""
        lblunit.Text = ""
        txtremaks.Text = ""
        txtitemno.Text = ""
        txtno.Text = ""
        txtqty.Text = ""
        'ComboBox1.SelectedIndex = 0
        lbltotal.Text = ""
        lblqty.Text = ""
        daterex.Enabled = False

        daterex.Value = Today
        dateneed.Value = Today
        txtno.Enabled = False
        buatKolom()

    End Sub
    '======>PENOMORAN OTOMATIS<=======
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tblpr where nopr in(select max(nopr) from tblpr)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "PR" + Format(Now, "yyMMdd") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 10) + 1
            urutanKode = "PR" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    '======> PEMBUATAN COLOM DATAGRIDVIEW <=======
    Sub buatKolom()
        DGVPR.Columns.Clear()
        DGVPR.Columns.Add("KodeBarang", "No Item")
        DGVPR.Columns.Add("NamaBarang", "Description")
        DGVPR.Columns.Add("Satuan", "Unit")
        DGVPR.Columns.Add("Jumlah", "Qty")
        DGVPR.Columns.Add("harga", "Price")
        DGVPR.Columns.Add("total", "Amount")

        DGVPR.RowHeadersVisible = False
        DGVPR.Columns(1).Width = 350
        DGVPR.Columns(4).Width = 170
        DGVPR.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVPR.Columns(2).Width = 50
        DGVPR.Columns(3).Width = 90

    End Sub
    '======>LOAD FORM<=======
    Private Sub FormPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        'comboboxdept()

        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store = '" & "General Store" & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            idstorekeluar.Text = DR.Item(0)
        End If
    End Sub
    '======>MECARI BARANG JIKA TEXTBOX DI KLICK<=======
    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        If ComboBox1.Text = "" Then
            MsgBox("Please Input Depatment", MsgBoxStyle.Critical, "Departement")
        Else
            CariBarang.TAMPILBARANG_PR()
            CariBarang.ShowDialog()
            txtqty.Focus()
        End If
    End Sub
    '======>MENYIMPAN KE DATAGRIDVIEW<=======

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            If DGVPR.CurrentRow.Index <> DGVPR.NewRowIndex Then
                DGVPR.Rows.RemoveAt(DGVPR.CurrentRow.Index)
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                itemJumlah()
            End If
        End If
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If txtitemno.Text = "" Or txtqty.Text = "" Then
                MsgBox("Please Input Item And Input Qty", MsgBoxStyle.Information, "Information!!")
            Else
                If DGVPR.Rows(0).Index = 0 Then
                    For barisatas As Integer = 0 To DGVPR.RowCount - 1
                        If txtitemno.Text = DGVPR.Rows(barisatas).Cells(0).Value Then
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
                    DGVPR.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, txtqty.Text, lblprice.Text, Format(lblprice.Text.ToString * Val(txtqty.Text), "#,###.#0")})
                    rumusSubtotal()
                    rumusCariitem()
                    txtitemno.Text = ""
                    txtqty.Text = ""
                    lblnamaitem.Text = "NAME ITEM"
                    lblprice.Text = ""
                    lblunit.Text = ""
                    itemJumlah()
                End If
            End If
        End If
    End Sub

    Sub itemJumlah()
        Dim jmlh As Integer
        jmlh = DGVPR.Rows.Count - 1
        jmlhitem.Text = jmlh
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If lbltotal.Text = "" Then
            MsgBox("Please Insert Item", MsgBoxStyle.Information, "Information!!")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Please Input Department", MsgBoxStyle.Information, "Information!!")
        Else
            noOtomatis()
            Dim simpanpr As String = "insert into tblpr values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & Format(dateneed.Value, "yyyyMMdd") & "','" & lblqty.Text & "','" & CDec(lbltotal.Text) & "','" & lbluser.Text & "','" & Approve.Text & "','" & Acknowledged.Text & "','" & ComboBox1.Text & "','" & txtremaks.Text & "','" & jmlhitem.Text & "')"
            CMD = New MySqlCommand(simpanpr, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
            For baris As Integer = 0 To DGVPR.Rows.Count - 2
                Dim simpanDetail As String = "insert into tblprdetail values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVPR.Rows(baris).Cells(0).Value & "','" & DGVPR.Rows(baris).Cells(1).Value & "','" & DGVPR.Rows(baris).Cells(2).Value & "','" & DGVPR.Rows(baris).Cells(3).Value & "','" & CDec(DGVPR.Rows(baris).Cells(4).Value) & "','" & CDec(DGVPR.Rows(baris).Cells(5).Value) & "','" & "" & "','" & " " & "')"
                CMD = New MySqlCommand(simpanDetail, Konn)
                CMD.ExecuteNonQuery()
                DS = New DataSet
            Next
            'If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            '    KONDISIAWAL()
            'Else
            '    PRINT_PR.Show()
            '    PRINT_PR.ReportPR.ReportSource = "printpr.rpt"
            '    PRINT_PR.ReportPR.SelectionFormula = "{@nopr}='" & txtno.Text & "'"
            '    PRINT_PR.ReportPR.RefreshReport()
            'End If
            MsgBox("Input PR Success", MsgBoxStyle.Information, "Information!!")
            PRLIST.kondisiAwal()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            DGVPR.CurrentRow.Cells(3).Value = TextBox1.Text
            DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(4).Value * DGVPR.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            Dept.Show()
        Else
            ComboBox1.Text = ""
            Button2.Text = "?"
            Dept.Show()
        End If
    End Sub

    Private Sub DGVPR_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVPR.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

            Else
                If DGVPR.CurrentRow.Index <> DGVPR.NewRowIndex Then
                    DGVPR.Rows.RemoveAt(DGVPR.CurrentRow.Index)
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

    Private Sub DGVPR_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPR.CellMouseDoubleClick
        TextBox1.Visible = True
        TextBox1.Text = ""
        txtitemno.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVPR.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVPR.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = DGVPR.Rows(e.RowIndex).Cells(4).Value
        TextBox1.Focus()
    End Sub
End Class