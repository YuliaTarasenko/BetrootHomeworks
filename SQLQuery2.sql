IF (NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'AccountsDB'))
BEGIN 
CREATE DATABASE AccountsDB 
END

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' 
AND TABLE_NAME = 'PhoneBook'))
BEGIN
CREATE TABLE AccountsDB.dbo.PhoneBook
(
ID int Identity(1,1) NOT NULL Primary Key,
FirstName nvarchar(100) Not NULL,
LastName nvarchar(100) Not NULL,
PhoneNumber nvarchar(20) Not NULL,
Company nvarchar(100)
)
END

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' 
AND TABLE_NAME = 'UserLoginHistory'))
BEGIN
CREATE TABLE AccountsDB.dbo.UserLoginHistory
(
ID int Identity(1,1) NOT NULL Primary Key,
UsersLogin nvarchar(20) Unique NOT NULL,
Email nvarchar(50) Unique NOT NULL,
Password nvarchar(max) NOT NULL
)
END

AlTER TABLE PhoneBook ADD City nvarchar(100);
ALTER TABLE PhoneBook DROP COLUMN Company;