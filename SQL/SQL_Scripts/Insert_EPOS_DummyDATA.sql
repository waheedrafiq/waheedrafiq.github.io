-- add few dummy data in each of the EPOS system 
-- Author : Waheed Rafiq
-- Date Written: 11-02-2017


Use EPOSv2
GO

-- insert 3 random data into tbl_Product

INSERT INTO tbl_Product(Product_Description, Product_SN,Product_version, Product_Cost)
VALUES ('XploR Cane Standard Edition','125SE','SE','128.99')

INSERT INTO tbl_Product(Product_Description, Product_SN,Product_version, Product_Cost)
VALUES ('XploR Cane Pro','135PRO','PRO','299.98')

INSERT INTO tbl_Product(Product_Description, Product_SN,Product_version, Product_Cost)
VALUES ('XploR Cane Classic Edition','115CE','CE','87.97')


-- Insert 3 random data into tbl_admin
INSERT INTO tbl_Admin(Admin_Username,Admin_pwd)
VALUES ('FooBoo','password21')

INSERT INTO tbl_Admin(Admin_Username,Admin_pwd)
VALUES ('SarahJohn','password21')

INSERT INTO tbl_Admin(Admin_Username,Admin_pwd)
VALUES ('MarkSmith','password21')


-- insert 3 dummy data into tbl_Employee


INSERT INTO tbl_Employee(Employee_Fname,Employee_Sname,Employee_AddressL1,Employee_AddressL2,Employee_PostCode,Employee_Mobile,Employee_ImagePath,Employee_AccountType)
VALUES ('Foo','Boo','24 ShardEnd Rd','Birmingham','B8 QUP','07412174163','/App_Data/Images/employee/fooboo.jpg','Sales')



INSERT INTO tbl_Employee(Employee_Fname,Employee_Sname,Employee_AddressL1,Employee_AddressL2,Employee_PostCode,Employee_Mobile,Employee_ImagePath,Employee_AccountType)
VALUES ('Sarah','John','200 ShardEnd Rd','Birmingham','B8 QUP','07412354897','/App_Data/Images/employee/sarahjohn.jpg','FrontLine')


INSERT INTO tbl_Employee(Employee_Fname,Employee_Sname,Employee_AddressL1,Employee_AddressL2,Employee_PostCode,Employee_Mobile,Employee_ImagePath,Employee_AccountType)
VALUES ('Mark','Smith','45 ShardEnd Rd','Birmingham','B8 QUP','07496174888','/App_Data/Images/employee/marksmith.jpg','Admin')

-- insert data into tbl_Maintenance


INSERT INTO tbl_Maintenance(maint_User_FirstName,maint_User_Surname)
VALUES('Abbi','Mamika')


INSERT INTO tbl_Maintenance(maint_User_FirstName,maint_User_Surname)
VALUES('Julie','Yulia')


INSERT INTO tbl_Maintenance(maint_User_FirstName,maint_User_Surname)
VALUES('Madonna','Rocco')


--insert tbl_FinanceManagement
INSERT INTO tbl_FinanceManagement(fin_unit_Sold,FK_product_Cost)
VALUES ('2','100.21')

INSERT INTO tbl_FinanceManagement(fin_unit_Sold,FK_product_Cost)
VALUES ('1','689.25')

INSERT INTO tbl_FinanceManagement(fin_unit_Sold,FK_product_Cost)
VALUES ('4','2500.56')


-- INSERT INTO tbl_PIM

INSERT INTO tbl_PIM(PIM_fname,PIM_Sname,PIM_ImagePath)
VALUES ('Zurfah','Rafiq','/App_Data/images/Users/PIM/zr.jpg')

INSERT INTO tbl_PIM(PIM_fname,PIM_Sname,PIM_ImagePath)
VALUES ('ME','Boo','/App_Data/images/Users/PIM/zr.jpg')

INSERT INTO tbl_PIM(PIM_fname,PIM_Sname,PIM_ImagePath)
VALUES ('Zoo','Roo','/App_Data/images/Users/PIM/zr.jpg')



-- last table insert dummy data into user table

INSERT INTO tbl_Users (Users_Fname,Users_Sname,Users_Email,Users_Username,Users_ImagePath,Users_Password)
VALUES ('Foo','Mamika','AM@EMAIL.COM','am','/App_Data/Images/Users/AM.jpg','password')


INSERT INTO tbl_Users (Users_Fname,Users_Sname,Users_Email,Users_Username,Users_ImagePath,Users_Password)
VALUES ('Boo','Mamika','AM@EMAIL.COM','am','/App_Data/Images/Users/AM.jpg','password')

INSERT INTO tbl_Users (Users_Fname,Users_Sname,Users_Email,Users_Username,Users_ImagePath,Users_Password)
VALUES ('Woo','Mamika','AM@EMAIL.COM','am','/App_Data/Images/Users/AM.jpg','password')