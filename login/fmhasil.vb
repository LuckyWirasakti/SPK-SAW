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
        query = "SELECT karyawan.nama, karyawan.nik, normal.jabatan, (((normal.ms_jab/(" & masa_jabatan & "))*" & data(0) & ")+((normal.apraisal/(" & apraisal & "))*" & data(1) & ")+((normal.nki/(" & nki & "))*" & data(2) & ")+((normal.test/(" & test & "))*" & data(3) & ")+(((" & rekomendasi & ")/normal.rekom)*" & data(4) & ")) AS rangking FROM normal JOIN karyawan ON karyawan.id = normal.idnilai ORDER BY rangking DESC"
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

    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                If newpage Then
                    newpage = False
                Else
                    mRow += 1
                End If
                y += h
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Me.Close()
    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        fmmenu.Show()
        Me.Close()
    End Sub
End Class