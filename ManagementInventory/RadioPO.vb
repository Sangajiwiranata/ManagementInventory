Public Class RadioPO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If consume.Checked = True Then
            FormPO.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class