CREATE DATABASE ANUNCIOS;
GO
USE ANUNCIOS;

-- Usuarios
CREATE TABLE Usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,  
    correo NVARCHAR(150) UNIQUE NOT NULL,
    contraseña NVARCHAR(255) NOT NULL,
    telefono NVARCHAR(20),
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE()

);
GO

-- Roles
CREATE TABLE Roles (
    RolID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaCreacion DATETIME,
    Activo BIT DEFAULT 1
);
GO

-- UsuariosRoles
CREATE TABLE UsuariosRoles (
    UsuarioID INT,
    RolID INT,
    FechAsignacion DATETIME NOT NULL DEFAULT GETDATE(),
    AsignadoPor NVARCHAR(100),
    Activo BIT DEFAULT 1,
    PRIMARY KEY (UsuarioID, RolID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);
GO

-- Categorias
CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1
);
GO

-- Subcategorias
CREATE TABLE Subcategorias (
    SubcategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    CategoriaID INT NOT NULL,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID)
);
GO

-- Anuncios
CREATE TABLE Anuncios (
    AnuncioID INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200) NOT NULL,
    Descripcion NVARCHAR(MAX),
    Precio DECIMAL(10,2),
    FechaPublicacion DATETIME DEFAULT GETDATE(),
    UsuarioID INT NOT NULL,
    Estado BIT DEFAULT 1,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(id_usuario)
);
GO

-- AnunciosSubcategorias
CREATE TABLE AnunciosSubcategorias (
    AnuncioID INT, 
    SubcategoriaID INT,
    FechaAsignacion DATETIME DEFAULT GETDATE(),
    AsignadoPor NVARCHAR(100),
    PRIMARY KEY (AnuncioID, SubcategoriaID),
    FOREIGN KEY (AnuncioID) REFERENCES Anuncios(AnuncioID),
    FOREIGN KEY (SubcategoriaID) REFERENCES Subcategorias(SubcategoriaID)
);
GO

-- Ubicaciones
CREATE TABLE Ubicaciones (
    UbicacionID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(255),
    Ciudad NVARCHAR(100),
    Pais NVARCHAR(100)
);
GO

-- AnunciosUbicaciones
CREATE TABLE AnunciosUbicaciones (
    AnuncioID INT,
    UbicacionID INT,
    FechaAsignacion DATETIME DEFAULT GETDATE(),
    AsignadoPor NVARCHAR(100),
    Activo BIT DEFAULT 1,
    PRIMARY KEY (AnuncioID, UbicacionID),
    FOREIGN KEY (AnuncioID) REFERENCES Anuncios(AnuncioID),
    FOREIGN KEY (UbicacionID) REFERENCES Ubicaciones(UbicacionID)
);
GO

-- ImagenesAnuncios
CREATE TABLE ImagenesAnuncios (
    ImagenID INT PRIMARY KEY IDENTITY(1,1),
    url NVARCHAR(255) NOT NULL,
    AnuncioID INT NOT NULL,
    Titulo NVARCHAR(100),
    FOREIGN KEY (AnuncioID) REFERENCES Anuncios(AnuncioID)
);
GO

-- Favoritos
CREATE TABLE Favoritos (
    UsuarioID INT,
    AnuncioID INT,
    FechaAgregado DATETIME DEFAULT GETDATE(),
    Notas NVARCHAR(255),
    Activo BIT DEFAULT 1,
    PRIMARY KEY (UsuarioID, AnuncioID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (AnuncioID) REFERENCES Anuncios(AnuncioID)
);
GO

-- Mensajes
CREATE TABLE Mensajes (
    MensajeID INT PRIMARY KEY IDENTITY(1,1),
    Contenido NVARCHAR(MAX) NOT NULL,
    FechaEnvio DATETIME DEFAULT GETDATE(),
    UsuarioEmisorID INT NOT NULL,
    UsuarioReceptorID INT NOT NULL,
    Leido BIT DEFAULT 0,
    FOREIGN KEY (UsuarioEmisorID) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (UsuarioReceptorID) REFERENCES Usuarios(id_usuario)
);
GO

-- ReportesDeAnuncios
CREATE TABLE ReportesDeAnuncios (
    ReporteID INT PRIMARY KEY IDENTITY(1,1),
    Motivo NVARCHAR(255) NOT NULL,
    FechaReporte DATETIME DEFAULT GETDATE(),
    UsuarioID INT NOT NULL,
    AnuncioID INT NOT NULL,
    Estado BIT DEFAULT 0,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (AnuncioID) REFERENCES Anuncios(AnuncioID)
);
GO

-- PlanesDePublicacion
CREATE TABLE PlanesDePublicacion (
    PlanID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Duracion INT NOT NULL, 
    Descripcion NVARCHAR(255)
);
GO

-- Pagos
CREATE TABLE Pagos (
    id_pago INT PRIMARY KEY IDENTITY(1,1),
    monto DECIMAL(10,2) NOT NULL,
    id_usuario INT NOT NULL,
    id_plan INT NOT NULL,
    fecha_pago DATETIME DEFAULT GETDATE(),
    metodo_pago NVARCHAR(50),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_plan) REFERENCES PlanesDePublicacion(PlanID)
);
GO


