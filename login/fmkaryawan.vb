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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        mysqlco = "server=localhost;user id=root;database=spk;Convert Zero Datetime=True"
        If txtnik.Text = "" Then
            MessageBox.Show("Isi Data")
            txtnik.Focus()
        Else
            str = ("INSERT INTO `karyawan` (`nik`,`nama`,`tgl_lahir`,`kota_lahir`,`agama`,`jns_klmn`,`alamat`,`kota`,`suku`,`no_ktp`,`tgl_berlaku_ktp`,`no_kk`,`no_npwp`,`no_gsm`,`email`,`nm_ibu`,`gol_darah`,`no_bpjs`,`tgl_bpjs`,`no_jamsostek`,`tgl_jamsostek`,`kd_faskes`,`kd_faskes_gigi`,`sts_nikah`,`tgl_nikah`,`jml_anak`,`susunan_klrg`,`sts_tng_krj`,`objek_id`,`posisi`,`tittle`,`direktorat`,`unit`,`sub_unit`,`sektor`,`rayon`,`id_psa`,`nm_psa`,`witel`,`teritori`,`regional`,`sts_kerja`,`lama_ojt`,`sts_induksi`,`tgl_kerja`,`tgl_kontrak_pertama`,`tgl_awal_kontrak`,`tgl_akhir_kontrak`,`tahun_kontrak`,`band_posisi`,`tgl_band_posisi`,`level`,`tgl_level`,`sts_pj`,`tgl_sts_pj`,`tgl_fas_rmh`,`tgl_sel_fas_rmh`,`tgl_awal_nop`,`tgl_akhir_nop`,`tgl_awal_cop`,`tgl_akhir_cop`,`level_pend`,`tgl_level_pend`,`jurusan`,`peny_pend`,`no_rek`,`bank`,`kantor_cab`,`alamat_bank`,`nama_rek`,`pic_hr`,`time_zone`) values ('" & txtnik.Text & "','" & txtnama.Text & "','" & tgl_lahir.Text & "','" & txtktlahir.Text & "','" & txtagama.Text & "','" & txtjnskelamin.Text & "','" & txtalamat.Text & "','" & txtkota.Text & "','" & txtsuku.Text & "','" & txtnoktp.Text & "','" & txttglktp.Text & "','" & txtnokk.Text & "','" & txtnonpwp.Text & "','" & txtnogsm.Text & "','" & txtemail.Text & "','" & txtibu.Text & "','" & txtgoldar.Text & "','" & txtbpjs.Text & "','" & tgl_bpjs.Text & "','" & txtjamsostek.Text & "','" & tgl_bpjs.Text & "','" & txtfaskes.Text & "','" & txtfaskesgg.Text & "','" & txtstatnikah.Text & "','" & tgl_nikah.Text & "','" & txtanak.Text & "','" & txtssnkeluarga.Text & "','" & txtstattngkerja.Text & "','" & txtobjekid.Text & "','" & txtposisi.Text & "','" & txttitle.Text & "','" & txtdirektorat.Text & "','" & txtunit.Text & "','" & txtsubunit.Text & "','" & txtsektor.Text & "','" & txtrayon.Text & "','" & txtidpsa.Text & "','" & txtnmpsa.Text & "','" & txtwitel.Text & "','" & txtteritory.Text & "','" & txtregional.Text & "','" & txtstatkerja.Text & "','" & txtlamaojt.Text & "','" & txtstatinduksi.Text & "','" & tgl_mulai_krj.Text & "','" & tgl_kontrak_1.Text & "','" & tgl_aw_kontrak.Text & "','" & tgl_akh_kontrak.Text & "','" & txtthnkontrak.Text & "','" & txtbandpss.Text & "','" & tgl_band_pss.Text & "','" & txtlevel.Text & "','" & tgl_level.Text & "','" & txtstatpj.Text & "','" & tgl_stat_pj.Text & "','" & tgl_fak_rmh.Text & "','" & tgl_sel_fas.Text & "','" & tgl_aw_nop.Text & "','" & tgl_akh_nop.Text & "','" & tgl_aw_cop.Text & "','" & tgl_akh_cop.Text & "','" & txtlvlpend.Text & "','" & tgl_lv_pend.Text & "','" & txtjurusan.Text & "','" & txtpenypend.Text & "','" & txtnorek.Text & "','" & txtbank.Text & "','" & txtcabbank.Text & "','" & txtalmtbank.Text & "','" & txtnmrek.Text & "','" & txtpichr.Text & "','" & txttimezone.Text & "')")
            MySql = New MySqlConnection(mysqlco)
            cmd = New MySqlCommand(str, mysql)
            Try
                MySql.Open()
                read = cmd.ExecuteReader()
                read.Read()
                MessageBox.Show("DATA TERSIMPAN")
                MySql.Close()
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
                txtposisi.Text = ""
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
        
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Autonumber()
    End Sub
End Class