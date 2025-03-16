/********************************************************************************

Author: Jonathan Rivera Vasquez
Date: 03-16-2025
Project: Real State Management System
Description: Creation of database schema for small property management project

********************************************************************************/

---------- DATABASE ----------
CREATE DATABASE realstatedb;
GO

USE realstatedb;
GO

---------- TABLES ----------
CREATE TABLE [owner](
	owner_id INT NOT NULL IDENTITY(1,1),
	[name] VARCHAR(255) NOT NULL,
	telephone VARCHAR(255) NOT NULL,
	email VARCHAR(255) NULL,
	identificationNumber VARCHAR(255) NOT NULL,
	[address] VARCHAR(255) NULL,

	CONSTRAINT [PK_owner_id] PRIMARY KEY(owner_id)
);
GO

CREATE TABLE property_type(
	property_type_id TINYINT NOT NULL IDENTITY(1,1),
	[description] VARCHAR(255) NOT NULL,

	CONSTRAINT [PK_property_type_id] PRIMARY KEY(property_type_id)
);
GO

CREATE TABLE property(
	property_id INT NOT NULL IDENTITY(1,1),
	property_type_id TINYINT NOT NULL,
	owner_id INT NOT NULL,
	number VARCHAR(255) NOT NULL,
	[address] VARCHAR(255) NOT NULL,
	area DECIMAL(6,2) NOT NULL,
	cosntruction_area DECIMAL(6,2) NULL,

	CONSTRAINT [PK_property_id] PRIMARY KEY(property_id),
	CONSTRAINT [FK_property_property_type_id] FOREIGN KEY(property_type_id) REFERENCES property_type(property_type_id),
	CONSTRAINT [FK_property_owner_id] FOREIGN KEY(owner_id) REFERENCES [owner](owner_id)
);
GO

---------- SECURITY ----------
USE master;
GO

-- CREATE LOGIN
CREATE LOGIN realstate_development
WITH PASSWORD = 'R34l.St4t3*2025#', 
CHECK_POLICY = ON;
GO

-- ADD USER IN DATABASE
USE realstatedb;
GO

CREATE USER realstate_development FOR LOGIN realstate_development;
GO

-- PERMISSIONS
ALTER ROLE [db_datareader] ADD MEMBER realstate_development;
ALTER ROLE [db_datawriter] ADD MEMBER realstate_development;
GO

-- CHECK PERMISSIONS
SELECT * FROM sys.database_principals WHERE name = 'realstate_development';
GO