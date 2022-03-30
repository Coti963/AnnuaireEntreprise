-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 30 mars 2022 à 08:00
-- Version du serveur : 8.0.27
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `annuaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Prenom` varchar(255) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Telephone` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Service` varchar(255) NOT NULL,
  `Date_arrivee` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`ID`, `Prenom`, `Nom`, `Telephone`, `Service`, `Date_arrivee`) VALUES
(1, 'Leana', 'Meyer', '0584463929', 'INSEE', '2017-03-17'),
(2, 'Léane', 'Bernard', '0531505450', 'INSEE', '2004-02-02'),
(3, 'Loris', 'Laurent', '0412821811', 'INSEE', '2009-04-03'),
(4, 'Hélèna', 'Noel', '0335992009', 'INSEE', '2008-01-19'),
(5, 'Elia', 'Lopez', '0239922182', 'INSEE', '2019-02-24'),
(6, 'Noah', 'Rolland', '0595939721', 'INSEE', '2010-01-13'),
(7, 'Julien', 'Fleury', '0415118921', 'INSEE', '2017-11-18'),
(8, 'Apolline', 'Lambert', '0263456405', 'INSEE', '2002-07-05'),
(9, 'Noah', 'Masson', '0575442676', 'INSEE', '2009-03-18'),
(10, 'Angelo', 'Riviere', '0227581201', 'INSEE', '2010-05-04'),
(11, 'Simon', 'Leroux', '0337804847', 'INSEE', '2005-03-06'),
(12, 'Lucas', 'Schmitt', '0565747729', 'INSEE', '2014-01-18'),
(13, 'Kylian', 'Bourgeois', '0100769760', 'INSEE', '2019-04-12'),
(14, 'Sandra', 'Caron', '0166797199', 'INSEE', '2018-05-07'),
(15, 'Lenny', 'Leroux', '0236220797', 'INSEE', '2011-07-20'),
(16, 'Léandre', 'Fontai', '0358106807', 'INSEE', '2002-03-31');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
