-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: controle_maquina
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `hardware`
--

DROP TABLE IF EXISTS `hardware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hardware` (
  `id` int NOT NULL AUTO_INCREMENT,
  `processador` varchar(450) NOT NULL,
  `memoria` varchar(450) NOT NULL,
  `armazenamento` varchar(450) NOT NULL,
  `gpu` varchar(450) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hardware`
--

LOCK TABLES `hardware` WRITE;
/*!40000 ALTER TABLE `hardware` DISABLE KEYS */;
INSERT INTO `hardware` (`id`, `processador`, `memoria`, `armazenamento`, `gpu`) VALUES (1,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(2,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(3,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(4,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(5,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(6,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(7,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(8,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(9,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(10,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(11,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(12,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(13,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(14,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(15,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(16,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(17,'Nao Informado','Nao Informado','SSD 120gb e HD','Nao Informado'),(18,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(19,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(20,'I7 - 3gen','Nao Informado','HD 512gb | ssd 32gb Chace','Onboard'),(21,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(22,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(23,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(24,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(25,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(26,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(27,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(28,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(29,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(30,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(31,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(32,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(33,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(34,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(35,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(36,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(37,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(38,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(39,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(40,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(41,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(42,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(43,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(44,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(45,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(46,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(47,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(48,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(49,'Nao Informado','Nao Informado','Nao Informado','Nao Informado'),(63,'i3 m350','3gb','120gb SSD','Não Tem');
/*!40000 ALTER TABLE `hardware` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maquina`
--

DROP TABLE IF EXISTS `maquina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maquina` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome_maquina` varchar(45) NOT NULL,
  `nome_dominio` varchar(45) NOT NULL,
  `nome_usuario` varchar(45) NOT NULL,
  `id_hardware` int DEFAULT NULL,
  `pc_and_note` varchar(45) NOT NULL,
  `observacao` varchar(45) DEFAULT NULL,
  `sistema_operacional` varchar(200) DEFAULT NULL,
  `keyos` varchar(450) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maquina`
--

LOCK TABLES `maquina` WRITE;
/*!40000 ALTER TABLE `maquina` DISABLE KEYS */;
INSERT INTO `maquina` (`id`, `nome_maquina`, `nome_dominio`, `nome_usuario`, `id_hardware`, `pc_and_note`, `observacao`, `sistema_operacional`, `keyos`) VALUES (1,'ALMOXARIFE-01','almoxarife01','FERNANDO',1,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(2,'ALMOXARIFE-02','almoxarife02','ALMOXARIFE FRENTE',2,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(3,'ALMOXARIFE-A01','almoxarifea01','ELIANDRO',3,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(4,'COMPRAS-01','compras01','RENATO',4,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(5,'COMPRAS-02','compras02','HENRIQUE',5,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(6,'CUSTO-01','custo01','FRANCISCO',6,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(7,'DIRETORIA-01','diretoria01','GILBERTO',7,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(8,'ENGEHARIA-05','engenharia-05','ANNANDA',8,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(9,'ENGENHARIA-01','engenharia01','JÚNIOR',9,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(10,'ENGENHARIA-02','engenharia02','ANDRÉ',10,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(11,'ENGENHARIA-03','engenharia03','GUILHERME',11,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(12,'ENGENHARIA-04','engenharia04','MAICON',12,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(13,'ENGENHARIA-A01','engenhariaa01','MARCELO',13,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(14,'FATURAMENTO-01','faturamento01','WANDER',14,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(15,'FATURAMENTO-F1','faturamentof1','SILAS',15,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(16,'FINANCEIRO-01','financeiro01','MÁRCIO',16,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(17,'FINANCEIRO-02','financeiro02','DANIEL',17,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(18,'FINANCEIRO-03','financeiro03','LETÍCIA',18,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(19,'FINANCEIRO-04','financeiro04','MURILO CARDOSO',19,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(20,'FINANCEIRO-05','financeiro05','GABRIEL',20,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(21,'INDUSTRIAL-01','industrial01','BIAS',21,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(22,'INDUSTRIAL-02','industrial02','THIAGO',22,'pc','','WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM'),(23,'INDUSTRIAL-03','industrial03','ALEX',23,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(24,'INDUSTRIAL-04','industrial04','GANSO',24,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(25,'INDUSTRIAL-05','industrial05','MARCEL',25,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(26,'INDUSTRIAL-06','industrial06','TERMINAL IND 06',26,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(27,'INDUSTRIAL-09','industrial09','JOÃO',27,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(28,'INDUSTRIAL-10','industrial10','ANDERSON',28,'Notebook','','WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM'),(29,'INDUSTRIAL-A01','industriala01','EDINHO',29,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(30,'INDUSTRIAL-A02','industriala02','MAURICIO',30,'pc','','WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM'),(31,'LOGISTICA-01','logistica01','FERNANDES',31,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(32,'LOGISTICA-02','logistica02','OTANIEL',32,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(33,'MANUTENCAO-01','manutencao01','NI',33,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(34,'PORTARIA-01','portaria01','PORTEIROS DIVERSOS',34,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(35,'QUALIDADE-01','qualidade01','LUAN',35,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(36,'RECEPCAO-01','recepcao01','RENATA E GABRIELE',36,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(37,'REFEITORIO-01','refeitorio01','NATÁLIA',37,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(38,'RH-02','rh02','FÁTIMA',38,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(39,'RH-03','rh03','CÍNTIA',39,'Notebook','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(40,'TI-01','ti01','LUCAS',40,'pc','','WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM'),(41,'TI-02','ti02','WESLEY',41,'pc','','WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM'),(42,'VENDAS-01','vendas01','VANDO',42,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(43,'VENDAS-03','vendas03','MARCELO OMITO',43,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(44,'VENDAS-04','vendas04','GABRIEL GAVIOLLI',44,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(45,'VENDAS-05','vendas05','ROGÉRIO',45,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(46,'VENDAS-06','vendas06','CLÉBER',46,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(47,'VENDAS-07','vendas07','MATHEUS',47,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(48,'VENDAS-F1','vendasf1','FÁBIO',48,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(49,'VENDAS-F2','vendasf2','MARCOS',49,'pc','','WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3'),(64,'SEGURANCA-01','Não Esta No Dominio','ALAN',63,'Notebook','','UFEI','Armazenada na BIOS(UFEI) do notebook');
/*!40000 ALTER TABLE `maquina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maquina_software`
--

DROP TABLE IF EXISTS `maquina_software`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maquina_software` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_maquina` int DEFAULT NULL,
  `id_licenca` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=110 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maquina_software`
--

LOCK TABLES `maquina_software` WRITE;
/*!40000 ALTER TABLE `maquina_software` DISABLE KEYS */;
INSERT INTO `maquina_software` (`id`, `id_maquina`, `id_licenca`) VALUES (1,5,1),(5,14,6),(6,15,7),(7,16,8),(9,18,10),(10,19,11),(11,21,12),(12,22,13),(13,25,14),(14,32,2),(85,27,20),(88,35,24),(90,40,58),(91,6,58),(92,48,25),(93,9,3),(94,9,60),(95,10,4),(96,10,60),(97,13,21),(98,13,60),(99,11,5),(100,11,59),(101,12,59),(102,8,59),(103,42,18),(104,42,59),(105,38,16),(106,39,23),(107,17,9),(108,20,15),(109,23,22);
/*!40000 ALTER TABLE `maquina_software` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `software`
--

DROP TABLE IF EXISTS `software`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `software` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(450) NOT NULL,
  `os` varchar(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `software`
--

LOCK TABLES `software` WRITE;
/*!40000 ALTER TABLE `software` DISABLE KEYS */;
INSERT INTO `software` (`id`, `nome`, `os`) VALUES (1,'WINDOWS 8.1 PRO','s'),(2,'WINDOWS 10 PRO','s'),(3,'OFFICE 2013','n'),(4,'OFFICE 2016','n'),(26,'OFFICE 365','n'),(27,'AUTOCAD LT','n'),(28,'Product Design & Manufacturing Collection','n'),(29,'WBCcad','n'),(30,'UFEI','s');
/*!40000 ALTER TABLE `software` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `software_licencas`
--

DROP TABLE IF EXISTS `software_licencas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `software_licencas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `software` varchar(450) NOT NULL,
  `key` varchar(450) NOT NULL,
  `qtd` int NOT NULL,
  `qtdmax` int NOT NULL,
  `nfe` varchar(450) NOT NULL,
  `observacao` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `software_licencas`
--

LOCK TABLES `software_licencas` WRITE;
/*!40000 ALTER TABLE `software_licencas` DISABLE KEYS */;
INSERT INTO `software_licencas` (`id`, `software`, `key`, `qtd`, `qtdmax`, `nfe`, `observacao`) VALUES (1,'OFFICE 2013','R6YVN-2YKXQ-337M9-HCJV3-YBFP3',0,1,'Informar',''),(2,'OFFICE 2013','KXNYR-TDK47-7WJ69-9T4Y3-Y4DTQ',0,1,'Informar',''),(3,'OFFICE 2013','QM78N-4W7PF-TMC6J-DFV9V-CYQTQ',0,1,'Informar',''),(4,'OFFICE 2013','TBN2J-HDPBY-4CQWJ-CYY4Y-HT7GQ',0,1,'Informar',''),(5,'OFFICE 2013','VNJ86-M2KVQ-T6MMJ-QTPPV-JQHGQ',0,1,'Informar',''),(6,'OFFICE 2013','G9NB7-CXH74-KBPXH-H96PD-G8X6Q',0,1,'Informar',''),(7,'OFFICE 2013','YHDQ2-RBNKY-MTWBT-VYDVX-H496Q',0,1,'Informar',''),(8,'OFFICE 2013','HQKBN-RPJFQ-DJCJB-2GKXP-7496Q',0,1,'Informar',''),(9,'OFFICE 2013','3C6FG-QNRXG-FKDTQ-3X63T-QYFP3',0,1,'Informar',''),(10,'OFFICE 2013','BQYNP-DJPDX-3P924-WJRGK-3RPXD',0,1,'Informar',''),(11,'OFFICE 2013','V8DN6-228C7-RVYDB-J8XHX-TFY23',0,1,'Informar',''),(12,'OFFICE 2013','XPNGG-4TJ9M-PX3KJ-DT7GY-RCW9D',0,1,'Informar',''),(13,'OFFICE 2013','G8F9N-BVKXK-9KK7V-3WHPF-367GQ',0,1,'Informar',''),(14,'OFFICE 2013','7PJ7X-XNVJ7-9Q4FX-PTKV4-K4PXD',0,1,'Informar',''),(15,'OFFICE 2013','3B63N-2WKVQ-P49G4-4VX3F-3C8C3',0,1,'Informar',''),(16,'OFFICE 2013','MP7CN-WRR49-Q39V2-VJQVY-F889D',0,1,'Informar',''),(17,'OFFICE 2013','FNCCB-BK26Y-C2RCH-8V6YV-GCK6Q',1,1,'Informar',''),(18,'OFFICE 2013','377ND-CG2V4-6KWDF-PXGTX-4JM23',0,1,'Informar',''),(19,'OFFICE 2013','NYRCK-66H3G-68TVY-V9FVJ-VH3TQ',1,1,'Informar',''),(20,'OFFICE 2016','4WCNM-QMMF9-BPQQ2-7PP6B-BBH39',0,1,'Informarw',''),(21,'OFFICE 2016','QGFXX-4VNP9-RXMD4-94GY2-PGYQ9',0,1,'Informar',''),(22,'OFFICE 2016','DCNJM-PDBRR-9JDC9-9F2Y4-R3KVX',0,1,'Informar',''),(23,'OFFICE 2016','CF4NX-D3YTY-PFQDQ-QT92D-WQKVX',0,1,'Informar',''),(24,'OFFICE 2016','Y7M7G-MKND9-DMV2B-KQRT6-P7JYK',0,1,'Informar',''),(25,'OFFICE 2016','GHXXM-MNRHM-BY6X7-F746M-VQWYK',0,1,'Informar',''),(28,'WINDOWS 8.1 PRO','6NTFW-4MXHQ-3V2F6-Q2HTQ-BG8K3',0,44,'Informar',''),(29,'WINDOWS 10 PRO','28NGP-7JFQ9-3MYWJ-MTRQJ-33WXM',3,8,'Informar',''),(58,'OFFICE 365','admin@cristalaco.onmicrosoft.com',0,2,'Não Informado','.                                                                 VaitomarnoCU@4X'),(59,'AUTOCAD LT','lucas@cristalaco.com.br',0,4,'Não Informado','ttps://manage.autodesk.com/cep/'),(60,'Product Design & Manufacturing Collection',' lucas@cristalaco.com.br',0,3,'Não Informado','ttps://manage.autodesk.com/cep/'),(61,'WBCcad','cristal.2015',10,10,'Não Informado','http://wbclicencas.azurewebsites.net/'),(62,'UFEI','Armazenada na BIOS(UFEI) do notebook',99,100,'Não Informada','');
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

-- Dump completed on 2021-04-19  9:31:17
