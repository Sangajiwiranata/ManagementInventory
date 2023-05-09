Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub TAMPILBARANG()
        MinimumStock.TAMPILKAN()
        CMD = New MySqlCommand("Select * from tblbarang", Konn)
        DR = CMD.ExecuteReader

        If DR.HasRows Then
            MinimumStock.Show()
            MinimumStock.MdiParent = Form1MenuUtama
            MinimumStock.Dock = DockStyle.Left
            For i As Integer = 0 To MinimumStock.DataGridView1.Rows.Count() - 1 Step +1

                If MinimumStock.DataGridView1.Rows(i).Cells(3).Value < MinimumStock.DataGridView1.Rows(i).Cells(5).Value Then
                    MinimumStock.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                ElseIf MinimumStock.DataGridView1.Rows(i).Cells(3).Value = MinimumStock.DataGridView1.Rows(i).Cells(5).Value Then
                    MinimumStock.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                End If
            Next
        End If
    End Sub
    Sub KONDISILOGIN()
        Call KONEKDB()
        Form1MenuUtama.CCbtn.Visible = True
        Form1MenuUtama.btnsr.Visible = True
        Form1MenuUtama.btnpr.Visible = True
        Form1MenuUtama.btnrcv.Visible = True
        Form1MenuUtama.btnpo.Visible = True
        Form1MenuUtama.StoreRequisitionsToolStripMenuItem.Enabled = True
        Form1MenuUtama.PurchaseOrderToolStripMenuItem.Enabled = True
        Form1MenuUtama.PurchaseRequestToolStripMenuItem.Enabled = True
        Form1MenuUtama.ReceivingToolStripMenuItem.Enabled = True
        Form1MenuUtama.LogoutToolStripMenuItem1.Enabled = True
        Form1MenuUtama.MasterDataITEM.Enabled = True
        Form1MenuUtama.MasterAdministrator.Enabled = True
        Form1MenuUtama.MasterReport.Enabled = True
        Form1MenuUtama.ChangePassword.Enabled = True
        Form1MenuUtama.btnlogout.Enabled = True
    End Sub
    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        End
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Text = "SANGAJI"
        txtpassword.Text = "GHAZALI"
        txtuser.Select()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtuser.Text = "" Then
                MsgBox("Input Username", MsgBoxStyle.Critical, "Warning!!")
            ElseIf txtpassword.Text = "" Then
                MsgBox("Input Password", MsgBoxStyle.Critical, "Warning!!")
            Else
                Call KONEKDB()
                CMD = New MySqlCommand("Select * From tbladmin where namauser='" & txtuser.Text & "' and passworduser='" & txtpassword.Text & "'", Konn)
                DR = CMD.ExecuteReader
                DR.Read()

                If DR.HasRows Then
                    Form1MenuUtama.Show()
                    'Call KONDISILOGIN()
                    'MsgBox("Login Success", MsgBoxStyle.Information, "")
                    Me.Hide()
                    Form1MenuUtama.StatusUser.Text = DR!nama
                    Form1MenuUtama.StatusLevel.Text = DR!leveluser
                    Form1MenuUtama.StatusDept.Text = DR!DEPT
                    FormGantiPass.Label5.Text = DR!iduser
                    'TAMPILBARANG()

                    'membatasi user
                    'If Form1MenuUtama.StatusLevel.Text = "USER" Then
                    '    Form1MenuUtama.PurchaseOrderToolStripMenuItem.Enabled = False
                    '    Form1MenuUtama.btnpo.Enabled = False
                    '    Form1MenuUtama.btnrcv.Enabled = False
                    '    Form1MenuUtama.ReceivingToolStripMenuItem.Enabled = False
                    '    Form1MenuUtama.MasterAdministrator.Enabled = False
                    '    Form1MenuUtama.MasterReport.Enabled = False
                    'ElseIf Form1MenuUtama.StatusLevel.Text <> "ADMIN" Then
                    '    Form1MenuUtama.MasterAdministrator.Enabled = False
                    'End If

                Else
                    MsgBox("Wrong Password", MsgBoxStyle.Critical, "Warning!!")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            btnlogin.Focus()
        End If
    End Sub
End Class