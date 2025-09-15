

namespace lib_dominio.Entidades
{
    public class Subcategorias
    {
        public int SubcategoriaID { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int CategoriaID { get; set; }
        public Categorias Categorias { get; set; } = null!;

        public List<AnunciosSubcategorias> AnunciosSubcategorias { get; set; } = new();


    }
}
