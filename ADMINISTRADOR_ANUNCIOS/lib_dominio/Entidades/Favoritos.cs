

namespace lib_dominio.Entidades
{
    public  class Favoritos
    {
        public int UsuarioID { get; set; }
        public Usuarios Usuarios { get; set; } = null!;

        public int AnuncioID { get; set; }
        public Anuncios Anuncios { get; set; } = null!;
        public DateTime FechaAgregado { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }



    }
}
