

namespace lib_dominio.Entidades
{
    public  class Favoritos
    {
        public int id_usuario { get; set; }

        public int id_anuncio { get; set; }

        public DateTime fecha_agregado { get; set; }

        public string? notas { get; set; }

        public bool activo { get; set; }



    }
}
