CREATE TABLE [dbo].[Alquiler]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PeliculaID] INT NULL, 
    [Fecha] DATETIME NULL, 
    [Precio] NUMERIC(18, 2) NULL
)
