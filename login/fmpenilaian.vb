Imports MySql.Data.MySqlClient
Public Class fmpenilaian
    Dim mysqlco As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim m As New MySqlConnection
    Dim key As Integer

    Sub dataTanggungJawab()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Tanggung Jawab --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbTanggungJawab.DisplayMember = "Key"
        cbTanggungJawab.ValueMember = "Value"
        cbTanggungJawab.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataKejujuran()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kejujuran --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKejujuran.DisplayMember = "Key"
        cbKejujuran.ValueMember = "Value"
        cbKejujuran.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataKedisiplinan()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kedisiplinan --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKedisiplinan.DisplayMember = "Key"
        cbKedisiplinan.ValueMember = "Value"
        cbKedisiplinan.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataSikap()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Sikap --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbSikap.DisplayMember = "Key"
        cbSikap.ValueMember = "Value"
        cbSikap.DataSource = New BindingSource(skala, Nothing)
    End Sub

    Sub dataKomunikasi()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Komunikasi --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKomunikasi.DisplayMember = "Key"
        cbKomunikasi.ValueMember = "Value"
        cbKomunikasi.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataKecakapanKerja()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kecakapan Kerja --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKecakapanKerja.DisplayMember = "Key"
        cbKecakapanKerja.ValueMember = "Value"
        cbKecakapanKerja.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataKualitasKerja()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kualitas Kerja --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKualitasKerja.DisplayMember = "Key"
        cbKualitasKerja.ValueMember = "Value"
        cbKualitasKerja.DataSource = New BindingSource(skala, Nothing)
    End Sub

    Sub dataKerjaSama()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kerja Sama --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKerjaSama.DisplayMember = "Key"
        cbKerjaSama.ValueMember = "Value"
        cbKerjaSama.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataKehadiran()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Kehadiran --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbKehadiran.DisplayMember = "Key"
        cbKehadiran.ValueMember = "Value"
        cbKehadiran.DataSource = New BindingSource(skala, Nothing)
    End Sub
    Sub dataInisiatif()
        Dim skala As New Dictionary(Of String, Integer)
        skala.Add("-- Inisiatif --", 0)
        skala.Add("Buruk", 1)
        skala.Add("Kurang", 2)
        skala.Add("Cukup", 3)
        skala.Add("Baik", 4)
        skala.Add("Sangat Baik", 5)
        cbInisiatif.DisplayMember = "Key"
        cbInisiatif.ValueMember = "Value"
        cbInisiatif.DataSource = New BindingSource(skala, Nothing)
    End Sub

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
        fmubah.Show()
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
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            str = ("INSERT INTO `alternatif` (`nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `apraisal`, `nki`, `test`, `rekom`) VALUES ('" + cbnama.Text + "','" + txtkerja.Text + "', '" + txtjabatan.Text + "','" + Mid(cbMasaJabatan.Text, 1, 1) + "', '" + Mid(cbAparsial.Text, 1, 1) + "', '" + Mid(cbNki.Text, 1, 1) + "', '" + Mid(cbTest.Text, 1, 1) + "','" + Mid(cbRekomdasi.Text, 1, 1) + "')")
            cmd = New MySqlCommand(str, mysqlcon)
            Try
                read = cmd.ExecuteReader()
                read.Read()
                mysqlcon.Close()
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
    Sub clearform2()
        cbNama2.ResetText()
        txtTanggal2.ResetText()
        txtJabatan2.ResetText()
        cbTanggungJawab.SelectedValue = 0
        cbKejujuran.SelectedValue = 0
        cbKedisiplinan.SelectedValue = 0
        cbSikap.SelectedValue = 0
        cbKomunikasi.SelectedValue = 0
        cbKecakapanKerja.SelectedValue = 0
        cbKualitasKerja.SelectedValue = 0
        cbKerjaSama.SelectedValue = 0
        cbKehadiran.SelectedValue = 0
        cbInisiatif.SelectedValue = 0
    End Sub


    Private Sub fmpenilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
        Call loaddata()
        Call loaddata2()
        dataTanggungJawab()
        dataKejujuran()
        dataKedisiplinan()
        dataSikap()
        dataKomunikasi()
        dataKecakapanKerja()
        dataKualitasKerja()
        dataKerjaSama()
        dataKehadiran()
        dataInisiatif()
    End Sub

    Sub loaddata()
        da = New MySqlDataAdapter("SELECT * FROM `alternatif`", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub
    Sub loaddata2()
        da = New MySqlDataAdapter("SELECT * FROM `alternatif2`", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvAlternatif2.DataSource = dt
    End Sub

    Sub tampilDataComboBox()
        Call buka_koneksi()
        cmd = New MySqlCommand("SELECT nama FROM karyawan", mysqlcon)
        read = cmd.ExecuteReader
        cbNama2.Text = ("-- Nama --")
        cbnama.Text = ("-- Nama --")
        Do While read.Read
            cbnama.Items.Add(read.Item(0))
            cbNama2.Items.Add(read.Item(0))
        Loop
        cmd.Dispose()
        read.Close()
        mysqlcon.Close()
    End Sub
    Private Sub cbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnama.SelectedIndexChanged
        Call buka_koneksi()
        cmd = New MySqlCommand("SELECT nama,tgl_kerja,posisi FROM karyawan WHERE nama = '" & cbnama.Text & "'", mysqlcon)
        read = cmd.ExecuteReader
        read.Read()
        If read.HasRows Then
            txtkerja.Text = read.Item(1)
            '' txtTanggal2.Text = read.Item(1)
            txtjabatan.Text = read.Item(2)
            '' txtJabatan2.Text = read.Item(2)
            txtkerja.Focus()
        End If
        read.Close()
        mysql.Close()
    End Sub

    Private Sub dg3_CellClick(sender As Object, e As DataGridViewCellEventArgs)
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
        If txtjabatan.Text = "" Or txtkerja.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            Dim masajabatan As Double
            Dim apraisal As Double
            Dim nki As Double
            Dim test As Double
            Dim rekomendasi As Double

            masajabatan = Mid(cbMasaJabatan.Text, 1, 1)
            apraisal = Mid(cbAparsial.Text, 1, 1)
            nki = Mid(cbNki.Text, 1, 1)
            test = Mid(cbTest.Text, 1, 1)
            rekomendasi = Mid(cbRekomdasi.Text, 1, 1)

            Call buka_koneksi()
            str = "UPDATE `alternatif` SET `nama` = '" + cbnama.Text + "', `tgl_mulai_kerja` = '" + txtkerja.Text + "', `jabatan` =  '" + txtjabatan.Text + "', `ms_jab` ='" + CStr(masajabatan) + "', `apraisal` = '" + CStr(apraisal) + "', `nki` = '" + CStr(nki) + "', `test` = '" + CStr(test) + "', `rekom` = '" + CStr(rekomendasi) + "' WHERE `alternatif`.`idnilai`=" + key.ToString() + ""
            cmd = New MySqlCommand(str, mysqlcon)
            Try
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA DIPERBAHARUI")
                mysqlcon.Close()
                Call loaddata()
                Call clearform()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        da = New MySqlDataAdapter("SELECT * FROM `alternatif` WHERE nama LIKE '%" + txtSearch.Text + "%'", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dg3.DataSource = dt
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        buka_koneksi()
        cmd = New MySqlCommand("DELETE FROM `alternatif` WHERE `alternatif`.`idnilai` = " + key.ToString + "", mysqlcon)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA TERHAPUS")
            mysqlcon.Close()
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

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        loaddata2()
    End Sub

    Private Sub dgvAlternatif2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlternatif2.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvAlternatif2.Rows(e.RowIndex)
            key = row.Cells("idnilai").Value
            cbNama2.Text = row.Cells("nama").Value.ToString
            txtTanggal2.Text = row.Cells("tgl_mulai_kerja").Value.ToString
            txtJabatan2.Text = row.Cells("jabatan").Value.ToString
        End If
    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        If txtJabatan2.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            Call buka_koneksi()
            str = ("INSERT INTO `alternatif2`(`idnilai`, `nama`, `tgl_mulai_kerja`, `jabatan`, `tanggung_jawab`, `kejujuran`, `kedisiplinan`, `sikap`, `komunikasi`, `kecakapan_kerja`, `kualitas_kerja`, `kerja_sama`, `kehadiran`, `inisiatif`) VALUES (NULL,'" & cbNama2.Text & "','" & txtTanggal2.Text & "','" & txtJabatan2.Text & "','" & cbTanggungJawab.SelectedValue.ToString & "','" & cbKejujuran.SelectedValue.ToString & "','" & cbKedisiplinan.SelectedValue.ToString & "','" & cbSikap.SelectedValue.ToString & "','" & cbKomunikasi.SelectedValue.ToString & "','" & cbKecakapanKerja.SelectedValue.ToString & "','" & cbKualitasKerja.SelectedValue.ToString & "','" & cbKerjaSama.SelectedValue.ToString & "','" & cbKehadiran.SelectedValue.ToString & "','" & cbInisiatif.SelectedValue.ToString & "')")
            cmd = New MySqlCommand(str, mysqlcon)
            Try
                read = cmd.ExecuteReader()
                read.Read()
                mysqlcon.Close()
                Call loaddata2()
                Call clearform2()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dg3_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dg3.Rows(e.RowIndex)
            key = row.Cells("idnilai").Value
            cbnama.Text = row.Cells("nama").Value.ToString
            txtkerja.Text = row.Cells("tgl_mulai_kerja").Value.ToString
            txtjabatan.Text = row.Cells("jabatan").Value.ToString
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        da = New MySqlDataAdapter("SELECT * FROM `alternatif2` WHERE nama LIKE '%" + txtCari2.Text + "%'", mysqlcon)
        dt = New DataTable
        da.Fill(dt)
        dgvAlternatif2.DataSource = dt
    End Sub

    Private Sub btnEdit2_Click(sender As Object, e As EventArgs) Handles btnEdit2.Click
        If txtJabatan2.Text = "" Or txtTanggal2.Text = "" Then
            MessageBox.Show("Isi Data")
        Else
            Call buka_koneksi()
            str = "UPDATE `alternatif2` SET `nama`='" & cbNama2.Text & "',`tgl_mulai_kerja`='" & txtTanggal2.Text & "',`jabatan`='" & txtJabatan2.Text & "',`tanggung_jawab`='" & cbTanggungJawab.SelectedValue.ToString & "',`kejujuran`='" & cbKejujuran.SelectedValue.ToString & "',`kedisiplinan`='" & cbKedisiplinan.SelectedValue.ToString & "',`sikap`='" & cbSikap.SelectedValue.ToString & "',`komunikasi`='" & cbKomunikasi.SelectedValue.ToString & "',`kecakapan_kerja`='" & cbKecakapanKerja.SelectedValue.ToString & "',`kualitas_kerja`='" & cbKualitasKerja.SelectedValue.ToString & "',`kerja_sama`='" & cbKerjaSama.SelectedValue.ToString & "',`kehadiran`='" & cbKehadiran.SelectedValue.ToString & "',`inisiatif`='" & cbInisiatif.SelectedValue.ToString & "' WHERE `idnilai` = '" & key.ToString & "'"
            cmd = New MySqlCommand(str, mysqlcon)
            Try
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA DIPERBAHARUI")
                mysqlcon.Close()
                Call loaddata2()
                Call clearform2()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        buka_koneksi()
        cmd = New MySqlCommand("DELETE FROM `alternatif2` WHERE `alternatif2`.`idnilai` = " + key.ToString + "", mysqlcon)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("DATA TERHAPUS")
            mysqlcon.Close()
            Call loaddata2()
            Call clearform2()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbNama2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNama2.SelectedIndexChanged
        Call buka_koneksi()
        cmd = New MySqlCommand("SELECT nama,tgl_kerja,posisi FROM karyawan WHERE nama = '" & cbnama.Text & "'", mysqlcon)
        read = cmd.ExecuteReader
        read.Read()
        If read.HasRows Then
            txtTanggal2.Text = read.Item(1)
            txtJabatan2.Text = read.Item(2)
            txtTanggal2.Focus()
        End If
        read.Close()
        mysqlcon.Close()
    End Sub
End Class