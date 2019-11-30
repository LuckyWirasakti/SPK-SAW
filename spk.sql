-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 30 Nov 2019 pada 06.16
-- Versi server: 10.4.8-MariaDB
-- Versi PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spk`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `id` int(30) NOT NULL,
  `nik` varchar(30) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tgl_lahir` varchar(30) NOT NULL,
  `kota_lahir` varchar(30) NOT NULL,
  `agama` varchar(30) NOT NULL,
  `jns_klmn` varchar(30) NOT NULL,
  `alamat` varchar(30) NOT NULL,
  `kota` varchar(30) NOT NULL,
  `suku` varchar(30) NOT NULL,
  `no_ktp` varchar(30) NOT NULL,
  `tgl_berlaku_ktp` varchar(30) NOT NULL,
  `no_kk` varchar(30) NOT NULL,
  `no_npwp` varchar(30) NOT NULL,
  `no_gsm` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `nm_ibu` varchar(30) NOT NULL,
  `gol_darah` varchar(30) NOT NULL,
  `no_bpjs` varchar(30) NOT NULL,
  `tgl_bpjs` varchar(30) NOT NULL,
  `no_jamsostek` varchar(30) NOT NULL,
  `tgl_jamsostek` varchar(30) NOT NULL,
  `kd_faskes` varchar(30) NOT NULL,
  `kd_faskes_gigi` varchar(30) NOT NULL,
  `sts_nikah` varchar(30) NOT NULL,
  `tgl_nikah` varchar(30) NOT NULL,
  `jml_anak` varchar(30) NOT NULL,
  `susunan_klrg` varchar(30) NOT NULL,
  `sts_tng_krj` varchar(30) NOT NULL,
  `objek_id` varchar(30) NOT NULL,
  `posisi` varchar(30) NOT NULL,
  `tittle` varchar(30) NOT NULL,
  `direktorat` varchar(30) NOT NULL,
  `unit` varchar(30) NOT NULL,
  `sub_unit` varchar(30) NOT NULL,
  `sektor` varchar(30) NOT NULL,
  `rayon` varchar(30) NOT NULL,
  `id_psa` varchar(30) NOT NULL,
  `nm_psa` varchar(30) NOT NULL,
  `witel` varchar(30) NOT NULL,
  `teritori` varchar(30) NOT NULL,
  `regional` varchar(30) NOT NULL,
  `sts_kerja` varchar(30) NOT NULL,
  `lama_ojt` varchar(30) NOT NULL,
  `sts_induksi` varchar(30) NOT NULL,
  `tgl_kerja` varchar(30) NOT NULL,
  `tgl_kontrak_pertama` varchar(30) NOT NULL,
  `tgl_awal_kontrak` varchar(30) NOT NULL,
  `tgl_akhir_kontrak` varchar(30) NOT NULL,
  `tahun_kontrak` varchar(30) NOT NULL,
  `band_posisi` varchar(30) NOT NULL,
  `tgl_band_posisi` varchar(30) NOT NULL,
  `level` varchar(30) NOT NULL,
  `tgl_level` varchar(30) NOT NULL,
  `sts_pj` varchar(30) NOT NULL,
  `tgl_sts_pj` varchar(30) NOT NULL,
  `tgl_fas_rmh` varchar(30) NOT NULL,
  `tgl_sel_fas_rmh` varchar(30) NOT NULL,
  `tgl_awal_nop` varchar(30) NOT NULL,
  `tgl_akhir_nop` varchar(30) NOT NULL,
  `tgl_awal_cop` varchar(30) NOT NULL,
  `tgl_akhir_cop` varchar(30) NOT NULL,
  `level_pend` varchar(30) NOT NULL,
  `tgl_level_pend` varchar(30) NOT NULL,
  `jurusan` varchar(30) NOT NULL,
  `peny_pend` varchar(30) NOT NULL,
  `no_rek` varchar(30) NOT NULL,
  `bank` varchar(30) NOT NULL,
  `kantor_cab` varchar(30) NOT NULL,
  `alamat_bank` varchar(30) NOT NULL,
  `nama_rek` varchar(30) NOT NULL,
  `pic_hr` varchar(30) NOT NULL,
  `time_zone` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `kriteria`
--

CREATE TABLE `kriteria` (
  `id` int(11) NOT NULL,
  `kd_kriteria` varchar(5) NOT NULL,
  `nm_kriteria` varchar(30) NOT NULL,
  `bobot` decimal(10,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kriteria`
--

INSERT INTO `kriteria` (`id`, `kd_kriteria`, `nm_kriteria`, `bobot`) VALUES
(1, 'C1', 'Masa Jabatan', '0.25'),
(2, 'C2', 'Nilai Apraisal', '0.20'),
(3, 'C3', 'Nilai NKI', '0.20'),
(4, 'C4', 'Nilai Test', '0.20'),
(5, 'C4', 'Rekomendasi Atasan', '0.15');

-- --------------------------------------------------------

--
-- Struktur dari tabel `login`
--

CREATE TABLE `login` (
  `nama` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `login`
--

INSERT INTO `login` (`nama`, `username`, `password`) VALUES
('Lucky', 'a', 'a');

-- --------------------------------------------------------

--
-- Struktur dari tabel `normal`
--

CREATE TABLE `normal` (
  `idnilai` int(30) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tgl_mulai_kerja` varchar(30) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `ms_jab` double NOT NULL,
  `apraisal` double NOT NULL,
  `nki` double NOT NULL,
  `test` double NOT NULL,
  `rekom` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `normal`
--

INSERT INTO `normal` (`idnilai`, `nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `apraisal`, `nki`, `test`, `rekom`) VALUES
(1, '', '', '', 0.2, 0.5, 0.25, 0.75, 1),
(2, 'Lucky Adhikrisna Wirasakti', '2019-09-19', 'Tamu', 0.4, 0.75, 0.25, 0.75, 1),
(3, 'David', '2019-09-19', 'Tamu', 0.4, 0.5, 1.25, 1, 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `penilaian`
--

CREATE TABLE `penilaian` (
  `idnilai` int(30) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tgl_mulai_kerja` varchar(30) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `ms_jab` double NOT NULL,
  `apraisal` double NOT NULL,
  `nki` double NOT NULL,
  `test` double NOT NULL,
  `rekom` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penilaian`
--

INSERT INTO `penilaian` (`idnilai`, `nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `apraisal`, `nki`, `test`, `rekom`) VALUES
(1, 'Lucky Adhikrisna Wirasakti', '2019-09-19', 'Tamu', 1, 2, 1, 3, 1),
(2, 'Lucky Adhikrisna Wirasakti', '2019-09-19', 'Tamu', 2, 3, 1, 3, 1),
(3, 'David', '2019-09-19', 'Tamu', 2, 2, 5, 4, 1);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `kriteria`
--
ALTER TABLE `kriteria`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`nama`);

--
-- Indeks untuk tabel `normal`
--
ALTER TABLE `normal`
  ADD PRIMARY KEY (`idnilai`);

--
-- Indeks untuk tabel `penilaian`
--
ALTER TABLE `penilaian`
  ADD PRIMARY KEY (`idnilai`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `kriteria`
--
ALTER TABLE `kriteria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `normal`
--
ALTER TABLE `normal`
  MODIFY `idnilai` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `penilaian`
--
ALTER TABLE `penilaian`
  MODIFY `idnilai` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
