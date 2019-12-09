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
        query = "SELECT karyawan.nama AS NAMA, karyawan.nik AS NIK, normal.jabatan AS JABATAN, (((normal.ms_jab/(" & masa_jabatan & "))*" & data(0) & ")+((normal.apraisal/(" & apraisal & "))*" & data(1) & ")+((normal.nki/(" & nki & "))*" & data(2) & ")+((normal.test/(" & test & "))*" & data(3) & ")+(((" & rekomendasi & ")/normal.rekom)*" & data(4) & ")) AS RANGKING FROM normal JOIN karyawan ON karyawan.id = normal.idnilai ORDER BY rangking DESC"
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
            data(i) = rd.Item(0)
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
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.Show()
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim drawString1 As [String] = "CALON KARYAWAN TETAP"
        Dim drawString2 As [String] = "TELKOM AKSES"
        ' Create font and brush.
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)

        ' Create rectangle for drawing.
        Dim a As Single = 0F
        Dim b1 As Single = 90.0F
        Dim b2 As Single = 120.0F
        Dim width As Single = 900.0F
        Dim height As Single = 50.0F
        Dim drawRect1 As New RectangleF(a, b1, width, height)
        Dim drawRect2 As New RectangleF(a, b2, width, height)

        ' Draw rectangle to screen.
        Dim blackPen As New Pen(Color.White)
        e.Graphics.DrawRectangle(blackPen, a, b1, width, height)
        e.Graphics.DrawRectangle(blackPen, a, b2, width, height)
        ' Set format of string.
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Center

        Dim ax As Single = 20.0F
        Dim ay As Single = 20.0F

        ' Create rectangle for source image.
        Dim srcRect As New RectangleF(0.0F, 50.0F, width, height)
        Dim units As GraphicsUnit = GraphicsUnit.Pixel

        Dim newimage As Image = Image.FromFile("D:\image\telkom.jpg")
        e.Graphics.DrawImage(newimage, ax, ay, srcRect, units)

        ' Draw string to screen.
        e.Graphics.DrawString(drawString1, drawFont, drawBrush, drawRect1, drawFormat)
        e.Graphics.DrawString(drawString2, drawFont, drawBrush, drawRect2, drawFormat)

        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top + 70.0F
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0

                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(" " + DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(" " + DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class