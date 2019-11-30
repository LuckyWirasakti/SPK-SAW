Imports MySql.Data.MySqlClient

Public Class fmnilai

    Dim masa_jabatan As Double
    Dim apraisal As Double
    Dim nki As Double
    Dim test As Double
    Dim rekomendasi As Double

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
        fmkontak.Show()
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
        muatNilaiMinMax()
        muatAlternatif()
        muatNormalisasi()
    End Sub

    Sub MySub()
        '' buat loop untuk update table normalisasi

    End Sub

    Sub muatAlternatif()
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        buka_koneksi()
        da = New MySqlDataAdapter("SELECT * FROM normal", mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Sub muatNormalisasi()
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        Dim query As String
        query = "SELECT nama, (normal.ms_jab/(" & masa_jabatan & ")) AS masajabatan, (normal.apraisal/(" & apraisal & ")) AS apraisal, (normal.nki/(" & nki & ")) AS nki, (normal.test/(" & test & ")) AS test, ((" & rekomendasi & ")/normal.rekom) AS rekomendasi FROM normal"
        da = New MySqlDataAdapter(query, mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
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
End Class