Imports MySql.Data.MySqlClient
Public Class PREDIT

    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount, supplier from tblprdetail where description Like'%" & TextBox3.Text & "%' and nopr='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVPR.DataSource = DS.Tables(0)
    End Sub

    Sub rumusSubtotal()
        Dim hitung As Double = 0

        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitung = hitung + DGVPR.Rows(i).Cells(5).Value
        Next
        lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
    End Sub

    Sub kondisiawal()
        Label14.Visible = False
        txtqty.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        dateneed.Enabled = False
        daterex.Enabled = False
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
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount, supplier from tblprdetail Where nopr='" & txtno.Text & "' order by noitem", Konn)
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
        DGVPR.Columns(6).HeaderText = "Supplier"
    End Sub

    'Sub idstore()
    '    KONEKDB()
    '    'DA = New MySqlDataAdapter("Select")
    '    CMD = New MySqlCommand("Select * from tblgudang", Konn)
    '    DR = CMD.ExecuteReader
    '    Do While DR.Read
    '        Label9.Text = (DR.Item(1))
    '    Loop
    'End Sub
    Private Sub PREDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'buatKolom()
        Label9.Text = "1"
        kondisiawal()

        'txtitemno.Enabled = False
        rumusCariitem()
        rumusSubtotal()

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

        itemQty()
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs)
        isiform()
    End Sub

    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitungItem = hitungItem + DGVPR.Rows(i).Cells(3).Value
        Next
        lblqty.Text = hitungItem
    End Sub

    Sub itemQty()
        Dim jmlh1 As Integer
        jmlh1 = DGVPR.Rows.Count
        Label18.Text = jmlh1
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If CheckBox1.Checked Then
            Dim update As String = "update tblpr set approved ='" & Label7.Text & "' where nopr='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If


        If CheckBox2.Checked Then
            Dim update As String = "update tblpr set Acknowledged ='" & Label8.Text & "' where nopr='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If

        For baris As Integer = 0 To DGVPR.Rows.Count - 1
            Dim updateqty As String = "update tblprdetail set qty ='" & DGVPR.Rows(baris).Cells(3).Value & "', amount='" & DGVPR.Rows(baris).Cells(5).Value & "', supplier='" & DGVPR.Rows(baris).Cells(6).Value & "' where nopr='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateqty, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

        Next

        For baris2 As Integer = 0 To DGVPR.Rows.Count - 1
            KONEKDB()
            CMD = New MySqlCommand("select * from tblprdetail where nopr='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris2).Cells(0).Value & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpanDetail As String = "insert into tblprdetail values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVPR.Rows(baris2).Cells(0).Value & "','" & DGVPR.Rows(baris2).Cells(1).Value & "','" & DGVPR.Rows(baris2).Cells(2).Value & "','" & DGVPR.Rows(baris2).Cells(3).Value & "','" & CDbl(DGVPR.Rows(baris2).Cells(4).Value) & "','" & CDbl(DGVPR.Rows(baris2).Cells(5).Value) & "','" & " " & "','" & " " & "')"
                CMD = New MySqlCommand(simpanDetail, Konn)
                DR.Close()
                CMD.ExecuteNonQuery()
                'Continue For
            Else

            End If
        Next
        '==============Update Balance/Qty/Amount Total======================
        Dim updateqtypr As String = "update tblpr set balance ='" & Label18.Text & "', qtytotal ='" & lblqty.Text & "', amount='" & CDec(lbltotal.Text) & "' where nopr='" & txtno.Text & "'"
        CMD = New MySqlCommand(updateqtypr, Konn)
        DR.Close()
        CMD.ExecuteNonQuery()

        MsgBox("Update Success", MsgBoxStyle.Information, "Information!!")
        Me.Close()
        PRLIST.kondisiAwal()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        kondisiawal()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label7.Text = Form1MenuUtama.StatusUser.Text
            CheckBox1.Enabled = False
        End If
    End Sub


    Private Sub DGVPR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPR.CellMouseClick
        txtqty.Enabled = True
        TextBox1.Visible = False
        txtqty.Select()
        'txtitemno.Enabled = False
        txtitemno.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value
        lblunit.Text = DGVPR.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVPR.Rows(e.RowIndex).Cells(3).Value
        lblprice.Text = DGVPR.Rows(e.RowIndex).Cells(4).Value
        Label16.Text = DGVPR.Rows(e.RowIndex).Cells(6).Value.ToString
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
                itemQty()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label14.Text <> "" Then
            If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

            Else
                hapusdatabase()
                isiform()
                rumusSubtotal()
                Label14.Text = ""
                rumusSubtotal()
                rumusCariitem()
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
                itemQty()
                Exit Sub
            End If
        End If
    End Sub
    Sub hapusdatabase()
        Try
            KONEKDB()
            Dim hapus As String
            For baris As Integer = 0 To DGVPR.Rows.Count - 1
                hapus = "delete from tblprdetail where nopr='" & txtno.Text & "' and noitem='" & Label14.Text & "'"
                CMD = New MySqlCommand(hapus, Konn)
                CMD.ExecuteNonQuery()
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVPR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPR.CellClick
        Label14.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs)
        If Label14.Text = "" Then
            MsgBox("Please Select Item", MsgBoxStyle.Information, "Information!!")
        Else
            CARISUPLIER.ShowDialog()
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = ""
            Label14.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        CARIITEM()
    End Sub

    Private Sub DGVPR_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPR.CellMouseDoubleClick
        If Label8.Text <> "" Then
            MsgBox("Document Can't Edit", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
        Else
            If Label7.Text <> "" Then
                supplier.ShowDialog()
            Else
                MsgBox("Please Approved By Dept Head", MsgBoxStyle.Exclamation, "" & txtno.Text & "")
            End If
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            If String.IsNullOrWhiteSpace(DGVPR.Rows(i).Cells(6).Value) Then
                MsgBox("Please Input Supplier", MsgBoxStyle.Critical, "Item Supplier")
                CheckBox2.Checked = False
                Label8.Text = ""
                CheckBox2.Enabled = True
                Exit For
                Exit Sub
            Else
                Label8.Text = Form1MenuUtama.StatusUser.Text
                CheckBox2.Enabled = False
            End If
        Next
    End Sub
End Class