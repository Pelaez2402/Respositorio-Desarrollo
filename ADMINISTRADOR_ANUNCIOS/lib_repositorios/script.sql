create database ANUNCIOS;
GO
use ANUNCIOS;
CREATE TABLE Usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    correo NVARCHAR(150) UNIQUE NOT NULL,
    contraseña NVARCHAR(255) NOT NULL,
    telefono NVARCHAR(20),
    fecha_registro DATE NOT NULL
);
GO
CREATE TABLE Roles (
    id_rol INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(50) NOT NULL,
    descripcion NVARCHAR(255),
    fecha_creacion DATE,
    activo BIT default 1 
);
GO
CREATE TABLE Usuarios_Roles (
    id_usuario INT,
    id_rol INT,
    fecha_asignacion DATE NOT NULL,
    asignado_por NVARCHAR(100),
    activo BIT default 1,
    PRIMARY KEY (id_usuario, id_rol),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_rol) REFERENCES Roles(id_rol)
);
GO
CREATE TABLE Categorias (
    id_categoria INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    fecha_creacion DATE,
    activo BIT DEFAULT 1
);
GO
CREATE TABLE Subcategorias (
    id_subcategoria INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    id_categoria INT,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria)
);
GO
CREATE TABLE Anuncios (
    id_anuncio INT PRIMARY KEY IDENTITY(1,1),
    titulo NVARCHAR(200) NOT NULL,
    descripcion NVARCHAR(MAX),
    precio DECIMAL(10,2),
    fecha_publicacion DATE,
    id_usuario INT,
    estado NVARCHAR(50) ,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);
GO
CREATE TABLE Anuncios_Subcategoria (
    id_anuncio INT,
    id_subcategoria INT,
    fecha_asignacion DATE,
    asignado_por NVARCHAR(100),
    PRIMARY KEY (id_anuncio, id_subcategoria),
    FOREIGN KEY (id_anuncio) REFERENCES Anuncios(id_anuncio),
    FOREIGN KEY (id_subcategoria) REFERENCES Subcategorias(id_subcategoria)
);
GO
CREATE TABLE Ubicaciones (
    id_ubicacion INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(255),
    ciudad NVARCHAR(100),
    pais NVARCHAR(100),
    
);
GO
CREATE TABLE Anuncios_Ubicaciones (
    id_anuncio INT,
    id_ubicacion INT,
    fecha_asignacion DATE,
    asignado_por NVARCHAR(100),
    activo BIT ,
    PRIMARY KEY (id_anuncio, id_ubicacion),
    FOREIGN KEY (id_anuncio) REFERENCES Anuncios(id_anuncio),
    FOREIGN KEY (id_ubicacion) REFERENCES Ubicaciones(id_ubicacion)
);
GO
CREATE TABLE Imagenes_Anuncio (
    id_imagen INT PRIMARY KEY IDENTITY(1,1),
    url NVARCHAR(255) NOT NULL,
    id_anuncio INT,
    titulo NVARCHAR(100),
    FOREIGN KEY (id_anuncio) REFERENCES Anuncios(id_anuncio)
);
GO
CREATE TABLE Favoritos (
    id_usuario INT,
    id_anuncio INT,
    fecha_agregado DATE,
    notas NVARCHAR(255),
    activo BIT DEFAULT 1,
    PRIMARY KEY (id_usuario, id_anuncio),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_anuncio) REFERENCES Anuncios(id_anuncio)
);
GO
CREATE TABLE Mensajes (
    id_mensaje INT PRIMARY KEY IDENTITY(1,1),
    contenido NVARCHAR(MAX) NOT NULL,
    fecha_envio DATETIME,
    id_usuario_emisor INT,
    id_usuario_receptor INT,
    leido BIT ,
    FOREIGN KEY (id_usuario_emisor) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_usuario_receptor) REFERENCES Usuarios(id_usuario)
);
GO
CREATE TABLE Reportes_Anuncio (
    id_reporte INT PRIMARY KEY IDENTITY(1,1),
    motivo NVARCHAR(255) NOT NULL,
    fecha_reporte DATE,
    id_usuario INT,
    id_anuncio INT,
    estado bit ,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_anuncio) REFERENCES Anuncios(id_anuncio)
);
GO
CREATE TABLE Planes_Publicacion (
    id_plan INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    precio DECIMAL(10,2),
    duracion INT, 
    descripcion NVARCHAR(255)
);
GO
CREATE TABLE Pagos (
    id_pago INT PRIMARY KEY IDENTITY(1,1),
    monto DECIMAL(10,2) NOT NULL,
    fecha_pago DATE,
    id_usuario INT,
    id_plan INT,
    metodo_pago NVARCHAR(50),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_plan) REFERENCES Planes_Publicacion(id_plan)
);
GO