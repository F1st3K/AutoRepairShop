CREATE DATABASE  IF NOT EXISTS `auto_repair_shop` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `auto_repair_shop`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: auto_repair_shop
-- ------------------------------------------------------
-- Server version	5.6.51

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `OrderProducts`
--

DROP TABLE IF EXISTS `OrderProducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `OrderProducts` (
  `OrderId` int(11) NOT NULL,
  `ProductArcticle` varchar(100) NOT NULL,
  `Count` int(11) NOT NULL,
  PRIMARY KEY (`OrderId`,`ProductArcticle`),
  KEY `Product_idx` (`ProductArcticle`),
  CONSTRAINT `Order` FOREIGN KEY (`OrderId`) REFERENCES `Orders` (`Id`),
  CONSTRAINT `Product` FOREIGN KEY (`ProductArcticle`) REFERENCES `Products` (`Article`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OrderProducts`
--

LOCK TABLES `OrderProducts` WRITE;
/*!40000 ALTER TABLE `OrderProducts` DISABLE KEYS */;
/*!40000 ALTER TABLE `OrderProducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `OrderStatuses`
--

DROP TABLE IF EXISTS `OrderStatuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `OrderStatuses` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `OrderStatuses`
--

LOCK TABLES `OrderStatuses` WRITE;
/*!40000 ALTER TABLE `OrderStatuses` DISABLE KEYS */;
/*!40000 ALTER TABLE `OrderStatuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Orders`
--

DROP TABLE IF EXISTS `Orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Orders` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` datetime NOT NULL,
  `Code` varchar(6) NOT NULL,
  `UserInfoId` int(11) NOT NULL,
  `StatusId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `UserInfoId_idx` (`UserInfoId`),
  KEY `StatusId_idx` (`StatusId`),
  CONSTRAINT `StatusId` FOREIGN KEY (`StatusId`) REFERENCES `OrderStatuses` (`Id`),
  CONSTRAINT `UserInfoId` FOREIGN KEY (`UserInfoId`) REFERENCES `UsersInfo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Orders`
--

LOCK TABLES `Orders` WRITE;
/*!40000 ALTER TABLE `Orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `Orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ProductCategories`
--

DROP TABLE IF EXISTS `ProductCategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ProductCategories` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ProductCategories`
--

LOCK TABLES `ProductCategories` WRITE;
/*!40000 ALTER TABLE `ProductCategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `ProductCategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ProductManufacturers`
--

DROP TABLE IF EXISTS `ProductManufacturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ProductManufacturers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ProductManufacturers`
--

LOCK TABLES `ProductManufacturers` WRITE;
/*!40000 ALTER TABLE `ProductManufacturers` DISABLE KEYS */;
/*!40000 ALTER TABLE `ProductManufacturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ProductUnits`
--

DROP TABLE IF EXISTS `ProductUnits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ProductUnits` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ProductUnits`
--

LOCK TABLES `ProductUnits` WRITE;
/*!40000 ALTER TABLE `ProductUnits` DISABLE KEYS */;
/*!40000 ALTER TABLE `ProductUnits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Products`
--

DROP TABLE IF EXISTS `Products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Products` (
  `Article` varchar(100) NOT NULL,
  `Name` text NOT NULL,
  `Description` text,
  `Picture` text,
  `CategoryId` int(11) NOT NULL,
  `ManufacturerId` int(11) NOT NULL,
  `UnitId` int(11) NOT NULL,
  `QuantityInStock` int(11) NOT NULL,
  `Discount` decimal(4,4) NOT NULL,
  `Price` int(11) NOT NULL,
  PRIMARY KEY (`Article`),
  UNIQUE KEY `Article_UNIQUE` (`Article`),
  KEY `CategoryId_idx` (`CategoryId`),
  KEY `ManufacturerId_idx` (`ManufacturerId`),
  KEY `UnitId_idx` (`UnitId`),
  CONSTRAINT `CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `ProductCategories` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ManufacturerId` FOREIGN KEY (`ManufacturerId`) REFERENCES `ProductManufacturers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `UnitId` FOREIGN KEY (`UnitId`) REFERENCES `ProductUnits` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Products`
--

LOCK TABLES `Products` WRITE;
/*!40000 ALTER TABLE `Products` DISABLE KEYS */;
/*!40000 ALTER TABLE `Products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UserRoles`
--

DROP TABLE IF EXISTS `UserRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `UserRoles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UserRoles`
--

LOCK TABLES `UserRoles` WRITE;
/*!40000 ALTER TABLE `UserRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `UserRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Login` text NOT NULL,
  `Hash` text NOT NULL,
  `RoleId` int(11) NOT NULL,
  `InfoId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RoleId_idx` (`RoleId`),
  KEY `InfoId_idx` (`InfoId`),
  CONSTRAINT `InfoId` FOREIGN KEY (`InfoId`) REFERENCES `UsersInfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `RoleId` FOREIGN KEY (`RoleId`) REFERENCES `UserRoles` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UsersInfo`
--

DROP TABLE IF EXISTS `UsersInfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `UsersInfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Surname` text NOT NULL,
  `Patronymic` text,
  `DataOfBirth` date NOT NULL,
  `Phone` int(10) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UsersInfo`
--

LOCK TABLES `UsersInfo` WRITE;
/*!40000 ALTER TABLE `UsersInfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `UsersInfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-13 11:46:49
