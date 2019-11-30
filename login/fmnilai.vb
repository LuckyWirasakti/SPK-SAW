Imports MySql.Data.MySqlClient

Public Class fmnilai

    Private Sub btnnilaii_Click(sender As Object, e As EventArgs)
        fmpenilaian.Show()
        Hide()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs)
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs)
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        fmhasil.Show()
        Hide()
    End Sub

    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btndata_Click_1(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Close()
    End Sub

    Private Sub btnhasil_Click_1(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhasil.Show()
        Close()
    End Sub

    Private Sub fmnilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muatAlternatif()
        muatNormalisasi()
    End Sub

    Sub muatAlternatif()
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM penilaian", mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub muatNormalisasi()
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM normal", mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub
End Class