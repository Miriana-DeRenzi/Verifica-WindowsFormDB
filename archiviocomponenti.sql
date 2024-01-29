-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 29, 2024 alle 11:45
-- Versione del server: 10.4.24-MariaDB
-- Versione PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `archiviocomponenti`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `lista`
--

CREATE TABLE `lista` (
  `Id` int(50) NOT NULL,
  `CodiceFarnell` int(50) NOT NULL,
  `CodiceProduttore` varchar(50) NOT NULL,
  `Quantità` int(50) NOT NULL,
  `Prezzo` varchar(50) NOT NULL,
  `Descrizione` varchar(100) NOT NULL,
  `Produttore` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `lista`
--

INSERT INTO `lista` (`Id`, `CodiceFarnell`, `CodiceProduttore`, `Quantità`, `Prezzo`, `Descrizione`, `Produttore`) VALUES
(1, 4208547, 'AR45', 10, '2,73', 'RIVELATORE; Tipo di Sviluppatore:Sviluppatore Posi', 'CIF'),
(2, 2907957, 'MC002734', 50, '1,29', ' \r\n 	\r\nUSB CABLE, 2.0 PLUG A-MICRO B, 6FT, BLK; Da Connettore a Connettore:Da spina tipo A a micro s', 'MULTICOMP'),
(3, 4148009, 'AR412', 5, '23.09', 'CLORURO FERRICO, 36C, 2.5L TANICA; Metodo di Erogazione:Barattolo; Gamma Prodotti:-; Sostanze Estrem', 'CIF'),
(4, 1123696, 'CK1050', 50, '1,97', 'INTERR., A 2 POLI, 6 POS, 0,15A, 250V; Num. Di Posizioni Interruttore:6 Posizioni; N° di Poli:2 Poli', 'LORLIN'),
(5, 3117069, 'LM358AP', 100, '0,241', 'IC, OP AMP, DUAL, 0.3V/US, 3000UV, PDIP8; Numero di Amplificatori:2 Amplificatori; Larghezza di Band', 'TEXAS INSTRUMENTS'),
(6, 2627992, 'NCP7815TG', 50, '0,493', 'REGOL. TENS. LIN. FISSA, 15V, 1A, TO-220; Tipo di Uscita:Fisso; Tensione di Ingresso Min:23V; Tensio', 'ON SEMICONDUCTOR'),
(7, 1716993, 'CTB1202/2BK', 100, '0,22', 'TERMINAL BLOCK, WIRE TO BRD, 2POS, 16AWG; Gamma Prodotti:CTB1202 Series; No. di Contatti:2Contatti; ', 'CAMDENBOSS'),
(8, 2346522, '35PK1000MEFCT810X20', 50, '0.41', 'CON. 1000µF, 35V, 20%; Capacità:1000µF; Tensione Nominale:35V; Gamma Prodotti:Serie PK; Tolleranza C', 'RUBYCON'),
(9, 2668407, 'DILB8P-223TLF', 100, '0.13', 'PRESA DIP, 8POS, 2FILE, 2.54MM, TH; No. di Contatti:8Contatti; Tipo di Connettore:Presa DIP; Distanz', 'AMPHENOL FCI'),
(10, 9470212, 'MRS25000C8062FCT00', 100, '0.06', 'RES, 80K6, 1%, 600MW, AXIAL, METAL FILM; Resistenza:80.6kohm; Gamma Prodotti:Serie MRS25; Livello di', 'VISHAY'),
(11, 9469915, 'MRS25000C7152FCT00', 100, '0.06', 'RES, 71K5, 1%, 600MW, AXIAL, METAL FILM; Resistenza:71.5kohm; Gamma Prodotti:Serie MRS25; Livello di', 'VISHAY'),
(12, 2329641, 'CFR25J20K', 100, '0.01', 'RESISTORE, CARBON , 20K, 0.33W, 5%; Resistenza:20kohm; Gamma Prodotti:Serie CFR; Livello di Potenza:', 'TE CONNECTIVITY / NEOHM'),
(13, 9469788, 'MRS25000C6491FCT00', 100, '0.06', 'RES, 6K49, 1%, 600MW, AXIAL, METAL FILM; Resistenza:6.49kohm; Gamma Prodotti:Serie MRS25; Livello di', 'VISHAY'),
(14, 2329501, 'CFR16J22K', 100, '0.01', 'RESISTORE, CARBON , 22K, 0,25W, 5%; Resistenza:22kohm; Gamma Prodotti:Serie CFR; Livello di Potenza:', 'TE CONNECTIVITY / NEOHM'),
(15, 2329947, 'LR0204F4K7', 100, '0.01', 'RESISTORE, METAL , 4K7, 0,25W, 1%; Resistenza:4.7kohm; Gamma Prodotti:Serie LR; Livello di Potenza:2', 'TE CONNECTIVITY / NEOHM'),
(16, 3399665, 'CFR16J1K5.', 100, '0.01', 'RES, 1K5, 0.25W, FILM CARBONIO; ', 'TE CONNECTIVITY / NEOHM'),
(17, 9466746, 'MRS25000C2321FCT00', 100, '0.06', 'RES, 2K32, 1%, 600MW, AXIAL, METAL FILM; Resistenza:2.32kohm; Gamma Prodotti:Serie MRS25; Livello di', 'VISHAY'),
(18, 2329866, 'LR0204F130K', 100, '0.01', 'RESISTORE, METAL , 130K, 0,25W, 1%; Resistenza:130kohm; Gamma Prodotti:Serie LR; Livello di Potenza:', 'TE CONNECTIVITY / NEOHM'),
(19, 1716996, 'CTB1202/5BK', 20, '0.72', 'TERMINAL BLOCK, WIRE TO BRD, 5POS, 16AWG; Gamma Prodotti:CTB1202 Series; No. di Contatti:5Contatti; ', 'CAMDENBOSS');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `lista`
--
ALTER TABLE `lista`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `lista`
--
ALTER TABLE `lista`
  MODIFY `Id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
