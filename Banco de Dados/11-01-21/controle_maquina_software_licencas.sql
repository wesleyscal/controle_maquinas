-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: controle_maquina
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
-- Table structure for table `software_licencas`
--

DROP TABLE IF EXISTS `software_licencas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `software_licencas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `software` varchar(450) NOT NULL,
  `key` varchar(450) NOT NULL,
  `qtd` int NOT NULL,
  `qtdmax` int NOT NULL,
  `nfe` varchar(450) NOT NULL,
  `observacao` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `software_licencas`
--

LOCK TABLES `software_licencas` WRITE;
/*!40000 ALTER TABLE `software_licencas` DISABLE KEYS */;
INSERT INTO `software_licencas` VALUES (1,'OFFICE 2013','R6YVN-2YKXQ-337M9-HCJV3-YBFP3',0,1,'Informar',''),(2,'OFFICE 2013','KXNYR-TDK47-7WJ69-9T4Y3-Y4DTQ',0,1,'Informar',''),(3,'OFFICE 2013','QM78N-4W7PF-TMC6J-DFV9V-CYQTQ',0,1,'Informar',''),(4,'OFFICE 2013','TBN2J-HDPBY-4CQWJ-CYY4Y-HT7GQ',0,1,'Informar',''),(5,'OFFICE 2013','VNJ86-M2KVQ-T6MMJ-QTPPV-JQHGQ',0,1,'Informar',''),(6,'OFFICE 2013','G9NB7-CXH74-KBPXH-H96PD-G8X6Q',0,1,'Informar',''),(7,'OFFICE 2013','YHDQ2-RBNKY-MTWBT-VYDVX-H496Q',0,1,'Informar',''),(8,'OFFICE 2013','HQKBN-RPJFQ-DJCJB-2GKXP-7496Q',0,1,'Informar',''),(9,'OFFICE 2013','3C6FG-QNRXG-FKDTQ-3X63T-QYFP3',0,1,'Informar',''),(10,'OFFICE 2013','BQYNP-DJPDX-3P924-WJRGK-3RPXD',0,1,'Informar',''),(11,'OFFICE 2013','V8DN6-228C7-RVYDB-J8XHX-TFY23',0,1,'Informar',''),(12,'OFFICE 2013','XPNGG-4TJ9M-PX3KJ-DT7GY-RCW9D',0,1,'Informar',''),(13,'OFFICE 2013','G8F9N-BVKXK-9KK7V-3WHPF-367GQ',0,1,'Informar',''),(14,'OFFICE 2013','7PJ7X-XNVJ7-9Q4FX-PTKV4-K4PXD',0,1,'Informar',''),(15,'OFFICE 2013','3B63N-2WKVQ-P49G4-4VX3F-3C8C3',1,1,'Informar',''),(16,'OFFICE 2013','MP7CN-WRR49-Q39V2-VJQVY-F889D',0,1,'Informar',''),(17,'OFFICE 2013','FNCCB-BK26Y-C2RCH-8V6YV-GCK6Q',1,1,'Informar',''),(18,'OFFICE 2013','377ND-CG2V4-6KWDF-PXGTX-4JM23',0,1,'Informar',''),(19,'OFFICE 2013','NYRCK-66H3G-68TVY-V9FVJ-VH3TQ',1,1,'Informar',''),(20,'OFFICE 2016','4WCNM-QMMF9-BPQQ2-7PP6B-BBH39',0,1,'Informarw',''),(21,'OFFICE 2016','QGFXX-4VNP9-RXMD4-94GY2-PGYQ9',0,1,'Informar',''),(22,'OFFICE 2016','DCNJM-PDBRR-9JDC9-9F2Y4-R3KVX',0,1,'Informar',''),(23,'OFFICE 2016','CF4NX-D3YTY-PFQDQ-QT92D-WQKVX',0,1,'Informar',''),(24,'OFFICE 2016','Y7M7G-MKND9-DMV2B-KQRT6-P7JYK',0,1,'Informar',''),(25,'OFFICE 2016','GHXXM-MNRHM-BY6X7-F746M-VQWYK',0,1,'Informar',''),(28,'WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3',0,44,'Informar',''),(29,'WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM',3,8,'Informar',''),(58,'OFFICE 365','admin@cristalaco.onmicrosoft.com',0,2,'Não Informado','------------------------------------------------------------------VaitomarnoCU@4X'),(59,'AUTOCAD LT','lucas@cristalaco.com.br',0,4,'Não Informado','ttps://manage.autodesk.com/cep/'),(60,'Product Design & Manufacturing Collection',' lucas@cristalaco.com.br',0,3,'Não Informado','ttps://manage.autodesk.com/cep/'),(61,'WBCcad','cristal.2015',10,10,'Não Informado','http://wbclicencas.azurewebsites.net/');
/*!40000 ALTER TABLE `software_licencas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-11 17:50:20
