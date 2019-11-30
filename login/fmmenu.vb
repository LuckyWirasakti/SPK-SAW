Public Class fmmenu

    Private Sub btnnilai_Click(sender As Object, e As EventArgs) Handles btnnilai.Click
        fmnilai.Show()
        Close()
    End Sub
    Private Sub btnkaryawan_Click(sender As Object, e As EventArgs)
        fmkaryawan.Show()
        Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnkriteria_Click(sender As Object, e As EventArgs)
        fmkriteria.Show()
        Hide()
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        fmhasil.Show()
        Hide()
    End Sub

    Private Sub btnkontak_Click(sender As Object, e As EventArgs) Handles btnkontak.Click
        fmkontak.Show()
        Hide()
    End Sub

    Private Sub btnkaryawan_Click_1(sender As Object, e As EventArgs) Handles btnkaryawan.Click
        fmkaryawan.Show()
    End Sub

    Private Sub btnkriteria_Click_1(sender As Object, e As EventArgs) Handles btnkriteria.Click
        fmkriteria.Show()
    End Sub

    Private Sub btnnilaii_Click(sender As Object, e As EventArgs) Handles btnnilaii.Click
        fmpenilaian.Show()
    End Sub

    Private Sub pnlOnButtonPosition_Paint(sender As Object, e As PaintEventArgs) Handles pnlOnButtonPosition.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click

    End Sub

    Private Sub pnlLeftSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeftSide.Paint

    End Sub

    Private Sub pnldata_Paint(sender As Object, e As PaintEventArgs) Handles pnldata.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub pnlkaryawan_Paint(sender As Object, e As PaintEventArgs) Handles pnlkaryawan.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub pnlkriteria_Paint(sender As Object, e As PaintEventArgs) Handles pnlkriteria.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub pnlTopSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopSide.Paint

    End Sub
End Class