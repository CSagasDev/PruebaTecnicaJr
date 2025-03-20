CREATE DATABASE DBTienda;
USE DBTienda;

-- Tabla de Categorías
CREATE TABLE Categoria (
    CodigoCategoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL
);

-- Tabla de Productos
CREATE TABLE Producto (
    CodigoProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    CodigoCategoria INT,
    FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(CodigoCategoria)
);

-- Tabla de Ventas
CREATE TABLE Venta (
    CodigoVenta INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATE NOT NULL,
    CodigoProducto INT,
    FOREIGN KEY (CodigoProducto) REFERENCES Producto(CodigoProducto)
);

-- Insertar categorías
INSERT INTO Categoria (Nombre) VALUES ('Electrónica'), ('Ropa'), ('Hogar');

-- Insertar productos
INSERT INTO Producto (Nombre, CodigoCategoria) VALUES 
('Laptop', 1), 
('Camiseta', 2), 
('Televisor', 1),
('Sofá', 3);

-- Insertar ventas solo en 2019
INSERT INTO Venta (Fecha, CodigoProducto) VALUES 
('2019-01-01', 1),
('2019-01-10', 1),
('2019-01-15', 2),
('2019-01-20', 2),
('2019-02-10', 3),
('2019-02-10', 3),
('2019-02-12', 6);

SELECT c.Nombre AS NombreCategoria
FROM Venta v
JOIN Producto p ON v.CodigoProducto = p.CodigoProducto
JOIN Categoria c ON p.CodigoCategoria = c.CodigoCategoria
WHERE v.Fecha = (SELECT MAX(Fecha) FROM Venta);

