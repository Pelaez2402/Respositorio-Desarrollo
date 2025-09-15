
namespace lib_dominio.Entidades
{
    public class AnunciosSubcategorias
    {
        public int AnuncioID { get; set; }
        public Anuncios Anuncios { get; set; } = null!;

        public int SubcategoriaID { get; set; }
        public Subcategorias Subcategorias { get; set; } = null!;

        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }
    }
}
