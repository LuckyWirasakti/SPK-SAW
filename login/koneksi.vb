Imports MySql.Data.MySqlClient
Module koneksi

    Public mysqlcon As MySqlConnection
    Public mycmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public read As MySqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public str As String

    Public drnilai As MySqlDataReader
    Public comnilai As MySqlCommand
    Public danilai As MySqlDataAdapter
    Public dtnilai As DataTable

    Public drpenilaian As MySqlDataReader
    Public compenilaian As MySqlCommand
    Public dapenilaian As MySqlDataAdapter
    Public dtpenilaian As DataTable
    Sub buka_koneksi()
        mysqlcon = New MySqlConnection("server=localhost;user id=root;database=spk")
        Try
            If mysqlcon.State = ConnectionState.Closed Then
                mysqlcon.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
