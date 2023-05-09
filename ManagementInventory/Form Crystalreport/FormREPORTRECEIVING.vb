Imports MySql.Data.MySqlClient
Public Class FormREPORTRECEIVING
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox1.Enabled = True
    End Sub
    Private Sub FormREPORTRECEIVING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBtgl.Checked = True Then
            ReportRCV.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportRCV.ReportSource = "reportreceiving.rpt"
            ReportRCV.Refresh()
        Else
            ReportRCV.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportRCV.SelectionFormula &= "and {@namaitem} = '" & TextBox1.Text & "'"
            ReportRCV.SelectionFormula &= "or {@norcv} = '" & TextBox1.Text & "'"
            ReportRCV.SelectionFormula &= "or {@supplier} = '" & TextBox1.Text & "'"
            ReportRCV.ReportSource = "reportreceiving.rpt"
            ReportRCV.Refresh()
        End If
    End Sub

    Private Sub CBtgl_CheckedChanged(sender As Object, e As EventArgs) Handles CBtgl.CheckedChanged
        If CBtgl.Checked = True Then
            DateTimePicker2.Enabled = True
            TextBox1.Enabled = False
        Else
            TextBox1.Enabled = True
        End If

    End Sub
End Class