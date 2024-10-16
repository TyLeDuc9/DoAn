USE [QUANLYTHUVIEN]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 10/17/2024 1:43:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[MaSach] [char](10) NOT NULL,
	[MaPhieu] [char](10) NOT NULL,
	[SoThe] [char](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 10/17/2024 1:43:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [char](10) NOT NULL,
	[TenDocGia] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [char](20) NULL,
	[SoThe] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC,
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Email] [nvarchar](20) NULL,
	[SDT] [char](15) NULL,
	[GioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK__NhanVien__77B2CA47BB58AE97] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXB]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXB](
	[MaNXB] [char](10) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [char](30) NULL,
	[SDT] [char](20) NULL,
 CONSTRAINT [PK__NhaXB__3A19482CC9FBF021] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPhieu] [char](10) NOT NULL,
	[MaNhanVien] [char](10) NULL,
	[SoThe] [char](10) NOT NULL,
 CONSTRAINT [PK__PhieuMuo__A40C071E1AC5394E] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[MaTacGia] [char](10) NULL,
	[MaNXB] [char](10) NULL,
	[TenSach] [nvarchar](50) NULL,
	[TheLoai] [nvarchar](20) NULL,
	[NamXB] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK__Sach__B235742D17D5C0F9] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [char](10) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[Email] [char](30) NULL,
	[SDT] [char](12) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK__TacGia__F24E675653CBB741] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[SoThe] [char](10) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayHetHan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 10/17/2024 1:43:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuThu](
	[MaThuThu] [nchar](15) NOT NULL,
	[TenThuThu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[MaThuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPh__MaSac__48CFD27E] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK__ChiTietPh__MaSac__48CFD27E]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietPhieuMuon__46E78A0C] FOREIGN KEY([MaPhieu], [SoThe])
REFERENCES [dbo].[PhieuMuon] ([MaPhieu], [SoThe])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK__ChiTietPhieuMuon__46E78A0C]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuMuon__MaNha__45F365D3] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK__PhieuMuon__MaNha__45F365D3]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuMuon__SoThe__44FF419A] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK__PhieuMuon__SoThe__44FF419A]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK__Sach__MaNXB__49C3F6B7] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXB] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK__Sach__MaNXB__49C3F6B7]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK__Sach__MaTacGia__47DBAE45] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK__Sach__MaTacGia__47DBAE45]
GO
