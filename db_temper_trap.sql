USE [master]
GO
/****** Object:  Database [db_temper_trap]    Script Date: 9/24/2024 10:44:13 PM ******/
CREATE DATABASE [db_temper_trap]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_temper_trap', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_temper_trap.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_temper_trap_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_temper_trap_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_temper_trap] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_temper_trap].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_temper_trap] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_temper_trap] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_temper_trap] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_temper_trap] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_temper_trap] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_temper_trap] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_temper_trap] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_temper_trap] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_temper_trap] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_temper_trap] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_temper_trap] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_temper_trap] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_temper_trap] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_temper_trap] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_temper_trap] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_temper_trap] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_temper_trap] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_temper_trap] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_temper_trap] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_temper_trap] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_temper_trap] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_temper_trap] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_temper_trap] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_temper_trap] SET  MULTI_USER 
GO
ALTER DATABASE [db_temper_trap] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_temper_trap] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_temper_trap] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_temper_trap] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_temper_trap] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_temper_trap] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_temper_trap] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_temper_trap] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_temper_trap]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Correo] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](255) NULL,
	[Telefono] [nvarchar](15) NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPedidos]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPedidos](
	[DetallePedidoId] [int] IDENTITY(1,1) NOT NULL,
	[PedidoId] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DetallePedidoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Puesto] [nvarchar](50) NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[FormaPagoId] [int] IDENTITY(1,1) NOT NULL,
	[Metodo] [nvarchar](50) NOT NULL,
	[PedidoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FormaPagoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[NombrePlato] [nvarchar](100) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 9/24/2024 10:44:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[PedidoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[EmpleadoId] [int] NULL,
	[FechaPedido] [datetime] NOT NULL,
	[Estado] [nvarchar](50) NOT NULL,
	[Comentario] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[PedidoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ClienteId], [Nombre], [Correo], [Direccion], [Telefono], [Password], [Usuario]) VALUES (1, N'Carlos Navas', N'carlos.navas@email.com', N'Av. Libertad 123, San Salvador', N'78965412', N'1234', N'carlosnavas')
INSERT [dbo].[Clientes] ([ClienteId], [Nombre], [Correo], [Direccion], [Telefono], [Password], [Usuario]) VALUES (2, N'Johana Campos', N'johana.campos@email.com', N'Av. Soyapango 123, San Salvador', N'78965412', N'johanacampos123', N'johanacampos')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesPedidos] ON 

INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (1, 1, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (2, 2, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (3, 3, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (4, 4, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (5, 5, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (6, 6, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (7, 7, 1, 1, CAST(8.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (8, 8, 2, 2, CAST(7.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (9, 9, 5, 1, CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (10, 10, 6, 1, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (11, 11, 6, 1, CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (12, 11, 5, 1, CAST(7.50 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (13, 11, 4, 1, CAST(9.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (14, 12, 3, 1, CAST(6.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (15, 13, 2, 1, CAST(7.00 AS Decimal(10, 2)))
INSERT [dbo].[DetallesPedidos] ([DetallePedidoId], [PedidoId], [MenuId], [Cantidad], [Precio]) VALUES (16, 14, 1, 1, CAST(8.50 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[DetallesPedidos] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([EmpleadoId], [Nombre], [Puesto], [Password], [Usuario]) VALUES (1, N'Ezequiel Campos', N'Mesero', N'ezequiel1234', N'ezequielcampos')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[FormasPago] ON 

INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (1, N'Efectivo', 1)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (2, N'Tarjeta', 2)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (3, N'Efectivo', 3)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (4, N'Efectivo', 4)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (5, N'Tarjeta', 5)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (6, N'Efectivo', 6)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (7, N'Efectivo', 7)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (8, N'Tarjeta', 8)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (9, N'Efectivo', 9)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (10, N'Efectivo', 10)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (11, N'Efectivo', 11)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (12, N'Tarjeta', 12)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (13, N'Efectivo', 13)
INSERT [dbo].[FormasPago] ([FormaPagoId], [Metodo], [PedidoId]) VALUES (14, N'Tarjeta', 14)
SET IDENTITY_INSERT [dbo].[FormasPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (1, N'Pizza Margarita', CAST(8.50 AS Decimal(10, 2)), N'Pizza clásica con tomate, mozzarella y albahaca')
INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (2, N'Hamburguesa Clásica', CAST(7.00 AS Decimal(10, 2)), N'Hamburguesa de carne con lechuga, tomate, cebolla y queso cheddar')
INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (3, N'Ensalada César', CAST(6.00 AS Decimal(10, 2)), N'Ensalada con lechuga, crutones, queso parmesano y aderezo César')
INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (4, N'Pasta Carbonara', CAST(9.00 AS Decimal(10, 2)), N'Pasta con salsa cremosa de huevo, panceta y queso parmesano')
INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (5, N'Tacos al Pastor', CAST(7.50 AS Decimal(10, 2)), N'Tacos de cerdo adobado con piña, cebolla y cilantro')
INSERT [dbo].[Menus] ([MenuId], [NombrePlato], [Precio], [Descripcion]) VALUES (6, N'Sopa de Mariscos', CAST(10.00 AS Decimal(10, 2)), N'Sopa caliente con una variedad de mariscos y verduras frescas')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedidos] ON 

INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (1, 1, NULL, CAST(N'2024-09-23T16:20:23.510' AS DateTime), N'Aceptado', N'Problemas con tráficooo')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (2, 1, NULL, CAST(N'2024-09-23T16:53:31.520' AS DateTime), N'En proceso de elaborar', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (3, 1, NULL, CAST(N'2024-09-23T16:56:23.407' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (4, 1, NULL, CAST(N'2024-09-23T17:15:11.763' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (5, 1, NULL, CAST(N'2024-09-23T17:21:49.737' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (6, 1, NULL, CAST(N'2024-09-23T17:40:01.407' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (7, 1, NULL, CAST(N'2024-09-23T17:46:13.320' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (8, 1, NULL, CAST(N'2024-09-23T18:04:29.203' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (9, 1, NULL, CAST(N'2024-09-23T19:13:51.130' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (10, 1, NULL, CAST(N'2024-09-24T20:32:51.887' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (11, 1, NULL, CAST(N'2024-09-24T21:18:05.267' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (12, 1, NULL, CAST(N'2024-09-24T21:27:57.850' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (13, 1, NULL, CAST(N'2024-09-24T21:31:06.440' AS DateTime), N'En proceso de elaborar', N'ya estamos en ello')
INSERT [dbo].[Pedidos] ([PedidoId], [ClienteId], [EmpleadoId], [FechaPedido], [Estado], [Comentario]) VALUES (14, 1, NULL, CAST(N'2024-09-24T22:08:59.170' AS DateTime), N'Aceptado', N'Pedido realizado con éxito')
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clientes__60695A197DF083DB]    Script Date: 9/24/2024 10:44:14 PM ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clientes__E3237CF7803FE319]    Script Date: 9/24/2024 10:44:14 PM ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__E3237CF7491F6303]    Script Date: 9/24/2024 10:44:14 PM ******/
ALTER TABLE [dbo].[Empleados] ADD UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (getdate()) FOR [FechaPedido]
GO
ALTER TABLE [dbo].[DetallesPedidos]  WITH CHECK ADD FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO
ALTER TABLE [dbo].[DetallesPedidos]  WITH CHECK ADD FOREIGN KEY([PedidoId])
REFERENCES [dbo].[Pedidos] ([PedidoId])
GO
ALTER TABLE [dbo].[FormasPago]  WITH CHECK ADD FOREIGN KEY([PedidoId])
REFERENCES [dbo].[Pedidos] ([PedidoId])
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD FOREIGN KEY([EmpleadoId])
REFERENCES [dbo].[Empleados] ([EmpleadoId])
GO
USE [master]
GO
ALTER DATABASE [db_temper_trap] SET  READ_WRITE 
GO
