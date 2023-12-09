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
  `codigo` varchar(10) NOT NULL DEFAULT '',
  `id_libro` int(11) NOT NULL DEFAULT 0,
  `cantidad` int(11) NOT NULL DEFAULT 0,
  `estado` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idEjemplar`),
  UNIQUE KEY `codigo` (`codigo`),
  KEY `FK_ejemplares_libros` (`id_libro`),
  CONSTRAINT `FK_ejemplares_libros` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_Libro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.ejemplares: ~3 rows (aproximadamente)
INSERT INTO `ejemplares` (`idEjemplar`, `codigo`, `id_libro`, `cantidad`, `estado`) VALUES
	(1, '1234567888', 1, 2, 0),
	(3, '1222323480', 1, 2, 1),
	(11, 'EJ123', 1, 5, 1);

-- Volcando estructura para tabla dbbiblioteca.lectores
CREATE TABLE IF NOT EXISTS `lectores` (
  `idLector` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `dni` varchar(50) DEFAULT NULL,
  `domicilio` varchar(50) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `estado` int(11) DEFAULT NULL,
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
  `isbn` varchar(50) NOT NULL DEFAULT '',
  `nombre` varchar(50) NOT NULL DEFAULT '',
  `tipo` varchar(50) NOT NULL DEFAULT '',
  `editorial` varchar(50) NOT NULL DEFAULT '',
  `autor` varchar(50) NOT NULL DEFAULT '',
  `estado` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id_Libro`),
  UNIQUE KEY `isbn` (`isbn`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla dbbiblioteca.libros: ~79 rows (aproximadamente)
INSERT INTO `libros` (`id_Libro`, `isbn`, `nombre`, `tipo`, `editorial`, `autor`, `estado`) VALUES
	(1, 'sigma', 'El Quijore', 'Cuento', 'Bichitos', 'Pato', 1),
	(3, '9783161484100', 'El Libro Aleatorio', 'Ficción', 'Editorial Random', 'Autor Anónimo', 1),
	(4, '9780439554930', 'Aventuras en SQL-Land', 'Aventura', 'Editorial Fantástica', 'SQLman', 1),
	(5, '9788498381524', 'Misterio en la Base de Datos', 'Misterio', 'Editorial Misteriosa', 'Detective SQL', 1),
	(6, '9786077356232', 'La Gran Query', 'Aventura', 'Editorial SQL', 'Ana SQL', 1),
	(7, '9780553103540', 'Aprendiendo SQL Avanzado', 'Educación', 'Editorial Educativa', 'Profesor SQL', 1),
	(8, '9780061120084', 'SQL y la Piedra Filosofal', 'Fantasía', 'Editorial Mágica', 'J.K. RowLinq', 1),
	(9, '9780735619670', 'El Señor de las Consultas', 'Aventura', 'Editorial de la Tierra Media', 'J.R.R. Token', 1),
	(10, '9780545010221', 'El Código SQL Da Vinci', 'Misterio', 'Editorial Renacentista', 'Dan Brown-SQL', 1),
	(11, '9780374533557', 'El Libro de Consultas Perdido', 'Aventura', 'Editorial Desconocida', 'Autor Anónimo', 1),
	(12, '9780385336178', 'Orgullo y Prejuicio SQL', 'Clásico', 'Editorial Literaria', 'Jane Austen-SQL', 1),
	(13, '9780553293372', 'Cien Años de Soledad SQL', 'Realismo mágico', 'Editorial Macondo', 'Gabriel García Márquez-SQL', 1),
	(14, '9781400034772', 'SQL y Castigo', 'Clásico', 'Editorial Literaria Antigua', 'Fiódor Dostoyevski-SQL', 1),
	(15, '9780141439587', 'SQL Oliver Twist', 'Ficción', 'Editorial Victoriana', 'Charles Dickens-SQL', 1),
	(16, '9781451673319', 'SQL en la Pradera', 'Western', 'Editorial del Oeste', 'Laura Ingalls Wilder-SQL', 1),
	(17, '9780679764021', 'Amor en Tiempos de Consultas', 'Romance', 'Editorial Romántica', 'Gabriel García Márquez-SQL', 1),
	(18, '9781400082772', 'Harry Potter y la Consulta Secreta', 'Fantasía', 'Editorial Mágica', 'J.K. RowLinq', 1),
	(19, '9780140449276', 'La Consulta de Montecristo', 'Aventura', 'Editorial Clásica', 'Alejandro Dumas-SQL', 1),
	(20, '9780451524935', 'SQL de los Muertos', 'Horror', 'Editorial de Terror', 'H.P. Lovecraft-SQL', 1),
	(21, '9780141439846', 'SQL Moby Dick', 'Aventura', 'Editorial Marítima', 'Herman Melville-SQL', 1),
	(22, '9781435110394', 'La Iliada SQL', 'Épico', 'Editorial Antigua', 'Homero-SQL', 1),
	(23, '9780199536852', 'La Odisea de las Consultas', 'Épico', 'Editorial Clásica', 'Homero-SQL', 1),
	(24, '9780451526342', 'SQL Frankenstein', 'Terror', 'Editorial Gótica', 'Mary Shelley-SQL', 1),
	(25, '9780142437230', 'La Divina Consulta', 'Poema Épico', 'Editorial Celestial', 'Dante Alighieri-SQL', 1),
	(26, '9780521859555', 'SQL y la Teoría de la Relatividad', 'Ciencia', 'Editorial Científica', 'Albert Einstein-SQL', 1),
	(27, '9780307408797', 'La Metamorfosis de SQL', 'Ficción', 'Editorial Surrealista', 'Franz Kafka-SQL', 1),
	(28, '9788408068894', 'Cumbres Borrascosas de las Consultas', 'Romance', 'Editorial Romántica Clásica', 'Emily Brontë-SQL', 1),
	(29, '9788415118961', 'SQL: El Señor de los Anillos', 'Fantasía', 'Editorial de la Tierra Media', 'J.R.R. Tolkien-SQL', 1),
	(30, '9788498381525', 'El Juego del Tiempo', 'Fantasía', 'Editorial Fantástica', 'Autor Fantástico', 1),
	(31, '9780141185060', '1984', 'Ficción Distópica', 'Editorial Distópica', 'George Orwell', 1),
	(32, '9780307743138', 'Crimen y Castigo', 'Ficción Psicológica', 'Editorial Psicológica', 'Fiódor Dostoyevski', 1),
	(33, '9780061122414', 'El Gran Gatsby', 'Ficción Clásica', 'Editorial Clásica', 'F. Scott Fitzgerald', 1),
	(34, '9780062315007', 'El Alquimista', 'Ficción Inspiracional', 'Editorial Inspiracional', 'Paulo Coelho', 1),
	(35, '9780451524937', 'Moby Dick', 'Aventura Marina', 'Editorial Marina', 'Herman Melville', 1),
	(36, '9788408218509', 'Cien años de soledad', 'Realismo Mágico', 'Editorial Realista', 'Gabriel García Márquez', 1),
	(37, '9788483108599', 'El Principito', 'Fábula', 'Editorial Fabulosa', 'Antoine de Saint-Exupéry', 1),
	(38, '9788498381526', 'El Nombre del Viento', 'Fantasía Épica', 'Editorial Fantástica', 'Patrick Rothfuss', 1),
	(39, '9788408207749', 'La Sombra del Viento', 'Misterio', 'Editorial de Misterios', 'Carlos Ruiz Zafón', 1),
	(40, '9788466328853', 'Los Pilares de la Tierra', 'Histórica', 'Editorial Histórica', 'Ken Follett', 1),
	(41, '9788408168735', 'La Casa de los Espíritus', 'Realismo Mágico', 'Editorial Espiritual', 'Isabel Allende', 1),
	(42, '9788498381527', 'Rayuela', 'Novela', 'Editorial Narrativa', 'Julio Cortázar', 1),
	(43, '9788433960063', 'Crónica de una muerte anunciada', 'Ficción', 'Editorial Ficticia', 'Gabriel García Márquez', 1),
	(44, '9788497939006', 'Don Quijote de la Mancha', 'Clásico', 'Editorial Clásica Española', 'Miguel de Cervantes', 1),
	(45, '9788490624731', 'Patria', 'Ficción Histórica', 'Editorial Histórica Española', 'Fernando Aramburu', 1),
	(46, '9788408069105', 'El Laberinto de los Espíritus', 'Misterio', 'Editorial de Misterios', 'Carlos Ruiz Zafón', 1),
	(47, '9788423351022', 'Origen', 'Thriller', 'Editorial de Suspenso', 'Dan Brown', 1),
	(48, '9788420674179', 'El Aleph', 'Cuentos', 'Editorial de Cuentos', 'Jorge Luis Borges', 1),
	(49, '9788433979126', 'El Amor en los Tiempos del Cólera', 'Ficción Romántica', 'Editorial Romántica', 'Gabriel García Márquez', 1),
	(50, '9788499890951', 'Los Juegos del Hambre', 'Ficción Juvenil', 'Editorial Juvenil', 'Suzanne Collins', 1),
	(51, '9788408169558', 'La Trilogía de la Ciudad Blanca', 'Thriller', 'Editorial de Suspenso', 'Eva García Sáenz de Urturi', 1),
	(52, '9788490623475', 'La Templanza', 'Ficción Histórica', 'Editorial Histórica', 'María Dueñas', 1),
	(53, '9788420423927', 'Los Pilares de la Tierra', 'Ficción Histórica', 'Editorial Histórica', 'Ken Follett', 1),
	(54, '9788491052424', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(55, '9780141439518', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(56, '9788497593069', 'El Diario de Ana Frank', 'Biografía', 'Editorial Biográfica', 'Ana Frank', 1),
	(57, '9788432216145', 'Ana Frank: La Biografía', 'Biografía', 'Editorial Biográfica', 'Melissa Müller', 1),
	(58, '9788420745184', 'Las Mujeres de la Casa de la Esperanza', 'Ficción', 'Editorial Ficticia', 'Louisa May Alcott', 1),
	(61, '9788491052425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(64, '7788491052425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(65, '9780141439519', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(68, '7788691052425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(71, '7788691051425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(72, '2780141439519', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(73, '8788497593069', 'El Diario de Ana Frank', 'Biografía', 'Editorial Biográfica', 'Ana Frank', 1),
	(76, '8788691051425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(79, '8788691054425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(80, '5780141439519', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(83, '8788691664425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(86, '8788697764425', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(87, '9780141439999', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(88, '8788497593669', 'El Diario de Ana Frank', 'Biografía', 'Editorial Biográfica', 'Ana Frank', 1),
	(89, '1788432216145', 'Ana Frank: La Biografía', 'Biografía', 'Editorial Biográfica', 'Melissa Müller', 1),
	(92, '8788697767725', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(95, '5788697767725', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(96, '9780141139999', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(99, '9788697767728', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(102, '9788697787728', 'Mujercitas', 'Clásico', 'Editorial Clásica', 'Louisa May Alcott', 1),
	(103, '1780141139999', 'Hijas de la Esperanza (Secuela de Mujercitas)', 'Ficción', 'Editorial de Ficción', 'Louisa May Alcott', 1),
	(104, '8788497663669', 'El Diario de Ana Frank', 'Biografía', 'Editorial Biográfica', 'Ana Frank', 1);

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
