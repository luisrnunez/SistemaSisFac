
CREATE TABLE Persona (
    IdPersona INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Cedula NVARCHAR(10),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100)
);
GO

CREATE TABLE Cliente (
    IdPersona INT PRIMARY KEY,
    FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Empleado (
    IdPersona INT PRIMARY KEY,
    Usuario NVARCHAR(50),
    Clave VARBINARY(64),
    FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Administrador (
    IdPersona INT PRIMARY KEY,
    Usuario NVARCHAR(50),
    Clave VARBINARY(64),
    FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona)
);
GO

CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100),
    Contacto NVARCHAR(100),
    RUC NVARCHAR(13)
);
GO

CREATE TABLE Producto (
    IdProducto INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(200),
    Precio DECIMAL(18, 2),
    Stock INT,
	IdProveedor INT,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor)
);
GO

CREATE TABLE Factura (
    IdFactura INT PRIMARY KEY IDENTITY,
    IdCliente INT,
    IdEmpleado INT,
    Fecha DATETIME,
    Total DECIMAL(18, 2),
    Pago DECIMAL(18, 2),
    Cambio DECIMAL(18, 2),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdPersona),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdPersona)
);
GO

CREATE TABLE DetalleFactura (
    IdDetalle INT PRIMARY KEY IDENTITY,
    IdFactura INT,
    IdProducto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(18, 2),
    Subtotal DECIMAL(18, 2),
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);
GO

CREATE PROCEDURE LeerClientes
AS
BEGIN
    SELECT 
        p.IdPersona AS IdCliente, 
        p.Nombre, 
        p.Apellido, 
        p.Cedula, 
        p.Direccion, 
        p.Telefono, 
        p.Email 
    FROM 
        Cliente c
    INNER JOIN 
        Persona p ON c.IdPersona = p.IdPersona;
END;
GO

CREATE PROCEDURE CrearCliente
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100)
AS
BEGIN
    DECLARE @idPersona INT;

    -- Insertar en Persona
    INSERT INTO Persona (Nombre, Apellido, Cedula, Direccion, Telefono, Email)
    VALUES (@nombre, @apellido, @cedula, @direccion, @telefono, @correo);

    SET @idPersona = SCOPE_IDENTITY();

    -- Insertar en Cliente
    INSERT INTO Cliente (IdPersona)
    VALUES (@idPersona);
END;
GO

CREATE PROCEDURE ActualizarCliente
    @idcliente INT,
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100)
AS
BEGIN
    UPDATE Persona
    SET 
        Nombre = @nombre,
        Apellido = @apellido,
        Cedula = @cedula,
        Direccion = @direccion,
        Telefono = @telefono,
        Email = @correo
    WHERE 
        IdPersona = @idcliente;
END;
GO

CREATE PROCEDURE EliminarCliente
    @idcliente INT
AS
BEGIN
    DELETE FROM Cliente WHERE IdPersona = @idcliente;
    DELETE FROM Persona WHERE IdPersona = @idcliente;
END;

GO

CREATE PROCEDURE LeerEmpleados
AS
BEGIN
    SELECT 
        p.IdPersona AS IdEmpleado, 
        p.Nombre, 
        p.Apellido, 
        e.Usuario
    FROM 
        Empleado e
    INNER JOIN 
        Persona p ON e.IdPersona = p.IdPersona;
END;
GO

CREATE PROCEDURE CrearEmpleado
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100),
    @usuario NVARCHAR(50),
    @clave NVARCHAR(50)
AS
BEGIN
    DECLARE @idPersona INT;
	DECLARE @claveHash VARBINARY(64);

    -- Generar el hash de la clave
    SET @claveHash = HASHBYTES('SHA2_256', CAST(@clave AS NVARCHAR(10)));
    -- Insertar en Persona
    INSERT INTO Persona (Nombre, Apellido, Cedula, Direccion, Telefono, Email)
    VALUES (@nombre, @apellido, @cedula, @direccion, @telefono, @correo);

    SET @idPersona = SCOPE_IDENTITY();

    -- Insertar en Empleado
    INSERT INTO Empleado (IdPersona, Usuario, Clave)
    VALUES (@idPersona, @usuario, @claveHash);
