/*
Navicat MySQL Data Transfer

Source Server         : con
Source Server Version : 50021
Source Host           : localhost:3306
Source Database       : dbrrgm

Target Server Type    : MYSQL
Target Server Version : 50021
File Encoding         : 65001

Date: 2016-08-21 01:33:51
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tbluser`
-- ----------------------------
DROP TABLE IF EXISTS `tbluser`;
CREATE TABLE `tbluser` (
  `userID` varchar(50) NOT NULL,
  `password` varchar(100) default NULL,
  `firstname` varchar(100) default NULL,
  `middlename` varchar(100) default NULL,
  `lastname` varchar(100) default NULL,
  `position` varchar(100) default NULL,
  PRIMARY KEY  (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbluser
-- ----------------------------
INSERT INTO `tbluser` VALUES ('USER-0001', 'aasa', 'Aira', 'Lapuz', 'Mesa', 'Admin');
INSERT INTO `tbluser` VALUES ('USER-0002', 'chill', 'dss', 'sd', 'sda', 'sdsd');
INSERT INTO `tbluser` VALUES ('USER-0003', 'as', 'asa', 'sasa', 'asa', 'asas');
INSERT INTO `tbluser` VALUES ('USER-0004', 'chil', 'chur', 'chill', 'chuasa', 'chill');
INSERT INTO `tbluser` VALUES ('USER-0005', 'wq', 'gdgf', 'fgf', 'dgd', 'gfgf');
INSERT INTO `tbluser` VALUES ('USER-0006', 'wq', 'wqwq', 'wqwq', 'qw', 'wqwqq');
INSERT INTO `tbluser` VALUES ('USER-0007', 'chill', 'alaka', 'a', 'chur', 'aj');
INSERT INTO `tbluser` VALUES ('USER-0008', 'dawd', 'aw', 'badyaw', 'oboy', 'jaja');
INSERT INTO `tbluser` VALUES ('USER-0009', 'saasasa', 'Lemuel', 'LLL', 'rivera', 'cashier');
INSERT INTO `tbluser` VALUES ('USER-0010', 'asd', 'Lemuel', 'Gervaio', 'Rivera', 'Admin');
INSERT INTO `tbluser` VALUES ('USER-0011', 'qwerty', 'qwesad', 'wqe', 'sffa', 'qwe');

-- ----------------------------
-- Table structure for `tbl_cust`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_cust`;
CREATE TABLE `tbl_cust` (
  `cust_ID` varchar(100) NOT NULL default '',
  `store_name` varchar(500) default NULL,
  `last_name` varchar(500) default NULL,
  `first_name` varchar(500) default NULL,
  `middle_initial` varchar(500) default NULL,
  `address` varchar(500) default NULL,
  `phone` varchar(500) default NULL,
  `fax` varchar(500) default NULL,
  `email` varchar(500) default NULL,
  `salesman` varchar(500) default NULL,
  `payment_term` varchar(500) default NULL,
  `payment_method` varchar(500) default NULL,
  `bank_account` varchar(500) default NULL,
  `credit_limit` double(8,2) default NULL,
  `open_balance` double(8,2) default NULL,
  `current_balance` double(8,2) default NULL,
  PRIMARY KEY  (`cust_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_cust
-- ----------------------------
INSERT INTO `tbl_cust` VALUES ('CUST-0001', 'Car Shop', 'Rivera', 'Lemuel', 'Gervacio', 'Calumpang Binangonan, Rizal', '0909876876', 'none', 'lemuel240.lr@gmial.com', 'LEM POGI', 'term term', 'saas', '234252556', '2200.00', '21000.00', '12000.00');
INSERT INTO `tbl_cust` VALUES ('CUST-0002', 'Secret Shop', 'Marshall', 'Toby', 'Wan', 'Binangonan', '98696', '77687', 'tobiwan@gmail.com', 'LEM POGI', 'TERMinology', 'Scientific Method', '8968776', '20000.50', '3000.12', '50000.00');

-- ----------------------------
-- Table structure for `tbl_inventory`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_inventory`;
CREATE TABLE `tbl_inventory` (
  `item_ID` varchar(100) NOT NULL default '',
  `decsription` varchar(500) default NULL,
  `price` int(100) default NULL,
  `last_unit_cost` int(100) default NULL,
  `item_type` int(100) default NULL,
  `location` varchar(500) default NULL,
  `critical_level` int(100) default NULL,
  `qty_hand` int(100) default NULL,
  `qty_SO` int(100) default NULL,
  `qty_PO` int(100) default NULL,
  `supplier_ID` varchar(100) default NULL,
  PRIMARY KEY  (`item_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_inventory
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_supplier`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_supplier`;
CREATE TABLE `tbl_supplier` (
  `supplier_ID` varchar(100) NOT NULL default '',
  `store_name` varchar(500) default NULL,
  `last_name` varchar(500) default NULL,
  `first_name` varchar(500) default NULL,
  `middle_initial` varchar(500) default NULL,
  `address` varchar(500) default NULL,
  `phone` varchar(500) default NULL,
  `fax` varchar(500) default NULL,
  `email` varchar(500) default NULL,
  `salesman` varchar(500) default NULL,
  `payment_term` varchar(500) default NULL,
  `payment_method` varchar(500) default NULL,
  `bank_account` varchar(500) default NULL,
  `credit_limit` double(8,2) default NULL,
  `open_balance` double(8,2) default NULL,
  `current_balance` double(8,2) default NULL,
  PRIMARY KEY  (`supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_supplier
-- ----------------------------
INSERT INTO `tbl_supplier` VALUES ('SUPP-0001', 'lemm', 'lemm', 'asd', 'asd', 'asd', 'asd', 'asd', 'asd', 'asd', 'ad', 'asd', 'asd', '22.00', '212.00', '12.00');
INSERT INTO `tbl_supplier` VALUES ('SUPP-0002', 'sample', 'sample', 'sample', 'sample', 'samplesample', 'sample', 'sample', 'sample', 'sample', 'sample', 'sample', 'sample', '100000.00', '10000.00', '120000.00');

-- ----------------------------
-- Table structure for `tbl_truck`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_truck`;
CREATE TABLE `tbl_truck` (
  `truck_ID` varchar(50) NOT NULL default '',
  PRIMARY KEY  (`truck_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_truck
-- ----------------------------
