USE [master]
GO
/****** Object:  Database [ViajesUbar]    Script Date: 23/01/2024 01:40:00 p. m. ******/
CREATE DATABASE [ViajesUbar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ViajesUbar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ViajesUbar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ViajesUbar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ViajesUbar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ViajesUbar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ViajesUbar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ViajesUbar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ViajesUbar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ViajesUbar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ViajesUbar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ViajesUbar] SET ARITHABORT OFF 
GO
ALTER DATABASE [ViajesUbar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ViajesUbar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ViajesUbar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ViajesUbar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ViajesUbar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ViajesUbar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ViajesUbar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ViajesUbar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ViajesUbar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ViajesUbar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ViajesUbar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ViajesUbar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ViajesUbar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ViajesUbar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ViajesUbar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ViajesUbar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ViajesUbar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ViajesUbar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ViajesUbar] SET  MULTI_USER 
GO
ALTER DATABASE [ViajesUbar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ViajesUbar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ViajesUbar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ViajesUbar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ViajesUbar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ViajesUbar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ViajesUbar] SET QUERY_STORE = OFF
GO
USE [ViajesUbar]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 23/01/2024 01:40:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellidos] [varchar](20) NOT NULL,
	[Telefono] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 23/01/2024 01:40:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje](
	[IDViaje] [int] IDENTITY(1,1) NOT NULL,
	[LatOrigen] [float] NOT NULL,
	[LongOrigen] [float] NOT NULL,
	[LatDestino] [float] NOT NULL,
	[LongDestino] [float] NOT NULL,
	[FechaViaje] [varchar](20) NOT NULL,
	[HoraInicio] [varchar](20) NOT NULL,
	[Distancia] [float] NOT NULL,
	[DireccionCardinal] [varchar](20) NOT NULL,
	[TiempoViaje] [float] NOT NULL,
	[HoraLlegada] [varchar](20) NOT NULL,
	[Costo] [float] NOT NULL,
	[IDUsuario2] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pasajero] ON 

INSERT [dbo].[Pasajero] ([IDUsuario], [Nombre], [Apellidos], [Telefono]) VALUES (1, N'Angel Isaac', N'Nabor Torres', 4423456789)
INSERT [dbo].[Pasajero] ([IDUsuario], [Nombre], [Apellidos], [Telefono]) VALUES (2, N'Manuel', N'Gómez González', 4424567890)
INSERT [dbo].[Pasajero] ([IDUsuario], [Nombre], [Apellidos], [Telefono]) VALUES (3, N'Héctor', N'Aguilar Llanos', 4425678901)
SET IDENTITY_INSERT [dbo].[Pasajero] OFF
GO
SET IDENTITY_INSERT [dbo].[Viaje] ON 

INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (2, 1, 3, 4, 3, N'28/08/2022', N'Jul 28 2022  5:30PM', 333.5457, N'N', 400.25484, N'Jul 29 2022 12:10AM', 8338.6425, 1)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (3, 34.0675918, -118.3977091, 34.076234, -118.395314, N'31/01/2023', N'Jul 28 2022 12:00PM', 0.96539999999999992, N'N', 1.15848, N'Jul 28 2022 12:01PM', 24.134999999999998, 1)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (4, 8.9, 7.5, 7.6, 6.5, N'12/10/2022', N'Jul 28 2022 10:00AM', 181.6561, N'SW', 217.98732, N'Jul 28 2022  1:37PM', 4541.4025, 2)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (5, 5.56, -12.58, 5.7, -12.8, N'10/7/2022', N'Jul 28 2022  8:00PM', 28.962, N'NW', 34.7544, N'Jul 28 2022  8:34PM', 724.05, 3)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (6, 15.8, -12.6, 16.3, -12.2, N'25/12/2022', N'Jul 28 2022  4:45PM', 70.1524, N'NE', 84.182880000000011, N'Jul 28 2022  6:09PM', 1753.81, 2)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (7, 5.6, 7.8, 5.3, 7.4, N'28/09/2023', N'Jul 28 2022  4:45PM', 55.349599999999995, N'SW', 66.41952, N'Jul 28 2022  5:51PM', 1383.7399999999998, 1)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (8, 5.5, 6.3, 5.4, 6.2, N'27/06/2022', N'Jul 28 2022  3:21PM', 15.607299999999999, N'SW', 18.728759999999998, N'Jul 28 2022  3:39PM', 390.18249999999995, 2)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (9, 2.2, 3.1, 2.2, 3.6, N'08/11/2022', N'Jul 28 2022  7:05AM', 55.5105, N'E', 66.6126, N'Jul 28 2022  8:11AM', 1387.7625, 3)
INSERT [dbo].[Viaje] ([IDViaje], [LatOrigen], [LongOrigen], [LatDestino], [LongDestino], [FechaViaje], [HoraInicio], [Distancia], [DireccionCardinal], [TiempoViaje], [HoraLlegada], [Costo], [IDUsuario2]) VALUES (10, 2, 5, 6, 8, N'23/01/2024', N'Jan 23 2024  2:00PM', 555.4268, N'NE', 666.51216, N'Jan 24 2024  1:06AM', 13885.669999999998, 1)
SET IDENTITY_INSERT [dbo].[Viaje] OFF
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [fk_Pasajero] FOREIGN KEY([IDUsuario2])
REFERENCES [dbo].[Pasajero] ([IDUsuario])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [fk_Pasajero]
GO
USE [master]
GO
ALTER DATABASE [ViajesUbar] SET  READ_WRITE 
GO
