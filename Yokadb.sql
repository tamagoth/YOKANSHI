-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.8-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para yokadb
CREATE DATABASE IF NOT EXISTS `yokadb` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_spanish_ci */;
USE `yokadb`;

-- Volcando estructura para tabla yokadb.catestados
CREATE TABLE IF NOT EXISTS `catestados` (
  `Id` int(11) NOT NULL,
  `Estado` varchar(50) COLLATE latin1_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.catestados: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `catestados` DISABLE KEYS */;
/*!40000 ALTER TABLE `catestados` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.talergias
CREATE TABLE IF NOT EXISTS `talergias` (
  `IDpaciente` int(11) DEFAULT NULL,
  `Descripcion` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  KEY `FK_talergias_tpacientes` (`IDpaciente`),
  CONSTRAINT `FK_talergias_tpacientes` FOREIGN KEY (`IDpaciente`) REFERENCES `tpacientes` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.talergias: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `talergias` DISABLE KEYS */;
/*!40000 ALTER TABLE `talergias` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tcitas
CREATE TABLE IF NOT EXISTS `tcitas` (
  `ID` int(11) NOT NULL,
  `IDPaciente` int(11) DEFAULT NULL,
  `IDDoctor` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `Detalle` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Nota` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Notas` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Status` int(11) DEFAULT NULL,
  `Peso` float DEFAULT NULL,
  `Estatura` float DEFAULT NULL,
  `Diagnostico` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  KEY `Índice 1` (`ID`),
  KEY `FK_tcitas_tpacientes` (`IDPaciente`),
  KEY `FK_tcitas_tusu` (`IDDoctor`),
  CONSTRAINT `FK_tcitas_tpacientes` FOREIGN KEY (`IDPaciente`) REFERENCES `tpacientes` (`ID`),
  CONSTRAINT `FK_tcitas_tusu` FOREIGN KEY (`IDDoctor`) REFERENCES `tusu` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.tcitas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tcitas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tcitas` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tclini
CREATE TABLE IF NOT EXISTS `tclini` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Estatus` int(11) NOT NULL,
  `Estado` varchar(50) COLLATE latin1_spanish_ci DEFAULT '',
  `Municipio` varchar(50) COLLATE latin1_spanish_ci DEFAULT '',
  `CP` varchar(10) COLLATE latin1_spanish_ci DEFAULT '',
  `Direccion` varchar(150) COLLATE latin1_spanish_ci DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.tclini: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tclini` DISABLE KEYS */;
/*!40000 ALTER TABLE `tclini` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tdocclin
CREATE TABLE IF NOT EXISTS `tdocclin` (
  `IDDoc` int(11) NOT NULL,
  `IDClin` int(11) NOT NULL,
  KEY `FK_tdocclin_tusu` (`IDDoc`),
  KEY `FK_tdocclin_tclini` (`IDClin`),
  CONSTRAINT `FK_tdocclin_tclini` FOREIGN KEY (`IDClin`) REFERENCES `tclini` (`Id`),
  CONSTRAINT `FK_tdocclin_tusu` FOREIGN KEY (`IDDoc`) REFERENCES `tusu` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.tdocclin: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tdocclin` DISABLE KEYS */;
/*!40000 ALTER TABLE `tdocclin` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tmedicina
CREATE TABLE IF NOT EXISTS `tmedicina` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Compuesto` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Presentacion` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `ReqRec` int(11) DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  KEY `Índice 1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.tmedicina: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tmedicina` DISABLE KEYS */;
/*!40000 ALTER TABLE `tmedicina` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tpacientes
CREATE TABLE IF NOT EXISTS `tpacientes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `ApellidoP` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `ApellidoM` varchar(100) COLLATE latin1_spanish_ci DEFAULT NULL,
  `FecNac` date DEFAULT NULL,
  `Email` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Sexo` int(11) DEFAULT NULL,
  `Pais` varchar(50) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Estado` int(11) DEFAULT NULL,
  `Comentarios` varchar(500) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Envio` int(11) DEFAULT NULL,
  KEY `Índice 1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.tpacientes: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tpacientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tpacientes` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.trecetad
CREATE TABLE IF NOT EXISTS `trecetad` (
  `ID` int(11) DEFAULT NULL,
  `IDMedicina` int(11) DEFAULT NULL,
  `Descripcion` varchar(150) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  KEY `FK_trecetad_trecetah` (`ID`),
  KEY `FK_trecetad_tmedicina` (`IDMedicina`),
  CONSTRAINT `FK_trecetad_tmedicina` FOREIGN KEY (`IDMedicina`) REFERENCES `tmedicina` (`ID`),
  CONSTRAINT `FK_trecetad_trecetah` FOREIGN KEY (`ID`) REFERENCES `trecetah` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.trecetad: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `trecetad` DISABLE KEYS */;
/*!40000 ALTER TABLE `trecetad` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.trecetah
CREATE TABLE IF NOT EXISTS `trecetah` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDCita` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `IDDoctor` int(11) DEFAULT NULL,
  `IDPaciente` int(11) DEFAULT NULL,
  `Total` float DEFAULT NULL,
  KEY `Índice 1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla yokadb.trecetah: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `trecetah` DISABLE KEYS */;
/*!40000 ALTER TABLE `trecetah` ENABLE KEYS */;

-- Volcando estructura para tabla yokadb.tusu
CREATE TABLE IF NOT EXISTS `tusu` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` varchar(30) COLLATE latin1_spanish_ci NOT NULL,
  `Nombre` varchar(80) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Apellidos` varchar(80) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Doctor` int(11) DEFAULT NULL,
  `Cedula` varchar(20) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Email` varchar(60) COLLATE latin1_spanish_ci DEFAULT NULL,
  `Admin` int(11) NOT NULL DEFAULT 0,
  `Pass` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  `Valid` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci COMMENT='Usuarios';

-- Volcando datos para la tabla yokadb.tusu: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tusu` DISABLE KEYS */;
INSERT INTO `tusu` (`ID`, `UserID`, `Nombre`, `Apellidos`, `Doctor`, `Cedula`, `Email`, `Admin`, `Pass`, `Valid`) VALUES
	(1, 'Admin', 'Admin', '', 0, '', '', 1, '21232f297a57a5a743894a0e4a801fc3', 1),
	(2, 'amendias', 'Agustin', 'Ayala', 0, '', 'agustin_layton@hotmail.com', 0, 'F869CE1C8414A264BB11E14A2C8850ED', 1),
	(3, 'cmeow', 'Clarita', 'Meow', 0, '', 'gato@hotmeow.com', 1, 'F869CE1C8414A264BB11E14A2C8850ED', 1),
	(4, 'mavalos', 'Maria del Rosario', 'Avalos', 0, '', 'm.rosario.avalos@outlook.com', 0, '739194B439A0F5C53CB457564049501F', 1);
/*!40000 ALTER TABLE `tusu` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

