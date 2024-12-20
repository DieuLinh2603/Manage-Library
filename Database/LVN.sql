USE [master]
GO
/****** Object:  Database [LVN]    Script Date: 5/11/2024 12:05:59 pm ******/
CREATE DATABASE [LVN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LVN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LVN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LVN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LVN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LVN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LVN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LVN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LVN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LVN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LVN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LVN] SET ARITHABORT OFF 
GO
ALTER DATABASE [LVN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LVN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LVN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LVN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LVN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LVN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LVN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LVN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LVN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LVN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LVN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LVN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LVN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LVN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LVN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LVN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LVN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LVN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LVN] SET  MULTI_USER 
GO
ALTER DATABASE [LVN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LVN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LVN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LVN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LVN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LVN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LVN] SET QUERY_STORE = ON
GO
ALTER DATABASE [LVN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LVN]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 5/11/2024 12:05:59 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[SoThe] [int] NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[Khoa] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuMuonTraSach]    Script Date: 5/11/2024 12:05:59 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuMuonTraSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SoThe] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_LichSuMuonTraSach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 5/11/2024 12:05:59 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[TacGia] [nvarchar](255) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[GiaSach] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/11/2024 12:05:59 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1001, N'Nguyễn Văn A', N'Công nghệ thông tin', N'vana@example.com', N'0901234567')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1002, N'Trần Thị B', N'Kinh tế', N'thib@example.com', N'0912345678')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1003, N'Lê Minh C', N'Ngôn ngữ Anh', N'minhc@example.com', N'0938765432')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1004, N'Phạm Hoàng D', N'Quản trị kinh doanh', N'hoangd@example.com', N'0945678901')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1005, N'Hoàng Yến E', N'Luật', N'yene@example.com', N'0903456789')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1006, N'Bùi Thanh F', N'Tài chính ngân hàng', N'thanhf@example.com', N'0921234567')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1007, N'Võ Đức G', N'Kế toán', N'ducg@example.com', N'0961234567')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1008, N'Đỗ Ngọc H', N'Marketing', N'ngoch@example.com', N'0932345678')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1009, N'Nguyễn Thảo I', N'Y học', N'thaoi@example.com', N'0953456789')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1010, N'Phan Minh K', N'Khoa học xã hội', N'minhk@example.com', N'0914567890')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1011, N'Đào Hải L', N'Môi trường', N'hail@example.com', N'0925678901')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1012, N'Hoàng Gia M', N'Kỹ thuật cơ khí', N'giam@example.com', N'0902345678')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1013, N'Tô Ngọc N', N'Dược', N'ngocn@example.com', N'0973456789')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1014, N'Ngô Thanh O', N'Quốc tế học', N'thano@example.com', N'0931234567')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1015, N'Thái Hà P', N'Sư phạm', N'hap@example.com', N'0922345678')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1016, N'Vương Anh Q', N'Mỹ thuật', N'anhq@example.com', N'0943456789')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1017, N'Chu Minh R', N'Kiến trúc', N'minhr@example.com', N'0911234567')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1018, N'Khổng Phúc S', N'Văn hóa học', N'phucs@example.com', N'0923456789')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1019, N'La Chí T', N'Tâm lý học', N'chit@example.com', N'0904567890')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1020, N'Tôn Nữ Lệ U', N'Quan hệ công chúng', N'leu@example.com', N'0955678901')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1021, N'Nguyễn Quốc V', N'Công nghệ thông tin', N'quocv@example.com', N'0906789012')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1022, N'Phạm Văn W', N'Kinh tế', N'vanw@example.com', N'0917890123')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1023, N'Lê Thị X', N'Ngôn ngữ Anh', N'thix@example.com', N'0938901234')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1024, N'Vũ Huy Y', N'Quản trị kinh doanh', N'huyy@example.com', N'0949012345')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1025, N'Trần Văn Z', N'Luật', N'vanz@example.com', N'0901234568')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1026, N'Nguyễn Minh AA', N'Tài chính ngân hàng', N'minhaa@example.com', N'0912345679')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1027, N'Hồ Quang BB', N'Kế toán', N'quangbb@example.com', N'0934567890')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1028, N'Nguyễn Hồng CC', N'Marketing', N'hongcc@example.com', N'0945678901')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1029, N'Phan Thị DD', N'Y học', N'thidd@example.com', N'0926789012')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1030, N'Lê Văn EE', N'Khoa học xã hội', N'vanee@example.com', N'0907890123')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1031, N'Đinh Quốc FF', N'Môi trường', N'quocff@example.com', N'0918901234')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1032, N'Bùi Văn GG', N'Kỹ thuật cơ khí', N'vangg@example.com', N'0939012345')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1033, N'Nguyễn Ngọc HH', N'Dược', N'ngocgg@example.com', N'0940123456')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1034, N'Tôn Thị II', N'Quốc tế học', N'thii@example.com', N'0921234568')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1035, N'Võ Minh JJ', N'Sư phạm', N'minhj@example.com', N'0902345679')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1036, N'Hồ Kim KK', N'Mỹ thuật', N'kimkk@example.com', N'0913456780')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1037, N'Nguyễn Trí LL', N'Kiến trúc', N'trill@example.com', N'0934567891')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1038, N'Đỗ Nhật MM', N'Văn hóa học', N'nhatmm@example.com', N'0905678902')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1039, N'Phan Hoàng NN', N'Tâm lý học', N'hoangnn@example.com', N'0926789013')
INSERT [dbo].[DocGia] ([SoThe], [HoTen], [Khoa], [Email], [SDT]) VALUES (1040, N'Nguyễn Thái OO', N'Quan hệ công chúng', N'thaio@example.com', N'0907890124')
GO
SET IDENTITY_INSERT [dbo].[LichSuMuonTraSach] ON 

INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (1, 1001, 1, CAST(N'2024-10-01' AS Date), CAST(N'2024-10-15' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (2, 1002, 2, CAST(N'2024-10-02' AS Date), CAST(N'2024-10-16' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (3, 1003, 3, CAST(N'2024-10-03' AS Date), CAST(N'2024-10-17' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (4, 1004, 4, CAST(N'2024-10-04' AS Date), CAST(N'2024-10-18' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (5, 1005, 5, CAST(N'2024-10-05' AS Date), CAST(N'2024-10-19' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (6, 1006, 6, CAST(N'2024-10-06' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (7, 1007, 7, CAST(N'2024-10-07' AS Date), CAST(N'2024-10-20' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (8, 1008, 8, CAST(N'2024-10-08' AS Date), CAST(N'2024-10-21' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (9, 1009, 9, CAST(N'2024-10-09' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (10, 1010, 10, CAST(N'2024-10-10' AS Date), CAST(N'2024-10-22' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (11, 1011, 11, CAST(N'2024-10-11' AS Date), CAST(N'2024-10-23' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (12, 1012, 12, CAST(N'2024-10-12' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (13, 1013, 13, CAST(N'2024-10-13' AS Date), CAST(N'2024-10-24' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (14, 1014, 14, CAST(N'2024-10-14' AS Date), CAST(N'2024-10-25' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (15, 1015, 15, CAST(N'2024-10-15' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (16, 1016, 16, CAST(N'2024-10-16' AS Date), CAST(N'2024-10-26' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (17, 1017, 17, CAST(N'2024-10-17' AS Date), CAST(N'2024-10-27' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (18, 1018, 18, CAST(N'2024-10-18' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (19, 1019, 19, CAST(N'2024-10-19' AS Date), CAST(N'2024-10-28' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (20, 1020, 20, CAST(N'2024-10-20' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (21, 1021, 21, CAST(N'2024-10-21' AS Date), CAST(N'2024-10-29' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (22, 1022, 22, CAST(N'2024-10-22' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (23, 1023, 23, CAST(N'2024-10-23' AS Date), CAST(N'2024-10-30' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (24, 1024, 24, CAST(N'2024-10-24' AS Date), CAST(N'2024-10-31' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (25, 1025, 25, CAST(N'2024-10-25' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (26, 1026, 26, CAST(N'2024-10-26' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (27, 1027, 27, CAST(N'2024-10-27' AS Date), CAST(N'2024-10-28' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (28, 1028, 28, CAST(N'2024-10-28' AS Date), CAST(N'2024-10-29' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (29, 1029, 29, CAST(N'2024-10-29' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (30, 1030, 30, CAST(N'2024-10-30' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (31, 1031, 31, CAST(N'2024-10-31' AS Date), CAST(N'2024-11-01' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (32, 1032, 32, CAST(N'2024-11-01' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (33, 1033, 33, CAST(N'2024-11-02' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (34, 1034, 34, CAST(N'2024-11-03' AS Date), CAST(N'2024-11-04' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (35, 1035, 35, CAST(N'2024-11-04' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (36, 1036, 36, CAST(N'2024-11-05' AS Date), CAST(N'2024-11-06' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (37, 1037, 37, CAST(N'2024-11-06' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (38, 1038, 38, CAST(N'2024-11-07' AS Date), CAST(N'2024-11-08' AS Date))
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (39, 1039, 39, CAST(N'2024-11-08' AS Date), NULL)
INSERT [dbo].[LichSuMuonTraSach] ([id], [SoThe], [MaSach], [NgayMuon], [NgayTra]) VALUES (40, 1040, 40, CAST(N'2024-11-09' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[LichSuMuonTraSach] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (1, N'Những Người Khốn Khổ', N'Victor Hugo', N'Tiểu thuyết', 1862, 150000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (2, N'Harry Potter và Hòn Đá Phù Thủy', N'J.K. Rowling', N'Phiêu lưu', 1997, 120000, 35)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (3, N'Đắc Nhân Tâm', N'Dale Carnegie', N'Tâm lý - Kỹ năng', 1936, 80000, 50)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (4, N'Nhà Giả Kim', N'Paulo Coelho', N'Tiểu thuyết', 1988, 100000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (5, N'C++ For Beginners', N'Bjarne Stroustrup', N'Lập trình', 2000, 200000, 15)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (6, N'1984', N'George Orwell', N'Khoa học viễn tưởng', 1949, 90000, 40)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (7, N'Toán Học Cơ Bản', N'Nguyễn Văn A', N'Giáo khoa', 2015, 60000, 45)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (8, N'Sử Việt - 12 Khúc Tráng Ca', N'Dương Trung Quốc', N'Lịch sử', 2020, 75000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (9, N'Mắt Biếc', N'Nguyễn Nhật Ánh', N'Tiểu thuyết', 1990, 50000, 60)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (10, N'The Art of War', N'Tôn Tử', N'Triết học', -500, 90000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (11, N'Lập Trình Python Cơ Bản', N'Nguyễn Hoàng', N'Lập trình', 2021, 150000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (12, N'Thế Giới Phẳng', N'Thomas L. Friedman', N'Kinh tế', 2005, 110000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (13, N'Tiếng Gọi Nơi Hoang Dã', N'Jack London', N'Phiêu lưu', 1903, 85000, 40)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (14, N'Trí Tuệ Xúc Cảm', N'Daniel Goleman', N'Tâm lý - Kỹ năng', 1995, 130000, 18)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (15, N'Lịch Sử Thế Giới', N'Will Durant', N'Lịch sử', 1949, 120000, 12)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (16, N'Sức Mạnh Của Thói Quen', N'Charles Duhigg', N'Tâm lý - Kỹ năng', 2012, 95000, 45)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (17, N'Cuốn Theo Chiều Gió', N'Margaret Mitchell', N'Tiểu thuyết', 1936, 140000, 33)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (18, N'Mật Mã Da Vinci', N'Dan Brown', N'Hình sự', 2003, 115000, 28)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (19, N'Hồi Ký Lê Duẩn', N'Lê Duẩn', N'Lịch sử', 1989, 105000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (20, N'Tư Duy Nhanh Và Chậm', N'Daniel Kahneman', N'Tâm lý - Kỹ năng', 2011, 125000, 26)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (21, N'Harry Potter và Phòng Chứa Bí Mật', N'J.K. Rowling', N'Phiêu lưu', 1998, 125000, 38)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (22, N'Tình Yêu Thời Thổ Tả', N'Gabriel Garcia Marquez', N'Tiểu thuyết', 1985, 99000, 15)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (23, N'Kẻ Trộm Sách', N'Markus Zusak', N'Tiểu thuyết', 2005, 135000, 22)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (24, N'Người Dám Cho Đi', N'Bob Burg', N'Tâm lý - Kỹ năng', 2008, 92000, 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (25, N'Tiểu Luận Phật Giáo', N'Thích Nhất Hạnh', N'Tôn giáo', 1993, 70000, 24)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (26, N'Nghĩ Giàu Làm Giàu', N'Napoleon Hill', N'Kinh doanh', 1937, 100000, 50)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (27, N'Tư Bản Luận', N'Karl Marx', N'Kinh tế', 1867, 160000, 10)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (28, N'Trăm Năm Cô Đơn', N'Gabriel Garcia Marquez', N'Tiểu thuyết', 1967, 99000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (29, N'Sinh Tồn Giữa Sa Mạc', N'Bear Grylls', N'Sinh tồn', 2015, 105000, 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (30, N'Tinh Hoa Kinh Doanh', N'Jim Collins', N'Kinh doanh', 2001, 125000, 37)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (31, N'Hoàng Tử Bé', N'Antoine de Saint-Exupéry', N'Tiểu thuyết', 1943, 85000, 60)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (32, N'Vượt Lên Chính Mình', N'Spencer Johnson', N'Tâm lý - Kỹ năng', 1998, 78000, 52)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (33, N'Đi Tìm Lẽ Sống', N'Viktor E. Frankl', N'Tâm lý - Kỹ năng', 1946, 90000, 40)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (34, N'Tam Quốc Diễn Nghĩa', N'Luo Guanzhong', N'Lịch sử', 1522, 145000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (35, N'Lịch Sử Cận Đại', N'Nguyễn Huy', N'Lịch sử', 2019, 85000, 31)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (36, N'Con Đường Hồi Giáo', N'Tariq Ramadan', N'Tôn giáo', 2004, 92000, 27)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (37, N'Trí Tuệ Nhân Tạo Và Robot', N'Tran Phu', N'Khoa học', 2023, 115000, 18)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (38, N'Bí Mật DotCom', N'Russell Brunson', N'Kinh doanh', 2015, 99000, 22)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (39, N'21 Bài Học Cho Thế Kỷ 21', N'Yuval Noah Harari', N'Lịch sử', 2018, 130000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (40, N'Quốc Gia Khởi Nghiệp', N'Dan Senor', N'Kinh doanh', 2010, 125000, 36)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (41, N'Thuyết Trình Đỉnh Cao', N'Chris Anderson', N'Tâm lý - Kỹ năng', 2016, 105000, 34)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (42, N'Cha Giàu Cha Nghèo', N'Robert T. Kiyosaki', N'Kinh doanh', 1997, 125000, 42)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (43, N'Một Đời Thương Thuyết', N'Herb Cohen', N'Tâm lý - Kỹ năng', 1980, 110000, 29)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (44, N'Tư Duy Logic', N'Norman Vincent Peale', N'Tâm lý - Kỹ năng', 1994, 90000, 31)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (45, N'Sức Mạnh Của Niềm Tin', N'Tony Robbins', N'Tâm lý - Kỹ năng', 1986, 98000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (46, N'Tôi Tài Giỏi Bạn Cũng Thế', N'Adam Khoo', N'Tâm lý - Kỹ năng', 2005, 120000, 33)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (47, N'Trên Đường Băng', N'Tony Buổi Sáng', N'Tâm lý - Kỹ năng', 2013, 89000, 47)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (48, N'Nghệ Thuật Yêu', N'Erich Fromm', N'Tâm lý - Kỹ năng', 1956, 105000, 23)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (49, N'Bí Mật Hành Trình Tâm Linh', N'James Redfield', N'Tâm linh', 1993, 115000, 16)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (50, N'Kỹ Năng Lắng Nghe', N'Norman Wright', N'Tâm lý - Kỹ năng', 2012, 95000, 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (51, N'Lập Trình Viên Cứng Đầu', N'Kevin Mitnick', N'Công nghệ', 2011, 145000, 22)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (52, N'Thiết Kế Cuộc Đời', N'Bill Burnett', N'Tâm lý - Kỹ năng', 2016, 98000, 39)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (53, N'Người Đàn Ông Từ Bắc Cực', N'Rolf Potts', N'Phiêu lưu', 2003, 88000, 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (54, N'Suy Nghĩ Của Tỷ Phú', N'Donald Trump', N'Kinh doanh', 2004, 150000, 11)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (55, N'Triết Học Nhập Môn', N'Roger Scruton', N'Triết học', 2001, 93000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (56, N'Lập Trình Java Nâng Cao', N'James Gosling', N'Lập trình', 2019, 130000, 18)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (57, N'Siêu Năng Lực Của Những Người Thành Công', N'Scott Adams', N'Tâm lý - Kỹ năng', 2017, 102000, 21)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (58, N'Nghệ Thuật Lãnh Đạo', N'Simon Sinek', N'Lãnh đạo', 2014, 110000, 28)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (59, N'Tạo Lập Sự Nghiệp', N'Cal Newport', N'Tâm lý - Kỹ năng', 2012, 112000, 33)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (60, N'Thế Giới Tư Bản', N'Edward Said', N'Kinh tế', 1978, 99000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (61, N'Chuyện Nghề Làm Đẹp', N'Vũ Mạnh Hải', N'Tâm lý - Kỹ năng', 2019, 75000, 26)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (62, N'Tình Yêu Trong Cách Mạng', N'Tran Dai Nghia', N'Tiểu thuyết', 1987, 85000, 37)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (63, N'Nghĩ Giàu Và Nghĩ Lớn', N'Steve Jobs', N'Tâm lý - Kỹ năng', 2010, 140000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (64, N'Thế Giới Hoàn Mỹ', N'Aldous Huxley', N'Khoa học viễn tưởng', 1932, 87000, 29)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (65, N'Tư Duy Hệ Thống', N'Donella H. Meadows', N'Tâm lý - Kỹ năng', 2008, 125000, 17)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (66, N'Điều Khiển Tâm Trí', N'Napoleon Hill', N'Tâm lý - Kỹ năng', 1937, 102000, 41)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (67, N'Quản Lý Thời Gian', N'Brian Tracy', N'Tâm lý - Kỹ năng', 2010, 95000, 36)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (68, N'Nghệ Thuật Đàm Phán', N'Chris Voss', N'Tâm lý - Kỹ năng', 2016, 120000, 24)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (69, N'Nền Tảng Văn Học Việt Nam', N'Phạm Văn Đồng', N'Văn học', 1983, 78000, 32)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (70, N'Hành Trình Về Phương Đông', N'Baird T. Spalding', N'Tâm linh', 1924, 89000, 18)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (71, N'Marketing 4.0', N'Philip Kotler', N'Marketing', 2017, 115000, 35)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (72, N'Hành Trình Cuộc Sống', N'Richard Carlson', N'Tâm lý - Kỹ năng', 1997, 100000, 29)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (73, N'Gieo Mầm Tư Duy', N'Norman Vincent Peale', N'Tâm lý - Kỹ năng', 1952, 94000, 50)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (74, N'Sự Thật Về Hạnh Phúc', N'Yuval Noah Harari', N'Văn học', 2021, 130000, 26)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (75, N'Cuộc Cách Mạng Công Nghiệp 4.0', N'Klaus Schwab', N'Công nghệ', 2016, 118000, 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (76, N'Sống Đẹp Giữa Đời', N'Dale Carnegie', N'Tâm lý - Kỹ năng', 1936, 75000, 45)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (77, N'Tuổi Trẻ Đáng Giá Bao Nhiêu', N'Rosie Nguyễn', N'Tâm lý - Kỹ năng', 2017, 100000, 37)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (78, N'Bí Mật Dotcom', N'Russell Brunson', N'Kinh doanh', 2015, 125000, 41)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (79, N'Số Phận Của Ý Thức', N'David Hume', N'Triết học', 1748, 82000, 15)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (80, N'Bí Quyết Thành Công', N'Vince Lombardi', N'Tâm lý - Kỹ năng', 1994, 91000, 28)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (81, N'Những Người Đàn Ông Có Số', N'Malcolm Gladwell', N'Tâm lý - Kỹ năng', 2008, 106000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (82, N'Bí Quyết Lãnh Đạo', N'John Maxwell', N'Lãnh đạo', 2007, 110000, 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (83, N'Nghệ Thuật Phê Phán', N'Paul Graham', N'Tâm lý - Kỹ năng', 2004, 99000, 27)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (84, N'Trở Thành Người Phụ Nữ Bạn Muốn', N'Rachel Hollis', N'Tâm lý - Kỹ năng', 2018, 88000, 22)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (85, N'Luật Của Thị Trường', N'David Ricardo', N'Kinh tế', 1817, 112000, 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (86, N'Hành Trình Lãnh Đạo', N'Simon Sinek', N'Lãnh đạo', 2019, 135000, 34)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (87, N'Sức Mạnh Của Năng Lực', N'David McClelland', N'Tâm lý - Kỹ năng', 1976, 102000, 26)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (88, N'Tìm Về Cuộc Sống Ý Nghĩa', N'Thích Nhất Hạnh', N'Tâm linh', 1989, 93000, 42)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (89, N'Khoa Học Hạnh Phúc', N'Steven Pinker', N'Tâm lý học', 2011, 109000, 31)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (90, N'Kinh Doanh Như Một Cuộc Chơi', N'Gary Vaynerchuk', N'Kinh doanh', 2009, 130000, 36)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (91, N'Kẻ Trộm Mặt Trăng', N'Jules Verne', N'Phiêu lưu', 1865, 115000, 22)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (92, N'Triết Lý Cuộc Sống', N'Thích Nhất Hạnh', N'Triết học', 2010, 94000, 18)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (93, N'Tâm Lý Học Tội Phạm', N'David Buss', N'Tâm lý học', 1995, 99000, 27)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (94, N'Hãy Yêu Cuộc Sống', N'Leo Buscaglia', N'Tâm lý - Kỹ năng', 1972, 85000, 36)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (95, N'Tìm Lại Chính Mình', N'Tony Robbins', N'Tâm lý - Kỹ năng', 1991, 92000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (96, N'Kỹ Năng Lãnh Đạo', N'John C. Maxwell', N'Lãnh đạo', 2001, 102000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (97, N'Sống Với Đam Mê', N'Oprah Winfrey', N'Tâm lý - Kỹ năng', 2015, 115000, 24)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (98, N'Nghệ Thuật Sống Khác Biệt', N'Adam Grant', N'Tâm lý - Kỹ năng', 2016, 105000, 32)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (99, N'Tri Thức Cơ Bản Về Tài Chính', N'Robert Kiyosaki', N'Kinh doanh', 2008, 110000, 44)
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (100, N'Trăm Hoa Đua Nở', N'Kim Liên', N'Văn học', 1982, 78000, 55)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (101, N'Những Kẻ Khác Biệt', N'Angela Duckworth', N'Tâm lý - Kỹ năng', 2013, 130000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (102, N'Khởi Nghiệp Từ Số 0', N'Elon Musk', N'Kinh doanh', 2015, 120000, 27)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (103, N'Bài Học Cuộc Sống', N'Robin Sharma', N'Tâm lý - Kỹ năng', 2009, 97000, 38)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (104, N'Hành Trình Kỳ Thú', N'Phạm Công Thiện', N'Phiêu lưu', 1984, 80000, 29)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (105, N'Thế Giới Bí Ẩn', N'Kazuo Ishiguro', N'Tiểu thuyết', 2015, 94000, 16)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (106, N'Quản Trị Đời Mình', N'Stephen Covey', N'Tâm lý - Kỹ năng', 1989, 100000, 21)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (107, N'Nghĩa Vụ Và Niềm Tin', N'George Orwell', N'Chính trị', 1945, 87000, 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (108, N'Thức Dậy Và Sống', N'Dale Carnegie', N'Tâm lý - Kỹ năng', 1936, 95000, 30)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (109, N'Nghệ Thuật Làm Việc Đơn Giản', N'Ken Segall', N'Tâm lý - Kỹ năng', 2012, 102000, 15)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NamXuatBan], [GiaSach], [SoLuong]) VALUES (110, N'Sự Sụp Đổ Của Quyền Lực', N'Moises Naim', N'Chính trị', 2013, 110000, 13)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'1')
GO
ALTER TABLE [dbo].[LichSuMuonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_LichSuMuonTraSach_DocGia] FOREIGN KEY([SoThe])
REFERENCES [dbo].[DocGia] ([SoThe])
GO
ALTER TABLE [dbo].[LichSuMuonTraSach] CHECK CONSTRAINT [FK_LichSuMuonTraSach_DocGia]
GO
ALTER TABLE [dbo].[LichSuMuonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_LichSuMuonTraSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[LichSuMuonTraSach] CHECK CONSTRAINT [FK_LichSuMuonTraSach_Sach]
GO
USE [master]
GO
ALTER DATABASE [LVN] SET  READ_WRITE 
GO
