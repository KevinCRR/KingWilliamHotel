CREATE TABLE `addresses` (
	`addressID` INT NOT NULL AUTO_INCREMENT,
	`addressLine1` varchar(100) NOT NULL,
	`addressLine2` varchar(50) NOT NULL,
	`city` varchar(50) NOT NULL,
	`country` varchar(50) NOT NULL,
	`postalCode` VARCHAR(7) NOT NULL,
	`provinceID` INT NOT NULL,
	PRIMARY KEY (`addressID`)
);

CREATE TABLE `reservations` (
	`reservationID` INT NOT NULL AUTO_INCREMENT,
	`numberOfGuests` INT NOT NULL,
	`startDate` DATETIME NOT NULL,
	`endDate` DATETIME NOT NULL,
	`notes` varchar(255),
	`customerID` INT NOT NULL,
	`billID` INT NOT NULL,
	`roomNumber` INT NOT NULL,
	PRIMARY KEY (`reservationID`)
);

CREATE TABLE `rooms` (
	`roomNumber` INT NOT NULL AUTO_INCREMENT,
	`floorNumber` INT NOT NULL,
	`notes` varchar(255),
	`roomTypeID` INT NOT NULL,
	`statusID` INT NOT NULL,
	PRIMARY KEY (`roomNumber`)
);

CREATE TABLE `roomStatus` (
	`statusID` INT NOT NULL AUTO_INCREMENT,
	`statusDescription` varchar(255) NOT NULL,
	PRIMARY KEY (`statusID`)
);

CREATE TABLE `roomTypes` (
	`roomTypeID` INT NOT NULL AUTO_INCREMENT,
	`roomType` varchar(50) NOT NULL,
	`pricePerNight` DECIMAL NOT NULL,
	PRIMARY KEY (`roomTypeID`)
);

CREATE TABLE `provinces` (
	`provinceID` INT NOT NULL AUTO_INCREMENT,
	`provinceCode` VARCHAR(2) NOT NULL,
	`provinceName` varchar(30) NOT NULL,
	PRIMARY KEY (`provinceID`)
);

CREATE TABLE `customerBilling` (
	`billID` INT NOT NULL,
	`billAmount` DECIMAL NOT NULL,
	`paymentType` varchar(50) NOT NULL,
	`amountOwing` DECIMAL NOT NULL,
	PRIMARY KEY (`billID`)
);

CREATE TABLE `chargeableItems` (
	`itemID` INT NOT NULL AUTO_INCREMENT,
	`itemName` varchar(50) NOT NULL,
	`itemDescription` varchar(255) NOT NULL,
	`itemPrice` DECIMAL NOT NULL,
	PRIMARY KEY (`itemID`)
);

CREATE TABLE `transactions` (
	`transactionID` INT NOT NULL AUTO_INCREMENT,
	`amountOfItems` INT NOT NULL,
	`date` DATETIME NOT NULL,
	`billID` INT NOT NULL,
	`itemID` INT NOT NULL,
	PRIMARY KEY (`transactionID`)
);

CREATE TABLE `staff` (
	`staffID` INT NOT NULL AUTO_INCREMENT,
	`firstName` varchar(50) NOT NULL,
	`lastName` varchar(50) NOT NULL,
	`phoneNumber` varchar(50) NOT NULL,
	`salary` DECIMAL NOT NULL,
	`hiredDate` DATE NOT NULL,
	`terminationDate` DATE,
	`image` varchar(50),
	`positionID` INT NOT NULL,
	`addressID` INT NOT NULL,
	PRIMARY KEY (`staffID`)
);

CREATE TABLE `employmentPositions` (
	`positionID` INT NOT NULL AUTO_INCREMENT,
	`positionTitle` varchar(50) NOT NULL,
	`positionDescription` varchar(255) NOT NULL,
	`startingSalary` DECIMAL NOT NULL,
	PRIMARY KEY (`positionID`)
);

CREATE TABLE `users` (
	`userID` INT NOT NULL AUTO_INCREMENT,
	`username` varchar(50) NOT NULL,
	`password` varchar(50) NOT NULL,
	`staffID` INT NOT NULL,
	`roleID` INT NOT NULL,
	PRIMARY KEY (`userID`)
);

CREATE TABLE `roles` (
	`roleID` INT NOT NULL AUTO_INCREMENT,
	`roleTitle` varchar(50) NOT NULL,
	`roleDescription` varchar(255) NOT NULL,
	PRIMARY KEY (`roleID`)
);

CREATE TABLE `customers` (
	`customerID` INT NOT NULL AUTO_INCREMENT,
	`firstName` varchar(50) NOT NULL,
	`lastName` varchar(50) NOT NULL,
	`phoneNumber` varchar(50) NOT NULL,
	`addressID` INT NOT NULL,
	PRIMARY KEY (`customerID`)
);

ALTER TABLE `addresses` ADD CONSTRAINT `addresses_fk0` FOREIGN KEY (`provinceID`) REFERENCES `provinces`(`provinceID`);

ALTER TABLE `reservations` ADD CONSTRAINT `reservations_fk0` FOREIGN KEY (`customerID`) REFERENCES `customers`(`customerID`);

ALTER TABLE `reservations` ADD CONSTRAINT `reservations_fk1` FOREIGN KEY (`billID`) REFERENCES `customerBilling`(`billID`);

ALTER TABLE `reservations` ADD CONSTRAINT `reservations_fk2` FOREIGN KEY (`roomNumber`) REFERENCES `rooms`(`roomNumber`);

ALTER TABLE `rooms` ADD CONSTRAINT `rooms_fk0` FOREIGN KEY (`roomTypeID`) REFERENCES `roomTypes`(`roomTypeID`);

ALTER TABLE `rooms` ADD CONSTRAINT `rooms_fk1` FOREIGN KEY (`statusID`) REFERENCES `roomStatus`(`statusID`);

ALTER TABLE `transactions` ADD CONSTRAINT `transactions_fk0` FOREIGN KEY (`billID`) REFERENCES `customerBilling`(`billID`);

ALTER TABLE `transactions` ADD CONSTRAINT `transactions_fk1` FOREIGN KEY (`itemID`) REFERENCES `chargeableItems`(`itemID`);

ALTER TABLE `staff` ADD CONSTRAINT `staff_fk0` FOREIGN KEY (`positionID`) REFERENCES `employmentPositions`(`positionID`);

ALTER TABLE `staff` ADD CONSTRAINT `staff_fk1` FOREIGN KEY (`addressID`) REFERENCES `addresses`(`addressID`);

ALTER TABLE `users` ADD CONSTRAINT `users_fk0` FOREIGN KEY (`staffID`) REFERENCES `staff`(`staffID`);

ALTER TABLE `users` ADD CONSTRAINT `users_fk1` FOREIGN KEY (`roleID`) REFERENCES `roles`(`roleID`);

ALTER TABLE `customers` ADD CONSTRAINT `customers_fk0` FOREIGN KEY (`addressID`) REFERENCES `addresses`(`addressID`);

