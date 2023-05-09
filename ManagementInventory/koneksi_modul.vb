Imports MySql.Data.MySqlClient
Module koneksi_modul
    Public Konn As MySqlConnection
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DB As String = "server=localhost; uid=root;database=accounting_db; Convert Zero Datetime=True"

    Sub KONEKDB()
        Try
            Konn = New MySqlConnection(DB)
            If Konn.State = ConnectionState.Closed Then
                Konn.Open()
                'MsgBox("Conection Success")
            End If
        Catch ex As Exception
            MsgBox("Database Disconected, Please Call IT Engginer", MsgBoxStyle.Information, "Information!")
        End Try
    End Sub
End Module
