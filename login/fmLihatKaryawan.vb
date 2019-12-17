Imports MySql.Data.MySqlClient

Public Class fmLihatKaryawan

    Public id As String

    Private Sub fmLihatKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysqlco As String
        Dim cmd As MySqlCommand
        Dim MySql As MySqlConnection
        mysqlco = "server=localhost;user id=root;database=spk"
        Dim query As String
        query = "SELECT * FROM karyawan ORDER BY id DESC"
        da = New MySqlDataAdapter(query, mysqlco)
        MySql = New MySqlConnection(mysqlco)
        cmd = New MySqlCommand(str, MySql)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            fmkaryawan.txtno.Text = row.Cells("id").Value.ToString
            fmkaryawan.txtnik.Text = row.Cells("nik").Value.ToString
            fmkaryawan.txtnama.Text = row.Cells("nama").Value.ToString
            fmkaryawan.tgl_lahir.Text = row.Cells("tgl_lahir").Value.ToString
            fmkaryawan.txtktlahir.Text = row.Cells("kota_lahir").Value.ToString
            fmkaryawan.txtagama.Text = row.Cells("agama").Value.ToString
            fmkaryawan.txtjnskelamin.Text = row.Cells("jns_klmn").Value.ToString
            fmkaryawan.txtalamat.Text = row.Cells("alamat").Value.ToString
            fmkaryawan.txtkota.Text = row.Cells("kota").Value.ToString
            fmkaryawan.txtsuku.Text = row.Cells("suku").Value.ToString
            fmkaryawan.txtnoktp.Text = row.Cells("no_ktp").Value.ToString
            fmkaryawan.txttglktp.Text = row.Cells("tgl_berlaku_ktp").Value.ToString
            fmkaryawan.txtnokk.Text = row.Cells("no_kk").Value.ToString
            fmkaryawan.txtnonpwp.Text = row.Cells("no_npwp").Value.ToString
            fmkaryawan.txtnogsm.Text = row.Cells("no_gsm").Value.ToString
            fmkaryawan.txtemail.Text = row.Cells("email").Value.ToString
            fmkaryawan.txtibu.Text = row.Cells("nm_ibu").Value.ToString
            fmkaryawan.txtgoldar.Text = row.Cells("gol_darah").Value.ToString
            fmkaryawan.txtbpjs.Text = row.Cells("no_bpjs").Value.ToString
            fmkaryawan.txtbpjs.Text = row.Cells("tgl_bpjs").Value.ToString
            fmkaryawan.txtjamsostek.Text = row.Cells("no_jamsostek").Value.ToString
            fmkaryawan.tgl_jamsostek.Text = row.Cells("tgl_jamsostek").Value.ToString
            fmkaryawan.txtfaskes.Text = row.Cells("kd_faskes").Value.ToString
            fmkaryawan.txtfaskesgg.Text = row.Cells("kd_faskes_gigi").Value.ToString
            fmkaryawan.txtstatnikah.Text = row.Cells("sts_nikah").Value.ToString
            fmkaryawan.tgl_nikah.Text = row.Cells("tgl_nikah").Value.ToString
            fmkaryawan.txtanak.Text = row.Cells("jml_anak").Value.ToString
            fmkaryawan.txtssnkeluarga.Text = row.Cells("susunan_klrg").Value.ToString
            fmkaryawan.txtstattngkerja.Text = row.Cells("sts_tng_krj").Value.ToString
            fmkaryawan.txtobjekid.Text = row.Cells("objek_id").Value.ToString
            fmkaryawan.txtposisi.Text = row.Cells("posisi").Value.ToString
            fmkaryawan.txttitle.Text = row.Cells("tittle").Value.ToString
            fmkaryawan.txtdirektorat.Text = row.Cells("direktorat").Value.ToString
            fmkaryawan.txtunit.Text = row.Cells("unit").Value.ToString
            fmkaryawan.txtsubunit.Text = row.Cells("sub_unit").Value.ToString
            fmkaryawan.txtsektor.Text = row.Cells("sektor").Value.ToString
            fmkaryawan.txtrayon.Text = row.Cells("rayon").Value.ToString
            fmkaryawan.txtidpsa.Text = row.Cells("id_psa").Value.ToString
            fmkaryawan.txtnmpsa.Text = row.Cells("nm_psa").Value.ToString
            fmkaryawan.txtwitel.Text = row.Cells("witel").Value.ToString
            fmkaryawan.txtteritory.Text = row.Cells("teritori").Value.ToString
            fmkaryawan.txtregional.Text = row.Cells("regional").Value.ToString
            fmkaryawan.txtstatkerja.Text = row.Cells("sts_kerja").Value.ToString
            fmkaryawan.txtlamaojt.Text = row.Cells("lama_ojt").Value.ToString
            fmkaryawan.txtstatinduksi.Text = row.Cells("sts_induksi").Value.ToString
            fmkaryawan.tgl_mulai_krj.Text = row.Cells("tgl_kerja").Value.ToString
            fmkaryawan.tgl_kontrak_1.Text = row.Cells("tgl_kontrak_pertama").Value.ToString
            fmkaryawan.tgl_aw_kontrak.Text = row.Cells("tgl_awal_kontrak").Value.ToString
            fmkaryawan.tgl_akh_kontrak.Text = row.Cells("tgl_akhir_kontrak").Value.ToString
            fmkaryawan.txtthnkontrak.Text = row.Cells("tahun_kontrak").Value.ToString
            fmkaryawan.txtbandpss.Text = row.Cells("band_posisi").Value.ToString
            fmkaryawan.tgl_band_pss.Text = row.Cells("tgl_band_posisi").Value.ToString
            fmkaryawan.txtlevel.Text = row.Cells("level").Value.ToString
            fmkaryawan.tgl_level.Text = row.Cells("tgl_level").Value.ToString
            fmkaryawan.txtstatpj.Text = row.Cells("sts_pj").Value.ToString
            fmkaryawan.tgl_stat_pj.Text = row.Cells("tgl_sts_pj").Value.ToString
            fmkaryawan.tgl_fak_rmh.Text = row.Cells("tgl_fas_rmh").Value.ToString
            fmkaryawan.tgl_sel_fas.Text = row.Cells("tgl_sel_fas_rmh").Value.ToString
            fmkaryawan.tgl_aw_nop.Text = row.Cells("tgl_awal_nop").Value.ToString
            fmkaryawan.tgl_akh_nop.Text = row.Cells("tgl_akhir_nop").Value.ToString
            fmkaryawan.tgl_aw_cop.Text = row.Cells("tgl_awal_cop").Value.ToString
            fmkaryawan.tgl_akh_cop.Text = row.Cells("tgl_akhir_cop").Value.ToString
            fmkaryawan.txtlvlpend.Text = row.Cells("tgl_level_pend").Value.ToString
            fmkaryawan.txtjurusan.Text = row.Cells("jurusan").Value.ToString
            fmkaryawan.txtpenypend.Text = row.Cells("peny_pend").Value.ToString
            fmkaryawan.txtnorek.Text = row.Cells("no_rek").Value.ToString
            fmkaryawan.txtbank.Text = row.Cells("bank").Value.ToString
            fmkaryawan.txtcabbank.Text = row.Cells("kantor_cab").Value.ToString
            fmkaryawan.txtalmtbank.Text = row.Cells("alamat_bank").Value.ToString
            fmkaryawan.txtnmrek.Text = row.Cells("nama_rek").Value.ToString
            fmkaryawan.txtpichr.Text = row.Cells("pic_hr").Value.ToString
            fmkaryawan.txttimezone.Text = row.Cells("time_zone").Value.ToString
        End If
    End Sub
End Class