CREATE DATABASE  IF NOT EXISTS `controle_maquina_test` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `controle_maquina_test`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: controle_maquina_test
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `hardware`
--

DROP TABLE IF EXISTS `hardware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hardware` (
  `id` int NOT NULL AUTO_INCREMENT,
  `processador` varchar(450) NOT NULL,
  `memoria` varchar(450) NOT NULL,
  `armazenamento` varchar(450) NOT NULL,
  `gpu` varchar(450) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hardware`
--

LOCK TABLES `hardware` WRITE;
/*!40000 ALTER TABLE `hardware` DISABLE KEYS */;
INSERT INTO `hardware` VALUES (1,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(2,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(3,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(4,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(5,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(6,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(7,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(8,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(9,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(10,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(11,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(12,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(13,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(14,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(15,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(16,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(17,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(18,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(19,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(20,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(21,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(22,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(23,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(24,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(25,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(26,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(27,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(28,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(29,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(30,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(31,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(32,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(33,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(34,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(35,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(36,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(37,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(38,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(39,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(40,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(41,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(42,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(43,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(44,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(45,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(46,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(47,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(48,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(49,'Nao Informado','Nao Informado','Nao Informado','Nao Informado');
/*!40000 ALTER TABLE `hardware` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-30 15:17:41
