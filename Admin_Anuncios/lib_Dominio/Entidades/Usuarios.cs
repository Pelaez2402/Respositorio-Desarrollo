

namespace lib_Dominio.Entidades
{
    public class Usuarios
    {
            public int id_usuario { get; set; }
            public string? nombre{ get; set; }
            public string? correo { get; set; }
            public string? contraseña { get; set; }
            public string? telefono { get; set; }
            public DateTime fecha_registro { get; set; }
    
        }
}
