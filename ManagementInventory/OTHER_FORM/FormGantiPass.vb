Imports MySql.Data.MySqlClient
Public Class FormGantiPass
    Sub kondisiawal()
        txtbaru.Text = ""
        txtlama.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub FormGantiPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtlama.Text = "" Or txtbaru.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Please Fill All Section")
        Else
            If TextBox1.Text <> txtbaru.Text Then
                MsgBox("Confirm Password Is Wrong", MsgBoxStyle.Critical, "")
            Else
                CMD = New MySqlCommand("select * from tbladmin where iduser='" & Label5.Text & "'", Konn)
                DR = CMD.ExecuteReader
                DR.Close()


                '=======>mengurangi Stock Gudang
                Dim kurangiStock As String = "update tbladmin set passworduser ='" & txtbaru.Text & "' where iduser='" & Label5.Text & "'"
                CMD = New MySqlCommand(kurangiStock, Konn)
                CMD.ExecuteNonQuery()
                MsgBox("Change Password Success!!", MsgBoxStyle.Information, "")
                End
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class