SELECT Nombre FROM Producto

SELECT Nombre, Precio FROM Producto;

SELECT Nombre FROM Producto WHERE Precio <= 200;

SELECT * FROM Producto
WHERE Precio >= 60 AND Precio <= 120;

SELECT Nombre, Precio * 100 AS PrecioCents FROM Producto;

SELECT AVG(Precio) FROM Producto;

SELECT AVG(Precio) FROM Producto WHERE ProveedorId=2;

SELECT COUNT(*) FROM Producto WHERE Precio >= 180;

SELECT Nombre, Precio FROM Producto
WHERE Precio >= 180
ORDER BY Precio DESC, Nombre;

SELECT *
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id;

SELECT Producto.Nombre, Precio, Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id;

SELECT AVG(Precio), ProveedorId
FROM Producto
GROUP BY ProveedorId;

SELECT AVG(Precio), Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre;

SELECT AVG(Precio), Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre
HAVING AVG(Precio) >= 150;

SELECT Nombre, Precio
FROM Producto
WHERE Precio = (SELECT MIN(Precio) FROM Producto);

SELECT A.Nombre, A.Precio, F.Nombre
FROM Producto A INNER JOIN Proveedor F
ON A.ProveedorId = F.Id
AND A.Precio =
(
SELECT MAX(A.Precio)
FROM Producto A
WHERE A.ProveedorId = F.Id
);

/* Select m.Nombre, Avg(p.Precio) as p_Precio, COUNT(p.ProveedorId)
as m_count
FROM Proveedor m, Producto p
WHERE p.ProveedorId = m.Id
GROUP BY p.ProveedorId
HAVING p_Precio >= 150 and m_count >= 2;

INSERT INTO Producto( Id, Nombre , Precio , ProveedorId)
VALUES ( 11, 'Loudspeakers' , 70 , 2 );
*/

UPDATE Producto
SET Nombre = 'Laser Printer'
WHERE Id = 8;

UPDATE Producto
SET Precio = Precio - (Precio * 0.1);

UPDATE Producto
SET Precio = Precio - (Precio * 0.1)
WHERE Precio >= 120;