END;
GO

CREATE PROCEDURE ActualizarEmpleado
    @idempleado INT,
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100),
    @usuario NVARCHAR(50),
    @clave NVARCHAR(50)
AS
BEGIN
	DECLARE @claveHash VARBINARY(64);

    -- Generar el hash de la clave
    SET @claveHash = HASHBYTES('SHA2_256', CAST(@clave AS NVARCHAR(10)));
    UPDATE Persona
    SET 
        Nombre = @nombre,
        Apellido = @apellido,
        Cedula = @cedula,
        Direccion = @direccion,
        Telefono = @telefono,
        Email = @correo
    WHERE 
        IdPersona = @idempleado;

    UPDATE Empleado
    SET 
        Usuario = @usuario,
        Clave = @claveHash
    WHERE 
        IdPersona = @idempleado;
END;
GO

CREATE PROCEDURE EliminarEmpleado
    @idempleado INT
AS
BEGIN
    DELETE FROM Empleado WHERE IdPersona = @idempleado;
    DELETE FROM Persona WHERE IdPersona = @idempleado;
END;
GO

CREATE PROCEDURE LeerAdministradores
AS
BEGIN
    SELECT 
        p.IdPersona AS IdAdministrador, 
        p.Nombre, 
        p.Apellido, 
        a.Usuario
    FROM 
        Administrador a
    INNER JOIN 
        Persona p ON a.IdPersona = p.IdPersona;
END;
GO

CREATE PROCEDURE CrearAdministrador
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100),
    @usuario NVARCHAR(50),
    @clave NVARCHAR(50)
AS
BEGIN
    DECLARE @idPersona INT;
	DECLARE @claveHash VARBINARY(64);

    -- Generar el hash de la clave
    SET @claveHash = HASHBYTES('SHA2_256', CAST(@clave AS NVARCHAR(10)));
    -- Insertar en Persona
    INSERT INTO Persona (Nombre, Apellido, Cedula, Direccion, Telefono, Email)
    VALUES (@nombre, @apellido, @cedula, @direccion, @telefono, @correo);

    SET @idPersona = SCOPE_IDENTITY();

    -- Insertar en Administrador
    INSERT INTO Administrador (IdPersona, Usuario, Clave)
    VALUES (@idPersona, @usuario, @claveHash);
END;

GO

CREATE PROCEDURE ActualizarAdministrador
    @idadministrador INT,
    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @cedula NVARCHAR(10),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100),
    @usuario NVARCHAR(50),
    @clave NVARCHAR(50)
AS
BEGIN
	DECLARE @claveHash VARBINARY(64);

    -- Generar el hash de la clave
    SET @claveHash = HASHBYTES('SHA2_256', CAST(@clave AS NVARCHAR(10)));
    UPDATE Persona
    SET 
        Nombre = @nombre,
        Apellido = @apellido,
        Cedula = @cedula,
        Direccion = @direccion,
        Telefono = @telefono,
        Email = @correo
    WHERE 
        IdPersona = @idadministrador;

    UPDATE Administrador
    SET 
        Usuario = @usuario,
        Clave = @claveHash
    WHERE 
        IdPersona = @idadministrador;
END;
GO

CREATE PROCEDURE EliminarAdministrador
    @idadministrador INT
AS
BEGIN
    DELETE FROM Administrador WHERE IdPersona = @idadministrador;
    DELETE FROM Persona WHERE IdPersona = @idadministrador;
END;

GO

CREATE PROCEDURE LeerProductos
AS
BEGIN
    SELECT IdProducto,IdProveedor, Nombre, Descripcion,(select Nombre from Proveedores pr where pr.IdProveedor = p.IdProveedor) as NProveedor, Precio, Stock FROM Producto p;
END;
GO

CREATE PROCEDURE CrearProducto
    @nombre NVARCHAR(100),
    @descripcion NVARCHAR(200),
    @precio DECIMAL(18, 2),
    @stock INT,
	@idproveedor INT
