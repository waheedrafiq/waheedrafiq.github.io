-- Create Foreign Keys in tables

USE EPOSv2;
GO
ALTER TABLE tbl_Admin
ADD FOREIGN KEY (FK_Employee_ID)
REFERENCES tbl_Employee(Employee_ID)

ALTER TABLE tbl_Employee
ADD FOREIGN KEY (FK_Admin_ID)
REFERENCES tbl_Admin(Admin_ID)

ALTER TABLE tbl_Maintenance
ADD FOREIGN KEY (FK_Product_ID)
REFERENCES tbl_Product(Product_ID)

ALTER TABLE tbl_Maintenance
ADD FOREIGN KEY (FK_User_ID)
REFERENCES tbl_Users(Users_ID)

ALTER TABLE tbl_FinanceManagement
ADD FOREIGN KEY (FK_employee_ID)
REFERENCES tbl_Employee(Employee_ID)



/*  next table add FK key */
ALTER TABLE tbl_Users
ADD FOREIGN KEY(FK_Product_ID)
REFERENCES tbl_Product(Product_ID)


ALTER TABLE tbl_PIM
ADD FOREIGN KEY(FK_User_ID)
REFERENCES tbl_Users(Users_ID) 

