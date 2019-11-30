Imports MySql.Data.MySqlClient

Public Class fmhasil
    Dim masa_jabatan As Double
    Dim apraisal As Double
    Dim nki As Double
    Dim test As Double
    Dim rekomendasi As Double
    Dim data(10) As Double

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

    End Sub

    Sub muatNormalisasi()
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        Dim query As String
        query = "SELECT nama, (((normal.ms_jab/(" & masa_jabatan & "))*" & data(0) & ")+((normal.apraisal/(" & apraisal & "))*" & data(1) & ")+((normal.nki/(" & nki & "))*" & data(2) & ")+((normal.test/(" & test & "))*" & data(3) & ")+(((" & rekomendasi & ")/normal.rekom)*" & data(4) & ")) AS rangking FROM normal ORDER BY rangking DESC"
        da = New MySqlDataAdapter(query, mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Sub muatNilaiMinMax()
        str = "SELECT MAX(ms_jab) AS masa_jabatan, MAX(apraisal) AS apraisal, MAX(nki) as nki, MAX(test) AS test, MIN(rekom) AS rekomendasi FROM `normal`"
        Dim conn As MySqlConnection
        Dim mysqlco As String
        mysqlco = "server=localhost;user id=root;database=spk"
        conn = New MySqlConnection(mysqlco)
        Dim cmd As MySqlCommand
        conn.Open()
        cmd = New MySqlCommand(str, conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows Then
                masa_jabatan = rd.Item("masa_jabatan")
                apraisal = rd.Item("apraisal")
                nki = rd.Item("nki")
                test = rd.Item("test")
                rekomendasi = rd.Item("rekomendasi")
            End If
        Catch ex As Exception
            Console.Write(ex)
        End Try

    End Sub

    Sub muatBobot()
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;database=spk")
        Dim cmd As MySqlCommand
        conn.Open()
        cmd = New MySqlCommand("SELECT bobot FROM kriteria", conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        Dim i As Integer
        i = 0
        While rd.Read()
            Data(i) = rd.Item(0)
            i = i + 1
        End While
    End Sub

    Private Sub fmhasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muatBobot()
        muatNilaiMinMax()
        muatNormalisasi()
    End Sub
End Class