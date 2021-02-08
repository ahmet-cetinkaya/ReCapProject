﻿CREATE TABLE Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(25),
)

CREATE TABLE Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(25),
)

CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(50),
	BrandId int,
	ColorId int,
	DailyPrice decimal,
	ModelYear smallint,
	Description nvarchar(50),
	FOREIGN KEY (ColorId) REFERENCES Brands(Id),
	FOREIGN KEY (BrandId) REFERENCES Colors(Id)
)