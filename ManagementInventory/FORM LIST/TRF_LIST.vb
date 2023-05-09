Imports MySql.Data.MySqlClient
Public Class TRF_LIST
    Sub kondisiAwal()
        Label4.Text = ""
        DR.Close()
        DA = New MySqlDataAdapter("Select * from tbl_trf", Konn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbLsuplier")
        DataGridView1.DataSource = (DS.Tables("tbLsuplier"))
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnHeadersDefaultCellStyle.NullValue = True
        'DataGridView1.ReadOnly = True
        'DataGridView1.Columns(1).Width = 60
        DataGridView1.Columns(2).Width = 40
        DataGridView1.Columns(3).Width = 160
        DataGridView1.Columns(4).Width = 40
        DataGridView1.Columns(5).Width = 160
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 150
        DataGridView1.Columns(8).Width = 150
        DataGridView1.Columns(9).Width = 150
        DataGridView1.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.ColumnHeadersHeight = 50


        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Columns(0).HeaderText = "No-Trf"
        DataGridView1.Columns(1).HeaderText = "Date"
        DataGridView1.Columns(2).HeaderText = "ID Store In"
        DataGridView1.Columns(3).HeaderText = "Store In"
        DataGridView1.Columns(4).HeaderText = "ID Store Out"
        DataGridView1.Columns(5).HeaderText = "Store Out"
        DataGridView1.Columns(6).HeaderText = "Qty"
        DataGridView1.Columns(7).HeaderText = "Created by"
        DataGridView1.Columns(8).HeaderText = "Approved by"
        DataGridView1.Columns(9).HeaderText = "Acknowledged by"
        DataGridView1.Columns(10).HeaderText = "Remarks"



    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Form1MenuUtama.MenuStrip1.Visible = True
        Form1MenuUtama.iconbutton.Visible = True
    End Sub

    Private Sub TRF_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        FormTransfer.Show()
    End Sub



    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex

        If TRF_EDIT.Label7.Text <> "" Then

            TRF_EDIT.CheckBox1.Checked = True
            TRF_EDIT.CheckBox1.Visible = False
        Else
            TRF_EDIT.CheckBox1.Enabled = True
            TRF_EDIT.CheckBox1.Checked = False

        End If

        If TRF_EDIT.Label8.Text <> "" Then
            TRF_EDIT.CheckBox1.Visible = False
            TRF_EDIT.CheckBox1.Checked = True
            TRF_EDIT.CheckBox2.Visible = False
            TRF_EDIT.CheckBox2.Checked = True

            TRF_EDIT.btnsave.Visible = False


        Else
            TRF_EDIT.CheckBox1.Enabled = True
            TRF_EDIT.CheckBox1.Checked = False
            TRF_EDIT.CheckBox2.Enabled = True
            TRF_EDIT.CheckBox2.Checked = False

        End If
        TRF_EDIT.Show()
        TRF_EDIT.Label7.Text = DataGridView1.Rows(i).Cells(8).Value.ToString
        TRF_EDIT.Label8.Text = DataGridView1.Rows(i).Cells(9).Value.ToString
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        TRF_EDIT.txtno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TRF_EDIT.daterex.Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TRF_EDIT.storekeluar.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value 'Store Awal
        TRF_EDIT.storemasuk.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TRF_EDIT.Label7.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
        TRF_EDIT.Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
        TRF_EDIT.idstorekeluar.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TRF_EDIT.idstoremasuk.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        kondisiAwal()
    End Sub
End Class