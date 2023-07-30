CREATE TABLE [dbo].[PersonHermano](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Surname] [nvarchar](100) NULL,
	[Congregacion] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](12) NULL,
	[FechaCreado] [smalldatetime] NULL,
	[esBautizado] [bit] NOT NULL,
	[esVideo] [bit] NOT NULL,
	[esSonido] [bit] NOT NULL,
	[esPlataforma] [bit] NOT NULL,
	[esAcomVideo] [bit] NOT NULL,
	[esMicro] [bit] NOT NULL,
);
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del hermano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Name'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellidos del hermano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Surname'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Congregacion del hermano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Congregacion'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email del hermano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Email'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de telefono del hermano' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'Phone'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Creacion del hermano en la tabla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'FechaCreado'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si el hermano esta bautizado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esBautizado'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si puede participar en Video' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esVideo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si puede participar en Sonido' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esSonido'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si puede participar en Plataforma' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esPlataforma'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si puede participar en Acomodacion de Video' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esAcomVideo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si puede participar en Micros' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonHermano', @level2type=N'COLUMN',@level2name=N'esMicro'
GO

