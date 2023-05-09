Imports MySql.Data.MySqlClient
Public Class ReleaseSR
    Sub Tampilkan()
        CMD = New MySqlCommand("select reqdate, location, user, dept from tblsr where nosr='" & txtno.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            daterex.Value = DR.Item(0)
            txtlocation.Text = DR.Item(1)
            lbluser.Text = DR.Item(2)
            department.Text = DR.Item(3)
        End If
    End Sub
    Sub rumusSubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DGVSR.Rows.Count - 1
            hitung = hitung + DGVSR.Rows(i).Cells(5).Value
            lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
        Next
    End Sub
    Sub comboboxExpenses()
        KONEKDB()
        DA = New MySqlDataAdapter("Select nama_perkiraan from tblperkiraan where kelompok_akun ='" & "Amortization & Depreciation" & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)

        Dim cbxDebet As New DataGridViewComboBoxColumn()
        cbxDebet.DataSource = DS.Tables(0)
        cbxDebet.DisplayMember = "nama_perkiraan"
        DGVSR.Columns.Add(cbxDebet)
        cbxDebet.HeaderText = "Alocation"
        cbxDebet.Width = 150
    End Sub
    Sub comboboxalocation()
        KONEKDB()
        DA = New MySqlDataAdapter("Select nama_perkiraan from tblperkiraan where kelompok_akun ='" & "Inventory" & "'", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)

        Dim cbxCredit As New DataGridViewComboBoxColumn()
        cbxCredit.DataSource = DS.Tables(0)
        cbxCredit.DisplayMember = "nama_perkiraan"
        DGVSR.Columns.Add(cbxCredit)
        cbxCredit.HeaderText = "Expenses"
        cbxCredit.Width = 150
    End Sub
    Sub isiform()
        KONEKDB()

        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblsrdetail Where nosr='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVSR.DataSource = (DS.Tables(0))
        'DGVSR.ReadOnly = 

        DGVSR.RowHeadersVisible = False
        DGVSR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSR.Columns(0).Width = 120
        DGVSR.Columns(1).Width = 400
        DGVSR.Columns(3).Width = 100

        DGVSR.Columns(0).HeaderText = "No Item"
        DGVSR.Columns(1).HeaderText = "Description"
        DGVSR.Columns(2).HeaderText = "Unit"
        DGVSR.Columns(3).HeaderText = "OnHand"
        DGVSR.Columns(4).HeaderText = "Price"
        DGVSR.Columns(5).HeaderText = "Amount"
        DGVSR.Columns.Add("Expenses", "ID Expenses")
        comboboxalocation()
        DGVSR.Columns.Add("Alocation", "ID Alocation")
        comboboxExpenses()

    End Sub
    Private Sub ReleaseSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daterex.Enabled = False
        department.Enabled = False
        txtlocation.Enabled = False
        lbluser.Text = ""
    End Sub

    Private Sub txtno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtno.MouseClick
        CariNoSR.ShowDialog()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub DGVSR_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSR.CellEndEdit
        DR.Close()
        CMD = New MySqlCommand("select kode_perkiraan from tblperkiraan where nama_perkiraan='" & DGVSR.Rows(e.RowIndex).Cells(7).Value & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DGVSR.Rows(e.RowIndex).Cells(6).Value = DR.Item(0)
        End If

        DR.Close()
        CMD = New MySqlCommand("select kode_perkiraan from tblperkiraan where nama_perkiraan='" & DGVSR.Rows(e.RowIndex).Cells(9).Value & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DGVSR.Rows(e.RowIndex).Cells(8).Value = DR.Item(0)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        '======== Insert to Jurnal =========
        DR.Close()
        For baris As Integer = 0 To DGVSR.Rows.Count - 2
            Dim SimpanDebet As String = "insert into tbljurnal values('" & "1" & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(6).Value & "','" & DGVSR.Rows(baris).Cells(7).Value & "','" & DGVSR.Rows(baris).Cells(5).Value & "','" & "0" & "' )"
            CMD = New MySqlCommand(SimpanDebet, Konn)
            CMD.ExecuteNonQuery()

            Dim simpatCredit As String = "insert into tbljurnal values('" & "2" & "','" & Format(daterex.Value, "yyyy-MM-dd") & "','" & DGVSR.Rows(baris).Cells(0).Value & "','" & DGVSR.Rows(baris).Cells(1).Value & "','" & DGVSR.Rows(baris).Cells(8).Value & "','" & DGVSR.Rows(baris).Cells(9).Value & "','" & "0" & "','" & DGVSR.Rows(baris).Cells(5).Value & "' )"
            CMD = New MySqlCommand(simpatCredit, Konn)
            CMD.ExecuteNonQuery()


            '======Select TBL Barang
            CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()

            '=======>mengurangi Stock Gudang
            Dim kurangiStock As String = "update tblbarang set jumlahbarang ='" & DR.Item("jumlahbarang") - DGVSR.Rows(baris).Cells(3).Value & "' where idbarang='" & DGVSR.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(kurangiStock, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        Next
        MsgBox("Release Successfull!!", MsgBoxStyle.Information, "Information!!")
        Me.Close()
    End Sub
End Class