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
  `ProductId` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  PRIMARY KEY (`OrderId`,`ProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproducts`
--

LOCK TABLES `orderproducts` WRITE;
/*!40000 ALTER TABLE `orderproducts` DISABLE KEYS */;
INSERT INTO `orderproducts` VALUES (3,1,0),(3,2,0),(4,2,0),(4,3,0),(5,20,0),(5,24,0),(5,25,0),(6,1,0),(6,2,0),(7,2,0),(7,3,0),(8,1,0),(9,1,0),(9,2,0),(9,3,0),(9,10,0),(9,11,0),(10,1,0),(11,1,0),(11,2,0),(12,2,0);
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
  `Date` text NOT NULL,
  `Code` varchar(6) NOT NULL,
  `Status` enum('Выполнен','Отменен') NOT NULL,
  `UserInfoId` int(11) NOT NULL,
  `Price` float NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'11.02.2000','QW201g','Выполнен',1,0),(2,'13.02.2000','FR345G','Отменен',5,0),(3,'19.10.2023 2:35:46','567013','Выполнен',0,4593),(4,'19.10.2023 2:36:59','0d6121','Выполнен',66,5136),(5,'19.10.2023 2:39:38','591b33','Выполнен',57,5150),(6,'19.10.2023 2:53:36','3749dd','Выполнен',2,5811),(7,'19.10.2023 2:55:07','cd91d8','Выполнен',0,10536),(8,'19.10.2023 2:55:50','d63f15','Выполнен',73,6750),(9,'19.10.2023 2:56:57','014c9c','Выполнен',0,8494.35),(10,'19.10.2023 3:04:30','35c4d7','Выполнен',14,16875),(11,'19.10.2023 3:07:57','c81940','Выполнен',73,12561),(12,'19.10.2023 3:08:54','905586','Выполнен',19,2436),(13,'19.10.2023 3:13:28','fd92ce','Выполнен',14,0);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcategories`
--

LOCK TABLES `productcategories` WRITE;
/*!40000 ALTER TABLE `productcategories` DISABLE KEYS */;
INSERT INTO `productcategories` VALUES (1,'Зарядные устройства'),(2,'Съемники подшипников'),(3,'Автозапчасти'),(4,'Ручные инструменты'),(5,'Аксессуары'),(6,'Автосервис');
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productmanufacturers`
--

