Imports MySql.Data.MySqlClient
Public Class PO_EDIT
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitung = hitung + DGVPR.Rows(i).Cells(5).Value
        Next
        lbltotal.Text = Format(hitung, "0,000.00")
    End Sub

    Sub kondisiawal()
        credit.Enabled = False
        txtnopr.Enabled = False
        Delto.Enabled = False
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        nedeed.Enabled = False
        daterex.Enabled = False
        txtno.Enabled = False
        'ComboBox1.Enabled = False
        Label8.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = True
        Label7.Text = ""
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        txtdischarga.Enabled = True
        txtppn.Enabled = True
        isiform()
        'buatKolom()
    End Sub
    Sub isiform()
        KONEKDB()
        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblpodetail Where nopo='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVPR.DataSource = (DS.Tables(0))
        DGVPR.ReadOnly = True

        DGVPR.RowHeadersVisible = False
        DGVPR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVPR.Columns(0).Width = 80
        DGVPR.Columns(1).Width = 400
        DGVPR.Columns(3).Width = 50

        DGVPR.Columns(0).HeaderText = "No Item"
        DGVPR.Columns(1).HeaderText = "Description"
        DGVPR.Columns(2).HeaderText = "Unit"
        DGVPR.Columns(3).HeaderText = "OnHand"
        DGVPR.Columns(4).HeaderText = "Price"
        DGVPR.Columns(5).HeaderText = "Amount"
    End Sub
    Private Sub PREDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
        rumusSubtotal()
        txtitemno.Enabled = False
        'GroupBox2.Enabled = False
        DGVPR.Columns(4).DefaultCellStyle.Format = "#,###,##"
        DGVPR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVPR.Columns(5).DefaultCellStyle.Format = "#,###,##"
        DGVPR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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
            Dim update As String = "update tblpo set approved ='" & Label7.Text & "' where nopo='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        End If


        If CheckBox2.Checked Then
            Dim update As String = "update tblpo set Acknowledged ='" & Label8.Text & "' where nopo='" & txtno.Text & "'"
            CMD = New MySqlCommand(update, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            For baris2 As Integer = 0 To DGVPR.Rows.Count - 1
                Dim updateqty As String = "update tblprdetail set status ='" & "Done" & "' where nopr='" & txtnopr.Text & "' and noitem='" & DGVPR.Rows(baris2).Cells(0).Value & "'"
                CMD = New MySqlCommand(updateqty, Konn)
                CMD.ExecuteNonQuery()
            Next
        End If

        For baris As Integer = 0 To DGVPR.Rows.Count - 1
            Dim updateqty As String = "update tblpodetail set qty ='" & DGVPR.Rows(baris).Cells(3).Value & "' where nopo='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateqty, Konn)
            CMD.ExecuteNonQuery()

            Dim updateprice As String = "update tblpodetail set price ='" & DGVPR.Rows(baris).Cells(4).Value & "' where nopo='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateprice, Konn)
            CMD.ExecuteNonQuery()

            Dim updateamount As String = "update tblpodetail set amount ='" & DGVPR.Rows(baris).Cells(5).Value & "' where nopo='" & txtno.Text & "' and noitem='" & DGVPR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(updateamount, Konn)
            CMD.ExecuteNonQuery()
        Next


        Dim updateqtypr As String = "update tblpo set qtytotal ='" & lblqty.Text & "', amount='" & CDec(lbltotal.Text) & "' where nopo='" & txtno.Text & "'"
        CMD = New MySqlCommand(updateqtypr, Konn)
        CMD.ExecuteNonQuery()

        MsgBox("Update Success", MsgBoxStyle.Information, "Information!!")
        Me.Close()
        POLIST.kondisiAwal()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label8.Text = Form1MenuUtama.StatusUser.Text
            CheckBox2.Enabled = False
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        kondisiawal()
        Me.Close()
    End Sub

    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        CariBarang.ShowDialog()
    End Sub

    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        Dim hitungItemAdd As Integer = 0
        For i As Integer = 0 To DGVPR.Rows.Count - 1
            hitungItem = hitungItem + DGVPR.Rows(i).Cells(3).Value
        Next
        lblqty.Text = hitungItem + hitungItemAdd
    End Sub

    Private Sub DGVPR_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPR.CellMouseClick

        txtitemno.Text = DGVPR.Rows(e.RowIndex).Cells(0).Value
        lblnamaitem.Text = DGVPR.Rows(e.RowIndex).Cells(1).Value
        lblprice.Text = Format(DGVPR.Rows(e.RowIndex).Cells(4).Value, "0,000.00")
        lblunit.Text = DGVPR.Rows(e.RowIndex).Cells(2).Value
        txtqty.Text = DGVPR.Rows(e.RowIndex).Cells(3).Value

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
            'txtqty.Enabled = False
            txtitemno.Enabled = True
            'GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub txtppn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtppn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If txtppn.Text = "" Or txtppn.Text = "0" Then
                DGVPR.CurrentRow.Cells(4).Value = discount.Text
                DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(3).Value * DGVPR.CurrentRow.Cells(4).Value
            Else
                DGVPR.CurrentRow.Cells(4).Value = Val(txtppn.Text * DGVPR.CurrentRow.Cells(4).Value * 0.01) + DGVPR.CurrentRow.Cells(4).Value
                DGVPR.CurrentRow.Cells(5).Value = DGVPR.CurrentRow.Cells(3).Value * DGVPR.CurrentRow.Cells(4).Value
                rumusSubtotal()
                'GroupBox2.Enabled = False
            End If
        End If
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
                'GroupBox2.Enabled = False

            End If
        End If
    End Sub

    Private Sub lblprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblprice.KeyPress
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
            txtdischarga.Enabled = False
            txtppn.Enabled = False
            'roupBox2.Enabled = False
        End If
    End Sub
End Class