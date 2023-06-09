USE [master]
GO
/****** Object:  Database [ordenes]    Script Date: 29/03/2023 05:03:36 a.m. ******/
CREATE DATABASE [ordenes] ON  PRIMARY 
( NAME = N'ordenes', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ordenes.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ordenes_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ordenes_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ordenes] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ordenes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ordenes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ordenes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ordenes] SET ARITHABORT OFF 
GO
ALTER DATABASE [ordenes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ordenes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ordenes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ordenes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ordenes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ordenes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ordenes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ordenes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ordenes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ordenes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ordenes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ordenes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ordenes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ordenes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ordenes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ordenes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ordenes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ordenes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ordenes] SET  MULTI_USER 
GO
ALTER DATABASE [ordenes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ordenes] SET DB_CHAINING OFF 
GO
USE [ordenes]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 29/03/2023 05:03:36 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NULL,
	[fecha] [varchar](255) NULL,
	[descripcion] [varchar](255) NULL,
	[estado] [varchar](255) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (1, N'kllklklk', N'asdasdasd', N'dfgvsvsd', N'sdvsdvsdv')
INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (33, N'Holikday inn', N'09/03/2023 12:00:00 a.m.', N'esta cadena se modifico', N'Cerrado')
INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (34, N'Agua progreso', N'25/03/2023 12:00:00 a.m.', N'la pantalla del cajero no prende se ecuentra en fuera de servicio', N'Abierto')
INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (35, N'Ayuntamiento centro', N'25/03/2023 12:00:00 a.m.', N'el cajero dejo de leer tarjetas pinpad no funciona le cayo cafe por un usuario', N'Abierto')
INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (36, N'FDonde', N'25/03/2023 12:00:00 a.m.', N'tenemos problema al consultar en el cajero nos podrian apoyar conectandose por favor', N'Abierto')
INSERT [dbo].[cliente] ([id], [nombre], [fecha], [descripcion], [estado]) VALUES (38, N'Holikday inn', N'07/03/2023 12:00:00 a.m.', N'esta cadena se modifico', N'Cerrado')
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
USE [master]
GO
ALTER DATABASE [ordenes] SET  READ_WRITE 
GO
