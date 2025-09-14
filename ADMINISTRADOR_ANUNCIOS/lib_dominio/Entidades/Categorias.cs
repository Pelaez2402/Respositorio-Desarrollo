

namespace lib_dominio.Entidades
{
    public  class Categorias
    {
        public int id_categoria { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha_creacion { get; set; }
        public bool activo { get; set; }
        
    }
}