AS
BEGIN
    INSERT INTO Producto (Nombre, Descripcion, Precio, Stock,IdProveedor)
    VALUES (@nombre, @descripcion, @precio, @stock,@idproveedor);
END;
GO

CREATE PROCEDURE ActualizarProducto
    @idproducto INT,
    @nombre NVARCHAR(100),
    @descripcion NVARCHAR(200),
    @precio DECIMAL(18, 2),
    @stock INT
AS
BEGIN
    UPDATE Producto
    SET 
        Nombre = @nombre,
        Descripcion = @descripcion,
        Precio = @precio,
        Stock = @stock
    WHERE 
        IdProducto = @idproducto;
END;
GO

CREATE PROCEDURE EliminarProducto
    @idproducto INT
AS
BEGIN
    DELETE FROM Producto WHERE IdProducto = @idproducto;
END;
GO

CREATE PROCEDURE CrearFactura
    @IdCliente INT,
    @IdEmpleado INT,
    @Fecha DATETIME,
    @Total DECIMAL(18, 2),
    @Pago DECIMAL(18, 2),
    @Cambio DECIMAL(18, 2)
AS
BEGIN
    -- Declarar una variable para almacenar el IdFactura generado
    DECLARE @IdFactura INT;

    -- Insertar la nueva factura
    INSERT INTO Factura (IdCliente, IdEmpleado, Fecha, Total, Pago, Cambio)
    VALUES (@IdCliente, @IdEmpleado, @Fecha, @Total, @Pago, @Cambio);

    -- Obtener el IdFactura generado y almacenarlo en la variable
    SET @IdFactura = SCOPE_IDENTITY();

    -- Devolver el IdFactura
    SELECT @IdFactura AS IdFactura;
END;

GO

CREATE PROCEDURE ConsultarDetalleFactura
    @IdFactura INT
AS
BEGIN
    SELECT 
        IdDetalle,
        IdFactura,
        IdProducto,
        Cantidad,
        PrecioUnitario,
        Subtotal
    FROM 
        DetalleFactura
    WHERE 
        IdFactura = @IdFactura;
END;
GO

CREATE PROCEDURE CrearDetFactura
    @IdFactura INT,
    @IdProducto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(18, 2),
    @Subtotal DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO DetalleFactura (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal)
    VALUES (@IdFactura, @IdProducto, @Cantidad, @PrecioUnitario, @Subtotal);
END;
GO

CREATE PROCEDURE ListarFacturas
AS
BEGIN
    -- Seleccionar todas las facturas de la tabla Factura
    SELECT 
        IdFactura,
        IdCliente,
        IdEmpleado,
        Fecha,
        Total,
        Pago,
        Cambio
    FROM 
        Factura
    ORDER BY 
        Fecha DESC;  -- Ordena por fecha en orden descendente
END;

GO

CREATE TRIGGER trg_UpdateProductStock
ON DetalleFactura
AFTER INSERT
AS
BEGIN
    DECLARE @IdProducto INT, @Cantidad INT;

    -- Obtener el IdProducto y la Cantidad del registro insertado
    SELECT @IdProducto = INSERTED.IdProducto, @Cantidad = INSERTED.Cantidad
    FROM INSERTED;

    -- Actualizar el stock del producto
    UPDATE Producto
    SET Stock = Stock - @Cantidad
    WHERE IdProducto = @IdProducto;
END;
GO

CREATE PROCEDURE ValidarUsuarioEmp
    @Usuario NVARCHAR(50),
    @Clave NVARCHAR(50)
AS
BEGIN
    DECLARE @ClaveHash VARBINARY(64);
    SET @ClaveHash = HASHBYTES('SHA2_256', CAST(@Clave AS NVARCHAR(10)));

    SELECT 
        emp.IdPersona, 
        Nombre, 
        Apellido
    FROM 
        Empleado emp 
        INNER JOIN Persona per ON emp.IdPersona = per.IdPersona
    WHERE 
        Usuario = @Usuario 
        AND Clave = @ClaveHash;
END;

Go

