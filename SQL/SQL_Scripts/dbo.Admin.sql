﻿CREATE TABLE [dbo].[Admin]
(
    ID int IDENTITY(1,1) PRIMARY KEY,
	Employee_ID varchar(255) ,
	Employee_Sname varchar(100),
	Employee_Fname varchar(100),
	Account_Type varchar(100),
	pwd varchar(100)
)
