Imports MySql.Data.MySqlClient

Public Class fmhasil

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

    End Sub

    Private Sub fmhasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Zoom(75)
        CrystalReportViewer2.Zoom(75)
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Me.Close()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmubah.Show()
        Me.Close()
    End Sub

End Class