Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmdaftar
    Dim mysqlcon As MySqlConnection
    Dim com As MySqlCommand
    Dim read As MySqlDataReader
    Function execomand(ByVal cmd As MySqlCommand) As Boolean
        If mysqlcon.State = ConnectionState.Closed Then
            mysqlcon.Open()
        End If
        If cmd.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
        If mysqlcon.State = ConnectionState.Open Then
            mysqlcon.Close()
        End If
    End Function
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;user id=root;database=spk"
        Dim com As New MySqlCommand("INSERT INTO `login`(`nama`,`username`,`password`) values (@nm,@user,@pass)", mysqlcon)
        com.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtnama.Text
        com.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtusername.Text
        com.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtpass.Text

        If execomand(com) Then
            MessageBox.Show("Data Tersimpan")
            fmlogin.Show()
            Hide()

        Else
            MessageBox.Show("Data Tidak Tersimpan")
        End If
    End Sub

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        fmlogin.Show()
        Hide()
    End Sub
End Class