Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmkriteria
    Dim bSource As New BindingSource
    Dim mysq As String
    Dim mysqlco As String
    Dim du As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim connection As New MySqlConnection("server=localhost;user id=root;database=spk")
    Function execommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Function
    Sub kosong()
        txtkode.Text = ""
        txtkriteria.Text = ""
        txtbobot.Text = ""
    End Sub
    Private Sub loaddata()
        dg2.DataSource = Nothing
        dg2.Refresh()
        str = "select * from kriteria"
        cmd = New MySqlCommand(str, mysql)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        dg2.DataSource = dt
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs)
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs)
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        If txtkode.Text = "" Then
            MessageBox.Show("Isi Data")
            txtkode.Focus()
        Else
            Dim bobot As Double
            Dim bobotH As String
            bobot = CDbl(txtbobot.Text)
            bobot = (bobot / 100)
            bobotH = CStr(bobot)
            bobotH = Replace(bobotH, ",", ".")

            str = ("INSERT INTO `kriteria` (`kd_kriteria`,`nm_kriteria`,`bobot`) values ('" & txtkode.Text & "','" & txtkriteria.Text & "','" + bobotH + "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                mysql.Close()
                loaddata()
                kosong()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub fmkriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM kriteria order by kd_kriteria asc", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg2.DataSource = dt
    End Sub

    Private Sub dg2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg2.Rows(e.RowIndex)
            txtkode.Text = row.Cells("kd_kriteria").Value.ToString
            txtkriteria.Text = row.Cells("nm_kriteria").Value.ToString
            txtbobot.Text = row.Cells("bobot").Value.ToString
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim bobot As Double
        Dim bobotH As String
        bobot = CDbl(txtbobot.Text)
        bobot = (bobot / 100)
        bobotH = CStr(bobot)
        bobotH = Replace(bobotH, ",", ".")

        mysqlco = "server=localhost;user id=root;database=spk"
        str = "UPDATE `kriteria` SET `nm_kriteria`='" & txtkriteria.Text & "',`bobot`='" & bobotH & "' WHERE `kd_kriteria` = '" & txtkode.Text & "'"
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        Try
            mysql.Open()
            read = cmd.ExecuteReader()
            read.Read()
            MessageBox.Show("DATA DIPERBAHARUI")
            mysql.Close()
            loaddata()
            kosong()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        mysq = "server=localhost;user id=root;database=spk"
        mysqlco = "DELETE FROM kriteria WHERE kd_kriteria='" & txtkode.Text & "'"
        mysql = New MySqlConnection(mysq)
        cmd = New MySqlCommand(mysqlco, mysql)
        Try
            mysql.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di hapus")
            loaddata()
            kosong()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class