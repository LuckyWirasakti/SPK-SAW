Imports MySql.Data.MySqlClient

Public Class fmLihatKaryawan
    Private Sub fmLihatKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        Dim query As String
        query = "SELECT * FROM karyawan ORDER BY id DESC"
        da = New MySqlDataAdapter(query, mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class