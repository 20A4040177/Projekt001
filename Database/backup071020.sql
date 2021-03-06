USE [master]
GO
/****** Object:  Database [EShop]    Script Date: 7/10/2020 9:45:13 PM ******/
CREATE DATABASE [EShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EShop', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EShop.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EShop_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EShop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EShop] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [EShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EShop] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EShop] SET  MULTI_USER 
GO
ALTER DATABASE [EShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EShop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EShop]
GO
/****** Object:  Table [dbo].[tblCalc]    Script Date: 7/10/2020 9:45:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCalc](
	[ItemID] [nchar](15) NOT NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
	[TotalPrice] [float] NULL,
	[InvoiceID] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CatID] [nchar](15) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[CatUsage] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCountry]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCountry](
	[CountryID] [nchar](15) NOT NULL,
	[CountryName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [nchar](15) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerAdd] [nvarchar](50) NULL,
	[CustomerTel] [nchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblImInvoice]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblImInvoice](
	[InvoiceID] [nchar](15) NOT NULL,
	[StaffID] [nchar](15) NULL,
	[ImportDate] [datetime] NULL,
	[SupplierID] [nchar](15) NULL,
	[TotalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblImInvoiceDetail]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblImInvoiceDetail](
	[InvoiceID] [nchar](15) NOT NULL,
	[ItemID] [nchar](15) NOT NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
	[TotalPrice] [float] NULL,
 CONSTRAINT [im_detail_prk] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblItemList]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItemList](
	[ItemID] [nchar](15) NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[CatID] [nchar](15) NULL,
	[TypeID] [nchar](15) NULL,
	[UnitID] [nchar](15) NULL,
	[MatID] [nchar](15) NULL,
	[CountryID] [nchar](15) NULL,
	[Quantity] [int] NULL,
	[ImUnitPrice] [float] NULL,
	[SaleUnitPrice] [float] NULL,
	[Warranty] [float] NULL,
	[Note] [nvarchar](50) NULL,
	[ItemImage] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblItemType]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItemType](
	[TypeID] [nchar](15) NOT NULL,
	[TypeName] [nvarchar](50) NULL,
	[CatID] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMaterial]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMaterial](
	[MatID] [nchar](15) NOT NULL,
	[MatName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPosition]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPosition](
	[PosID] [nchar](15) NOT NULL,
	[PosName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PosID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblReItem]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReItem](
	[ItemID] [nchar](15) NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[ReturnDate] [datetime] NULL,
	[DesTxt] [nvarchar](50) NULL,
	[InvoiceID] [nchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSaleInvoice]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSaleInvoice](
	[InvoiceID] [nchar](15) NOT NULL,
	[StaffID] [nchar](15) NULL,
	[SaleDate] [datetime] NULL,
	[CustomerID] [nchar](15) NULL,
	[TotalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSaleInvoiceDetail]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSaleInvoiceDetail](
	[InvoiceID] [nchar](15) NOT NULL,
	[ItemID] [nchar](15) NOT NULL,
	[Quantity] [int] NULL,
	[Discount] [float] NULL,
	[TotalPrice] [float] NULL,
 CONSTRAINT [sale_detail_prk] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStaff]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaff](
	[StaffID] [nchar](15) NOT NULL,
	[StaffName] [nvarchar](50) NULL,
	[Gender] [nchar](12) NULL,
	[DOB] [datetime] NULL,
	[StaffAdd] [nvarchar](50) NULL,
	[StaffTel] [nchar](11) NULL,
	[ShiftID] [nchar](15) NULL,
	[PosID] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[SupplierID] [nchar](15) NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
	[SupplierAdd] [nvarchar](50) NULL,
	[SupplierTel] [nchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUnit]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUnit](
	[UnitID] [nchar](15) NOT NULL,
	[UnitName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblWorkShift]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWorkShift](
	[ShiftID] [nchar](15) NOT NULL,
	[ShiftName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'EARRDX01       ', 0, 0, 0, 0, N'SL7102020212454')
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'FANMN          ', 0, 0, 0, 0, N'SL7102020212910')
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'LAMPPSLF       ', 0, 0, 0, 0, NULL)
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'LAMPPXDF       ', 0, 0, 0, 0, N'IM7102020211728')
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'LMNRD          ', 0, 0, 0, 0, N'IM7102020211821')
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'LTHP45         ', 0, 0, 0, 0, NULL)
INSERT [dbo].[tblCalc] ([ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice], [InvoiceID]) VALUES (N'MP3RZ01        ', 0, 0, 0, 0, N'SL7102020211928')
INSERT [dbo].[tblCategory] ([CatID], [CatName], [CatUsage]) VALUES (N'CCDC           ', N'Cong cu dung cu', N'')
INSERT [dbo].[tblCategory] ([CatID], [CatName], [CatUsage]) VALUES (N'TBGD           ', N'Thiet bi gia dinh', N'')
INSERT [dbo].[tblCategory] ([CatID], [CatName], [CatUsage]) VALUES (N'TBGT           ', N'Thiet bi giai tri', N'')
INSERT [dbo].[tblCategory] ([CatID], [CatName], [CatUsage]) VALUES (N'TBVP           ', N'Thiet bi van phong', N'')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'AUS            ', N'Uc')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'CN             ', N'Trung Quoc')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'IN             ', N'An Do')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'JP             ', N'Nhat Ban')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'SEA            ', N'Dong Nam A')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'SK             ', N'Han Quoc')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'SNG            ', N'Singapore')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'SWE            ', N'Thuy Dien')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'SWI            ', N'Thuy Si')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'TW             ', N'Dai Loan')
INSERT [dbo].[tblCountry] ([CountryID], [CountryName]) VALUES (N'US             ', N'Hoa Ky')
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [CustomerAdd], [CustomerTel]) VALUES (N'CS0125486854   ', N'Nguyen Duc Anh', N'125 Nguyen Trai', N'0125486854 ')
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [CustomerAdd], [CustomerTel]) VALUES (N'CS0912587458   ', N'Nguyen Thu Thao', N'458 Ba Dinh', N'0912587458 ')
INSERT [dbo].[tblCustomer] ([CustomerID], [CustomerName], [CustomerAdd], [CustomerTel]) VALUES (N'CS0952485258   ', N'Nguyen Hoai An', N'156 Hang Thung', N'0952485258 ')
INSERT [dbo].[tblImInvoice] ([InvoiceID], [StaffID], [ImportDate], [SupplierID], [TotalPrice]) VALUES (N'IM7102020211546', N'STF001         ', CAST(0x0000ABF400000000 AS DateTime), N'SP555476825    ', 4185000)
INSERT [dbo].[tblImInvoice] ([InvoiceID], [StaffID], [ImportDate], [SupplierID], [TotalPrice]) VALUES (N'IM7102020211728', N'STF002         ', CAST(0x0000ABF400000000 AS DateTime), N'SP423586132    ', 8040000)
INSERT [dbo].[tblImInvoice] ([InvoiceID], [StaffID], [ImportDate], [SupplierID], [TotalPrice]) VALUES (N'IM7102020211821', N'STF003         ', CAST(0x0000ABF400000000 AS DateTime), N'SP453885658    ', 12187500)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211546', N'EARRDX01       ', 12, 200000, 10, 2160000)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211546', N'FANMN          ', 15, 150000, 10, 2025000)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211728', N'LAMPPXDF       ', 20, 160000, 5, 3040000)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211728', N'LMNRD          ', 5, 1000000, 0, 5000000)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211821', N'LMNRD          ', 10, 900000, 0, 9000000)
INSERT [dbo].[tblImInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [UnitPrice], [Discount], [TotalPrice]) VALUES (N'IM7102020211821', N'MP3RZ01        ', 15, 250000, 15, 3187500)
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'EARRDX01       ', N'Tai nghe MD N03', N'CCDC           ', N'CCAT           ', N'CAI            ', N'HKK            ', N'AUS            ', 11, 200000, 220000.00000000003, 12, NULL, N'D:\shopImage\tai-ngh-bluetoooth-mh1-136.jpg')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'FANMN          ', N'Quat Mini 321', N'TBGD           ', N'GDLM           ', N'CAI            ', N'NC             ', N'CN             ', 15, 150000, 165000, 1, NULL, N'D:\shopImage\quat-tich-dien-yoobao-F04-MAX-998845.jpg')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'LAMPPSLF       ', N'Den ngu XDF15', N'TBGD           ', N'GDCS           ', N'CAI            ', N'HKN            ', N'IN             ', 0, NULL, NULL, 3, NULL, N'')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'LAMPPXDF       ', N'Den hoc MX112', N'TBVP           ', N'GDCS           ', N'CAI            ', N'HKK            ', N'CN             ', 20, 160000, 176000, 3, NULL, N'D:\shopImage\2031453dde595678e7db1eba30059e04.jpg')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'LMNRD          ', N'May cat co RD 68', N'CCDC           ', N'CCMM           ', N'CAI            ', N'HKK            ', N'AUS            ', 15, 900000, 990000.00000000012, 12, NULL, N'D:\shopImage\May-cat-co-Honda-AB-35.jpg')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'LTHP45         ', N'Laptop DP M228', N'TBVP           ', N'CCMM           ', N'CAI            ', N'HKK            ', N'AUS            ', 0, NULL, NULL, 24, NULL, N'D:\shopImage\37535_laptop_hp_15s_du1040tx_8re77pa_2.jpg')
INSERT [dbo].[tblItemList] ([ItemID], [ItemName], [CatID], [TypeID], [UnitID], [MatID], [CountryID], [Quantity], [ImUnitPrice], [SaleUnitPrice], [Warranty], [Note], [ItemImage]) VALUES (N'MP3RZ01        ', N'May nghe nhac RZ X02', N'CCDC           ', N'CCAT           ', N'CAI            ', N'HKK            ', N'AUS            ', 15, 250000, 275000, 6, NULL, N'D:\shopImage\b1.png')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'CCAT           ', N'Cong cu am thanh', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'CCLM           ', N'Cong cu  lam mat', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'CCMM           ', N'May moc chuyen dung', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'CCNV           ', N'Cong cu ngoai vi', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'GDCS           ', N'Thiet bi chieu sang gia dinh', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'GDLM           ', N'Thiet bi lam mat gia dinh', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'GTAT           ', N'Thiet bi am thanh gia dinh', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'GTLM           ', N'Thiet bi lam mat gia dinh', N'CCDC           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'GTNV           ', N'Thiet bi ngoai vi giai tri', N'TBGT           ')
INSERT [dbo].[tblItemType] ([TypeID], [TypeName], [CatID]) VALUES (N'VPCS           ', N'Thiet bi chieu sang van phong', N'TBVP           ')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'HKK            ', N'Hop kim kem')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'HKKH           ', N'Hop kim khac')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'HKN            ', N'Hop kim nhom')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'IN             ', N'Inox')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'NC             ', N'Nhua cung')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'ND             ', N'Nhua deo')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'SLC            ', N'Silicon ban dan')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'TCD            ', N'Thep chuyen dung')
INSERT [dbo].[tblMaterial] ([MatID], [MatName]) VALUES (N'TKG            ', N'Thep khong gi')
INSERT [dbo].[tblPosition] ([PosID], [PosName]) VALUES (N'BH             ', N'Ban hang')
INSERT [dbo].[tblPosition] ([PosID], [PosName]) VALUES (N'BV             ', N'Bao ve')
INSERT [dbo].[tblPosition] ([PosID], [PosName]) VALUES (N'KT             ', N'Ke toan')
INSERT [dbo].[tblPosition] ([PosID], [PosName]) VALUES (N'QL             ', N'Quan ly')
INSERT [dbo].[tblPosition] ([PosID], [PosName]) VALUES (N'TN             ', N'Thu ngan')
INSERT [dbo].[tblSaleInvoice] ([InvoiceID], [StaffID], [SaleDate], [CustomerID], [TotalPrice]) VALUES (N'SL7102020212454', N'STF003         ', CAST(0x0000ABF400000000 AS DateTime), N'CS0125486854   ', 220000)
INSERT [dbo].[tblSaleInvoiceDetail] ([InvoiceID], [ItemID], [Quantity], [Discount], [TotalPrice]) VALUES (N'SL7102020212454', N'EARRDX01       ', 1, 0, 220000)
INSERT [dbo].[tblStaff] ([StaffID], [StaffName], [Gender], [DOB], [StaffAdd], [StaffTel], [ShiftID], [PosID]) VALUES (N'STF001         ', N'Nguyen Hoang An', N'Male        ', CAST(0x0000862000000000 AS DateTime), N'13 Kim Nguu Ha Noi', N'0915156332 ', N'NGAY           ', N'BH             ')
INSERT [dbo].[tblStaff] ([StaffID], [StaffName], [Gender], [DOB], [StaffAdd], [StaffTel], [ShiftID], [PosID]) VALUES (N'STF002         ', N'DInh Thu Nhan', N'Female      ', CAST(0x000083DD00000000 AS DateTime), N'42 Ba Dinh Ha Noi', N'0125478998 ', N'CHIEU          ', N'BH             ')
INSERT [dbo].[tblStaff] ([StaffID], [StaffName], [Gender], [DOB], [StaffAdd], [StaffTel], [ShiftID], [PosID]) VALUES (N'STF003         ', N'Nguyen Thu Thao', N'Female      ', CAST(0x0000882400000000 AS DateTime), N'156 Linh Dam Ha Noi', N'0987589887 ', N'TOI            ', N'TN             ')
INSERT [dbo].[tblStaff] ([StaffID], [StaffName], [Gender], [DOB], [StaffAdd], [StaffTel], [ShiftID], [PosID]) VALUES (N'STF004         ', N'Nguyen Diep Anh', N'Female      ', CAST(0x0000899300000000 AS DateTime), N'145 Nguyen Trai Ha Noi', N'012586847  ', N'NGAY           ', N'BH             ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP125878528    ', N'Cong ty co phan thiet bi New Light', N'Texas, Hoa Ky', N'125878528  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP423586132    ', N'Cong ty MTV Bankai', N'Okinawa, Nhat Ban', N'423586132  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP453885658    ', N'Evil Corp Co.LTD', N'Moscow, Lien bang Nga', N'453885658  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP472224857    ', N'Cong ty TNHH Tu Phong', N'Tham Quyen, Trung Quoc', N'472224857  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP513789567    ', N'Cong ty giai phap cong nghe MUI', N'New Dehli, An Do', N'513789567  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP555476825    ', N'Cong ty TNHH Cong nghe Ruizu', N'Tham Quyen, Trung Quoc', N'555476825  ')
INSERT [dbo].[tblSupplier] ([SupplierID], [SupplierName], [SupplierAdd], [SupplierTel]) VALUES (N'SP789225365    ', N'Cua hang dung cu Thuan An', N'Di An, Binh Duong, Viet Nam', N'789225365  ')
INSERT [dbo].[tblUnit] ([UnitID], [UnitName]) VALUES (N'CAI            ', N'Cai')
INSERT [dbo].[tblUnit] ([UnitID], [UnitName]) VALUES (N'KG             ', N'Kilogram')
INSERT [dbo].[tblUnit] ([UnitID], [UnitName]) VALUES (N'MANH           ', N'Manh')
INSERT [dbo].[tblWorkShift] ([ShiftID], [ShiftName]) VALUES (N'ALL            ', N'Toan thoi gian')
INSERT [dbo].[tblWorkShift] ([ShiftID], [ShiftName]) VALUES (N'CHIEU          ', N'Ca chieu')
INSERT [dbo].[tblWorkShift] ([ShiftID], [ShiftName]) VALUES (N'NGAY           ', N'Ca ngay')
INSERT [dbo].[tblWorkShift] ([ShiftID], [ShiftName]) VALUES (N'TOI            ', N'Ca toi')
ALTER TABLE [dbo].[tblItemList] ADD  CONSTRAINT [df_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[tblItemList] ADD  CONSTRAINT [df_Image]  DEFAULT ('D:\shopImage\default-thumb.png') FOR [ItemImage]
GO
ALTER TABLE [dbo].[tblReItem] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[tblCalc]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblItemList] ([ItemID])
GO
ALTER TABLE [dbo].[tblImInvoice]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[tblStaff] ([StaffID])
GO
ALTER TABLE [dbo].[tblImInvoice]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[tblSupplier] ([SupplierID])
GO
ALTER TABLE [dbo].[tblImInvoiceDetail]  WITH CHECK ADD FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[tblImInvoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[tblImInvoiceDetail]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblItemList] ([ItemID])
GO
ALTER TABLE [dbo].[tblItemList]  WITH CHECK ADD FOREIGN KEY([CatID])
REFERENCES [dbo].[tblCategory] ([CatID])
GO
ALTER TABLE [dbo].[tblItemList]  WITH CHECK ADD FOREIGN KEY([CountryID])
REFERENCES [dbo].[tblCountry] ([CountryID])
GO
ALTER TABLE [dbo].[tblItemList]  WITH CHECK ADD FOREIGN KEY([MatID])
REFERENCES [dbo].[tblMaterial] ([MatID])
GO
ALTER TABLE [dbo].[tblItemList]  WITH CHECK ADD FOREIGN KEY([TypeID])
REFERENCES [dbo].[tblItemType] ([TypeID])
GO
ALTER TABLE [dbo].[tblItemList]  WITH CHECK ADD FOREIGN KEY([UnitID])
REFERENCES [dbo].[tblUnit] ([UnitID])
GO
ALTER TABLE [dbo].[tblItemType]  WITH CHECK ADD FOREIGN KEY([CatID])
REFERENCES [dbo].[tblCategory] ([CatID])
GO
ALTER TABLE [dbo].[tblReItem]  WITH CHECK ADD FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[tblSaleInvoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[tblReItem]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblItemList] ([ItemID])
GO
ALTER TABLE [dbo].[tblSaleInvoice]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
GO
ALTER TABLE [dbo].[tblSaleInvoice]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[tblStaff] ([StaffID])
GO
ALTER TABLE [dbo].[tblSaleInvoiceDetail]  WITH CHECK ADD FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[tblSaleInvoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[tblSaleInvoiceDetail]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblItemList] ([ItemID])
GO
ALTER TABLE [dbo].[tblStaff]  WITH CHECK ADD FOREIGN KEY([PosID])
REFERENCES [dbo].[tblPosition] ([PosID])
GO
ALTER TABLE [dbo].[tblStaff]  WITH CHECK ADD FOREIGN KEY([ShiftID])
REFERENCES [dbo].[tblWorkShift] ([ShiftID])
GO
/****** Object:  Trigger [dbo].[trg_dec_quantity]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_dec_quantity] on [dbo].[tblImInvoiceDetail] for update as
begin update tblItemList
set Quantity=tblItemList.Quantity-(select Quantity from deleted where ItemID=tblItemList.ItemID)+(select Quantity from inserted where ItemID=tblItemList.ItemID)
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_del_quantity]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_del_quantity] on [dbo].[tblImInvoiceDetail] for delete as
begin update tblItemList
set Quantity=tblItemList.Quantity-(select Quantity from deleted where ItemID=tblItemList.ItemID)
from tblItemList join deleted on tblItemList.ItemID=deleted.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_inc_quantity]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_inc_quantity] on [dbo].[tblImInvoiceDetail] after insert as
begin 
update tblItemList 
set Quantity=tblItemList.Quantity+(select Quantity from inserted where ItemID=tblItemList.ItemID)
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_update__update_im_price]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_update__update_im_price] on [dbo].[tblImInvoiceDetail] after update as
begin 
update tblItemList
set ImUnitPrice=UnitPrice from inserted where inserted.ItemID=tblItemList.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_update_im_price]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_update_im_price] on [dbo].[tblImInvoiceDetail] after insert as
begin
update tblItemList
set ImUnitPrice= UnitPrice from inserted where inserted.ItemID=tblItemList.ItemID

end
GO
/****** Object:  Trigger [dbo].[trg_update_quantity_im]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_update_quantity_im] on [dbo].[tblImInvoiceDetail] for update as
begin update tblItemList
set Quantity=tblItemList.Quantity-(select Quantity from deleted where ItemID=tblItemList.ItemID)+(select Quantity from inserted where ItemID=tblItemList.ItemID)
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_update_img]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_update_img] on [dbo].[tblItemList] for insert as
begin update tblItemList
set ItemImage='D:\shopImage\default-thumb.png'
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
where tblItemList.ItemImage=''
end
GO
/****** Object:  Trigger [dbo].[trg_update_sale_price]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_update_sale_price] on [dbo].[tblItemList] after update as
begin
update tblItemList
set SaleUnitPrice=1.1*inserted.ImUnitPrice from inserted where tblItemList.ItemID=inserted.ItemID
end
select* from tblItemList
GO
/****** Object:  Trigger [dbo].[trg_dec_quantity_sale]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_dec_quantity_sale] on [dbo].[tblSaleInvoiceDetail] after insert as
begin update tblItemList
set Quantity=tblItemList.Quantity-(select Quantity from inserted where ItemID=tblItemList.ItemID)
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
end

GO
/****** Object:  Trigger [dbo].[trg_del_quantity_sale]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_del_quantity_sale] on [dbo].[tblSaleInvoiceDetail] for delete as
begin update tblItemList
set Quantity=tblItemList.Quantity+(select Quantity from deleted where ItemID=tblItemList.ItemID)
from tblItemList join deleted on tblItemList.ItemID=deleted.ItemID
end
GO
/****** Object:  Trigger [dbo].[trg_update_quantity_sale]    Script Date: 7/10/2020 9:45:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_update_quantity_sale] on [dbo].[tblSaleInvoiceDetail] for update as
begin update tblItemList
set Quantity=tblItemList.Quantity+(select Quantity from deleted where ItemID=tblItemList.ItemID)-(select Quantity from inserted where ItemID=tblItemList.ItemID)
from tblItemList join inserted on tblItemList.ItemID=inserted.ItemID
end
GO
USE [master]
GO
ALTER DATABASE [EShop] SET  READ_WRITE 
GO
