-- Create full  database with tables
-- EPOS already created on 11-02-2017 bcufaceapi.database.windows.net
-- Use EPOS


CREATE TABLE tbl_Product
(
	Product_ID Int IDENTITY(1,1) PRIMARY KEY, 
	Product_Description varchar(255),
	Product_SN varchar(100),
	Product_version varchar(100),
	Product_Cost  DECIMAL(5,2),
	Product_ImageURL varchar(255),
	FK_Product_ Users_ID Int 
)

CREATE TABLE tbl_Admin
(
    Admin_ID int IDENTITY(1,1) PRIMARY KEY,
	FK_Employee_ID int,
	Admin_Username varchar(100),
	Admin_pwd varchar(100),
	admin_Image_url varchar(255)
	
) -- end of tbl_admin


Create Table tbl_Employee
(
    Employee_ID int IDENTITY(1,1) PRIMARY KEY,
	Employee_Fname varchar(100),
	Employee_Sname varchar(100),
	Employee_AddressL1 varchar(150),
	Employee_AddressL2 varchar (100),
	Employee_PostCode varchar(20),
	Employee_Mobile char(11),
	Employee_ImagePath varchar(200),
	Employee_AccountType varchar(100),
	FK_Admin_ID int
)-- tbl_Employee 


CREATE TABLE tbl_Maintenance
(
   Maintenance_ID int IDENTITY(1,1) PRIMARY KEY,
   Fk_Product_ID int,
   FK_User_ID int ,
   maint_User_FirstName varchar(100),
   maint_User_Surname varchar(100),
   maint_Maintenance_Date datetime NOT NULL DEFAULT GETDATE()
) -- tbl_Maintenace 


CREATE TABLE tbl_FinanceManagement
(
   fin_ID int IDENTITY(1,1) PRIMARY KEY ,
   FK_employee_ID int,
   fin_unit_Sold INT,
   FK_product_Cost DECIMAL(5,2)


) -- tbl_FinanceManagement THIS WILL REQUIRE further Research of what type of basic fin infomration is required


CREATE TABLE tbl_PIM
(
  PIM_ID int IDENTITY(1,1) PRIMARY KEY,
  FK_Users_ID int,
  PIM_fname varchar(100),
  PIM_ImagePath varchar(255)

) --  end of tbl_PIM 


CREATE TABLE tbl_MS_PIM
(
   MS_ID int IDENTITY(1,1) PRIMARY KEY,
   MS_fname varchar(100),
   MS_person varchar(100),
   MS_personId varchar(100),
   MS_FaceId varchar(100),
   MS_GroupId varchar(100),
   MS_persistedFaceId char(11) ,
   MS_ImagePath varchar(255)
   FK_Users_ID

) -- end of tbl_MS_PIM

CREATE TABLE tbl_Users
(
   Users_ID int IDENTITY(1,1) PRIMARY KEY,
   Users_Fname varchar(100),
   Users_Sname varchar(100),
   Users_Email varchar(100),
   Users_Username varchar(150),
   Users_Password varchar(150),
   Users_ImagePath varchar(255),
   FK_PIM_ID int


) -- end of tbl_Users 

