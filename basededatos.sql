-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.28-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para dbbiblioteca
CREATE DATABASE IF NOT EXISTS `dbbiblioteca` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `dbbiblioteca`;

-- Volcando estructura para tabla dbbiblioteca.ejemplares
CREATE TABLE IF NOT EXISTS `ejemplares` (
  `idEjemplar` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(10) NOT NULL DEFAULT '0',
  `id_libro` int(11) NOT NULL DEFAULT 0,
  `cantidad` int(11) NOT NULL DEFAULT 0,
  `estado` varchar(30) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idEjemplar`),
  UNIQUE KEY `codigo` (`codigo`),
  KEY `FK__libros` (`id_libro`),
  CONSTRAINT `FK__libros` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_Libro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.ejemplares: ~20 rows (aproximadamente)
INSERT INTO `ejemplares` (`idEjemplar`, `codigo`, `id_libro`, `cantidad`, `estado`) VALUES
	(1, '1234567890', 1, 15, 'Disponible'),
	(2, '9876543210', 2, 8, 'Disponible'),
	(3, '4567890123', 3, 12, 'Disponible'),
	(4, '7890123456', 4, 5, 'Disponible'),
	(5, '5432109876', 5, 20, 'Disponible'),
	(6, '6543210987', 6, 10, 'Disponible'),
	(7, '2345678901', 7, 18, 'Disponible'),
	(8, '8901234567', 8, 7, 'Disponible'),
	(9, '3456789012', 9, 14, 'Disponible'),
	(10, '6789012345', 10, 3, 'Disponible'),
	(11, '5678901234', 12, 9, 'Disponible'),
	(13, '7590123456', 13, 6, 'Disponible'),
	(14, '3216987654', 14, 11, 'Disponible'),
	(15, '1018765432', 16, 4, 'Disponible'),
	(16, '5432169876', 17, 13, 'Disponible'),
	(17, '9876843210', 18, 16, 'Disponible'),
	(18, '2109376543', 19, 2, 'Disponible'),
	(19, '8765132109', 20, 10, 'Disponible'),
	(20, '1016765432', 21, 4, 'Disponible'),
	(21, '1045675432', 22, 14, 'Disponible');

-- Volcando estructura para tabla dbbiblioteca.lectores
CREATE TABLE IF NOT EXISTS `lectores` (
  `idLector` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `dni` varchar(50) DEFAULT NULL,
  `domicilio` varchar(50) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idLector`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.lectores: ~2 rows (aproximadamente)
INSERT INTO `lectores` (`idLector`, `apellido`, `nombre`, `dni`, `domicilio`, `telefono`, `estado`) VALUES
	(1, 'Vargar', 'Talerdo', '60262817', 'Las Mojarras', '3838452344', 1),
	(2, 'Caceres', 'Mateo', '45664000', 'La Loma', '3838498251', 1);

-- Volcando estructura para tabla dbbiblioteca.libros
CREATE TABLE IF NOT EXISTS `libros` (
  `id_Libro` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL DEFAULT '0',
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `tipo` varchar(50) NOT NULL DEFAULT '0',
  `editorial` varchar(50) NOT NULL DEFAULT '0',
  `autor` varchar(50) NOT NULL DEFAULT '0',
  `estado` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_Libro`),
  UNIQUE KEY `isbn` (`isbn`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.libros: ~20 rows (aproximadamente)
INSERT INTO `libros` (`id_Libro`, `isbn`, `nombre`, `tipo`, `editorial`, `autor`, `estado`) VALUES
	(1, '9780133594140', 'Introducción a la Programación', 'Programación', 'Editorial A', 'Autor A', 1),
	(2, '9780061120084', 'Cien años de soledad', 'Ficción', 'Editorial B', 'Gabriel García Márquez', 1),
	(3, '9780553382563', 'Dune', 'Ciencia Ficción', 'Editorial C', 'Frank Herbert', 1),
	(4, '9780743273565', 'The Great Gatsby', 'Ficción', 'Editorial D', 'F. Scott Fitzgerald', 1),
	(5, '9780380015399', 'To Kill a Mockingbird', 'Ficción', 'Editorial E', 'Harper Lee', 1),
	(6, '9780140283334', '1984', 'Ciencia Ficción', 'Editorial F', 'George Orwell', 1),
	(7, '9781400034772', 'The Da Vinci Code', 'Misterio', 'Editorial G', 'Dan Brown', 1),
	(8, '9780141439471', 'Pride and Prejudice', 'Ficción Romántica', 'Editorial H', 'Jane Austen', 1),
	(9, '9780451524935', 'The Catcher in the Rye', 'Ficción', 'Editorial I', 'J.D. Salinger', 1),
	(10, '9780060850524', 'The Hobbit', 'Fantasía', 'Editorial J', 'J.R.R. Tolkien', 1),
	(12, '9780743273365', 'The Great Gatsby', 'Ficción', 'Editorial K', 'F. Scott Fitzgerald', 1),
	(13, '9780812971069', 'The Kite Runner', 'Ficción', 'Editorial L', 'Khaled Hosseini', 1),
	(14, '9780452284244', 'The Road', 'Ficción', 'Editorial M', 'Cormac McCarthy', 1),
	(16, '9751400034772', 'The Da Vinci Code', 'Misterio', 'Editorial N', 'Dan Brown', 1),
	(17, '9780751524935', 'The Catcher in the Rye', 'Ficción', 'Editorial O', 'J.D. Salinger', 1),
	(18, '9880141439471', 'Pride and Prejudice', 'Ficción Romántica', 'Editorial P', 'Jane Austen', 1),
	(19, '9780112971069', 'The Kite Runner', 'Ficción', 'Editorial Q', 'Khaled Hosseini', 1),
	(20, '9780380045399', 'To Kill a Mockingbird', 'Ficción', 'Editorial R', 'Harper Lee', 1),
	(21, '9780140287334', '1984', 'Ciencia Ficción', 'Editorial S', 'George Orwell', 1),
	(22, '9780061121084', 'Cien años de soledad', 'Ficción', 'Editorial T', 'Gabriel García Márquez', 1);

-- Volcando estructura para tabla dbbiblioteca.prestamos
CREATE TABLE IF NOT EXISTS `prestamos` (
  `idPrestamo` int(11) NOT NULL AUTO_INCREMENT,
  `id_lector` int(11) DEFAULT NULL,
  `id_ejemplar` int(11) DEFAULT NULL,
  `fechaPrestamo` date DEFAULT NULL,
  `fechaEntrega` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrestamo`),
  KEY `FK_prestamos_lectores` (`id_lector`),
  KEY `FK_prestamos_ejemplares` (`id_ejemplar`),
  CONSTRAINT `FK_prestamos_ejemplares` FOREIGN KEY (`id_ejemplar`) REFERENCES `ejemplares` (`idEjemplar`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_prestamos_lectores` FOREIGN KEY (`id_lector`) REFERENCES `lectores` (`idLector`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.prestamos: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
