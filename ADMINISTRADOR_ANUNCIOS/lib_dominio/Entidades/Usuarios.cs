
namespace lib_dominio.Entidades
{
    public class Usuarios
    {
        public int UsuarioID { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }


        public List<Anuncios> Anuncios { get; set; } = new();
        public List<UsuariosRoles> UsuariosRoles { get; set; } = new();
        public List<Favoritos> Favoritos { get; set; } = new();
        public List<Mensajes> Mensajes { get; set; } = new();
        public List<Pagos> Pagos { get; set; } = new();
        public List<ReportesDeAnuncios> ReportesDeAnuncios { get; set; } = new();
    }
}
