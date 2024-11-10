/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 10.4.21-MariaDB : Database - tmdinventory
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`tmdinventory` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `tmdinventory`;

/*Table structure for table `categories` */

DROP TABLE IF EXISTS `categories`;

CREATE TABLE `categories` (
  `CategoryID` int(11) NOT NULL,
  `CategoryName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `categories` */

insert  into `categories`(`CategoryID`,`CategoryName`) values 
(1,'Electronics'),
(2,'Automotive'),
(3,'Home and Garden'),
(4,'Clothing'),
(5,'Sports and Outdoors');

/*Table structure for table `deliveries` */

DROP TABLE IF EXISTS `deliveries`;

CREATE TABLE `deliveries` (
  `DeliveryID` int(11) NOT NULL AUTO_INCREMENT,
  `PartsID` int(11) DEFAULT NULL,
  `SupplierID` int(11) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `DeliveredBy` varchar(100) DEFAULT NULL,
  `ReceivedBy` varchar(100) DEFAULT NULL,
  `Notes` text DEFAULT NULL,
  `SotcksDelivered` int(11) DEFAULT NULL,
  `UserID` int(11) DEFAULT NULL,
  PRIMARY KEY (`DeliveryID`),
  KEY `OrderDetailID` (`SupplierID`),
  KEY `UserID` (`UserID`),
  KEY `PartsID` (`PartsID`),
  CONSTRAINT `deliveries_ibfk_3` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  CONSTRAINT `deliveries_ibfk_4` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`),
  CONSTRAINT `deliveries_ibfk_5` FOREIGN KEY (`PartsID`) REFERENCES `parts` (`PartID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `deliveries` */

/*Table structure for table `parts` */

DROP TABLE IF EXISTS `parts`;

CREATE TABLE `parts` (
  `PartID` int(11) NOT NULL AUTO_INCREMENT,
  `PartName` varchar(255) DEFAULT NULL,
  `PartNumber` varchar(50) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL,
  `SupplierID` int(11) DEFAULT NULL,
  `UnitPrice` float DEFAULT NULL,
  `QuantityInStock` int(11) DEFAULT NULL,
  `MinimumQuantity` int(11) DEFAULT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `DateAdded` date DEFAULT NULL,
  `DateModified` date DEFAULT NULL,
  PRIMARY KEY (`PartID`),
  KEY `SupplierID` (`SupplierID`),
  KEY `parts_cat` (`CategoryID`),
  CONSTRAINT `parts_cat` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`),
  CONSTRAINT `parts_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4;

/*Data for the table `parts` */

insert  into `parts`(`PartID`,`PartName`,`PartNumber`,`Description`,`CategoryID`,`SupplierID`,`UnitPrice`,`QuantityInStock`,`MinimumQuantity`,`Location`,`DateAdded`,`DateModified`) values 
(1,'Widget A','WGT001','Small widget',1,1,10.5,100,20,'Shelf A','2023-10-19','2023-10-19'),
(2,'Gizmo X','GZM002','Advanced gizmo',2,2,25,50,10,'Drawer B','2023-10-18','2023-10-18'),
(3,'Thingamajig B','THG003','Medium thingamajig',3,3,15.75,75,15,'Bin C','2023-10-17','2023-10-17'),
(4,'Doodad Z','DDZ004','High-quality doodad',4,4,30.2,30,5,'Shelf D','2023-10-16','2023-10-16'),
(5,'Whatchamacallit Y','WMC005','Large whatchamacallit',5,5,50.6,20,2,'Cabinet E','2023-10-15','2023-10-15'),
(6,'Widget B','WGT006','Medium widget',1,1,12.75,80,15,'Shelf A','2023-10-14','2023-10-14'),
(7,'Gizmo Y','GZM007','Compact gizmo',2,2,20.3,60,12,'Drawer B','2023-10-13','2023-10-13'),
(8,'Thingamajig A','THG008','Small thingamajig',3,3,8.9,120,25,'Bin C','2023-10-12','2023-10-12'),
(9,'Doodad X','DDZ009','Basic doodad',4,4,18.4,40,8,'Shelf D','2023-10-11','2023-10-11'),
(10,'Whatchamacallit Z','WMC010','Heavy whatchamacallit',5,5,65.25,10,1,'Cabinet E','2023-10-10','2023-10-10'),
(11,'Widget C','WGT011','Large widget',1,1,15.6,70,18,'Shelf A','2023-10-09','2023-10-09'),
(12,'Gizmo Z','GZM012','Advanced gizmo',2,2,28.8,45,9,'Drawer B','2023-10-08','2023-10-08'),
(13,'Thingamajig C','THG013','Medium thingamajig',3,3,17.25,90,20,'Bin C','2023-10-07','2023-10-07'),
(14,'Doodad Y','DDZ014','High-quality doodad',4,4,35.1,25,4,'Shelf D','2023-10-06','2023-10-06'),
(15,'Whatchamacallit X','WMC015','Compact whatchamacallit',5,5,40.75,15,3,'Cabinet E','2023-10-05','2023-10-05'),
(16,'Widget D','WGT016','Basic widget',1,1,9.8,110,22,'Shelf A','2023-10-04','2023-10-04'),
(17,'Gizmo W','GZM017','Compact gizmo',2,2,19.4,55,11,'Drawer B','2023-10-03','2023-10-03'),
(18,'Thingamajig D','THG018','Small thingamajig',3,3,11.2,100,23,'Bin C','2023-10-02','2023-10-02'),
(19,'Doodad W','DDZ019','Basic doodad',4,4,20.7,35,7,'Shelf D','2023-10-01','2023-10-01'),
(20,'Whatchamacallit W','WMC020','Medium whatchamacallit',5,5,55.2,12,2,'Cabinet E','2023-09-30','2023-09-30'),
(21,'Widget E','WGT021','Compact widget',1,1,11.9,95,17,'Shelf A','2023-09-29','2023-09-29'),
(22,'Gizmo V','GZM022','Advanced gizmo',2,2,24.6,60,14,'Drawer B','2023-09-28','2023-09-28'),
(23,'Thingamajig E','THG023','Small thingamajig',3,3,14.3,85,19,'Bin C','2023-09-27','2023-09-27'),
(24,'Doodad V','DDZ024','High-quality doodad',4,4,32.7,20,3,'Shelf D','2023-09-26','2023-09-26'),
(25,'Whatchamacallit V','WMC025','Large whatchamacallit',5,5,60.4,8,1,'Cabinet E','2023-09-25','2023-09-25');

/*Table structure for table `suppliers` */

DROP TABLE IF EXISTS `suppliers`;

CREATE TABLE `suppliers` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` varchar(255) DEFAULT NULL,
  `ContactPerson` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `suppliers` */

