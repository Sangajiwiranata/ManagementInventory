Imports MySql.Data.MySqlClient
Public Class POLIST
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblpo where nopo Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub kondisiAwal()
        DR.Close()
        Label4.Text = ""
        DA = New MySqlDataAdapter("Select * from tblpo order by nopo desc", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnHeadersDefaultCellStyle.NullValue = True
        DataGridView1.ReadOnly = True
        'DataGridView1.Columns(4).Width = 30
        DataGridView1.Columns(5).Width = 250
        DataGridView1.Columns(7).Width = 180
        DataGridView1.Columns(8).Width = 300
        DataGridView1.Columns(9).Width = 50
        DataGridView1.Columns(10).Width = 150
        DataGridView1.Columns(11).Width = 150
        DataGridView1.Columns(12).Width = 150
        DataGridView1.Columns(13).Width = 150
        DataGridView1.Columns(14).Width = 300
        DataGridView1.ColumnHeadersHeight = 100


        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-PO"
        DataGridView1.Columns(1).HeaderText = "No-PR"
        DataGridView1.Columns(2).HeaderText = "Issue-Date"
        DataGridView1.Columns(3).HeaderText = "Delivery-Date"
        DataGridView1.Columns(4).HeaderText = "TOP"
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).HeaderText = "Supplier Name"
        DataGridView1.Columns(6).HeaderText = "Phone Number"
        DataGridView1.Columns(7).HeaderText = "Email"
        DataGridView1.Columns(8).HeaderText = "Address"
        DataGridView1.Columns(9).HeaderText = "Total Qty"
        DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(10).DefaultCellStyle.Format = "#,###,##"
        DataGridView1.Columns(10).HeaderText = "Total Amount"
        DataGridView1.Columns(11).HeaderText = "Created by"
        DataGridView1.Columns(12).HeaderText = "Approved by"
        DataGridView1.Columns(13).HeaderText = "Acknowledged by"
        DataGridView1.Columns(14).HeaderText = "Remarks"
        'DataGridView1.Columns(15).HeaderText = "Currency"
        DataGridView1.Columns(15).HeaderText = "Delivery to"
        DataGridView1.Columns(16).HeaderText = "Status"
    End Sub

    Private Sub PRLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        TextBox1.Select()
        DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, Now.Month, 1)
        DateTimePicker2.Value = Today
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        FormPO.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub Btnedit_Click(sender As Object, ByVal e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If PO_EDIT.Label7.Text <> "" Then

            PO_EDIT.GroupBox2.Enabled = False
            PO_EDIT.CheckBox1.Checked = True
            PO_EDIT.CheckBox1.Visible = False
        Else
            PO_EDIT.CheckBox1.Enabled = True
            PO_EDIT.CheckBox1.Checked = False
        End If
        If PO_EDIT.Label8.Text <> "" Then
            PO_EDIT.CheckBox1.Visible = False
            PO_EDIT.CheckBox1.Checked = True
            PO_EDIT.CheckBox2.Visible = False
            PO_EDIT.CheckBox2.Checked = True
            PO_EDIT.btnsave.Enabled = False
            PO_EDIT.GroupBox2.Enabled = False
        Else
            PO_EDIT.CheckBox1.Enabled = True
            PO_EDIT.CheckBox1.Checked = False
            PO_EDIT.CheckBox2.Enabled = True
            PO_EDIT.CheckBox2.Checked = False
        End If
        PO_EDIT.Show()
        PO_EDIT.credit.Text = DataGridView1.Rows(i).Cells(4).Value
        PO_EDIT.Label7.Text = "Approved by : " + DataGridView1.Rows(i).Cells(12).Value
        PO_EDIT.Label8.Text = "Acknowledged by : " + DataGridView1.Rows(i).Cells(13).Value
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            PRINT_PO.Show()
            PRINT_PO.ReportPOBaru.ReportSource = "printpo.rpt"
            PRINT_PO.ReportPOBaru.SelectionFormula = "{@nopo}='" & Label4.Text & "'"
            PRINT_PO.ReportPOBaru.RefreshReport()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            PO_EDIT.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            PO_EDIT.txtnopr.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            PO_EDIT.daterex.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            PO_EDIT.nedeed.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            PO_EDIT.lbluser.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
            PO_EDIT.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
            PO_EDIT.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString
            PO_EDIT.Delto.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value
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
        DA = New MySqlDataAdapter("Select * from tblpo where issudate between'" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
End Class