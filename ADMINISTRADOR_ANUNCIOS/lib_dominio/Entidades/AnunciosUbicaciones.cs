namespace lib_dominio.Entidades
{
    public class AnunciosUbicaciones
    {
        public int AnuncioID { get; set; }
        public Anuncios Anuncios { get; set; } = null!;

        public int UbicacionID { get; set; }
        public Ubicaciones Ubicaciones { get; set; } = null!;

        public DateTime FechaAsignacion { get; set; }
        public string? AsignadoPor { get; set; }
        public bool Activo { get; set; }
    }
}
