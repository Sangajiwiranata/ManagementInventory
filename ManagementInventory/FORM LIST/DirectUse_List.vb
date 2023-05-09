Imports MySql.Data.MySqlClient
Public Class DirectUse_List
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        FormDirectUse.Show()
    End Sub
    Sub CARIITEM()
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tbl_directpurchase where nodirect Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub kondisiAwal()
        Label4.Text = ""
        DR.Close()
        DA = New MySqlDataAdapter("Select * from tbl_directpurchase", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        'DataGridView1.ColumnHeadersDefaultCellStyle.NullValue = True
        DataGridView1.ReadOnly = True
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(8).Width = 140
        DataGridView1.Columns(9).Width = 120
        DataGridView1.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-Receiving"
        DataGridView1.Columns(1).HeaderText = "Date"
        DataGridView1.Columns(2).HeaderText = "Supplier Name"
        DataGridView1.Columns(3).HeaderText = "Phone Number"
        DataGridView1.Columns(4).HeaderText = "Email"
        DataGridView1.Columns(5).HeaderText = "Qty"
        DataGridView1.Columns(6).HeaderText = "Amount"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "Rp   #,###,###,##"
        DataGridView1.Columns(7).HeaderText = "Created by"
        DataGridView1.Columns(8).HeaderText = "Approved by"
        DataGridView1.Columns(9).HeaderText = "Acknowledged by"
        DataGridView1.Columns(10).HeaderText = "Remarks"
        DataGridView1.Columns(11).HeaderText = "ID COA"
        DataGridView1.Columns(12).HeaderText = "Main COA"
        DataGridView1.Columns(13).HeaderText = "Sub Expenses"
    End Sub

    Private Sub DirectUse_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        TextBox1.Select()
        DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        DateTimePicker2.Value = Today
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CARIITEM()
    End Sub

    Private Sub Btn_Filter_Click(sender As Object, e As EventArgs) Handles Btn_Filter.Click
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tbl_directpurchase where daate between '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisiAwal()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If DirectPurchaseEdit.Label7.Text <> "" Then

            DirectPurchaseEdit.GroupBox2.Enabled = False
            DirectPurchaseEdit.CheckBox1.Checked = True
            DirectPurchaseEdit.CheckBox1.Visible = False
            'DirectPurchaseEdit.TextBox2.Visible = True
            'DirectPurchaseEdit.Label15.Visible = True
        Else
            DirectPurchaseEdit.CheckBox1.Enabled = True
            DirectPurchaseEdit.CheckBox1.Checked = False
        End If
        If DirectPurchaseEdit.Label8.Text <> "" Then
            DirectPurchaseEdit.CheckBox1.Visible = False
            DirectPurchaseEdit.CheckBox1.Checked = True
            DirectPurchaseEdit.CheckBox2.Visible = False
            DirectPurchaseEdit.CheckBox2.Checked = True

            DirectPurchaseEdit.btnsave.Enabled = False
            DirectPurchaseEdit.GroupBox2.Enabled = False

        Else
            DirectPurchaseEdit.CheckBox1.Enabled = True
            DirectPurchaseEdit.CheckBox1.Checked = False
            DirectPurchaseEdit.CheckBox2.Enabled = True
            DirectPurchaseEdit.CheckBox2.Checked = False
        End If
        DirectPurchaseEdit.Show()
        DirectPurchaseEdit.Label7.Text = DataGridView1.Rows(i).Cells(8).Value.ToString
        DirectPurchaseEdit.Label8.Text = DataGridView1.Rows(i).Cells(9).Value.ToString
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            DirectPurchaseEdit.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            DirectPurchaseEdit.dateneed.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            DirectPurchaseEdit.txtsuplier.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            DirectPurchaseEdit.lbltlpsuplier.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            DirectPurchaseEdit.lbluser.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            DirectPurchaseEdit.lblemailsuplier.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            DirectPurchaseEdit.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            DirectPurchaseEdit.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
            DirectPurchaseEdit.idcoa.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
            DirectPurchaseEdit.maincoa.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
            DirectPurchaseEdit.coaexpenses.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            PRINT_PO.Show()
            PRINT_PO.ReportPOBaru.ReportSource = "DirectPurchase.rpt"
            PRINT_PO.ReportPOBaru.SelectionFormula = "{@no}='" & Label4.Text & "'"
            PRINT_PO.ReportPOBaru.RefreshReport()
        End If
    End Sub
End Class