CREATE PROCEDURE ValidarUsuarioAdmi
    @Usuario NVARCHAR(50),
    @Clave NVARCHAR(50)
AS
BEGIN
    DECLARE @ClaveHash VARBINARY(64);
    SET @ClaveHash = HASHBYTES('SHA2_256', CAST(@Clave AS NVARCHAR(10)));

    SELECT 
        admi.IdPersona, 
        Nombre, 
        Apellido
    FROM 
        Administrador admi 
        INNER JOIN Persona per ON admi.IdPersona = per.IdPersona
    WHERE 
        Usuario = @Usuario 
        AND Clave = @ClaveHash;
END;
GO

CREATE PROCEDURE BuscarClientePorId
    @idPersona INT
AS
BEGIN
    SELECT 
        p.IdPersona AS IdCliente, 
        p.Nombre, 
        p.Apellido, 
        p.Cedula, 
        p.Direccion, 
        p.Telefono, 
        p.Email 
    FROM 
        Cliente c
    INNER JOIN 
        Persona p ON c.IdPersona = p.IdPersona
    WHERE p.IdPersona = @idPersona;
END;
GO

CREATE PROCEDURE BuscarEmpleadoPorId
    @idPersona INT
AS
BEGIN
    SELECT 
        p.IdPersona AS IdEmpleado, 
        p.Nombre, 
        p.Apellido, 
        e.Usuario
    FROM 
        Empleado e
    INNER JOIN 
        Persona p ON e.IdPersona = p.IdPersona
    WHERE p.IdPersona = @idPersona;
END;
GO

CREATE PROCEDURE BuscarAdministradorPorId
    @idPersona INT
AS
BEGIN
    SELECT 
        p.IdPersona AS IdAdministrador, 
        p.Nombre, 
        p.Apellido, 
        a.Usuario
    FROM 
        Administrador a
    INNER JOIN 
        Persona p ON a.IdPersona = p.IdPersona
    WHERE p.IdPersona = @idPersona;
END;
GO

CREATE PROCEDURE BuscarClientesPorCriterio
    @Criterio NVARCHAR(50),
    @Valor NVARCHAR(50)
AS
BEGIN
    IF @Criterio = 'Cedula'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
            p.Direccion,
			p.Telefono,
			p.Email
        FROM 
            Cliente c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Cedula LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Nombre'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
             p.Direccion,
			p.Telefono,
			p.Email
        FROM 
            Cliente c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Nombre LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Apellido'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
            p.Direccion,
			p.Telefono,
			p.Email
        FROM 
            Cliente c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Apellido LIKE '%' + @Valor + '%';
    END
END;
GO

CREATE PROCEDURE BuscarEmpleadosPorCriterio
    @Criterio NVARCHAR(50),
    @Valor NVARCHAR(50)
AS
BEGIN
    IF @Criterio = 'Cedula'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
             p.Direccion,
			p.Telefono,
			p.Email,
			c.Usuario
        FROM 
            Empleado c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Cedula LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Nombre'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
             p.Direccion,
			p.Telefono,
			p.Email,
			c.Usuario
        FROM 
            Empleado c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Nombre LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Apellido'
    BEGIN
        SELECT 
            c.IdPersona,
            p.Cedula,
            p.Nombre,
            p.Apellido,
            p.Direccion,
			p.Telefono,
			p.Email,
			c.Usuario
        FROM 
            Empleado c
        INNER JOIN 
            Persona p ON c.IdPersona = p.IdPersona
        WHERE 
            p.Apellido LIKE '%' + @Valor + '%';
    END
END;
GO
CREATE PROCEDURE BuscarProductosPorCriterio
    @Criterio NVARCHAR(50),
    @Valor NVARCHAR(50)
AS
BEGIN
    IF @Criterio = 'Nombre'
    BEGIN
        SELECT *,(select Nombre from Proveedores pr where pr.IdProveedor = p.IdProveedor) as NProveedor
        FROM 
            Producto p
        WHERE 
            Nombre LIKE '%' + @Valor + '%';
    END
	ELSE IF @Criterio = 'Proveedor'
    BEGIN
        SELECT *,(select Nombre from Proveedores pr where pr.IdProveedor =p.IdProveedor) as NProveedor
        FROM 
            Producto p
        WHERE 
            IdProveedor LIKE '%' + @Valor + '%';
    END
