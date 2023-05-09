Public Class FormREPORTSR
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox1.Enabled = True
        DateTimePicker2.Enabled = False
    End Sub
    Private Sub FormREPORTSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBtgl.Checked = True Then
            ReportSR.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportSR.ReportSource = "ReportSR.rpt"
            ReportSR.Refresh()
        Else
            ReportSR.SelectionFormula = "month({@awal})=(" & Month(DateTimePicker2.Text) & ") and year({@awal})=(" & Year(DateTimePicker2.Text) & ")"
            ReportSR.SelectionFormula &= "and {@namaitem} = '" & TextBox1.Text & "'"
            ReportSR.SelectionFormula &= "or {@nosr} = '" & TextBox1.Text & "'"
            ReportSR.SelectionFormula &= "or {@supplier} = '" & TextBox1.Text & "'"
            ReportSR.ReportSource = "ReportSR.rpt"
            ReportSR.Refresh()
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