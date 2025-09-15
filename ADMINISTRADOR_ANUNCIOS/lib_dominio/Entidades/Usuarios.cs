
namespace lib_dominio.Entidades
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? contraseña { get; set; }
        public string? telefono { get; set; }
        public DateTime fecha_registro { get; set; }


        public List<Anuncios> Anuncios { get; set; } = new();
        public List<UsuariosRoles> UsuariosRoles { get; set; } = new();
        public List<Favoritos> Favoritos { get; set; } = new();
    }
}
