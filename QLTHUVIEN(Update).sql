USE [master]
GO
/****** Object:  Database [QLTHUVIEN]    Script Date: 25/10/2023 10:03:58 PM ******/
CREATE DATABASE [QLTHUVIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTHUVIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUNGKCR\MSSQL\DATA\QLTHUVIEN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTHUVIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUNGKCR\MSSQL\DATA\QLTHUVIEN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTHUVIEN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTHUVIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTHUVIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTHUVIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTHUVIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QLTHUVIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTHUVIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTHUVIEN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTHUVIEN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTHUVIEN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTHUVIEN', N'ON'
GO
ALTER DATABASE [QLTHUVIEN] SET QUERY_STORE = OFF
GO
USE [QLTHUVIEN]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuPhat]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuPhat](
	[MaPhat] [nchar](10) NOT NULL,
	[MaPT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuPhat] PRIMARY KEY CLUSTERED 
(
	[MaPhat] ASC,
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuTra]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuTra](
	[MaPT] [nchar](10) NOT NULL,
	[MaPM] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC,
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [nchar](10) NOT NULL,
	[TenDocGia] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Sdt] [nchar](10) NOT NULL,
	[Email] [nchar](30) NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Sdt] [nchar](10) NOT NULL,
	[Email] [nchar](30) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Email] [nchar](30) NOT NULL,
	[Sdt] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [nchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
	[SoLuong] [int] NOT NULL,
	[MaThe] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK__PhieuMuo__2725E7FF8C46AE15] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuPhat]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuPhat](
	[MaPhat] [nchar](10) NOT NULL,
	[NgayPhat] [date] NOT NULL,
	[NoiDungPhat] [nvarchar](250) NOT NULL,
	[PhiPhat] [float] NOT NULL,
 CONSTRAINT [PK_PhieuPhat] PRIMARY KEY CLUSTERED 
(
	[MaPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTra]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTra](
	[MaPT] [nchar](10) NOT NULL,
	[NgayTra] [date] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[TinhTrangSach] [nvarchar](100) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[NamXB] [int] NULL,
	[GiaSach] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaNXB] [nchar](10) NOT NULL,
	[MaTacGia] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nchar](10) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](255) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[LoaiTK] [varchar](50) NULL,
	[MaNV] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheDocGia]    Script Date: 25/10/2023 10:03:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheDocGia](
	[MaThe] [nchar](10) NOT NULL,
	[NgayLapThe] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[MaDocGia] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TheDocGia] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM01      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM01      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM01      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM013     ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM014     ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM015     ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM02      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM08      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM08      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM08      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM11      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM11      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM11      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM12      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM12      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM16      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM17      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM20      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM20      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM20      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM21      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM23      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM24      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM25      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM26      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM27      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM28      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM29      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM29      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM29      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM30      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM30      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM35      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM35      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM35      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM36      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM36      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM36      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM40      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM41      ', N'S01       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM41      ', N'S02       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM41      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM42      ', N'S03       ')
