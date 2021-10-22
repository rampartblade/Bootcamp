-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 21, 2021 at 07:49 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `creditcard`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('61e6f981-fcf4-4c53-83ca-7e5e3203a8df', 'rickyadiputra98@gmail.com', 'RICKYADIPUTRA98@GMAIL.COM', 'rickyadiputra98@gmail.com', 'RICKYADIPUTRA98@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEFIqpMYZoyxCQXCjKOJletFWKwgOF4eisExszswlcZzK5M5sfswn8Md28qRMZaOiSA==', '5TPUXUIRPPQ3MC7ZXAK2KX2DHLHV6753', '2da802b4-6796-42a0-a000-b0bc9cf31b93', NULL, 0, 0, NULL, 1, 0),
('7113e4b5-f5d4-4f7a-97a5-a3100f6121cf', 'test@gmail.com', 'TEST@GMAIL.COM', 'test@gmail.com', 'TEST@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEFmU3uW0BlNvp5/fSM/jr18B4Va9Ttvia0hq+0Iz8L8UazBGCNkP9TMlT6X7wVB4Vg==', 'RW254GVBVQ5VGV3YXNND7UKW2UVJUPZU', '20404b04-4a75-45f7-90fd-2952a19eae1a', NULL, 0, 0, NULL, 1, 0),
('d14a5cbc-d3ac-42cb-8b04-a532212e9089', 'jimmyhopkins@gmail.com', 'JIMMYHOPKINS@GMAIL.COM', 'jimmyhopkins@gmail.com', 'JIMMYHOPKINS@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEIrZUwrIML68zAgWebZvhrcapf35eRa3Tj2x8zqIxAtgU/U97tz1zJYQvtlVwv+DbA==', 'HVBY2LNKXF7OZ7F2BZJTYNY357HCPGYH', '4a0d703a-9c8e-41a3-83a0-7b310e65ce36', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `creditcarddetails`
--

CREATE TABLE `creditcarddetails` (
  `PaymentDetailId` int(11) NOT NULL,
  `CardOwnerName` text DEFAULT NULL,
  `CardNumber` text DEFAULT NULL,
  `ExpirationDate` text DEFAULT NULL,
  `SecurityCode` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `creditcarddetails`
--

INSERT INTO `creditcarddetails` (`PaymentDetailId`, `CardOwnerName`, `CardNumber`, `ExpirationDate`, `SecurityCode`) VALUES
(1, 'Ricky Adiputra', '123454321', '11052022', '555777');

-- --------------------------------------------------------

--
-- Table structure for table `refreshtokens`
--

CREATE TABLE `refreshtokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) DEFAULT NULL,
  `Token` text DEFAULT NULL,
  `JwtId` text DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `refreshtokens`
--

INSERT INTO `refreshtokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, '61e6f981-fcf4-4c53-83ca-7e5e3203a8df', 'Q4UXUIK0QSS7BPM5CCZA3QTQCCG0D7US6DBc5ebc5c1-09de-4621-8bc2-1c4b67b9849c', '8e32a6d4-5b77-4f10-83f3-13954f779aa1', 0, 0, '2021-10-21 09:49:18', '2022-04-21 09:49:18'),
(2, '61e6f981-fcf4-4c53-83ca-7e5e3203a8df', 'U8YYQDPT5TU0G33OUAD3PSU3Q4B09GZA0SM1ec3c516-2810-4a0d-8b69-af60e4ac9eb5', '88b89704-3b20-4a57-91a8-f2a5e04e748a', 0, 0, '2021-10-21 09:53:00', '2022-04-21 09:53:00'),
(3, '61e6f981-fcf4-4c53-83ca-7e5e3203a8df', '465HMAQGY5UAP3V88IV9RQUQGKEUII2SLKT8bf30ebe-04bb-4840-a652-088fcdab3c1b', '899bb104-7772-4023-ae5b-d3ea508bdf75', 0, 0, '2021-10-21 16:02:19', '2022-04-21 16:02:19'),
(4, 'd14a5cbc-d3ac-42cb-8b04-a532212e9089', 'CINFQJBCT0KNFYLKQVLUC1QH0POO376DVS0eb382a45-7102-4cd6-b23d-03b2efd9f693', '51c245dd-153b-4e4e-a6aa-7beb48115c0a', 0, 0, '2021-10-21 16:18:53', '2022-04-21 16:18:53'),
(5, '61e6f981-fcf4-4c53-83ca-7e5e3203a8df', 'T2BX1ZQFUNJGMYSX1EZCIAU090PEIN06VXC721f5300-ac91-46b6-84e9-a5bd5c14d8fa', '8115a07a-3e96-457f-b781-cd226b42a133', 0, 0, '2021-10-21 17:32:44', '2022-04-21 17:32:44'),
(6, '7113e4b5-f5d4-4f7a-97a5-a3100f6121cf', 'BJRH2CQUI4RD3L9HMV9VQSPC49GMBENKKSM0f34ad73-091b-4f55-bbf1-f9eb6cccc4ae', 'a08c0489-2bc0-42c9-8840-e18650d58b2d', 0, 0, '2021-10-21 17:35:21', '2022-04-21 17:35:21'),
(7, '7113e4b5-f5d4-4f7a-97a5-a3100f6121cf', 'A2NG9MSEZ71BQBGRP6EO55XQCPYQMDFJ14Of9f8d9ab-99c7-4d78-9e3e-49f3fd511405', '15dd188c-1dc5-41ba-861c-98e3a412b706', 0, 0, '2021-10-21 17:36:11', '2022-04-21 17:36:11');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021083915_add authentication', '5.0.11'),
('20211021094817_Added refresh tokens table', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `creditcarddetails`
--
ALTER TABLE `creditcarddetails`
  ADD PRIMARY KEY (`PaymentDetailId`);

--
-- Indexes for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `creditcarddetails`
--
ALTER TABLE `creditcarddetails`
  MODIFY `PaymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
