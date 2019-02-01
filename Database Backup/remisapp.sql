USE [master]
GO
/****** Object:  Database [remisapp]    Script Date: 12/18/2018 3:56:40 PM ******/
CREATE DATABASE [remisapp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'remisapp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\remisapp.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'remisapp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\remisapp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [remisapp] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [remisapp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [remisapp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [remisapp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [remisapp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [remisapp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [remisapp] SET ARITHABORT OFF 
GO
ALTER DATABASE [remisapp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [remisapp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [remisapp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [remisapp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [remisapp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [remisapp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [remisapp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [remisapp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [remisapp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [remisapp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [remisapp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [remisapp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [remisapp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [remisapp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [remisapp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [remisapp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [remisapp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [remisapp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [remisapp] SET  MULTI_USER 
GO
ALTER DATABASE [remisapp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [remisapp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [remisapp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [remisapp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [remisapp]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[splitstring] ( @stringToSplit VARCHAR(MAX), @charIndex Varchar(1) )
RETURNS
@returnList TABLE ([Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(@charIndex, @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(@charIndex, @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END
GO
/****** Object:  Table [dbo].[Beneficio]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beneficio](
	[id_beneficio] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descuento] [numeric](5, 2) NULL,
	[vigencia_desde] [date] NULL,
	[vigencia_hasta] [date] NULL,
	[descripcion] [varchar](50) NULL,
	[estado] [varchar](1) NULL,
	[total_acumulado] [numeric](8, 2) NULL,
	[cantidad_viajes] [numeric](6, 0) NULL,
 CONSTRAINT [PK_Beneficios] PRIMARY KEY CLUSTERED 
(
	[id_beneficio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer](
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_comision] [numeric](18, 0) NULL,
	[id_vehiculo] [numeric](18, 0) NULL,
	[estado] [varchar](1) NULL,
 CONSTRAINT [PK_Chofer] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer_Turno]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer_Turno](
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_turno] [numeric](18, 0) NOT NULL,
	[estado] [varchar](1) NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_Chofer_Turno] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC,
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comision](
	[id_comision] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[porcentaje] [numeric](5, 2) NULL,
	[descripcion] [varchar](50) NULL,
	[vigencia_desde] [date] NULL,
	[vigencia_hasta] [date] NULL,
	[estado] [varchar](1) NULL,
 CONSTRAINT [PK_Comisiones] PRIMARY KEY CLUSTERED 
(
	[id_comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilio](
	[id_domicilio] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_persona] [numeric](18, 0) NOT NULL,
	[calle] [varchar](200) NULL,
	[numero] [varchar](50) NULL,
	[dpto] [varchar](5) NULL,
	[piso] [numeric](3, 0) NULL,
	[cp] [varchar](15) NULL,
	[localidad] [varchar](200) NULL,
	[provincia] [varchar](200) NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[id_marca] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Autos_Marcas] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[id_modelo] [numeric](18, 0) NOT NULL,
	[id_marca] [numeric](18, 0) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[id_modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[id_permiso] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[estado] [varchar](1) NULL,
 CONSTRAINT [PK_Roles_1] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[id_persona] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](500) NULL,
	[estado] [varchar](1) NULL,
	[nro_documento] [numeric](11, 0) NULL,
	[fecha_nacimiento] [date] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[id_persona] [numeric](18, 0) NOT NULL,
	[categoria] [varchar](1) NULL,
	[fecha_vencimiento] [date] NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio](
	[id_persona] [numeric](18, 0) NOT NULL,
	[nro_socio] [numeric](18, 0) NOT NULL,
	[fecha_asociacion] [datetime] NOT NULL,
	[estado] [varchar](1) NULL,
 CONSTRAINT [PK_Socios] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[id_telefono] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_tipo_telefono] [numeric](5, 0) NOT NULL,
	[cod_pais] [varchar](5) NULL,
	[cod_area] [varchar](5) NULL,
	[numero] [varchar](15) NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[id_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Estado_Viaje]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Estado_Viaje](
	[id_estado] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[grupo] [varchar](10) NULL,
 CONSTRAINT [PK_Tipos_Estado_Viaje] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_telefono](
	[id_tipo_telefono] [numeric](5, 0) NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [PK_tipos_telefono] PRIMARY KEY CLUSTERED 
(
	[id_tipo_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id_turno] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[horario_entrada] [varchar](10) NULL,
	[horario_salida] [varchar](10) NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/18/2018 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_persona] [numeric](18, 0) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[estado] [varchar](1) NULL,
	[primer_ingreso] [varchar](1) NULL,
	[ultimo_ingreso] [date] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[usuario] [varchar](50) NOT NULL,
	[id_permiso] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios_Permisos] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC,
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[id_vehiculo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_modelo] [numeric](18, 0) NULL,
	[anio_Fabricacion] [numeric](4, 0) NULL,
	[patente] [varchar](20) NULL,
	[motor] [varchar](50) NULL,
	[chasis] [varchar](50) NULL,
	[estado] [varchar](1) NULL,
	[fecha_vencimiento_VTV] [date] NULL,
 CONSTRAINT [PK_Autos] PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje](
	[id_viaje] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[origen] [varchar](500) NOT NULL,
	[destino] [varchar](500) NOT NULL,
	[fecha_salida_estimada] [datetime] NOT NULL,
	[fecha_arribo_estimado] [datetime] NOT NULL,
	[km_estimados] [numeric](5, 0) NOT NULL,
	[comentarios] [varchar](4000) NULL,
	[id_socio] [numeric](18, 0) NOT NULL,
	[ida_vuelta] [varchar](1) NOT NULL,
	[id_chofer_estimado] [numeric](18, 0) NOT NULL,
	[id_estado] [numeric](18, 0) NOT NULL,
	[precio] [numeric](8, 2) NULL,
	[km_recorridos] [numeric](5, 0) NULL,
	[fecha_salida] [datetime] NULL,
	[fecha_arribo] [datetime] NULL,
	[id_chofer] [numeric](18, 0) NULL,
	[precio_estimado] [numeric](8, 2) NOT NULL,
	[duracion_estimada] [numeric](5, 0) NOT NULL,
	[duracion] [numeric](5, 0) NULL,
 CONSTRAINT [PK_Viajes] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje_Beneficio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje_Beneficio](
	[id_viaje] [numeric](18, 0) NOT NULL,
	[id_beneficio] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Viajes_Beneficios] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC,
	[id_beneficio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Beneficio] ON 

INSERT [dbo].[Beneficio] ([id_beneficio], [descuento], [vigencia_desde], [vigencia_hasta], [descripcion], [estado], [total_acumulado], [cantidad_viajes]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(13.50 AS Numeric(5, 2)), CAST(N'2018-12-18' AS Date), NULL, N'teset', N'A', CAST(10.00 AS Numeric(8, 2)), CAST(1 AS Numeric(6, 0)))
SET IDENTITY_INSERT [dbo].[Beneficio] OFF
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), N'A')
INSERT [dbo].[Chofer_Turno] ([id_persona], [id_turno], [estado], [fecha_modificacion]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'A', CAST(N'2018-12-18' AS Date))
SET IDENTITY_INSERT [dbo].[Comision] ON 

INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(12.00 AS Numeric(5, 2)), N'Por defecto', CAST(N'2018-01-01' AS Date), NULL, N'D')
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(25.00 AS Numeric(5, 2)), N'Castigo', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A')
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(6.00 AS Numeric(5, 2)), N'Premio', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A')
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(2.00 AS Numeric(5, 2)), N'super premio', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A')
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(20.00 AS Numeric(5, 2)), N'pruebas', CAST(N'2018-02-06' AS Date), NULL, N'A')
SET IDENTITY_INSERT [dbo].[Comision] OFF
SET IDENTITY_INSERT [dbo].[Domicilio] ON 

INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'calle', N'123', N'B', CAST(1 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires')
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(31 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'Calle', N'123', NULL, CAST(1 AS Numeric(3, 0)), N'1234', N'Saraza', N'Buenos Aires')
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(32 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'Calle', N'2', NULL, CAST(0 AS Numeric(3, 0)), N'1432', N'San Miguel', N'San Juan')
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(33 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'asd', N'123', N'', CAST(0 AS Numeric(3, 0)), N'123', N'123', N'123')
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(34 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'casa', N'1', N'1', CAST(1 AS Numeric(3, 0)), N'1', N'test', N'test')
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia]) VALUES (CAST(35 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'Calle', N'123', NULL, CAST(0 AS Numeric(3, 0)), N'1678', N'Isidro Casanova', N'Buenos Aires')
SET IDENTITY_INSERT [dbo].[Domicilio] OFF
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(1 AS Numeric(18, 0)), N'ACURA')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(2 AS Numeric(18, 0)), N'AUDI')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(3 AS Numeric(18, 0)), N'BMW')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(4 AS Numeric(18, 0)), N'CADILLAC')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(5 AS Numeric(18, 0)), N'CHRYSLER')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(6 AS Numeric(18, 0)), N'CITROEN')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(7 AS Numeric(18, 0)), N'FAW')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(8 AS Numeric(18, 0)), N'FIAT')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(9 AS Numeric(18, 0)), N'FORD')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(10 AS Numeric(18, 0)), N'GENERAL MOTORS')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(11 AS Numeric(18, 0)), N'HONDA')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(12 AS Numeric(18, 0)), N'HUMMER')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(13 AS Numeric(18, 0)), N'LAND ROVER')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(14 AS Numeric(18, 0)), N'LINCOLN')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(15 AS Numeric(18, 0)), N'MAZDA')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(16 AS Numeric(18, 0)), N'MERCEDES BENZ')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(17 AS Numeric(18, 0)), N'MERCURY')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(18 AS Numeric(18, 0)), N'MITSUBISHI')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(19 AS Numeric(18, 0)), N'NISSAN')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(20 AS Numeric(18, 0)), N'PEUGEOT')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(21 AS Numeric(18, 0)), N'PORSCHE')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(22 AS Numeric(18, 0)), N'RENAULT')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(23 AS Numeric(18, 0)), N'SEAT')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(24 AS Numeric(18, 0)), N'SSANGYONG')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(25 AS Numeric(18, 0)), N'SUBARU')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(26 AS Numeric(18, 0)), N'SUZUKI')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(27 AS Numeric(18, 0)), N'TATA MOTORS')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(28 AS Numeric(18, 0)), N'TOYOTA')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(29 AS Numeric(18, 0)), N'VAM')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(30 AS Numeric(18, 0)), N'VOLKSWAGEN')
INSERT [dbo].[Marca] ([id_marca], [descripcion]) VALUES (CAST(31 AS Numeric(18, 0)), N'ZILENT')
SET IDENTITY_INSERT [dbo].[Marca] OFF
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CHEVELLE, NOVA, CAPRICE, OPEL')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'DART K, VOLARE K')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'CORDOBA,MONACO, LE BARON ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'CHRYSLER 600')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'DATSUN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'TSURU')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'PINTO,MAVERICK,FAIRMONT, TOPAZ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(29 AS Numeric(18, 0)), N'V. A. M.')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'RENAULT MODELO 86 Y ANTERIORES')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'SEDAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'CARIBE, BRASILIA, SAFARI')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'COMBI')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'ATLANTIC')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'CORSAR, VARIANT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'VOLARE, SUPER BEE, STEALTH')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SUBURBAN, CARRY ALL')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'SAMURAI, SAKURA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'RAM CHARGER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'GOLF MODELO 92 Y ANTERIORES')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'JETTA MODELO 92 Y ANTERIORES')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'SHADOW')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'ICHI VAN PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(23 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'CARRY ALL')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CAVALIER MODELO 94 Y ANTERIORES')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'BLAZER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'SPIRIT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'VOYAGER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(28 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'GHIA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(29 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'AEROSTAR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'EXPLORER ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(31 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SILHOUETTE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(32 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'GOLF MODELO 92 AL 99')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(33 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'JETTA MODELO 92 AL 99 ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(34 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CHEVY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(35 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP WRANGLER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(36 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP GRAND CHEROKEE ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(37 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CAVALIER MODELO 2004 AL 1995')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(38 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'NEON ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(39 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'ESCORT ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), N'MYSTIQUE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(41 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'WINDSTAR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(42 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'DERBY ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(43 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'STRATUS Y BREEZE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(44 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'RAM PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(45 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'TSUBAME')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(46 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'CIRRUS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(47 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'SENTRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(48 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'LUMINA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(49 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TRACKER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'CONTOUR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(51 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'GRAN PRIX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(52 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'VENTURE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(53 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'MALIBU NUEVA GENERACION')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(54 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SUNFIRE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(55 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'PATHFINDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(56 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'QUEST')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(57 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'EXPEDITION')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(58 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'CIVIC')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(59 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'306')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(60 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'EXPRESS VAN PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(61 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'DURANGO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(62 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'FIESTA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(63 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), N'NAVIGATOR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(64 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'CLUB WAGON PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(65 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'POINTER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(66 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'BEETLE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(67 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'GRAN AM')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(68 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'URVAN PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(69 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'XTERRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(70 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'FOCUS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(71 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'JETTA MODELO 1999 AL 2011/ CLASICO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(72 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'GOLF MODELO 1999 AL 2011 ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(73 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TIGRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(74 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'PT CRUISER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(75 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'ASTRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(76 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'AZTEK')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(77 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SONORA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(78 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'ESCAPE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(79 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'EUROVAN PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(80 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'ODISSEY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(81 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'MAGNUM')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(82 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'ATOS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(83 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'EXCURSION')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(84 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'206')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(85 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'SCENIC')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(86 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'MONDEO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(87 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'IBIZA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(88 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'CORDOBA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(89 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'TOLEDO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(90 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'MEGANE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(91 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'IKON')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(92 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'KA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(93 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP LIBERTY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(94 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'ZAFIRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(95 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'XTRAIL')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(96 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'CROWN VICTORIA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(97 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CORSA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(98 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'ESCALADE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(99 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'CRV')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(100 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'PLATINA')
GO
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(101 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'CLIO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(102 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'ALHAMBRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(103 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'SHARAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(104 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'CAMRY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(105 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'COROLLA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(106 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'MATRIX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(107 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'COOPER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(108 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'POLO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(109 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'4 RUNNER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(110 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'MERIVA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(111 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'VECTRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(112 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'PACIFICA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(113 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'PALIO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(114 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'PALIO ADVENTURE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(115 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'ECOSPORT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(116 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'PILOT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(117 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), N'AVIATOR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(118 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'LANCER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(119 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'MONTERO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(120 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'OUTLANDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(121 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'SPACESTAR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(122 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'MURANO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(123 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), N'CAYENNE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(124 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'307')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(125 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'MATIZ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(126 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'LAND CRUISER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(127 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'RAV4')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(128 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'SIENNA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(129 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'YARIS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(130 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'TOUAREG')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(131 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'FREESTAR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(132 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CHEVY C2')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(133 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'VERNA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(134 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'LUPO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(135 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'ENDEAVOR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(136 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), N'MARINER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(137 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'G6')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(138 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'EQUINOX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(139 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'MICRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(140 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'ARMADA ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(141 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), N'H3')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(142 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'X3')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(143 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'CLASE G')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(144 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'CLASE ML ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(145 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'G4')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(146 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'MONTANA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(147 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'UPLANDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(148 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'HHR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(149 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP COMMANDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(150 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'FIT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(151 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'APRIO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(152 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'BORA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(153 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'MDX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(154 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'3')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(155 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'6')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(156 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'AERIO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(157 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'GRAND VITARA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(158 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'HIACE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(159 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'ATTITUDE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(160 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'CALIBER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(161 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'TIIDA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(162 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'SWIFT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(163 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'G3')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(164 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'CROSSFOX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(165 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TORRENT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(166 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'OUTBACK')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(167 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'B9 TRIBECA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(168 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'AVENGER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(169 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'YUKON')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(170 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TAHOE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(171 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'OPTRA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(172 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'GRAND RAID')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(173 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'SPORTVAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(174 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'NITRO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(175 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP COMPASS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(176 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'ASPEN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(177 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'GRANDIS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(178 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'EDGE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(179 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Q7')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(180 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'RDX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(181 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'SPRINTER PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(182 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'FORESTER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(183 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TRAIL BLAZER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(184 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP PATRIOT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(185 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'PANDA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(186 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'GRANDE PUNTO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(187 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'IDEA ADVENTURE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(188 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), N'MKX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(189 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'MATIZ G2')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(190 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'G5')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(191 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'ACADIA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(192 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'FJ CRUISER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(193 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'TRAFIC PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(194 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'CX7')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(195 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'CX9')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(196 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'XL7')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(197 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'AVANZA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(198 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'HIGHLANDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(199 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'TRANSIT PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(200 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'ROGUE')
GO
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(201 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CAPTIVA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(202 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'F1')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(203 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'F4')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(204 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'F5')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(205 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JOURNEY ')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(206 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'SX4')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(207 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'AVEO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(208 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'SMART')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(209 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'BORA SPORTWAGEN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(210 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'ALBEA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(211 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'ROUTAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(212 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'SEQUOIA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(213 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'KOLEOS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(214 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'308')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(215 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'X5')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(216 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'SAFRANE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(217 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'FREETRACK')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(218 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'GOL')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(219 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'TIGUAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(220 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TRAVERSE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(221 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Q5')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(222 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'EPICA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(223 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'CRUZE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(224 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'RUSH')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(225 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'500')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(226 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'CITY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(227 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'LINEA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(228 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SPARK')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(229 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), N'H2')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(230 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'DISCOVERY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(231 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'FREELANDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(232 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'LR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(233 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'RANGE ROVER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(234 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'3008')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(235 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'EXPERT TEPEE PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(236 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'FLUENCE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(237 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'PRIUS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(238 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'TRANSPORTER PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(239 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'SANDERO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(240 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'STEPWAY')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(241 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'SCALA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(242 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP CHEROKEE SPORT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(243 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'RAM MAXI WAGON PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(244 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'ECONOLINE PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(245 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'CLASE GLK')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(246 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'MARCH')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(247 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'VERSA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(248 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'KANGOO PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(249 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'KIZASHI')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(250 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'POINTER STATION WAGON')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(251 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'H100 PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(252 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'EXEO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(253 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'I 10')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(254 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'MANAGER PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(255 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'JUKE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(256 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'NUEVO JETTA A6')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(257 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'SONIC')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(258 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'VITO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(259 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'DEFENDER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(260 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'ELEMENT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(261 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'LEAF')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(262 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'C')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(263 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'DS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(264 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), N'MOUNTAINEER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(265 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'NANO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(266 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'MANZA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(267 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'VISTA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(268 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'INDICA')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(269 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'INDIGO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(270 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'SAFARI')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(271 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'SUMO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(272 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), N'REXTON')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(273 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP RENEGADE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(274 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'VIANO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(275 AS Numeric(18, 0)), CAST(31 AS Numeric(18, 0)), N'COURANT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(276 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'AVENSIS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(277 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'DUSTER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(278 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP J-364')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(279 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'JEEP WAGONEER')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(280 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Q3')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(281 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'EVOQUE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(282 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'CROSSTOUR')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(283 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'DART DESDE 2012')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(284 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'TRAX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(285 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'ILX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(286 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'GF8')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(287 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'GF70')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(288 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'MULTIVAN')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(289 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'CRAFTER PASAJEROS')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(290 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'CX-5')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(291 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'UNO')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(292 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'VOLT')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(293 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'301')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(294 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'PARTNER TEPEE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(295 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'ASX')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(296 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'NOTE')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(297 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'208')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(298 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'XV')
INSERT [dbo].[Modelo] ([id_modelo], [id_marca], [descripcion]) VALUES (CAST(299 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), N'VENTO')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'A', N'Administrador', N'O')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'C', N'Chofer', N'O')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'G', N'Gerente', N'A')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'O', N'Operador', N'A')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'R', N'Responsable', N'A')
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(5 AS Numeric(18, 0)), N'admin', N'admin', N'admin@remisapp.com', N'A', CAST(99999999 AS Numeric(11, 0)), CAST(N'2018-01-01' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(6 AS Numeric(18, 0)), N'Operador', N'Operado', N'operador@mail.com', N'A', CAST(20123123 AS Numeric(11, 0)), CAST(N'1987-04-03' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(7 AS Numeric(18, 0)), N'Gerente', N'Gerente', N'gerenete@mail.com', N'A', CAST(20321321 AS Numeric(11, 0)), CAST(N'1959-06-10' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(8 AS Numeric(18, 0)), N'Responsable', N'Responsable', N'responsable@mail.com', N'A', CAST(123123123 AS Numeric(11, 0)), CAST(N'1975-06-04' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(9 AS Numeric(18, 0)), N'chofer', N'chofer', N'chofer@mail.com', N'A', CAST(30123123 AS Numeric(11, 0)), CAST(N'2000-12-18' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(10 AS Numeric(18, 0)), N'jorge', N'lopez', N'jorge', N'A', CAST(20202020 AS Numeric(11, 0)), CAST(N'2018-07-11' AS Date))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento]) VALUES (CAST(11 AS Numeric(18, 0)), N'Socio 1', N'Apellido Socio 1', N'socio1@mail.com', N'A', CAST(20321321 AS Numeric(11, 0)), CAST(N'1989-07-13' AS Date))
SET IDENTITY_INSERT [dbo].[Persona] OFF
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento]) VALUES (CAST(9 AS Numeric(18, 0)), N'B', CAST(N'2018-07-20' AS Date))
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(N'2018-12-18T07:44:24.777' AS DateTime), N'A')
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), CAST(N'2018-12-18T15:31:11.237' AS DateTime), N'A')
SET IDENTITY_INSERT [dbo].[Telefono] ON 

INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'1567952853')
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), CAST(2 AS Numeric(5, 0)), N'54', N'11', N'43221123')
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(3 AS Numeric(5, 0)), N'54', N'11', N'44455312')
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'11', N'54', N'123123')
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'11', N'54', N'20123321')
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), CAST(2 AS Numeric(5, 0)), N'54', N'11', N'4444123')
SET IDENTITY_INSERT [dbo].[Telefono] OFF
SET IDENTITY_INSERT [dbo].[Tipo_Estado_Viaje] ON 

INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(1 AS Numeric(18, 0)), N'En Curso', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(2 AS Numeric(18, 0)), N'Reservado', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(3 AS Numeric(18, 0)), N'Pendiente', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(4 AS Numeric(18, 0)), N'Rechazado', N'Fin')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(5 AS Numeric(18, 0)), N'Finalizado', N'Fin')
SET IDENTITY_INSERT [dbo].[Tipo_Estado_Viaje] OFF
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(1 AS Numeric(5, 0)), N'Celular')
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(2 AS Numeric(5, 0)), N'Fijo')
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(3 AS Numeric(5, 0)), N'Laboral')
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida]) VALUES (CAST(1 AS Numeric(18, 0)), N'Mañana', N'6', N'13')
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida]) VALUES (CAST(2 AS Numeric(18, 0)), N'Tarde', N'13', N'18')
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida]) VALUES (CAST(3 AS Numeric(18, 0)), N'Noche', N'18', N'22')
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida]) VALUES (CAST(4 AS Numeric(18, 0)), N'Madrugada', N'22', N'6')
SET IDENTITY_INSERT [dbo].[Turno] OFF
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso]) VALUES (CAST(5 AS Numeric(18, 0)), N'admin', N'd033e22ae348aeb5660fc2140aec35850c4da997', N'A', N'S', NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso]) VALUES (CAST(6 AS Numeric(18, 0)), N'20123123', N'c624cbc39d0eba28c6abf3869293659b1cad0472', N'A', N'S', NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso]) VALUES (CAST(7 AS Numeric(18, 0)), N'20321321', N'c614b3b86b8b405a07a1a0e8c15ec337ff3e5802', N'A', N'S', NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso]) VALUES (CAST(8 AS Numeric(18, 0)), N'123123123', N'88ea39439e74fa27c09a4fc0bc8ebe6d00978392', N'A', N'S', NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso]) VALUES (CAST(9 AS Numeric(18, 0)), N'30123123', N'6b6a518625315ba3a73d068962168d683bbaeaba', N'A', N'S', NULL)
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'123123123', N'R')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'20123123', N'O')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'20321321', N'G')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'30123123', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'admin', N'A')
SET IDENTITY_INSERT [dbo].[Vehiculo] ON 

INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(92 AS Numeric(18, 0)), CAST(2018 AS Numeric(4, 0)), N'AC411NX', N'ASDAJS1231', N'KDFSDFKJ12', N'A', NULL)
SET IDENTITY_INSERT [dbo].[Vehiculo] OFF
SET IDENTITY_INSERT [dbo].[Viaje] ON 

INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion]) VALUES (CAST(10044 AS Numeric(18, 0)), N'san jjuan', N'san luis', CAST(N'2018-12-18T07:44:41.000' AS DateTime), CAST(N'2018-12-18T10:23:41.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'El socio canceló', CAST(10 AS Numeric(18, 0)), N'N', CAST(9 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion]) VALUES (CAST(10046 AS Numeric(18, 0)), N'test', N'test', CAST(N'2018-12-18T15:37:20.000' AS DateTime), CAST(N'2018-12-18T18:16:20.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'cancelacion de prueba', CAST(11 AS Numeric(18, 0)), N'S', CAST(9 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion]) VALUES (CAST(10047 AS Numeric(18, 0)), N'prueba', N'nueva', CAST(N'2018-12-18T15:40:00.000' AS DateTime), CAST(N'2018-12-18T17:42:25.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'Salió más caro de lo previsto', CAST(11 AS Numeric(18, 0)), N'S', CAST(9 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(430.00 AS Numeric(8, 2)), CAST(10 AS Numeric(5, 0)), CAST(N'2018-12-18T15:40:25.000' AS DateTime), CAST(N'2018-12-18T15:40:41.487' AS DateTime), CAST(9 AS Numeric(18, 0)), CAST(2106.00 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL)
SET IDENTITY_INSERT [dbo].[Viaje] OFF
/****** Object:  Index [UQ_Nro_documento]    Script Date: 12/18/2018 3:56:41 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Nro_documento] ON [dbo].[Persona]
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Ux_Usuario]    Script Date: 12/18/2018 3:56:41 PM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [Ux_Usuario] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Autos_Unique_Patente]    Script Date: 12/18/2018 3:56:41 PM ******/
ALTER TABLE [dbo].[Vehiculo] ADD  CONSTRAINT [IX_Autos_Unique_Patente] UNIQUE NONCLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chofer]  WITH CHECK ADD  CONSTRAINT [FK_Choferes_Comisiones] FOREIGN KEY([id_comision])
REFERENCES [dbo].[Comision] ([id_comision])
GO
ALTER TABLE [dbo].[Chofer] CHECK CONSTRAINT [FK_Choferes_Comisiones]
GO
ALTER TABLE [dbo].[Chofer]  WITH CHECK ADD  CONSTRAINT [FK_Choferes_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Chofer] CHECK CONSTRAINT [FK_Choferes_Personas]
GO
ALTER TABLE [dbo].[Chofer]  WITH CHECK ADD  CONSTRAINT [FK_Choferes_Vehiculos] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[Vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[Chofer] CHECK CONSTRAINT [FK_Choferes_Vehiculos]
GO
ALTER TABLE [dbo].[Chofer_Turno]  WITH CHECK ADD  CONSTRAINT [FK_Chofer_Turno_Chofer] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Chofer] ([id_persona])
GO
ALTER TABLE [dbo].[Chofer_Turno] CHECK CONSTRAINT [FK_Chofer_Turno_Chofer]
GO
ALTER TABLE [dbo].[Chofer_Turno]  WITH CHECK ADD  CONSTRAINT [FK_Chofer_Turno_Turno] FOREIGN KEY([id_turno])
REFERENCES [dbo].[Turno] ([id_turno])
GO
ALTER TABLE [dbo].[Chofer_Turno] CHECK CONSTRAINT [FK_Chofer_Turno_Turno]
GO
ALTER TABLE [dbo].[Domicilio]  WITH CHECK ADD  CONSTRAINT [FK_Domicilios_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Domicilio] CHECK CONSTRAINT [FK_Domicilios_Personas]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [FK_Modelo_Marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca] ([id_marca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [FK_Modelo_Marca]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Persona]
GO
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD  CONSTRAINT [FK_Socios_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Socio] CHECK CONSTRAINT [FK_Socios_Personas]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefonos_Personas]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_tipos_telefono] FOREIGN KEY([id_tipo_telefono])
REFERENCES [dbo].[Tipo_telefono] ([id_tipo_telefono])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefonos_tipos_telefono]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuarios_Personas]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Permiso_Usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuario] ([usuario])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuario_Permiso_Usuario]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Permisos_Permisos] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[Permiso] ([id_permiso])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuarios_Permisos_Permisos]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Modelo] FOREIGN KEY([id_modelo])
REFERENCES [dbo].[Modelo] ([id_modelo])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Modelo]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viaje_Chofer] FOREIGN KEY([id_chofer])
REFERENCES [dbo].[Chofer] ([id_persona])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viaje_Chofer]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viaje_Chofer_Estimado] FOREIGN KEY([id_chofer_estimado])
REFERENCES [dbo].[Chofer] ([id_persona])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viaje_Chofer_Estimado]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viaje_Socio] FOREIGN KEY([id_socio])
REFERENCES [dbo].[Socio] ([id_persona])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viaje_Socio]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Tipos_Estado_Viaje] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Tipo_Estado_Viaje] ([id_estado])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viajes_Tipos_Estado_Viaje]
GO
ALTER TABLE [dbo].[Viaje_Beneficio]  WITH CHECK ADD  CONSTRAINT [FK_Beneficios_Viajes] FOREIGN KEY([id_viaje])
REFERENCES [dbo].[Viaje] ([id_viaje])
GO
ALTER TABLE [dbo].[Viaje_Beneficio] CHECK CONSTRAINT [FK_Beneficios_Viajes]
GO
ALTER TABLE [dbo].[Viaje_Beneficio]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Beneficios] FOREIGN KEY([id_beneficio])
REFERENCES [dbo].[Beneficio] ([id_beneficio])
GO
ALTER TABLE [dbo].[Viaje_Beneficio] CHECK CONSTRAINT [FK_Viajes_Beneficios]
GO
/****** Object:  StoredProcedure [dbo].[BlanquearClave]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 13/12/2018
-- =============================================
CREATE PROCEDURE [dbo].[BlanquearClave]
	@id_persona numeric(18,0) = NULL,
	@usuario varchar(50)
AS
DECLARE @Password VARCHAR(100)
BEGIN
    SET @Password = (SELECT nro_documento FROM dbo.Persona WHERE id_persona = @id_persona);

	UPDATE dbo.Usuario
	SET password = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40),
		primer_ingreso = 'S'
	WHERE id_persona = @id_persona;
END
GO
/****** Object:  StoredProcedure [dbo].[GetBeneficiosSocio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetBeneficiosSocio]
  @id_socio Numeric(18,0)
AS
  Declare @cant_viajes int,
          @sum_precio numeric(8,2)
BEGIN
	SELECT @cant_viajes = COUNT(1), @sum_precio = SUM(precio) 
	  FROM dbo.Viaje
	 WHERE id_socio = @id_socio;

	SELECT id_beneficio 
	  FROM dbo.Beneficio
	 WHERE vigencia_desde < GETDATE()
	   AND (vigencia_hasta > GETDATE() OR vigencia_hasta is null)
	   AND @cant_viajes >= cantidad_viajes 
	   AND @sum_precio >= total_acumulado
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarBeneficio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarBeneficio]
	 @id_beneficio numeric(18,0),
	 @descuento numeric(5,2),
	 @descripcion varchar(50),
	 @vigencia_desde date,
	 @vigencia_hasta date,
	 @cantidadViajes int,
	 @totalAcumulado numeric(8,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Beneficio WHERE id_beneficio = @id_beneficio)
	BEGIN
		INSERT INTO dbo.Beneficio
		VALUES(@descuento,@vigencia_desde,@vigencia_hasta,@descripcion,'A',@totalAcumulado,@cantidadViajes)
	END
	ELSE
	BEGIN
		UPDATE dbo.Beneficio
		 SET descuento = @descuento,
			 descripcion = @descripcion,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta,
			 total_acumulado = @totalAcumulado,
			 cantidad_viajes = @cantidadViajes
		 WHERE id_beneficio = @id_beneficio
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarChofer]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 15/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarChofer]
	@id_persona numeric(18,0) = NULL,
	@id_comision numeric(18,0),
	@id_vehiculo numeric(18,0),
	@fecha_vencimiento_registro date,
	@categoria_registro varchar(1),
	@id_turno numeric(18,0)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.Chofer WHERE id_persona = @id_persona )
	BEGIN
		INSERT INTO dbo.Chofer (id_persona,id_comision,id_vehiculo,estado)
		VALUES(@id_persona,@id_comision,@id_vehiculo,'A');

		INSERT INTO dbo.Registro(id_persona,fecha_vencimiento,categoria)
		VALUES(@id_persona,@fecha_vencimiento_registro,@categoria_registro);

		INSERT INTO dbo.Chofer_Turno
		VALUES(@id_persona,@id_turno,'A',GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Chofer
		SET id_comision = @id_comision,
			id_vehiculo = @id_vehiculo
	    WHERE id_persona = @id_persona;

		IF NOT EXISTS (SELECT 1 FROM dbo.Registro WHERE id_persona = @id_persona )
		BEGIN
			INSERT INTO dbo.Registro(id_persona,fecha_vencimiento,categoria)
			VALUES(@id_persona,@fecha_vencimiento_registro,@categoria_registro);
		END
		ELSE
		BEGIN
			UPDATE dbo.Registro
			SEt fecha_vencimiento = @fecha_vencimiento_registro,
				categoria = @categoria_registro
			WHERE id_persona = @id_persona;
		END;

		DELETE dbo.Chofer_Turno WHERE id_persona = @id_persona;

		INSERT INTO dbo.Chofer_Turno
		VALUES(@id_persona,@id_turno,'A',GETDATE());

	END;
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarComision]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/7/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarComision]
	 @id_comision numeric(18,0),
	 @porcentaje numeric(5,2),
	 @descripcion varchar(50),
	 @vigencia_desde date,
	 @vigencia_hasta date = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Comision WHERE id_comision = @id_comision)
	BEGIN
		INSERT INTO dbo.Comision
		VALUES(@porcentaje,@descripcion,@vigencia_desde,@vigencia_hasta,'A')
	END
	ELSE
	BEGIN
		UPDATE dbo.Comision
		 SET porcentaje = @porcentaje,
			 descripcion = @descripcion,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta
		 WHERE id_comision = @id_comision
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarPermisosUsuario]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 21/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarPermisosUsuario]
	@usuario varchar(50),
	@permisos varchar(MAX)	 
AS
BEGIN
	DELETE dbo.Usuario_Permiso
	WHERE usuario = @usuario;

	INSERT INTO dbo.Usuario_Permiso
	SELECT @usuario,* FROM dbo.splitstring(@permisos,';');

END



GO
/****** Object:  StoredProcedure [dbo].[GuardarPersona]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 7/14/2018 11:39 PM
-- Description:	Guarda datos de una persona, nueva o existente.
-- =============================================
CREATE PROCEDURE [dbo].[GuardarPersona]
    @nombre varchar(100),
    @apellido varchar(100),
    @calle varchar(200),
	@numero varchar(50),
	@dpto varchar(5) = NULL,
	@piso numeric(3,0) = NULL,
	@cp varchar(15),
	@localidad varchar(200),
	@provincia varchar(200),
    @email varchar(500),
	@id_tipo_telefono numeric(18,0),
	@cod_pais varchar(200),
	@cod_area varchar(200),
	@nro_telefono varchar(200),
	@fecha_nacimiento date,
	@nro_documento numeric(11,0),
	@id_persona numeric(18,0) output
AS
BEGIN
	IF @id_persona IS NULL 
	BEGIN
		INSERT INTO dbo.Persona
		OUTPUT INSERTED.id_persona
		VALUES( @nombre,
				@apellido,
				@email,
				'A',
				@nro_documento,
				@fecha_nacimiento);
		SET @id_persona = (SELECT IDENT_CURRENT ('dbo.Persona'));

		INSERT INTO dbo.Domicilio(id_persona,calle,numero,cp,dpto,piso,localidad,provincia)
		VALUES (@id_persona, @calle, @numero, @cp, @dpto, @piso, @localidad, @provincia);
		INSERT INTO dbo.Telefono(id_persona,id_tipo_telefono,cod_pais,cod_area,numero)
		VALUES (@id_persona, @id_tipo_telefono,@cod_pais,@cod_area,@nro_telefono);
	END
	ELSE
	BEGIN
	 UPDATE dbo.Persona
	 SET nombre = @nombre,
		 apellido =	@apellido,
		 email	=	@email,
		 fecha_nacimiento = @fecha_nacimiento,
		 nro_documento = @nro_documento
	 WHERE id_persona = @id_persona;

	 IF NOT EXISTS (SELECT 1 FROM dbo.Domicilio WHERE id_persona = @id_persona)
	 BEGIN
		 INSERT INTO dbo.Domicilio(id_persona,calle,numero,cp,dpto,piso,localidad,provincia)
			VALUES (@id_persona, @calle, @numero, @cp, @dpto, @piso, @localidad, @provincia);
	 END
	 ELSE
	 BEGIN
		 UPDATE dbo.Domicilio
		  SET calle  = @calle,
			  numero = @numero,
			  cp     = @cp,
			  dpto   = @dpto,
			  piso   = @piso,
			  localidad = @localidad,
			  provincia =  @provincia
		  WHERE id_persona = @id_persona;
	 END;

	 IF NOT EXISTS (SELECT 1 FROM dbo.Telefono WHERE id_persona = @id_persona)
	 BEGIN
		 INSERT INTO dbo.Telefono(id_persona,id_tipo_telefono,cod_pais,cod_area,numero)
		VALUES (@id_persona, @id_tipo_telefono,@cod_pais,@cod_area,@nro_telefono);
	 END
	 ELSE
	 BEGIN
		 UPDATE dbo.Telefono
		  SET id_tipo_telefono = @id_tipo_telefono,
		  cod_pais = @cod_pais,
		  cod_area = @cod_area,
		  numero = @nro_telefono
		  WHERE id_persona = @id_persona;
	 END;
	END; 
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarSocio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 16/06/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarSocio]
    @id_persona numeric(18,0) = NULL
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM dbo.Socio WHERE id_persona = @id_persona )
	BEGIN
	 INSERT INTO dbo.Socio(id_persona,nro_socio,fecha_asociacion,estado)
	 VALUES(@id_persona,@id_persona,GETDATE(),'A');
	END
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 16/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarUsuario]
	@id_persona numeric(18,0) = NULL,
	@usuario varchar(50),
	@password varchar(50)
AS
DECLARE @ErrorMsg varchar(256)
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE id_persona = @id_persona )
		BEGIN
			INSERT INTO dbo.Usuario(usuario,password,id_persona,estado,primer_ingreso,ultimo_ingreso)
			VALUES( @usuario,
					SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40),
					@id_persona,
					'A',
					'S',
					NULL);
		END
	 END TRY
	 BEGIN CATCH
	  SET @ErrorMsg = ('Error al guardar usuario (' + @usuario + '). Error SQL: '+ ERROR_MESSAGE());
	   THROW 50001,@ErrorMsg , 1;
	 END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarVehiculo]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 21/11/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarVehiculo]
	@id_vehiculo numeric(18,0) = NULL,
	@id_modelo numeric(18,0),
	@anio_Fabricacion numeric(4,0),
	@patente varchar(11),
	@chasis varchar(50),
	@motor varchar(50),
	@Fecha_Vencimiento_VTV date
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
	IF NOT EXISTS (SELECT 1 FROM dbo.Vehiculo WHERE id_vehiculo = @id_vehiculo )
	BEGIN
		INSERT INTO dbo.Vehiculo
		VALUES(@id_Modelo,@anio_Fabricacion,@patente,@motor,@chasis,'A',@Fecha_Vencimiento_VTV);
	END
	ELSE 
	BEGIN
		UPDATE dbo.Vehiculo
		SET
		id_Modelo = @id_Modelo,
		anio_Fabricacion = @anio_Fabricacion,
		patente = @patente,
		motor = @motor,
		chasis = @chasis,
		fecha_vencimiento_VTV = @Fecha_Vencimiento_VTV
		WHERE id_vehiculo = @id_vehiculo
	END
	COMMIT
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarViaje]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 15/07/2018
-- =============================================

CREATE PROCEDURE [dbo].[GuardarViaje]
        @id_viaje numeric(18,0) = NULL,
        @origen  varchar(500),
        @destino  varchar(500),
        @fecha_salida datetime = NULL,
		@fecha_salida_estimada datetime,
        @fecha_arribo datetime = NULL,
		@fecha_arribo_estimado datetime,
        @km_recorridos numeric(5,0) = NULL,
		@km_estimados numeric(5,0),
		@precio numeric(8,2) = NULL,
		@precio_estimado numeric(8,2),
        @comentarios varchar(4000) = NULL,
		@id_socio numeric(18,0),
		@id_chofer  numeric(18,0) = NULL,
		@id_chofer_estimado numeric(18,0),
		@ida_Vuelta  varchar(1) = 'S',
		@id_estado numeric(18,0),
		@duracion numeric(5,0) = NULL,
		@duracion_estimada numeric(5,0),
		@beneficios  varchar(MAX) = NULL
AS
BEGIN

	IF @id_viaje IS NULL OR NOT EXISTS (SELECT 1 FROM dbo.Viaje WHERE id_viaje = @id_viaje )
	BEGIN
		INSERT INTO dbo.Viaje
		(origen		
		,destino		
		,fecha_salida_estimada
		,fecha_salida	
		,fecha_arribo_estimado
		,fecha_arribo	
		,km_estimados   
		,km_recorridos	
		,comentarios	
		,id_chofer_estimado
		,id_chofer		
		,id_socio		
		,ida_vuelta		
		,id_estado		
		,precio			
		,precio_estimado
		,duracion_estimada
		,duracion)
		OUTPUT INSERTED.id_viaje
		VALUES(
		 @origen
		,@destino	
		,@fecha_salida_estimada
		,@fecha_salida
		,@fecha_arribo_estimado
		,@fecha_arribo
		,@km_estimados
		,@km_recorridos
		,@comentarios
		,@id_chofer_estimado
		,@id_chofer
		,@id_socio
		,@ida_vuelta
		,@id_estado
		,@precio
		,@precio_estimado
		,@duracion_estimada
		,@duracion);
		SET @id_viaje = (SELECT IDENT_CURRENT ('dbo.Viaje'));		
	END
	ELSE 
	BEGIN
		UPDATE dbo.Viaje
		SET
		 origen			= @origen
		,destino		= @destino
		,fecha_salida_estimada = @fecha_salida_estimada
		,fecha_salida	= @fecha_salida
		,fecha_arribo_estimado = @fecha_arribo_estimado
		,fecha_arribo	= @fecha_arribo
		,km_estimados   = @km_estimados
		,km_recorridos	= @km_recorridos
		,comentarios	= @comentarios
		,id_chofer_estimado = @id_chofer_estimado
		,id_chofer		= @id_chofer
		,id_socio		= @id_socio
		,ida_vuelta		= @ida_vuelta
		,id_estado		= @id_estado
		,precio			= @precio
		,precio_estimado = @precio_estimado
		,duracion_estimada = @duracion_estimada
		,duracion = @duracion
		WHERE id_viaje = @id_viaje
	END

	IF @beneficios IS NOT NULL
	BEGIN
		EXEC GuardarViajeBeneficio @id_viaje,@beneficios;
	END;

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarViajeBeneficio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 29/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarViajeBeneficio]
	@id_viaje numeric(18,0),
	@beneficios	 varchar(MAX)	 
AS
BEGIN

	INSERT INTO dbo.Viaje_Beneficio
	SELECT @id_viaje,* FROM dbo.splitstring(@beneficios,';');

END
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 09/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[Login] 
	-- Add the parameters for the stored procedure here
	@Usuario VARCHAR(50), 
	@Password VARCHAR(50),
	@Respuesta INT OUT
AS
BEGIN
	SET NOCOUNT ON;
	SET @Respuesta = ISNULL((SELECT 1 FROM dbo.Usuario
		WHERE usuario = @Usuario
		AND Password = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40)),0);
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarBeneficio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarBeneficio]
	 @id_beneficio numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	UPDATE dbo.Beneficio
		 SET estado = 'I'
		 WHERE id_beneficio = @id_beneficio
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarChofer]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 18/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarChofer]
	@id_persona numeric(18,0)
AS
BEGIN
	UPDATE dbo.Chofer
	SET estado = 'I'
	WHERE id_persona = @id_persona;
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarComision]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarComision]
	 @id_comision numeric(18,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	UPDATE dbo.Comision
		 SET estado = 'I'
		 WHERE id_comision = @id_comision
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarSocio]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 18/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarSocio]
	@id_persona numeric(18,0)
AS
BEGIN
	UPDATE dbo.Socio
	SET estado = 'I'
	WHERE id_persona = @id_persona;
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarUsuario]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 20/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarUsuario]
	@usuario varchar(50)
AS
BEGIN
	UPDATE dbo.Usuario
	SET estado = 'I'
	WHERE usuario = @usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarVehiculo]    Script Date: 12/18/2018 3:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 19/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarVehiculo]
	@id_vehiculo numeric(18,0)
AS
BEGIN
	UPDATE dbo.Vehiculo
	SET estado = 'I'
	WHERE id_vehiculo = @id_vehiculo;
END
GO
USE [master]
GO
ALTER DATABASE [remisapp] SET  READ_WRITE 
GO
