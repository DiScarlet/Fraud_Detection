USE [master]
GO
/****** Object:  Database [Credit_Card_Info]    Script Date: 1/6/2024 8:34:34 PM ******/
CREATE DATABASE [Credit_Card_Info]
GO
USE [Credit_Card_Info]
GO
/****** Object:  Table [dbo].[User_Transactions]    Script Date: 1/6/2024 8:34:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Transactions](
	[Transactions_ID] [int] IDENTITY(1,1) NOT NULL,
	[distance_from_home] [real] NULL,
	[distance_from_last_transaction] [real] NULL,
	[ratio_to_median_purchase_price] [real] NULL,
	[repeat_retailer] [bit] NULL,
	[used_chip] [bit] NULL,
	[used_pin_number] [bit] NULL,
	[online_order] [bit] NULL,
	[fraud] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Transactions_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Credit_Card_Info] SET  READ_WRITE 
GO
