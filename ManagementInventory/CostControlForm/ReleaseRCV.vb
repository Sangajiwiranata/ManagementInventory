Imports MySql.Data.MySqlClient
Public Class ReleaseRCV
    Sub Tampilkan()
        CMD = New MySqlCommand("select nopo, daate, user from tblreceiving where norcv='" & txtno.Text & "'", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DateTimePicker1.Value = DR.Item(1)
            txtnopo.Text = DR.Item(0)
            lbluser.Text = DR.Item(2)
        End If
    End Sub

    Sub rumusSubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DGVRCV.Rows.Count - 1
            hitung = hitung + DGVRCV.Rows(i).Cells(5).Value
            lbltotal.Text = FormatCurrency(hitung, NumDigitsAfterDecimal:=2)
        Next
    End Sub

    Sub isiform()
        KONEKDB()

        DA = New MySqlDataAdapter("Select noitem, description, unit, qty, price, amount from tblreceivingdetail Where norcv='" & txtno.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DGVRCV.DataSource = (DS.Tables(0))
        'DGVRCV.ReadOnly = 

        DGVRCV.RowHeadersVisible = False
        DGVRCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVRCV.Columns(0).Width = 120
        DGVRCV.Columns(1).Width = 400
        DGVRCV.Columns(3).Width = 100

        DGVRCV.Columns(0).HeaderText = "No Item"
        DGVRCV.Columns(1).HeaderText = "Description"
        DGVRCV.Columns(2).HeaderText = "Unit"
        DGVRCV.Columns(3).HeaderText = "OnHand"
        DGVRCV.Columns(4).HeaderText = "Price"
        DGVRCV.Columns(5).HeaderText = "Amount"
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtno_MouseClick(sender As Object, e As MouseEventArgs) Handles txtno.MouseClick
        norcv.Show()
    End Sub

    Private Sub ReleaseRCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnopo.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        For baris As Integer = 0 To DGVRCV.Rows.Count - 2
            '======Select TBL Barang
            CMD = New MySqlCommand("select * from tblbarang where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'", Konn)
            DR = CMD.ExecuteReader
            DR.Read()

            '=======>mengurangi Stock Gudang
            Dim kurangiStock As String = "update tblbarang set jumlahbarang ='" & DR.Item("jumlahbarang") + DGVRCV.Rows(baris).Cells(3).Value & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(kurangiStock, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()


            Dim EDITHARGA As String = "update tblbarang set hargabarang ='" & DGVRCV.Rows(baris).Cells(4).Value & "' where idbarang='" & DGVRCV.Rows(baris).Cells(0).Value & "'"
            CMD = New MySqlCommand(EDITHARGA, Konn)
            DR.Close()
            CMD.ExecuteNonQuery()
        Next
        MsgBox("Successfull", MsgBoxStyle.Information, "Information!!")
    End Sub
End Class