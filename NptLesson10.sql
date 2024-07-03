USE [NptK22CNT3Lesson10]
GO
/****** Object:  Table [dbo].[NptAccount]    Script Date: 07/03/2024 10:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NptAccount](
	[NptId] [int] NOT NULL,
	[NptUserName] [nvarchar](50) NULL,
	[NptPassword] [nvarchar](50) NULL,
	[NptFullName] [nvarchar](50) NULL,
	[NptEmail] [nvarchar](50) NULL,
	[Nptphone] [nvarchar](50) NULL,
	[NptActive] [bit] NULL,
 CONSTRAINT [PK_NptAccount] PRIMARY KEY CLUSTERED 
(
	[NptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NptAccount] ([NptId], [NptUserName], [NptPassword], [NptFullName], [NptEmail], [Nptphone], [NptActive]) VALUES (1, N'Tanami', N'Usagiri', N'NguyenPhongTan', N'nguyenphongtan2004@gmail.com', N'0913698863', 1)
GO
