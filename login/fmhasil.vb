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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CrystalReportViewer1.SelectionFormula = "{rangking1.Jabatan} = '" & ComboBox1.Text.ToString & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        CrystalReportViewer2.SelectionFormula = "{rangking21.Jabatan} = '" & ComboBox2.Text.ToString & "'"
        CrystalReportViewer2.Refresh()
        CrystalReportViewer2.RefreshReport()
    End Sub
End Class