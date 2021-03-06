USE [ProductDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/12/2019 9:18:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CatagoryID] [int] IDENTITY(1,1) NOT NULL,
	[CatagoryName] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/12/2019 9:18:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[CatagoryID] [int] NULL,
	[ProductName] [varchar](50) NULL,
	[QTY] [int] NULL,
	[Price] [float] NULL,
	[Description] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CatagoryID], [CatagoryName]) VALUES (1, N'Stationery')
INSERT [dbo].[Category] ([CatagoryID], [CatagoryName]) VALUES (2, N'Computer')
INSERT [dbo].[Category] ([CatagoryID], [CatagoryName]) VALUES (3, N'Moblie')
INSERT [dbo].[Category] ([CatagoryID], [CatagoryName]) VALUES (4, N'Notebook')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (1, 1, N'Pen', 10, 15, N'Good pen for exam')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (2, 1, N'Pencil', 100, 5, N'Good pencil for drawing')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (3, 1, N'Notebook', 50, 25, N'Notebook for primary students')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (4, 1, N'Fullscape', 200, 15, N'Fullscape for higer secondary students')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (5, 1, N'Eraser', 1000, 1.5, N'Eraser for KG Students')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (6, 2, N'Mouse', 20, 200, N'USB 2.0 Mouse')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (7, 2, N'Keyboard', 20, 250, N'USB 3.0 Keyboard')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (8, 2, N'USB Stick', 1000, 450, N'4 GB Pendrives')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (9, 2, N'Laptop', 1000, 450, N'')
INSERT [dbo].[Product] ([ProductID], [CatagoryID], [ProductName], [QTY], [Price], [Description]) VALUES (10, 0, N'Table', 10, 1500, N'Computer Table')
SET IDENTITY_INSERT [dbo].[Product] OFF
