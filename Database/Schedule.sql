CREATE DATABASE `schedule`;
USE `schedule`;

CREATE TABLE IF NOT EXISTS `schedule`.`address` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cep` VARCHAR(8) NULL,
  `street` VARCHAR(45) NULL,
  `number` VARCHAR(45) NULL,
  `district` VARCHAR(45) NULL,
  `city` VARCHAR(45) NULL,
  `state` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`user` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NULL,
  `born` DATE NULL,
  `sex` SET('Feminino', 'Masculino') NULL,
  `rg` VARCHAR(12) NULL,
  `cpf` VARCHAR(11) NULL,
  `cnh` VARCHAR(11) NULL,
  `profile_img_address` VARCHAR(250) NULL,
  `address_id` INT NULL,
  `is_inactive` TINYINT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `login_UNIQUE` (`login` ASC) VISIBLE,
  INDEX `fk_address_idx` (`address_id` ASC) VISIBLE,
  CONSTRAINT `fk_address_user`
    FOREIGN KEY (`address_id`)
    REFERENCES `schedule`.`address` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`module` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `restrict` TINYINT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`access` (
  `user_id` INT NOT NULL,
  `module_id` INT NOT NULL,
  `hasaccess` TINYINT NULL DEFAULT 1,
  INDEX `User_FK_idx` (`user_id` ASC) VISIBLE,
  INDEX `Module_FK_idx` (`module_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_access`
    FOREIGN KEY (`user_id`)
    REFERENCES `schedule`.`user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_module_access`
    FOREIGN KEY (`module_id`)
    REFERENCES `schedule`.`module` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`product` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `is_inactive` TINYINT NULL DEFAULT 0,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`customer` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cnpj` CHAR(14) NULL,
  `ie` VARCHAR(16) NULL,
  `razao` VARCHAR(45) NULL,
  `name` VARCHAR(45) NULL,
  `telephone` VARCHAR(45) NULL,
  `cellphone` VARCHAR(45) NULL,
  `email` VARCHAR(250) NULL,
  `obs` TEXT NULL,
  `address_id` INT NULL,
  `accountant` VARCHAR(45) NULL,
  `accountant_email` VARCHAR(45) NULL,
  `product_id` INT NULL,
  `components` VARCHAR(45) NULL,
  `is_inactive` TINYINT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  INDEX `fk_address_idx` (`address_id` ASC) VISIBLE,
  INDEX `fk_product_idx` (`product_id` ASC) VISIBLE,
  CONSTRAINT `fk_address_customer`
    FOREIGN KEY (`address_id`)
    REFERENCES `schedule`.`address` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_customer`
    FOREIGN KEY (`product_id`)
    REFERENCES `schedule`.`product` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `schedule`.`serviceorder` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `customer_id` INT NULL,
  `whorequested` VARCHAR(45) NULL,
  `user_id` INT NULL,
  `subject` VARCHAR(45) NULL,
  `description` TEXT NULL,
  `solution` TEXT NULL,
  `product_id` INT NULL,
  `service` VARCHAR(45) NULL,
  `status` VARCHAR(45) NULL,
  `creation` DATETIME NULL,
  `start` DATETIME NULL,
  `end` DATETIME NULL,
  `active` TINYINT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_customer_idx` (`customer_id` ASC) VISIBLE,
  INDEX `fk_user_idx` (`user_id` ASC) VISIBLE,
  INDEX `fk_product_idx` (`product_id` ASC) VISIBLE,
  CONSTRAINT `fk_customer_serviceorder`
    FOREIGN KEY (`customer_id`)
    REFERENCES `schedule`.`customer` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_user_serviceorder`
    FOREIGN KEY (`user_id`)
    REFERENCES `schedule`.`user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_serviceorder`
    FOREIGN KEY (`product_id`)
    REFERENCES `schedule`.`product` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- trigers --
-- DROP TRIGGER IF EXISTS `user_Ai`;
DELIMITER $$
CREATE TRIGGER `user_AI` AFTER INSERT ON `user` FOR EACH ROW
BEGIN
	CALL `AddAccess` (new.id,'M');
END $$
DELIMITER ;

-- DROP TRIGGER IF EXISTS `module_AI`;
DELIMITER $$
CREATE TRIGGER `module_AI` AFTER INSERT ON `module` FOR EACH ROW
BEGIN
	CALL `AddAccess` (new.id,'U');
END $$
DELIMITER ;

-- Procedimentos --
-- DROP PROCEDURE IF EXISTS `AddAccess`;
DELIMITER $$
CREATE PROCEDURE `AddAccess` (`UsuMod_ID` INT, `Search` SET("U","M"))
BEGIN
	DECLARE `User` INT;
	DECLARE `Module` INT;
    DECLARE `TotalUser` INT;
    DECLARE `TotalModule` INT;
    DECLARE `Total` INT;
    DECLARE `Seq` INT DEFAULT 0;    
    
    SET `User` = `UsuMod_ID`;
	SET `Module` = `UsuMod_ID`;
	SET `TotalUser` = (SELECT COUNT(*) FROM `user`);
	SET `TotalModule` = (SELECT COUNT(*) FROM `module`);
    
    IF `Search` = 'M' THEN
		SET `Total` = `TotalModule`;
	ELSE
		SET `Total` = `TotalUser`;
	END IF;
    
    SearchLoop: LOOP
		IF `Search` = 'M' THEN
			SET `Module` = (SELECT `id` FROM `module` LIMIT Seq,1);
		ELSE
			SET `User` = (SELECT `id` FROM `user` LIMIT Seq,1);
		END IF;
        
		IF `Seq` < `Total` THEN
			INSERT INTO `access` VALUES(`User`, `Module`, TRUE);
            SET `Seq` = `Seq` + 1;
		ELSE
			LEAVE SearchLoop;
		END IF;
	END LOOP SearchLoop;
END $$
DELIMITER ;

