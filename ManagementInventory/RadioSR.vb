Public Class RadioSR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If radiobuttonSR.Checked = True Then
            Form1MenuUtama.MenuStrip1.Visible = False
            Form1MenuUtama.iconbutton.Visible = False
            SR_LIST.MdiParent = Form1MenuUtama
            SR_LIST.Dock = DockStyle.Fill
            SR_LIST.Show()
            Me.Close()
        ElseIf RadiobuttonTrf.Checked = True Then
            Form1MenuUtama.MenuStrip1.Visible = False
            Form1MenuUtama.iconbutton.Visible = False
            TRF_LIST.MdiParent = Form1MenuUtama
            TRF_LIST.Dock = DockStyle.Fill
            TRF_LIST.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class