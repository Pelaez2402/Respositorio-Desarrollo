

namespace lib_dominio.Entidades
{
    public class Anuncios
    {
        public int id_anuncio { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public decimal  precio {get;set;}
        public DateTime? fecha_publicacion { get; set; }
        public int id_usuario { get; set; }
        public bool estado { get; set; }
         
            
    }
}
