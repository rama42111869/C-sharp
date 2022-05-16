CREATE TABLE [dbo].[Venta]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VehiculoID] INT NULL, 
    [ClienteID] INT NULL, 
    [Importe] NUMERIC(18, 2) NULL, 
    [Descuento] NUMERIC(18, 2) NULL, 
    [Fecha] DATETIME NULL
)
