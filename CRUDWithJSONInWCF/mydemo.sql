USE [master]
GO
/****** Object:  Database [mydemo]    Script Date: 30.1.2018 21:23:16 ******/
CREATE DATABASE [mydemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mydemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\mydemo.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'mydemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\mydemo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [mydemo] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mydemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mydemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mydemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mydemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mydemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mydemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [mydemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mydemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mydemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mydemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mydemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mydemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mydemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mydemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mydemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mydemo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mydemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mydemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mydemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mydemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mydemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mydemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mydemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mydemo] SET RECOVERY FULL 
GO
ALTER DATABASE [mydemo] SET  MULTI_USER 
GO
ALTER DATABASE [mydemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mydemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mydemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mydemo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [mydemo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'mydemo', N'ON'
GO
USE [mydemo]
GO
/****** Object:  User [ra]    Script Date: 30.1.2018 21:23:17 ******/
CREATE USER [ra] FOR LOGIN [ra] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30.1.2018 21:23:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [money] NULL,
	[Quantity] [int] NULL,
	[CreationDate] [date] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (1, N'Nokia1', 100.0000, 2, CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (2, N'Nokia2', 200.0000, 3, CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (3, N'Samsung1', 300.0000, 4, CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (4, N'Samsung2', 400.0000, 5, CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (5, N'Apple1', 500.0000, 6, CAST(N'2014-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (6, N'Apple2', 500.0000, 6, CAST(N'2014-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (7, N'Apple3', 500.0000, 6, CAST(N'2014-01-01' AS Date))
INSERT [dbo].[Product] ([Id], [Name], [Price], [Quantity], [CreationDate]) VALUES (8, N'Apple4', 500.0000, 667, CAST(N'2014-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[Product] OFF
USE [master]
GO
ALTER DATABASE [mydemo] SET  READ_WRITE 
GO
