Imports MySql.Data.MySqlClient
Public Class fmlogin
    Dim mysqlcon As MySqlConnection
    Dim com As MySqlCommand
    Dim read As MySqlDataReader


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;user id=root;database=spk"
        Dim read As MySqlDataReader
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select nama from login where username='" & txtusername.Text & "' and password='" & txtpass.Text & "'"
            com = New MySqlCommand(query, mysqlcon)
            read = com.ExecuteReader
            Dim count As Integer
            count = 0
            While read.Read
                count = count + 1
            End While
            If count = 1 Then
                fmmenu.Show()
                Close()
            ElseIf count > 1 Then
                MessageBox.Show("Username dan Password Sama")
            Else
                MessageBox.Show("Username dan Password Anda Salah")
            End If
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            mysqlcon = New MySqlConnection("server=localhost;user id=root;database=spk")
            mysqlcon.Open()
            mycmd = New MySqlCommand("SELECT nama FROM login WHERE username = '" & txtusername.Text & "' and password = '" & txtpass.Text & "'", mysqlcon)
            read = mycmd.ExecuteReader
            Dim count As Integer
            count = 0
            While read.Read
                count = count + 1
            End While
            If count = 1 Then
                fmmenu.Show()
                Close()
            ElseIf count > 1 Then
                MessageBox.Show("Username dan Password Sama")
            Else
                MessageBox.Show("Username dan Password Anda Salah")
            End If
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub
End Class
