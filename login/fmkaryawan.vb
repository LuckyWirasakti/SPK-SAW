Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class fmkaryawan
    Dim bSource As New BindingSource
    Dim mysq As String
    Dim mysqlco As String
    Dim du As String
    Dim cmd As New MySqlCommand
    Dim mysql As New MySqlConnection
    Dim connection As New MySqlConnection("server=localhost;user id=root;database=spk")
    Function execommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Function
    Private Sub Autonumber()
        Dim strtemp As String = ""
        Dim strvalue As String = ""
        buka_koneksi()
        mycmd = New MySqlCommand("select * from karyawan order by id desc", mysqlcon)
        read = mycmd.ExecuteReader
        If read.Read Then
            strtemp = Mid(read.Item("id"), 1, 4)
        Else
            txtno.Text = "0001"
            txtno.Focus()
            Exit Sub
        End If
        strvalue = Val(strtemp) + 1
        txtno.Text = "" + Mid("0000", 1, 4 - strvalue.Length) & strvalue
        txtno.Focus()
    End Sub
    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Sub kosong()
        txtnik.Text = ""
        txtnama.Text = ""
        tgl_lahir.Text = ""
        txtktlahir.Text = ""
        txtagama.Text = ""
        txtjnskelamin.Text = ""
        txtalamat.Text = ""
        txtkota.Text = ""
        txtsuku.Text = ""
        txtnoktp.Text = ""
        txttglktp.Text = ""
        txtnokk.Text = ""
        txtnonpwp.Text = ""
        txtnogsm.Text = ""
        txtemail.Text = ""
        txtibu.Text = ""
        txtgoldar.Text = ""
        txtbpjs.Text = ""
        tgl_bpjs.Text = ""
        txtjamsostek.Text = ""
        tgl_jamsostek.Text = ""
        txtfaskes.Text = ""
        txtfaskesgg.Text = ""
        txtstatnikah.Text = ""
        tgl_nikah.Text = ""
        txtanak.Text = ""
        txtssnkeluarga.Text = ""
        txtstattngkerja.Text = ""
        txtobjekid.Text = ""
        cbposisi.Text = "-- Pilih Jabatan --"
        txttitle.Text = ""
        txtdirektorat.Text = ""
        txtunit.Text = ""
        txtsubunit.Text = ""
        txtsektor.Text = ""
        txtrayon.Text = ""
        txtidpsa.Text = ""
        txtnmpsa.Text = ""
        txtwitel.Text = ""
        txtteritory.Text = ""
        txtregional.Text = ""
        txtstatkerja.Text = ""
        txtlamaojt.Text = ""
        txtstatinduksi.Text = ""
        tgl_mulai_krj.Text = ""
        tgl_kontrak_1.Text = ""
        tgl_aw_kontrak.Text = ""
        tgl_akh_kontrak.Text = ""
        txtthnkontrak.Text = ""
        txtbandpss.Text = ""
        tgl_band_pss.Text = ""
        txtlevel.Text = ""
        tgl_level.Text = ""
        txtstatpj.Text = ""
        tgl_stat_pj.Text = ""
        tgl_fak_rmh.Text = ""
        tgl_sel_fas.Text = ""
        tgl_aw_nop.Text = ""
        tgl_akh_nop.Text = ""
        tgl_aw_cop.Text = ""
        tgl_akh_cop.Text = ""
        txtlvlpend.Text = ""
        tgl_lv_pend.Text = ""
        txtjurusan.Text = ""
        txtpenypend.Text = ""
        txtnorek.Text = ""
        txtbank.Text = ""
        txtcabbank.Text = ""
        txtalmtbank.Text = ""
        txtnmrek.Text = ""
        txtpichr.Text = ""
        txttimezone.Text = ""
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        mysqlco = "server=localhost;user id=root;database=spk;Convert Zero Datetime=True"
        If txtnik.Text = "" Then
            MessageBox.Show("Isi Data")
            txtnik.Focus()
        Else
            str = ("INSERT INTO `karyawan` (`nik`,`nama`,`tgl_lahir`,`kota_lahir`,`agama`,`jns_klmn`,`alamat`,`kota`,`suku`,`no_ktp`,`tgl_berlaku_ktp`,`no_kk`,`no_npwp`,`no_gsm`,`email`,`nm_ibu`,`gol_darah`,`no_bpjs`,`tgl_bpjs`,`no_jamsostek`,`tgl_jamsostek`,`kd_faskes`,`kd_faskes_gigi`,`sts_nikah`,`tgl_nikah`,`jml_anak`,`susunan_klrg`,`sts_tng_krj`,`objek_id`,`posisi`,`tittle`,`direktorat`,`unit`,`sub_unit`,`sektor`,`rayon`,`id_psa`,`nm_psa`,`witel`,`teritori`,`regional`,`sts_kerja`,`lama_ojt`,`sts_induksi`,`tgl_kerja`,`tgl_kontrak_pertama`,`tgl_awal_kontrak`,`tgl_akhir_kontrak`,`tahun_kontrak`,`band_posisi`,`tgl_band_posisi`,`level`,`tgl_level`,`sts_pj`,`tgl_sts_pj`,`tgl_fas_rmh`,`tgl_sel_fas_rmh`,`tgl_awal_nop`,`tgl_akhir_nop`,`tgl_awal_cop`,`tgl_akhir_cop`,`level_pend`,`tgl_level_pend`,`jurusan`,`peny_pend`,`no_rek`,`bank`,`kantor_cab`,`alamat_bank`,`nama_rek`,`pic_hr`,`time_zone`) values ('" & txtnik.Text & "','" & txtnama.Text & "','" & tgl_lahir.Text & "','" & txtktlahir.Text & "','" & txtagama.Text & "','" & txtjnskelamin.Text & "','" & txtalamat.Text & "','" & txtkota.Text & "','" & txtsuku.Text & "','" & txtnoktp.Text & "','" & txttglktp.Text & "','" & txtnokk.Text & "','" & txtnonpwp.Text & "','" & txtnogsm.Text & "','" & txtemail.Text & "','" & txtibu.Text & "','" & txtgoldar.Text & "','" & txtbpjs.Text & "','" & tgl_bpjs.Text & "','" & txtjamsostek.Text & "','" & tgl_bpjs.Text & "','" & txtfaskes.Text & "','" & txtfaskesgg.Text & "','" & txtstatnikah.Text & "','" & tgl_nikah.Text & "','" & txtanak.Text & "','" & txtssnkeluarga.Text & "','" & txtstattngkerja.Text & "','" & txtobjekid.Text & "','" & cbposisi.Text & "','" & txttitle.Text & "','" & txtdirektorat.Text & "','" & txtunit.Text & "','" & txtsubunit.Text & "','" & txtsektor.Text & "','" & txtrayon.Text & "','" & txtidpsa.Text & "','" & txtnmpsa.Text & "','" & txtwitel.Text & "','" & txtteritory.Text & "','" & txtregional.Text & "','" & txtstatkerja.Text & "','" & txtlamaojt.Text & "','" & txtstatinduksi.Text & "','" & tgl_mulai_krj.Text & "','" & tgl_kontrak_1.Text & "','" & tgl_aw_kontrak.Text & "','" & tgl_akh_kontrak.Text & "','" & txtthnkontrak.Text & "','" & txtbandpss.Text & "','" & tgl_band_pss.Text & "','" & txtlevel.Text & "','" & tgl_level.Text & "','" & txtstatpj.Text & "','" & tgl_stat_pj.Text & "','" & tgl_fak_rmh.Text & "','" & tgl_sel_fas.Text & "','" & tgl_aw_nop.Text & "','" & tgl_akh_nop.Text & "','" & tgl_aw_cop.Text & "','" & tgl_akh_cop.Text & "','" & txtlvlpend.Text & "','" & tgl_lv_pend.Text & "','" & txtjurusan.Text & "','" & txtpenypend.Text & "','" & txtnorek.Text & "','" & txtbank.Text & "','" & txtcabbank.Text & "','" & txtalmtbank.Text & "','" & txtnmrek.Text & "','" & txtpichr.Text & "','" & txttimezone.Text & "')")
            mysql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                MySql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                mysql.Close()
                kosong()
                Autonumber()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        fmmenu.Show()
        Close()
    End Sub

    Private Sub btntampil_Click(sender As Object, e As EventArgs) Handles btntampil.Click
        fmLihatKaryawan.Show()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            Call buka_koneksi()
            cmd = New MySqlCommand("UPDATE karyawan SET nik = '" & txtnik.Text & "', nama = '" & txtnama.Text & "', tgl_lahir = '" & tgl_lahir.Text & "', kota_lahir = '" & txtktlahir.Text & "', agama = '" & txtagama.Text & "', jns_klmn = '" & txtjnskelamin.Text & "', alamat = '" & txtalamat.Text & "', kota = '" & txtkota.Text & "', suku = '" & txtsuku.Text & "', no_ktp = '" & txtnoktp.Text & "', tgl_berlaku_ktp = '" & txttglktp.Text & "', no_kk = '" & txtnokk.Text & "', no_npwp = '" & txtnonpwp.Text & "', no_gsm = '" & txtnogsm.Text & "', email = '" & txtemail.Text & "', nm_ibu = '" & txtibu.Text & "', gol_darah = '" & txtgoldar.Text & "', no_bpjs = '" & txtbpjs.Text & "', tgl_bpjs = '" & txtbpjs.Text & "', no_jamsostek = '" & txtjamsostek.Text & "', tgl_jamsostek = '" & tgl_jamsostek.Text & "', kd_faskes = '" & txtfaskes.Text & "', kd_faskes_gigi = '" & txtfaskesgg.Text & "', sts_nikah = '" & txtstatnikah.Text & "', tgl_nikah = '" & tgl_nikah.Text & "', jml_anak = '" & txtanak.Text & "', susunan_klrg = '" & txtssnkeluarga.Text & "', sts_tng_krj = '" & txtstattngkerja.Text & "', objek_id = '" & txtobjekid.Text & "', posisi = '" & cbposisi.Text & "', tittle = '" & txttitle.Text & "', direktorat = '" & txtdirektorat.Text & "', unit = '" & txtunit.Text & "', sub_unit = '" & txtsubunit.Text & "', sektor = '" & txtsektor.Text & "', rayon = '" & txtrayon.Text & "', id_psa = '" & txtidpsa.Text & "', nm_psa = '" & txtnmpsa.Text & "', witel = '" & txtwitel.Text & "', teritori = '" & txtteritory.Text & "', regional = '" & txtregional.Text & "', sts_kerja = '" & txtstatkerja.Text & "', lama_ojt = '" & txtlamaojt.Text & "', sts_induksi = '" & txtstatinduksi.Text & "', tgl_kerja = '" & tgl_mulai_krj.Text & "', tgl_kontrak_pertama = '" & tgl_kontrak_1.Text & "', tgl_awal_kontrak = '" & tgl_aw_kontrak.Text & "', tgl_akhir_kontrak = '" & tgl_akh_kontrak.Text & "', tahun_kontrak = '" & txtthnkontrak.Text & "', band_posisi = '" & txtbandpss.Text & "', tgl_band_posisi = '" & tgl_band_pss.Text & "', level = '" & txtlevel.Text & "', tgl_level = '" & tgl_level.Text & "', sts_pj = '" & txtstatpj.Text & "', tgl_sts_pj = '" & tgl_stat_pj.Text & "', tgl_fas_rmh = '" & tgl_fak_rmh.Text & "', tgl_sel_fas_rmh = '" & tgl_sel_fas.Text & "', tgl_awal_nop = '" & tgl_aw_nop.Text & "', tgl_akhir_nop = '" & tgl_akh_nop.Text & "', tgl_awal_cop = '" & tgl_aw_cop.Text & "', tgl_akhir_cop = '" & tgl_akh_cop.Text & "', level_pend = '" & txtlvlpend.Text & "', tgl_level_pend = '" & tgl_level.Text & "', jurusan = '" & txtjurusan.Text & "', peny_pend = '" & txtpenypend.Text & "', no_rek = '" & txtnorek.Text & "', bank = '" & txtbank.Text & "', kantor_cab = '" & txtcabbank.Text & "', alamat_bank = '" & txtalmtbank.Text & "', nama_rek = '" & txtnmrek.Text & "', pic_hr = '" & txtpichr.Text & "', time_zone = '" & txttimezone.Text & "' WHERE  id = '" & txtno.Text & "' ", mysqlcon)
            kosong()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Diperbaharui")
        Catch ex As Exception
            MessageBox.Show("Gagal Memperbaharui Data" + ex.ToString)
        End Try
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Autonumber()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Call buka_koneksi()
            cmd = New MySqlCommand("DELETE FROM karyawan WHERE id = '" + txtno.Text + "'", mysqlcon)
            cmd.ExecuteNonQuery()
            kosong()
            MessageBox.Show("Data Terhapus")
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal Menghapus Data")
        End Try
    End Sub
End Class