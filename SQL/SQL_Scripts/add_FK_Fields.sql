-- add FK keys fields only 
/*
ALTER TABLE dbo.Admin 
ADD FK_Employee_ID int ; 
*/

/*
ALTER TABLE dbo.tbl_Users
ADD FK_Product_ID int; 
*/

/*
ALTER TABLE dbo.tbl_PIM
ADD FK_USERS_ID int;
*/


ALTER TABLE dbo.tbl_Employee
ADD FK_Admin int; 
