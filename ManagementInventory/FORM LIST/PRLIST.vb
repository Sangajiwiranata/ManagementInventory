Imports MySql.Data.MySqlClient
Public Class PRLIST
    Sub comboboxdept()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_dept", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboDept.Items.Add(DR.Item(1))
        Loop
    End Sub
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblpr where nopr Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub
    Sub kondisiAwal()
        Label4.Text = ""
        DR.Close()
        DA = New MySqlDataAdapter("Select * from tblpr order by nopr desc", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 90
        DataGridView1.Columns(2).Width = 90
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 180
        DataGridView1.Columns(5).Width = 180
        DataGridView1.Columns(6).Width = 180
        DataGridView1.Columns(7).Width = 180
        DataGridView1.Columns(8).Width = 340
        DataGridView1.Columns(9).Width = 600
        DataGridView1.Columns(10).Width = 60
        'DataGridView1.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersHeight = 50
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-PR"
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderText = "Issue-Date"
        DataGridView1.Columns(2).HeaderText = "Need-Date"
        DataGridView1.Columns(3).HeaderText = "Total Qty"
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderText = "Total Amount"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
        DataGridView1.Columns(5).HeaderText = "Created by"
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).HeaderText = "Approved by"
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(7).HeaderText = "Acknowledged by"
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(8).HeaderText = "Department"
        DataGridView1.Columns(9).HeaderText = "Remakrs"
        DataGridView1.Columns(10).HeaderText = "Balance"
        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Sub rumusSubtotal()
        Dim hitung As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            txtGrandTotal.Text = Format(hitung, "#,###.00")
        Next
    End Sub

    Sub rumusCariitem()
        Dim hitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungItem = hitungItem + DataGridView1.Rows(i).Cells(3).Value
            txtQtytotal.Text = hitungItem
        Next
    End Sub

    Private Sub PRLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        comboboxdept()
        rumusSubtotal()
        rumusCariitem()
        'DataGridView1.Rows(0).Selected = False
        DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, Now.Month, 1)
        DateTimePicker2.Value = Today
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        FormPR.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If PREDIT.Label7.Text <> "" Then

            PREDIT.GroupBox2.Enabled = False
            PREDIT.CheckBox1.Checked = True
            PREDIT.CheckBox1.Visible = False
            'PREDIT.TextBox2.Visible = True
            'PREDIT.Label15.Visible = True
        Else
            PREDIT.CheckBox1.Enabled = True
            PREDIT.CheckBox1.Checked = False
        End If
        If PREDIT.Label8.Text <> "" Then
            PREDIT.CheckBox1.Visible = False
            PREDIT.CheckBox1.Checked = True
            PREDIT.CheckBox2.Visible = False
            PREDIT.CheckBox2.Checked = True

            PREDIT.btnsave.Enabled = False
            PREDIT.GroupBox2.Enabled = False

        Else
            PREDIT.CheckBox1.Enabled = True
            PREDIT.CheckBox1.Checked = False
            PREDIT.CheckBox2.Enabled = True
            PREDIT.CheckBox2.Checked = False
        End If
        PREDIT.Show()
        PREDIT.Label7.Text = DataGridView1.Rows(i).Cells(6).Value
        PREDIT.Label8.Text = DataGridView1.Rows(i).Cells(7).Value
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            PRINT_PR.Show()
            PRINT_PR.ReportPR.ReportSource = "printpr.rpt"
            PRINT_PR.ReportPR.SelectionFormula = "{@nopr}='" & Label4.Text & "'"
            PRINT_PR.ReportPR.RefreshReport()
        End If
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            PREDIT.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            PREDIT.ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
            PREDIT.daterex.Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            PREDIT.dateneed.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            PREDIT.lbluser.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            PREDIT.ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            PREDIT.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            PREDIT.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisiAwal()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub Btn_Filter_Click(sender As Object, e As EventArgs) Handles Btn_Filter.Click
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblpr where issudate between '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub ComboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDept.SelectedIndexChanged
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblpr where dept ='" & ComboDept.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
End Class