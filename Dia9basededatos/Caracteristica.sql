CREATE TABLE [dbo].[Caracteristica]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductoID] INT NULL, 
    [Precio] NUMERIC(18, 2) NULL, 
    [Ancho] NUMERIC(18, 2) NULL, 
    [Largo] NUMERIC(18, 2) NULL, 
    [Peso] NUMERIC(18, 2) NULL
)
