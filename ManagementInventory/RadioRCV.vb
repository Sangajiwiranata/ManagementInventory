Public Class RadioRCV
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If consume.Checked = True Then
            Form1MenuUtama.MenuStrip1.Visible = False
            Form1MenuUtama.iconbutton.Visible = False
            RCV_LIST.MdiParent = Form1MenuUtama
            RCV_LIST.Dock = DockStyle.Fill
            RCV_LIST.Show()
        ElseIf Asset.Checked = True Then
            MsgBox("Sabar Bro")
            'Form1MenuUtama.MenuStrip1.Visible = False
            'Form1MenuUtama.iconbutton.Visible = False
            'DirectUse_List.MdiParent = Form1MenuUtama
            'DirectUse_List.Dock = DockStyle.Fill
            'DirectUse_List.Show()
        ElseIf TanpaPO.Checked = True Then
            Form1MenuUtama.MenuStrip1.Visible = False
            Form1MenuUtama.iconbutton.Visible = False
            DirectUse_List.MdiParent = Form1MenuUtama
            DirectUse_List.Dock = DockStyle.Fill
            DirectUse_List.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class