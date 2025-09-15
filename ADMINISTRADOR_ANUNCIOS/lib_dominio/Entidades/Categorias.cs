

namespace lib_dominio.Entidades
{
    public  class Categorias
    {
        public int CategoriaID { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public List<Subcategorias> Subcategorias { get; set; } = new();
    }
}
