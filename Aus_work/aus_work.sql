-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2016 at 07:20 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `aus_work`
--

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `IdNo` int(4) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(55) NOT NULL,
  `LastName` varchar(55) NOT NULL,
  `PreferedName` varchar(55) NOT NULL,
  `Address` varchar(55) NOT NULL,
  `Suburb` varchar(55) NOT NULL,
  `State` varchar(12) NOT NULL,
  `PostCode` varchar(15) NOT NULL,
  `Country` varchar(50) NOT NULL,
  `HomePhone` varchar(15) NOT NULL,
  `WorkPhone` varchar(15) NOT NULL,
  `Mobile` varchar(18) NOT NULL,
  `Fax` varchar(15) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `SkinType` varchar(150) NOT NULL,
  `HairType` varchar(150) NOT NULL,
  `FacialType` varchar(150) NOT NULL,
  `DateOfBirth` varchar(20) NOT NULL,
  `LastServiceDate` varchar(20) NOT NULL,
  `LastVisitDate` varchar(20) NOT NULL,
  `LastColornumber` varchar(10) NOT NULL,
  `Productbuy1` varchar(50) NOT NULL,
  `Productbuy2` varchar(50) NOT NULL,
  `DiscountGiven` int(15) NOT NULL,
  `SpecialTreatment` varchar(50) NOT NULL,
  `Allergies` varchar(55) NOT NULL,
  PRIMARY KEY (`IdNo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`IdNo`, `FirstName`, `LastName`, `PreferedName`, `Address`, `Suburb`, `State`, `PostCode`, `Country`, `HomePhone`, `WorkPhone`, `Mobile`, `Fax`, `Email`, `SkinType`, `HairType`, `FacialType`, `DateOfBirth`, `LastServiceDate`, `LastVisitDate`, `LastColornumber`, `Productbuy1`, `Productbuy2`, `DiscountGiven`, `SpecialTreatment`, `Allergies`) VALUES
(1, 'Alen', 'Hallen', 'Al', 'sfdfdsf', '', '', '', '', '', '', '', '', '', '', '', '', '02-02-1991', '12-11-2015', '12-11-2015', '', '', '', 2, '', ''),
(3, 'Tomus', 'Jack', 'Tom', '', '', '', '', '', '', '', '', '', '', '', '', '', '15-09-1999', '12-11-2015', '12-11-2015', '', '', '', 5, '', 'yes'),
(4, 'Jack', 'Sparrow', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '20-09-1999', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(5, 'michell', 'deep', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '1-11-1998', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(6, 'rooni', 'micke', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '13-11-1992', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(7, 'tina', 'micke', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '1-02-2000', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(8, 'john', 'amith', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '12-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(9, 'Loory', 'Pixie', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '13-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(10, 'tim', 'sammy', 'sam', '', '', '', '', '', '', '', '', '', '', '', '', '', '02-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(11, 'jack', 'donald', 'jackie', '', '', '', '', '', '', '', '', '', '', '', '', '', '01-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(12, 'Mick', 'corry', 'mi', '', '', '', '', '', '', '', '', '', '', '', '', '', '06-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(13, 'ronald', 'smith', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '06-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(14, 'Alli', 'Kim', 'Al', 'abbd,hhhuuy,hhiioos', '', 'Dehli', '55990', 'India', '', '', '3216484888465', '', 'abc@hotmail.com', 'Oily', 'Thick', '', '01-11-2015', '05-11-2015', '10-11-2015', '', '', '', 0, '', 'No'),
(15, 'Snape', 'Perks', '', '', '', '', '', 'New York', '', '', '', '', '', '', '', '', '02-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(16, 'Sam', 'Lora', 'Sam', '', '', '', '', '', '', '', '', '', '', '', '', '', '12-11-2015', '12-11-2015', '12-11-2015', '', '', '', 0, '', ''),
(17, 'Rose', 'Finn', 'Rosie', '', '', '', '', 'London', '', '', '', '', '', '', '', '', '02-02-1999', '14-11-2015', '14-11-2015', '', '', '', 0, '', 'No');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
