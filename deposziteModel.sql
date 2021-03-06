/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [DepoziteDb]
GO
/****** Object:  Table [dbo].[People]    Script Date: 9/23/2018 7:28:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](90) NOT NULL,
	[Surname] [nvarchar](90) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credities]    Script Date: 9/23/2018 7:28:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](15, 2) NOT NULL,
	[Person_Id] [int] NULL,
	[DateOfCredit] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AllPeople]    Script Date: 9/23/2018 7:28:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[AllPeople]
As
select P.Id, P.Name  from Credities As C
inner join People as P on P.Id=C.Person_Id
Group by   P.Name  , P.Id
GO
/****** Object:  View [dbo].[usp_AllPerson]    Script Date: 9/23/2018 7:28:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[usp_AllPerson]
As
SELECT People.Id,People.name,sum(Credities.Price) as Total FROM People
INNER JOIN Credities On People.Id=Credities.Person_Id
GROUP BY People.Id,People.name
GO
/****** Object:  View [dbo].[uv_all]    Script Date: 9/23/2018 7:28:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[uv_all]
As
SELeCT * from People
GO
ALTER TABLE [dbo].[Credities]  WITH CHECK ADD FOREIGN KEY([Person_Id])
REFERENCES [dbo].[People] ([Id])
GO
