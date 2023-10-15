CREATE DATABASE  IF NOT EXISTS `auto_repair_shop` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `auto_repair_shop`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: auto_repair_shop
-- ------------------------------------------------------
-- Server version	8.0.1-dmr-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `orderproducts`
--

DROP TABLE IF EXISTS `orderproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderproducts` (
  `OrderId` int(11) NOT NULL,
  `ProductArcticle` varchar(100) NOT NULL,
  `Count` int(11) NOT NULL,
  PRIMARY KEY (`OrderId`,`ProductArcticle`),
  KEY `Product_idx` (`ProductArcticle`),
  CONSTRAINT `Order` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`Id`),
  CONSTRAINT `Product` FOREIGN KEY (`ProductArcticle`) REFERENCES `products` (`Article`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproducts`
--

LOCK TABLES `orderproducts` WRITE;
/*!40000 ALTER TABLE `orderproducts` DISABLE KEYS */;
/*!40000 ALTER TABLE `orderproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Date` datetime NOT NULL,
  `Code` varchar(6) NOT NULL,
  `UserInfoId` int(11) NOT NULL,
  `StatusId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `UserInfoId_idx` (`UserInfoId`),
  KEY `StatusId_idx` (`StatusId`),
  CONSTRAINT `StatusId` FOREIGN KEY (`StatusId`) REFERENCES `orderstatuses` (`Id`),
  CONSTRAINT `UserInfoId` FOREIGN KEY (`UserInfoId`) REFERENCES `usersinfo` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderstatuses`
--

DROP TABLE IF EXISTS `orderstatuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderstatuses` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderstatuses`
--

LOCK TABLES `orderstatuses` WRITE;
/*!40000 ALTER TABLE `orderstatuses` DISABLE KEYS */;
/*!40000 ALTER TABLE `orderstatuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcategories`
--

DROP TABLE IF EXISTS `productcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productcategories` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcategories`
--

LOCK TABLES `productcategories` WRITE;
/*!40000 ALTER TABLE `productcategories` DISABLE KEYS */;
/*!40000 ALTER TABLE `productcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productmanufacturers`
--

DROP TABLE IF EXISTS `productmanufacturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productmanufacturers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productmanufacturers`
--

LOCK TABLES `productmanufacturers` WRITE;
/*!40000 ALTER TABLE `productmanufacturers` DISABLE KEYS */;
/*!40000 ALTER TABLE `productmanufacturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
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
  CONSTRAINT `CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `productcategories` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ManufacturerId` FOREIGN KEY (`ManufacturerId`) REFERENCES `productmanufacturers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `UnitId` FOREIGN KEY (`UnitId`) REFERENCES `productunits` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productunits`
--

DROP TABLE IF EXISTS `productunits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productunits` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productunits`
--

LOCK TABLES `productunits` WRITE;
/*!40000 ALTER TABLE `productunits` DISABLE KEYS */;
/*!40000 ALTER TABLE `productunits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userroles`
--

DROP TABLE IF EXISTS `userroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userroles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userroles`
--

LOCK TABLES `userroles` WRITE;
/*!40000 ALTER TABLE `userroles` DISABLE KEYS */;
INSERT INTO `userroles` VALUES (1,'Администратор'),(2,'Клиент'),(3,'Менеджер');
/*!40000 ALTER TABLE `userroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Login` text NOT NULL,
  `Hash` text NOT NULL,
  `RoleId` int(11) NOT NULL,
  `InfoId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RoleId_idx` (`RoleId`),
  KEY `InfoId_idx` (`InfoId`),
  CONSTRAINT `InfoId` FOREIGN KEY (`InfoId`) REFERENCES `usersinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `RoleId` FOREIGN KEY (`RoleId`) REFERENCES `userroles` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'loginspYrbnLw','|7s\\lH',1,1),(2,'loginldoGOEoz','(/Gc9d',2,2),(3,'loginRhtTWOUL','KhYb+6',3,3),(4,'logingcncrrVt','0s9B?3',1,4),(5,'loginDzvxLMSh','qmv8Y\'',2,5),(6,'loginCYQDuzaQ','Hh!D5o',2,6),(7,'loginzomMHdGF','s9Y[\\o',2,7),(8,'loginGuWCekZh','7>jA0Q',2,8),(9,'loginOVzEPXBU','\\2^Kto',3,9),(10,'loginhipKwVOG','S+48Pi',3,10),(11,'loginnwlwfWJV',')1gI2A',2,11),(12,'loginOVeNFjgE','4n;Xi9',2,12),(13,'loginyOKpgezQ','5Y~LTp',3,13),(14,'loginUESqWqzL','3ND`fZ',2,14),(15,'loginaMJsWdgM','5+P(\'m',3,15),(16,'loginvuGEXFKp','(&`4Ae',2,16),(17,'loginUxkGoPcU','ra3H;i',3,17),(18,'loginnWgEsPpe','3b$)^Q',1,18),(19,'loginTVsxpeMc','3)5tvU',2,19),(20,'loginYabOqmdv','y3B:0f',3,20),(21,'loginGKqwoMPE','js>6iA',2,21),(22,'loginGJKRiwnt','DbtN3:',3,22),(23,'loginVsnulXby','Bb3}?J',1,23),(24,'loginFMAnHFef','lau0~F',3,24),(25,'loginjTqOFkyy','/Sn{1(',3,25),(26,'loginCHyWIOlj',']r%?',3,26),(27,'loginSIkLHbby','J3E}tH',2,27),(28,'loginvcoLQQkN','7@R?',3,28),(29,'loginBdKnwxIN','DO6qK[',2,29),(30,'loginvSwgUUih','0B7@ac',2,30),(31,'loginisNXixEd','Z{;`6n',3,31),(32,'loginpTETxfiz','r!oY9L',2,32),(33,'loginsMOeqMWQ','Rfd6\'J',1,33),(34,'loginQHLLmkPO','\\(7Xgc',2,34),(35,'loginRwzAWqja','7Q(g8V',2,35),(36,'loginWVlnNcct','OB9A~t',2,36),(37,'loginvusfELtV','8ENXz!',3,37),(38,'loginMGeaHwxR','#FPQd0',2,38),(39,'loginZWWWaLcM','.Zp`8f',1,39),(40,'loginenJEiQfp','1mZBe&',2,40),(41,'loginidXkPJEx','@1DuPH',2,41),(42,'loginHKUeAiwB','N=du[5',2,42),(43,'loginFdVBaklR','}aM^Y2',3,43),(44,'loginKkgzMnnI','*AZw\\0',2,44),(45,'loginhLnuFXRr','!C46nq',2,45),(46,'loginXPhXgGEx','O[8h;y',2,46),(47,'loginOUOyKWKd','Dor5:U',1,47),(48,'loginBwsFEXQF',')5HfU\\',2,48),(49,'loginIuXYFJAr','>St*n3',1,49),(50,'loginUiTtFkpE','*$8s^N',3,50);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usersinfo`
--

DROP TABLE IF EXISTS `usersinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usersinfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Surname` text NOT NULL,
  `Patronymic` text,
  `DataOfBirth` date NOT NULL,
  `Phone` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usersinfo`
--

LOCK TABLES `usersinfo` WRITE;
/*!40000 ALTER TABLE `usersinfo` DISABLE KEYS */;
INSERT INTO `usersinfo` VALUES (1,'Юрий','Астафьев','Владимирович','1998-03-05','+7(057)075-62-76'),(2,'Анна','Дроздова','Матвеевна','1979-04-05','+7(426)316-69-21'),(3,'Василиса','Леонова','Лукинична','1990-12-17','+7(285)107-20-46'),(4,'Арина','Королева','Константиновна','1994-08-05','+7(141)494-93-76'),(5,'Леонид','Логинов','Ильич','1994-01-30','+7(076)760-92-28'),(6,'Дарина','Рябова','Владимировна','1999-06-27','+7(279)849-06-08'),(7,'Матвей','Лебедев','Васильевич','2000-12-26','+7(962)396-40-31'),(8,'Сергей','Петров','Николаевич','1992-10-17','+7(072)606-68-69'),(9,'Варвара','Беляева','Марковна','1994-03-18','+7(086)579-87-37'),(10,'Анна','Попова','Леонидовна','1998-01-04','+7(787)680-41-50'),(11,'Светлана','Прохорова','Ярославовна','1974-02-08','+7(177)868-94-56'),(12,'Даниил','Соколов','Николаевич','1986-07-11','+7(133)067-44-52'),(13,'Екатерина','Жукова','Макаровна','1981-12-13','+7(104)296-41-35'),(14,'Екатерина','Наумова','Марковна','1983-12-30','+7(074)505-91-83'),(15,'Святослав','Лаптев','Владиславович','1978-10-09','+7(970)343-68-57'),(16,'Арина','Маркова','Вячеславовна','1985-06-14','+7(269)843-20-33'),(17,'Ангелина','Мальцева','Степановна','1985-06-21','+7(285)876-18-61'),(18,'Мила','Медведева','Святославовна','1971-08-18','+7(006)637-83-97'),(19,'Алиса','Шевелева','Михайловна','1997-01-06','+7(306)392-88-06'),(20,'Василий','Лебедев','Артёмович','1986-04-18','+7(141)119-28-48'),(21,'Маргарита','Колпакова','Ивановна','1984-05-04','+7(170)152-45-11'),(22,'Варвара','Соколова','Адамовна','1970-05-13','+7(413)195-24-65'),(23,'Сергей','Кожевников','Елисеевич','1977-04-09','+7(857)068-24-33'),(24,'Мария','Богданова','Макаровна','1986-06-12','+7(586)311-54-16'),(25,'Матвей','Голубев','Маркович','1995-05-11','+7(798)532-01-90'),(26,'София','Александрова','Александровна','1995-09-04','+7(720)164-53-59'),(27,'Глеб','Коротков','Александрович','2001-04-01','+7(640)145-02-95'),(28,'Варвара','Журавлева','Владимировна','1983-01-13','+7(261)699-89-60'),(29,'Всеволод','Тихомиров','Русланович','1986-08-25','+7(166)530-51-19'),(30,'Никита','Кузин','Андреевич','1974-12-05','+7(227)947-11-40'),(31,'Илья','Соболев','Егорович','1971-10-19','+7(203)368-97-45'),(32,'Фёдор','Смирнов','Иванович','1987-09-28','+7(735)978-70-04'),(33,'Егор','Федоров','Львович','1995-11-01','+7(027)315-44-61'),(34,'Александр','Петров','Платонович','1982-01-23','+7(070)232-81-26'),(35,'Вероника','Богданова','Александровна','1980-08-20','+7(964)096-84-90'),(36,'Элина','Егорова','Степановна','1973-10-10','+7(395)539-50-09'),(37,'Лука','Смирнов','Романович','1981-07-17','+7(327)557-44-35'),(38,'Мария','Никонова','Андреевна','1994-06-13','+7(764)335-37-00'),(39,'Диана','Старикова','Артёмовна','1974-01-23','+7(440)507-84-99'),(40,'Юлия','Исакова','Павловна','1987-06-04','+7(449)098-67-30'),(41,'Оливия','Руднева','Сергеевна','1978-08-26','+7(668)366-51-63'),(42,'Иван','Кириллов','Артёмович','1998-05-09','+7(704)041-51-65'),(43,'Эрик','Иванов','Иванович','1980-08-06','+7(664)224-33-19'),(44,'Анна','Ушакова','Павловна','1980-12-01','+7(550)144-94-91'),(45,'Дмитрий','Харитонов','Владимирович','1973-12-18','+7(430)058-69-09'),(46,'Фёдор','Миронов','Матвеевич','2002-11-03','+7(543)635-10-02'),(47,'Екатерина','Коновалова','Михайловна','1990-01-09','+7(621)226-66-62'),(48,'Эмилия','Горшкова','Семёновна','1980-09-03','+7(113)124-65-03'),(49,'Артур','Васильев','Вячеславович','1983-08-13','+7(545)773-98-42'),(50,'Руслан','Семенов','Миронович','1984-09-06','+7(078)603-81-60');
/*!40000 ALTER TABLE `usersinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-15 16:00:37