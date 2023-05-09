Public Class spash
    Private Sub Spash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Increment(15)
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                Me.Hide()
                Form1MenuUtama.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class