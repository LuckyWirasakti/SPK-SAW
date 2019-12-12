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
        fmubah.Show()
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
        muatAlternatif2()
        muatNormalisasi2()
    End Sub

    Sub muatAlternatif()
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM alternatif", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvAlternatif.DataSource = dt
    End Sub
    Sub muatNormalisasi()
        da = New MySqlDataAdapter("SELECT * FROM normal", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvNormal.DataSource = dt
    End Sub

    Sub muatAlternatif2()
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM alternatif2", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvAlternatif2.DataSource = dt
    End Sub
    Sub muatNormalisasi2()
        da = New MySqlDataAdapter("SELECT * FROM normal2", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvNormal2.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fmubah.Show()
        Me.Close()
    End Sub
End Class