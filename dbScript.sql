USE [master]
GO
CREATE DATABASE [StoreDb]
GO
USE [StoreDb]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryID] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[TotalCost] [decimal](18, 2) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[User]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'C1')
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'C2')
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'C3')
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'C4')
GO
INSERT [dbo].[Category] ([ID], [Name]) VALUES (5, N'C5')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [CategoryID], [Stock], [TotalCost], [CreatedOn]) VALUES (1, N'ProductOne', N'P1 Desc', 1, 10, CAST(100.00 AS Decimal(18, 2)), CAST(N'2023-12-02T19:36:23.607' AS DateTime))
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [CategoryID], [Stock], [TotalCost], [CreatedOn]) VALUES (2, N'ProductTwo', N'P2 Desc', 2, 5, CAST(72.00 AS Decimal(18, 2)), CAST(N'2023-12-02T19:36:36.357' AS DateTime))
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [CategoryID], [Stock], [TotalCost], [CreatedOn]) VALUES (3, N'ProductThree', N'P3 Desc', 3, 17, CAST(676.00 AS Decimal(18, 2)), CAST(N'2023-12-02T19:36:59.463' AS DateTime))
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [CategoryID], [Stock], [TotalCost], [CreatedOn]) VALUES (4, N'ProductFour', N'', 1, 2, CAST(11.00 AS Decimal(18, 2)), CAST(N'2023-12-02T21:03:35.063' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([ID], [UserName], [Password]) VALUES (1, N'User', N'BA3253876AED6BC22D4A6FF53D8406C6AD864195ED144AB5C87621B6C233B548BAEAE6956DF346EC8C17F5EA10F35EE3CBC514797ED7DDD3145464E2A0BAB413')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_Product_CreatedOn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreatedOn]  DEFAULT (getdate()) FOR [CreatedOn]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Product_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Product_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddProduct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddProduct] AS' 
END
GO
ALTER PROCEDURE [dbo].[AddProduct]
@Name NVARCHAR(50),
@Stock INT,
@CategoryID INT,
@TotalCostOfStock DECIMAL(18,2),
@Description NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO Product(Name,Description,CategoryID,Stock,TotalCost)
				VALUES(@Name,@Description,@CategoryID,@Stock,@TotalCostOfStock);
END
GO
/****** Object:  StoredProcedure [dbo].[GetCategories]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCategories]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCategories] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetCategories]
AS
BEGIN
	SELECT *
	FROM Category
END
GO
/****** Object:  StoredProcedure [dbo].[GetProduct]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProduct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetProduct] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetProduct]
@ID INT
AS
BEGIN
	SELECT p.ID,
		   p.Name,
		   p.Stock,
		   p.Description,
		   p.TotalCost AS TotalCostOfStock,
		   c.Name AS Category,
		   c.ID AS CategoryID
	FROM Product p JOIN Category c ON p.CategoryID = c.ID
	WHERE p.ID = @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProducts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetProducts] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetProducts]
@Name NVARCHAR(50) = NULL,
@Stock INT = NULL,
@CategoryID INT = NULL,
@TotalCostOfStock DECIMAL(18,2) = NULL
AS
BEGIN
	SELECT p.ID,
		   p.Name,
		   p.Stock,
		   p.Description,
		   p.TotalCost AS TotalCostOfStock,
		   c.Name AS Category,
		   c.ID AS CategoryID
	FROM Product p JOIN Category c ON p.CategoryID = c.ID
	WHERE (@Name IS NULL OR p.Name LIKE '%'+@Name+'%') AND
		  (@Stock IS NULL OR p.Stock = @Stock) AND
		  (@CategoryID IS NULL OR c.ID = @CategoryID) AND
		  (@TotalCostOfStock IS NULL OR p.TotalCost = @TotalCostOfStock);
END
GO
/****** Object:  StoredProcedure [dbo].[UserLogin]    Script Date: 2023-12-02 11:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UserLogin] AS' 
END
GO
ALTER PROC [dbo].[UserLogin]
@UserName NVARCHAR(50),
@Password NVARCHAR(255)
AS
BEGIN
	SELECT TOP (1) ID,
				 UserName
	FROM [User]
	WHERE UserName = @UserName AND Password = @Password
END
GO
USE [master]
GO
ALTER DATABASE [StoreDb] SET  READ_WRITE 
GO
