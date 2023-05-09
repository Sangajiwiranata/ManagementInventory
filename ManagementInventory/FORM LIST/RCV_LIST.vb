Imports MySql.Data.MySqlClient
Public Class RCV_LIST
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblreceiving where norcv Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub kondisiAwal()
        Label4.Text = ""
        DR.Close()
        DA = New MySqlDataAdapter("Select * from tblreceiving", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        'DataGridView1.ColumnHeadersDefaultCellStyle.NullValue = True
        DataGridView1.ReadOnly = True
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 120
        DataGridView1.Columns(4).Width = 450
        DataGridView1.Columns(5).Width = 150
        DataGridView1.Columns(6).Width = 200
        DataGridView1.Columns(7).Width = 50
        DataGridView1.Columns(8).Width = 150
        DataGridView1.Columns(10).Width = 140
        DataGridView1.Columns(11).Width = 120
        DataGridView1.Columns(12).Width = 550
        DataGridView1.Columns(13).Width = 140
        DataGridView1.Columns(14).Width = 140
        DataGridView1.Columns(15).Width = 140
        'DataGridView1.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-Receiving"
        DataGridView1.Columns(1).HeaderText = "No-PO"
        DataGridView1.Columns(2).HeaderText = "Date"
        DataGridView1.Columns(3).HeaderText = "TOP"
        DataGridView1.Columns(4).HeaderText = "Supplier Name"
        DataGridView1.Columns(5).HeaderText = "Phone Number"
        DataGridView1.Columns(6).HeaderText = "Email"
        DataGridView1.Columns(7).HeaderText = "Qty"
        DataGridView1.Columns(8).HeaderText = "Amount"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "#,###,###,##"
        DataGridView1.Columns(9).HeaderText = "Created by"
        DataGridView1.Columns(10).HeaderText = "Approved by"
        DataGridView1.Columns(11).HeaderText = "Acknowledged by"
        DataGridView1.Columns(12).HeaderText = "Remarks"
        DataGridView1.Columns(13).HeaderText = "ID COA"
        DataGridView1.Columns(14).HeaderText = "Main Coa"
        DataGridView1.Columns(15).HeaderText = "Sub Expenses"


    End Sub


    Private Sub PRLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        TextBox1.Select()
        DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        DateTimePicker2.Value = Today
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Formreceiving.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub Btnedit_Click(sender As Object, ByVal e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If RCV_EDIT.Label7.Text <> "" Then

            RCV_EDIT.CheckBox1.Checked = True
            RCV_EDIT.CheckBox1.Visible = False
        Else
            RCV_EDIT.CheckBox1.Enabled = True
            RCV_EDIT.CheckBox1.Checked = False

        End If
        If RCV_EDIT.Label8.Text <> "" Then
            RCV_EDIT.CheckBox1.Visible = False
            RCV_EDIT.CheckBox1.Checked = True
            RCV_EDIT.CheckBox2.Visible = False
            RCV_EDIT.CheckBox2.Checked = True
            RCV_EDIT.GroupBox3.Enabled = False
            RCV_EDIT.GroupBox4.Enabled = False
            RCV_EDIT.btnsave.Visible = True
        Else
            RCV_EDIT.CheckBox1.Enabled = True
            RCV_EDIT.CheckBox1.Checked = False
            RCV_EDIT.CheckBox2.Enabled = True
            RCV_EDIT.CheckBox2.Checked = False

        End If
        RCV_EDIT.Show()
        RCV_EDIT.Label7.Text = DataGridView1.Rows(i).Cells(10).Value
        RCV_EDIT.Label8.Text = DataGridView1.Rows(i).Cells(11).Value
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            PRINT_PO.Show()
            PRINT_PO.ReportPOBaru.ReportSource = "printRcv.rpt"
            PRINT_PO.ReportPOBaru.SelectionFormula = "{@norcv}='" & Label4.Text & "'"
            PRINT_PO.ReportPOBaru.RefreshReport()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            RCV_EDIT.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            RCV_EDIT.txtnopo.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            RCV_EDIT.DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            RCV_EDIT.DateTimePicker2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            RCV_EDIT.TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            RCV_EDIT.lbluser.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
            RCV_EDIT.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
            RCV_EDIT.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
            RCV_EDIT.idcoa.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
            RCV_EDIT.maincoa.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value
            RCV_EDIT.coaexpenses.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisiAwal()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub Btn_Filter_Click(sender As Object, e As EventArgs) Handles Btn_Filter.Click
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblreceiving where daate between '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
End Class