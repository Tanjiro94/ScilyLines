-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 12 avr. 2024 à 10:50
-- Version du serveur : 8.0.31
-- Version de PHP : 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sicilylinesc`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

DROP TABLE IF EXISTS `bateau`;
CREATE TABLE IF NOT EXISTS `bateau` (
  `ID` char(32) NOT NULL,
  `NOM` char(32) NOT NULL,
  `LONGUEUR` char(32) DEFAULT NULL,
  `LARGEUR` char(32) DEFAULT NULL,
  `VITESSE` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `civilite` char(10) NOT NULL,
  `nom` char(15) NOT NULL,
  `prenom` char(15) NOT NULL,
  `telephone` int DEFAULT NULL,
  `email` char(255) DEFAULT NULL,
  `pays` char(30) DEFAULT NULL,
  `ville` char(30) DEFAULT NULL,
  `motdepasse` char(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

DROP TABLE IF EXISTS `liaison`;
CREATE TABLE IF NOT EXISTS `liaison` (
  `id` int NOT NULL AUTO_INCREMENT,
  `duree` varchar(11) NOT NULL,
  `port_depart` int NOT NULL,
  `port_arrivee` int NOT NULL,
  `idSecteur` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk-depart` (`port_depart`),
  KEY `fk-arrivee` (`port_arrivee`),
  KEY `id` (`id`),
  KEY `duree` (`duree`),
  KEY `fk-Secteur` (`idSecteur`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`id`, `duree`, `port_depart`, `port_arrivee`, `idSecteur`) VALUES
(102, '2h', 4, 1, 2),
(103, '6h', 2, 1, 3),
(107, '8h', 2, 4, 3),
(109, '10h', 3, 1, 1),
(110, '1h', 2, 4, 2),
(111, '7h', 3, 1, 3),
(113, '22h', 2, 2, 2),
(114, '1h', 4, 3, 1),
(115, '1h', 1, 1, 2),
(117, '4h', 3, 2, 5),
(118, '8h', 3, 2, 5),
(119, '78h', 3, 2, 4),
(120, '', 1, 1, 5),
(121, '15h', 3, 3, 1),
(123, '12h', 2, 4, 5);

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

DROP TABLE IF EXISTS `port`;
CREATE TABLE IF NOT EXISTS `port` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`id`, `nom`) VALUES
(1, 'Palerme'),
(2, 'Ustica'),
(3, 'Stromboli'),
(4, 'Lipari');

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`id`, `nom`) VALUES
(1, 'Messine'),
(2, 'Millazo'),
(3, 'Napoli'),
(4, 'Lif'),
(5, 'Pub'),
(6, 'Pub');

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

DROP TABLE IF EXISTS `traversee`;
CREATE TABLE IF NOT EXISTS `traversee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` varchar(11) DEFAULT NULL,
  `heure` varchar(11) DEFAULT NULL,
  `id_liaison` int NOT NULL,
  `id_bateau` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk-liaison-traversee` (`id_liaison`),
  KEY `fk-bateau` (`id_bateau`)
) ENGINE=InnoDB AUTO_INCREMENT=51010 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`id`, `date`, `heure`, `id_liaison`, `id_bateau`) VALUES
(1, '1h', '2h', 1, 1),
(2, '1h', '2h', 1, 1),
(51006, '2021-09-21', '2h', 103, 1),
(51007, '2011-07-01', '1h', 102, 1),
(51008, '05-12-2022', '2h', 107, 1),
(51009, '05-02-2013', '4h', 111, 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `fk-arrivee` FOREIGN KEY (`port_arrivee`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `fk-depart` FOREIGN KEY (`port_depart`) REFERENCES `port` (`id`),
  ADD CONSTRAINT `fk-Secteur` FOREIGN KEY (`idSecteur`) REFERENCES `secteur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
