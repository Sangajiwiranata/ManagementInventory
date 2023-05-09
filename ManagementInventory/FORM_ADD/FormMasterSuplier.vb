Imports MySql.Data.MySqlClient
Public Class FormMasterSuplier
    Sub Buatkolom()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tbLsuplier", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))

        DataGridView1.RowHeadersVisible = False
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(4).Width = 300

        DataGridView1.Columns(0).HeaderText = "Id Supplier"
        DataGridView1.Columns(1).HeaderText = "Name Supplier"
        DataGridView1.Columns(2).HeaderText = "Phone Number"
        DataGridView1.Columns(3).HeaderText = "Email"
        DataGridView1.Columns(4).HeaderText = "Address"
        DataGridView1.Columns(5).HeaderText = "Type"
    End Sub
    Sub AKTIFKAN()
        namasuplier.Enabled = True
        tlpn.Enabled = True
        email.Enabled = True
        alamat.Enabled = True
        type.Enabled = True
    End Sub
    Sub KONDISIAWAL()
        Call KONEKDB()
        INPUT.Text = "ADD"
        TUTUP.Text = "CLOSE"
        idsuplier.Text = ""
        namasuplier.Text = ""
        tlpn.Text = ""
        email.Text = ""
        alamat.Text = ""
        type.Text = ""

        idsuplier.Enabled = False
        namasuplier.Enabled = False
        tlpn.Enabled = False
        email.Enabled = False
        alamat.Enabled = False
        type.Enabled = False
        Buatkolom()
        noOtomatis()
    End Sub
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tblsuplier where idsuplier in(select max(idsuplier) from tblsuplier)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "V" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            urutanKode = "V" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        idsuplier.Text = urutanKode
    End Sub
    Private Sub FormMasterSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
    End Sub

    Private Sub INPUT_Click(sender As Object, e As EventArgs) Handles INPUT.Click
        If INPUT.Text = "ADD" Then
            INPUT.Text = "SAVE"
            AKTIFKAN()
            TUTUP.Text = "CANCEL"
        Else
            If idsuplier.Text = "" Or namasuplier.Text = "" Or tlpn.Text = "" Or email.Text = "" Or alamat.Text = "" Or type.Text = "" Then
                MsgBox("Please fill all section", MsgBoxStyle.Information, "Information!!")
            Else
                Call KONEKDB()
                Dim inputData As String = "Insert into tblsuplier values('" & idsuplier.Text & "','" & namasuplier.Text & "','" & tlpn.Text & "', '" & email.Text & "', '" & alamat.Text & "', '" & type.Text & "')"
                CMD = New MySqlCommand(inputData, Konn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Berhasil", MsgBoxStyle.Information, "Information!!")
                Call KONDISIAWAL()
            End If
        End If
    End Sub

    Private Sub CLOSE_Click(sender As Object, e As EventArgs) Handles TUTUP.Click
        If TUTUP.Text = "CANCEL" Then
            KONDISIAWAL()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub tlpn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tlpn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) Then
            ReportSupplier.Show()
            ReportSupplier.supplierlistpr.ReportSource = "SupplierList.rpt"
            ReportSupplier.supplierlistpr.Refresh()
        Else
            KONDISIAWAL()
        End If
    End Sub
End Class