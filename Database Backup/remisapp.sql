USE [remisapp]
GO
/****** Object:  StoredProcedure [dbo].[QuitarVehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarVehiculo]
GO
/****** Object:  StoredProcedure [dbo].[QuitarUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[QuitarTurno]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarTurno]
GO
/****** Object:  StoredProcedure [dbo].[QuitarSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarSocio]
GO
/****** Object:  StoredProcedure [dbo].[QuitarParametro]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarParametro]
GO
/****** Object:  StoredProcedure [dbo].[QuitarComision]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarComision]
GO
/****** Object:  StoredProcedure [dbo].[QuitarChofer]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarChofer]
GO
/****** Object:  StoredProcedure [dbo].[QuitarBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[QuitarAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[QuitarAccion]
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[Login]
GO
/****** Object:  StoredProcedure [dbo].[GuardarViajeBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarViajeBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarViaje]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarViaje]
GO
/****** Object:  StoredProcedure [dbo].[GuardarVehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarVehiculo]
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[GuardarTurno]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarTurno]
GO
/****** Object:  StoredProcedure [dbo].[GuardarTicketComprobante]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarTicketComprobante]
GO
/****** Object:  StoredProcedure [dbo].[GuardarSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarSocio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarPersona]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarPersona]
GO
/****** Object:  StoredProcedure [dbo].[GuardarPermisosUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarPermisosUsuario]
GO
/****** Object:  StoredProcedure [dbo].[GuardarParametro]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarParametro]
GO
/****** Object:  StoredProcedure [dbo].[GuardarComision]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarComision]
GO
/****** Object:  StoredProcedure [dbo].[GuardarChoferAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarChoferAccion]
GO
/****** Object:  StoredProcedure [dbo].[GuardarChofer]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarChofer]
GO
/****** Object:  StoredProcedure [dbo].[GuardarBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarBeneficio]
GO
/****** Object:  StoredProcedure [dbo].[GuardarAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GuardarAccion]
GO
/****** Object:  StoredProcedure [dbo].[GetBeneficiosSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[GetBeneficiosSocio]
GO
/****** Object:  StoredProcedure [dbo].[CrearUsuarioAdministrador]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[CrearUsuarioAdministrador]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaPuntosChoferes]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[ConsultaPuntosChoferes]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaChoferesParaViajes]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[ConsultaChoferesParaViajes]
GO
/****** Object:  StoredProcedure [dbo].[BlanquearClave]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP PROCEDURE [dbo].[BlanquearClave]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPassword]    Script Date: 3/15/2019 2:23:40 AM ******/
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
/****** Object:  Index [UQ_Nro_documento]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP INDEX [UQ_Nro_documento] ON [dbo].[Persona]
GO
/****** Object:  Table [dbo].[Viaje_Beneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Viaje_Beneficio]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Viaje]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Vehiculo]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Usuario_Permiso]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Turno]
GO
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Tipo_telefono]
GO
/****** Object:  Table [dbo].[Tipo_Estado_Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Tipo_Estado_Viaje]
GO
/****** Object:  Table [dbo].[Ticket_Comprobante]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Ticket_Comprobante]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Telefono]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Socio]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Registro]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Persona]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Permiso]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Parametro]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Modelo]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Marca]
GO
/****** Object:  Table [dbo].[Estado_Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Estado_Viaje]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Domicilio]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Comision]
GO
/****** Object:  Table [dbo].[Chofer_Turno]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Chofer_Turno]
GO
/****** Object:  Table [dbo].[Chofer_Accion]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Chofer_Accion]
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Chofer]
GO
/****** Object:  Table [dbo].[Beneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Beneficio]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP TABLE [dbo].[Accion]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP FUNCTION [dbo].[splitstring]
GO
USE [master]
GO
/****** Object:  Database [remisapp]    Script Date: 3/15/2019 2:23:40 AM ******/
DROP DATABASE [remisapp]
GO
/****** Object:  Database [remisapp]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON DATABASE::[remisapp] TO [Sergio-PC\Sergio]
GO
USE [remisapp]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[splitstring] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Accion] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Beneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Beneficio] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Chofer]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Chofer] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Chofer_Accion]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Chofer_Accion] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Chofer_Turno]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Chofer_Turno] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Comision] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Domicilio] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Estado_Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Estado_Viaje] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Marca] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Modelo] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Parametro] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Permiso] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Persona] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Registro] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Socio] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Telefono] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Ticket_Comprobante]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Ticket_Comprobante] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Tipo_Estado_Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Tipo_Estado_Viaje] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Tipo_telefono]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Tipo_telefono] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Turno] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/15/2019 2:23:40 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Ux_Usuario] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Usuario] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Usuario_Permiso] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Autos_Unique_Patente] UNIQUE NONCLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Vehiculo] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Viaje] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Viaje_Beneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Viaje_Beneficio] TO  SCHEMA OWNER 
GO
/****** Object:  Index [UQ_Nro_documento]    Script Date: 3/15/2019 2:23:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Nro_documento] ON [dbo].[Persona]
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[ActualizarPassword]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[ActualizarPassword] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[BlanquearClave]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[BlanquearClave] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[ConsultaChoferesParaViajes]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[ConsultaChoferesParaViajes] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[ConsultaPuntosChoferes]    Script Date: 3/15/2019 2:23:40 AM ******/
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

	SELECT c.id_persona,a.id_accion --p.apellido +', '+p.nombre,p.nro_documento, a.descripcion ,ca.fecha, ISNULL(a.puntaje,0) puntaje
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
	ORDER BY c.id_persona, ca.fecha DESC
	
END
GO
ALTER AUTHORIZATION ON [dbo].[ConsultaPuntosChoferes] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[CrearUsuarioAdministrador]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[CrearUsuarioAdministrador] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GetBeneficiosSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GetBeneficiosSocio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarAccion] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarBeneficio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarChofer]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarChofer] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarChoferAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarChoferAccion] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarComision]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarComision] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarParametro]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarParametro] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarPermisosUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarPermisosUsuario] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarPersona]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarPersona] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarSocio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarTicketComprobante]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarTicketComprobante] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarTurno]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarTurno] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarUsuario] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarVehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarVehiculo] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarViaje]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarViaje] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[GuardarViajeBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[GuardarViajeBeneficio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[Login] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarAccion]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarAccion] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarBeneficio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarBeneficio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarChofer]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarChofer] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarComision]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarComision] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarParametro]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarParametro] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarSocio]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarSocio] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarTurno]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarTurno] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarUsuario]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarUsuario] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[QuitarVehiculo]    Script Date: 3/15/2019 2:23:40 AM ******/
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
ALTER AUTHORIZATION ON [dbo].[QuitarVehiculo] TO  SCHEMA OWNER 
GO
USE [master]
GO
ALTER DATABASE [remisapp] SET  READ_WRITE 
GO
