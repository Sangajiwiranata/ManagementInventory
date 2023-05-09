Public Class FormREPORTPR

    Private Sub FormREPORTPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox1.Enabled = True
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBtgl.Checked = True Then
            ReportPR.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportPR.ReportSource = "ReportPR.rpt"
            ReportPR.Refresh()
        Else
            ReportPR.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportPR.SelectionFormula &= "and {@namaitem} = '" & TextBox1.Text & "'"
            ReportPR.SelectionFormula &= "or {@nopr} = '" & TextBox1.Text & "'"
            ReportPR.SelectionFormula &= "or {@supplier} = '" & TextBox1.Text & "'"
            ReportPR.ReportSource = "ReportPR.rpt"
            ReportPR.Refresh()
        End If
    End Sub

    Private Sub CBtgl_CheckedChanged(sender As Object, e As EventArgs) Handles CBtgl.CheckedChanged
        If CBtgl.Checked = True Then
            DateTimePicker2.Enabled = True
            TextBox1.Enabled = False
        Else
            kondisiawal()
        End If

    End Sub
End Class