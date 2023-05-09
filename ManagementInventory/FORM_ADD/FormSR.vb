Imports MySql.Data.MySqlClient
Public Class FormSR
    Sub comboboxstore()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            txtlocation.Items.Add(DR.Item(1))
        Loop
    End Sub
    Sub comboboxdept()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_dept", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            department.Items.Add(DR.Item(1))
        Loop
    End Sub
    '======>Button Close<=======
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    '======>MECARI TOTAL AMOUNT<=======
    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DGVSR.Rows.Count - 1
            hitung = hitung + DGVSR.Rows(i).Cells(5).Value
            lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
        Next
    End Sub
    '======>MECARI TOTAL ITEM<=======
    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DGVSR.Rows.Count - 1
            hitungItem = hitungItem + DGVSR.Rows(i).Cells(3).Value
            lblqty.Text = hitungItem
        Next
    End Sub

    '======>KONDISI AWAL<=======
    Sub KONDISIAWAL()
        Approved.Text = ""
        Approved.Visible = False
        Acknowledged.Text = ""
        Acknowledged.Visible = False
        lblnamaitem.Text = ""
        idstorekeluar.Text = ""
        lbluser.Text = Form1MenuUtama.StatusUser.Text
        txtremaks.Text = ""
        txtlocation.Text = ""
        txtitemno.Text = ""
        txtno.Text = ""
        txtqty.Text = ""
        lblunit.Text = ""
        lblprice.Text = ""
        'department.SelectedIndex = 0
        lbltotal.Text = ""
        lblqty.Text = ""
        lblstock.Text = ""
        daterex.Enabled = False
        daterex.Value = Today
        txtno.Enabled = False
        buatKolom()
        'noOtomatis()
    End Sub

    '======>PENOMORAN OTOMATIS<=======
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tblsr where nosr in(select max(nosr) from tblsr)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "SR" + Format(Now, "ddMMyy") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            urutanKode = "SR" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    '======>PEMBUATAN COLOM DATAGRIDVIEW<=======
    Sub buatKolom()
        DGVSR.Columns.Clear()
        DGVSR.Columns.Add("KodeBarang", "No Item")
        DGVSR.Columns.Add("NamaBarang", "Description")
        DGVSR.Columns.Add("Satuan", "Unit")
        DGVSR.Columns.Add("Jumlah", "Qty")
        DGVSR.Columns.Add("harga", "Price")
        DGVSR.Columns.Add("total", "Amount")

        DGVSR.RowHeadersVisible = False
        DGVSR.Columns(1).Width = 450
        DGVSR.Columns(4).Width = 170
        DGVSR.Columns(2).Width = 60
        DGVSR.Columns(3).Width = 90
    End Sub
    '======>FORM LOAD<==========
    Private Sub FormSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        comboboxdept()
        comboboxstore()
    End Sub

    '=======>cari item<========
    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        If idstorekeluar.Text = "" Then
            MsgBox("Please Select Warehose", MsgBoxStyle.OkOnly, "Store Information")
        Else
            CariBarang.TAMPILBARANG_SR()
            CariBarang.ShowDialog()
        End If


        'Call KONEKDB()
        'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & txtitemno.Text & "'", Konn)
        'DR = CMD.ExecuteReader
        'DR.Read()
        'If DR.HasRows Then
        '    lblstock.Text = DR.Item("jumlahbarang")
        '    txtqty.Focus()
        'Else
        '    MsgBox("Please Input Item", MsgBoxStyle.Information, "Information!!")
        'End If

    End Sub

    '======>MENYIMPAN KE DATAGRIDVIEW<=======
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Call KONEKDB()
        If txtitemno.Text = "" Then
            MsgBox("Please Input Item", MsgBoxStyle.Information, "Information!!")
        Else
            '========Validasi stock Barang======
            If Val(lblstock.Text) < Val(txtqty.Text) Then
                MsgBox("Stocked Goods Less", MsgBoxStyle.Critical, "")
            Else
                '======== Insert To DataGridview
                DGVSR.Rows.Add(New String() {txtitemno.Text, lblnamaitem.Text, lblunit.Text, txtqty.Text, lblprice.Text, FormatCurrency(lblprice.Text * Val(txtqty.Text)), txtremaks.Text})
                rumusSubtotal()
                rumusCariitem()
                lblstock.Text = ""
                txtitemno.Text = ""
                txtqty.Text = ""
                lblnamaitem.Text = "NAME ITEM"
                lblprice.Text = ""
                lblunit.Text = ""
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Call KONEKDB()
        If lbltotal.Text = "" Then
            MsgBox("Please Insert Item", MsgBoxStyle.Information, "Information!!")
        ElseIf txtlocation.Text = "" Then
            MsgBox("Please Input Location", MsgBoxStyle.Information, "Information!!")
        ElseIf department.Text = "-> Select Department" Then
            MsgBox("Please Input Department", MsgBoxStyle.Information, "Information!!")
        Else
            noOtomatis()
            Dim simpansr As String = "insert into tblsr values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & lblqty.Text & "','" & CDec(lbltotal.Text) & "','" & txtlocation.Text & "','" & lbluser.Text & "','" & Approved.Text & "','" & Acknowledged.Text & "','" & department.Text & "','" & txtremaks.Text & "')"
            CMD = New MySqlCommand(simpansr, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            '======== Insert To TBL SR Detail 
            For baris As Integer = 0 To DGVSR.Rows.Count - 2
                Dim simpanDetailsr As String = "insert into tblsrdetail values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & CDec(DGVSR.Rows(baris).Cells(4).Value) & "','" & CDec(DGVSR.Rows(baris).Cells(5).Value) & "','" & "" & "','" & "" & "','" & "" & "','" & "" & "')"
                CMD = New MySqlCommand(simpanDetailsr, Konn)
                CMD.ExecuteNonQuery()
            Next
            '======== Perintah Print
            'If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            '    KONDISIAWAL()
            'Else
            '    SRPRINT.Show()
            '    '======== Load Report
            '    SRPRINT.CRVSR.ReportSource = "printsr.rpt"
            '    SRPRINT.CRVSR.SelectionFormula = "{@NOMOR}='" & txtno.Text & "'"
            '    SRPRINT.CRVSR.RefreshReport()
            'End If
            KONDISIAWAL()
            Me.Close()
            SR_LIST.kondisiAwal()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Are You Sure to Delete this Item....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            If DGVSR.CurrentRow.Index <> DGVSR.NewRowIndex Then
                DGVSR.Rows.RemoveAt(DGVSR.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtlocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlocation.SelectedIndexChanged
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store = '" & txtlocation.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            idstorekeluar.Text = DR.Item(0)
        End If
    End Sub
End Class