USE [remisapp]
GO
/****** Object:  StoredProcedure [dbo].[QuitarVehiculo]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarVehiculo]
GO
/****** Object:  StoredProcedure [dbo].[QuitarUsuario]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[QuitarTurno]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarTurno]
GO
/****** Object:  StoredProcedure [dbo].[QuitarSocio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarSocio]
GO
/****** Object:  StoredProcedure [dbo].[QuitarParametro]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarParametro]
GO
/****** Object:  StoredProcedure [dbo].[QuitarComision]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarComision]
GO
/****** Object:  StoredProcedure [dbo].[QuitarChofer]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarChofer]
GO
/****** Object:  StoredProcedure [dbo].[QuitarBeneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[QuitarAccion]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[QuitarAccion]
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[Login]
GO
/****** Object:  StoredProcedure [dbo].[GuardarViajeBeneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarViajeBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarViaje]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarViaje]
GO
/****** Object:  StoredProcedure [dbo].[GuardarVehiculo]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarVehiculo]
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[GuardarTurno]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarTurno]
GO
/****** Object:  StoredProcedure [dbo].[GuardarTicketComprobante]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarTicketComprobante]
GO
/****** Object:  StoredProcedure [dbo].[GuardarSocio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarSocio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarPersona]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarPersona]
GO
/****** Object:  StoredProcedure [dbo].[GuardarPermisosUsuario]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarPermisosUsuario]
GO
/****** Object:  StoredProcedure [dbo].[GuardarParametro]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarParametro]
GO
/****** Object:  StoredProcedure [dbo].[GuardarComision]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarComision]
GO
/****** Object:  StoredProcedure [dbo].[GuardarChoferAccion]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarChoferAccion]
GO
/****** Object:  StoredProcedure [dbo].[GuardarChofer]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarChofer]
GO
/****** Object:  StoredProcedure [dbo].[GuardarBeneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarAccion]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GuardarAccion]
GO
/****** Object:  StoredProcedure [dbo].[GetBeneficiosSocio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[GetBeneficiosSocio]
GO
/****** Object:  StoredProcedure [dbo].[CrearUsuarioAdministrador]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[CrearUsuarioAdministrador]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaPuntosChoferes]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[ConsultaPuntosChoferes]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaChoferesParaViajes]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[ConsultaChoferesParaViajes]
GO
/****** Object:  StoredProcedure [dbo].[BlanquearClave]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[BlanquearClave]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPassword]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP PROCEDURE [dbo].[ActualizarPassword]
GO
ALTER TABLE [dbo].[Viaje_Beneficio] DROP CONSTRAINT [FK_Viajes_Beneficios]
GO
ALTER TABLE [dbo].[Viaje_Beneficio] DROP CONSTRAINT [FK_Beneficios_Viajes]
GO
ALTER TABLE [dbo].[Viaje] DROP CONSTRAINT [FK_Viajes_Tipos_Estado_Viaje]
GO
ALTER TABLE [dbo].[Viaje] DROP CONSTRAINT [FK_Viaje_Socio]
GO
ALTER TABLE [dbo].[Viaje] DROP CONSTRAINT [FK_Viaje_Chofer_Estimado]
GO
ALTER TABLE [dbo].[Viaje] DROP CONSTRAINT [FK_Viaje_Chofer]
GO
ALTER TABLE [dbo].[Vehiculo] DROP CONSTRAINT [FK_Vehiculo_Modelo]
GO
ALTER TABLE [dbo].[Usuario_Permiso] DROP CONSTRAINT [FK_Usuarios_Permisos_Permisos]
GO
ALTER TABLE [dbo].[Usuario_Permiso] DROP CONSTRAINT [FK_Usuario_Permiso_Usuario]
GO
ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Usuarios_Personas]
GO
ALTER TABLE [dbo].[Ticket_Comprobante] DROP CONSTRAINT [FK_Ticket_Comprobante_Viaje]
GO
ALTER TABLE [dbo].[Telefono] DROP CONSTRAINT [FK_Telefonos_tipos_telefono]
GO
ALTER TABLE [dbo].[Telefono] DROP CONSTRAINT [FK_Telefonos_Personas]
GO
ALTER TABLE [dbo].[Socio] DROP CONSTRAINT [FK_Socios_Personas]
GO
ALTER TABLE [dbo].[Registro] DROP CONSTRAINT [FK_Registro_Chofer]
GO
ALTER TABLE [dbo].[Modelo] DROP CONSTRAINT [FK_Modelo_Marca]
GO
ALTER TABLE [dbo].[Estado_Viaje] DROP CONSTRAINT [FK_Estado_Viaje_Viaje]
GO
ALTER TABLE [dbo].[Estado_Viaje] DROP CONSTRAINT [FK_Estado_Viaje_Tipo_Estado_Viaje]
GO
ALTER TABLE [dbo].[Domicilio] DROP CONSTRAINT [FK_Domicilios_Personas]
GO
ALTER TABLE [dbo].[Chofer_Turno] DROP CONSTRAINT [FK_Chofer_Turno_Turno]
GO
ALTER TABLE [dbo].[Chofer_Turno] DROP CONSTRAINT [FK_Chofer_Turno_Chofer]
GO
ALTER TABLE [dbo].[Chofer_Accion] DROP CONSTRAINT [FK_Chofer_Accion_Chofer]
GO
ALTER TABLE [dbo].[Chofer_Accion] DROP CONSTRAINT [FK_Chofer_Accion_Accion]
GO
ALTER TABLE [dbo].[Chofer] DROP CONSTRAINT [FK_Choferes_Vehiculos]
GO
ALTER TABLE [dbo].[Chofer] DROP CONSTRAINT [FK_Choferes_Personas]
GO
ALTER TABLE [dbo].[Chofer] DROP CONSTRAINT [FK_Choferes_Comisiones]
GO
/****** Object:  Index [IX_Autos_Unique_Patente]    Script Date: 3/15/2019 2:20:54 PM ******/
ALTER TABLE [dbo].[Vehiculo] DROP CONSTRAINT [IX_Autos_Unique_Patente]
GO
/****** Object:  Index [Ux_Usuario]    Script Date: 3/15/2019 2:20:54 PM ******/
ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [Ux_Usuario]
GO
/****** Object:  Index [UQ_Nro_documento]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP INDEX [UQ_Nro_documento] ON [dbo].[Persona]
GO
/****** Object:  Table [dbo].[Viaje_Beneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Viaje_Beneficio]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Viaje]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Vehiculo]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Usuario_Permiso]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Turno]
GO
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Tipo_telefono]
GO
/****** Object:  Table [dbo].[Tipo_Estado_Viaje]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Tipo_Estado_Viaje]
GO
/****** Object:  Table [dbo].[Ticket_Comprobante]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Ticket_Comprobante]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Telefono]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Socio]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Registro]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Persona]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Permiso]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Parametro]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Modelo]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Marca]
GO
/****** Object:  Table [dbo].[Estado_Viaje]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Estado_Viaje]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Domicilio]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Comision]
GO
/****** Object:  Table [dbo].[Chofer_Turno]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Chofer_Turno]
GO
/****** Object:  Table [dbo].[Chofer_Accion]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Chofer_Accion]
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Chofer]
GO
/****** Object:  Table [dbo].[Beneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Beneficio]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP TABLE [dbo].[Accion]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP FUNCTION [dbo].[splitstring]
GO
USE [master]
GO
/****** Object:  Database [remisapp]    Script Date: 3/15/2019 2:20:54 PM ******/
DROP DATABASE [remisapp]
GO
/****** Object:  Database [remisapp]    Script Date: 3/15/2019 2:20:54 PM ******/
CREATE DATABASE [remisapp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'remisapp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\remisapp.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'remisapp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\remisapp_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 3/15/2019 2:20:54 PM ******/
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
/****** Object:  Table [dbo].[Accion]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accion](
	[id_accion] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[puntaje] [numeric](5, 2) NOT NULL,
	[vigencia_desde] [date] NOT NULL,
	[vigencia_hasta] [date] NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Accion] PRIMARY KEY CLUSTERED 
(
	[id_accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Beneficio]    Script Date: 3/15/2019 2:20:54 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Beneficios] PRIMARY KEY CLUSTERED 
(
	[id_beneficio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer](
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_comision] [numeric](18, 0) NULL,
	[id_vehiculo] [numeric](18, 0) NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Chofer] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer_Accion]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer_Accion](
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_accion] [numeric](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Chofer_Accion] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC,
	[id_accion] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chofer_Turno]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chofer_Turno](
	[id_chofer_turno] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_persona] [numeric](18, 0) NOT NULL,
	[id_turno] [numeric](18, 0) NOT NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Chofer_Turno] PRIMARY KEY CLUSTERED 
(
	[id_chofer_turno] ASC,
	[id_persona] ASC,
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 3/15/2019 2:20:54 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Comisiones] PRIMARY KEY CLUSTERED 
(
	[id_comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 3/15/2019 2:20:54 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Viaje]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Viaje](
	[id_estado_viaje] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_viaje] [numeric](18, 0) NOT NULL,
	[id_tipo_estado_viaje] [numeric](18, 0) NOT NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Estado_Viaje] PRIMARY KEY CLUSTERED 
(
	[id_estado_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 3/15/2019 2:20:54 PM ******/
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
/****** Object:  Table [dbo].[Modelo]    Script Date: 3/15/2019 2:20:54 PM ******/
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
/****** Object:  Table [dbo].[Parametro]    Script Date: 3/15/2019 2:20:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametro](
	[id_parametro] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[clave] [varchar](50) NULL,
	[valor] [varchar](50) NULL,
	[vigencia_desde] [date] NULL,
	[vigencia_hasta] [date] NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED 
(
	[id_parametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/15/2019 2:20:54 PM ******/
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
/****** Object:  Table [dbo].[Persona]    Script Date: 3/15/2019 2:20:54 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[id_persona] [numeric](18, 0) NOT NULL,
	[categoria] [varchar](1) NULL,
	[fecha_vencimiento] [date] NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio](
	[id_persona] [numeric](18, 0) NOT NULL,
	[nro_socio] [numeric](18, 0) NOT NULL,
	[fecha_asociacion] [datetime] NOT NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Socios] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[id_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket_Comprobante]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket_Comprobante](
	[id_comprobante] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_viaje] [numeric](18, 0) NULL,
	[fecha_emision] [datetime] NULL,
 CONSTRAINT [PK_Ticket_Comprobante] PRIMARY KEY CLUSTERED 
(
	[id_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Estado_Viaje]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  Table [dbo].[Turno]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id_turno] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[horario_entrada] [varchar](10) NULL,
	[horario_salida] [varchar](10) NULL,
	[estado] [varchar](1) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	[ultimo_ingreso] [datetime] NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [varchar](50) NULL,
 CONSTRAINT [PK_Autos] PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	[ahorro] [numeric](8, 2) NULL,
	[usuario_creacion] [varchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[usuario_ult_mod] [varchar](50) NULL,
	[fecha_ult_mod] [datetime] NULL,
 CONSTRAINT [PK_Viajes] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje_Beneficio]    Script Date: 3/15/2019 2:20:55 PM ******/
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
SET IDENTITY_INSERT [dbo].[Accion] ON 

INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'Tomar viaje otro chofer', CAST(2.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'Cumplir horario salida', CAST(1.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), N'Cumplir horario llegada', CAST(1.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), N'Llegar tarde', CAST(-1.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), N'Salir tarde', CAST(-2.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Accion] ([id_accion], [descripcion], [puntaje], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), N'Inconveniente con usuario', CAST(-5.00 AS Numeric(5, 2)), CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Accion] OFF
SET IDENTITY_INSERT [dbo].[Beneficio] ON 

INSERT [dbo].[Beneficio] ([id_beneficio], [descuento], [vigencia_desde], [vigencia_hasta], [descripcion], [estado], [total_acumulado], [cantidad_viajes], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(13.50 AS Numeric(5, 2)), CAST(N'2018-12-18' AS Date), NULL, N'teset', N'A', CAST(10.00 AS Numeric(8, 2)), CAST(1 AS Numeric(6, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Beneficio] ([id_beneficio], [descuento], [vigencia_desde], [vigencia_hasta], [descripcion], [estado], [total_acumulado], [cantidad_viajes], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(20.00 AS Numeric(5, 2)), CAST(N'2019-03-11' AS Date), NULL, N'descuento fuerte', N'A', CAST(10.00 AS Numeric(8, 2)), CAST(5 AS Numeric(6, 0)), N'26000002', CAST(N'2019-03-11T19:30:42.890' AS DateTime), NULL, NULL)
INSERT [dbo].[Beneficio] ([id_beneficio], [descuento], [vigencia_desde], [vigencia_hasta], [descripcion], [estado], [total_acumulado], [cantidad_viajes], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(5.00 AS Numeric(5, 2)), CAST(N'2019-03-13' AS Date), CAST(N'2019-03-15' AS Date), N'Mininmo', N'A', CAST(100.00 AS Numeric(8, 2)), CAST(2 AS Numeric(6, 0)), N'26000001', CAST(N'2019-03-14T01:33:53.610' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Beneficio] OFF
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.593' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.110' AS DateTime), N'26000002', CAST(N'2019-03-11T19:29:57.597' AS DateTime))
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.597' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.597' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.397' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T19:29:57.547' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'26000002', CAST(N'2019-03-11T19:29:57.297' AS DateTime), N'26000001', CAST(N'2019-03-13T23:15:25.523' AS DateTime))
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000002', CAST(N'2019-03-11T18:33:40.120' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'26000001', CAST(N'2019-03-13T23:33:55.700' AS DateTime), N'26000001', CAST(N'2019-03-13T23:38:20.633' AS DateTime))
INSERT [dbo].[Chofer] ([id_persona], [id_comision], [id_vehiculo], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', N'26000001', CAST(N'2019-03-14T01:32:35.303' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.080' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-05T15:30:14.340' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-13T14:10:14.503' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-13T14:12:59.723' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-13T14:16:30.633' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T00:48:22.740' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T00:50:51.910' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T00:56:29.260' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T01:06:52.110' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-13T13:52:11.207' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-14T01:04:46.450' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-14T01:11:35.160' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-14T02:01:47.553' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-05T15:31:32.933' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:29:33.537' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:34:35.273' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:44:58.690' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:51:34.770' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:54:10.420' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:56:17.573' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T13:01:48.257' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T13:03:21.830' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:25:43.207' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:28:11.187' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:28:21.117' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:03.057' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:09.247' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:37.033' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:39:29.510' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-13T13:52:47.250' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-13T14:10:25.833' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-13T14:13:10.877' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-13T14:16:40.780' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-13T14:16:57.120' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:48:39.853' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:51:07.240' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:52:22.750' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:56:42.197' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:04:59.047' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:07:07.970' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:11:44.417' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T02:01:57.600' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T13:00:08.343' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-12T09:52:41.683' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T00:43:27.720' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:53:02.177' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:44:56.310' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T12:52:59.497' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-11T13:37:14.437' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T00:58:52.430' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T01:02:33.260' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-14T01:41:23.690' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-11T13:37:41.313' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-12T09:52:09.587' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T00:59:03.357' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:02:42.623' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:41:43.200' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T12:59:17.100' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-14T01:43:07.737' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-05T21:02:50.627' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-14T01:43:42.963' AS DateTime))
INSERT [dbo].[Chofer_Accion] ([id_persona], [id_accion], [fecha]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T12:58:34.137' AS DateTime))
SET IDENTITY_INSERT [dbo].[Chofer_Turno] ON 

INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:11:59.947' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-11T19:29:57.630' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:22:38.030' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:24:22.780' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:30:17.157' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:33:27.790' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-05T12:37:35.630' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'I', NULL, NULL, N'26000001', CAST(N'2019-03-13T23:15:25.567' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'A', NULL, NULL, NULL, CAST(N'2019-03-11T18:33:40.130' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'I', N'26000001', CAST(N'2019-03-13T23:33:55.703' AS DateTime), N'26000001', CAST(N'2019-03-13T23:34:10.557' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'26000001', CAST(N'2019-03-13T23:38:20.640' AS DateTime), NULL, NULL)
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'I', N'26000001', CAST(N'2019-03-14T01:32:35.310' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.083' AS DateTime))
INSERT [dbo].[Chofer_Turno] ([id_chofer_turno], [id_persona], [id_turno], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'25000001', CAST(N'2019-03-14T01:35:10.083' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Chofer_Turno] OFF
SET IDENTITY_INSERT [dbo].[Comision] ON 

INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(12.00 AS Numeric(5, 2)), N'Por defecto', CAST(N'2018-01-01' AS Date), NULL, N'D', NULL, NULL, NULL, NULL)
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(25.00 AS Numeric(5, 2)), N'Castigo', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(6.00 AS Numeric(5, 2)), N'Premio', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(2.00 AS Numeric(5, 2)), N'super premio', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Comision] ([id_comision], [porcentaje], [descripcion], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(20.00 AS Numeric(5, 2)), N'pruebas', CAST(N'2018-02-06' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Comision] OFF
SET IDENTITY_INSERT [dbo].[Domicilio] ON 

INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Carlos Casares', N'321', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'Av. Illia', N'300', NULL, CAST(0 AS Numeric(3, 0)), N'1754', N'San Justo', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'Av. Rivadavia', N'13123', NULL, CAST(0 AS Numeric(3, 0)), N'1704', N'Ramos Mejía', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'Lujan', N'4500', N'F', CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'Lujan', N'758', N'F', CAST(3 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'Ayacucho', N'203', N'C', CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'Av. Cristiania', N'2500', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'Roma', N'4385', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'Castañon', N'150', N'2', CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'Castañon', N'150', N'2', CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), N'Roque Perez', N'5368', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), N'Roma', N'4385', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), N'Los Andes', N'890', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'Marconi', N'201', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, N'26000002', CAST(N'2019-03-11T19:29:57.587' AS DateTime))
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), N'Vicente Lopez', N'230', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), N'Gaboto', N'5001', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), N'Florencio Varela', N'2330', NULL, CAST(0 AS Numeric(3, 0)), N'1754', N'San Justo', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'Lafuente', N'1234', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), N'Oruro', N'2020', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', NULL, NULL, NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), N'Av. El Cortijo', N'210', NULL, CAST(0 AS Numeric(3, 0)), N'1784', N'Merlo Gomez', N'Buenos Aires', NULL, NULL, N'26000001', CAST(N'2019-03-13T23:15:25.463' AS DateTime))
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), N'Calle', N'1234', N'F', CAST(1 AS Numeric(3, 0)), N'1567', N'Padua', N'Buenos Aires', N'26000002', CAST(N'2019-03-11T18:19:41.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'a', N'1', N'a', CAST(1 AS Numeric(3, 0)), N'123', N'test', N'test', N'26000002', CAST(N'2019-03-11T18:23:54.667' AS DateTime), NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(23 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), N'a', N'1', N'1', CAST(1 AS Numeric(3, 0)), N'1234', N'isidro casanova', N'buenos aires', N'26000002', CAST(N'2019-03-11T18:33:40.087' AS DateTime), N'26000002', CAST(N'2019-03-11T18:33:40.160' AS DateTime))
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), N'Castañon', N'150', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', N'26000001', CAST(N'2019-03-13T23:33:55.680' AS DateTime), N'26000001', CAST(N'2019-03-13T23:38:20.630' AS DateTime))
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), N'Av Crisitiania', N'2789', NULL, CAST(0 AS Numeric(3, 0)), N'1765', N'Isidro Casanova', N'Buenos Aires', N'27000002', CAST(N'2019-03-14T01:25:13.277' AS DateTime), NULL, NULL)
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), N'Las Heras', N'340', N'F', CAST(3 AS Numeric(3, 0)), N'1055', N'CABA', N'CABA', N'26000001', CAST(N'2019-03-14T01:32:35.300' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.080' AS DateTime))
INSERT [dbo].[Domicilio] ([id_domicilio], [id_persona], [calle], [numero], [dpto], [piso], [cp], [localidad], [provincia], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), N'Falsa', N'123', NULL, CAST(0 AS Numeric(3, 0)), N'1000', N'CABA', N'CABA', N'27000001', CAST(N'2019-03-15T13:14:03.900' AS DateTime), N'27000001', CAST(N'2019-03-15T13:14:20.750' AS DateTime))
SET IDENTITY_INSERT [dbo].[Domicilio] OFF
SET IDENTITY_INSERT [dbo].[Estado_Viaje] ON 

INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000005', CAST(N'2019-03-14T00:43:27.740' AS DateTime), N'28000005', CAST(N'2019-03-14T00:44:56.310' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000005', CAST(N'2019-03-14T00:44:56.313' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T00:48:22.747' AS DateTime), N'28000001', CAST(N'2019-03-14T00:48:39.853' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T00:48:39.853' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T00:50:26.133' AS DateTime), N'28000001', CAST(N'2019-03-14T00:52:22.750' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T00:50:51.920' AS DateTime), N'28000001', CAST(N'2019-03-14T00:52:22.750' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T00:51:07.240' AS DateTime), N'28000001', CAST(N'2019-03-14T00:52:22.750' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T00:52:22.753' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T00:55:24.013' AS DateTime), N'28000001', CAST(N'2019-03-14T00:56:42.197' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T00:55:44.217' AS DateTime), N'28000002', CAST(N'2019-03-14T00:59:03.360' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T00:56:29.267' AS DateTime), N'28000001', CAST(N'2019-03-14T00:56:42.197' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T00:56:42.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000002', CAST(N'2019-03-14T00:58:52.437' AS DateTime), N'28000002', CAST(N'2019-03-14T00:59:03.360' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000002', CAST(N'2019-03-14T00:59:03.360' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:02:20.847' AS DateTime), N'28000002', CAST(N'2019-03-14T01:02:42.623' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000002', CAST(N'2019-03-14T01:02:33.273' AS DateTime), N'28000002', CAST(N'2019-03-14T01:02:42.623' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000002', CAST(N'2019-03-14T01:02:42.623' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:04:07.757' AS DateTime), N'28000001', CAST(N'2019-03-14T01:04:59.050' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T01:04:46.460' AS DateTime), N'28000001', CAST(N'2019-03-14T01:04:59.050' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T01:04:59.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:07:30.447' AS DateTime), N'28000001', CAST(N'2019-03-14T01:07:07.970' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T01:06:52.117' AS DateTime), N'28000001', CAST(N'2019-03-14T01:07:07.970' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(23 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T01:07:07.970' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:11:15.403' AS DateTime), N'28000001', CAST(N'2019-03-14T01:11:44.420' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T01:11:35.170' AS DateTime), N'28000001', CAST(N'2019-03-14T01:11:44.420' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T01:11:44.420' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:39:37.300' AS DateTime), N'28000002', CAST(N'2019-03-14T01:41:43.203' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(28 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000002', CAST(N'2019-03-14T01:41:23.700' AS DateTime), N'28000002', CAST(N'2019-03-14T01:41:43.203' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(29 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'A', N'28000002', CAST(N'2019-03-14T01:41:43.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T01:42:18.897' AS DateTime), N'28000012', CAST(N'2019-03-14T01:43:56.737' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(31 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000012', CAST(N'2019-03-14T01:43:07.740' AS DateTime), N'28000012', CAST(N'2019-03-14T01:43:56.737' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(32 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'I', N'28000012', CAST(N'2019-03-14T01:43:42.967' AS DateTime), N'28000012', CAST(N'2019-03-14T01:43:56.737' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(33 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'28000012', CAST(N'2019-03-14T01:43:56.737' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(34 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T02:00:45.057' AS DateTime), N'27000002', CAST(N'2019-03-14T02:01:02.540' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(35 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'27000002', CAST(N'2019-03-14T02:01:02.540' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(36 AS Numeric(18, 0)), CAST(29 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'I', N'27000002', CAST(N'2019-03-14T02:01:22.003' AS DateTime), N'28000001', CAST(N'2019-03-14T02:02:06.620' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(37 AS Numeric(18, 0)), CAST(29 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T02:01:47.560' AS DateTime), N'28000001', CAST(N'2019-03-14T02:02:06.620' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(38 AS Numeric(18, 0)), CAST(29 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'I', N'28000001', CAST(N'2019-03-14T02:01:57.600' AS DateTime), N'28000001', CAST(N'2019-03-14T02:02:06.620' AS DateTime))
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(39 AS Numeric(18, 0)), CAST(29 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'A', N'28000001', CAST(N'2019-03-14T02:02:06.620' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'A', N'27000002', CAST(N'2019-03-14T11:16:51.297' AS DateTime), NULL, NULL)
INSERT [dbo].[Estado_Viaje] ([id_estado_viaje], [id_viaje], [id_tipo_estado_viaje], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(41 AS Numeric(18, 0)), CAST(31 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'A', N'27000001', CAST(N'2019-03-15T13:10:05.213' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Estado_Viaje] OFF
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
SET IDENTITY_INSERT [dbo].[Parametro] ON 

INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), N'KM_VALOR', N'3.45', CAST(N'2019-03-14' AS Date), NULL, N'A', NULL, NULL, N'25000001', CAST(N'2019-03-14T01:36:03.360' AS DateTime))
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'KM_DIST_MIN', N'2', CAST(N'2019-03-02' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'USER_ADMN', N'32969556', CAST(N'2019-03-02' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), N'TOLERANCIA_SALIDA', N'10', CAST(N'2019-03-03' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), N'AGENCIA_NOMBRE', N'San Cayetano', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), N'AGENCIA_CALLE', N'Gaboto', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), N'AGENCIA_NRO', N'1500', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), N'AGENCIA_CP', N'1765', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), N'AGENCIA_TEL', N'+54 9 11 67952853', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), N'AGENCIA_PROV', N'Buenos Aires', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), N'CORREO_HABILITADO', N'S', CAST(N'2018-11-05' AS Date), NULL, N'A', NULL, NULL, N'25000001', CAST(N'2019-03-13T13:51:40.033' AS DateTime))
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), N'AGENCIA_EMAIL', N'remisapp.uai@gmail.com', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), N'AGENCIA_PSW', N'remisapp2019', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), N'AGENCIA_CUIT', N'20-32969556-6', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), N'AGENCIA_IIBB', N'20-32969556-6', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), N'AGENCIA_INI_ACT', N'2019-03-01', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), N'TIPO_FACTURA', N'X', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), N'PERIODO_PUNTAJE', N'60', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parametro] ([id_parametro], [clave], [valor], [vigencia_desde], [vigencia_hasta], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), N'PERIODO_BENEFICIOS', N'30', CAST(N'2019-03-01' AS Date), NULL, N'A', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Parametro] OFF
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'A', N'Administrador', N'O')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'C', N'Chofer', N'O')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'G', N'Gerente', N'A')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'O', N'Operador', N'A')
INSERT [dbo].[Permiso] ([id_permiso], [descripcion], [estado]) VALUES (N'R', N'Responsable', N'A')
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), N'USER_ADMN', NULL, NULL, NULL, CAST(32969556 AS Numeric(11, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'Julio', N'Araoz', N'julio@mail.com', N'A', CAST(25000001 AS Numeric(11, 0)), CAST(N'1985-03-05' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'Ignacio', N'Marcone', N'imarcone@mail.com', N'A', CAST(26000001 AS Numeric(11, 0)), CAST(N'1983-12-12' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), N'Alejandra', N'Ochoa', N'aochoa@mail.com', N'A', CAST(26000002 AS Numeric(11, 0)), CAST(N'1984-01-04' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), N'Julieta', N'Perez', N'jperez@mail.com', N'A', CAST(27000001 AS Numeric(11, 0)), CAST(N'1985-04-19' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), N'Julieta', N'Perez', N'jperez@mail.com', N'A', CAST(2700001 AS Numeric(11, 0)), CAST(N'1985-04-19' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), N'Maria Laura', N'Caceres', N'mlcaceres@mail.com', N'A', CAST(27000002 AS Numeric(11, 0)), CAST(N'1985-05-13' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), N'Maria Laura', N'Caceres', N'mlcaceres@mail.com', N'A', CAST(27000002 AS Numeric(11, 0)), CAST(N'1989-05-01' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), N'Pedro Rubén', N'Garcia', N'pbgarcia@mail.com', N'A', CAST(27000003 AS Numeric(11, 0)), CAST(N'1989-06-12' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), N'Sergio Valentin', N'Areco', N'sergio_areco@hotmail.com', N'A', CAST(32969556 AS Numeric(11, 0)), CAST(N'1987-04-03' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), N'Yanet Magdalena', N'Pagano', N'pagano_yanet@yahoo.com.ar', N'A', CAST(34213733 AS Numeric(11, 0)), CAST(N'1988-12-05' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), N'Carlos Alberto', N'Areco', N'careco@mail.com', N'A', CAST(29279339 AS Numeric(11, 0)), CAST(N'1982-12-05' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), N'Maria Cristina', N'Cabañas', N'mccabanias@mail.com', N'A', CAST(92217730 AS Numeric(11, 0)), CAST(N'1955-10-21' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), N'Eduardo Miguel', N'Gomez', N'emgomez@mail.com', N'A', CAST(28000001 AS Numeric(11, 0)), CAST(N'1994-06-14' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), N'Mario Héctor', N'Ledesma', N'mledesmas@mail.com', N'A', CAST(28000005 AS Numeric(11, 0)), CAST(N'1991-07-09' AS Date), NULL, NULL, N'26000002', CAST(N'2019-03-11T19:29:57.580' AS DateTime))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), N'Carlos', N'Rocha', N'crocha@mail.com', N'A', CAST(28000011 AS Numeric(11, 0)), CAST(N'1992-01-17' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), N'Angel', N'Carruego', N'acarruego@mail.com', N'A', CAST(28000016 AS Numeric(11, 0)), CAST(N'1992-01-17' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), N'Roberto', N'Arroyo', N'rarroyo@mai.com', N'A', CAST(28000002 AS Numeric(11, 0)), CAST(N'1990-02-28' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), N'Mirta', N'Acassuso', N'macassuso', N'A', CAST(28000006 AS Numeric(11, 0)), CAST(N'1989-07-13' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), N'Alberto', N'Cabañas', N'acabanias@mai.com', N'A', CAST(28000012 AS Numeric(11, 0)), CAST(N'1985-08-08' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), N'Pablo Ramón', N'Castillo', N'pcastillo@mail.com', N'A', CAST(28000017 AS Numeric(11, 0)), CAST(N'1988-10-11' AS Date), NULL, NULL, N'26000001', CAST(N'2019-03-13T23:15:25.460' AS DateTime))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(22 AS Numeric(18, 0)), N'Marcos', N'Prueba', N'marquitos@test.com', N'A', CAST(34213999 AS Numeric(11, 0)), CAST(N'2001-03-06' AS Date), N'26000002', CAST(N'2019-03-11T18:19:41.163' AS DateTime), NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(23 AS Numeric(18, 0)), N'e', N'e', N'ser@mail.com', N'A', CAST(1312312 AS Numeric(11, 0)), CAST(N'2001-03-11' AS Date), N'26000002', CAST(N'2019-03-11T18:23:54.667' AS DateTime), NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), N'a', N'b', N's@mail.com', N'A', CAST(123 AS Numeric(11, 0)), CAST(N'2001-03-02' AS Date), N'26000002', CAST(N'2019-03-11T18:33:40.083' AS DateTime), N'26000002', CAST(N'2019-03-11T18:33:40.160' AS DateTime))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), N'Julian Ramiro', N'Gonzalez', N'test@mail.com', N'A', CAST(34123123 AS Numeric(11, 0)), CAST(N'1990-02-28' AS Date), N'26000001', CAST(N'2019-03-13T23:33:55.680' AS DateTime), N'26000001', CAST(N'2019-03-13T23:38:20.627' AS DateTime))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), N'Mayerling', N'Angulo', N'sergio_areco@hotmail.com', N'A', CAST(92123123 AS Numeric(11, 0)), CAST(N'1993-06-22' AS Date), N'27000002', CAST(N'2019-03-14T01:25:13.273' AS DateTime), NULL, NULL)
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), N'Ignacio', N'Fucci', N'i.fucci@mail.com', N'A', CAST(29279339 AS Numeric(11, 0)), CAST(N'1982-06-16' AS Date), N'26000001', CAST(N'2019-03-14T01:32:35.300' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.080' AS DateTime))
INSERT [dbo].[Persona] ([id_persona], [nombre], [apellido], [email], [estado], [nro_documento], [fecha_nacimiento], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(28 AS Numeric(18, 0)), N'Ernesto', N'Lopez', N'sergio_areco@hotmail.com', N'A', CAST(23000123 AS Numeric(11, 0)), CAST(N'1979-06-14' AS Date), N'27000001', CAST(N'2019-03-15T13:14:03.887' AS DateTime), N'27000001', CAST(N'2019-03-15T13:14:20.750' AS DateTime))
SET IDENTITY_INSERT [dbo].[Persona] OFF
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), N'A', CAST(N'2020-12-23' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), N'A', CAST(N'2020-03-11' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), N'A', CAST(N'2022-07-13' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), N'C', CAST(N'2021-09-29' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), N'B', CAST(N'2021-09-02' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), N'B', CAST(N'2022-09-16' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), N'B', CAST(N'2022-09-14' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), N'A', CAST(N'2022-09-24' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), N'B', CAST(N'2020-03-11' AS Date), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), N'A', CAST(N'2020-03-21' AS Date), N'A', N'26000001', CAST(N'2019-03-13T23:33:55.703' AS DateTime), N'26000001', CAST(N'2019-03-13T23:38:20.633' AS DateTime))
INSERT [dbo].[Registro] ([id_persona], [categoria], [fecha_vencimiento], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), N'B', CAST(N'2020-08-12' AS Date), N'A', N'26000001', CAST(N'2019-03-14T01:32:35.307' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.083' AS DateTime))
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(N'2019-03-05T11:38:17.647' AS DateTime), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), CAST(N'2019-03-05T11:40:31.140' AS DateTime), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), CAST(N'2019-03-05T11:41:42.093' AS DateTime), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(N'2019-03-05T11:43:10.333' AS DateTime), N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(N'2019-03-14T01:25:13.280' AS DateTime), N'A', N'27000002', CAST(N'2019-03-14T01:25:13.280' AS DateTime), NULL, NULL)
INSERT [dbo].[Socio] ([id_persona], [nro_socio], [fecha_asociacion], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(28 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), CAST(N'2019-03-15T13:14:03.900' AS DateTime), N'A', N'27000001', CAST(N'2019-03-15T13:14:03.900' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Telefono] ON 

INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'12341234', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'12344321', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'44444321', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'33335000', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'33331234', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'22228901', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'22224000', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'46782020', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'1167952853', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'67952853', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'54671234', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(2 AS Numeric(5, 0)), N'54', N'11', N'46943270', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'54127896', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), CAST(3 AS Numeric(5, 0)), N'54', N'11', N'45531234', NULL, NULL, N'26000002', CAST(N'2019-03-11T19:29:57.590' AS DateTime))
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'30002132', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'30023114', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'43253456', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'34557678', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'98703456', NULL, NULL, NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'46123453', NULL, NULL, N'26000001', CAST(N'2019-03-13T23:15:25.467' AS DateTime))
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'652343', N'26000002', CAST(N'2019-03-11T18:19:41.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'12312312', N'26000002', CAST(N'2019-03-11T18:23:54.667' AS DateTime), NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(23 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'123123', N'26000002', CAST(N'2019-03-11T18:33:40.087' AS DateTime), N'26000002', CAST(N'2019-03-11T18:33:40.160' AS DateTime))
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'34987789', N'26000001', CAST(N'2019-03-13T23:33:55.683' AS DateTime), N'26000001', CAST(N'2019-03-13T23:38:20.630' AS DateTime))
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'44667891', N'27000002', CAST(N'2019-03-14T01:25:13.277' AS DateTime), NULL, NULL)
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(27 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'653424', N'26000001', CAST(N'2019-03-14T01:32:35.300' AS DateTime), N'25000001', CAST(N'2019-03-14T01:35:10.080' AS DateTime))
INSERT [dbo].[Telefono] ([id_telefono], [id_persona], [id_tipo_telefono], [cod_pais], [cod_area], [numero], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(28 AS Numeric(18, 0)), CAST(1 AS Numeric(5, 0)), N'54', N'11', N'12344321', N'27000001', CAST(N'2019-03-15T13:14:03.900' AS DateTime), N'27000001', CAST(N'2019-03-15T13:14:20.750' AS DateTime))
SET IDENTITY_INSERT [dbo].[Telefono] OFF
SET IDENTITY_INSERT [dbo].[Ticket_Comprobante] ON 

INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T12:54:10.433' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T12:56:17.560' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(N'2019-03-08T12:58:34.150' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(N'2019-03-08T12:59:17.133' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2019-03-08T13:00:08.357' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T13:01:48.267' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-03-08T13:03:21.843' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), CAST(N'2019-03-11T13:37:41.317' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:25:43.223' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:28:11.207' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:28:21.120' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:03.073' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:09.250' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(N'2019-03-12T09:29:37.037' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(N'2019-03-12T09:39:29.530' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(12 AS Numeric(18, 0)), CAST(N'2019-03-12T09:52:09.603' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), CAST(N'2019-03-13T13:52:47.267' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(14 AS Numeric(18, 0)), CAST(N'2019-03-13T14:10:25.833' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(19 AS Numeric(18, 0)), CAST(13 AS Numeric(18, 0)), CAST(N'2019-03-13T14:13:10.877' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(N'2019-03-13T14:16:40.783' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(21 AS Numeric(18, 0)), CAST(16 AS Numeric(18, 0)), CAST(N'2019-03-13T14:16:57.123' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(22 AS Numeric(18, 0)), CAST(18 AS Numeric(18, 0)), CAST(N'2019-03-14T00:44:56.317' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(23 AS Numeric(18, 0)), CAST(17 AS Numeric(18, 0)), CAST(N'2019-03-14T00:48:39.853' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(24 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(N'2019-03-14T00:51:07.243' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), CAST(N'2019-03-14T00:52:22.757' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(N'2019-03-14T00:56:42.200' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), CAST(N'2019-03-14T00:59:03.363' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(28 AS Numeric(18, 0)), CAST(22 AS Numeric(18, 0)), CAST(N'2019-03-14T01:02:42.630' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(29 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), CAST(N'2019-03-14T01:05:07.260' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(24 AS Numeric(18, 0)), CAST(N'2019-03-14T01:07:07.977' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(31 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)), CAST(N'2019-03-14T01:11:44.420' AS DateTime))
INSERT [dbo].[Ticket_Comprobante] ([id_comprobante], [id_viaje], [fecha_emision]) VALUES (CAST(32 AS Numeric(18, 0)), CAST(26 AS Numeric(18, 0)), CAST(N'2019-03-14T01:41:43.207' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ticket_Comprobante] OFF
SET IDENTITY_INSERT [dbo].[Tipo_Estado_Viaje] ON 

INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(1 AS Numeric(18, 0)), N'En Curso', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(2 AS Numeric(18, 0)), N'Reservado', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(3 AS Numeric(18, 0)), N'Pendiente', N'Alta')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(4 AS Numeric(18, 0)), N'Cancelado', N'Fin')
INSERT [dbo].[Tipo_Estado_Viaje] ([id_estado], [descripcion], [grupo]) VALUES (CAST(5 AS Numeric(18, 0)), N'Finalizado', N'Fin')
SET IDENTITY_INSERT [dbo].[Tipo_Estado_Viaje] OFF
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(1 AS Numeric(5, 0)), N'Celular')
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(2 AS Numeric(5, 0)), N'Fijo')
INSERT [dbo].[Tipo_telefono] ([id_tipo_telefono], [descripcion]) VALUES (CAST(3 AS Numeric(5, 0)), N'Laboral')
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), N'Mañana', N'6', N'12', N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'Tarde', N'13', N'17', N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'Noche', N'18', N'23', N'A', NULL, NULL, NULL, NULL)
INSERT [dbo].[Turno] ([id_turno], [descripcion], [horario_entrada], [horario_salida], [estado], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), N'Madrugada', N'00', N'5', N'A', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Turno] OFF
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), N'32969556', N'7288edd0fc3ffcbe93a0cf06e3568e28521687bc', N'A', N'N', CAST(N'2019-03-15T11:57:25.847' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'25000001', N'7288edd0fc3ffcbe93a0cf06e3568e28521687bc', N'A', N'N', CAST(N'2019-03-15T14:04:49.280' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'26000001', N'7288edd0fc3ffcbe93a0cf06e3568e28521687bc', N'A', N'N', CAST(N'2019-03-14T15:35:25.467' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), N'26000002', N'2deac2f271a42349b34f75461ecdf5396a0a218d', N'A', N'N', CAST(N'2019-03-14T15:30:12.217' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), N'27000001', N'7288edd0fc3ffcbe93a0cf06e3568e28521687bc', N'A', N'N', CAST(N'2019-03-15T13:13:00.980' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), N'2700002', N'6a7c974be0c313429df373ca6af2ea5790bd413b', N'I', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), N'27000002', N'7288edd0fc3ffcbe93a0cf06e3568e28521687bc', N'A', N'N', CAST(N'2019-03-14T11:12:54.007' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), N'27000003', N'1cc8256bddcd64128a85dc34b6a218823d91aed5', N'A', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), N'28000001', N'9dde683afc071a1f1fb293cdf733cdc72eee529b', N'A', N'S', CAST(N'2019-03-14T02:01:50.840' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), N'28000005', N'0c11f6dba83de7579a5fb6e4b3aa2f472d45674e', N'A', N'S', CAST(N'2019-03-14T00:44:48.347' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), N'28000011', N'a1fc26ec48ba57478ff8ea44c3d5b47c514e6cd6', N'A', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), N'28000016', N'620d81082b140af406584868a74683718b4d85c9', N'A', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), N'28000002', N'6111bf96828b34706306ac523b80d14d9041aa2f', N'A', N'S', CAST(N'2019-03-14T01:41:33.853' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), N'28000006', N'b5ce333b4c60fe569ec2c80c5ed0e29ed89ca605', N'A', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), N'28000012', N'37d0f779635215a9b8e6c5e58f00c258bd762432', N'A', N'S', CAST(N'2019-03-14T01:43:16.400' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), N'28000017', N'641e71385cbde8544c2f020e14c020db9b1af2f0', N'A', N'S', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), N'123', N'40bd001563085fc35165329ea1ff5c5ecbdbbeef', N'A', N'S', NULL, N'26000002', CAST(N'2019-03-11T18:33:40.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), N'34123123', N'3ef82d99f3f69e864cba18f917d00b359b86e71e', N'A', N'S', NULL, N'26000001', CAST(N'2019-03-13T23:33:55.710' AS DateTime), NULL, NULL)
INSERT [dbo].[Usuario] ([id_persona], [usuario], [password], [estado], [primer_ingreso], [ultimo_ingreso], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), N'29279339', N'7ecffcdfe15dbfcfa793b4d03943f2d355d89eac', N'A', N'S', NULL, N'26000001', CAST(N'2019-03-14T01:32:35.313' AS DateTime), NULL, NULL)
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'123', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'25000001', N'G')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'26000001', N'R')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'26000002', N'R')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'27000001', N'O')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'27000002', N'O')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'27000003', N'O')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'2700002', N'O')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000001', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000002', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000005', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000006', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000011', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000012', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000016', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'28000017', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'29279339', N'C')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'32969556', N'A')
INSERT [dbo].[Usuario_Permiso] ([usuario], [id_permiso]) VALUES (N'34123123', N'C')
SET IDENTITY_INSERT [dbo].[Vehiculo] ON 

INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(92 AS Numeric(18, 0)), CAST(2018 AS Numeric(4, 0)), N'AC411NX', N'UEKAJ8098025', N'9BFZH55K9J8098025', N'A', CAST(N'2022-02-15' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(75 AS Numeric(18, 0)), CAST(2011 AS Numeric(4, 0)), N'LSG422', N'TDHAJ8432397', N'9BFZH55K9J8432397', N'A', CAST(N'2020-02-19' AS Date), NULL, NULL, N'26000002', N'Mar 11 2019  6:17PM')
INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(280 AS Numeric(18, 0)), CAST(2012 AS Numeric(4, 0)), N'LDS 213', N'SKDAKJ12381JWE98', N'12DASD983IJ12381JWE98', N'I', CAST(N'2019-08-01' AS Date), N'26000001', CAST(N'2019-03-11T13:54:56.950' AS DateTime), N'26000002', N'Mar 11 2019  6:18PM')
INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(58 AS Numeric(18, 0)), CAST(2012 AS Numeric(4, 0)), N'LKC321', N'ALSDA12312312', N'ALSDA12312312', N'A', CAST(N'2020-02-19' AS Date), N'26000002', CAST(N'2019-03-11T18:16:32.553' AS DateTime), NULL, NULL)
INSERT [dbo].[Vehiculo] ([id_vehiculo], [id_modelo], [anio_Fabricacion], [patente], [motor], [chasis], [estado], [fecha_vencimiento_VTV], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(105 AS Numeric(18, 0)), CAST(2017 AS Numeric(4, 0)), N'AA433HG', N'ASDKASJDHAlG', N'SDFDSFDS', N'A', CAST(N'2021-11-18' AS Date), N'26000001', CAST(N'2019-03-14T01:30:56.693' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Vehiculo] OFF
SET IDENTITY_INSERT [dbo].[Viaje] ON 

INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(1 AS Numeric(18, 0)), N'San Justo', N'Ciudad Evita', CAST(N'2019-03-05T15:05:00.000' AS DateTime), CAST(N'2019-03-05T17:44:57.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'test', CAST(11 AS Numeric(18, 0)), N'S', CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-05T15:05:57.000' AS DateTime), CAST(N'2019-03-08T12:52:53.700' AS DateTime), CAST(15 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), CAST(4187 AS Numeric(5, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(2 AS Numeric(18, 0)), N'don bosco', N' plaza italia', CAST(N'2019-03-05T15:24:09.000' AS DateTime), CAST(N'2019-03-05T18:03:52.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'test', CAST(12 AS Numeric(18, 0)), N'N', CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-05T15:24:52.000' AS DateTime), CAST(N'2019-03-08T12:59:12.207' AS DateTime), CAST(19 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), CAST(4174 AS Numeric(5, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(3 AS Numeric(18, 0)), N'D', N'C', CAST(N'2019-03-05T15:29:35.000' AS DateTime), CAST(N'2019-03-05T18:09:14.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'test', CAST(10 AS Numeric(18, 0)), N'N', CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-05T15:30:14.000' AS DateTime), CAST(N'2019-03-08T13:00:03.850' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), CAST(4170 AS Numeric(5, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(4 AS Numeric(18, 0)), N'C', N'F', CAST(N'2019-03-05T20:27:11.000' AS DateTime), CAST(N'2019-03-05T23:07:08.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'test', CAST(10 AS Numeric(18, 0)), N'N', CAST(20 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-05T20:28:08.000' AS DateTime), CAST(N'2019-03-08T12:58:29.213' AS DateTime), CAST(20 AS Numeric(18, 0)), CAST(2756.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), CAST(3870 AS Numeric(5, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(5 AS Numeric(18, 0)), N'Castañon 150', N'Av. Paseo Colon 635', CAST(N'2019-03-08T12:26:35.000' AS DateTime), CAST(N'2019-03-08T15:13:18.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'test', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-08T12:34:18.000' AS DateTime), CAST(N'2019-03-08T13:03:16.593' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), CAST(29 AS Numeric(5, 0)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(6 AS Numeric(18, 0)), N'un lugar', N'otro lugar', CAST(N'2019-03-11T13:35:37.000' AS DateTime), CAST(N'2019-03-11T16:16:14.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'prueba', CAST(10 AS Numeric(18, 0)), N'N', CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-11T13:37:14.000' AS DateTime), CAST(N'2019-03-11T13:37:28.343' AS DateTime), CAST(18 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-11T13:36:03.460' AS DateTime), N'28000002', CAST(N'2019-03-11T13:37:41.313' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(7 AS Numeric(18, 0)), N'Plaza constitucion', N'San Justo', CAST(N'2019-03-12T08:46:16.000' AS DateTime), CAST(N'2019-03-12T11:25:16.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'EL usuario informa mucha demora.', CAST(10 AS Numeric(18, 0)), N'S', CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(2383.94 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T08:46:42.240' AS DateTime), N'27000002', CAST(N'2019-03-12T08:47:14.497' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(8 AS Numeric(18, 0)), N'test', N'test', CAST(N'2019-03-12T09:23:45.000' AS DateTime), CAST(N'2019-03-12T12:02:45.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'tseset', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(1832.74 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T09:23:47.553' AS DateTime), N'27000002', CAST(N'2019-03-12T09:24:02.213' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(9 AS Numeric(18, 0)), N'otro', N'otro', CAST(N'2019-03-12T09:24:47.000' AS DateTime), CAST(N'2019-03-12T11:27:20.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1400.49 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-12T09:25:20.000' AS DateTime), CAST(N'2019-03-12T09:28:55.980' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(1400.49 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), CAST(4 AS Numeric(5, 0)), NULL, N'27000002', CAST(N'2019-03-12T09:24:48.827' AS DateTime), N'28000001', CAST(N'2019-03-12T09:29:37.033' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(10 AS Numeric(18, 0)), N'A', N'B', CAST(N'2019-03-12T09:35:42.000' AS DateTime), CAST(N'2019-03-12T12:18:02.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1832.74 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-12T09:39:02.000' AS DateTime), CAST(N'2019-03-12T09:39:07.763' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(1832.74 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T09:35:44.780' AS DateTime), N'28000001', CAST(N'2019-03-12T09:39:29.527' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(11 AS Numeric(18, 0)), N'D', N'C', CAST(N'2019-03-12T09:45:58.000' AS DateTime), CAST(N'2019-03-12T12:31:41.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(1832.74 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-12T09:52:41.000' AS DateTime), CAST(N'2019-03-12T09:52:56.677' AS DateTime), CAST(15 AS Numeric(18, 0)), CAST(1832.74 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T09:46:00.060' AS DateTime), N'28000005', CAST(N'2019-03-12T09:53:02.177' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(12 AS Numeric(18, 0)), N'H', N'K', CAST(N'2019-03-12T09:46:11.000' AS DateTime), CAST(N'2019-03-12T11:51:57.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1400.49 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-12T09:49:57.000' AS DateTime), CAST(N'2019-03-12T09:51:56.477' AS DateTime), CAST(18 AS Numeric(18, 0)), CAST(1400.49 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), CAST(2 AS Numeric(5, 0)), NULL, N'27000002', CAST(N'2019-03-12T09:46:16.717' AS DateTime), N'28000002', CAST(N'2019-03-12T09:52:09.603' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(13 AS Numeric(18, 0)), N'J', N'N', CAST(N'2019-03-12T02:45:50.000' AS DateTime), CAST(N'2019-03-13T17:08:59.000' AS DateTime), CAST(117 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2022.93 AS Numeric(8, 2)), CAST(117 AS Numeric(5, 0)), CAST(N'2019-03-13T14:12:59.000' AS DateTime), CAST(N'2019-03-13T14:13:04.390' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(2022.93 AS Numeric(8, 2)), CAST(176 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T09:47:40.017' AS DateTime), N'28000001', CAST(N'2019-03-13T14:13:10.877' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(14 AS Numeric(18, 0)), N'fg', N'g', CAST(N'2019-03-15T12:26:53.000' AS DateTime), CAST(N'2019-03-13T16:49:14.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(12 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-13T14:10:14.000' AS DateTime), CAST(N'2019-03-13T14:10:19.287' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(2383.94 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T12:29:04.700' AS DateTime), N'28000001', CAST(N'2019-03-13T14:10:25.833' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(15 AS Numeric(18, 0)), N'lala', N'lola', CAST(N'2019-03-20T12:26:53.000' AS DateTime), CAST(N'2019-03-13T15:54:11.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(12 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1821.69 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-13T13:52:11.000' AS DateTime), CAST(N'2019-03-13T13:52:27.523' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(1821.69 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-12T12:29:32.020' AS DateTime), N'28000001', CAST(N'2019-03-13T13:52:47.267' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(16 AS Numeric(18, 0)), N'san justo', N'ramos mejia', CAST(N'2019-03-13T14:15:39.000' AS DateTime), CAST(N'2019-03-13T16:55:30.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(704.90 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-13T14:16:30.000' AS DateTime), CAST(N'2019-03-13T14:16:34.387' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(704.90 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, NULL, N'27000002', CAST(N'2019-03-13T14:15:43.123' AS DateTime), N'28000001', CAST(N'2019-03-13T14:16:57.120' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(17 AS Numeric(18, 0)), N'a', N'b', CAST(N'2019-03-13T17:43:48.000' AS DateTime), CAST(N'2019-03-14T03:27:22.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(19 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(468.76 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-14T00:48:22.000' AS DateTime), CAST(N'2019-03-14T00:48:32.457' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(468.76 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-13T17:44:18.523' AS DateTime), N'28000001', CAST(N'2019-03-14T00:48:39.853' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(18 AS Numeric(18, 0)), N'Exception', N'test', CAST(N'2019-03-13T19:51:19.000' AS DateTime), CAST(N'2019-03-14T01:23:27.000' AS DateTime), CAST(10 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(16 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(100.00 AS Numeric(8, 2)), CAST(10 AS Numeric(5, 0)), CAST(N'2019-03-14T00:43:27.000' AS DateTime), CAST(N'2019-03-14T00:44:48.377' AS DateTime), CAST(15 AS Numeric(18, 0)), CAST(100.00 AS Numeric(8, 2)), CAST(40 AS Numeric(5, 0)), CAST(1 AS Numeric(5, 0)), CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-13T19:51:34.353' AS DateTime), N'28000005', CAST(N'2019-03-14T00:44:56.310' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(19 AS Numeric(18, 0)), N'nuevo', N'test', CAST(N'2019-03-14T10:49:39.000' AS DateTime), CAST(N'2019-03-14T02:52:51.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-14T00:50:51.000' AS DateTime), CAST(N'2019-03-14T00:50:59.583' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T00:50:26.130' AS DateTime), N'28000001', CAST(N'2019-03-14T00:52:22.753' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(20 AS Numeric(18, 0)), N'test', N'test', CAST(N'2019-03-14T08:54:59.000' AS DateTime), CAST(N'2019-03-14T02:58:29.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-14T00:56:29.000' AS DateTime), CAST(N'2019-03-14T00:56:36.667' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T00:55:24.013' AS DateTime), N'28000001', CAST(N'2019-03-14T00:56:42.197' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(21 AS Numeric(18, 0)), N'otro', N'mas', CAST(N'2019-03-14T08:54:59.000' AS DateTime), CAST(N'2019-03-14T03:08:52.000' AS DateTime), CAST(87 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(870.00 AS Numeric(8, 2)), CAST(87 AS Numeric(5, 0)), CAST(N'2019-03-14T00:58:52.000' AS DateTime), CAST(N'2019-03-14T00:58:58.477' AS DateTime), CAST(18 AS Numeric(18, 0)), CAST(870.00 AS Numeric(8, 2)), CAST(130 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T00:55:44.217' AS DateTime), N'28000002', CAST(N'2019-03-14T00:59:03.360' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(22 AS Numeric(18, 0)), N'a', N'b', CAST(N'2019-03-14T10:02:08.000' AS DateTime), CAST(N'2019-03-14T03:41:33.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-14T01:02:33.000' AS DateTime), CAST(N'2019-03-14T01:02:37.393' AS DateTime), CAST(18 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:02:20.847' AS DateTime), N'28000002', CAST(N'2019-03-14T01:02:42.623' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(23 AS Numeric(18, 0)), N'test', N'dos', CAST(N'2019-03-14T09:03:45.000' AS DateTime), CAST(N'2019-03-14T03:06:46.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-14T01:04:46.000' AS DateTime), CAST(N'2019-03-14T01:04:53.100' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(810.00 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:04:07.753' AS DateTime), N'28000001', CAST(N'2019-03-14T01:04:59.050' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(24 AS Numeric(18, 0)), N'test', N'dest', CAST(N'2019-03-14T11:07:15.000' AS DateTime), CAST(N'2019-03-14T03:45:52.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-14T01:06:52.000' AS DateTime), CAST(N'2019-03-14T01:07:02.107' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:07:30.447' AS DateTime), N'28000001', CAST(N'2019-03-14T01:07:07.970' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(25 AS Numeric(18, 0)), N'test', N'test', CAST(N'2019-03-14T10:10:58.000' AS DateTime), CAST(N'2019-03-14T03:50:35.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'', CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(106 AS Numeric(5, 0)), CAST(N'2019-03-14T01:11:35.000' AS DateTime), CAST(N'2019-03-14T01:11:38.520' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(1060.00 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:11:15.400' AS DateTime), N'28000001', CAST(N'2019-03-14T01:11:44.420' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(26 AS Numeric(18, 0)), N'test', N'mas lejos', CAST(N'2019-03-14T06:38:49.000' AS DateTime), CAST(N'2019-03-14T03:51:23.000' AS DateTime), CAST(87 AS Numeric(5, 0)), N'', CAST(26 AS Numeric(18, 0)), N'N', CAST(18 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(300.15 AS Numeric(8, 2)), CAST(87 AS Numeric(5, 0)), CAST(N'2019-03-14T01:41:23.000' AS DateTime), CAST(N'2019-03-14T01:41:34.797' AS DateTime), CAST(18 AS Numeric(18, 0)), CAST(300.15 AS Numeric(8, 2)), CAST(130 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:39:37.300' AS DateTime), N'28000002', CAST(N'2019-03-14T01:41:43.203' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(27 AS Numeric(18, 0)), N'test', N'lejos', CAST(N'2019-03-14T06:38:49.000' AS DateTime), CAST(N'2019-03-14T02:49:07.000' AS DateTime), CAST(44 AS Numeric(5, 0)), N'salio todo mal', CAST(26 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(270.00 AS Numeric(8, 2)), CAST(44 AS Numeric(5, 0)), CAST(N'2019-03-14T01:43:07.000' AS DateTime), CAST(N'2019-03-14T01:43:16.427' AS DateTime), CAST(20 AS Numeric(18, 0)), CAST(131.31 AS Numeric(8, 2)), CAST(66 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T01:42:18.893' AS DateTime), N'28000012', CAST(N'2019-03-14T01:43:56.737' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(28 AS Numeric(18, 0)), N'nuevo', N'test', CAST(N'2019-03-14T07:00:32.000' AS DateTime), CAST(N'2019-03-14T09:39:32.000' AS DateTime), CAST(106 AS Numeric(5, 0)), N'pruebas', CAST(10 AS Numeric(18, 0)), N'S', CAST(18 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(365.70 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T02:00:45.053' AS DateTime), N'27000002', CAST(N'2019-03-14T02:01:02.540' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(29 AS Numeric(18, 0)), N'test', N'otra prueba', CAST(N'2019-03-14T07:00:32.000' AS DateTime), CAST(N'2019-03-14T04:03:47.000' AS DateTime), CAST(81 AS Numeric(5, 0)), N'salio todo mal', CAST(26 AS Numeric(18, 0)), N'S', CAST(14 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(279.45 AS Numeric(8, 2)), CAST(81 AS Numeric(5, 0)), CAST(N'2019-03-14T02:01:47.000' AS DateTime), CAST(N'2019-03-14T02:01:50.860' AS DateTime), CAST(14 AS Numeric(18, 0)), CAST(279.45 AS Numeric(8, 2)), CAST(122 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T02:01:22.003' AS DateTime), N'28000001', CAST(N'2019-03-14T02:02:06.620' AS DateTime))
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(30 AS Numeric(18, 0)), N'est', N'test', CAST(N'2019-03-14T11:16:48.063' AS DateTime), CAST(N'2019-03-14T13:55:48.063' AS DateTime), CAST(106 AS Numeric(5, 0)), NULL, CAST(10 AS Numeric(18, 0)), N'N', CAST(14 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(365.70 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000002', CAST(N'2019-03-14T11:16:51.293' AS DateTime), NULL, NULL)
INSERT [dbo].[Viaje] ([id_viaje], [origen], [destino], [fecha_salida_estimada], [fecha_arribo_estimado], [km_estimados], [comentarios], [id_socio], [ida_vuelta], [id_chofer_estimado], [id_estado], [precio], [km_recorridos], [fecha_salida], [fecha_arribo], [id_chofer], [precio_estimado], [duracion_estimada], [duracion], [ahorro], [usuario_creacion], [fecha_creacion], [usuario_ult_mod], [fecha_ult_mod]) VALUES (CAST(31 AS Numeric(18, 0)), N'Origen', N'Destino', CAST(N'2019-03-15T13:09:49.130' AS DateTime), CAST(N'2019-03-15T15:48:49.130' AS DateTime), CAST(106 AS Numeric(5, 0)), NULL, CAST(13 AS Numeric(18, 0)), N'N', CAST(19 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, CAST(365.70 AS Numeric(8, 2)), CAST(159 AS Numeric(5, 0)), NULL, CAST(0.00 AS Numeric(8, 2)), N'27000001', CAST(N'2019-03-15T13:10:05.213' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Viaje] OFF
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(16 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(17 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(18 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Viaje_Beneficio] ([id_viaje], [id_beneficio]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
/****** Object:  Index [UQ_Nro_documento]    Script Date: 3/15/2019 2:20:55 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Nro_documento] ON [dbo].[Persona]
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Ux_Usuario]    Script Date: 3/15/2019 2:20:55 PM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [Ux_Usuario] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Autos_Unique_Patente]    Script Date: 3/15/2019 2:20:55 PM ******/
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
ALTER TABLE [dbo].[Chofer_Accion]  WITH CHECK ADD  CONSTRAINT [FK_Chofer_Accion_Accion] FOREIGN KEY([id_accion])
REFERENCES [dbo].[Accion] ([id_accion])
GO
ALTER TABLE [dbo].[Chofer_Accion] CHECK CONSTRAINT [FK_Chofer_Accion_Accion]
GO
ALTER TABLE [dbo].[Chofer_Accion]  WITH CHECK ADD  CONSTRAINT [FK_Chofer_Accion_Chofer] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Chofer] ([id_persona])
GO
ALTER TABLE [dbo].[Chofer_Accion] CHECK CONSTRAINT [FK_Chofer_Accion_Chofer]
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
ALTER TABLE [dbo].[Estado_Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Viaje_Tipo_Estado_Viaje] FOREIGN KEY([id_tipo_estado_viaje])
REFERENCES [dbo].[Tipo_Estado_Viaje] ([id_estado])
GO
ALTER TABLE [dbo].[Estado_Viaje] CHECK CONSTRAINT [FK_Estado_Viaje_Tipo_Estado_Viaje]
GO
ALTER TABLE [dbo].[Estado_Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Estado_Viaje_Viaje] FOREIGN KEY([id_viaje])
REFERENCES [dbo].[Viaje] ([id_viaje])
GO
ALTER TABLE [dbo].[Estado_Viaje] CHECK CONSTRAINT [FK_Estado_Viaje_Viaje]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [FK_Modelo_Marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca] ([id_marca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [FK_Modelo_Marca]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD  CONSTRAINT [FK_Registro_Chofer] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Chofer] ([id_persona])
GO
ALTER TABLE [dbo].[Registro] CHECK CONSTRAINT [FK_Registro_Chofer]
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
ALTER TABLE [dbo].[Ticket_Comprobante]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Comprobante_Viaje] FOREIGN KEY([id_viaje])
REFERENCES [dbo].[Viaje] ([id_viaje])
GO
ALTER TABLE [dbo].[Ticket_Comprobante] CHECK CONSTRAINT [FK_Ticket_Comprobante_Viaje]
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
/****** Object:  StoredProcedure [dbo].[ActualizarPassword]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarPassword] 
	@Usuario VARCHAR(50), 
	@Password VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Usuario
	   SET Password = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40),
	   primer_ingreso = 'N'
	 WHERE usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[BlanquearClave]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ConsultaChoferesParaViajes]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 24/02/2019
-- Description:	Consulta de choferes que estan disponible para realizar
-- un viaje en un momento específico
-- =============================================
CREATE PROCEDURE [dbo].[ConsultaChoferesParaViajes]
	@fechaHoraViaje DATETIME
AS
DECLARE @periodo_cant_dias Int = 0
BEGIN
    SELECT @periodo_cant_dias = valor  FROM [remisapp].[dbo].[Parametro] WHERE clave = 'PERIODO_PUNTAJE' AND estado = 'A'

	SELECT id_persona FROM (
	SELECT c.id_persona id_persona, ISNULL(SUM(a.puntaje),0) puntaje
	FROM dbo.Chofer c
	INNER JOIN dbo.Registro r ON c.id_persona = r.id_persona
	INNER JOIN dbo.Vehiculo v ON c.id_vehiculo = v.id_vehiculo
	LEFT JOIN dbo.Chofer_Accion ca ON ca.id_persona = c.id_persona
	LEFT JOIN dbo.Accion a on ca.id_accion = a.id_accion
	WHERE c.estado = 'A'
		 AND ca.fecha >= GETDATE() - @periodo_cant_dias
		 AND r.fecha_vencimiento >= CONVERT(DATE, getdate())
		 AND v.fecha_vencimiento_VTV >= CONVERT(DATE, getdate())
		AND EXISTS (
			SELECT 1
			FROM dbo.Chofer_Turno ct
			INNER JOIN dbo.Turno t ON ct.id_turno = t.id_turno
			WHERE id_persona = c.id_persona
				AND CONVERT(TIME, @fechaHoraViaje) BETWEEN
						CONVERT(TIME, CONCAT (t.horario_entrada,':00:00'))
					AND CONVERT(TIME, CONCAT (t.horario_salida,':59:59'))
			)
		AND NOT EXISTS (
			SELECT 1
			FROM dbo.Viaje
			WHERE id_estado IN (
					SELECT id_estado
					FROM dbo.Tipo_Estado_Viaje
					WHERE grupo = 'Alta'
					)
				AND @fechaHoraViaje BETWEEN isnull(fecha_salida, fecha_salida_estimada)
					AND isnull(fecha_arribo, fecha_arribo_estimado)
				AND isnull(id_chofer, id_chofer_estimado) = c.id_persona
			)
	GROUP BY c.id_persona
	) T
	ORDER BY puntaje DESC
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaPuntosChoferes]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 10/03/2019
-- Description:	Consulta detalle de puntos de los choferes
-- =============================================
CREATE PROCEDURE [dbo].[ConsultaPuntosChoferes] 
	@id_chofer Numeric(18,0) = NULL,
	@fecha_desde Date = NULL,
	@fecha_hasta Date = NULL,
	@activo	Varchar(1) = 'S',
	@vigente	Varchar(1) = 'S',
	@acciones	Varchar(Max) = NULL
AS
BEGIN

	IF @fecha_desde IS NULL 
	BEGIN
		SET @fecha_desde  = CAST('1/1/1900' as datetime)
	END	

	IF @fecha_hasta IS NULL 
	BEGIN
		SET @fecha_hasta  = GETDATE()
	END	

	SELECT c.id_persona,a.id_accion,ca.fecha --p.apellido +', '+p.nombre,p.nro_documento, a.descripcion ,ca.fecha, ISNULL(a.puntaje,0) puntaje
	FROM dbo.Chofer c
	INNER JOIN dbo.Persona p ON c.id_persona = p.id_persona
	INNER JOIN dbo.Registro r ON c.id_persona = r.id_persona
	INNER JOIN dbo.Vehiculo v ON c.id_vehiculo = v.id_vehiculo
	LEFT JOIN dbo.Chofer_Accion ca ON ca.id_persona = c.id_persona
	LEFT JOIN dbo.Accion a on ca.id_accion = a.id_accion
	WHERE (c.id_persona = @id_chofer OR @id_chofer IS NULL)
		AND ((@activo = 'S' AND  c.estado = 'A')
			OR @activo = 'N')
		AND (@vigente = 'S' 
			AND (r.fecha_vencimiento >= CONVERT(DATE, GETDATE())
				 AND v.fecha_vencimiento_VTV >= CONVERT(DATE, GETDATE()))
			OR @vigente = 'N'
			)
		AND ca.fecha BETWEEN @fecha_desde AND @fecha_hasta
		AND (@acciones IS NULL OR
		ca.id_accion IN (SELECT * FROM dbo.splitstring(@acciones,';')))
	ORDER BY c.id_persona, ca.fecha DESC
	
END
GO
/****** Object:  StoredProcedure [dbo].[CrearUsuarioAdministrador]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 04-03-2019
-- Description:	Procedimiento para crear el usuario administrador en caso que no exista ningun usuario.
-- =============================================
CREATE PROCEDURE [dbo].[CrearUsuarioAdministrador]
AS
DECLARE @usuario varchar(50),
	    @id_persona numeric(18,0)
BEGIN
  IF NOT EXISTS ( SELECT 1 FROM dbo.Usuario WHERE estado = 'A')
  BEGIN
    SET @usuario = (SELECT valor FROM dbo.Parametro WHERE clave = 'USER_ADMN' AND estado = 'A')
    INSERT INTO dbo.Persona (nombre,nro_documento)
	VALUES( 'USER_ADMN',@usuario)
	SET @id_persona = (SELECT IDENT_CURRENT ('dbo.Persona'));
	EXEC dbo.GuardarUsuario @id_persona = @id_persona, @usuario = @usuario, @password = @usuario;
	EXEC dbo.GuardarPermisosUsuario @usuario = @usuario, @permisos = 'A'
  END;
END
GO
/****** Object:  StoredProcedure [dbo].[GetBeneficiosSocio]    Script Date: 3/15/2019 2:20:55 PM ******/
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
          @sum_precio numeric(8,2),
		  @periodo_cant_dias Int = 0
BEGIN
    SELECT @periodo_cant_dias = valor  FROM [remisapp].[dbo].[Parametro] WHERE clave = 'PERIODO_BENEFICIOS' AND estado = 'A'

	SELECT @cant_viajes = COUNT(1), @sum_precio = SUM(precio) 
	  FROM dbo.Viaje v
	 WHERE v.id_socio = @id_socio
	   AND v.fecha_creacion >= GETDATE()-@periodo_cant_dias
	   AND v.id_estado = 5
	   AND NOT EXISTS(SELECT 1 FROM dbo.Viaje v2 
					   WHERE v.id_socio = v2.id_socio
					     AND fecha_creacion >= GETDATE()-@periodo_cant_dias
					     AND v2.id_estado = 4);-- Que no tenga viajes cancelaados en los ult @periodo_cant_dias dias 

	SELECT id_beneficio 
	  FROM dbo.Beneficio
	 WHERE vigencia_desde < GETDATE()
	   AND (vigencia_hasta > GETDATE() OR vigencia_hasta is null)
	   AND @cant_viajes >= cantidad_viajes 
	   AND @sum_precio >= total_acumulado
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarAccion]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/7/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarAccion]
	 @id_accion numeric(18,0),
	 @descripcion varchar(50),
	 @puntaje numeric(5,2),
	 @vigencia_desde date,
	 @vigencia_hasta date = NULL,
	 @usuario_operacion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Accion WHERE id_accion = @id_accion)
	BEGIN
		INSERT INTO dbo.Accion(puntaje,descripcion,vigencia_desde,vigencia_hasta,estado,usuario_creacion,fecha_creacion)
		VALUES(@puntaje,@descripcion,@vigencia_desde,@vigencia_hasta,'A',@usuario_operacion,GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Accion
		 SET puntaje = @puntaje,
			 descripcion = @descripcion,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta,
			 usuario_ult_mod = @usuario_operacion,
			 fecha_ult_mod = GETDATE()
		 WHERE id_accion = @id_accion
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarBeneficio]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	 @totalAcumulado numeric(8,2),
	 @usuario_operacion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Beneficio WHERE id_beneficio = @id_beneficio)
	BEGIN
		INSERT INTO dbo.Beneficio(descuento,vigencia_desde,vigencia_hasta,descripcion,estado,total_acumulado,cantidad_viajes,usuario_creacion,fecha_creacion)
		VALUES(@descuento,@vigencia_desde,@vigencia_hasta,@descripcion,'A',@totalAcumulado,@cantidadViajes,@usuario_operacion,GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Beneficio
		 SET descuento = @descuento,
			 descripcion = @descripcion,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta,
			 total_acumulado = @totalAcumulado,
			 cantidad_viajes = @cantidadViajes,
			 usuario_creacion = @usuario_operacion,
			 fecha_creacion = GETDATE()
		 WHERE id_beneficio = @id_beneficio
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarChofer]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	@turnos varchar(MAX),
	@usuario_operacion varchar(50)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.Chofer WHERE id_persona = @id_persona )
	BEGIN
		INSERT INTO dbo.Chofer (id_persona,id_comision,id_vehiculo,estado,usuario_creacion,fecha_creacion)
		VALUES(@id_persona,@id_comision,@id_vehiculo,'A',@usuario_operacion,GETDATE());

		INSERT INTO dbo.Registro(id_persona,fecha_vencimiento,categoria,estado ,usuario_creacion,fecha_creacion)
		VALUES(@id_persona,@fecha_vencimiento_registro,@categoria_registro,'A',@usuario_operacion,GETDATE());

		INSERT INTO dbo.Chofer_Turno (id_persona,id_turno ,estado ,usuario_creacion,fecha_creacion)
		SELECT @id_persona,*,'A',@usuario_operacion,GETDATE() FROM dbo.splitstring(@turnos,';');

	END
	ELSE
	BEGIN
		UPDATE dbo.Chofer
		SET id_comision = @id_comision,
		id_vehiculo = @id_vehiculo,
			fecha_ult_mod = GETDATE(),
			usuario_ult_mod = @usuario_operacion
		WHERE id_persona = @id_persona
			  AND estado = 'A';

		IF NOT EXISTS (SELECT 1 FROM dbo.Registro WHERE id_persona = @id_persona )
		BEGIN
			INSERT INTO dbo.Registro(id_persona,fecha_vencimiento,categoria,estado ,usuario_creacion,fecha_creacion)
			VALUES(@id_persona,@fecha_vencimiento_registro,@categoria_registro,'A',@usuario_operacion,GETDATE());
		END
		ELSE			
		BEGIN
			UPDATE dbo.Registro 
			  SET fecha_vencimiento = @fecha_vencimiento_registro,
			  categoria = @categoria_registro,
			  fecha_ult_mod = GETDATE(),
			  usuario_ult_mod = @usuario_operacion
			WHERE id_persona = @id_persona
			  AND estado = 'A';

		END;

		UPDATE dbo.Chofer_Turno 
		  SET estado = 'I',
		  fecha_ult_mod = GETDATE(),
		  usuario_ult_mod = @usuario_operacion
		WHERE id_persona = @id_persona
		  AND estado = 'A';

		INSERT INTO dbo.Chofer_Turno (id_persona,id_turno ,estado , usuario_creacion,fecha_creacion)
		SELECT @id_persona,*,'A',@usuario_operacion,GETDATE() FROM dbo.splitstring(@turnos,';');

	END;
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarChoferAccion]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/7/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarChoferAccion]
	 @id_accion numeric(18,0),
	 @id_chofer numeric(18,0)
AS
BEGIN
	INSERT dbo.Chofer_Accion
	VALUES (@id_chofer,@id_accion,GETDATE());
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarComision]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	 @vigencia_hasta date = NULL,
	 @usuario_operacion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Comision WHERE id_comision = @id_comision)
	BEGIN
		INSERT INTO dbo.Comision(porcentaje,descripcion,vigencia_desde,vigencia_hasta,estado,usuario_creacion,fecha_creacion)
		VALUES(@porcentaje,@descripcion,@vigencia_desde,@vigencia_hasta,'A',@usuario_operacion,GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Comision
		 SET porcentaje = @porcentaje,
			 descripcion = @descripcion,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta,
			 usuario_ult_mod = @usuario_operacion,
			 fecha_ult_mod = GETDATE()
		 WHERE id_comision = @id_comision
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarParametro]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/7/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarParametro]
	 @id_parametro numeric(18,0),
	 @clave varchar(50),
	 @valor varchar(50),
	 @vigencia_desde date,
	 @vigencia_hasta date = NULL,
	 @usuario_operacion varchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Parametro WHERE id_parametro = @id_parametro)
	BEGIN
		INSERT INTO dbo.Parametro(clave,valor,vigencia_desde,vigencia_hasta,estado,usuario_creacion,fecha_creacion)
		VALUES(@clave,@valor,@vigencia_desde,@vigencia_hasta,'A',@usuario_operacion,GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Parametro
		 SET clave = @clave,
			 valor = @valor,
			 vigencia_desde = @vigencia_desde,
			 vigencia_hasta = @vigencia_hasta,
			 usuario_ult_mod = @usuario_operacion,
			 fecha_ult_mod = GETDATE()
		 WHERE id_parametro = @id_parametro
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarPermisosUsuario]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GuardarPersona]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	@usuario_operacion varchar(50),
	@id_persona numeric(18,0) output
AS
BEGIN
	IF @id_persona IS NULL 
	BEGIN
		INSERT INTO dbo.Persona(nombre,apellido,email,estado,nro_documento,fecha_nacimiento,usuario_creacion,fecha_creacion)
		OUTPUT INSERTED.id_persona
		VALUES( @nombre,
				@apellido,
				@email,
				'A',
				@nro_documento,
				@fecha_nacimiento,
				@usuario_operacion,
				GETDATE());
		SET @id_persona = (SELECT IDENT_CURRENT ('dbo.Persona'));

		INSERT INTO dbo.Domicilio(id_persona,calle,numero,cp,dpto,piso,localidad,provincia,usuario_creacion,fecha_creacion)
		VALUES (@id_persona, @calle, @numero, @cp, @dpto, @piso, @localidad, @provincia,@usuario_operacion,GETDATE());
		INSERT INTO dbo.Telefono(id_persona,id_tipo_telefono,cod_pais,cod_area,numero,usuario_creacion,fecha_creacion)
		VALUES (@id_persona, @id_tipo_telefono,@cod_pais,@cod_area,@nro_telefono,@usuario_operacion,GETDATE());
	END
	ELSE
	BEGIN
	 UPDATE dbo.Persona
	 SET nombre = @nombre,
		 apellido =	@apellido,
		 email	=	@email,
		 fecha_nacimiento = @fecha_nacimiento,
		 nro_documento = @nro_documento,
		usuario_ult_mod = @usuario_operacion,
		fecha_ult_mod	=GETDATE()
	 WHERE id_persona = @id_persona;

	 IF NOT EXISTS (SELECT 1 FROM dbo.Domicilio WHERE id_persona = @id_persona)
	 BEGIN
		 INSERT INTO dbo.Domicilio(id_persona,calle,numero,cp,dpto,piso,localidad,provincia,usuario_creacion,fecha_creacion)
			VALUES (@id_persona, @calle, @numero, @cp, @dpto, @piso, @localidad, @provincia,@usuario_operacion,GETDATE());
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
			  provincia =  @provincia,
			  usuario_ult_mod = @usuario_operacion,
		      fecha_ult_mod	=  GETDATE()
		  WHERE id_persona = @id_persona;
	 END;

	 IF NOT EXISTS (SELECT 1 FROM dbo.Telefono WHERE id_persona = @id_persona)
	 BEGIN
		 INSERT INTO dbo.Telefono(id_persona,id_tipo_telefono,cod_pais,cod_area,numero,usuario_creacion,fecha_creacion)
		VALUES (@id_persona, @id_tipo_telefono,@cod_pais,@cod_area,@nro_telefono,@usuario_operacion,GETDATE());
	 END
	 ELSE
	 BEGIN
		 UPDATE dbo.Telefono
		  SET id_tipo_telefono = @id_tipo_telefono,
		  cod_pais = @cod_pais,
		  cod_area = @cod_area,
		  numero = @nro_telefono,
		  usuario_ult_mod = @usuario_operacion,
		  fecha_ult_mod	= GETDATE()
		  WHERE id_persona = @id_persona;
	 END;
	END; 
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarSocio]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 16/06/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarSocio]
    @id_persona numeric(18,0) = NULL,
	@usuario_operacion varchar(50)
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM dbo.Socio WHERE id_persona = @id_persona )
	BEGIN
	 INSERT INTO dbo.Socio(id_persona,nro_socio,fecha_asociacion,estado,usuario_creacion,fecha_creacion)
	 VALUES(@id_persona,@id_persona,GETDATE(),'A',@usuario_operacion,GETDATE());
	END
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarTicketComprobante]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GuardarTicketComprobante] 
	@id_viaje NUMERIC(18,0),
	@fecha_emision DATETIME,
	@id_ticket_comprobante NUMERIC(18,0) OUT
AS
BEGIN

	INSERT INTO dbo.Ticket_Comprobante
	VALUES(@id_viaje,@fecha_emision);

	SET @id_ticket_comprobante = (SELECT IDENT_CURRENT ('dbo.Ticket_Comprobante'));

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarTurno]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/7/2018
-- =============================================
CREATE PROCEDURE [dbo].[GuardarTurno]
	 @id_turno numeric(18,0),
	 @descripcion varchar(50),
	 @horario_entrada int,
	 @horario_salida int,
	 @usuario_operacion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;
	IF NOT EXISTS (SELECT 1 FROM dbo.Comision WHERE id_comision = @id_turno)
	BEGIN
		INSERT INTO dbo.Turno(descripcion, horario_entrada,horario_salida,estado,usuario_creacion,fecha_creacion)
		VALUES(@descripcion,@horario_entrada,@horario_salida,'A',@usuario_operacion,GETDATE())
	END
	ELSE
	BEGIN
		UPDATE dbo.Turno
		 SET descripcion = @descripcion,
			 horario_entrada = @horario_entrada,
			 horario_salida = @horario_salida,
			 usuario_ult_mod = @usuario_operacion,
			 fecha_ult_mod = GETDATE()
		 WHERE id_turno = @id_turno
	END

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	@password varchar(50),
	@usuario_operacion varchar(50)
AS
DECLARE @ErrorMsg varchar(256)
BEGIN
	BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE id_persona = @id_persona )
		BEGIN
			INSERT INTO dbo.Usuario(usuario,password,id_persona,estado,primer_ingreso,ultimo_ingreso,usuario_creacion,fecha_creacion)
			VALUES( @usuario,
					SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40),
					@id_persona,
					'A',
					'S',
					NULL,
					@usuario_operacion,
					GETDATE());
		END
	 END TRY
	 BEGIN CATCH
	  SET @ErrorMsg = ('Error al guardar usuario (' + @usuario + '). Error SQL: '+ ERROR_MESSAGE());
	   THROW 50001,@ErrorMsg , 1;
	 END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarVehiculo]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	@Fecha_Vencimiento_VTV date,
	@usuario_operacion varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION
	IF NOT EXISTS (SELECT 1 FROM dbo.Vehiculo WHERE id_vehiculo = @id_vehiculo )
	BEGIN
		INSERT INTO dbo.Vehiculo(id_modelo,anio_Fabricacion ,patente ,motor ,chasis ,estado ,fecha_vencimiento_VTV ,usuario_creacion ,fecha_creacion )
		VALUES(@id_Modelo,@anio_Fabricacion,@patente,@motor,@chasis,'A',@Fecha_Vencimiento_VTV, @usuario_operacion,GETDATE());
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
		fecha_vencimiento_VTV = @Fecha_Vencimiento_VTV,
		usuario_ult_mod = @usuario_operacion,
		fecha_ult_mod = GETDATE()
		WHERE id_vehiculo = @id_vehiculo
	END
	COMMIT
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarViaje]    Script Date: 3/15/2019 2:20:55 PM ******/
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
		@ahorro numeric(8,2) = 0,
		@beneficios  varchar(MAX) = NULL,
		@usuario_operacion varchar(50)
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
		,duracion
		,ahorro
		,usuario_creacion
		,fecha_creacion)
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
		,@duracion
		,@ahorro
		,@usuario_operacion
		,GETDATE());
		SET @id_viaje = (SELECT IDENT_CURRENT ('dbo.Viaje'));
		
		INSERT INTO dbo.Estado_Viaje(id_viaje,id_tipo_estado_viaje,estado,usuario_creacion,fecha_creacion)
		SELECT id_viaje, id_estado, 'A',@usuario_operacion, GETDATE()
		  FROM dbo.Viaje
		  WHERE id_viaje = @id_viaje
				
	END
	ELSE 
	BEGIN
		UPDATE dbo.Estado_Viaje
		   SET usuario_ult_mod = @usuario_operacion,
		       fecha_ult_mod = GETDATE(),
			   estado = 'I'
		 WHERE id_viaje = @id_viaje
		  AND estado = 'A'

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
		,ahorro = @ahorro
		,usuario_ult_mod = @usuario_operacion
		,fecha_ult_mod = GETDATE()
		WHERE id_viaje = @id_viaje

		INSERT INTO dbo.Estado_Viaje(id_viaje,id_tipo_estado_viaje,estado,usuario_creacion,fecha_creacion)
		SELECT id_viaje, id_estado, 'A',@usuario_operacion, GETDATE()
		  FROM dbo.Viaje
		 WHERE id_viaje = @id_viaje
	END

	IF @beneficios IS NOT NULL
	BEGIN
		EXEC GuardarViajeBeneficio @id_viaje,@beneficios;
	END;

END
GO
/****** Object:  StoredProcedure [dbo].[GuardarViajeBeneficio]    Script Date: 3/15/2019 2:20:55 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 3/15/2019 2:20:55 PM ******/
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
	@Respuesta INT OUT,
	@PrimerIngreso VARCHAR(1) OUT
AS
BEGIN
	SELECT @Respuesta = 1, @PrimerIngreso = primer_ingreso
	 FROM dbo.Usuario
	WHERE usuario = @Usuario
	AND Password = SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', @Password)), 3, 40)

	IF @Respuesta IS NULL
	BEGIN
	 SET @Respuesta = 0
	END;

	UPDATE dbo.Usuario
	   SET ultimo_ingreso = GETDATE()
	 WHERE usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarAccion]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarAccion]
	 @id_accion numeric(18,0),
	 @usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Accion
		 SET estado = 'I',
		 usuario_ult_mod = @usuario_operacion,
		 fecha_ult_mod = GETDATE()
		 WHERE id_accion = @id_accion
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarBeneficio]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarBeneficio]
	 @id_beneficio numeric(18,0),
	 @usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Beneficio
		 SET estado = 'I',
		 usuario_ult_mod = @usuario_operacion,
		 fecha_ult_mod = GETDATE()
		 WHERE id_beneficio = @id_beneficio
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarChofer]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 18/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarChofer]
	@id_persona numeric(18,0),
	@usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Chofer
	SET estado = 'I',
	usuario_ult_mod = @usuario_operacion,
	fecha_ult_mod = GETDATE()
	WHERE id_persona = @id_persona
	  AND estado = 'A';

	UPDATE dbo.Chofer_Turno
	SET estado = 'I',
	usuario_ult_mod = @usuario_operacion,
	fecha_ult_mod = GETDATE()
	WHERE id_persona = @id_persona
	  AND estado = 'A';

	UPDATE dbo.Registro
	SET estado = 'I',
	usuario_ult_mod = @usuario_operacion,
	fecha_ult_mod = GETDATE()
	WHERE id_persona = @id_persona
	  AND estado = 'A';

END
GO
/****** Object:  StoredProcedure [dbo].[QuitarComision]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarComision]
	 @id_comision numeric(18,0),
	 @usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Comision
		 SET estado = 'I',
		 usuario_ult_mod = @usuario_operacion,
		 fecha_ult_mod = GETDATE()
		 WHERE id_comision = @id_comision
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarParametro]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarParametro]
	 @id_parametro numeric(18,0),
	 @usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Parametro
		 SET estado = 'I',
		 usuario_ult_mod = @usuario_operacion,
		 fecha_ult_mod = GETDATE()
		 WHERE id_parametro = @id_parametro
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarSocio]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 18/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarSocio]
	@id_persona numeric(18,0),
	@usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Socio
	SET estado = 'I',
	usuario_ult_mod = @usuario_operacion,
	fecha_ult_mod = GETDATE()
	WHERE id_persona = @id_persona;
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarTurno]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 28/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarTurno]
	 @id_turno numeric(18,0),
	 @usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Turno
		 SET estado = 'I',
		 usuario_ult_mod = @usuario_operacion,
		 fecha_ult_mod = GETDATE()
		 WHERE id_turno = @id_turno
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarUsuario]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 20/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarUsuario]
	@usuario varchar(50),
	@usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Usuario
	SET estado = 'I',
	usuario_ult_mod = @usuario_operacion,
	fecha_ult_mod = GETDATE()
	WHERE usuario = @usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarVehiculo]    Script Date: 3/15/2019 2:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sergio Areco
-- Create date: 19/07/2018
-- =============================================
CREATE PROCEDURE [dbo].[QuitarVehiculo]
	@id_vehiculo numeric(18,0),
	@usuario_operacion varchar(50)
AS
BEGIN
	UPDATE dbo.Vehiculo
	SET estado = 'I',
		usuario_ult_mod = @usuario_operacion,
		fecha_ult_mod = GETDATE()
	WHERE id_vehiculo = @id_vehiculo;
END
GO
USE [master]
GO
ALTER DATABASE [remisapp] SET  READ_WRITE 
GO
