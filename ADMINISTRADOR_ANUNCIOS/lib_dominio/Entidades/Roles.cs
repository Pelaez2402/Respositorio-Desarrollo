

namespace lib_dominio.Entidades
{
    public class Roles
    {
        public int id_rol { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public DateTime? fecha_creacion { get; set; }
        public bool activo { get; set; }
    }
}
