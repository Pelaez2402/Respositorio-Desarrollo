namespace lib_dominio.Entidades
{
    public class ReportesDeAnuncios
    {
        public int ReporteID { get; set; }
        public string? motivo { get; set; }
        public DateTime FechaReporte { get; set; }

        public int UsuarioID { get; set; }
        public Usuarios Usuarios { get; set; } = null!;

        public int AnuncioID { get; set; }
        public Anuncios Anuncio { get; set; } = null!;

        public bool Estado { get; set; }
    }
}
