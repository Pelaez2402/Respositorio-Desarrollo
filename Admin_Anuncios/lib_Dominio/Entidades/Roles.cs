

namespace lib_Dominio.Entidades
{
    public class Roles
    {
        public int id_rol { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }

         //id_rol INT PRIMARY KEY IDENTITY(1,1),
        //nombre NVARCHAR(50) NOT NULL,
        //descripcion NVARCHAR(255),
     //fecha_creacion DATE,
     //activo BIT default 1 
    }
}
