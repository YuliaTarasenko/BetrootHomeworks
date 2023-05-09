--create database Librarydb

create table Customers(
CustomerId int NOT NULL PRIMARY KEY,
LastName nvarchar(100) NOT NULL,
FirstName nvarchar(100) NOT NULL,
);

create table Authors(
AuthorId int not null primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null
);

create table Books(
BookId int NOT NULL PRIMARY KEY,
Name nvarchar(max) Not null,
BookCount int,
AuthorId int FOREIGN KEY REFERENCES Authors(AuthorID)
);

create table Orders(
OrderId int NOT NULL PRIMARY KEY,
OrderDate datetime NOT NULL,
CustomerId int FOREIGN KEY REFERENCES Customers(CustomerId),
BookId int foreign key references Books(BookId)
);