END;
exec BuscarProductosPorCriterio 'Nombre','a'
GO

CREATE PROCEDURE LeerProveedores
AS
BEGIN
    SELECT * FROM Proveedores;
END;
GO

CREATE PROCEDURE CrearProveedor
    @nombre NVARCHAR(100),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @email NVARCHAR(100),
    @contacto NVARCHAR(100),
    @ruc NVARCHAR(13)
AS
BEGIN
    INSERT INTO Proveedores (Nombre, Direccion, Telefono, Email, Contacto, RUC)
    VALUES (@nombre, @direccion, @telefono, @email, @contacto, @ruc);
END;
GO

CREATE PROCEDURE ActualizarProveedor
    @idProveedor INT,
    @nombre NVARCHAR(100),
    @direccion NVARCHAR(200),
    @telefono NVARCHAR(15),
    @email NVARCHAR(100),
    @contacto NVARCHAR(100),
    @ruc NVARCHAR(13)
AS
BEGIN
    UPDATE Proveedores
    SET Nombre = @nombre,
        Direccion = @direccion,
        Telefono = @telefono,
        Email = @email,
        Contacto = @contacto,
        RUC = @ruc
    WHERE IdProveedor = @idProveedor;
END;
GO

CREATE PROCEDURE EliminarProveedor
    @idProveedor INT
AS
BEGIN
    DELETE FROM Proveedores
    WHERE IdProveedor = @idProveedor;
END;
GO

CREATE PROCEDURE BuscarProveedorPorId
    @idPersona INT
AS
BEGIN
    SELECT * FROM Proveedores
    WHERE IdProveedor = @idPersona;
END;
GO

CREATE PROCEDURE BuscarProveedoresPorCriterio
    @Criterio NVARCHAR(50),
    @Valor NVARCHAR(50)
AS
BEGIN
	IF @Criterio = 'Nombre'
    BEGIN
           SELECT * FROM Proveedores WHERE  Nombre LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Contacto'
    BEGIN
           SELECT * FROM Proveedores WHERE  Contacto LIKE '%' + @Valor + '%';
    END
    ELSE IF @Criterio = 'Telefono'
    BEGIN
          SELECT * FROM Proveedores WHERE  Telefono LIKE '%' + @Valor + '%';
    END
	 ELSE IF @Criterio = 'RUC'
    BEGIN
          SELECT * FROM Proveedores WHERE  RUC LIKE '%' + @Valor + '%';
    END

END;
GO
CREATE PROCEDURE VerificarDuplicados
    @id INT,  -- ID de la persona a actualizar
    @cedula NVARCHAR(10),
    @telefono NVARCHAR(15),
    @correo NVARCHAR(100),
    @usuario NVARCHAR(50),
    @metodo NVARCHAR(10)
AS
BEGIN
    IF @metodo = 'insert'
    BEGIN
        -- Verificación de duplicados en modo 'insert'
        IF EXISTS (SELECT 1 FROM Persona WHERE Cedula = @cedula)
        BEGIN
            SELECT 1; -- Cédula duplicada
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Persona WHERE Telefono = @telefono)
        BEGIN
            SELECT 2; -- Teléfono duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Persona WHERE Email = @correo)
        BEGIN
            SELECT 3; -- Correo duplicado
            RETURN;
        END
        IF @usuario != 'cliente'
        BEGIN
            IF EXISTS (SELECT 1 FROM Empleado WHERE Usuario = @usuario)
            BEGIN
                SELECT 4; -- Usuario duplicado en Empleado
                RETURN;
            END
        END
    END
    ELSE IF @metodo = 'update'
    BEGIN
        -- Verificación de duplicados en modo 'update'
        -- Se excluye el registro con el @id actual

        IF EXISTS (SELECT 1 FROM Persona WHERE Cedula = @cedula AND IdPersona != @id)
        BEGIN
            SELECT 1; -- Cédula duplicada
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Persona WHERE Telefono = @telefono AND IdPersona != @id)
        BEGIN
            SELECT 2; -- Teléfono duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Persona WHERE Email = @correo AND IdPersona != @id)
        BEGIN
            SELECT 3; -- Correo duplicado
            RETURN;
        END
        IF @usuario != 'cliente'
        BEGIN
            IF EXISTS (SELECT 1 FROM Empleado WHERE Usuario = @usuario AND IdPersona != @id)
            BEGIN
                SELECT 4; -- Usuario duplicado en Empleado
                RETURN;
            END
        END
    END
