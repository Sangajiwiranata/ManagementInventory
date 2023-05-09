Imports MySql.Data.MySqlClient
Public Class SR_EDIT
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVSR.Rows.Count - 1
            hitung = hitung + DGVSR.Rows(i).Cells(5).Value
        Next
        lbltotal.Text = Format(hitung, "0,000.00")
    End Sub


    Sub kondisiawal()
        lblprice.Enabled = False
        'txtlocation.Enabled = False
        ' department.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        daterex.Enabled = False
        txtno.Enabled = False
        'ComboBox1.Enabled = False
        Label8.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = True
        Label7.Text = ""
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        isiform()
    End Sub
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount, idcoa, maincoa, subcoa, allocation from tblsrdetail Where nosr='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVSR.DataSource = (DS.Tables(0))
        DGVSR.ReadOnly = True

        DGVSR.RowHeadersVisible = False
        'DGVSR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSR.Columns(0).Width = 80
        DGVSR.Columns(1).Width = 400
        DGVSR.Columns(3).Width = 50



        DGVSR.Columns(0).HeaderText = "No Item"
        DGVSR.Columns(1).HeaderText = "Description"
        DGVSR.Columns(2).HeaderText = "Unit"
        DGVSR.Columns(3).HeaderText = "OnHand"
        DGVSR.Columns(4).HeaderText = "Price"
        DGVSR.Columns(5).HeaderText = "Amount"
        DGVSR.Columns(6).HeaderText = "ID COA"
        DGVSR.Columns(7).HeaderText = "Main Coa"
        DGVSR.Columns(8).HeaderText = "Sub Expenses"
        DGVSR.Columns(9).HeaderText = "Allocation Expenses"
        DGVSR.Columns.Add("10", "Allocation ID")
    End Sub

    Private Sub PREDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
        rumusSubtotal()
        idstore()
        TextBox1.Visible = False
        DGVSR.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DGVSR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVSR.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DGVSR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If Form1MenuUtama.StatusLevel.Text = "USER" Then
            CheckBox1.Visible = False
            CheckBox2.Visible = False
        ElseIf Form1MenuUtama.StatusLevel.Text = "GENSUPV" Then
            CheckBox2.Visible = False

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
            Dim update As String = "update tblsr set approved ='" & Label7.Text & "' where nosr='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
            'MsgBox("Approved Success")
        End If

        If Label7.Text <> "" Then
            For bariscoa As Integer = 0 To DGVSR.Rows.Count - 1
                Dim updatecoa As String = "update tblsrdetail set idcoa ='" & DGVSR.Rows(bariscoa).Cells(6).Value & "', maincoa='" & DGVSR.Rows(bariscoa).Cells(7).Value & "', subcoa ='" & DGVSR.Rows(bariscoa).Cells(8).Value & "', allocation='" & DGVSR.Rows(bariscoa).Cells(9).Value & "' where nosr='" & txtno.Text & "' and noitem='" & DGVSR.Rows(bariscoa).Cells(0).Value & "'"
                CMD = New MySqlCommand(updatecoa, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()
            Next

        End If


        If CheckBox2.Checked Then
            Dim update As String = "update tblsr set Acknowledged ='" & Label8.Text & "' where nosr='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
            'MsgBox("Acknowledged Success")

            For baris2 As Integer = 0 To DGVSR.Rows.Count - 1
                Dim simpanjurnal As String = "insert into tbljurnal values('" & DGVSR.Rows(baris2).Cells(10).Value & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & DGVSR.Rows(baris2).Cells(6).Value & "','" & DGVSR.Rows(baris2).Cells(7).Value & "','" & CDbl(DGVSR.Rows(baris2).Cells(5).Value) & "','" & "" & "','" & "" & "')"
                CMD = New MySqlCommand(simpanjurnal, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()

                Dim simpanjurnal2 As String = "insert into tbljurnal values('" & "1300" & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & Format(Today, "ddMMyyyy").ToString & "','" & txtno.Text & "','" & "100-002-001" & "','" & "Inventory Warehose" & "','" & "" & "','" & CDbl(DGVSR.Rows(baris2).Cells(5).Value) & "','" & "" & "')"
                CMD = New MySqlCommand(simpanjurnal2, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()

                Dim transaksibarangKeluar As String = "insert into tbl_transaksibarang values('" & DGVSR.Rows(baris2).Cells(0).Value & "','" & DGVSR.Rows(baris2).Cells(1).Value & "','" & DGVSR.Rows(baris2).Cells(2).Value & "','" & CDbl(DGVSR.Rows(baris2).Cells(4).Value) & "','" & "0" & "','" & DGVSR.Rows(baris2).Cells(3).Value & "','" & idstorekeluar.Text & "')"
                CMD = New MySqlCommand(transaksibarangKeluar, Konn)
                CMD.ExecuteNonQuery()
            Next

        End If
        For baris As Integer = 0 To DGVSR.Rows.Count - 1
            Dim updateqty As String = "update tblsrdetail set qty ='" & DGVSR.Rows(baris).Cells(3).Value & "', amount='" & DGVSR.Rows(baris).Cells(5).Value & "' where nosr='" & txtno.Text & "' and noitem='" & DGVSR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateqty, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        Next

        For baris2 As Integer = 0 To DGVSR.Rows.Count - 1
            KONEKDB()
            CMD = New MySqlCommand("select * from tblsrdetail where nosr='" & txtno.Text & "' and noitem='" & DGVSR.Rows(baris2).Cells(0).Value & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpanDetail As String = "insert into tblsrdetail values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVSR.Rows(baris2).Cells(0).Value & "','" & DGVSR.Rows(baris2).Cells(1).Value & "','" & DGVSR.Rows(baris2).Cells(2).Value & "','" & DGVSR.Rows(baris2).Cells(3).Value & "','" & CDbl(DGVSR.Rows(baris2).Cells(4).Value) & "','" & CDbl(DGVSR.Rows(baris2).Cells(5).Value) & "','" & " " & "','" & " " & "','" & " " & "','" & " " & "')"
                CMD = New MySqlCommand(simpanDetail, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()

                'Continue For
            Else

            End If
        Next

        Dim updateqtypr As String = "update tblsr set qtytotal ='" & lblqty.Text & "', amount='" & CDbl(lbltotal.Text) & "' where nosr='" & txtno.Text & "'"
        CMD = New MySqlCommand(updateqtypr, Konn)
        DR.Close()
        CMD.ExecuteNonQuery()

        MsgBox("Update Success", MsgBoxStyle.Information, "Information!!")
        Me.Close()
        SR_LIST.kondisiAwal()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        'Dim pesan As String
        For i As Integer = 0 To DGVSR.Rows.Count - 1
            If DGVSR.Rows(i).Cells(6).Value <> "" Then
                Label8.Text = Form1MenuUtama.StatusUser.Text
                CheckBox2.Enabled = False
            Else
                CheckBox2.Checked = False
                MsgBox("Please Input Supplier", MsgBoxStyle.Critical, "")
            End If

        Next

    End Sub
    Sub idstore()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store = '" & txtlocation.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            idstorekeluar.Text = DR.Item(0)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        kondisiawal()
        Me.Close()
    End Sub

    Private Sub DGVSR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSR.CellContentClick
        txtqty.Enabled = True
        'TextBox1.Visible = False
        txtitemno.Enabled = False

        txtqty.Focus()
        'txtitemno.Enabled = False
        txtitemno.Text = DGVSR.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVSR.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVSR.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVSR.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = Format(DGVSR.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        'Label16.Text = DGVSR.Rows(e.RowIndex).Cells(6).Value.ToString
    End Sub
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0

        For i As Integer = 0 To DGVSR.Rows.Count - 1
            hitungItem = hitungItem + DGVSR.Rows(i).Cells(3).Value

        Next
        lblqty.Text = hitungItem
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            DGVSR.CurrentRow.Cells(3).Value = txtqty.Text
            DGVSR.CurrentRow.Cells(5).Value = DGVSR.CurrentRow.Cells(4).Value * DGVSR.CurrentRow.Cells(3).Value
            rumusSubtotal()
            rumusCariitem()
            txtitemno.Text = ""
            txtqty.Text = ""
            lblnamaitem.Text = "NAME ITEM"
            lblprice.Text = ""
            lblunit.Text = ""
            txtitemno.Enabled = True
            'txtqty.Enabled = False
            'txtitemno.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If DGVSR.Rows(0).Index = 0 Then
                Dim amount As Double
                amount = TextBox1.Text * Format(CDbl(lblprice.Text), "0,000.00")
                For barisatas As Integer = 0 To DGVSR.RowCount - 1
                    If txtitemno.Text = DGVSR.Rows(barisatas).Cells(0).Value Then
                        MsgBox("Item already exists", MsgBoxStyle.Information, "Information!!")
                        txtitemno.Text = ""
                        TextBox1.Text = ""
                        lblnamaitem.Text = "NAME ITEM"
                        lblprice.Text = ""
                        lblunit.Text = ""
                        Exit Sub
                    End If
                Next
                Dim dt As DataTable = DirectCast(DGVSR.DataSource, DataTable)
                dt.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, TextBox1.Text, lblprice.Text, Format(amount, "0,000.00")})
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                TextBox1.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                TextBox1.Visible = False
            End If
        End If
    End Sub

    Private Sub txtitemno_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseDoubleClick
        CariBarang.TAMPILBARANG_SR_edit()
        CariBarang.ShowDialog()
        TextBox1.Select()
    End Sub

    Private Sub DGVSR_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVSR.CellMouseDoubleClick
        If Label8.Text <> "" Then
            MsgBox("Document Can't Edit", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
        Else
            If Label7.Text <> "" Then
                allocationSR.ShowDialog()
            Else
                MsgBox("Please Approved By Dept Head", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
            End If
        End If
    End Sub
End Class