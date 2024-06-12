USE [NguyenPhongTan-K22CNT3-2210900123]
GO
/****** Object:  Table [dbo].[nptKhoa]    Script Date: 06/12/2024 10:42:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nptKhoa](
	[nptMaKH] [nchar](10) NOT NULL,
	[nptTenKH] [nvarchar](50) NULL,
	[nptTrangThai] [bit] NULL,
 CONSTRAINT [PK_nptKhoa] PRIMARY KEY CLUSTERED 
(
	[nptMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nptSinhVien]    Script Date: 06/12/2024 10:42:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nptSinhVien](
	[nptMaSV] [nvarchar](50) NOT NULL,
	[nptHoSV] [nvarchar](50) NULL,
	[nptTenSV] [nvarchar](50) NULL,
	[nptNgaySinh] [date] NULL,
	[nptPhai] [bit] NULL,
	[nptPhone] [nchar](10) NULL,
	[nptEmail] [nvarchar](50) NULL,
	[nptMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_nptSinhVien] PRIMARY KEY CLUSTERED 
(
	[nptMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nptKhoa] ([nptMaKH], [nptTenKH], [nptTrangThai]) VALUES (N'1         ', N'NguyenPhongTan', 1)
INSERT [dbo].[nptKhoa] ([nptMaKH], [nptTenKH], [nptTrangThai]) VALUES (N'2         ', N'Tanami', 1)
GO
INSERT [dbo].[nptSinhVien] ([nptMaSV], [nptHoSV], [nptTenSV], [nptNgaySinh], [nptPhai], [nptPhone], [nptEmail], [nptMaKH]) VALUES (N'1', N'Nguyen', N'Tan', CAST(N'2004-04-28' AS Date), 1, N'0913698863', N'Nguyenphongtan2004@gmail.com', N'1         ')
INSERT [dbo].[nptSinhVien] ([nptMaSV], [nptHoSV], [nptTenSV], [nptNgaySinh], [nptPhai], [nptPhone], [nptEmail], [nptMaKH]) VALUES (N'2', N'Usagiri', N'Tanami', CAST(N'2004-04-28' AS Date), 0, N'0913698863', N'Tanamiusagiri@gmail.com', N'2         ')
GO
ALTER TABLE [dbo].[nptSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_nptSinhVien_nptKhoa] FOREIGN KEY([nptMaKH])
REFERENCES [dbo].[nptKhoa] ([nptMaKH])
GO
ALTER TABLE [dbo].[nptSinhVien] CHECK CONSTRAINT [FK_nptSinhVien_nptKhoa]
GO