END;

GO

CREATE PROCEDURE VerificarDuplicadosProvee
    @id INT,  -- ID del proveedor a actualizar (usado en update)
    @nombre NVARCHAR(100),
    @telefono NVARCHAR(15),
    @email NVARCHAR(100),
    @ruc NVARCHAR(13),
    @metodo NVARCHAR(10)  -- Puede ser 'insert' o 'update'
AS
BEGIN
    IF @metodo = 'insert'
    BEGIN
        -- Verificación de duplicados en modo 'insert'
        IF EXISTS (SELECT 1 FROM Proveedores WHERE Nombre = @nombre)
        BEGIN
            SELECT 1; -- Nombre duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE Telefono = @telefono)
        BEGIN
            SELECT 2; -- Teléfono duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE Email = @email)
        BEGIN
            SELECT 3; -- Correo duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE RUC = @ruc)
        BEGIN
            SELECT 4; -- RUC duplicado
            RETURN;
        END
    END
    ELSE IF @metodo = 'update'
    BEGIN
        -- Verificación de duplicados en modo 'update'
        -- Excluir el registro con el @id actual en las verificaciones

        IF EXISTS (SELECT 1 FROM Proveedores WHERE Nombre = @nombre AND IdProveedor != @id)
        BEGIN
            SELECT 1; -- Nombre duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE Telefono = @telefono AND IdProveedor != @id)
        BEGIN
            SELECT 2; -- Teléfono duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE Email = @email AND IdProveedor != @id)
        BEGIN
            SELECT 3; -- Correo duplicado
            RETURN;
        END
        IF EXISTS (SELECT 1 FROM Proveedores WHERE RUC = @ruc AND IdProveedor != @id)
        BEGIN
            SELECT 4; -- RUC duplicado
            RETURN;
        END
    END
END;
GO

CREATE PROCEDURE VerificarDuplicadosProducto
    @id INT,  -- ID del producto a actualizar (usado en update)
    @nombre NVARCHAR(100),
    @metodo NVARCHAR(10)  -- Puede ser 'insert' o 'update'
AS
BEGIN
    IF @metodo = 'insert'
    BEGIN
        -- Verificación de duplicados en modo 'insert'
        IF EXISTS (SELECT 1 FROM Producto WHERE Nombre = @nombre)
        BEGIN
            SELECT 1; -- Nombre duplicado
            RETURN;
        END
    END
    ELSE IF @metodo = 'update'
    BEGIN
        -- Verificación de duplicados en modo 'update'
        -- Excluir el registro con el @id actual en la verificación
        IF EXISTS (SELECT 1 FROM Producto WHERE Nombre = @nombre AND IdProducto != @id)
        BEGIN
            SELECT 1; -- Nombre duplicado
            RETURN;
        END
    END
END;

GO

INSERT INTO Proveedores (Nombre, Direccion, Telefono, Email, Contacto, RUC) VALUES
('TechSupplier S.A.', 'Av. Principal 123, Quito, Ecuador', '022345678', 'ventas@techsupplier.com.ec', 'Juan Pérez', '1790012345001'),
('Distribuidora Digital', 'Calle Secundaria 456, Guayaquil, Ecuador', '042345679', 'info@distribuidoradigital.com.ec', 'María González', '0991234567001'),
('ElectroPro S.A.', 'Av. Tercera 789, Cuenca, Ecuador', '072345670', 'contacto@electropro.com.ec', 'Carlos Ramírez', '0192345678001');
go

INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, IdProveedor) VALUES
('Laptop Lenovo', 'Laptop con procesador Intel Core i5 y pantalla HD', 1200.50, 15, 1),
('Smartphone Samsung Galaxy', 'Teléfono inteligente con pantalla Super AMOLED y cámara de 48 MP', 899.99, 20, 2),
('Monitor LG UltraWide', 'Monitor de 34 pulgadas con resolución 3440x1440 y tecnología IPS', 799.00, 10, 3),
('Impresora HP LaserJet', 'Impresora láser monocromática para oficina', 349.95, 8, 1),
('Teclado mecánico Razer', 'Teclado mecánico para gaming con retroiluminación RGB', 149.99, 25, 2),
('Mouse Logitech G502', 'Mouse gaming con sensor óptico de alta precisión y 11 botones programables', 79.99, 30, 3),
('Auriculares Sony WH-1000XM4', 'Auriculares con cancelación de ruido y conexión Bluetooth', 299.00, 12, 1),
('Tablet Apple iPad Pro', 'Tablet con pantalla Liquid Retina y chip A12Z Bionic', 999.00, 18, 2),
('Cámara Canon EOS R5', 'Cámara mirrorless con sensor CMOS de 45 MP y grabación de video 8K', 3499.00, 3, 3),
('Proyector Epson Home Cinema', 'Proyector Full HD con tecnología 3LCD y 3500 lúmenes', 699.99, 7, 1);
GO

INSERT INTO Persona (Nombre, Apellido, Cedula, Direccion, Telefono, Email) VALUES 
('Juan', 'Perez', '0123456789', 'Calle Falsa 123', '0987654321', 'juan.perez@example.com'),
('Maria', 'Gonzalez', '1123456789', 'Avenida Siempre Viva 742', '0987654322', 'maria.gonzalez@example.com'),
('Pedro', 'Martinez', '2123456789', 'Boulevard de los Sueños Rotos 456', '0987654323', 'pedro.martinez@example.com'),
('Luisa', 'Fernandez', '3123456789', 'Calle del Sol 789', '0987654324', 'luisa.fernandez@example.com'),
('Carlos', 'Lopez', '4123456789', 'Avenida Libertador 101', '0987654325', 'carlos.lopez@example.com'),
('Ana', 'Ramirez', '5123456789', 'Calle Luna 202', '0987654326', 'ana.ramirez@example.com'),
('Jorge', 'Torres', '6123456789', 'Calle Estrella 303', '0987654327', 'jorge.torres@example.com'),
('Laura', 'Hernandez', '7123456789', 'Avenida de la Paz 404', '0987654328', 'laura.hernandez@example.com'),
('Ricardo', 'Diaz', '8123456789', 'Calle Victoria 505', '0987654329', 'ricardo.diaz@example.com'),
('Elena', 'Sanchez', '9123456789', 'Avenida Central 606', '0987654330', 'elena.sanchez@example.com'),
('JuanEmp', 'Perez', '0123456789', 'Calle Falsa 123', '0987654321', 'juan.perez@example.com'),
('MariaEmp', 'Gonzalez', '1123456789', 'Avenida Siempre Viva 742', '0987654322', 'maria.gonzalez@example.com'),
('PedroEmp', 'Martinez', '2123456789', 'Boulevard de los Sueños Rotos 456', '0987654323', 'pedro.martinez@example.com'),
('Juan', 'Luis', 'xxxxxxx', 'xxxxxxxxxxx', 'xxxxxxxx', 'admin@example.com');
GO

INSERT INTO Empleado (IdPersona, Usuario, Clave)
VALUES
(11, 'emp1', HASHBYTES('SHA2_256', CAST(123 AS NVARCHAR(10)))),
(12, 'emp2', HASHBYTES('SHA2_256', CAST(123 AS NVARCHAR(10)))),
(13, 'emp3', HASHBYTES('SHA2_256', CAST(123 AS NVARCHAR(10))));
GO

