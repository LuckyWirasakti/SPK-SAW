Imports MySql.Data.MySqlClient
Public Class fmlogin
    Dim mysqlcon As MySqlConnection
    Dim com As MySqlCommand
    Dim read As MySqlDataReader
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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
                Hide()
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

    Private Sub fmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        fmdaftar.Show()
        Hide()
    End Sub
End Class
