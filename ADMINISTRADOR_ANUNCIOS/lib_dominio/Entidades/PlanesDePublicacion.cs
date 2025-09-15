    

namespace lib_dominio.Entidades
{
    public class PlanesDePublicacion
    {
        public int PlanID { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }
        public string? Descripcion { get; set; }

        public List<Pagos> Pagos { get; set; } = new();
    }
}
