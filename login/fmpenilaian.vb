Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmpenilaian
    Dim bSource As New BindingSource
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
    Dim key As Integer
    Private Sub btnclose_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) 
        fmhasil.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) 
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) 
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) 
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Call buka_koneksi()
        Dim masajabatan As Double
        Dim apraisal As Double
        Dim nki As Double
        Dim test As Double
        Dim rekomendasi As Double
        Dim nama As String
        Dim tanggal As String
        Dim jabatan As String
        nama = cbnama.Text
        tanggal = txtkerja.Text
        jabatan = txtjabatan.Text
        masajabatan = Mid(cbMasaJabatan.Text, 1, 1) / 5
        apraisal = Mid(cbAparsial.Text, 1, 1) / 4
        nki = Mid(cbNki.Text, 1, 1) / 4
        test = Mid(cbTest.Text, 1, 1) / 4
        rekomendasi = 1 / Mid(cbRekomdasi.Text, 1, 1)
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            str = ("INSERT INTO `penilaian` (`nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `apraisal`, `nki`, `test`, `rekom`) VALUES ('" + cbnama.Text + "','" + txtkerja.Text + "', '" + txtjabatan.Text + "','" + Mid(cbMasaJabatan.Text, 1, 1) + "', '" + Mid(cbAparsial.Text, 1, 1) + "', '" + Mid(cbNki.Text, 1, 1) + "', '" + Mid(cbTest.Text, 1, 1) + "','" + Mid(cbRekomdasi.Text, 1, 1) + "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                mysql.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            str = ("INSERT INTO `normal` (`nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `apraisal`, `nki`, `test`, `rekom`) VALUES ('" + nama + "','" + tanggal + "', '" + jabatan + "','" + masajabatan.ToString() + "', '" + CStr(apraisal) + "', '" + CStr(nki) + "', '" + CStr(test) + "','" + CStr(rekomendasi) + "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                mysql.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub clearform()
        cbnama.ResetText()
        txtkerja.Clear()
        txtjabatan.Clear()
        cbMasaJabatan.Text = "-- pilih --"
        cbAparsial.Text = "-- pilih --"
        cbRekomdasi.Text = "-- pilih --"
        cbNki.Text = "-- pilih --"
        cbTest.Text = "-- pilih --"
    End Sub


    Private Sub fmpenilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
        Call loaddata()
    End Sub

    Sub loaddata()
        mysqlco = "server=localhost;user id=root;database=spk"
        da = New MySqlDataAdapter("SELECT * FROM `penilaian`", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub

    Sub tampilDataComboBox()
        Call buka_koneksi()
        Dim str As String
        str = "select nama from karyawan"
        cmd = New MySqlCommand(str, mysqlcon)
        read = cmd.ExecuteReader
        cbnama.Items.Clear()
        Do While read.Read
            cbnama.Items.Add(read.Item(0))
        Loop
        cmd.Dispose()
        read.Close()
        mysql.Close()
    End Sub
    Private Sub cbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnama.SelectedIndexChanged
        Call buka_koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT nama,tgl_kerja,posisi FROM karyawan WHERE nama = '" & cbnama.Text & "'", mysqlcon)
        read = cmd.ExecuteReader
        read.Read()
        If read.HasRows Then
            txtkerja.Text = read.Item(1)
            txtjabatan.Text = read.Item(2)
            txtkerja.Focus()
        End If
        read.Close()
        mysql.Close()
    End Sub

    Private Sub dg3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg3.Rows(e.RowIndex)
            key = row.Cells("idnilai").Value
            cbnama.Text = row.Cells("nama").Value.ToString
            txtkerja.Text = row.Cells("tgl_mulai_kerja").Value.ToString
            txtjabatan.Text = row.Cells("jabatan").Value.ToString
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            Dim masajabatan As Double
            Dim apraisal As Double
            Dim nki As Double
            Dim test As Double
            Dim rekomendasi As Double
            masajabatan = Mid(cbMasaJabatan.Text, 1, 1) / 5
            apraisal = Mid(cbAparsial.Text, 1, 1) / 4
            nki = Mid(cbNki.Text, 1, 1) / 4
            test = Mid(cbTest.Text, 1, 1) / 4
            rekomendasi = 1 / Mid(cbRekomdasi.Text, 1, 1)
            str = "UPDATE `penilaian` SET `nama` = '" + cbnama.Text + "', `tgl_mulai_kerja` = '" + txtkerja.Text + "', `jabatan` =  '" + txtjabatan.Text + "', `ms_jab` ='" + CStr(masajabatan) + "', `apraisal` = '" + CStr(apraisal) + "', `nki` = '" + CStr(nki) + "', `test` = '" + CStr(test) + "', `rekom` = '" + CStr(rekomendasi) + "' WHERE `penilaian`.`idnilai`=" + key.ToString() + ""
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                mysql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA DIPERBAHARUI")
                mysql.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        da = New MySqlDataAdapter("SELECT * FROM `penilaian` WHERE nama LIKE '%" + txtSearch.Text + "%'", mysqlco)
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, mysql)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        mysqlco = "server=localhost;user id=root;database=spk"
        mysql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand("DELETE FROM `penilaian` WHERE `penilaian`.`idnilai` = " + key.ToString + "", mysql)
        Try
            mysql.Open()
            read = cmd.ExecuteReader()
            read.Read()
            MessageBox.Show("DATA TERHAPUS")
            mysql.Close()
            Call clearform()
            Call loaddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call loaddata()
        Call clearform()
    End Sub

    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub
End Class