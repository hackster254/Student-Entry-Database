-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 27, 2021 at 07:43 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `college`
--

CREATE TABLE `college` (
  `college_id` varchar(10) NOT NULL,
  `college_name` varchar(55) DEFAULT NULL,
  `years` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `college`
--

INSERT INTO `college` (`college_id`, `college_name`, `years`) VALUES
('COANRI', 'College of agriculture', 4),
('COETEC', 'College of Engineering', 5),
('COHES', 'College of Health Sciences', 6),
('COPAS', 'College of Pure and Applied Sciences', 4);

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` varchar(10) NOT NULL,
  `course_name` varchar(55) DEFAULT NULL,
  `college_id` varchar(10) DEFAULT NULL,
  `college_name` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `course_name`, `college_id`, `college_name`) VALUES
('BOH', 'Bachelor Horticulture', 'COANRI', 'College of agriculture'),
('CI', 'Control and Instrumentation', 'COPAS', 'college of pure and applied sciences'),
('CS', 'Computer Science', 'COPAS', 'college of pure and applied sciences'),
('CVL', 'Civil Engineering', 'COETEC', 'College of Engineering'),
('ECE', 'Electronic and Computer Engineering', 'COETEC', 'College of Engineering'),
('MED', 'Medicine', 'COHES', 'College of Health Sciences'),
('PHA', 'Pharmacy', 'COHES', 'College of Health Sciences');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `Regno` varchar(20) NOT NULL,
  `Cat1` int(11) DEFAULT NULL,
  `Cat2` int(11) DEFAULT NULL,
  `Cat3` int(11) DEFAULT NULL,
  `Total` int(11) DEFAULT NULL,
  `Grade` char(1) DEFAULT NULL,
  `unit_id` varchar(10) DEFAULT NULL,
  `college_name` varchar(55) NOT NULL,
  `course_name` varchar(55) NOT NULL,
  `unit_name` varchar(30) NOT NULL,
  `semester` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`Regno`, `Cat1`, `Cat2`, `Cat3`, `Total`, `Grade`, `unit_id`, `college_name`, `course_name`, `unit_name`, `semester`) VALUES
('', 0, 0, 0, NULL, NULL, NULL, '', '', '', 0),
('0290', 10, 20, 50, 291, NULL, NULL, '', '', '', 0),
('cla', 24, 21, 67, 69, 'B', NULL, 'COHES', 'Medicine', 'Anatomy', 2),
('dee', 23, 34, 45, NULL, NULL, NULL, '', '', '', 0),
('eee', 2, 3, 0, NULL, NULL, NULL, '', '', '', 0),
('ene212', 0, 0, 0, NULL, NULL, NULL, '', '', '', 0),
('ene212-0267', NULL, NULL, NULL, NULL, NULL, 'ICS 2500', '', '', '', 0),
('karira', 23, 23, 50, 52, 'C', NULL, 'COETEC', 'Electronic and Computer Engineering', 'Numerical Analysis', 2),
('MED223/16', 21, 12, 57, 58, 'C', NULL, 'COHES', 'Pharmacy', 'Biochemistry', 2),
('sct211-003', NULL, NULL, NULL, NULL, NULL, 'ICS 2502', '', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `units`
--

CREATE TABLE `units` (
  `unit_id` varchar(10) NOT NULL,
  `unit_name` varchar(55) DEFAULT NULL,
  `course_id` varchar(10) DEFAULT NULL,
  `course_name` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `units`
--

INSERT INTO `units` (`unit_id`, `unit_name`, `course_id`, `course_name`) VALUES
('ANA 100', 'Anatomy', 'MED', 'Medicine'),
('BIOCHEM 24', 'Biochemistry', 'PHA', 'Pharmacy'),
('EEE 0023', 'Digital Logic', 'CS', 'Computer Science'),
('GEO 2100', 'Geology', 'CVL', 'Civil Engineering'),
('HOR 345', 'Flower graft', 'BOH', 'Bachelor Horticulture'),
('ICS 2500', 'VB net', 'ECE', 'Electronic and Computer Engineering'),
('ICS 2502', 'Data structures', 'CS', 'Computer Science'),
('QM', 'Quantum Mechanics', 'CI', 'Control and Instrumentation'),
('SMA 2400', 'Numerical Analysis', 'ECE', 'Electronic and Computer Engineering');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `college`
--
ALTER TABLE `college`
  ADD PRIMARY KEY (`college_id`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`course_id`),
  ADD KEY `college_id` (`college_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Regno`),
  ADD KEY `unit_id` (`unit_id`);

--
-- Indexes for table `units`
--
ALTER TABLE `units`
  ADD PRIMARY KEY (`unit_id`),
  ADD KEY `course_id` (`course_id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `courses`
--
ALTER TABLE `courses`
  ADD CONSTRAINT `courses_ibfk_1` FOREIGN KEY (`college_id`) REFERENCES `college` (`college_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`unit_id`) REFERENCES `units` (`unit_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `units`
--
ALTER TABLE `units`
  ADD CONSTRAINT `units_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