INSERT INTO Administrador (IdPersona, Usuario, Clave)
VALUES
(14, 'admin', HASHBYTES('SHA2_256', CAST(123 AS NVARCHAR(10))));
GO

INSERT INTO Cliente (IdPersona)
VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10);


--select * from Empleado
--select * from Administrador
--select * from Cliente
--select * from Persona
--select * from Producto
--select * from Proveedores
--select * from Factura
--select * from DetalleFactura


---- Reiniciar el conteo de la columna IDENTITY a 1
--DBCC CHECKIDENT ('Factura', RESEED, 0);

--delete from Cliente
--delete from Administrador
--delete from Empleado
--delete from Persona
--delete from Producto
--delete from Factura

-- Procedimiento para Leer todos los Proveedores

go
INSERT INTO Factura (IdCliente, IdEmpleado, Fecha, Total, Pago, Cambio)
VALUES
(1, 11, '2024-09-01', 1299.49, 1300.00, 0.51),
(2, 12, '2024-09-02', 1199.98, 1200.00, 0.02),
(3, 13, '2024-09-03', 1599.00, 1600.00, 1.00),
(4, 11, '2024-09-04', 549.94, 550.00, 0.06),
(5, 12, '2024-09-05', 149.99, 150.00, 0.01),
(6, 13, '2024-09-02', 319.98, 320.00, 0.02),
(7, 11, '2024-09-03', 1299.00, 1300.00, 1.00),
(8, 12, '2024-09-02', 999.00, 1000.00, 1.00),
(9, 13, '2024-09-03', 3499.00, 3500.00, 1.00),
(10, 11, '2024-09-02', 799.99, 800.00, 0.01),
(1, 12, '2024-09-01', 1199.98, 1200.00, 0.02),
(2, 13, '2024-09-02', 1599.00, 1600.00, 1.00),
(3, 11, '2024-09-03', 549.94, 550.00, 0.06),
(4, 12, '2024-09-05', 149.99, 150.00, 0.01),
(5, 13, '2024-09-05', 319.98, 320.00, 0.02),
(6, 11, '2024-09-03', 1299.00, 1300.00, 1.00),
(7, 12, '2024-09-02', 999.00, 1000.00, 1.00),
(8, 13, '2024-09-02', 3499.00, 3500.00, 1.00),
(9, 11, '2024-09-01', 799.99, 800.00, 0.01),
(10, 12, '2024-09-01', 1199.98, 1200.00, 0.02);
go

INSERT INTO DetalleFactura (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal)
VALUES
(1, 1, 1, 1200.50, 1200.50),
(1, 6, 1, 79.99, 79.99),
(2, 2, 1, 899.99, 899.99),
(2, 4, 1, 349.95, 349.95),
(3, 3, 1, 799.00, 799.00),
(3, 8, 1, 999.00, 999.00),
(4, 4, 1, 349.95, 349.95),
(4, 5, 1, 149.99, 149.99),
(5, 5, 1, 149.99, 149.99),
(6, 6, 1, 79.99, 79.99),
(6, 7, 1, 299.00, 299.00),
(7, 1, 1, 1200.50, 1200.50),
(7, 7, 1, 299.00, 299.00),
(8, 8, 1, 999.00, 999.00),
(9, 9, 1, 3499.00, 3499.00),
(10, 3, 1, 799.00, 799.00),
(11, 1, 1, 1200.50, 1200.50),
(11, 6, 1, 79.99, 79.99),
(12, 2, 1, 899.99, 899.99),
(12, 4, 1, 349.95, 349.95),
(13, 3, 1, 799.00, 799.00),
(13, 8, 1, 999.00, 999.00),
(14, 4, 1, 349.95, 349.95),
(14, 5, 1, 149.99, 149.99),
(15, 5, 1, 149.99, 149.99),
(16, 6, 1, 79.99, 79.99),
(16, 7, 1, 299.00, 299.00),
(17, 1, 1, 1200.50, 1200.50),
(17, 7, 1, 299.00, 299.00),
(18, 8, 1, 999.00, 999.00),
(19, 9, 1, 3499.00, 3499.00),
(20, 3, 1, 799.00, 799.00);
