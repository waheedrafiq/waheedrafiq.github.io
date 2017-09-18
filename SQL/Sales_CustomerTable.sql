USE sales
GO
CREATE TABLE tblcustomers
(
	CustomerID int NOT NULL,
	FirstName nvarchar(200) NULL,
	Surname nvarchar(200) NULL,
	Email nvarchar(200) NULL,
	createdate datetime NOT NULL
)
GO
