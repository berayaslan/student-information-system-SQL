USE [master]
GO
/****** Object:  Database [DbOgrenciBilgiSistemi]    Script Date: 26.05.2021 20:47:06 ******/
CREATE DATABASE [DbOgrenciBilgiSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbOgrenciBilgiSistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DbOgrenciBilgiSistemi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbOgrenciBilgiSistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DbOgrenciBilgiSistemi_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbOgrenciBilgiSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET RECOVERY FULL 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbOgrenciBilgiSistemi', N'ON'
GO
USE [DbOgrenciBilgiSistemi]
GO
/****** Object:  Table [dbo].[TBL_BOLUMLER]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_BOLUMLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BOLUM] [varchar](50) NULL,
	[BOLUMKODU] [char](2) NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBL_BOLUMLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_DERSLER]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DERSLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DERS] [varchar](50) NULL,
	[DERSKODU] [char](4) NULL,
	[BOLUM] [int] NULL,
	[OGRETMEN] [int] NULL,
	[KREDI] [decimal](18, 2) NULL,
	[DERSLIK] [char](3) NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBL_DERSLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_NOTLAR]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_NOTLAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OGRENCI] [int] NULL,
	[OGRENCINO] [varchar](9) NULL,
	[BOLUM] [int] NULL,
	[DERS] [int] NULL,
	[VIZE] [decimal](18, 2) NULL,
	[FINAL] [decimal](18, 2) NULL,
	[ORTALAMA] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TBL_NOTLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRENCI]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRENCI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](30) NULL,
	[SOYAD] [varchar](30) NULL,
	[TC] [varchar](11) NULL,
	[TELEFON] [varchar](11) NULL,
	[OGRENCIDURUM] [varchar](50) NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBL_OGRENCI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRENCIBOLUMLISTESI]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRENCIBOLUMLISTESI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OGRENCI] [int] NULL,
	[BOLUM] [int] NULL,
	[OGRENCINO] [char](9) NULL,
 CONSTRAINT [PK_TBL_OGRENCIBOLUMLISTESI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRENCIDERSLISTESI]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRENCIDERSLISTESI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OGRENCI] [int] NULL,
	[OGRETMEN] [int] NULL,
	[BOLUM] [int] NULL,
	[DERS] [int] NULL,
	[KREDİ] [decimal](18, 2) NULL,
	[DERSLIK] [char](3) NULL,
 CONSTRAINT [PK_TBL_OGRENCIDERSLISTESI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_OGRETMENLER]    Script Date: 26.05.2021 20:47:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_OGRETMENLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](30) NULL,
	[SOYAD] [varchar](30) NULL,
	[BOLUM] [int] NULL,
	[SICILNO] [char](4) NULL,
	[DURUM] [bit] NULL,
 CONSTRAINT [PK_TBL_OGRETMENLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_BOLUMLER] ON 

INSERT [dbo].[TBL_BOLUMLER] ([ID], [BOLUM], [BOLUMKODU], [DURUM]) VALUES (1, N'Bilgisayar Programcılığı', N'B1', 1)
INSERT [dbo].[TBL_BOLUMLER] ([ID], [BOLUM], [BOLUMKODU], [DURUM]) VALUES (2, N'Endüstri Mühendisliği', N'B2', 1)
INSERT [dbo].[TBL_BOLUMLER] ([ID], [BOLUM], [BOLUMKODU], [DURUM]) VALUES (3, N'İnşaat Mühendisliği', N'B3', 1)
INSERT [dbo].[TBL_BOLUMLER] ([ID], [BOLUM], [BOLUMKODU], [DURUM]) VALUES (4, N'Yazılım Mühendisliği', N'B4', 1)
INSERT [dbo].[TBL_BOLUMLER] ([ID], [BOLUM], [BOLUMKODU], [DURUM]) VALUES (5, N'Mekatronik Mühendisliği', N'B5', 1)
SET IDENTITY_INSERT [dbo].[TBL_BOLUMLER] OFF
SET IDENTITY_INSERT [dbo].[TBL_DERSLER] ON 

INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (1, N'Görsel Programlama', N'B101', 1, 1, CAST(5.00 AS Decimal(18, 2)), N'100', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (2, N'Nesne Tabanlı Programlama', N'B102', 1, 2, CAST(5.00 AS Decimal(18, 2)), N'201', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (3, N'Matematik I', N'B201', 2, 2, CAST(7.00 AS Decimal(18, 2)), N'200', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (4, N'Fizik I', N'B202', 2, 7, CAST(9.00 AS Decimal(18, 2)), N'103', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (5, N'Teknik Resim', N'B203', 2, 2, CAST(6.00 AS Decimal(18, 2)), N'102', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (6, N'Grafik Tasarım', N'B103', 1, 6, CAST(3.00 AS Decimal(18, 2)), N'101', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (7, N'Fizik Laboratuvarı', N'B301', 3, 3, CAST(7.00 AS Decimal(18, 2)), N'204', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (8, N'İnşaat Mühendisliği Teknik Resim', N'B302', 3, 8, CAST(6.00 AS Decimal(18, 2)), N'105', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (9, N'Bilgisayar Programlama Diller', N'B303', 3, 3, CAST(5.00 AS Decimal(18, 2)), N'201', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (10, N'Veri Yapıları ve Algoritmalar', N'B401', 4, 4, CAST(6.00 AS Decimal(18, 2)), N'200', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (11, N'Hesaplama Kuramı', N'B402', 4, 9, CAST(8.00 AS Decimal(18, 2)), N'203', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (12, N'Siber Güvenlik', N'B403', 4, 4, CAST(6.00 AS Decimal(18, 2)), N'206', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (13, N'Temel Elektronik', N'B501', 5, 5, CAST(7.00 AS Decimal(18, 2)), N'103', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (14, N'Mühendislik Malzemeleri', N'B502', 5, 10, CAST(12.00 AS Decimal(18, 2)), N'105', 1)
INSERT [dbo].[TBL_DERSLER] ([ID], [DERS], [DERSKODU], [BOLUM], [OGRETMEN], [KREDI], [DERSLIK], [DURUM]) VALUES (15, N'Akışkanlar Mekaniği', N'B503', 5, 5, CAST(9.00 AS Decimal(18, 2)), N'201', 1)
SET IDENTITY_INSERT [dbo].[TBL_DERSLER] OFF
SET IDENTITY_INSERT [dbo].[TBL_NOTLAR] ON 

INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (1, 1, N'182105032', 1, 1, CAST(75.00 AS Decimal(18, 2)), CAST(52.00 AS Decimal(18, 2)), CAST(61.20 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (2, 1, N'182105032', 1, 6, CAST(82.00 AS Decimal(18, 2)), CAST(95.00 AS Decimal(18, 2)), CAST(89.80 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (3, 1, N'182105032', 1, 2, CAST(35.00 AS Decimal(18, 2)), CAST(68.00 AS Decimal(18, 2)), CAST(54.80 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (4, 2, N'282105034', 2, 3, CAST(45.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(78.00 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (5, 2, N'282105034', 2, 4, CAST(82.00 AS Decimal(18, 2)), CAST(95.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (6, 2, N'282105034', 2, 5, CAST(41.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (7, 2, N'382105347', 3, 7, CAST(65.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (8, 2, N'382105347', 3, 8, CAST(78.00 AS Decimal(18, 2)), CAST(54.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (9, 2, N'382105347', 3, 9, CAST(84.00 AS Decimal(18, 2)), CAST(71.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (10, 4, N'482105036', 4, 10, CAST(87.00 AS Decimal(18, 2)), CAST(98.00 AS Decimal(18, 2)), CAST(93.60 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (11, 4, N'482105036', 4, 11, CAST(45.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(78.00 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (12, 4, N'482105036', 4, 12, CAST(69.00 AS Decimal(18, 2)), CAST(73.00 AS Decimal(18, 2)), CAST(71.40 AS Decimal(18, 2)))
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (13, 5, N'182105066', 1, 1, CAST(65.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (14, 5, N'182105066', 1, 6, CAST(89.00 AS Decimal(18, 2)), CAST(64.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (15, 5, N'182105066', 1, 2, CAST(74.00 AS Decimal(18, 2)), CAST(62.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (16, 5, N'582105054', 5, 13, CAST(45.00 AS Decimal(18, 2)), CAST(87.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (17, 5, N'582105054', 5, 14, CAST(65.00 AS Decimal(18, 2)), CAST(92.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TBL_NOTLAR] ([ID], [OGRENCI], [OGRENCINO], [BOLUM], [DERS], [VIZE], [FINAL], [ORTALAMA]) VALUES (18, 5, N'582105054', 5, 15, CAST(32.00 AS Decimal(18, 2)), CAST(34.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[TBL_NOTLAR] OFF
SET IDENTITY_INSERT [dbo].[TBL_OGRENCI] ON 

INSERT [dbo].[TBL_OGRENCI] ([ID], [AD], [SOYAD], [TC], [TELEFON], [OGRENCIDURUM], [DURUM]) VALUES (1, N'Mücahit', N'Kara', N'65423556425', N'5413266468 ', N'Anabilim Dalı Öğrenci', 1)
INSERT [dbo].[TBL_OGRENCI] ([ID], [AD], [SOYAD], [TC], [TELEFON], [OGRENCIDURUM], [DURUM]) VALUES (2, N'Kadir', N'Alaca', N'54535843625', N'5323546846 ', N'Çap Öğrencisi', 1)
INSERT [dbo].[TBL_OGRENCI] ([ID], [AD], [SOYAD], [TC], [TELEFON], [OGRENCIDURUM], [DURUM]) VALUES (3, N'Özlem', N'Sezgin', N'65423556425', N'5413266468 ', N'Anabilim Dalı Öğrenci', 1)
INSERT [dbo].[TBL_OGRENCI] ([ID], [AD], [SOYAD], [TC], [TELEFON], [OGRENCIDURUM], [DURUM]) VALUES (4, N'Haluk', N'Tatar', N'10024568548', N'5432446578', N'Anabilim Dalı Öğrencisi', 1)
INSERT [dbo].[TBL_OGRENCI] ([ID], [AD], [SOYAD], [TC], [TELEFON], [OGRENCIDURUM], [DURUM]) VALUES (5, N'Melisa ', N'Küçük', N'25035665432', N'4562354868', N'Çap Öğrencisi', 1)
SET IDENTITY_INSERT [dbo].[TBL_OGRENCI] OFF
SET IDENTITY_INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ON 

INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (1, 1, 1, N'182105032')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (2, 2, 2, N'282105034')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (3, 3, 3, N'382105041')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (4, 4, 4, N'482105036')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (5, 5, 5, N'582105054')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (6, 2, 3, N'382105347')
INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] ([ID], [OGRENCI], [BOLUM], [OGRENCINO]) VALUES (7, 5, 1, N'182105066')
SET IDENTITY_INSERT [dbo].[TBL_OGRENCIBOLUMLISTESI] OFF
SET IDENTITY_INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ON 

INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (1, 1, 1, 1, 1, CAST(5.00 AS Decimal(18, 2)), N'100')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (2, 1, 6, 1, 6, CAST(3.00 AS Decimal(18, 2)), N'101')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (3, 1, 1, 1, 2, CAST(5.00 AS Decimal(18, 2)), N'201')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (4, 2, 2, 2, 3, CAST(7.00 AS Decimal(18, 2)), N'200')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (5, 2, 7, 2, 4, CAST(9.00 AS Decimal(18, 2)), N'103')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (6, 2, 2, 2, 5, CAST(6.00 AS Decimal(18, 2)), N'102')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (7, 3, 3, 3, 7, CAST(7.00 AS Decimal(18, 2)), N'204')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (8, 3, 8, 3, 8, CAST(6.00 AS Decimal(18, 2)), N'105')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (9, 3, 3, 3, 9, CAST(5.00 AS Decimal(18, 2)), N'201')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (10, 4, 4, 4, 10, CAST(6.00 AS Decimal(18, 2)), N'103')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (11, 4, 9, 4, 11, CAST(8.00 AS Decimal(18, 2)), N'102')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (12, 4, 4, 4, 12, CAST(6.00 AS Decimal(18, 2)), N'100')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (13, 5, 5, 5, 13, CAST(7.00 AS Decimal(18, 2)), N'213')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (14, 5, 10, 5, 14, CAST(12.00 AS Decimal(18, 2)), N'215')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (15, 5, 5, 5, 15, CAST(9.00 AS Decimal(18, 2)), N'106')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (16, 2, 3, 3, 7, CAST(7.00 AS Decimal(18, 2)), N'203')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (17, 2, 8, 3, 8, CAST(6.00 AS Decimal(18, 2)), N'207')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (18, 2, 3, 3, 9, CAST(5.00 AS Decimal(18, 2)), N'301')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (19, 5, 1, 1, 1, CAST(5.00 AS Decimal(18, 2)), N'201')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (20, 5, 6, 1, 2, CAST(5.00 AS Decimal(18, 2)), N'103')
INSERT [dbo].[TBL_OGRENCIDERSLISTESI] ([ID], [OGRENCI], [OGRETMEN], [BOLUM], [DERS], [KREDİ], [DERSLIK]) VALUES (21, 5, 1, 1, 6, CAST(3.00 AS Decimal(18, 2)), N'321')
SET IDENTITY_INSERT [dbo].[TBL_OGRENCIDERSLISTESI] OFF
SET IDENTITY_INSERT [dbo].[TBL_OGRETMENLER] ON 

INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (1, N'Salih', N'Yıldız', 1, N'1000', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (2, N'Cansu Ayvaz', N'Güven', 2, N'2000', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (3, N'Yavuz', N'Özarslan', 3, N'3000', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (4, N'Özlem', N'Kurt', 4, N'4000', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (5, N'Selin', N'Şekerci', 5, N'5000', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (6, N'Osman', N'Kavala', 1, N'1001', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (7, N'Kayra', N'Gül', 2, N'2001', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (8, N'Zuhal', N'Karagök', 3, N'3001', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (9, N'İsmet', N'Karasu', 4, N'4001', 1)
INSERT [dbo].[TBL_OGRETMENLER] ([ID], [AD], [SOYAD], [BOLUM], [SICILNO], [DURUM]) VALUES (10, N'Kiraz', N'Kaya', 5, N'5001', 1)
SET IDENTITY_INSERT [dbo].[TBL_OGRETMENLER] OFF
ALTER TABLE [dbo].[TBL_BOLUMLER] ADD  CONSTRAINT [DF_TBL_BOLUMLER_DURUM]  DEFAULT ((1)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBL_DERSLER] ADD  CONSTRAINT [DF_TBL_DERSLER_DURUM]  DEFAULT ((1)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBL_OGRENCI] ADD  CONSTRAINT [DF_TBL_OGRENCI_DURUM]  DEFAULT ((1)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBL_OGRETMENLER] ADD  CONSTRAINT [DF_TBL_OGRETMENLER_DURUM]  DEFAULT ((1)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TBL_DERSLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_DERSLER_TBL_BOLUMLER] FOREIGN KEY([BOLUM])
REFERENCES [dbo].[TBL_BOLUMLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_DERSLER] CHECK CONSTRAINT [FK_TBL_DERSLER_TBL_BOLUMLER]
GO
ALTER TABLE [dbo].[TBL_DERSLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_DERSLER_TBL_OGRETMENLER] FOREIGN KEY([OGRETMEN])
REFERENCES [dbo].[TBL_OGRETMENLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_DERSLER] CHECK CONSTRAINT [FK_TBL_DERSLER_TBL_OGRETMENLER]
GO
ALTER TABLE [dbo].[TBL_NOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBL_NOTLAR_TBL_BOLUMLER] FOREIGN KEY([BOLUM])
REFERENCES [dbo].[TBL_BOLUMLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_NOTLAR] CHECK CONSTRAINT [FK_TBL_NOTLAR_TBL_BOLUMLER]
GO
ALTER TABLE [dbo].[TBL_NOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBL_NOTLAR_TBL_DERSLER] FOREIGN KEY([DERS])
REFERENCES [dbo].[TBL_DERSLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_NOTLAR] CHECK CONSTRAINT [FK_TBL_NOTLAR_TBL_DERSLER]
GO
ALTER TABLE [dbo].[TBL_NOTLAR]  WITH CHECK ADD  CONSTRAINT [FK_TBL_NOTLAR_TBL_OGRENCI] FOREIGN KEY([OGRENCI])
REFERENCES [dbo].[TBL_OGRENCI] ([ID])
GO
ALTER TABLE [dbo].[TBL_NOTLAR] CHECK CONSTRAINT [FK_TBL_NOTLAR_TBL_OGRENCI]
GO
ALTER TABLE [dbo].[TBL_OGRENCIBOLUMLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIBOLUMLISTESI_TBL_BOLUMLER] FOREIGN KEY([BOLUM])
REFERENCES [dbo].[TBL_BOLUMLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIBOLUMLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIBOLUMLISTESI_TBL_BOLUMLER]
GO
ALTER TABLE [dbo].[TBL_OGRENCIBOLUMLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIBOLUMLISTESI_TBL_OGRENCI] FOREIGN KEY([OGRENCI])
REFERENCES [dbo].[TBL_OGRENCI] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIBOLUMLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIBOLUMLISTESI_TBL_OGRENCI]
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_BOLUMLER] FOREIGN KEY([BOLUM])
REFERENCES [dbo].[TBL_BOLUMLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_BOLUMLER]
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_DERSLER] FOREIGN KEY([DERS])
REFERENCES [dbo].[TBL_DERSLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_DERSLER]
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_OGRENCI] FOREIGN KEY([OGRENCI])
REFERENCES [dbo].[TBL_OGRENCI] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_OGRENCI]
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_OGRETMENLER] FOREIGN KEY([OGRETMEN])
REFERENCES [dbo].[TBL_OGRETMENLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCIDERSLISTESI] CHECK CONSTRAINT [FK_TBL_OGRENCIDERSLISTESI_TBL_OGRETMENLER]
GO
ALTER TABLE [dbo].[TBL_OGRETMENLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRETMENLER_TBL_BOLUMLER] FOREIGN KEY([BOLUM])
REFERENCES [dbo].[TBL_BOLUMLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRETMENLER] CHECK CONSTRAINT [FK_TBL_OGRETMENLER_TBL_BOLUMLER]
GO
USE [master]
GO
ALTER DATABASE [DbOgrenciBilgiSistemi] SET  READ_WRITE 
GO
