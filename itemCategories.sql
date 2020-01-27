/******DB******/
USE master 
GO
CREATE DATABASE mindbox;
GO

/******SCHEMA******/
USE mindbox
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1/27/2020 3:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 1/27/2020 3:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](64) NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemsCategories]    Script Date: 1/27/2020 3:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemsCategories](
	[CategoryId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
 CONSTRAINT [PK_ItemsCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC,
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/******DATA******/
USE mindbox
GO
INSERT [dbo].[Categories] ([Id], [Name]) 
VALUES 
 (1, N'comedy')
,(2, N'action')
,(3, N'adventure')
,(4, N'western')
,(5, N'thriller')
,(6, N'drama')

USE mindbox
GO
INSERT [dbo].[Items] ([Id], [Title]) 
VALUES 
(1, N'movie1')
,(2, N'movie2')
,(3, N'movie3')
,(4, N'movie4')
,(5, N'movie5')
,(6, N'movie6')
,(7, N'movie7')
,(8, N'movie8')
,(9, N'movie9')

USE mindbox
GO
INSERT [dbo].[ItemsCategories] ([CategoryId], [ItemId])
VALUES 
(1, 1)
,(1, 2)
,(1, 3)
,(2, 1)
,(2, 2)
,(2, 3)
,(3, 1)
,(3, 3)
,(3, 5)
,(4, 9)
,(6, 6)
,(6, 7)


/******QUERY******/
USE mindbox
GO
SELECT 
	category.Name AS CategoryName
	,item.Title AS ItemName
FROM items item 
	LEFT JOIN ItemsCategories ic 
		ON ic.ItemId = item.Id
	LEFT JOIN categories category 
		ON category.Id = ic.CategoryId
ORDER BY 1,2
