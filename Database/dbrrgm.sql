/*
Navicat MySQL Data Transfer

Source Server         : Phey
Source Server Version : 50623
Source Host           : localhost:3306
Source Database       : dbrrgm

Target Server Type    : MYSQL
Target Server Version : 50623
File Encoding         : 65001

Date: 2016-09-05 01:42:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tbluser`
-- ----------------------------
DROP TABLE IF EXISTS `tbluser`;
CREATE TABLE `tbluser` (
  `userID` varchar(50) NOT NULL,
  `password` varchar(100) DEFAULT NULL,
  `firstname` varchar(100) DEFAULT NULL,
  `middlename` varchar(100) DEFAULT NULL,
  `lastname` varchar(100) DEFAULT NULL,
  `position` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbluser
-- ----------------------------
INSERT INTO `tbluser` VALUES ('USER-0001', 'aasa', 'Aira', 'Lapuz', 'Mesa', 'Admin');
INSERT INTO `tbluser` VALUES ('USER-0002', 'chill', 'dss', 'sd', 'sda', 'sdsd');
INSERT INTO `tbluser` VALUES ('USER-0003', 'bobo', 'Jester', 'Jo', 'Dagli', 'admin');
INSERT INTO `tbluser` VALUES ('USER-0004', 'chil', 'chur', 'chill', 'chuasa', 'chill');
INSERT INTO `tbluser` VALUES ('USER-0005', 'wq', 'gdgf', 'fgf', 'dgd', 'gfgf');
INSERT INTO `tbluser` VALUES ('USER-0006', 'wq', 'wqwq', 'wqwq', 'qw', 'wqwqq');
INSERT INTO `tbluser` VALUES ('USER-0007', 'chill', 'alaka', 'a', 'chur', 'aj');
INSERT INTO `tbluser` VALUES ('USER-0008', 'dawd', 'aw', 'badyaw', 'oboy', 'jaja');
INSERT INTO `tbluser` VALUES ('USER-0009', 'saasasa', 'Lemuel', 'LLL', 'rivera', 'cashier');
INSERT INTO `tbluser` VALUES ('USER-0010', 'asd', 'Lemuel', 'Gervaio', 'Rivera', 'Admin');
INSERT INTO `tbluser` VALUES ('USER-0011', 'paul', 'qwesad', 'wqe', 'verdadero', 'qwe');

-- ----------------------------
-- Table structure for `tbl_bank_info_cust`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_bank_info_cust`;
CREATE TABLE `tbl_bank_info_cust` (
  `bank_id` varchar(255) DEFAULT NULL,
  `cust_id` varchar(255) DEFAULT NULL,
  `bank_accnt_num` varchar(255) DEFAULT NULL,
  `accnt_name` varchar(255) DEFAULT NULL,
  `bank_name` varchar(255) DEFAULT NULL,
  `bank_branch` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_bank_info_cust
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_cart_po`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_cart_po`;
CREATE TABLE `tbl_cart_po` (
  `po_cart_id` varchar(255) DEFAULT NULL,
  `po_item_id` varchar(255) DEFAULT NULL,
  `po_item_desc` varchar(255) DEFAULT NULL,
  `po_qty` int(11) DEFAULT NULL,
  `po_price` double DEFAULT NULL,
  `po_subtotal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_cart_po
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_cart_so`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_cart_so`;
CREATE TABLE `tbl_cart_so` (
  `so_cart_id` varchar(255) NOT NULL DEFAULT '',
  `so_item_id` varchar(255) DEFAULT NULL,
  `so_item_desc` varchar(255) DEFAULT NULL,
  `so_item_type` varchar(255) DEFAULT NULL,
  `so_qty` int(11) DEFAULT NULL,
  `so_price` double DEFAULT NULL,
  `so_subtotal` double DEFAULT NULL,
  PRIMARY KEY (`so_cart_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_cart_so
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_cust`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_cust`;
CREATE TABLE `tbl_cust` (
  `cust_ID` varchar(100) NOT NULL DEFAULT '',
  `store_name` varchar(500) DEFAULT NULL,
  `last_name` varchar(500) DEFAULT NULL,
  `first_name` varchar(500) DEFAULT NULL,
  `middle_initial` varchar(500) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `phone` varchar(500) DEFAULT NULL,
  `fax` varchar(500) DEFAULT NULL,
  `email` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`cust_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_cust
-- ----------------------------
INSERT INTO `tbl_cust` VALUES ('CUST-0001', 'Car Shop', 'Rivera', 'Lemuel', 'Gervacio', 'Calumpang Binangonan, Rizal', '0909876876', 'none', 'lemuel240.lr@gmial.com');
INSERT INTO `tbl_cust` VALUES ('CUST-0002', 'Secret Shop', 'Marshall', 'Toby', 'Wan', 'Binangonan', '986965', '77687', 'tobiwan@gmail.com');

-- ----------------------------
-- Table structure for `tbl_deliver_sched`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_deliver_sched`;
CREATE TABLE `tbl_deliver_sched` (
  `deliver_sched_id` varchar(255) DEFAULT NULL,
  `truck_id` varchar(255) DEFAULT NULL,
  `so_order_id` varchar(255) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_deliver_sched
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_inventory`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_inventory`;
CREATE TABLE `tbl_inventory` (
  `item_ID` varchar(100) NOT NULL DEFAULT '',
  `decsription` varchar(500) DEFAULT NULL,
  `price` int(100) DEFAULT NULL,
  `last_unit_cost` int(100) DEFAULT NULL,
  `item_type` int(100) DEFAULT NULL,
  `location` varchar(500) DEFAULT NULL,
  `safe_level` int(50) DEFAULT NULL,
  `critical_level` int(100) DEFAULT NULL,
  `reorder_level` int(50) DEFAULT NULL,
  `qty_hand` int(100) DEFAULT NULL,
  `qty_SO` int(100) DEFAULT NULL,
  `qty_PO` int(100) DEFAULT NULL,
  `supplier_ID` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`item_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_inventory
-- ----------------------------
INSERT INTO `tbl_inventory` VALUES ('item-0001', '555 SARDINES GREEN 155/100', '1333', null, '100', 'Warehouse', '10', '5', '3', '10', '10', '10', null);
INSERT INTO `tbl_inventory` VALUES ('item-0002', '555 SARDINES GREEN 425G/48', '1544', null, '48', 'Warehouse', '10', '5', '3', '10', '10', '10', null);
INSERT INTO `tbl_inventory` VALUES ('item-0003', '555 SARDINES RED 155/100', '1577', null, '100', 'Warehouse', '20', '10', null, '10', '10', '10', null);

-- ----------------------------
-- Table structure for `tbl_payment_so`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_payment_so`;
CREATE TABLE `tbl_payment_so` (
  `payment_id` varchar(255) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `order_id` varchar(255) DEFAULT NULL,
  `cust_id` varchar(255) DEFAULT NULL,
  `receipt_id` varchar(255) DEFAULT NULL,
  `payment_type` varchar(255) DEFAULT NULL,
  `amnt_receive` double DEFAULT NULL,
  `bank_id` varchar(255) DEFAULT NULL,
  `check_num` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_payment_so
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_purchase_order`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_purchase_order`;
CREATE TABLE `tbl_purchase_order` (
  `po_order_id` varchar(255) DEFAULT NULL,
  `po_supplier_id` varchar(255) DEFAULT NULL,
  `po_cart_id` varchar(255) DEFAULT NULL,
  `po_order_date` datetime DEFAULT NULL,
  `po_total_qty` int(11) DEFAULT NULL,
  `po_total_amnt` double DEFAULT NULL,
  `po_delivery_date` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_purchase_order
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_return_order`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_return_order`;
CREATE TABLE `tbl_return_order` (
  `so_return_id` varchar(255) DEFAULT NULL,
  `so_cart_id` varchar(255) DEFAULT NULL,
  `so_item_id` varchar(255) DEFAULT NULL,
  `so_qty` int(11) DEFAULT NULL,
  `so_price` double DEFAULT NULL,
  `so_subtotal_amnt` double DEFAULT NULL,
  `so_date_return` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_return_order
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_sales_order`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_sales_order`;
CREATE TABLE `tbl_sales_order` (
  `so_order_id` varchar(255) NOT NULL,
  `so_cust_id` varchar(255) DEFAULT NULL,
  `so_cart_id` varchar(255) DEFAULT NULL,
  `so_order_date` datetime DEFAULT NULL,
  `so_total_qty` int(11) DEFAULT NULL,
  `so_total_amnt` double DEFAULT NULL,
  `so_delivery_id` varchar(255) DEFAULT NULL,
  `so_remark` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_sales_order
-- ----------------------------
INSERT INTO `tbl_sales_order` VALUES ('so-0001', null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for `tbl_sold_items`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_sold_items`;
CREATE TABLE `tbl_sold_items` (
  `sold_items_id` varchar(255) DEFAULT NULL,
  `item_id` varchar(255) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `date` double DEFAULT NULL,
  `price` double DEFAULT NULL,
  `subtotal` double DEFAULT NULL,
  `cust_id` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_sold_items
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_supplier`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_supplier`;
CREATE TABLE `tbl_supplier` (
  `supplier_ID` varchar(100) NOT NULL DEFAULT '',
  `store_name` varchar(500) DEFAULT NULL,
  `last_name` varchar(500) DEFAULT NULL,
  `first_name` varchar(500) DEFAULT NULL,
  `middle_initial` varchar(500) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `phone` varchar(500) DEFAULT NULL,
  `fax` varchar(500) DEFAULT NULL,
  `email` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_supplier
-- ----------------------------
INSERT INTO `tbl_supplier` VALUES ('SUPP-0001', 'lemm', 'lemm', 'asd', 'asd', 'asd', 'asd', 'asd', 'asd');
INSERT INTO `tbl_supplier` VALUES ('SUPP-0002', 'sample', 'sample', 'sample', 'sample', 'samplesample', 'sample', 'sample', 'sample');

-- ----------------------------
-- Table structure for `tbl_truck`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_truck`;
CREATE TABLE `tbl_truck` (
  `truck_ID` varchar(50) NOT NULL DEFAULT '',
  `plate_number` varchar(50) DEFAULT NULL,
  `truck_status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`truck_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_truck
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_utilities`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_utilities`;
CREATE TABLE `tbl_utilities` (
  `utility_ID` varchar(255) DEFAULT NULL,
  `VAT` double DEFAULT NULL,
  `mark_UP` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbl_utilities
-- ----------------------------
