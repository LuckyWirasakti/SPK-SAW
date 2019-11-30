Imports MySql.Data.MySqlClient

Public Class fmhasil
    Private mysqlco As String
    Private cmd As MySqlCommand
    Private MySql As MySqlConnection

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub fmhasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muatData()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs)

    End Sub

    Sub muatData()
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT nama, ((ms_jab*(0.25))+(apraisal*(0.20))+(nki*(0.20))+(test*(0.20))+(rekom*(0.15))) AS rangking FROM penilaian ORDER BY rangking DESC", mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Close()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Close()
    End Sub
End Class