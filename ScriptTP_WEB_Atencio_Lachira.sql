USE [master]
GO
/****** Object:  Database [BDParacas1]    Script Date: 28/10/2015 04:33:31 p.m. ******/
CREATE DATABASE [BDParacas1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDParacas1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDParacas1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDParacas1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDParacas1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDParacas1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDParacas1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDParacas1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDParacas1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDParacas1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDParacas1] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDParacas1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDParacas1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDParacas1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDParacas1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDParacas1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDParacas1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDParacas1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDParacas1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDParacas1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDParacas1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDParacas1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDParacas1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDParacas1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDParacas1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDParacas1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDParacas1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDParacas1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDParacas1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDParacas1] SET  MULTI_USER 
GO
ALTER DATABASE [BDParacas1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDParacas1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDParacas1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDParacas1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BDParacas1]
GO
/****** Object:  Table [dbo].[AuditoriaPesaje]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditoriaPesaje](
	[AuditoriaPesajeId] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[PesajeId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_AuditoriaPesaje] PRIMARY KEY CLUSTERED 
(
	[AuditoriaPesajeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Autorizacion]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autorizacion](
	[AutorizacionId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[EmbalajeId] [int] NOT NULL,
	[OperacionId] [int] NOT NULL,
	[Peso] [decimal](9, 2) NOT NULL,
	[NroBultos] [int] NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Autorizacion_Estado]  DEFAULT ((1)),
	[Fecha] [datetime] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[NaveId] [int] NOT NULL,
	[Producto] [varchar](5000) NULL,
	[Tipo] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Autorizacion] PRIMARY KEY CLUSTERED 
(
	[AutorizacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Conductor]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Conductor](
	[ConductorId] [int] IDENTITY(1,1) NOT NULL,
	[NroBrevete] [varchar](50) NOT NULL,
	[Nombres] [varchar](150) NOT NULL,
	[ApellidoPaterno] [varchar](150) NOT NULL,
	[ApellidoMaterno] [varchar](150) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Conductor_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Conductor] PRIMARY KEY CLUSTERED 
(
	[ConductorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contenedor]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contenedor](
	[ContenedorId] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Contenedor_Estado]  DEFAULT ((1)),
	[Embarcadero] [varchar](100) NULL,
	[AgenteAduana] [varchar](100) NULL,
	[TipoMovimiento] [varchar](3) NULL,
	[Codigo] [varchar](100) NULL,
	[Tara] [decimal](9, 2) NULL,
	[NumeroViaje] [varchar](50) NULL,
	[PesoManifiesto] [decimal](9, 2) NULL,
	[PrecintoAduanero] [varchar](100) NULL,
	[Precinto1] [varchar](100) NULL,
	[Precinto2] [varchar](100) NULL,
	[Precinto3] [varchar](100) NULL,
	[FechaMuelle] [datetime] NULL,
	[FechaBarco] [datetime] NULL,
	[FechaIzaje] [datetime] NULL,
	[TipoContenedorId] [int] NOT NULL,
	[TamanoContenedorId] [int] NOT NULL,
	[EIR] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NOT NULL,
	[Autorizacion] [int] NULL,
	[Fecha] [datetime] NULL,
	[NaveId] [int] NOT NULL,
 CONSTRAINT [PK_Contenedor] PRIMARY KEY CLUSTERED 
(
	[ContenedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Embalaje]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Embalaje](
	[EmbalajeId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Embalaje_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Embalaje] PRIMARY KEY CLUSTERED 
(
	[EmbalajeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GuiaRemision]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GuiaRemision](
	[GuiaRemisionId] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NOT NULL,
	[Bultos] [int] NOT NULL,
	[PesajeId] [int] NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_GuiaRemision_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_GuiaRemision] PRIMARY KEY CLUSTERED 
(
	[GuiaRemisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MovimientoPesaje]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MovimientoPesaje](
	[MovimientoPesajeId] [int] IDENTITY(1,1) NOT NULL,
	[PesajeId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Peso] [decimal](9, 2) NOT NULL,
	[Tipo] [varchar](3) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[TipoRepesaje] [varchar](3) NULL,
	[Estado] [smallint] NOT NULL,
 CONSTRAINT [PK_MovimientoPesaje] PRIMARY KEY CLUSTERED 
(
	[MovimientoPesajeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nave]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nave](
	[NaveId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[PesoTotal] [decimal](9, 2) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Nave_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Nave] PRIMARY KEY CLUSTERED 
(
	[NaveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operacion]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operacion](
	[OperacionId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Operacion_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_OperacionId] PRIMARY KEY CLUSTERED 
(
	[OperacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pesaje]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pesaje](
	[PesajeId] [int] IDENTITY(1,1) NOT NULL,
	[ConductorId] [int] NOT NULL,
	[VehiculoId] [int] NOT NULL,
	[AutorizacionId] [int] NOT NULL,
	[Observacion] [varchar](5000) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Pesaje_Estado]  DEFAULT ((1)),
	[Fecha] [datetime] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Bruto] [decimal](9, 2) NULL,
	[Tara] [decimal](9, 2) NULL,
	[Neto] [decimal](9, 2) NULL,
	[NaveId] [int] NULL,
	[TipoMercancia] [varchar](5000) NULL,
	[CodSeguridad] [varchar](5000) NULL,
	[CodContenedor] [varchar](5000) NULL,
	[Tipo] [varchar](3) NULL,
	[Bultos] [int] NOT NULL,
	[Tarja] [int] NULL,
	[HoraGancho] [datetime] NULL,
 CONSTRAINT [PK_Pesaje] PRIMARY KEY CLUSTERED 
(
	[PesajeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte](
	[ReporteId] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[TurnoId] [int] NOT NULL,
	[EstadoFiltro] [smallint] NOT NULL,
 CONSTRAINT [PK_Reporte] PRIMARY KEY CLUSTERED 
(
	[ReporteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[RolId] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TamanioContenedor]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TamanioContenedor](
	[TamanioContenedorId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_TamanioContenedor_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_TamanioContenedor] PRIMARY KEY CLUSTERED 
(
	[TamanioContenedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoContenedor]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoContenedor](
	[TipoContenedorId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_TipoContenedor_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_TipoContenedor] PRIMARY KEY CLUSTERED 
(
	[TipoContenedorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoVehiculo]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[TipoVehiculoId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[PesoMaximo] [decimal](9, 2) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_TipoVehiculo_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[TipoVehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turno](
	[TurnoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[HoraInicio] [int] NOT NULL,
	[MinutoInicio] [int] NOT NULL,
	[HoraFin] [int] NOT NULL,
	[MinutoFin] [int] NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Turno_Estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[TurnoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Usuario_Estado]  DEFAULT ((1)),
	[RolId] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[VehiculoId] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [varchar](50) NOT NULL,
	[Carrete] [varchar](50) NOT NULL,
	[Estado] [smallint] NOT NULL CONSTRAINT [DF_Vehiculo_Estado]  DEFAULT ((1)),
	[TipoVehiculoId] [int] NULL,
	[ConductorId] [int] NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[VehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Autorizacion] ON 

INSERT [dbo].[Autorizacion] ([AutorizacionId], [Codigo], [EmbalajeId], [OperacionId], [Peso], [NroBultos], [Estado], [Fecha], [UsuarioId], [NaveId], [Producto], [Tipo]) VALUES (2, N'00679', 4, 3, CAST(10000.00 AS Decimal(9, 2)), 1, 1, CAST(N'2015-10-14 20:25:04.467' AS DateTime), 1, 1, N'AGUA', N'IMP')
INSERT [dbo].[Autorizacion] ([AutorizacionId], [Codigo], [EmbalajeId], [OperacionId], [Peso], [NroBultos], [Estado], [Fecha], [UsuarioId], [NaveId], [Producto], [Tipo]) VALUES (3, N'00680', 6, 5, CAST(10000.00 AS Decimal(9, 2)), 1, 0, CAST(N'2015-10-19 01:21:01.993' AS DateTime), 1, 4, N'CHATARRA', N'EXP')
SET IDENTITY_INSERT [dbo].[Autorizacion] OFF
SET IDENTITY_INSERT [dbo].[Conductor] ON 

INSERT [dbo].[Conductor] ([ConductorId], [NroBrevete], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Estado]) VALUES (1, N'A83490223', N'JUAN', N'ZELADA', N'CASTILLO', 1)
INSERT [dbo].[Conductor] ([ConductorId], [NroBrevete], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Estado]) VALUES (2, N'A94893289', N'MARTIN', N'PEREZ', N'RAMIREZ', 0)
SET IDENTITY_INSERT [dbo].[Conductor] OFF
SET IDENTITY_INSERT [dbo].[Contenedor] ON 

INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (2, 0, N'2394', N'57382', N'IMP', N'893492', CAST(10000.00 AS Decimal(9, 2)), N'490', CAST(15000.00 AS Decimal(9, 2)), N'123123', N'', N'', N'', CAST(N'2015-10-19 00:32:00.000' AS DateTime), CAST(N'2015-10-19 00:32:00.000' AS DateTime), CAST(N'2015-10-19 00:32:00.000' AS DateTime), 3, 1, N'123456', N'CALLAO', 125, CAST(N'2015-10-19 00:41:42.437' AS DateTime), 4)
INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (3, 0, N'2394', N'32954', N'IMP', N'893493', CAST(15000.00 AS Decimal(9, 2)), N'510', CAST(20000.00 AS Decimal(9, 2)), N'123321', N'', N'', N'', CAST(N'2015-10-19 00:43:48.617' AS DateTime), CAST(N'2015-10-19 00:49:53.617' AS DateTime), CAST(N'2015-10-19 00:48:48.627' AS DateTime), 3, 1, N'483293', N'LIMA', 126, CAST(N'2015-10-19 00:45:12.890' AS DateTime), 1)
INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (4, 0, N'2394', N'45392', N'EXP', N'893494', CAST(12000.00 AS Decimal(9, 2)), N'620', CAST(15000.00 AS Decimal(9, 2)), N'4552341', N'', N'', N'', CAST(N'2015-10-19 00:45:00.000' AS DateTime), CAST(N'2015-10-19 00:59:00.000' AS DateTime), CAST(N'2015-10-19 00:45:00.000' AS DateTime), 3, 1, N'322315', N'CALLAO', 127, CAST(N'2015-10-19 00:52:23.870' AS DateTime), 1)
INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (5, 1, N'3242', N'54398', N'IMP', N'893495', CAST(17000.00 AS Decimal(9, 2)), N'715', CAST(20000.00 AS Decimal(9, 2)), N'3842732', N'', N'', N'', CAST(N'2015-10-19 00:54:09.353' AS DateTime), CAST(N'2015-10-19 01:54:09.353' AS DateTime), CAST(N'2015-10-19 00:54:09.353' AS DateTime), 3, 1, N'324234', N'HILO', 128, CAST(N'2015-10-19 00:56:17.797' AS DateTime), 5)
INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (6, 1, N'123', N'123', N'EXP', N'12312', CAST(2342.00 AS Decimal(9, 2)), N'950', CAST(12453.00 AS Decimal(9, 2)), N'49821', N'', N'', N'', CAST(N'2015-10-28 00:57:43.260' AS DateTime), CAST(N'2015-10-28 01:17:43.260' AS DateTime), CAST(N'2015-10-28 00:57:43.260' AS DateTime), 3, 1, N'2312', N'LIMA', 123, CAST(N'2015-10-28 00:59:14.603' AS DateTime), 4)
INSERT [dbo].[Contenedor] ([ContenedorId], [Estado], [Embarcadero], [AgenteAduana], [TipoMovimiento], [Codigo], [Tara], [NumeroViaje], [PesoManifiesto], [PrecintoAduanero], [Precinto1], [Precinto2], [Precinto3], [FechaMuelle], [FechaBarco], [FechaIzaje], [TipoContenedorId], [TamanoContenedorId], [EIR], [Ubicacion], [Autorizacion], [Fecha], [NaveId]) VALUES (7, 1, N'2312', N'123', N'EXP', N'123', CAST(123.00 AS Decimal(9, 2)), N'123', CAST(123.00 AS Decimal(9, 2)), N'123', N'123', N'123', N'123', CAST(N'2015-10-28 03:13:40.983' AS DateTime), CAST(N'2015-10-28 03:19:40.983' AS DateTime), CAST(N'2015-10-28 03:13:40.983' AS DateTime), 3, 1, N'123', N'LIMA', 123, CAST(N'2015-10-28 03:14:35.500' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Contenedor] OFF
SET IDENTITY_INSERT [dbo].[Embalaje] ON 

INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (1, N'20ARO', N'AROS', 1)
INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (2, N'20ATD', N'POR CONFIRMAR', 0)
INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (3, N'CAJA 1', N'CAJA 1 METRO CUBICULO', 1)
INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (4, N'40ARO', N'AROS DE 40 PULGADAS', 1)
INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (5, N'20LQGRA', N'LIQUIDA - GRANEL', 1)
INSERT [dbo].[Embalaje] ([EmbalajeId], [Codigo], [Descripcion], [Estado]) VALUES (6, N'20SOGR', N'SOLIDO - GRANEL', 1)
SET IDENTITY_INSERT [dbo].[Embalaje] OFF
SET IDENTITY_INSERT [dbo].[GuiaRemision] ON 

INSERT [dbo].[GuiaRemision] ([GuiaRemisionId], [Documento], [Bultos], [PesajeId], [Estado]) VALUES (34, N'432', 2, 6, 1)
INSERT [dbo].[GuiaRemision] ([GuiaRemisionId], [Documento], [Bultos], [PesajeId], [Estado]) VALUES (35, N'342', 3, 6, 1)
SET IDENTITY_INSERT [dbo].[GuiaRemision] OFF
SET IDENTITY_INSERT [dbo].[Nave] ON 

INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (1, N'NAVESITA', CAST(10000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (2, N'NAVE 3', CAST(2000.00 AS Decimal(9, 2)), 0)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (3, N'RAM CALIPUY', CAST(15000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (4, N'PERLA NEGRA', CAST(100000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (5, N'ALFA CENTAURI', CAST(15000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (6, N'AMERICAN BLUE', CAST(20000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[Nave] ([NaveId], [Nombre], [PesoTotal], [Estado]) VALUES (7, N'JAIMAICA SHIP', CAST(25000.00 AS Decimal(9, 2)), 1)
SET IDENTITY_INSERT [dbo].[Nave] OFF
SET IDENTITY_INSERT [dbo].[Operacion] ON 

INSERT [dbo].[Operacion] ([OperacionId], [Codigo], [Descripcion], [Estado]) VALUES (1, N'33DC', N'DESCARGA DIRECTA CABOTAJE', 1)
INSERT [dbo].[Operacion] ([OperacionId], [Codigo], [Descripcion], [Estado]) VALUES (2, N'33DDI', N'DESCARGA DIRECTA INTERNACIONAL.', 0)
INSERT [dbo].[Operacion] ([OperacionId], [Codigo], [Descripcion], [Estado]) VALUES (3, N'33IP', N'INGRESO DE PACOTILLA', 1)
INSERT [dbo].[Operacion] ([OperacionId], [Codigo], [Descripcion], [Estado]) VALUES (4, N'33DDI', N'DESCARGA DIRECTA INTERNACIONAL', 1)
INSERT [dbo].[Operacion] ([OperacionId], [Codigo], [Descripcion], [Estado]) VALUES (5, N'33RP', N'RETIRO DE PACOTILLA', 1)
SET IDENTITY_INSERT [dbo].[Operacion] OFF
SET IDENTITY_INSERT [dbo].[Pesaje] ON 

INSERT [dbo].[Pesaje] ([PesajeId], [ConductorId], [VehiculoId], [AutorizacionId], [Observacion], [Estado], [Fecha], [UsuarioId], [Bruto], [Tara], [Neto], [NaveId], [TipoMercancia], [CodSeguridad], [CodContenedor], [Tipo], [Bultos], [Tarja], [HoraGancho]) VALUES (4, 1, 5, 2, N'TEST1', 1, CAST(N'2015-10-21 00:00:00.000' AS DateTime), 1, CAST(16348.00 AS Decimal(9, 2)), NULL, CAST(10000.00 AS Decimal(9, 2)), 1, NULL, NULL, N'2', N'EXP', 1, 2, CAST(N'2015-10-21 18:54:16.907' AS DateTime))
INSERT [dbo].[Pesaje] ([PesajeId], [ConductorId], [VehiculoId], [AutorizacionId], [Observacion], [Estado], [Fecha], [UsuarioId], [Bruto], [Tara], [Neto], [NaveId], [TipoMercancia], [CodSeguridad], [CodContenedor], [Tipo], [Bultos], [Tarja], [HoraGancho]) VALUES (5, 1, 5, 3, N'ESTO ES UNA PRUEBA', 1, CAST(N'2015-10-28 00:00:00.000' AS DateTime), 1, CAST(15983.00 AS Decimal(9, 2)), NULL, CAST(10000.00 AS Decimal(9, 2)), 4, NULL, NULL, N'3', N'IMP', 1, 4, CAST(N'2015-10-28 00:59:32.750' AS DateTime))
INSERT [dbo].[Pesaje] ([PesajeId], [ConductorId], [VehiculoId], [AutorizacionId], [Observacion], [Estado], [Fecha], [UsuarioId], [Bruto], [Tara], [Neto], [NaveId], [TipoMercancia], [CodSeguridad], [CodContenedor], [Tipo], [Bultos], [Tarja], [HoraGancho]) VALUES (6, 1, 4, 3, N'TEST 2', 1, CAST(N'2015-10-28 00:00:00.000' AS DateTime), 1, CAST(18342.00 AS Decimal(9, 2)), NULL, CAST(10000.00 AS Decimal(9, 2)), 4, NULL, NULL, N'3', N'IMP', 1, 2, CAST(N'2015-10-28 03:14:35.547' AS DateTime))
SET IDENTITY_INSERT [dbo].[Pesaje] OFF
INSERT [dbo].[Rol] ([RolId], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([RolId], [Descripcion]) VALUES (2, N'Balancero')
SET IDENTITY_INSERT [dbo].[TamanioContenedor] ON 

INSERT [dbo].[TamanioContenedor] ([TamanioContenedorId], [Descripcion], [Estado]) VALUES (1, N'20 PIES', 1)
INSERT [dbo].[TamanioContenedor] ([TamanioContenedorId], [Descripcion], [Estado]) VALUES (2, N'40 PIES.', 0)
INSERT [dbo].[TamanioContenedor] ([TamanioContenedorId], [Descripcion], [Estado]) VALUES (3, N'40 PIES', 1)
INSERT [dbo].[TamanioContenedor] ([TamanioContenedorId], [Descripcion], [Estado]) VALUES (4, N'60 PIES', 1)
SET IDENTITY_INSERT [dbo].[TamanioContenedor] OFF
SET IDENTITY_INSERT [dbo].[TipoContenedor] ON 

INSERT [dbo].[TipoContenedor] ([TipoContenedorId], [Descripcion], [Estado]) VALUES (1, N'20 PIES', 0)
INSERT [dbo].[TipoContenedor] ([TipoContenedorId], [Descripcion], [Estado]) VALUES (2, N'40 PIES.', 0)
INSERT [dbo].[TipoContenedor] ([TipoContenedorId], [Descripcion], [Estado]) VALUES (3, N'FRIGORÍFICO TÉRMICO', 1)
INSERT [dbo].[TipoContenedor] ([TipoContenedorId], [Descripcion], [Estado]) VALUES (4, N'TÉRMICO', 1)
INSERT [dbo].[TipoContenedor] ([TipoContenedorId], [Descripcion], [Estado]) VALUES (5, N'REVESTIDO', 1)
SET IDENTITY_INSERT [dbo].[TipoContenedor] OFF
SET IDENTITY_INSERT [dbo].[TipoVehiculo] ON 

INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (1, N'VEH-001', N'3 EJES NORMAL', CAST(5000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (2, N'VEH-002', N'4 EJES NORMAL', CAST(3000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (3, N'VEH-003', N'4 EJES ESP. ABIERTO', CAST(2000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (4, N'VEH-004', N'Camión tipo 4', CAST(10000.00 AS Decimal(9, 2)), 0)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (5, N'VEH-004', N'4 EJES ESPECIAL', CAST(7500.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (6, N'VEH-005', N'4 EJES SEMI ABIERTO', CAST(9000.00 AS Decimal(9, 2)), 1)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (7, N'VEH-006', N'5 EJES NORMAL', CAST(3500.00 AS Decimal(9, 2)), 0)
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Codigo], [Nombre], [PesoMaximo], [Estado]) VALUES (8, N'VEH-007', N'5 EJES ESPECIAL', CAST(8000.00 AS Decimal(9, 2)), 1)
SET IDENTITY_INSERT [dbo].[TipoVehiculo] OFF
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([TurnoId], [Nombre], [HoraInicio], [MinutoInicio], [HoraFin], [MinutoFin], [Estado]) VALUES (1, N'TURNO 1', 6, 0, 12, 0, 1)
SET IDENTITY_INSERT [dbo].[Turno] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioId], [Codigo], [Password], [Estado], [RolId]) VALUES (1, N'JL', N'123', 1, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Codigo], [Password], [Estado], [RolId]) VALUES (3, N'ATENCIO', N'321', 0, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Codigo], [Password], [Estado], [RolId]) VALUES (4, N'TEST', N'12345', 1, 2)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Vehiculo] ON 

INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (1, N'DGI-392', N'PWO-310', 1, 1, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (2, N'ASD-238', N'EWI-239', 1, 2, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (3, N'AIW-294', N'FRI-392', 1, 7, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (4, N'EOI-293', N'RFO-392', 1, 6, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (5, N'FER-390', N'KFR-032', 1, 8, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (6, N'RTO-439', N'RPO-443', 1, 7, NULL)
INSERT [dbo].[Vehiculo] ([VehiculoId], [Placa], [Carrete], [Estado], [TipoVehiculoId], [ConductorId]) VALUES (7, N'ASD-231', N'IOJ-328', 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Vehiculo] OFF
ALTER TABLE [dbo].[MovimientoPesaje] ADD  CONSTRAINT [DF_MovimientoPesaje_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Reporte] ADD  CONSTRAINT [DF_Reporte_EstadoFiltro]  DEFAULT ((1)) FOR [EstadoFiltro]
GO
ALTER TABLE [dbo].[AuditoriaPesaje]  WITH CHECK ADD  CONSTRAINT [FK_AuditoriaPesaje_Pesaje] FOREIGN KEY([PesajeId])
REFERENCES [dbo].[Pesaje] ([PesajeId])
GO
ALTER TABLE [dbo].[AuditoriaPesaje] CHECK CONSTRAINT [FK_AuditoriaPesaje_Pesaje]
GO
ALTER TABLE [dbo].[AuditoriaPesaje]  WITH CHECK ADD  CONSTRAINT [FK_AuditoriaPesaje_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[AuditoriaPesaje] CHECK CONSTRAINT [FK_AuditoriaPesaje_Usuario]
GO
ALTER TABLE [dbo].[Autorizacion]  WITH CHECK ADD  CONSTRAINT [FK_Autorizacion_Embalaje] FOREIGN KEY([EmbalajeId])
REFERENCES [dbo].[Embalaje] ([EmbalajeId])
GO
ALTER TABLE [dbo].[Autorizacion] CHECK CONSTRAINT [FK_Autorizacion_Embalaje]
GO
ALTER TABLE [dbo].[Autorizacion]  WITH CHECK ADD  CONSTRAINT [FK_Autorizacion_Nave] FOREIGN KEY([NaveId])
REFERENCES [dbo].[Nave] ([NaveId])
GO
ALTER TABLE [dbo].[Autorizacion] CHECK CONSTRAINT [FK_Autorizacion_Nave]
GO
ALTER TABLE [dbo].[Autorizacion]  WITH CHECK ADD  CONSTRAINT [FK_Autorizacion_Operacion] FOREIGN KEY([OperacionId])
REFERENCES [dbo].[Operacion] ([OperacionId])
GO
ALTER TABLE [dbo].[Autorizacion] CHECK CONSTRAINT [FK_Autorizacion_Operacion]
GO
ALTER TABLE [dbo].[Autorizacion]  WITH CHECK ADD  CONSTRAINT [FK_Autorizacion_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Autorizacion] CHECK CONSTRAINT [FK_Autorizacion_Usuario]
GO
ALTER TABLE [dbo].[Contenedor]  WITH CHECK ADD  CONSTRAINT [FK_Contenedor_Nave] FOREIGN KEY([NaveId])
REFERENCES [dbo].[Nave] ([NaveId])
GO
ALTER TABLE [dbo].[Contenedor] CHECK CONSTRAINT [FK_Contenedor_Nave]
GO
ALTER TABLE [dbo].[Contenedor]  WITH CHECK ADD  CONSTRAINT [FK_Contenedor_TamanioContenedor] FOREIGN KEY([TamanoContenedorId])
REFERENCES [dbo].[TamanioContenedor] ([TamanioContenedorId])
GO
ALTER TABLE [dbo].[Contenedor] CHECK CONSTRAINT [FK_Contenedor_TamanioContenedor]
GO
ALTER TABLE [dbo].[Contenedor]  WITH CHECK ADD  CONSTRAINT [FK_Contenedor_TipoContenedor] FOREIGN KEY([TipoContenedorId])
REFERENCES [dbo].[TipoContenedor] ([TipoContenedorId])
GO
ALTER TABLE [dbo].[Contenedor] CHECK CONSTRAINT [FK_Contenedor_TipoContenedor]
GO
ALTER TABLE [dbo].[GuiaRemision]  WITH CHECK ADD  CONSTRAINT [FK_GuiaRemision_Pesaje] FOREIGN KEY([PesajeId])
REFERENCES [dbo].[Pesaje] ([PesajeId])
GO
ALTER TABLE [dbo].[GuiaRemision] CHECK CONSTRAINT [FK_GuiaRemision_Pesaje]
GO
ALTER TABLE [dbo].[MovimientoPesaje]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoPesaje_Pesaje] FOREIGN KEY([PesajeId])
REFERENCES [dbo].[Pesaje] ([PesajeId])
GO
ALTER TABLE [dbo].[MovimientoPesaje] CHECK CONSTRAINT [FK_MovimientoPesaje_Pesaje]
GO
ALTER TABLE [dbo].[MovimientoPesaje]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoPesaje_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[MovimientoPesaje] CHECK CONSTRAINT [FK_MovimientoPesaje_Usuario]
GO
ALTER TABLE [dbo].[Pesaje]  WITH CHECK ADD  CONSTRAINT [FK_Pesaje_Autorizacion] FOREIGN KEY([AutorizacionId])
REFERENCES [dbo].[Autorizacion] ([AutorizacionId])
GO
ALTER TABLE [dbo].[Pesaje] CHECK CONSTRAINT [FK_Pesaje_Autorizacion]
GO
ALTER TABLE [dbo].[Pesaje]  WITH CHECK ADD  CONSTRAINT [FK_Pesaje_Conductor] FOREIGN KEY([ConductorId])
REFERENCES [dbo].[Conductor] ([ConductorId])
GO
ALTER TABLE [dbo].[Pesaje] CHECK CONSTRAINT [FK_Pesaje_Conductor]
GO
ALTER TABLE [dbo].[Pesaje]  WITH CHECK ADD  CONSTRAINT [FK_Pesaje_Nave] FOREIGN KEY([NaveId])
REFERENCES [dbo].[Nave] ([NaveId])
GO
ALTER TABLE [dbo].[Pesaje] CHECK CONSTRAINT [FK_Pesaje_Nave]
GO
ALTER TABLE [dbo].[Pesaje]  WITH CHECK ADD  CONSTRAINT [FK_Pesaje_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Pesaje] CHECK CONSTRAINT [FK_Pesaje_Usuario]
GO
ALTER TABLE [dbo].[Pesaje]  WITH CHECK ADD  CONSTRAINT [FK_Pesaje_Vehiculo] FOREIGN KEY([VehiculoId])
REFERENCES [dbo].[Vehiculo] ([VehiculoId])
GO
ALTER TABLE [dbo].[Pesaje] CHECK CONSTRAINT [FK_Pesaje_Vehiculo]
GO
ALTER TABLE [dbo].[Reporte]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Turno] FOREIGN KEY([TurnoId])
REFERENCES [dbo].[Turno] ([TurnoId])
GO
ALTER TABLE [dbo].[Reporte] CHECK CONSTRAINT [FK_Reporte_Turno]
GO
ALTER TABLE [dbo].[Reporte]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Reporte] CHECK CONSTRAINT [FK_Reporte_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolId])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Conductor] FOREIGN KEY([ConductorId])
REFERENCES [dbo].[Conductor] ([ConductorId])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Conductor]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_TipoVehiculo] FOREIGN KEY([TipoVehiculoId])
REFERENCES [dbo].[TipoVehiculo] ([TipoVehiculoId])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_TipoVehiculo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ReportePesaje]    Script Date: 28/10/2015 04:33:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ReportePesaje]
as
Select v.Placa as 'Num. de Placa del vehiculo', tv.Nombre as 'Num. de Ejes de la Unidad', P.Tipo AS 'Razón de la Unidad', c.FechaMuelle, c.FechaBarco , DATEDIFF(MINUTE,c.FechaMuelle,c.FechaBarco) AS 'Tiempo de Atención del vehiculo',CONVERT(varchar(10),C.FechaIzaje,103) as 'Fecha de Operación' from Pesaje P, Vehiculo V, TipoVehiculo TV, Contenedor C
where P.VehiculoId = V.VehiculoId and V.TipoVehiculoId = TV.TipoVehiculoId and p.CodContenedor =  c.ContenedorId


GO
USE [master]
GO
ALTER DATABASE [BDParacas1] SET  READ_WRITE 
GO
