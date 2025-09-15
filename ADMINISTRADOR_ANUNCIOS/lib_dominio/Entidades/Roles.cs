

namespace lib_dominio.Entidades
{
    public class Roles
    {
        public int RolID { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public List<UsuariosRoles> UsuariosRoles { get; set; } = new();
    }
}
