


namespace lib_dominio.Entidades
{
    public class Anuncios
    {
        public int AnuncioID { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public decimal  Precio {get;set;}
        public DateTime? FechaPublicacion { get; set; }
        public int UsuarioID { get; set; }
        public Usuarios Usuarios { get; set; } = null!;
        public bool Estado { get; set; }


        public List<Favoritos> Favoritos { get; set; } = new();
        public List<AnunciosSubcategorias> AnunciosSubcategorias { get; set; } = new();
        public List<AnunciosUbicaciones> AnunciosUbicaciones { get; set; } = new();
        public List<ImagenesAnuncios> ImagenesAnuncios { get; set; } = new();
        public List<ReportesDeAnuncios> ReportesDeAnuncios { get; set; } = new();
    }
}
