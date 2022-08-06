-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 06, 2022 at 06:42 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hms`
--

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `bill_id` int(11) NOT NULL,
  `booking_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `room_price` int(11) DEFAULT NULL,
  `payment_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`bill_id`, `booking_id`, `customer_id`, `room_price`, `payment_date`) VALUES
(3, 3, 2, 1330, '2022-08-04');

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `booking_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `room_id` int(11) NOT NULL,
  `checkin_date` date DEFAULT NULL,
  `checkout_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`booking_id`, `customer_id`, `room_id`, `checkin_date`, `checkout_date`) VALUES
(3, 2, 5, '2022-08-05', '2022-08-19');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `username` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL,
  `firstname` varchar(254) DEFAULT NULL,
  `lastname` varchar(254) DEFAULT NULL,
  `contact_num` varchar(254) DEFAULT NULL,
  `email` varchar(254) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `username`, `password`, `firstname`, `lastname`, `contact_num`, `email`) VALUES
(2, 'jpperez', 'jpperez', 'Jp', 'Perez', '', 'perezjohnpatrick077@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `customer_checkin`
--

CREATE TABLE `customer_checkin` (
  `customer_id` int(11) NOT NULL,
  `cfirstname` varchar(50) NOT NULL,
  `clastname` varchar(50) NOT NULL,
  `ccontact_num` varchar(50) NOT NULL,
  `room_type` varchar(50) NOT NULL,
  `nights` int(11) NOT NULL,
  `checkin` varchar(50) NOT NULL,
  `checkout` varchar(50) NOT NULL,
  `total` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_checkin`
--

INSERT INTO `customer_checkin` (`customer_id`, `cfirstname`, `clastname`, `ccontact_num`, `room_type`, `nights`, `checkin`, `checkout`, `total`) VALUES
(1, 'Jp', 'Perez', '09123456789', 'Single', 1, '8/5/2022 3:45:55 PM', '8/6/2022 3:45:55 PM', 75),
(2, 'wasd', 'awd', '123', 'Presidential', 14, '8/5/2022 4:40:40 PM', '8/19/2022 4:40:40 PM', 7280),
(4, 'Pj', 'Zerep', '1212123', 'Deluxe', 15, '8/5/2022 9:03:16 PM', '8/20/2022 9:03:16 PM', 3555),
(5, 'John', 'Patrik', '12321', 'Single', 19, '8/5/2022 9:06:00 PM', '8/24/2022 9:06:00 PM', 1425),
(6, 'Patr', 'Perz', '1432', 'Twin', 7, '8/11/2022 9:06:24 PM', '8/18/2022 9:06:24 PM', 665),
(7, 'Juan', 'dlCrz', '12123', 'Studio', 22, '8/20/2022 9:08:36 PM', '8/27/2022 9:08:36 PM', 2750);

-- --------------------------------------------------------

--
-- Table structure for table `emp_record`
--

CREATE TABLE `emp_record` (
  `emp_id` int(11) NOT NULL,
  `efirstname` varchar(50) NOT NULL,
  `elastname` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `contact_num` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `salary` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `emp_record`
--

INSERT INTO `emp_record` (`emp_id`, `efirstname`, `elastname`, `gender`, `contact_num`, `email`, `salary`) VALUES
(4, 'Juan', 'de la Cruz', 'M', '09123', 'juan@delacruz.com', '270'),
(5, 'John Patrick', 'Perez', 'M', '09321', 'perezjohnpatrick077@gmail.com', '0'),
(6, 'Jay Harold', 'Roldan', 'M', '12123', 'jay@harold123.com', '0'),
(7, 'Kenshyn', 'Nicolas', 'M', '0123', 'kenshyn@nico.las', '0');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_id` int(11) NOT NULL,
  `room_type_id` int(11) NOT NULL,
  `room_num` varchar(254) DEFAULT NULL,
  `availability` varchar(254) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_id`, `room_type_id`, `room_num`, `availability`) VALUES
(1, 1, '1', 'TRUE'),
(2, 1, '2', 'TRUE'),
(3, 1, '3', 'TRUE'),
(4, 1, '4', 'TRUE'),
(5, 2, '5', 'FALSE'),
(6, 2, '6', 'TRUE'),
(7, 2, '7', 'TRUE'),
(8, 2, '8', 'TRUE'),
(9, 3, '9', 'TRUE'),
(10, 3, '10', 'TRUE'),
(11, 3, '11', 'TRUE'),
(12, 3, '12', 'TRUE'),
(13, 4, '13', 'TRUE'),
(14, 4, '14', 'TRUE'),
(15, 4, '15', 'TRUE'),
(16, 4, '16', 'TRUE'),
(17, 5, '17', 'TRUE'),
(18, 5, '18', 'TRUE'),
(19, 5, '19', 'TRUE'),
(20, 5, '20', 'TRUE'),
(21, 6, '21', 'TRUE'),
(22, 6, '22', 'TRUE'),
(23, 6, '23', 'TRUE'),
(24, 6, '24', 'TRUE');

-- --------------------------------------------------------

--
-- Table structure for table `room_type`
--

CREATE TABLE `room_type` (
  `room_type_id` int(11) NOT NULL,
  `room_type_name` varchar(254) DEFAULT NULL,
  `room_price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room_type`
--

INSERT INTO `room_type` (`room_type_id`, `room_type_name`, `room_price`) VALUES
(1, 'SINGLE ROOM', 75),
(2, 'TWIN ROOM', 95),
(3, 'STUDIO ROOM', 125),
(4, 'DELUXE SUITE', 237),
(5, 'PENTHOUSE SUITE', 345),
(6, 'PRESIDENTIAL SUITE', 520);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`bill_id`),
  ADD KEY `booking_id` (`booking_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`booking_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `room_id` (`room_id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `customer_checkin`
--
ALTER TABLE `customer_checkin`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `emp_record`
--
ALTER TABLE `emp_record`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`),
  ADD KEY `room_type_id` (`room_type_id`);

--
-- Indexes for table `room_type`
--
ALTER TABLE `room_type`
  ADD PRIMARY KEY (`room_type_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bill`
--
ALTER TABLE `bill`
  MODIFY `bill_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `booking`
--
ALTER TABLE `booking`
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `customer_checkin`
--
ALTER TABLE `customer_checkin`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `emp_record`
--
ALTER TABLE `emp_record`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `room_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `room_type`
--
ALTER TABLE `room_type`
  MODIFY `room_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bill`
--
ALTER TABLE `bill`
  ADD CONSTRAINT `bill_ibfk_1` FOREIGN KEY (`booking_id`) REFERENCES `booking` (`booking_id`),
  ADD CONSTRAINT `bill_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`);

--
-- Constraints for table `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `booking_ibfk_2` FOREIGN KEY (`room_id`) REFERENCES `room` (`room_id`);

--
-- Constraints for table `room`
--
ALTER TABLE `room`
  ADD CONSTRAINT `room_ibfk_1` FOREIGN KEY (`room_type_id`) REFERENCES `room_type` (`room_type_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
