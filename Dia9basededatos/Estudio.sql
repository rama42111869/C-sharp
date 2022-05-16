CREATE TABLE [dbo].[Estudio]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TipoEstudioId] INT NULL, 
    [EmpleadoId] INT NULL, 
    [Fecha] DATETIME NULL, 
    [Informe] VARCHAR(250) NULL
)
