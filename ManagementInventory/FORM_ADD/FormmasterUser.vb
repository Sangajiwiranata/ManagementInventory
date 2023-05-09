Imports MySql.Data.MySqlClient
Public Class FormmasterUser
    Sub comboboxposition()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_position", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(1))
        Loop

    End Sub
    Sub comboboxlevel()
        KONEKDB()
        'DA = New MySqlDataAdapter("Select")
        CMD = New MySqlCommand("Select * from tbl_levelstaff", Konn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            cmblevel.Items.Add(DR.Item(1))
        Loop
    End Sub
    Sub AKTIFKAN()
        txtname.Enabled = True
        txtpassword.Enabled = True
        'txtposition.Enabled = True
        cmblevel.Enabled = True
        ComboBox1.Enabled = True
        txtusername.Enabled = True
    End Sub
    Sub KONDISIAWAL()
        txtusername.Enabled = False
        txtid.Enabled = False
        txtname.Enabled = False
        txtpassword.Enabled = False
        ComboBox1.Enabled = False
        cmblevel.Enabled = False
        txtusername.Text = ""
        txtname.Text = ""
        txtpassword.Text = ""
        ComboBox1.Text = ""
        cmblevel.Text = ""
        BTNSIMPAN.Text = "Add"
        BTNTUTUP.Text = "Close"
        txtname.Focus()
        noOtomatis()
    End Sub
    Sub noOtomatis()
        Call KONEKDB()
        CMD = New MySqlCommand("select * from tbladmin where iduser in(select max(iduser) from tbladmin)", Konn)
        Dim urutanKode As String
        Dim hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            urutanKode = "USER" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            urutanKode = "USER" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtid.Text = urutanKode
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNTUTUP.Click
        If BTNTUTUP.Text = "Cancel" Then
            KONDISIAWAL()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FormmasterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KONDISIAWAL()
        comboboxlevel()
        comboboxposition()
    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If BTNSIMPAN.Text = "Add" Then
            BTNSIMPAN.Text = "Save"
            AKTIFKAN()
            BTNTUTUP.Text = "Cancel"
        Else
            If txtid.Text = "" Or txtname.Text = "" Or ComboBox1.Text = "" Or txtpassword.Text = "" Or cmblevel.Text = "" Or txtusername.Text = "" Then
                MsgBox("Please fill all section", MsgBoxStyle.Information, "Information")
            Else
                Call KONEKDB()
                Dim inputData As String = "Insert into tbladmin values('" & txtid.Text & "','" & txtname.Text & "','" & ComboBox1.Text & "', '" & txtusername.Text & "', '" & txtpassword.Text & "', '" & cmblevel.Text & "')"
                CMD = New MySqlCommand(inputData, Konn)
                CMD.ExecuteNonQuery()
                MsgBox("Succesfull", MsgBoxStyle.Information, "Information")
                KONDISIAWAL()
            End If
        End If
    End Sub
End Class