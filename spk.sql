-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 26, 2019 at 06:13 PM
-- Server version: 5.7.26
-- PHP Version: 7.2.18

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
-- Table structure for table `hasil`
--

DROP TABLE IF EXISTS `hasil`;
CREATE TABLE IF NOT EXISTS `hasil` (
  `idhasil` int(15) NOT NULL,
  `idnilai` int(15) NOT NULL,
  `nms_jab` varchar(30) NOT NULL,
  `napraisal` varchar(30) NOT NULL,
  `nnki` varchar(30) NOT NULL,
  `ntest` varchar(30) NOT NULL,
  `nrekom` varchar(30) NOT NULL,
  `preferensi` varchar(30) NOT NULL,
  PRIMARY KEY (`idhasil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `hitung`
--

DROP TABLE IF EXISTS `hitung`;
CREATE TABLE IF NOT EXISTS `hitung` (
  `hasil` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

DROP TABLE IF EXISTS `karyawan`;
CREATE TABLE IF NOT EXISTS `karyawan` (
  `id` int(30) NOT NULL AUTO_INCREMENT,
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
  `time_zone` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `kriteria`
--

DROP TABLE IF EXISTS `kriteria`;
CREATE TABLE IF NOT EXISTS `kriteria` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kd_kriteria` varchar(5) NOT NULL,
  `nm_kriteria` varchar(30) NOT NULL,
  `bobot` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kriteria`
--

INSERT INTO `kriteria` (`id`, `kd_kriteria`, `nm_kriteria`, `bobot`) VALUES
(1, 'C1', 'Masa Jabatan', '0.25'),
(2, 'C2', 'Nilai Apraisal', '0.20'),
(3, 'C3', 'Nilai NKI', '0.20'),
(4, 'C4', 'Nilai Test', '0.20'),
(5, 'C4', 'Rekomendasi Atasan', '0.15');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `nama` varchar(30) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(15) NOT NULL,
  PRIMARY KEY (`nama`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`nama`, `username`, `password`) VALUES
('lucky', 'a', 'a'),
('vira', 'vira', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `penilaian`
--

DROP TABLE IF EXISTS `penilaian`;
CREATE TABLE IF NOT EXISTS `penilaian` (
  `idnilai` int(30) NOT NULL AUTO_INCREMENT,
  `nama` varchar(30) NOT NULL,
  `tgl_mulai_kerja` varchar(30) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `ms_jab` double NOT NULL,
  `team_leader` double NOT NULL,
  `apraisal` double NOT NULL,
  `nki` double NOT NULL,
  `test` double NOT NULL,
  `rekom` double NOT NULL,
  PRIMARY KEY (`idnilai`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penilaian`
--

INSERT INTO `penilaian` (`idnilai`, `nama`, `tgl_mulai_kerja`, `jabatan`, `ms_jab`, `team_leader`, `apraisal`, `nki`, `test`, `rekom`) VALUES
(1, 'VARENSIUS ALFRIANTO LALLO', '2019-09-19', 'TEST', 5, 3, 3, 1, 3, 2),
(2, 'OCTAVIA RATU', '2019-09-19', 'TEST', 5, 5, 2, 3, 2, 1),
(3, 'ANGGA WAHYU PRASETYO', '2019-09-19', 'TEST', 5, 5, 4, 3, 4, 1),
(4, 'ZAINAL BARAWASI', '2019-09-19', 'TEST', 4, 4, 2, 3, 2, 2),
(5, 'JAINAL MAJID', '2019-09-19', 'TEST', 1, 1, 1, 2, 1, 1),
(6, 'DONATUS A. RUMBEWAS', '2019-09-19', 'TEST', 4, 4, 3, 2, 3, 1),
(7, 'HERY WIJAYA', '2019-09-19', 'TEST', 5, 5, 4, 3, 2, 1),
(8, 'SITI RAHMATIA USMAN', '2019-09-19', 'TEST', 5, 5, 4, 3, 4, 2),
(9, 'MAKHPUD', '2019-09-19', 'TEST', 4, 4, 3, 3, 1, 1),
(10, 'SYARIF HIDAYATULLAH', '2019-09-19', 'TEST', 3, 3, 3, 4, 2, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
