

1. SELECT Nombre FROM Producto;
2. SELECT Nombre, Precio FROM Producto;
3. SELECT Nombre FROM Producto WHERE Precio <= 200;
4. /* Usando AND */
SELECT * FROM Producto
WHERE Precio >= 60 AND Precio <= 120;
/* Usando BETWEEN */
SELECT * FROM Producto
WHERE Precio BETWEEN 60 AND 120;

5. /* Sin usar AS */
SELECT Nombre, Precio * 100 FROM Producto;
/* Usando AS */
SELECT Nombre, Precio * 100 AS PrecioCents FROM Producto;

6. SELECT AVG(Precio) FROM Producto;
7. SELECT AVG(Precio) FROM Producto WHERE ProveedorId=2;
8. SELECT COUNT(*) FROM Producto WHERE Precio >= 180;
9. SELECT Nombre, Precio FROM Producto
WHERE Precio >= 180
ORDER BY Precio DESC, Nombre;
10. /* Sin usar INNER JOIN */
SELECT * FROM Producto, Proveedor
WHERE Producto.ProveedorId = Proveedor.Id;
/* Usando INNER JOIN */
SELECT *
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id;
11. SELECT Producto.Nombre, Precio, Proveedor.Nombre
FROM Producto, Proveedor

WHERE Producto.ProveedorId = Proveedor.Id;
/* Usando INNER JOIN */
SELECT Producto.Nombre, Precio, Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id;
12. SELECT AVG(Precio), ProveedorId
FROM Producto
GROUP BY ProveedorId;
13. /* Sin usar INNER JOIN */
SELECT AVG(Precio), Proveedor.Nombre
FROM Producto, Proveedor
WHERE Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre;
/* Usando INNER JOIN */
SELECT AVG(Precio), Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre;
14. /* Sin usar INNER JOIN */
SELECT AVG(Precio), Proveedor.Nombre
FROM Producto, Proveedor
WHERE Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre
HAVING AVG(Precio) >= 150;
/* Usando INNER JOIN */
SELECT AVG(Precio), Proveedor.Nombre
FROM Producto INNER JOIN Proveedor
ON Producto.ProveedorId = Proveedor.Id
GROUP BY Proveedor.Nombre
HAVING AVG(Precio) >= 150;
15. SELECT Nombre,Precio
FROM Producto
ORDER BY Precio ASC
LIMIT 1
/* Usando SELECT anidado */
/* Atencion: Si existe más de un item con el menor precio
devolvera ambos */
SELECT Nombre, Precio
FROM Producto
WHERE Precio = (SELECT MIN(Precio) FROM Producto);

16. /* Usando SELECT anidado y Sin usar INNER JOIN */
SELECT A.Nombre, A.Precio, F.Nombre
FROM Producto A, Proveedor F
WHERE A.ProveedorId = F.Id
AND A.Precio =
(
SELECT MAX(A.Precio)
FROM Producto A
WHERE A.ProveedorId = F.Id
);
/* Usando a nested SELECT and y INNER JOIN */
SELECT A.Nombre, A.Precio, F.Nombre
FROM Producto A INNER JOIN Proveedor F
ON A.ProveedorId = F.Id
AND A.Precio =
(
SELECT MAX(A.Precio)
FROM Producto A
WHERE A.ProveedorId = F.Id
);

17. Select m.Nombre, Avg(p.Precio) as p_Precio, COUNT(p.ProveedorId)
as m_count
FROM Proveedor m, Producto p
WHERE p.ProveedorId = m.Id
GROUP BY p.ProveedorId
HAVING p_Precio >= 150 and m_count >= 2;
18. INSERT INTO Producto( Id, Nombre , Precio , ProveedorId)
VALUES ( 11, 'Loudspeakers' , 70 , 2 );
19. UPDATE Producto
SET Nombre = 'Laser Printer'
WHERE Id = 8;
20. UPDATE Producto
SET Precio = Precio - (Precio * 0.1);
21. UPDATE Producto
SET Precio = Precio - (Precio * 0.1)
WHERE Precio >= 120;