-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 03:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectmplid`
--

-- --------------------------------------------------------

--
-- Table structure for table `lamaran_panitia`
--

CREATE TABLE `lamaran_panitia` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `alamat` text DEFAULT NULL,
  `nomorHP` varchar(20) DEFAULT NULL,
  `divisi` varchar(50) DEFAULT NULL,
  `alasan_melamar` text DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Menunggu',
  `alasan_ditolak` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lamaran_panitia`
--

INSERT INTO `lamaran_panitia` (`id`, `nama`, `email`, `alamat`, `nomorHP`, `divisi`, `alasan_melamar`, `status`, `alasan_ditolak`) VALUES
(1, 'ajdbkajdbaiuodh', 'bakdjbaopidb', 'aldjbadioaidh', '1083198307', 'Marshal', 'jabdaobdipa', 'Ditolak', 'aodbaijdboaid'),
(2, 'Ridwan', 'ridwan@gmail.com', 'Jl. Suwandi', '085822787522', 'Caster', 'Bakat', 'Diterima', NULL),
(3, 'Ridwan', 'ridwan@gmail.com', 'JL Suwandi', '9730864194864', 'Master Of Ceremony', 'Mau aja', 'Diterima', NULL),
(4, 'Wahyu', 'wahyu@gmail.com', 'JL Perjuangan', '08911736', 'Team Production', 'Pengen juga', 'Diterima', NULL),
(5, 'Dzaki', 'dzaki@gmail,com', 'JL Anang Hasyim', '108319873', 'Analyst Match', 'Jago', 'Diterima', NULL),
(6, 'Asep', 'asep@gmail.com', 'JL Ahmad Yani', '10874380374', 'Caster', 'Saya menyukai gamenya dan tertartik untuk menjadi caster di game ini', 'Diterima', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `panitia`
--

CREATE TABLE `panitia` (
  `ID` int(11) NOT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(255) DEFAULT NULL,
  `NomorHP` varchar(20) DEFAULT NULL,
  `Divisi` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lamaran_panitia`
--
ALTER TABLE `lamaran_panitia`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `panitia`
--
ALTER TABLE `panitia`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `lamaran_panitia`
--
ALTER TABLE `lamaran_panitia`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `panitia`
--
ALTER TABLE `panitia`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
