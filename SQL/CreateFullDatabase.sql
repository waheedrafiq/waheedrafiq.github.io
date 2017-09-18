CREATE DATABASE TESCOSALES
GO
USE TESCOSALES
GO
CREATE TABLE dbo.productcategory
(
	Categoryid int IDENTITY NOT NULl PRIMARY KEY,
	Categoryname char(5) NOT NULL ,
	Categorydescription nvarchar(50) NUll, -- optional needs to be applied here
	Createdate datetime NOT NULL
	 
)
CREATE TABLE dbo.productmodel
(
  Categoryid int NOT NULL,
  Modelid int IDENTITY NOT NULL PRIMARY KEY,
  Modeldescription nvarchar(100) NULL,
  Language bit NOT NULL,
  Lastupdatedate timestamp NOT NULL

  FOREIGN KEY (Categoryid) REFERENCES dbo.productcategory(Categoryid),


)
CREATE TABLE dbo.product
(
  Productno nchar(10) NOT NULL PRIMARY KEY,
  Categoryid int NOT NULL,
  FOREIGN KEY(Categoryid) REFERENCES dbo.productcategory(Categoryid),
  Modelid int NOT NULL,
  FOREIGN KEY(Modelid) REFERENCES dbo.productmodel(Modelid),
  Productname nvarchar(50) NOT NULL,
  Colour nchar(10) NULL ,
  Cost money NULL,
  Price money NULL,
  Startdate smalldatetime NOT NULL,
  Enddate smalldatetime NOT NULL,
  Discontinueddate smalldatetime NOT NULL,
  Photo varbinary(MAX) NOT NULL,
  Stocklocation nchar(10) NOT NULL,
  Obsoleteflag bit NOT NULL,
  Supplierid int NOT NULL,
  ProductDescription nvarchar(100) NOT NULL,
  StockFigure smallint NULL,
  Lastupdatedate timestamp NOT NULL

)
CREATE TABLE dbo.customer
(
 Customerid int NOT NULL PRIMARY KEY,
 Title nchar(4) NULL,
 Firstname nvarchar(50) NULL,
 Middlename nvarchar(50) NULL,
 Surname nvarchar(50) NOT NULL,
 Companyname nchar(10) NULL,
 Salesperson int NULL,
 Emailaddr nvarchar(50) NULL,
 Phoneno numeric(18,0) NULL,
 Creditlimit datetime NULL,
 Lastupdatedate timestamp NOT NULL

)

CREATE TABLE dbo.customeraddress
(
   Addressid int IDENTITY NOT NULL PRIMARY KEY, -- pk USE IDENTITY(1,1)
   Customerid int NOT NULL,

   FOREIGN KEY(Customerid) REFERENCES dbo.customer(Customerid),
   Addresstype nchar(8) NOT NULL ,
   addressline1 nvarchar(50) NULL,
   addressline2 nvarchar(50) NULL,
   addressline3 nvarchar(50) NULL,
   PostCode nchar(10) NULL
)
CREATE TABLE dbo.customerorder
(
  Orderno int IDENTITY NOT NULL PRIMARY KEY, ---= USE IDENTITY (1,1)
  Customerid int NOT NULL ,
  FOREIGN KEY(Customerid) REFERENCES dbo.customer(Customerid),
  Orderdate smalldatetime NULL,
  Orderstatus nchar(10) NULL,
  Ordercomment nvarchar(250) NULL,
  DeliveryCost money NOT NULL,
  Ordertotal money NOT NULL,
  Blocked bit NOT NULL,
  DeliveryMethod nchar(10) NULL,
  DueDate smalldatetime NOT NULL,
  Invoiceaddressid int NULL,
  Lastupdate timestamp NOT NULL


)
CREATE TABLE dbo.orderline
(
   Orderno int NOT NULL PRIMARY KEY,
   FOREIGN KEY(Orderno) REFERENCES dbo.customerorder(Orderno),
   Productno nchar(10) NOT NULL,
   FOREIGN KEY(Productno) REFERENCES dbo.product(Productno),
   Orderlineqty smallint NOT NULL,
   Orderlinevalue money NOT NULL,
   Lastupdatedate timestamp NOT NULL
)

GO



GO
