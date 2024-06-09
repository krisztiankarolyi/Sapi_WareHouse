-- --------------------------------------------------------
-- Host:                         mysql-65782-0.cloudclusters.net
-- Szerver verzió:               5.7.35-0ubuntu0.18.04.1 - (Ubuntu)
-- Szerver OS:                   Linux
-- HeidiSQL Verzió:              11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Adatbázis struktúra mentése a warehouse.
CREATE DATABASE IF NOT EXISTS `warehouse` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci */;
USE `warehouse`;

-- Struktúra mentése tábla warehouse. beszallitasok
CREATE TABLE IF NOT EXISTS `beszallitasok` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `atvevo` int(11) DEFAULT '0',
  `SzallitoLevel` varchar(50) COLLATE utf8_hungarian_ci DEFAULT '0',
  `termek_megnevezes` varchar(50) COLLATE utf8_hungarian_ci DEFAULT '0',
  `cikkszam` int(11) DEFAULT '0',
  `mennyiseg` int(11) DEFAULT '0',
  `datum` date DEFAULT NULL,
  `fizetve` int(11) DEFAULT '0',
  `egysegar` int(11) DEFAULT '0',
  `afa` int(11) DEFAULT '0',
  `brutto_koltseg` int(11) DEFAULT '0',
  `beszallito` varchar(50) COLLATE utf8_hungarian_ci DEFAULT '',
  PRIMARY KEY (`ID`),
  KEY `atvevo` (`atvevo`),
  CONSTRAINT `FK__dolgozok` FOREIGN KEY (`atvevo`) REFERENCES `dolgozok` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.beszallitasok: ~0 rows (hozzávetőleg)
DELETE FROM `beszallitasok`;
/*!40000 ALTER TABLE `beszallitasok` DISABLE KEYS */;
/*!40000 ALTER TABLE `beszallitasok` ENABLE KEYS */;

-- Struktúra mentése tábla warehouse. dolgozok
CREATE TABLE IF NOT EXISTS `dolgozok` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `fnev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '0',
  `jelszo` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '0',
  `teljes_nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '0',
  `felfuggesztve` varchar(50) COLLATE utf8_hungarian_ci DEFAULT 'nem',
  `admin` varchar(50) COLLATE utf8_hungarian_ci DEFAULT 'nem',
  `szuldat` date DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `fnev` (`fnev`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.dolgozok: ~3 rows (hozzávetőleg)
DELETE FROM `dolgozok`;
/*!40000 ALTER TABLE `dolgozok` DISABLE KEYS */;
INSERT INTO `dolgozok` (`ID`, `fnev`, `jelszo`, `teljes_nev`, `felfuggesztve`, `admin`, `szuldat`) VALUES
	(1, 'admin', '48KRsfCqvXmHsKAJGcOq6w==', 'Sapientia Admin', 'nem', 'igen', '2001-08-30');
/*!40000 ALTER TABLE `dolgozok` ENABLE KEYS */;

-- Struktúra mentése tábla warehouse. hianyok
CREATE TABLE IF NOT EXISTS `hianyok` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `termekID` int(11) NOT NULL DEFAULT '0',
  `dolgozo` int(11) NOT NULL DEFAULT '0',
  `mennyiseg` int(11) NOT NULL DEFAULT '0',
  `datum` date NOT NULL,
  `magyarazat` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `dolgozo` (`dolgozo`),
  KEY `cikkszam` (`termekID`) USING BTREE,
  CONSTRAINT `FK_hianyok_dolgozok` FOREIGN KEY (`dolgozo`) REFERENCES `dolgozok` (`ID`),
  CONSTRAINT `FK_hianyok_termekek` FOREIGN KEY (`termekID`) REFERENCES `termekek` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.hianyok: ~2 rows (hozzávetőleg)
DELETE FROM `hianyok`;
/*!40000 ALTER TABLE `hianyok` DISABLE KEYS */;
/*!40000 ALTER TABLE `hianyok` ENABLE KEYS */;

-- Struktúra mentése tábla warehouse. termekek
CREATE TABLE IF NOT EXISTS `termekek` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `cikkszam` int(11) NOT NULL,
  `megnevezes` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT '0',
  `kategoria` varchar(50) COLLATE utf8_hungarian_ci DEFAULT 'egyéb',
  `elozo_ho_keszlet` int(11) DEFAULT '0',
  `jelenleg_keszlet` int(11) DEFAULT '0',
  `leltariv` varchar(50) COLLATE utf8_hungarian_ci DEFAULT '0',
  `br_beszerzesi_ertek` int(11) DEFAULT '0',
  `osszkoltseg` int(11) DEFAULT '0',
  `netto_ertek` int(11) DEFAULT '0',
  `afa_kulcs` int(11) DEFAULT '0',
  `brutto_ertek` int(11) DEFAULT '0',
  `mertekegyseg` varchar(50) COLLATE utf8_hungarian_ci DEFAULT 'db',
  PRIMARY KEY (`ID`),
  KEY `cikkszam` (`cikkszam`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.termekek: ~2 rows (hozzávetőleg)
DELETE FROM `termekek`;
/*!40000 ALTER TABLE `termekek` DISABLE KEYS */;
/*!40000 ALTER TABLE `termekek` ENABLE KEYS */;

-- Struktúra mentése tábla warehouse. tobbletek
CREATE TABLE IF NOT EXISTS `tobbletek` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `termekID` int(11) NOT NULL DEFAULT '0',
  `dolgozo` int(11) DEFAULT NULL,
  `darabszam` int(11) NOT NULL DEFAULT '0',
  `magyarazat` varchar(50) COLLATE utf8_hungarian_ci DEFAULT '0',
  `datum` date DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `dolgozo` (`dolgozo`),
  KEY `cikkszam` (`termekID`) USING BTREE,
  CONSTRAINT `FK_kulonbsegek_dolgozok` FOREIGN KEY (`dolgozo`) REFERENCES `dolgozok` (`ID`),
  CONSTRAINT `FK_tobbletek_termekek` FOREIGN KEY (`termekID`) REFERENCES `termekek` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.tobbletek: ~0 rows (hozzávetőleg)
DELETE FROM `tobbletek`;
/*!40000 ALTER TABLE `tobbletek` DISABLE KEYS */;
/*!40000 ALTER TABLE `tobbletek` ENABLE KEYS */;

-- Struktúra mentése tábla warehouse. uzenetek
CREATE TABLE IF NOT EXISTS `uzenetek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `felado` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT 'system',
  `cimzett` varchar(50) COLLATE utf8_hungarian_ci NOT NULL DEFAULT 'system',
  `targy` varchar(50) COLLATE utf8_hungarian_ci DEFAULT 'nincs',
  `tartalom` varchar(200) COLLATE utf8_hungarian_ci DEFAULT 'Ez az üzenet üres.',
  `datum` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cimzett` (`cimzett`),
  KEY `felado` (`felado`),
  CONSTRAINT `FK_uzenetek_dolgozok` FOREIGN KEY (`felado`) REFERENCES `dolgozok` (`fnev`),
  CONSTRAINT `FK_uzenetek_dolgozok_2` FOREIGN KEY (`cimzett`) REFERENCES `dolgozok` (`fnev`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- Tábla adatainak mentése warehouse.uzenetek: ~2 rows (hozzávetőleg)
DELETE FROM `uzenetek`;
/*!40000 ALTER TABLE `uzenetek` DISABLE KEYS */;
/*!40000 ALTER TABLE `uzenetek` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