LOCK TABLES `productmanufacturers` WRITE;
/*!40000 ALTER TABLE `productmanufacturers` DISABLE KEYS */;
INSERT INTO `productmanufacturers` VALUES (1,'KOLNER'),(2,'AIRLINE'),(3,'BIG FIGHTER'),(4,'STV'),(5,'JONNESWAY'),(6,'BOSCH'),(7,'TCL'),(8,'JTC'),(9,'GRASS'),(10,'SMART'),(11,'CHAMPION'),(12,'ALCA'),(13,'MOBIL'),(14,'EXPERT');
/*!40000 ALTER TABLE `productmanufacturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Article` varchar(100) NOT NULL,
  `Name` text NOT NULL,
  `Description` text,
  `Picture` text,
  `CategoryId` int(11) NOT NULL,
  `ManufacturerId` int(11) NOT NULL,
  `UnitId` int(11) NOT NULL,
  `QuantityInStock` int(11) NOT NULL,
  `Discount` decimal(4,4) NOT NULL,
  `Price` float NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Article_UNIQUE` (`Article`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'A782R4','Аккумулятор','Аккумулятор автомобильный 3 55р','A782R4.jpg',3,3,1,3,0.2500,4500),(2,'D374E4','Съемник подшипников','Съемник 2 AT-GP2-05','D374E4.jpeg',2,2,1,0,0.1300,1400),(3,'D799T6','Съемник подшипников','Съемник для подшипников 8 9000','picture.png',2,8,1,6,0.2500,1800),(4,'E679R3','Автошампунь','Автошампунь 9 800026 Active Foam Truck','picture.png',6,9,1,14,0.1000,4000),(5,'E932T8','Полироль','Полироль 9 125101 Black Brilliance','picture.png',6,9,1,23,0.0700,2100),(6,'F026R4','Антифриз','Антифриз сине-зеленый 13 ANTIFREEZE EXTRA','picture.png',6,13,1,13,0.1500,530),(7,'F938T5','Антифриз','Антифриз красный 7 LLC01212','picture.png',6,7,1,34,0.1500,1200),(8,'H572T6','Парктроник','Парктроник 2 APS-8L-02','picture.png',3,2,1,12,0.1000,2900),(9,'K702L6','Ключ','Ключ 5 W233032 (30 / 32 мм)','picture.png',4,5,1,9,0.1000,1600),(10,'K830R4','Колпак для колеса','Колпак для колеса 2 Супер Астра R16 серебристый 2шт','K830R4.jpg',3,2,2,14,0.3100,915),(11,'K849L6','Набор ключей','Набор ключей накидных 4 00-00010990 61','K849L6.jpeg',4,4,2,23,0.1000,780),(12,'L802Y5','Лопата','Лопата саперная 2 AB-S-03','picture.png',5,2,1,23,0.1000,870),(13,'O393R4','Отвертка','Отвертка 5 D04P2100','O393R4.jpeg',4,5,1,14,0.1200,460),(14,'P023T2','Провода прикуривания','Провода прикуривания в сумке 10 CABLE 700 4,5м','picture.png',3,10,1,6,0.2500,3400),(15,'P307T5','Провода прикуривания','Провода прикуривания в сумке 14 400А 2,5м','picture.png',3,14,1,2,0.2500,700),(16,'S021R4','Адаптер для щеток','Адаптер для щеток стеклоочистителя 12 Top Lock A/C блистер 2 шт','picture.png',3,12,2,13,0.2400,200),(17,'S037R9','Щетка','Щётка 2 AB-H-03','S037R9.jpeg',5,2,1,26,0.2000,740),(18,'S625T5','Щетка','щетка стеклоочистителя 12 Start 16\"/40см каркасная\"','picture.png',3,12,1,12,0.1200,249),(19,'S826R4','Щетка','Щетка стеклоочистителя 12 Super flat 19\"/48см бескаркасная\"','picture.png',3,12,1,28,0.2000,530),(20,'S983R4','Щетка','Щетка с/о 6 ECO 65C 650мм каркасная','S983R4.jpg',3,6,1,8,0.3000,500),(21,'V892T6','Свеча зажигания','Свеча зажигания 11 IGP F7RTC','picture.png',3,11,1,21,0.1500,130),(22,'Z326T9','Зарядное устройство','Устройство зарядное 14 ЗУ-300 6/12В 3,8А','picture.png',1,14,1,14,0.1000,2400),(23,'Z374R3','Зарядное устройство','Зарядное устройство 2 ACH-15A-08','Z374R3.jpeg',1,2,1,14,0.1500,4600),(24,'Z469T7','Устройство пуско-зарядное','Устройство пуско-зарядное 2 12В 8000мАч 350А','Z469T7.jpg',1,2,1,4,0.2500,4000),(25,'Z472R4','Зарядное устройство','Зарядное устройство 1 KBCН 4','Z472R4.jpeg',1,1,1,6,0.1200,1250);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productunits`
--

LOCK TABLES `productunits` WRITE;
/*!40000 ALTER TABLE `productunits` DISABLE KEYS */;
INSERT INTO `productunits` VALUES (1,'шт.'),(2,'уп.');
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
INSERT INTO `userroles` VALUES (1,'Администратор'),(2,'Менеджер'),(3,'Клиент');
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
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'loginspYrbnLw','|7s\\lH',1,0),(3,'loginRhtTWOUL','KhYb+6',3,3),(4,'logingcncrrVt','0s9B?3',1,4),(5,'loginDzvxLMSh','qmv8Y\'',2,5),(6,'loginCYQDuzaQ','Hh!D5o',2,6),(7,'loginzomMHdGF','s9Y[\\o',2,7),(8,'loginGuWCekZh','7>jA0Q',2,8),(9,'loginOVzEPXBU','\\2^Kto',3,9),(10,'loginhipKwVOG','S+48Pi',3,10),(11,'loginnwlwfWJV',')1gI2A',2,11),(12,'loginOVeNFjgE','4n;Xi9',2,12),(13,'loginyOKpgezQ','5Y~LTp',3,13),(14,'loginUESqWqzL','3ND`fZ',2,14),(15,'loginaMJsWdgM','5+P(\'m',3,15),(16,'loginvuGEXFKp','(&`4Ae',2,16),(17,'loginUxkGoPcU','ra3H;i',3,17),(18,'loginnWgEsPpe','3b$)^Q',1,18),(19,'loginTVsxpeMc','3)5tvU',2,19),(20,'loginYabOqmdv','y3B:0f',3,20),(21,'loginGKqwoMPE','js>6iA',2,21),(22,'loginGJKRiwnt','DbtN3:',3,22),(23,'loginVsnulXby','Bb3}?J',1,23),(24,'loginFMAnHFef','lau0~F',3,24),(25,'loginjTqOFkyy','/Sn{1(',3,25),(26,'loginCHyWIOlj',']r%?',3,26),(27,'loginSIkLHbby','J3E}tH',2,27),(28,'loginvcoLQQkN','7@R?',3,28),(29,'loginBdKnwxIN','DO6qK[',2,29),(30,'loginvSwgUUih','0B7@ac',2,30),(31,'loginisNXixEd','Z{;`6n',3,31),(32,'loginpTETxfiz','r!oY9L',2,32),(33,'loginsMOeqMWQ','Rfd6\'J',1,33),(34,'loginQHLLmkPO','\\(7Xgc',2,34),(35,'loginRwzAWqja','7Q(g8V',2,35),(36,'loginWVlnNcct','OB9A~t',2,36),(37,'loginvusfELtV','8ENXz!',3,37),(38,'loginMGeaHwxR','#FPQd0',2,38),(39,'loginZWWWaLcM','.Zp`8f',1,39),(40,'loginenJEiQfp','1mZBe&',2,40),(41,'loginidXkPJEx','@1DuPH',2,41),(42,'loginHKUeAiwB','N=du[5',2,42),(43,'loginFdVBaklR','}aM^Y2',3,43),(44,'loginKkgzMnnI','*AZw\\0',2,44),(45,'loginhLnuFXRr','!C46nq',2,45),(46,'loginXPhXgGEx','O[8h;y',2,46),(47,'loginOUOyKWKd','Dor5:U',1,47),(48,'loginBwsFEXQF',')5HfU\\',2,48),(49,'loginIuXYFJAr','>St*n3',1,49),(50,'loginUiTtFkpE','*$8s^N',3,50),(57,'login','parol',3,2),(59,'Alexd','qwertyui',2,0),(65,'admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',1,71),(66,'manager','6ee4a469cd4e91053847f5d3fcb61dbcc91e8f0ef10be7748da4c4a1ba382d17',2,72),(67,'user','04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb',3,73);
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
  `Patronymic` text NOT NULL,
  `DataOfBirth` text NOT NULL,
  `Phone` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usersinfo`
--

LOCK TABLES `usersinfo` WRITE;
/*!40000 ALTER TABLE `usersinfo` DISABLE KEYS */;
INSERT INTO `usersinfo` VALUES (1,'Юрий','Астафьев','Владимирович','05.03.1998','+7(057) 075-6276'),(2,'Неанна','Дроздова','Матвеевна','04.05.1979','+7(426) 316-6921'),(3,'Василиса','Леонова','Лукинична','1990-12-17','+7(285)107-20-46'),(4,'Арина','Королева','Константиновна','1994-08-05','+7(141)494-93-76'),(5,'Леонид','Логинов','Ильич','1994-01-30','+7(076)760-92-28'),(6,'Дарина','Рябова','Владимировна','1999-06-27','+7(279)849-06-08'),(7,'Матвей','Лебедев','Васильевич','2000-12-26','+7(962)396-40-31'),(8,'Сергей','Петров','Николаевич','1992-10-17','+7(072)606-68-69'),(9,'Варвара','Беляева','Марковна','1994-03-18','+7(086)579-87-37'),(10,'Анна','Попова','Леонидовна','1998-01-04','+7(787)680-41-50'),(11,'Светлана','Прохорова','Ярославовна','1974-02-08','+7(177)868-94-56'),(12,'Даниил','Соколов','Николаевич','1986-07-11','+7(133)067-44-52'),(13,'Екатерина','Жукова','Макаровна','1981-12-13','+7(104)296-41-35'),(14,'Екатерина','Наумова','Марковна','1983-12-30','+7(074)505-91-83'),(15,'Святослав','Лаптев','Владиславович','1978-10-09','+7(970)343-68-57'),(16,'Арина','Маркова','Вячеславовна','1985-06-14','+7(269)843-20-33'),(17,'Ангелина','Мальцева','Степановна','1985-06-21','+7(285)876-18-61'),(18,'Мила','Медведева','Святославовна','1971-08-18','+7(006)637-83-97'),(19,'Алиса','Шевелева','Михайловна','1997-01-06','+7(306)392-88-06'),(20,'Василий','Лебедев','Артёмович','1986-04-18','+7(141)119-28-48'),(21,'Маргарита','Колпакова','Ивановна','1984-05-04','+7(170)152-45-11'),(22,'Варвара','Соколова','Адамовна','1970-05-13','+7(413)195-24-65'),(23,'Сергей','Кожевников','Елисеевич','1977-04-09','+7(857)068-24-33'),(24,'Мария','Богданова','Макаровна','1986-06-12','+7(586)311-54-16'),(25,'Матвей','Голубев','Маркович','1995-05-11','+7(798)532-01-90'),(26,'София','Александрова','Александровна','1995-09-04','+7(720)164-53-59'),(27,'Глеб','Коротков','Александрович','2001-04-01','+7(640)145-02-95'),(28,'Варвара','Журавлева','Владимировна','1983-01-13','+7(261)699-89-60'),(29,'Всеволод','Тихомиров','Русланович','1986-08-25','+7(166)530-51-19'),(30,'Никита','Кузин','Андреевич','1974-12-05','+7(227)947-11-40'),(31,'Илья','Соболев','Егорович','1971-10-19','+7(203)368-97-45'),(32,'Фёдор','Смирнов','Иванович','1987-09-28','+7(735)978-70-04'),(33,'Егор','Федоров','Львович','1995-11-01','+7(027)315-44-61'),(34,'Александр','Петров','Платонович','1982-01-23','+7(070)232-81-26'),(35,'Вероника','Богданова','Александровна','1980-08-20','+7(964)096-84-90'),(36,'Элина','Егорова','Степановна','1973-10-10','+7(395)539-50-09'),(37,'Лука','Смирнов','Романович','1981-07-17','+7(327)557-44-35'),(38,'Мария','Никонова','Андреевна','1994-06-13','+7(764)335-37-00'),(39,'Диана','Старикова','Артёмовна','1974-01-23','+7(440)507-84-99'),(40,'Юлия','Исакова','Павловна','1987-06-04','+7(449)098-67-30'),(41,'Оливия','Руднева','Сергеевна','1978-08-26','+7(668)366-51-63'),(42,'Иван','Кириллов','Артёмович','1998-05-09','+7(704)041-51-65'),(43,'Эрик','Иванов','Иванович','1980-08-06','+7(664)224-33-19'),(44,'Анна','Ушакова','Павловна','1980-12-01','+7(550)144-94-91'),(45,'Дмитрий','Харитонов','Владимирович','1973-12-18','+7(430)058-69-09'),(46,'Фёдор','Миронов','Матвеевич','2002-11-03','+7(543)635-10-02'),(47,'Екатерина','Коновалова','Михайловна','1990-01-09','+7(621)226-66-62'),(48,'Эмилия','Горшкова','Семёновна','1980-09-03','+7(113)124-65-03'),(49,'Артур','Васильев','Вячеславович','1983-08-13','+7(545)773-98-42'),(50,'Руслан','Семенов','Миронович','1984-09-06','+7(078)603-81-60'),(51,'имя','фамилия','отчество','1999-09-06','+7(999)604-81-60'),(52,'имя','фамилия','отчество','1999-09-06','+7(999)604-81-60'),(54,'Федор','Ремизов','Генадьевич','2001-12-23','+7(678) 498-7634'),(58,'Владимир','Рудольфовичь','','2012-12-12','+7(   )    -'),(61,'Alex','Desty','','  .  .','+7(   )    -'),(63,'Артур','Михайлов','','  .  .','+7(   )    -'),(68,'Владими','Окунев','','  .  .','+7(   )    -'),(69,'Иван','Иваныч','','  .  .','+7(   )    -'),(70,'Иван','Иванович','','  .  .','+7(   )    -'),(71,'Никита','Костин','Костантинович','02.11.2005','+7(888) 444-4995'),(72,'Илья','Иванов','Александрович','19.04.1995','+7(546) 587-6545'),(73,'Федор','Ремизов','Генадьевичь','23.10.2000','+7(983) 456-9843'),(74,'Николай','Артеменко','','  .  .','+7(999) 450-6667'),(75,'Петр','Низов','Алексеевич','11.11.2000','+7(345) 678-8765');
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

-- Dump completed on 2023-10-19  3:25:14
