USE [master]
GO
/****** Object:  Database [Veterinaria]    Script Date: 15/07/2021 16:38:31 ******/
CREATE DATABASE [Veterinaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Veterinaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veterinaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Veterinaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Veterinaria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria] SET RECOVERY FULL 
GO
ALTER DATABASE [Veterinaria] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veterinaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veterinaria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Veterinaria', N'ON'
GO
ALTER DATABASE [Veterinaria] SET QUERY_STORE = OFF
GO
USE [Veterinaria]
GO
/****** Object:  User [UCEMA]    Script Date: 15/07/2021 16:38:32 ******/
CREATE USER [UCEMA] FOR LOGIN [UCEMA] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [UCEMA]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/07/2021 16:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](80) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Email] [varchar](180) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Clave] [varchar](11) NOT NULL,
	[Fecha_ingreso] [datetime] NOT NULL,
	[Fecha_Modificar] [datetime] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 15/07/2021 16:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[ID_Mascota] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
	[TipoAnimal] [varchar](20) NOT NULL,
	[Raza] [varchar](50) NOT NULL,
	[DetalleMascota] [varchar](150) NULL,
	[Fecha_ingreso] [datetime] NOT NULL,
	[Fecha_Modificar] [datetime] NOT NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[ID_Mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/07/2021 16:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[ID_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Servicio] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Detalle] [varchar](150) NULL,
	[Fecha_Reserva] [datetime2](7) NOT NULL,
	[Fecha_Modificar] [datetime] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ID_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 15/07/2021 16:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [bit] NOT NULL,
	[Precio] [float] NOT NULL,
	[Detalle] [varchar](150) NULL,
	[Fecha_ingreso] [datetime] NOT NULL,
	[Fecha_Modificar] [datetime] NOT NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (1, N'k', N'm', N'h', 1, N'h', CAST(N'2021-07-13T02:29:26.510' AS DateTime), CAST(N'2021-07-13T02:29:26.510' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (2, N'j', N'j', N'j', 1, N'j', CAST(N'2021-07-13T02:31:39.467' AS DateTime), CAST(N'2021-07-13T02:31:39.467' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (3, N'm', N'm', N'm', 1, N'm', CAST(N'2021-07-13T02:31:47.373' AS DateTime), CAST(N'2021-07-13T02:31:47.373' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (4, N'l', N'l', N'l', 1, N'l', CAST(N'2021-07-13T02:31:54.173' AS DateTime), CAST(N'2021-07-13T02:31:54.173' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (5, N'V', N'V', N'V', 1, N'V', CAST(N'2021-07-13T02:33:07.963' AS DateTime), CAST(N'2021-07-13T02:33:07.963' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (6, N'l', N'l', N'HOLA@YAHOO.AR', 1, N'34', CAST(N'2021-07-13T02:34:08.120' AS DateTime), CAST(N'2021-07-13T02:34:08.120' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (7, N'k', N'm', N'r', 1, N'r', CAST(N'2021-07-13T04:19:52.667' AS DateTime), CAST(N'2021-07-13T04:19:52.667' AS DateTime))
INSERT [dbo].[Cliente] ([ID], [Apellido], [Nombre], [Email], [Estado], [Clave], [Fecha_ingreso], [Fecha_Modificar]) VALUES (8, N'V', N'P', N'p', 1, N'hola', CAST(N'2021-07-13T04:37:26.953' AS DateTime), CAST(N'2021-07-13T20:29:02.277' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([ID_Mascota], [ID_Cliente], [Nombre], [Estado], [TipoAnimal], [Raza], [DetalleMascota], [Fecha_ingreso], [Fecha_Modificar]) VALUES (1, 8, N'valen', 1, N'perro', N'golden', N'peludo', CAST(N'2021-07-13T19:38:34.460' AS DateTime), CAST(N'2021-07-13T19:38:34.460' AS DateTime))
INSERT [dbo].[Mascota] ([ID_Mascota], [ID_Cliente], [Nombre], [Estado], [TipoAnimal], [Raza], [DetalleMascota], [Fecha_ingreso], [Fecha_Modificar]) VALUES (2, 8, N'pancho', 0, N'gato', N'nose', N'q', CAST(N'2021-07-13T19:47:29.953' AS DateTime), CAST(N'2021-07-13T20:09:51.060' AS DateTime))
INSERT [dbo].[Mascota] ([ID_Mascota], [ID_Cliente], [Nombre], [Estado], [TipoAnimal], [Raza], [DetalleMascota], [Fecha_ingreso], [Fecha_Modificar]) VALUES (3, 8, N'martu', 1, N'perroooo', N'goldennnnn', N'peludooooo', CAST(N'2021-07-13T20:10:41.383' AS DateTime), CAST(N'2021-07-13T22:47:01.360' AS DateTime))
SET IDENTITY_INSERT [dbo].[Mascota] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (1, 8, 6, 0, N'ryty', CAST(N'2021-08-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:24:19.277' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (2, 8, 1, 0, N'fgjfg', CAST(N'2021-08-23T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:55:45.280' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (3, 8, 1, 1, N'ghf', CAST(N'2021-08-15T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T07:41:12.840' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (4, 8, 1, 1, N'holaaaa', CAST(N'2021-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:56:36.343' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (5, 8, 2, 1, N'gfhf', CAST(N'2021-08-31T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T15:25:45.703' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (6, 8, 1, 1, N'g', CAST(N'2021-08-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:41:17.200' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (7, 8, 3, 1, N'w', CAST(N'2005-07-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:42:23.423' AS DateTime))
INSERT [dbo].[Reserva] ([ID_Reserva], [ID_Cliente], [ID_Servicio], [Estado], [Detalle], [Fecha_Reserva], [Fecha_Modificar]) VALUES (8, 8, 1, 1, N'ghf', CAST(N'2021-07-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-13T18:57:28.543' AS DateTime))
SET IDENTITY_INSERT [dbo].[Reserva] OFF
GO
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (1, N'Cortar Pelo', 1, 560, NULL, CAST(N'2021-07-11T22:58:13.687' AS DateTime), CAST(N'2021-07-11T22:58:43.993' AS DateTime))
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (2, N'Control', 1, 450, NULL, CAST(N'2021-07-11T23:00:07.867' AS DateTime), CAST(N'2021-07-11T23:00:07.867' AS DateTime))
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (3, N'Vacunación', 1, 700, NULL, CAST(N'2021-07-11T23:00:40.857' AS DateTime), CAST(N'2021-07-11T23:00:40.857' AS DateTime))
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (4, N'Baño', 0, 400, NULL, CAST(N'2021-07-11T23:02:34.213' AS DateTime), CAST(N'2021-07-11T23:02:34.213' AS DateTime))
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (5, N'Operación', 1, 1000, N'El monto total será calculado el día de la operación. Monto mínimo es $1000', CAST(N'2021-07-11T23:05:01.317' AS DateTime), CAST(N'2021-07-11T23:05:01.317' AS DateTime))
INSERT [dbo].[Servicio] ([ID], [Nombre], [Estado], [Precio], [Detalle], [Fecha_ingreso], [Fecha_Modificar]) VALUES (6, N'Adopción', 1, 3000, N'El monto total varía según el animal. Monto mínimo $3000', CAST(N'2021-07-11T23:05:54.060' AS DateTime), CAST(N'2021-07-11T23:05:54.060' AS DateTime))
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
