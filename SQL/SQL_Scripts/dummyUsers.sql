use dummy
GO

CREATE TABLE USERS
(
  ID int IDENTITY(1,1) PRIMARY KEY,
  FirstName varchar(100),
  LastName varchar(100),
  Gender varchar(10),
  Salary Decimal(5,2),
  ImagePath varchar(255)



) -- END OF USERS TABLE