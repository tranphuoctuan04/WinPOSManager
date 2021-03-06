USE [master]
GO
/****** Object:  Database [POSManager]    Script Date: 02/13/2015 20:50:05 ******/
CREATE DATABASE [POSManager] ON  PRIMARY 
( NAME = N'POSManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\POSManager.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POSManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\POSManager_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [POSManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POSManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POSManager] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [POSManager] SET ANSI_NULLS OFF
GO
ALTER DATABASE [POSManager] SET ANSI_PADDING OFF
GO
ALTER DATABASE [POSManager] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [POSManager] SET ARITHABORT OFF
GO
ALTER DATABASE [POSManager] SET AUTO_CLOSE ON
GO
ALTER DATABASE [POSManager] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [POSManager] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [POSManager] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [POSManager] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [POSManager] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [POSManager] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [POSManager] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [POSManager] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [POSManager] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [POSManager] SET  ENABLE_BROKER
GO
ALTER DATABASE [POSManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [POSManager] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [POSManager] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [POSManager] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [POSManager] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [POSManager] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [POSManager] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [POSManager] SET  READ_WRITE
GO
ALTER DATABASE [POSManager] SET RECOVERY SIMPLE
GO
ALTER DATABASE [POSManager] SET  MULTI_USER
GO
ALTER DATABASE [POSManager] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [POSManager] SET DB_CHAINING OFF
GO
USE [POSManager]
GO
/****** Object:  Table [dbo].[Khuvuc]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khuvuc](
	[KhuvucId] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](250) NULL,
	[STT] [int] NULL,
	[CuahangId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Khuvuc] PRIMARY KEY CLUSTERED 
(
	[KhuvucId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khuvuc] ([KhuvucId], [Ten], [STT], [CuahangId]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', N'Dãy 1', 1, NULL)
INSERT [dbo].[Khuvuc] ([KhuvucId], [Ten], [STT], [CuahangId]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bd2', N'Dãy 2', 2, NULL)
INSERT [dbo].[Khuvuc] ([KhuvucId], [Ten], [STT], [CuahangId]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bd3', N'Dãy 3', 3, NULL)
/****** Object:  Table [dbo].[_User]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[_User](
	[_UserId] [uniqueidentifier] NOT NULL,
	[NhanvienId] [uniqueidentifier] NULL,
	[_Username] [varchar](50) NULL,
	[_Password] [varchar](50) NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[_UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[_User] ([_UserId], [NhanvienId], [_Username], [_Password]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bda', N'21232f29-7a57-a5a7-4389-4a0e4a801fc3', N'21232f297a57a5a743894a0e4a801fc3', N'21232f297a57a5a743894a0e4a801fc3')
/****** Object:  Table [dbo].[Cuahang]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuahang](
	[CuahangId] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](550) NULL,
 CONSTRAINT [PK_Cuahang] PRIMARY KEY CLUSTERED 
(
	[CuahangId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuchi]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuchi](
	[ThuchiId] [uniqueidentifier] NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[Giatien] [int] NULL,
	[Lydo] [nvarchar](200) NULL,
 CONSTRAINT [PK_Thuchi] PRIMARY KEY CLUSTERED 
(
	[ThuchiId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomHanghoa]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomHanghoa](
	[NhomHanghoaId] [uniqueidentifier] NOT NULL,
	[Code] [varchar](10) NULL,
	[Ten] [nvarchar](250) NULL,
 CONSTRAINT [PK_NhomHanghoa_1] PRIMARY KEY CLUSTERED 
(
	[NhomHanghoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienId] [uniqueidentifier] NOT NULL,
	[CuahangId] [uniqueidentifier] NULL,
	[Hoten] [nvarchar](100) NULL,
	[Diachi] [nvarchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Sdt] [varchar](50) NULL,
 CONSTRAINT [PK_Nhanvien_1] PRIMARY KEY CLUSTERED 
(
	[NhanvienId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 02/13/2015 20:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[BanId] [uniqueidentifier] NOT NULL,
	[KhuvucId] [uniqueidentifier] NULL,
	[STT] [int] NULL,
	[Ten] [nvarchar](50) NULL,
	[HoadonId] [uniqueidentifier] NULL,
	[Candon] [bit] NULL,
	[Hoatdong] [bit] NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[BanId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bd8', N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', 5, N'Bàn 5', N'e00cf25a-d426-83b3-df67-8c61f42c6bd8', 0, 1)
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bdb', N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', 1, N'Bàn 1', NULL, 0, 1)
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bdc', N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', 2, N'Bàn 2', NULL, 1, 1)
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bdd', N'e00cf25a-d426-83b3-df67-8c61f42c6bd2', 6, N'Bàn 6', NULL, 0, 1)
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bde', N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', 3, N'Bàn 3', NULL, 0, 1)
INSERT [dbo].[Ban] ([BanId], [KhuvucId], [STT], [Ten], [HoadonId], [Candon], [Hoatdong]) VALUES (N'e00cf25a-d426-83b3-df67-8c61f42c6bdf', N'e00cf25a-d426-83b3-df67-8c61f42c6bd1', 4, N'Bàn 4', NULL, 0, 1)
/****** Object:  UserDefinedFunction [dbo].[CheckLogin]    Script Date: 02/13/2015 20:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[CheckLogin]

(@username varchar(max), @pass varchar(max))
RETURNs uniqueidentifier
WITH EXECUTE AS CALLER
begin
	declare @userID uniqueidentifier
	select top 1 @userID = u._UserId
	from [_User] u
	where u._Username = @username AND u.[_Password] = @pass
	
	return @userID
	
	
end
GO
/****** Object:  Table [dbo].[Hanghoa]    Script Date: 02/13/2015 20:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hanghoa](
	[HanghoaId] [uniqueidentifier] NOT NULL,
	[Code] [varchar](10) NULL,
	[Ten] [nvarchar](100) NULL,
	[NhomHanghoaId] [uniqueidentifier] NULL,
	[Hoatdong] [bit] NULL,
 CONSTRAINT [PK_Hanghoa] PRIMARY KEY CLUSTERED 
(
	[HanghoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 02/13/2015 20:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[HoadonId] [uniqueidentifier] NOT NULL,
	[NhanvienId] [uniqueidentifier] NULL,
	[TenKhachhang] [nvarchar](100) NULL,
	[BanId] [uniqueidentifier] NULL,
	[Ngaygio] [datetime] NULL,
	[CuahangId] [uniqueidentifier] NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [PK_Hoadon_1] PRIMARY KEY CLUSTERED 
(
	[HoadonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banggia]    Script Date: 02/13/2015 20:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banggia](
	[BanggiaId] [uniqueidentifier] NOT NULL,
	[HanghoaId] [uniqueidentifier] NULL,
	[Gia] [float] NULL,
	[NgayApdung] [datetime] NULL,
 CONSTRAINT [PK_Banggia] PRIMARY KEY CLUSTERED 
(
	[BanggiaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sys_BanUpdate]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sys_BanUpdate]
@BanId UniqueIdentifier, @KhuvucId UniqueIdentifier, @HoadonId UniqueIdentifier, @STT Int, @Candon Bit, @Hoatdong Bit, @Ten NVarChar(50)
as
begin
	UPDATE [Ban]
	SET 
	[KhuvucId] = @KhuvucId, [HoadonId] = @HoadonId, [STT] = @STT, [Candon] = @Candon, [Hoatdong] = @Hoatdong, [Ten] = @Ten
	WHERE [BanId] = @BanId 

	
end
GO
/****** Object:  StoredProcedure [dbo].[sys_BanSelect]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sys_BanSelect]
as
begin
	select * from [Ban]
end
GO
/****** Object:  StoredProcedure [dbo].[sys_BanInsert]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sys_BanInsert]
@BanId UniqueIdentifier, @KhuvucId UniqueIdentifier, @HoadonId UniqueIdentifier, @STT Int, @Candon Bit, @Hoatdong Bit, @Ten NVarChar(50)
as
begin
	INSERT INTO [Ban]([BanId], [KhuvucId], [HoadonId], [STT], [Candon], [Hoatdong], [Ten]) VALUES (@BanId, @KhuvucId, @HoadonId, @STT, @Candon, @Hoatdong, @Ten)
end
GO
/****** Object:  StoredProcedure [dbo].[sys_BanDelete]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sys_BanDelete]
@BanId UniqueIdentifier, @KhuvucId UniqueIdentifier, @HoadonId UniqueIdentifier, @STT Int, @Candon Bit, @Hoatdong Bit, @Ten NVarChar(50)
as
begin
	DELETE 	From 	[Ban]
	WHERE [BanId] = @BanId 

	
end
GO
/****** Object:  StoredProcedure [dbo].[Pos_Danh_GetBanItem]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Pos_Danh_GetBanItem]
as begin
	select b.*, k.Ten as TenKhuvuc from Ban b inner join Khuvuc k on k.KhuvucId = b.KhuvucId order by k.STT, b.STT
end
GO
/****** Object:  Table [dbo].[LichsuHanghoa]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichsuHanghoa](
	[LichsuHanghoaId] [uniqueidentifier] NOT NULL,
	[HanghoaId] [uniqueidentifier] NULL,
	[NgayBatdau] [datetime] NOT NULL,
	[NgayKetthuc] [datetime] NOT NULL,
 CONSTRAINT [PK_LichsuHanghoa_1] PRIMARY KEY CLUSTERED 
(
	[LichsuHanghoaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChitietHoadon]    Script Date: 02/13/2015 20:50:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietHoadon](
	[ChitietHoadonId] [uniqueidentifier] NOT NULL,
	[HoadonId] [uniqueidentifier] NULL,
	[HanghoaId] [uniqueidentifier] NULL,
	[Soluong] [int] NULL,
	[Dongia] [float] NULL,
	[Thanhtien] [float] NULL,
 CONSTRAINT [PK_ChitietHoadon] PRIMARY KEY CLUSTERED 
(
	[ChitietHoadonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Nhanvien_Cuahang]    Script Date: 02/13/2015 20:50:06 ******/
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Cuahang] FOREIGN KEY([CuahangId])
REFERENCES [dbo].[Cuahang] ([CuahangId])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Cuahang]
GO
/****** Object:  ForeignKey [FK_Ban_Khuvuc]    Script Date: 02/13/2015 20:50:06 ******/
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_Khuvuc] FOREIGN KEY([KhuvucId])
REFERENCES [dbo].[Khuvuc] ([KhuvucId])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_Khuvuc]
GO
/****** Object:  ForeignKey [FK_Hanghoa_NhomHanghoa]    Script Date: 02/13/2015 20:50:08 ******/
ALTER TABLE [dbo].[Hanghoa]  WITH CHECK ADD  CONSTRAINT [FK_Hanghoa_NhomHanghoa] FOREIGN KEY([NhomHanghoaId])
REFERENCES [dbo].[NhomHanghoa] ([NhomHanghoaId])
GO
ALTER TABLE [dbo].[Hanghoa] CHECK CONSTRAINT [FK_Hanghoa_NhomHanghoa]
GO
/****** Object:  ForeignKey [FK_Hoadon_Ban]    Script Date: 02/13/2015 20:50:08 ******/
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_Ban] FOREIGN KEY([BanId])
REFERENCES [dbo].[Ban] ([BanId])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_Ban]
GO
/****** Object:  ForeignKey [FK_Hoadon_Nhanvien]    Script Date: 02/13/2015 20:50:08 ******/
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_Nhanvien] FOREIGN KEY([NhanvienId])
REFERENCES [dbo].[Nhanvien] ([NhanvienId])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_Nhanvien]
GO
/****** Object:  ForeignKey [FK_Banggia_Hanghoa]    Script Date: 02/13/2015 20:50:08 ******/
ALTER TABLE [dbo].[Banggia]  WITH CHECK ADD  CONSTRAINT [FK_Banggia_Hanghoa] FOREIGN KEY([HanghoaId])
REFERENCES [dbo].[Hanghoa] ([HanghoaId])
GO
ALTER TABLE [dbo].[Banggia] CHECK CONSTRAINT [FK_Banggia_Hanghoa]
GO
/****** Object:  ForeignKey [FK_LichsuHanghoa_Hanghoa]    Script Date: 02/13/2015 20:50:16 ******/
ALTER TABLE [dbo].[LichsuHanghoa]  WITH CHECK ADD  CONSTRAINT [FK_LichsuHanghoa_Hanghoa] FOREIGN KEY([HanghoaId])
REFERENCES [dbo].[Hanghoa] ([HanghoaId])
GO
ALTER TABLE [dbo].[LichsuHanghoa] CHECK CONSTRAINT [FK_LichsuHanghoa_Hanghoa]
GO
/****** Object:  ForeignKey [FK_ChitietHoadon_Hanghoa]    Script Date: 02/13/2015 20:50:16 ******/
ALTER TABLE [dbo].[ChitietHoadon]  WITH CHECK ADD  CONSTRAINT [FK_ChitietHoadon_Hanghoa] FOREIGN KEY([HanghoaId])
REFERENCES [dbo].[Hanghoa] ([HanghoaId])
GO
ALTER TABLE [dbo].[ChitietHoadon] CHECK CONSTRAINT [FK_ChitietHoadon_Hanghoa]
GO
/****** Object:  ForeignKey [FK_ChitietHoadon_Hoadon]    Script Date: 02/13/2015 20:50:16 ******/
ALTER TABLE [dbo].[ChitietHoadon]  WITH CHECK ADD  CONSTRAINT [FK_ChitietHoadon_Hoadon] FOREIGN KEY([HoadonId])
REFERENCES [dbo].[Hoadon] ([HoadonId])
GO
ALTER TABLE [dbo].[ChitietHoadon] CHECK CONSTRAINT [FK_ChitietHoadon_Hoadon]
GO
