Imports MySql.Data.MySqlClient
Public Class FormTransfer
    Sub noOtomatis2()
        CMD = New MySqlCommand("select * from tblbarang where no in(select max(no) from tblbarang)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR.Close()
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "1"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 1) + 1
            urutanKode = Microsoft.VisualBasic.Right(hitung, 1)
        End If
        Label11.Text = urutanKode
    End Sub
    Sub rumusSubtotal()
        Dim hitung As Integer = 0
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
    Sub KONDISIAWAL()
        noOtomatis2()
        'noOtomatis2()
        Approved.Text = ""
        Approved.Visible = False
        Acknowledged.Text = ""
        Acknowledged.Visible = False
        lblnamaitem.Text = ""

        lbluser.Text = Form1MenuUtama.StatusUser.Text
        txtremaks.Text = ""
        txtlocation.Text = ""
        ANOTHERSTORE.Text = ""
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
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tbl_trf where notrf in(select max(notrf) from tbl_trf)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "TRF" + Format(Now, "ddMMyy") + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            urutanKode = "TRF" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtno.Text = urutanKode
    End Sub
    Sub comboboxstore()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            txtlocation.Items.Add(DR.Item(1))
            ANOTHERSTORE.Items.Add(DR.Item(1))
        Loop
    End Sub
    Private Sub FormTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboboxstore()
        KONDISIAWAL()
        'noOtomatis()
    End Sub

    Private Sub txtitemno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemno.MouseClick
        If idstorekeluar.Text = "" Then
            MsgBox("Please Input Store", MsgBoxStyle.Critical, "Information!!")
        Else
            CariBarang.TAMPILBARANG_Transfer()
            CariBarang.ShowDialog()
            txtqty.Select()
        End If
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Call KONEKDB()
        If txtitemno.Text = "" Then
            MsgBox("Please Input Item")
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Are You Sure to Delete this Item....?", "Warning!!", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            If DGVSR.CurrentRow.Index <> DGVSR.NewRowIndex Then
                DGVSR.Rows.RemoveAt(DGVSR.CurrentRow.Index)
            End If
        End If
        rumusSubtotal()
        rumusCariitem()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Call KONEKDB()
        If lbltotal.Text = "" Then
            MsgBox("Please Insert Item")
        ElseIf txtlocation.Text = "" Then
            MsgBox("Please enter warehouse")
        ElseIf ANOTHERSTORE.Text = "" Then
            MsgBox("Please enter the destination warehouse")
        Else

            noOtomatis()
            Dim simpansr As String = "insert into tbl_trf values('" & txtno.Text &
                "','" & Format(daterex.Value, "yyyy-MM-dd") &
                "','" & idstoremasuk.Text & "','" & ANOTHERSTORE.Text &
                "','" & idstorekeluar.Text & "','" & txtlocation.Text &
                "','" & lblqty.Text & "','" & lbluser.Text &
                "','" & Approved.Text & "','" & Acknowledged.Text & "','" & txtremaks.Text & "')"
            CMD = New MySqlCommand(simpansr, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()

            '======== Insert To TBL Transfer Detail 
            For baris As Integer = 0 To DGVSR.Rows.Count - 2
                DR.Close()
                Dim simpanDetailsr As String = "insert into tbl_trfdetail values('" & txtno.Text & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & idstoremasuk.Text & "','" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & CDec(DGVSR.Rows(baris).Cells(4).Value) & "','" & CDec(DGVSR.Rows(baris).Cells(5).Value) & "')"
                CMD = New MySqlCommand(simpanDetailsr, Konn)
                CMD.ExecuteNonQuery()
                DR.Close()

                'Dim transaksibarangMasuk As String = "insert into tbl_transaksibarang values('" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & "0" & "','" & idstoremasuk.Text & "')"
                'CMD = New MySqlCommand(transaksibarangMasuk, Konn)
                'CMD.ExecuteNonQuery()

                'Dim transaksibarangKeluar As String = "insert into tbl_transaksibarang values('" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "','" & "0" & "','" & DGVSR.Rows(baris).Cells(3).Value & "','" & idstorekeluar.Text & "')"
                'CMD = New MySqlCommand(transaksibarangKeluar, Konn)
                'CMD.ExecuteNonQuery()

                ''======Select TBL Barang
                'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "'and id_store='" & idstoremasuk.Text & "'", Konn)
                'DR = CMD.ExecuteReader
                'DR.Read()
                'If Not DR.HasRows Then
                '    Dim inputData As String = "Insert into tblbarang values('" & Label11.Text & "','" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(2).Value & "', '" & DGVSR.Rows(baris).Cells(3).Value & "', '" & DGVSR.Rows(baris).Cells(4).Value & "', '" & DGVSR.Rows(baris).Cells(5).Value & "', '" & "" & "','" & idstoremasuk.Text & "', '" & "" & "', '" & "" & "')"
                '    DR.Close()
                '    CMD = New MySqlCommand(inputData, Konn)
                '    CMD.ExecuteNonQuery()

                '    CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "'and id_store='" & idstorekeluar.Text & "'", Konn)
                '    DR = CMD.ExecuteReader
                '    DR.Read()
                '    Dim kurangistock As String = "update tblbarang set jumlahbarang ='" & DR.Item("jumlahbarang") - DGVSR.Rows(baris).Cells(3).Value & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstorekeluar.Text & "'"
                '    CMD = New MySqlCommand(kurangistock, Konn)
                '    DR.Close()
                '    CMD.ExecuteNonQuery()
                'Else
                '    '=======>mengurangi Stock Gudang
                '    Dim tambahstock As String = "update tblbarang set jumlahbarang ='" & DR.Item("jumlahbarang") + DGVSR.Rows(baris).Cells(3).Value & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstoremasuk.Text & "'"
                '    CMD = New MySqlCommand(tambahstock, Konn)
                '    DR.Close()
                '    CMD.ExecuteNonQuery()

                '    CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstoremasuk.Text & "'", Konn)
                '    DR = CMD.ExecuteReader
                '    DR.Read()
                '    Dim EDITtotal As String = "update tblbarang set totalharga ='" & DR.Item("jumlahbarang") * CDec(DR.Item("hargabarang")) & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstoremasuk.Text & "'"
                '    CMD = New MySqlCommand(EDITtotal, Konn)
                '    DR.Close()
                '    CMD.ExecuteNonQuery()

                '    CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "'and id_store='" & "1" & "'", Konn)
                '    DR = CMD.ExecuteReader
                '    DR.Read()

                '    Dim baranggudang As Integer = DR.Item("jumlahbarang")
                '    Dim kurangistock As String = "update tblbarang set jumlahbarang ='" & baranggudang - Val(DGVSR.Rows(baris).Cells(3).Value) & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstorekeluar.Text & "'"
                '    CMD = New MySqlCommand(kurangistock, Konn)
                '    DR.Close()
                '    CMD.ExecuteNonQuery()
                'End If

                '======Select TBL Barang


                'Dim EDITHARGA As String = "update tblbarang set hargabarang ='" & CDec(DGVSR.Rows(baris).Cells(4).Value) & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstoremasuk.Text & "'"
                'CMD = New MySqlCommand(EDITHARGA, Konn)
                'DR.Close()
                'CMD.ExecuteNonQuery()


                'CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstorekeluar.Text & "'", Konn)
                'DR = CMD.ExecuteReader
                'DR.Read()
                'Dim EDITtotal2 As String = "update tblbarang set totalharga ='" & DR.Item("jumlahbarang") * DR.Item("hargabarang") & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "' and id_store='" & idstorekeluar.Text & "'"
                'CMD = New MySqlCommand(EDITtotal2, Konn)
                'DR.Close()
                'CMD.ExecuteNonQuery()
            Next
            ''======== Perintah Print
            'If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            '    KONDISIAWAL()
            'Else
            '    SRPRINT.Show()
            '    '======== Load Report
            '    SRPRINT.CRVSR.ReportSource = "printsr.rpt"
            '    SRPRINT.CRVSR.SelectionFormula = "{@NOMOR}='" & txtno.Text & "'"
            '    SRPRINT.CRVSR.RefreshReport()
            'End If
            Me.Close()
            TRF_LIST.kondisiAwal()
        End If
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

    Private Sub ANOTHERSTORE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ANOTHERSTORE.SelectedIndexChanged
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tblgudang where nama_store = '" & ANOTHERSTORE.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            idstoremasuk.Text = DR.Item(0)
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class