insert  into `suppliers`(`SupplierID`,`SupplierName`,`ContactPerson`,`ContactNumber`,`Email`) values 
(1,'ABC Electronics','John Doe','555-1234','john.doe@abc.com'),
(2,'XYZ Motors','Jane Smith','555-5678','jane.smith@xyzmotors.com'),
(3,'123 Furniture Co.','Bob Johnson','555-7890','bob.johnson@123furniture.com'),
(4,'Fashion Unlimited','Mary Brown','555-4321','mary.brown@fashionunlimited.com'),
(5,'Sports Gear Inc.','Mike Wilson','555-0987','mike.wilson@sportsgear.com');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Role` varchar(50) DEFAULT NULL,
  `Validity` date DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`UserID`,`Username`,`Password`,`Role`,`Validity`) values 
(1,'john_doe','password123','Admin','2023-10-19'),
(2,'jane_smith','letmein','Manager','2024-01-18'),
(3,'bob_johnson','securepass','User','2023-12-17'),
(4,'mary_brown','12345','User','2023-10-16'),
(5,'mike_wilson','qwerty','User','2023-11-15'),
(6,'susan_davis','susan123','User','2023-10-14'),
(7,'david_parker','davidpass','User','2023-12-13'),
(8,'linda_martin','linda01','User','2024-02-12'),
(9,'james_williams','pass1234','User','2023-10-11'),
(10,'amy_jones','password','User','2023-10-10');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
