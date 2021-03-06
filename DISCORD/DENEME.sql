USE [master]
GO
/****** Object:  Database [Deneme]    Script Date: 19.03.2022 20:04:49 ******/
CREATE DATABASE [Deneme]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Deneme', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Deneme.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Deneme_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Deneme_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Deneme] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Deneme].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Deneme] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Deneme] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Deneme] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Deneme] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Deneme] SET ARITHABORT OFF 
GO
ALTER DATABASE [Deneme] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Deneme] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Deneme] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Deneme] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Deneme] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Deneme] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Deneme] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Deneme] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Deneme] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Deneme] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Deneme] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Deneme] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Deneme] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Deneme] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Deneme] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Deneme] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Deneme] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Deneme] SET RECOVERY FULL 
GO
ALTER DATABASE [Deneme] SET  MULTI_USER 
GO
ALTER DATABASE [Deneme] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Deneme] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Deneme] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Deneme] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Deneme] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Deneme] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Deneme', N'ON'
GO
ALTER DATABASE [Deneme] SET QUERY_STORE = OFF
GO
USE [Deneme]
GO
/****** Object:  Table [dbo].[Arkadaslar]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arkadaslar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](100) NULL,
	[ClientName] [nvarchar](100) NULL,
	[ClientIP] [nvarchar](50) NULL,
	[ClientPort] [nvarchar](50) NULL,
	[ArkIp] [nvarchar](50) NULL,
	[ArkPort] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](100) NULL,
	[Sifre] [nvarchar](5) NULL,
	[IPAdres] [nvarchar](50) NULL,
	[PortNo] [nvarchar](50) NULL,
	[KullanciYetkiId] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](100) NULL,
	[Mesaj] [nvarchar](2000) NULL,
	[AliciAd] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OdaAdi] [nvarchar](100) NULL,
	[OdaIp] [nvarchar](50) NULL,
	[OdaPort] [nvarchar](50) NULL,
	[KurucuAd] [nvarchar](100) NULL,
	[OdadakiKisiSayisi] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OdaKisi]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdaKisi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OdaAdi] [nvarchar](100) NULL,
	[KullaniciAdi] [nvarchar](100) NULL,
	[KullanciYetkiId] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorttanSil]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorttanSil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PortNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiAd] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Arkadaslar] ON 

INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (1, N'Beste', N'Kutay', N'192.168.1.8', N'2162', N'192.168.1.8', N'2223', 1)
INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (2, N'Beste', N'Hatice', N'192.168.1.8', N'3365', N'192.168.1.8', N'6797', 1)
INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (3, N'Kutay', N'Beste', N'192.168.1.8', N'2161', N'192.168.1.8', N'7264', 1)
INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (4, N'Kutay', N'Hatice', N'192.168.1.8', N'3365', N'192.168.1.8', N'3495', 1)
INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (5, N'Hatice', N'Kutay', N'192.168.1.8', N'2162', N'192.168.1.8', N'6340', 1)
INSERT [dbo].[Arkadaslar] ([Id], [KullaniciAd], [ClientName], [ClientIP], [ClientPort], [ArkIp], [ArkPort], [Durum]) VALUES (7, N'Beste', N'Sevde', N'192.168.1.8', N'5372', N'192.168.1.8', N'3113', 1)
SET IDENTITY_INSERT [dbo].[Arkadaslar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([Id], [KullaniciAd], [Sifre], [IPAdres], [PortNo], [KullanciYetkiId], [Durum]) VALUES (1, N'Beste', N'12345', N'192.168.1.8', N'2161', 1, 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAd], [Sifre], [IPAdres], [PortNo], [KullanciYetkiId], [Durum]) VALUES (2, N'Kutay', N'54321', N'192.168.1.8', N'2162', 1, 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAd], [Sifre], [IPAdres], [PortNo], [KullanciYetkiId], [Durum]) VALUES (3, N'Hatice', N'98765', N'192.168.1.8', N'3365', 1, 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAd], [Sifre], [IPAdres], [PortNo], [KullanciYetkiId], [Durum]) VALUES (4, N'Gökhan', N'36985', N'192.168.1.8', N'8751', 1, 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAd], [Sifre], [IPAdres], [PortNo], [KullanciYetkiId], [Durum]) VALUES (5, N'Sevde', N'95115', N'192.168.1.8', N'5372', 1, 1)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Mesajlar] ON 

INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (1, N'Beste', N'Selam', N'Kutay', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (2, N'Kutay', N'Selam Beste', N'Beste', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (3, N'Beste', N'Selam', N'Ayva', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (4, N'Beste', N'', N'Ayva', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (5, N'Beste', N'Nbadsasd', N'Ayva', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (6, N'Beste', N'', N'Ayva', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (7, N'Kutay', N'Naber', N'Beste', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (8, N'Beste', N'ii sen', N'Kutay', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (9, N'Kutay', N'selam', N'Discord', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (10, N'Beste', N'selam', N'Discord', 1)
INSERT [dbo].[Mesajlar] ([Id], [KullaniciAd], [Mesaj], [AliciAd], [Durum]) VALUES (11, N'Beste', N'naber', N'Discord', 1)
SET IDENTITY_INSERT [dbo].[Mesajlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Oda] ON 

INSERT [dbo].[Oda] ([Id], [OdaAdi], [OdaIp], [OdaPort], [KurucuAd], [OdadakiKisiSayisi], [Durum]) VALUES (7, N'Beste', N'192.168.1.8', N'2228', N'Beste', 1, 1)
INSERT [dbo].[Oda] ([Id], [OdaAdi], [OdaIp], [OdaPort], [KurucuAd], [OdadakiKisiSayisi], [Durum]) VALUES (11, N'Discord', N'192.168.1.8', N'7603', N'Kutay', 1, 1)
SET IDENTITY_INSERT [dbo].[Oda] OFF
GO
SET IDENTITY_INSERT [dbo].[OdaKisi] ON 

INSERT [dbo].[OdaKisi] ([Id], [OdaAdi], [KullaniciAdi], [KullanciYetkiId], [Durum]) VALUES (1, N'Kutay', N'Kutay', 2, 1)
INSERT [dbo].[OdaKisi] ([Id], [OdaAdi], [KullaniciAdi], [KullanciYetkiId], [Durum]) VALUES (2, N'Kutay', N'Hatice', 1, 1)
INSERT [dbo].[OdaKisi] ([Id], [OdaAdi], [KullaniciAdi], [KullanciYetkiId], [Durum]) VALUES (3, N'Discord', N'Kutay', 2, 1)
INSERT [dbo].[OdaKisi] ([Id], [OdaAdi], [KullaniciAdi], [KullanciYetkiId], [Durum]) VALUES (4, N'Discord', N'Hatice', 1, 1)
INSERT [dbo].[OdaKisi] ([Id], [OdaAdi], [KullaniciAdi], [KullanciYetkiId], [Durum]) VALUES (5, N'Discord', N'Beste', 1, 1)
SET IDENTITY_INSERT [dbo].[OdaKisi] OFF
GO
SET IDENTITY_INSERT [dbo].[PorttanSil] ON 

INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (1, 2030)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (2, 2031)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (3, 2082)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (4, 2083)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (5, 2086)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (6, 2087)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (7, 2095)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (8, 2096)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (9, 2181)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (10, 2222)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (11, 2447)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (12, 2710)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (13, 2809)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (14, 3050)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (15, 3074)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (16, 3128)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (17, 3306)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (18, 3389)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (19, 3396)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (20, 3689)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (21, 3690)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (22, 3724)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (23, 3784)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (24, 4662)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (25, 4894)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (26, 4899)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (27, 5000)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (28, 5003)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (29, 5121)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (30, 5190)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (31, 5222)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (32, 5223)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (33, 5269)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (34, 5432)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (35, 5517)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (36, 5800)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (37, 5900)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (38, 6000)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (39, 6346)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (40, 6600)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (41, 6667)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (42, 9009)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (43, 9715)
INSERT [dbo].[PorttanSil] ([Id], [PortNo]) VALUES (44, 9714)
SET IDENTITY_INSERT [dbo].[PorttanSil] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([Id], [YetkiAd], [Durum]) VALUES (1, N'Uye', 1)
INSERT [dbo].[Yetki] ([Id], [YetkiAd], [Durum]) VALUES (2, N'Yonetici', 1)
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
/****** Object:  StoredProcedure [dbo].[ArkadasEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ArkadasEkle]
@KullaniciAd nvarchar(100),
@ClientName nvarchar(100),
@ClientIP nvarchar(50),
@ClientPort nvarchar(50),
@ArkIp nvarchar(50),
@ArkPort nvarchar(50),
@Durum bit
as
begin
insert into Arkadaslar(KullaniciAd,ClientName,ClientIP,ClientPort,ArkIp,ArkPort,Durum)
values(@KullaniciAd,@ClientName,@ClientIP,@ClientPort,@ArkIp,@ArkPort,@Durum)
end
GO
/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[KullaniciEkle]
@KullaniciAd nvarchar(100),
@Sifre nvarchar(5),
@IPAdres nvarchar(50),
@PortNo nvarchar (50),
@KullanciYetkiId int,
@Durum bit
as
begin
insert into Kullanici(KullaniciAd,Sifre,IPAdres,PortNo,KullanciYetkiId,Durum)
values (@KullaniciAd,@Sifre,@IPAdres,@PortNo,1,@Durum)
end
GO
/****** Object:  StoredProcedure [dbo].[MesajEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MesajEkle]
@KullaniciAd nvarchar(100),
@Mesaj nvarchar(2000),
@AliciAd nvarchar(100),
@Durum bit
as
begin
insert into Mesajlar(KullaniciAd,Mesaj,AliciAd,Durum)
values(@KullaniciAd,@Mesaj,@AliciAd,@Durum)
end
GO
/****** Object:  StoredProcedure [dbo].[OdaEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[OdaEkle]
@OdaAdi nvarchar(100),
@OdaIp nvarchar(50),
@OdaPort nvarchar(50),
@KurucuAd nvarchar(100),
@OdadakiKisiSayisi int,
@Durum bit
as
begin
insert into Oda(OdaAdi,OdaIp,OdaPort,KurucuAd,OdadakiKisiSayisi,Durum)
values(@OdaAdi,@OdaIp,@OdaPort,@KurucuAd,@OdadakiKisiSayisi,@Durum)
end
GO
/****** Object:  StoredProcedure [dbo].[OdayaKisiEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[OdayaKisiEkle]
@OdaAdi nvarchar(100),
@KullaniciAdi nvarchar(100),
@Durum bit
as
begin
insert into OdaKisi(OdaAdi,KullaniciAdi,KullanciYetkiId,Durum)
values(@OdaAdi,@KullaniciAdi,1,@Durum)
end
GO
/****** Object:  StoredProcedure [dbo].[PorttanSilNo]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[PorttanSilNo] 
@PortNo int
as
begin
insert into PorttanSil(PortNo)
values (@PortNo)
end
GO
/****** Object:  StoredProcedure [dbo].[YetkiEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[YetkiEkle]
@YetkiAd nvarchar(50),
@Durum bit
as
begin
insert into Yetki(YetkiAd,Durum)
values (@YetkiAd,@Durum)
end
GO
/****** Object:  Trigger [dbo].[OdaKisiEkle]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[OdaKisiEkle]
on [dbo].[Oda]
after insert
as
declare @OdaAdi nvarchar(100)
declare @KullaniciAdi nvarchar(100)
declare @KurucuAd nvarchar(100)
select @OdaAdi=OdaAdi from inserted
select KurucuAd from Oda where @OdaAdi=OdaAdi
select @KurucuAd=KurucuAd from inserted
insert into OdaKisi(OdaAdi,KullaniciAdi,KullanciYetkiId,Durum)
values(@OdaAdi,@KurucuAd,2,1)
update Oda set OdadakiKisiSayisi +=1 where @OdaAdi=OdaAdi
GO
ALTER TABLE [dbo].[Oda] ENABLE TRIGGER [OdaKisiEkle]
GO
/****** Object:  Trigger [dbo].[OdaSil]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[OdaSil]
on [dbo].[Oda]
after delete
as
declare @OdaAdi nvarchar(100)
begin
delete from OdaKisi where @OdaAdi=OdaAdi
delete from Mesajlar where @OdaAdi=AliciAd
end
GO
ALTER TABLE [dbo].[Oda] ENABLE TRIGGER [OdaSil]
GO
/****** Object:  Trigger [dbo].[OdaKisiCikar]    Script Date: 19.03.2022 20:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[OdaKisiCikar]
on [dbo].[OdaKisi]
after delete
as
declare @OdaAdi nvarchar(100)
begin
update Oda set OdadakiKisiSayisi -=1 where @OdaAdi=OdaAdi
end
GO
ALTER TABLE [dbo].[OdaKisi] ENABLE TRIGGER [OdaKisiCikar]
GO
USE [master]
GO
ALTER DATABASE [Deneme] SET  READ_WRITE 
GO
