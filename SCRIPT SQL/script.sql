USE [ZentaDB]
GO
/****** Object:  Table [dbo].[Fichas]    Script Date: 23-03-2020 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fichas](
	[id_Ficha] [bigint] IDENTITY(1,1) NOT NULL,
	[Cargo] [nvarchar](100) NULL,
	[Antiguedad] [nvarchar](100) NULL,
	[Area] [nvarchar](100) NULL,
 CONSTRAINT [PK_Fichas] PRIMARY KEY CLUSTERED 
(
	[id_Ficha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 23-03-2020 14:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[id_Persona] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Apellido] [nvarchar](100) NULL,
	[Edad] [int] NULL,
	[Ciudad] [nvarchar](100) NULL,
	[Direccion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
