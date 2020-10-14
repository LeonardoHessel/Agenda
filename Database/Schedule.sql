CREATE DATABASE `schedule`;

USE `schedule`;

CREATE TABLE IF NOT EXISTS `user` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NULL,
  `borndate` DATE NULL,
  `sex` VARCHAR(15) NULL,
  `rg` CHAR(9) NULL,
  `cpf` CHAR(11) NULL,
  `cnh` CHAR(12) NULL,
  `profileimgaddress` VARCHAR(250) NULL,
  `active` TINYINT NOT NULL DEFAULT TRUE,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `login_UNIQUE` (`login` ASC) VISIBLE)
ENGINE = InnoDB;

ALTER TABLE user MODIFY COLUMN active  bool default true;

CREATE TABLE IF NOT EXISTS `module` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `restrict` TINYINT NULL,
  PRIMARY KEY (`id`)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `access` (
  `user` INT NOT NULL,
  `module` INT NOT NULL,
  `hasaccess` TINYINT NULL,
  INDEX `User_FK_idx` (`user` ASC) VISIBLE,
  INDEX `Module_FK_idx` (`module` ASC) VISIBLE,
  CONSTRAINT `user_fk`
    FOREIGN KEY (`user`)
    REFERENCES `user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `module_fk`
    FOREIGN KEY (`module`)
    REFERENCES `module` (`id`)
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

-- Inserts --
INSERT INTO `module` (`name`, `restrict`) VALUES ("Login", FALSE);
INSERT INTO `user` VALUES (0,"Default", "123", "Default","2000-01-01","Masculino","426738998","43261603810","000000000000","",true);

-- INSERT INTO `user` (`login`, `password`, `name`) VALUES ("Default", "123", "Default");

