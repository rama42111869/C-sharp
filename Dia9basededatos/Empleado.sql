CREATE TABLE [dbo].[Empleado]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TipoEmpleadoID] INT NULL,
    [Nombre] VARCHAR(150) NULL, 
    [Apellido] VARCHAR(150) NULL, 
    [DNI] VARCHAR(50) NULL, 
    [Legajo] VARCHAR(50) NULL
)
