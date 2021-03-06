USE [master]
GO
/****** Object:  Database [gecenYil]    Script Date: 22.12.2017 21:35:32 ******/
CREATE DATABASE [gecenYil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'yolculuk', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\yolculuk.mdf' , SIZE = 61440KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'yolculuk_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\yolculuk_log.ldf' , SIZE = 916352KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gecenYil] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gecenYil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gecenYil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gecenYil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gecenYil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gecenYil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gecenYil] SET ARITHABORT OFF 
GO
ALTER DATABASE [gecenYil] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gecenYil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gecenYil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gecenYil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gecenYil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gecenYil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gecenYil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gecenYil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gecenYil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gecenYil] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gecenYil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gecenYil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gecenYil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gecenYil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gecenYil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gecenYil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gecenYil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gecenYil] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gecenYil] SET  MULTI_USER 
GO
ALTER DATABASE [gecenYil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gecenYil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gecenYil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gecenYil] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [gecenYil] SET DELAYED_DURABILITY = DISABLED 
GO
USE [gecenYil]
GO
/****** Object:  Table [dbo].[ocak]    Script Date: 22.12.2017 21:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ocak](
	[tarih] [date] NULL,
	[saat] [time](7) NULL,
	[yolcuSayisi] [float] NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [gecenYil] SET  READ_WRITE 
GO
