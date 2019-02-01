-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: bookshop
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `books` (
  `id` varchar(20) NOT NULL,
  `name` varchar(50) NOT NULL,
  `author` varchar(30) DEFAULT NULL,
  `city` varchar(20) DEFAULT NULL,
  `publishing` varchar(20) DEFAULT NULL,
  `year` year(4) NOT NULL,
  `price_in` smallint(6) DEFAULT NULL,
  `price_out` smallint(6) DEFAULT NULL,
  `count` smallint(6) DEFAULT NULL,
  `rating_clients` float DEFAULT NULL,
  `rating_critic` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES ('9785040899357','Фрида Кало. Биография в комиксах','','','Эксмо',2018,397,345,122,4.5,4.16),('9785040903047','Messer / Нож. Лирика','Линдеманн Т.','','Бомбора',2018,719,625,189,4.8,4.5),('9785040958238','Дерево растет в Бруклине','Смит Б.','','Эксмо',2018,389,338,302,4.12,3.98),('9785040964840','Музыка ветра','Уайт К.','','Эксмо',2018,389,338,382,4.2,4.11),('9785040970186','Мертвое озеро','Кейн Р.','','Эксмо',2018,333,289,330,5.4,5.28),('9785040975167','Шесть пробуждений','Лафферти М.','','Fanzon',2018,397,345,348,3.1,2.65),('9785040976843','Долина драконов. Книга третья. Магическая сделка','Звездная Е.','','Эксмо',2018,289,346,80,5,4.2),('9785170913824','Метро 2033','Глуховский Д.','Москва','АСТ',2015,428,587,27,4.46,4.8),('9785171061586','Леонардо да Винчи','Айзексон У.','','АСТ',2018,1017,884,177,4.8,3.31),('9785171071387','Письма 1853-1890','Ван Гог','','АСТ',2018,356,309,262,0,-1.37),('9785179826804','ПАНК 57','Дуглас П.','Москва','АСТ',2018,302,356,5,5,3.9),('9785353014355','Гарри Поттер и Орден Феникса','Роулинг Д.К.','Москва','Росмэн-Пресс',2011,150,300,50,4.8,4.3),('9785389137813','Дневник книготорговца','Байтелл Ш.','Москва','Азбука Бизнес',2018,400,424,0,4.2,4.56),('9785389138070','Тень ночи','Харкнесс Д.','','Азбука СПб',2018,446,388,77,5.7,5.03),('9785389140684','Вдовы','Ла Плант Л.','','Азбука',2018,403,350,61,0,-0.08),('9785389150256','Dragon Age. Призыв','Гейдер Д.','','Азбука',2018,330,287,169,5.15,4.51),('9785604151105','Охота на ведьм','','','Bubble',2018,429,373,74,0,-0.42),('9785699813513','Очаровательный кишечник','Эндерс Дж.','','Издательство Э',2017,409,355,193,4.34,3.23),('9785699993437','Гравити Фолз. Забытые легенды. Графический роман','','','Эксмо',2018,421,467,10,5,4.75),('9785864718056','Молитва морю','Хоссейни Х.','','Фантом Пресс',2018,314,273,316,5.1,4.49),('9785938788206','Думай и Богатей','Хилл Н.','Санкт-Петербург','Еврознак СПб',2017,188,219,22,4.14,4.1),('9785957331636','Культ предков. Сила нашей крови','Райдос В.','Санкт-Петербург','Весь СПб',2017,350,453,15,4.43,3.88),('9785961461015','Атлант расправил плечи (комплект из 3 книг)','Рэнд А.','','Альпина Паблишер',2018,1099,956,266,4.14,3.99);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `shop_id` int(11) NOT NULL,
  `time` datetime DEFAULT CURRENT_TIMESTAMP,
  `info` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=116 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (96,1,'2018-12-07 01:37:21','4 \"Думай и Богатей Хилл Н.\"\n1 \"Тень ночи Харкнесс Д.\"\n'),(97,1,'2018-12-11 17:54:19','1 \"Фрида Кало. Биография в комиксах \"\nСумма: 345'),(98,1,'2018-12-11 17:57:03','4 \"Фрида Кало. Биография в комиксах \"\nСумма: 1380'),(99,1,'2018-12-11 17:58:12','3 \"Метро 2033 Глуховский Д.\"\nСумма: 1761'),(100,1,'2018-12-11 18:00:04','3 \"Метро 2033 Глуховский Д.\"\nСумма: 1761'),(101,1,'2018-12-11 18:00:59','1 \"Метро 2033 Глуховский Д.\"\nСумма: 587'),(102,1,'2018-12-26 02:08:03','2 \"Метро 2033 Глуховский Д.\"\nСумма: 1174'),(103,1,'2018-12-26 02:08:47','3 \"Гарри Поттер и Орден Феникса Роулинг Д.К.\"\nСумма: 900'),(104,0,'2018-12-26 02:14:03','3 \"Гарри Поттер и Орден Феникса Роулинг Д.К.\"\nСумма: 29423 \"Шесть пробуждений Лафферти М.\"\nСумма: 29421 \"Вдовы Ла Плант Л.\"\nСумма: 29423 \"Думай и Богатей Хилл Н.\"\nСумма: 2942'),(105,0,'2019-01-01 18:48:39','2 \"Письма 1853-1890 Ван Гог\"\nСумма: 618'),(106,0,'2019-01-01 18:48:44','2 \"Письма 1853-1890 Ван Гог\"\nСумма: 16833 \"Очаровательный кишечник Эндерс Дж.\"\nСумма: 1683'),(107,0,'2019-01-01 18:52:14','2 \"Леонардо да Винчи Айзексон У.\"\nСумма: 1768'),(108,0,'2019-01-01 18:52:21','1 \"Гравити Фолз. Забытые легенды. Графический роман \"\nСумма: 467'),(109,0,'2019-01-01 18:52:55',''),(110,1,'2019-01-01 18:53:58','2 \"Музыка ветра Уайт К.\"\nСумма: 676'),(111,1,'2019-01-01 18:54:28','1 \"Тень ночи Харкнесс Д.\"\nСумма: 388'),(112,1,'2019-01-01 18:54:35','3 \"Культ предков. Сила нашей крови Райдос В.\"\nСумма: 1359'),(113,1,'2019-01-01 18:55:00','2 \"Гравити Фолз. Забытые легенды. Графический роман \"\nСумма: 14981 \"Думай и Богатей Хилл Н.\"\nСумма: 14981 \"Шесть пробуждений Лафферти М.\"\nСумма: 1498'),(114,1,'2019-01-01 19:01:56','2 \"Мертвое озеро Кейн Р.\"\nСумма: 578'),(115,0,'2019-01-01 19:04:02','2 \"Шесть пробуждений Лафферти М.\"\n1 \"Гарри Поттер и Орден Феникса Роулинг Д.К.\"\n1 \"Вдовы Ла Плант Л.\"\nСумма: 1340');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shops`
--

DROP TABLE IF EXISTS `shops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `shops` (
  `id` smallint(6) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `worktime` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shops`
--

LOCK TABLES `shops` WRITE;
/*!40000 ALTER TABLE `shops` DISABLE KEYS */;
INSERT INTO `shops` VALUES (0,'Пушкина 28','123124125','С пн по пятницу 9-22'),(1,'Курочкина 22','123124125','С пн по пятницу 9-22');
/*!40000 ALTER TABLE `shops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statistics`
--

DROP TABLE IF EXISTS `statistics`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `statistics` (
  `date` varchar(6) DEFAULT NULL,
  `book_id` varchar(20) DEFAULT NULL,
  `count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statistics`
--

LOCK TABLES `statistics` WRITE;
/*!40000 ALTER TABLE `statistics` DISABLE KEYS */;
INSERT INTO `statistics` VALUES ('122018','9785353014355',3),('12019','9785171071387',2),('12019','9785040975167',2),('12019','9785353014355',1),('12019','9785389140684',1);
/*!40000 ALTER TABLE `statistics` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `store`
--

DROP TABLE IF EXISTS `store`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `store` (
  `book_id` varchar(15) NOT NULL,
  `shop_id` smallint(6) NOT NULL,
  `count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `store`
--

LOCK TABLES `store` WRITE;
/*!40000 ALTER TABLE `store` DISABLE KEYS */;
INSERT INTO `store` VALUES ('9785040899357',0,28),('9785040899357',1,22),('9785040903047',0,8),('9785040903047',1,19),('9785040958238',0,16),('9785040958238',1,9),('9785040964840',0,3),('9785040964840',1,15),('9785040970186',0,20),('9785040970186',1,20),('9785040975167',0,13),('9785040975167',1,23),('9785040976843',0,29),('9785040976843',1,1),('9785170913824',0,25),('9785170913824',1,0),('9785171061586',0,27),('9785171061586',1,23),('9785171071387',0,21),('9785171071387',1,10),('9785179826804',0,3),('9785179826804',1,32),('9785353014355',0,3),('9785353014355',1,16),('9785389137813',0,69),('9785389137813',1,0),('9785389138070',0,2),('9785389138070',1,27),('9785389140684',0,14),('9785389140684',1,23),('9785389150256',0,29),('9785389150256',1,10),('9785604151105',0,3),('9785604151105',1,29),('9785699813513',0,8),('9785699813513',1,7),('9785699993437',0,27),('9785699993437',1,47),('9785864718056',0,8),('9785864718056',1,19),('9785938788206',0,24),('9785938788206',1,25),('9785957331636',0,8),('9785957331636',1,3),('9785961461015',0,15),('9785961461015',1,17);
/*!40000 ALTER TABLE `store` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-14 22:46:04
