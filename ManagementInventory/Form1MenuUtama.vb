Imports MySql.Data.MySqlClient
Public Class Form1MenuUtama
    Sub filteruser()
        Call KONEKDB()
        CMD = New MySqlCommand("Select * From tbladmin", Konn)
        DR = CMD.ExecuteReader
        DR.Read()
    End Sub

    Sub KONDISIAWAL()
        CCbtn.Visible = False
        btnsr.Visible = False
        btnpr.Visible = False
        btnrcv.Visible = False
        btnpo.Visible = False

        StoreRequisitionsToolStripMenuItem.Enabled = False
        PurchaseOrderToolStripMenuItem.Enabled = False
        PurchaseRequestToolStripMenuItem.Enabled = False
        ReceivingToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem1.Enabled = False
        MasterDataITEM.Enabled = False
        MasterAdministrator.Enabled = False
        MasterReport.Enabled = False
        ChangePassword.Enabled = False
        StatusUser.Text = ""
        StatusLevel.Text = ""
        btnlogout.Enabled = False
        StatusTime.Dock = DockStyle.Left

    End Sub
    Private Sub Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'KONDISIAWAL()
        StatusDate.Text = Today
        Timer1.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub PurchaseRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseRequestToolStripMenuItem.Click
        FormPR.ShowDialog()
    End Sub

    Private Sub StoreRequisitionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreRequisitionsToolStripMenuItem.Click
        FormSR.ShowDialog()
    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        FormPO.ShowDialog()
    End Sub

    Private Sub ReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivingToolStripMenuItem.Click
        Formreceiving.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MessageBox.Show("Do You Want to Close?", "Warning!!!", MessageBoxButtons.YesNo) = DialogResult.No Then
            KONDISIAWAL()
        Else
            End
        End If
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        KONDISIAWAL()
    End Sub

    Private Sub ReportsStoreRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsStoreRequisitionToolStripMenuItem.Click
        FormREPORTSR.ShowDialog()
    End Sub

    Private Sub ReportsReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsReceivingToolStripMenuItem.Click
        FormREPORTRECEIVING.ShowDialog()
    End Sub

    Private Sub AddMasterItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMasterItemToolStripMenuItem.Click
        Formtambahbarang.ShowDialog()
    End Sub

    Private Sub ReportsPurchaseRequesitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsPurchaseRequesitionToolStripMenuItem.Click
        FormREPORTPR.ShowDialog()
    End Sub

    Private Sub ReportPurchaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPurchaseOrderToolStripMenuItem.Click
        FormREPORTPO.ShowDialog()
    End Sub

    Private Sub AddMasterSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMasterSupplierToolStripMenuItem.Click
        FormMasterSuplier.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MasterDataITEM.Click
        Gudang.ShowDialog()
    End Sub

    Private Sub AddMasterUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMasterUserToolStripMenuItem.Click
        FormmasterUser.ShowDialog()
    End Sub

    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click
        FormGantiPass.ShowDialog()
    End Sub

    Private Sub btnpr_Click(sender As Object, e As EventArgs) Handles btnpr.Click
        MenuStrip1.Visible = False
        iconbutton.Visible = False
        PRLIST.MdiParent = Me
        PRLIST.Dock = DockStyle.Fill
        PRLIST.Show()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs)
        FormLogin.ShowDialog()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Do You Want to Close?", "Information!!", MessageBoxButtons.YesNo) = DialogResult.No Then

        Else
            End
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtuser.Select()
        FormLogin.txtuser.Text = ""
        FormLogin.txtpassword.Text = ""
    End Sub

    Private Sub btnpo_Click(sender As Object, e As EventArgs) Handles btnpo.Click
        If StatusLevel.Text <> "PURCHASING" And StatusLevel.Text <> "ADMIN" And StatusLevel.Text <> "COST CONTROL" Then
            MsgBox("User Doesn't Have Access", MsgBoxStyle.Critical, "Warning!!")
        Else
            MenuStrip1.Visible = False
            iconbutton.Visible = False
            POLIST.MdiParent = Me
            POLIST.Dock = DockStyle.Fill
            POLIST.Show()
        End If

    End Sub

    Private Sub Btnrcv_Click(sender As Object, e As EventArgs) Handles btnrcv.Click
        If StatusLevel.Text <> "RECEIVING" And StatusLevel.Text <> "ADMIN" And StatusLevel.Text <> "COST CONTROL" Then
            MsgBox("User Doesn't Have Access", MsgBoxStyle.Critical, "Warning!!")
        Else
            RadioRCV.Show()
        End If

    End Sub

    Private Sub Btnsr_Click(sender As Object, e As EventArgs) Handles btnsr.Click
        RadioSR.Show()
    End Sub

    Private Sub CCbtn_Click(sender As Object, e As EventArgs)
        'If StatusLevel.Text <> "ADMIN" And StatusLevel.Text <> "COST CONTROL" Then
        '    MsgBox("User Doesn't Have Access", MsgBoxStyle.Critical, "Warning!!")
        'Else
        '    MenuStrip1.Visible = False
        '    iconbutton.Visible = False
        '    Home.MdiParent = Me
        '    Home.Dock = DockStyle.Fill
        '    PanelCostControl.Visible = True
        'End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        iconbutton.Visible = True
        MenuStrip1.Visible = True
        PanelCostControl.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReleaseSR.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReleaseRCV.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StatusTime.Text = TimeOfDay
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Gudang.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub
End Class