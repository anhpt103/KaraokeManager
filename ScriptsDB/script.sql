USE [master]
GO
/****** Object:  Database [KaraokeData]    Script Date: 03/09/2020 07:23:27 ******/
CREATE DATABASE [KaraokeData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KaraokeData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\KaraokeData.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KaraokeData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\KaraokeData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KaraokeData] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KaraokeData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KaraokeData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KaraokeData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KaraokeData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KaraokeData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KaraokeData] SET ARITHABORT OFF 
GO
ALTER DATABASE [KaraokeData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KaraokeData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KaraokeData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KaraokeData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KaraokeData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KaraokeData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KaraokeData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KaraokeData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KaraokeData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KaraokeData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KaraokeData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KaraokeData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KaraokeData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KaraokeData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KaraokeData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KaraokeData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KaraokeData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KaraokeData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KaraokeData] SET  MULTI_USER 
GO
ALTER DATABASE [KaraokeData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KaraokeData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KaraokeData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KaraokeData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [KaraokeData] SET DELAYED_DURABILITY = DISABLED 
GO
USE [KaraokeData]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDonViTinh] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](100) NOT NULL,
	[GiaPhong] [decimal](18, 2) NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](150) NULL,
	[PhoneNumber] [varchar](12) NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](100) NOT NULL,
	[LoaiHangID] [int] NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongHat]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](100) NULL,
	[LoaiPhongID] [int] NOT NULL,
	[SoPhutTinhTien] [int] NOT NULL,
	[MoTa] [nvarchar](150) NULL,
	[ViTriPhong] [nvarchar](200) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_PhongHat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[NhaCungCapID] [int] NOT NULL,
	[LoaiHangID] [int] NOT NULL,
	[NhomHangID] [int] NOT NULL,
	[DonViTinhID] [int] NOT NULL,
	[Barcode] [varchar](50) NULL,
	[DuongDanAnh] [nvarchar](500) NULL,
	[MoTa] [nvarchar](150) NULL,
	[IsDelete] [bit] NOT NULL,
	[GiaBan] [decimal](18, 2) NOT NULL,
	[SoTon] [int] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Store]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Store](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](12) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](13) NULL,
	[Address] [nvarchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Sex] [bit] NULL,
	[Position] [nvarchar](100) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[LogErrors]    Script Date: 03/09/2020 07:23:27 ******/
CREATE TABLE [dbo].[LogErrors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](255) NOT NULL,
	[Level] [varchar](50) NOT NULL,
	[Logger] [varchar](255) NOT NULL,
	[Message] [varchar](4000) NOT NULL,
	[Exception] [varchar](2000) NULL,
 CONSTRAINT [PK_LogErrors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[LoaiHang] ADD  CONSTRAINT [DF_LoaiHang_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[LoaiPhong] ADD  CONSTRAINT [DF_LoaiPhong_GiaPhong]  DEFAULT ((0)) FOR [GiaPhong]
GO
ALTER TABLE [dbo].[LoaiPhong] ADD  CONSTRAINT [DF_LoaiPhong_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[NhomHang] ADD  CONSTRAINT [DF_NhomHang_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[PhongHat] ADD  CONSTRAINT [DF_PhongHat_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_GiaBan]  DEFAULT ((0)) FOR [GiaBan]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_SoTon]  DEFAULT ((0)) FOR [SoTon]
GO
ALTER TABLE [dbo].[Store] ADD  CONSTRAINT [DF_Store_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  StoredProcedure [dbo].[usp_CheckInfoLogin]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_CheckInfoLogin] 
	-- Add the parameters for the stored procedure here
	@UserName VARCHAR(50),
	@Password VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @msg NVARCHAR(50)
	IF EXISTS (SELECT 1 FROM Users u WHERE u.UserName = @UserName AND u.IsDelete = 0)
		BEGIN
			IF EXISTS (SELECT 1 FROM Users u WHERE u.UserName = @UserName AND u.Password = @Password AND u.IsDelete = 0)
				BEGIN
					SET @msg = ''
				END
			ELSE
				BEGIN
					SET @msg = N'Mật khẩu không đúng'
				END
		END
	ELSE
		BEGIN
		   SET @msg = N'Tài khoản "'+@UserName+'" không tồn tại'
		END
	SELECT @msg
END

GO
/****** Object:  StoredProcedure [dbo].[usp_RegisterUser]    Script Date: 03/09/2020 07:23:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_RegisterUser]
	-- Add the parameters for the stored procedure here
	@FullName NVARCHAR(50),
	@UserName VARCHAR(50),
	@Password VARCHAR(50),
	@Sex BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @msg NVARCHAR(50)
    IF EXISTS (SELECT 1 FROM Users u WHERE UPPER(u.UserName) = UPPER(@UserName))
		BEGIN
			SET @msg = N'Tài khoản "' + @UserName + '" đã tồn tại'
		END
	ELSE 
		BEGIN
			INSERT INTO Users(UserName, Password, FullName, Sex) VALUES (@UserName, @Password, @FullName, @Sex)
			SET @msg = ''
		END
	SELECT @msg
END

GO
/****** Object:  StoredProcedure [dbo].[usp_GetLoaiHang]    Script Date: 9/14/2020 6:37:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetLoaiHang] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT ID, TenLoai, MoTa, IsDelete,
    CASE IsDelete
        WHEN 0 THEN N'Sử dụng'
        ELSE N'Không sử dụng'
        END AS IsDelete_Text
    FROM dbo.LoaiHang
END

GO
USE [master]
GO
ALTER DATABASE [KaraokeData] SET  READ_WRITE 
GO
