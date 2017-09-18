/* Store Procedure base upon a view   */
/* Autor : Waheed Rafiq   */
USE orderdatabase
GO
create proc upselectedorder 
@orderid int =0 
as 
SELECT     dbo.customer.custname, dbo.[order].orderid, dbo.[order].orderduedate, dbo.orderline.orderlineno, dbo.orderline.linequantity, dbo.orderline.lineprice, 
                      dbo.orderline.linepreptime, dbo.menuitem.itemname, dbo.menu.menutype, dbo.restaurant.restname
FROM         dbo.customer INNER JOIN
                      dbo.[order] ON dbo.customer.customerid = dbo.[order].customerid INNER JOIN
                      dbo.orderline ON dbo.[order].orderid = dbo.orderline.orderid INNER JOIN
                      dbo.menuitem ON dbo.orderline.menuitemid = dbo.menuitem.menuitemid INNER JOIN
                      dbo.menu ON dbo.menuitem.menuid = dbo.menu.menuid INNER JOIN
                      dbo.restaurant ON dbo.menu.restaurantid = dbo.restaurant.restaurantid INNER JOIN
                      dbo.category ON dbo.restaurant.categoryid = dbo.category.categoryid
WHERE ( dbo.[order].orderid = @orderid)
GO

