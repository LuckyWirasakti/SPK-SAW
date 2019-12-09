Imports MySql.Data.MySqlClient

Public Class fmubah

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Hide()
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Hide()
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.Clear()
    End Sub

    Private Sub txtPassword2_Enter(sender As Object, e As EventArgs) Handles txtPassword2.Enter
        txtPassword2.Clear()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtPassword.Text = txtPassword2.Text Then
            If cbUsername.Text = "-- Pilih User --" Then
                MessageBox.Show("Nama pengguna tidak sah")
            Else
                changePassword()
                Login()
            End If
        Else
            MessageBox.Show("Kata Sandi Tidak Sama")
        End If
    End Sub
    Sub changePassword()
        Try
            Call buka_koneksi()
            mycmd = New MySqlCommand("UPDATE `login` SET `password` = '" & txtPassword.Text & "' WHERE `login`.`nama` = '" & cbUsername.Text & "';", mysqlcon)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Kata Sandi Berhasil Diubah")
        Catch ex As Exception
            MessageBox.Show("Kata Sandi Gagal Diubah")
        End Try
    End Sub

    Private Sub fmubah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username()
        Login()
    End Sub
    Sub Username()
        mysqlcon = New MySqlConnection("server=localhost;user id=root;database=spk")
        mysqlcon.Open()
        mycmd = New MySqlCommand("SELECT nama FROM login", mysqlcon)
        read = mycmd.ExecuteReader
        Do While read.Read
            cbUsername.Items.Add(read.Item(0))
        Loop
        mycmd.Dispose()
        read.Close()
        mysqlcon.Close()
    End Sub

    Sub Login()
        mysqlcon = New MySqlConnection("server=localhost;user id=root;database=spk")
        da = New MySqlDataAdapter("SELECT * FROM `login`", mysqlcon)
        mycmd = New MySqlCommand(str, mysqlcon)
        dt = New DataTable()
        da.Fill(dt)
        dgvLogin.DataSource = dt
    End Sub
End Class