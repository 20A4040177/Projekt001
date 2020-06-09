USE [master]
GO
/****** Object:  Database [EShop]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblCalc]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblCategory]    Script Date: 5/30/2020 9:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CatID] [nchar](15) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[CatUseage] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCountry]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblImInvoice]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblImInvoiceDetail]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblItemList]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblItemType]    Script Date: 5/30/2020 9:02:59 PM ******/
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
/****** Object:  Table [dbo].[tblMaterial]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblPosition]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblSaleInvoice]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblSaleInvoiceDetail]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblStaff]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblUnit]    Script Date: 5/30/2020 9:03:00 PM ******/
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
/****** Object:  Table [dbo].[tblWorkShift]    Script Date: 5/30/2020 9:03:00 PM ******/
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
ALTER TABLE [dbo].[tblItemList] ADD  CONSTRAINT [df_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[tblItemList] ADD  CONSTRAINT [df_Image]  DEFAULT ('D:\shopImage\default-thumb.png') FOR [ItemImage]
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
USE [master]
GO
ALTER DATABASE [EShop] SET  READ_WRITE 
GO
