Imports MySql.Data.MySqlClient
Public Class SR_LIST
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
        DA = New MySqlDataAdapter("Select * from tblsr where nosr Like'%" & TextBox1.Text & "%'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
    Sub kondisiAwal()
        Label4.Text = ""
        DR.Close()
        DA = New MySqlDataAdapter("Select * from tblsr", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnHeadersDefaultCellStyle.NullValue = True
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(5).Width = 160
        DataGridView1.Columns(6).Width = 160
        DataGridView1.Columns(7).Width = 160
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersHeight = 50


        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-SR"
        DataGridView1.Columns(1).HeaderText = "Date"
        DataGridView1.Columns(2).HeaderText = "Qty"
        DataGridView1.Columns(3).HeaderText = "Amount"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "Rp,  ###,###,###.##"
        DataGridView1.Columns(4).HeaderText = "Store"
        DataGridView1.Columns(5).HeaderText = "Created by"
        DataGridView1.Columns(6).HeaderText = "Approved by"
        DataGridView1.Columns(7).HeaderText = "Acknowledged by"
        DataGridView1.Columns(8).HeaderText = "Deparment"
        DataGridView1.Columns(9).HeaderText = "Remarks"


    End Sub


    Private Sub PRLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        comboboxdept()
        TextBox1.Select()
        DateTimePicker1.Value = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        DateTimePicker2.Value = Today
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        FormSR.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub Btnedit_Click(sender As Object, ByVal e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If SR_EDIT.Label7.Text <> "" Then

            SR_EDIT.CheckBox1.Checked = True
            SR_EDIT.CheckBox1.Visible = False
        Else
            SR_EDIT.CheckBox1.Enabled = True
            SR_EDIT.CheckBox1.Checked = False

        End If
        If SR_EDIT.Label8.Text <> "" Then
            SR_EDIT.CheckBox1.Visible = False
            SR_EDIT.CheckBox1.Checked = True
            SR_EDIT.CheckBox2.Visible = False
            SR_EDIT.CheckBox2.Checked = True

            SR_EDIT.btnsave.Visible = False


        Else
            SR_EDIT.CheckBox1.Enabled = True
            SR_EDIT.CheckBox1.Checked = False
            SR_EDIT.CheckBox2.Enabled = True
            SR_EDIT.CheckBox2.Checked = False

        End If
        SR_EDIT.Show()
        SR_EDIT.Label7.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        SR_EDIT.Label8.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If MessageBox.Show("Do you want to Print this file....?", "", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            SRPRINT.Show()
            SRPRINT.CRVSR.ReportSource = "printsr.rpt"
            SRPRINT.CRVSR.SelectionFormula = "{@NOMOR}='" & Label4.Text & "'"
            SRPRINT.CRVSR.Refresh()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            SR_EDIT.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            SR_EDIT.daterex.Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            SR_EDIT.txtlocation.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            SR_EDIT.lbluser.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            SR_EDIT.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            SR_EDIT.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            SR_EDIT.department.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
            SR_EDIT.lblqty.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
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
        DA = New MySqlDataAdapter("Select * from tblsr where reqdate between '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub ComboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDept.SelectedIndexChanged
        Call KONEKDB()
        DA = New MySqlDataAdapter("Select * from tblsr where dept ='" & ComboDept.Text & "'", Konn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub
End Class