INSERT [dbo].[ChiTietPhieuMuon] ([MaPM], [MaSach]) VALUES (N'PM43      ', N'S03       ')
GO
INSERT [dbo].[ChiTietPhieuTra] ([MaPT], [MaPM]) VALUES (N'PT01      ', N'PM20      ')
INSERT [dbo].[ChiTietPhieuTra] ([MaPT], [MaPM]) VALUES (N'PT02      ', N'PM41      ')
INSERT [dbo].[ChiTietPhieuTra] ([MaPT], [MaPM]) VALUES (N'PT03      ', N'PM40      ')
INSERT [dbo].[ChiTietPhieuTra] ([MaPT], [MaPM]) VALUES (N'PT04      ', N'PM12      ')
INSERT [dbo].[ChiTietPhieuTra] ([MaPT], [MaPM]) VALUES (N'PT05      ', N'PM01      ')
GO
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [DiaChi], [Sdt], [Email]) VALUES (N'DG01      ', N'Hà Văn Hải', N'Tp.HCM', N'0357608667', N'vanhai11203@gmail.com         ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Sdt], [Email]) VALUES (N'NV01      ', N'Nguyễn Văn A', N'0123456789', N'A@gmail.com                   ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Sdt], [Email]) VALUES (N'NV02      ', N'Hai', N'9876543210', N'vanhai11203@gmail.com         ')
GO
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [Email], [Sdt]) VALUES (N'NXB01     ', N'Kim Đồng', N'55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', N'KimDong@gmail.com             ', N'0123456789')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [Email], [Sdt]) VALUES (N'NXB02     ', N'Lao Động', N'45 Phạm Ngọc Thạch, Phường 6, Quận 3, Thành phố Hồ Chí Minh', N'LaoDong@gmail.com             ', N'0123789022')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'04        ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 0, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM01      ', CAST(N'2021-06-14' AS Date), CAST(N'2021-06-30' AS Date), N'không có', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM013     ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'mới 1', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM014     ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'mới 1', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM015     ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'mới 1', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM017     ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'mới 10', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM02      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-24' AS Date), N'Không có', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM03      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-31' AS Date), N'Không có....', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM04      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM05      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM06      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-24' AS Date), N'Không', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM07      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM08      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM09      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM10      ', CAST(N'2023-10-21' AS Date), CAST(N'2023-10-21' AS Date), N'', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM11      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-22' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM12      ', CAST(N'2023-10-26' AS Date), CAST(N'2023-10-29' AS Date), N'', 2, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM16      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM17      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM18      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM19      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM20      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM21      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM22      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 0, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM23      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM24      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM25      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM26      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM27      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM28      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM29      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM30      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 0, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM31      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 0, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM32      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM33      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM34      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM35      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 6, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM36      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-26' AS Date), N'', 6, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM37      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM38      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM39      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM40      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM41      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 3, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM42      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'', 1, N'T01       ', N'NV01      ')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLap], [NgayTra], [GhiChu], [SoLuong], [MaThe], [MaNV]) VALUES (N'PM43      ', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-27' AS Date), N'mới mới ', 1, N'T01       ', N'NV01      ')
GO
INSERT [dbo].[PhieuTra] ([MaPT], [NgayTra], [GhiChu], [TinhTrangSach], [MaNV]) VALUES (N'PT01      ', CAST(N'2023-10-25' AS Date), N'hôm nay', N'Trả đủ sách', N'NV01      ')
INSERT [dbo].[PhieuTra] ([MaPT], [NgayTra], [GhiChu], [TinhTrangSach], [MaNV]) VALUES (N'PT02      ', CAST(N'2023-10-22' AS Date), N'', N'Không', N'NV01      ')
INSERT [dbo].[PhieuTra] ([MaPT], [NgayTra], [GhiChu], [TinhTrangSach], [MaNV]) VALUES (N'PT03      ', CAST(N'2023-10-22' AS Date), N'mới ', N'Trả đủ sách', N'NV01      ')
INSERT [dbo].[PhieuTra] ([MaPT], [NgayTra], [GhiChu], [TinhTrangSach], [MaNV]) VALUES (N'PT04      ', CAST(N'2023-10-25' AS Date), N'Mới 2', N'Trả đủ sách', N'NV01      ')
INSERT [dbo].[PhieuTra] ([MaPT], [NgayTra], [GhiChu], [TinhTrangSach], [MaNV]) VALUES (N'PT05      ', CAST(N'2023-10-25' AS Date), N'trả thiếu truyện kiều , chí phèo', N'Trả thiếu sách', N'NV01      ')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [NamXB], [GiaSach], [SoLuong], [MaNXB], [MaTacGia]) VALUES (N'S01       ', N'Truyện Kiều', N'Truyện Thơ Nôm', 2000, 70000, 15, N'NXB01     ', N'TG01      ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [NamXB], [GiaSach], [SoLuong], [MaNXB], [MaTacGia]) VALUES (N'S02       ', N'Chí Phèo', N'Truyện Ngắn', 2003, 50000, 21, N'NXB01     ', N'TG02      ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [NamXB], [GiaSach], [SoLuong], [MaNXB], [MaTacGia]) VALUES (N'S03       ', N'Làng Vũ Đại', N'Truyện Ngắn', 2005, 50000, 18, N'NXB02     ', N'TG02      ')
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG01      ', N'Nguyễn Du')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG02      ', N'Nam Cao')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG03      ', N'Ngô Tất Tố')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG04      ', N'Nguyễn Khoa Điềm')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG05      ', N'Thạch Lam')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG06      ', N'Nam Cao')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG07      ', N'Vũ Trọng Phụng')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG08      ', N'Tố Hữu')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG09      ', N'Phan Thanh Giản')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG10      ', N'Nam Cao1')
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([id], [TenTK], [MatKhau], [LoaiTK], [MaNV]) VALUES (1, N'Hai', N'123', N'Admin', NULL)
INSERT [dbo].[TaiKhoan] ([id], [TenTK], [MatKhau], [LoaiTK], [MaNV]) VALUES (2, N'NV1', N'123', N'NhanVien', N'NV01      ')
INSERT [dbo].[TaiKhoan] ([id], [TenTK], [MatKhau], [LoaiTK], [MaNV]) VALUES (3, N'dung', N'123', N'Admin', NULL)
INSERT [dbo].[TaiKhoan] ([id], [TenTK], [MatKhau], [LoaiTK], [MaNV]) VALUES (4, N'duc', N'123', N'Admin', NULL)
INSERT [dbo].[TaiKhoan] ([id], [TenTK], [MatKhau], [LoaiTK], [MaNV]) VALUES (5, N'khang', N'123', N'Admin', NULL)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
INSERT [dbo].[TheDocGia] ([MaThe], [NgayLapThe], [NgayHetHan], [MaDocGia]) VALUES (N'T01       ', CAST(N'2022-01-11' AS Date), CAST(N'2032-01-11' AS Date), N'DG01      ')
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon1] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon1]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach1] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach1]
GO
ALTER TABLE [dbo].[ChiTietPhieuPhat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuPhat_PhieuPhat] FOREIGN KEY([MaPhat])
REFERENCES [dbo].[PhieuPhat] ([MaPhat])
GO
ALTER TABLE [dbo].[ChiTietPhieuPhat] CHECK CONSTRAINT [FK_ChiTietPhieuPhat_PhieuPhat]
GO
ALTER TABLE [dbo].[ChiTietPhieuPhat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuPhat_PhieuTra] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PhieuTra] ([MaPT])
GO
ALTER TABLE [dbo].[ChiTietPhieuPhat] CHECK CONSTRAINT [FK_ChiTietPhieuPhat_PhieuTra]
GO
ALTER TABLE [dbo].[ChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTra_PhieuMuon] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietPhieuTra] CHECK CONSTRAINT [FK_ChiTietPhieuTra_PhieuMuon]
GO
ALTER TABLE [dbo].[ChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuTra_PhieuTra] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PhieuTra] ([MaPT])
GO
ALTER TABLE [dbo].[ChiTietPhieuTra] CHECK CONSTRAINT [FK_ChiTietPhieuTra_PhieuTra]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_NhanVien]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_TheDocGia] FOREIGN KEY([MaThe])
REFERENCES [dbo].[TheDocGia] ([MaThe])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_TheDocGia]
GO
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[TheDocGia]  WITH CHECK ADD  CONSTRAINT [FK_TheDocGia_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[TheDocGia] CHECK CONSTRAINT [FK_TheDocGia_DocGia]
GO
USE [master]
GO
ALTER DATABASE [QLTHUVIEN] SET  READ_WRITE 
GO
