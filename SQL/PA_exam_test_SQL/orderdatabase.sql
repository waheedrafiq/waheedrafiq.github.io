USE [master]
GO
/****** Object:  Database [orderdatabase]    Script Date: 10/03/2014 10:26:30 ******/
CREATE DATABASE [orderdatabase]

GO

USE [orderdatabase]
GO
/****** Object:  Table [dbo].[category]    Script Date: 10/03/2014 10:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[categoryid] [int] NOT NULL,
	[catdescription] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customer]    Script Date: 10/03/2014 10:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[custemail] [nvarchar](50) NOT NULL,
	[custusername] [nvarchar](100) NOT NULL,
	[custquestion] [nvarchar](50) NULL,
	[custanswer] [nvarchar](50) NULL,
	[custtelno] [nvarchar](25) NOT NULL,
	[custname] [nvarchar](50) NOT NULL,
	[custaddress1] [nvarchar](100) NOT NULL,
	[custaddress2] [nvarchar](100) NULL,
	[custaddress3] [nvarchar](100) NOT NULL,
	[custpostode] [nvarchar](10) NOT NULL,
	[custcomment] [nvarchar](100) NULL,
	[custupdatedate] [datetime] NULL,
	[customerid] [int] IDENTITY(333,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[menu]    Script Date: 10/03/2014 10:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[menuid] [int] NOT NULL,
	[restaurantid] [int] NOT NULL,
	[menutype] [nvarchar](10) NOT NULL,
	[menustartdate] [smalldatetime] NOT NULL,
	[menuexpirydate] [smalldatetime] NOT NULL,
	[menucomment] [nvarchar](100) NULL,
	[menuupdatedate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[menuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[menuitem]    Script Date: 10/03/2014 10:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[menuitem](
	[menuitemid] [int] NOT NULL,
	[menuid] [int] NOT NULL,
	[itemname] [nvarchar](50) NOT NULL,
	[itemdescription] [nvarchar](100) NOT NULL,
	[itemimage] [varbinary](max) NULL,
	[itemprice] [money] NOT NULL,
	[itempreptime] [int] NOT NULL,
	[itemcomment] [nvarchar](100) NULL,
	[itemupdatedate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[menuitemid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[order]    Script Date: 10/03/2014 10:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[customerid] [int] NOT NULL,
	[orderdate] [smalldatetime] NOT NULL,
	[orderduedate] [smalldatetime] NOT NULL,
	[orderstatus] [tinyint] NOT NULL,
	[ordertotal] [money] NULL,
	[ordertrackingid] [tinyint] NOT NULL,
	[orderdeliverytime] [time](0) NOT NULL,
	[ordercollectdeliver] [nchar](1) NOT NULL,
	[ordercomment] [nvarchar](100) NULL,
	[orderid] [int] IDENTITY(1000,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orderline]    Script Date: 10/03/2014 10:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderline](
	[orderid] [int] NOT NULL,
	[orderlineno] [int] NOT NULL,
	[menuitemid] [int] NOT NULL,
	[linequantity] [smallint] NOT NULL,
	[linestatus] [tinyint] NOT NULL,
	[lineprice] [money] NULL,
	[linepreptime] [smallint] NULL,
	[linecomment] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC,
	[orderlineno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[restaurant]    Script Date: 10/03/2014 10:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[restaurant](
	[restaurantid] [int] NOT NULL,
	[categoryid] [int] NOT NULL,
	[restname] [nvarchar](50) NOT NULL,
	[restaddress1] [nvarchar](100) NOT NULL,
	[restaddress2] [nvarchar](100) NULL,
	[restaddress3] [nvarchar](100) NOT NULL,
	[restpostcode] [nvarchar](10) NOT NULL,
	[restdescription] [nvarchar](100) NOT NULL,
	[resttelno] [nvarchar](25) NOT NULL,
	[restemail] [nvarchar](50) NULL,
	[restimage] [varbinary](max) NULL,
	[restcomment] [nvarchar](100) NULL,
	[restupdatedate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[restaurantid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[category] ([categoryid], [catdescription]) VALUES (1, N'indian restaurants')
INSERT [dbo].[category] ([categoryid], [catdescription]) VALUES (2, N'chinese restaurants')
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (101, 11, N'breakfast', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'for early risers', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (102, 11, N'dinner   ', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'everything catered for', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (103, 11, N'lunch    ', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'specially for businesses', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (104, 13, N'breakfast', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'for all tastes', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (105, 13, N'dinner   ', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'wide range of fare', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menu] ([menuid], [restaurantid], [menutype], [menustartdate], [menuexpirydate], [menucomment], [menuupdatedate]) VALUES (106, 13, N'lunch    ', CAST(0xA2E10000 AS SmallDateTime), CAST(0xA37A0000 AS SmallDateTime), N'for reired peoples', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3001, 101, N'menu item 1 - dips', N'a special paste wrapped around veg sticks', NULL, 3.5000, 5, N'may contain nut traces', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3002, 101, N'menu item 2 - bahgees', N'our best and customers favourites', NULL, 3.0000, 2, N'none needed', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3003, 101, N'menu item 3 - lamb tikka', N'', NULL, 5.5500, 10, N'oven baked', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3004, 102, N'menu item 1 - chicken massalla', N'specailly mixed spicey', NULL, 7.5000, 15, N'done in our tandoor', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3005, 102, N'menu item 2 - special biryani', N'mixed meat and pilau rice', NULL, 6.9500, 15, N'popular mild dish', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3006, 102, N'menu item 3 - vegitarian', N'spicey without meat', NULL, 5.7500, 10, N'no meat', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3007, 102, N'menu item 4 - lamb balti', N'traditional flaming dish', NULL, 7.2500, 15, N'simply the best', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3008, 102, N'menu item 5 - meat passanda', N'hot and spicy', NULL, 6.8000, 12, N'another popular dish', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3009, 105, N'menu item 1 - chicken wings', N'tender with a special sauce', NULL, 3.0000, 10, N'what you would expect', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3010, 105, N'menu item 2 - chicken chop suey', N'our nations favourite', NULL, 5.5500, 10, N'traditional stuff', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[menuitem] ([menuitemid], [menuid], [itemname], [itemdescription], [itemimage], [itemprice], [itempreptime], [itemcomment], [itemupdatedate]) VALUES (3011, 105, N'menu item 3 - chicken curry', N'traditional chinese blend', NULL, 6.0000, 10, N'better than the indian curry!', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[restaurant] ([restaurantid], [categoryid], [restname], [restaddress1], [restaddress2], [restaddress3], [restpostcode], [restdescription], [resttelno], [restemail], [restimage], [restcomment], [restupdatedate]) VALUES (11, 1, N'the bhaji', N'broad street', N'soho', N'birmingham', N'b422su', N'specialist upmarket eat-out', N'01213315400', N'bhaji@bt.com', NULL, N'the best', CAST(0x0000A2E000000000 AS DateTime))
INSERT [dbo].[restaurant] ([restaurantid], [categoryid], [restname], [restaddress1], [restaddress2], [restaddress3], [restpostcode], [restdescription], [resttelno], [restemail], [restimage], [restcomment], [restupdatedate]) VALUES (12, 1, N'rupali', N'union road', N'soho', N'birmingham', N'b422xd', N'simply the best eat-out', N'01213326745', N'rupali@yahoo.com', NULL, N'the best - really', CAST(0x0000A2B800000000 AS DateTime))
INSERT [dbo].[restaurant] ([restaurantid], [categoryid], [restname], [restaddress1], [restaddress2], [restaddress3], [restpostcode], [restdescription], [resttelno], [restemail], [restimage], [restcomment], [restupdatedate]) VALUES (13, 2, N'wingwong', N'brackley road', N'heath', N'birmingham', N'b123xd', N'original oriental', N'01211234567', N'wingwong@hotmail.com', NULL, N'come and try us', CAST(0x0000A2B800000000 AS DateTime))
ALTER TABLE [dbo].[menu] ADD  CONSTRAINT [startistoday]  DEFAULT (getdate()) FOR [menustartdate]
GO
ALTER TABLE [dbo].[order] ADD  CONSTRAINT [orderdateistoday]  DEFAULT (getdate()) FOR [orderdate]
GO
ALTER TABLE [dbo].[order] ADD  CONSTRAINT [orderstatusisone]  DEFAULT ((1)) FOR [orderstatus]
GO
ALTER TABLE [dbo].[order] ADD  CONSTRAINT [ordertrackingidisone]  DEFAULT ((1)) FOR [ordertrackingid]
GO
ALTER TABLE [dbo].[orderline] ADD  CONSTRAINT [linestatusisone]  DEFAULT ((1)) FOR [linestatus]
GO
ALTER TABLE [dbo].[menu]  WITH CHECK ADD  CONSTRAINT [FK_restaurant_menu] FOREIGN KEY([restaurantid])
REFERENCES [dbo].[restaurant] ([restaurantid])
GO
ALTER TABLE [dbo].[menu] CHECK CONSTRAINT [FK_restaurant_menu]
GO
ALTER TABLE [dbo].[menuitem]  WITH CHECK ADD  CONSTRAINT [FK_menu_menuitem] FOREIGN KEY([menuid])
REFERENCES [dbo].[menu] ([menuid])
GO
ALTER TABLE [dbo].[menuitem] CHECK CONSTRAINT [FK_menu_menuitem]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_customer_order] FOREIGN KEY([customerid])
REFERENCES [dbo].[customer] ([customerid])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_customer_order]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [FK_menuitem_line] FOREIGN KEY([menuitemid])
REFERENCES [dbo].[menuitem] ([menuitemid])
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [FK_menuitem_line]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [FK_order_line] FOREIGN KEY([orderid])
REFERENCES [dbo].[order] ([orderid])
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [FK_order_line]
GO
ALTER TABLE [dbo].[restaurant]  WITH CHECK ADD  CONSTRAINT [FK_category_restaurant] FOREIGN KEY([categoryid])
REFERENCES [dbo].[category] ([categoryid])
GO
ALTER TABLE [dbo].[restaurant] CHECK CONSTRAINT [FK_category_restaurant]
GO
ALTER TABLE [dbo].[menu]  WITH CHECK ADD  CONSTRAINT [menutypevalues] CHECK  (([menutype]='breakfast' OR [menutype]='lunch' OR [menutype]='dinner'))
GO
ALTER TABLE [dbo].[menu] CHECK CONSTRAINT [menutypevalues]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [collectdeliverhasvalue] CHECK  (([ordercollectdeliver]='C' OR [ordercollectdeliver]='D'))
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [collectdeliverhasvalue]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [duegreaterorequalorderdate] CHECK  (([orderduedate]>=[orderdate]))
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [duegreaterorequalorderdate]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [statushasvalue] CHECK  (([orderstatus]>(0) AND [orderstatus]<(4)))
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [statushasvalue]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [trackingidhasvalue] CHECK  (([ordertrackingid]>(0) AND [ordertrackingid]<(6)))
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [trackingidhasvalue]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [linestatushasvalue] CHECK  (([linestatus]>(0) AND [linestatus]<(6)))
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [linestatushasvalue]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [preptimehasvalue] CHECK  (([linepreptime]>(0)))
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [preptimehasvalue]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [pricehasvalue] CHECK  (([lineprice]>(0)))
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [pricehasvalue]
GO
ALTER TABLE [dbo].[orderline]  WITH CHECK ADD  CONSTRAINT [qtyhasvalue] CHECK  (([linequantity]>(0)))
GO
ALTER TABLE [dbo].[orderline] CHECK CONSTRAINT [qtyhasvalue]
GO
USE [master]
GO
ALTER DATABASE [orderdatabase] SET  READ_WRITE 
GO
