-- Lançamento Agenda v0.82 --

alter table `customer` add column `financial_pending` BOOL DEFAULT FALSE AFTER `name`;
alter table `customer` add column `prospecting` BOOL DEFAULT FALSE AFTER `name`;
alter table `customer` add column `responsible` VARCHAR(45) NULL AFTER `name`;
alter table `customer` add column `terminals` INT DEFAULT 0 AFTER `components`;
alter table `customer` add column `since` DATE AFTER `cellphone`;
update customer set since = '2020.11.20';

alter table `customer` change column `telephone` `telephone` CHAR(10);
alter table `customer` change column `cellphone` `cellphone` CHAR(12);
alter table `customer` change column `razao` `razao` VARCHAR(250);
alter table `customer` change column `name` `name` VARCHAR(250);
alter table `customer` change column `accountant_email` `accountant_email` VARCHAR(250);

-- Lançamento Agenda v0.83 --

alter table `serviceorder` change column `subject` `subject` VARCHAR(250);

alter table `serviceorder` add column `launched_id` INT AFTER `whorequested`;

alter table `serviceorder` 
ADD constraint `fk_launched_serviceorder` 
foreign key (`launched_id`) 
references `user`(`id`);

update `serviceorder` set `launched_id` = `user_id`;