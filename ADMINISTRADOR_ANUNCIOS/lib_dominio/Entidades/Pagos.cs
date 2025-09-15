

namespace lib_dominio.Entidades
{
    public class Pagos
    {
        public int PagoID { get; set; }

        public decimal Monto { get; set; }


        public int UsuarioID { get; set; }
        public Usuarios Usuarios { get; set; } = null!;
        public int PlanID { get; set; }
        public PlanesDePublicacion PlanesDePublicacion { get; set; } = null!;
        public DateTime FechaPago { get; set; }

        public string? MetodoPago { get; set; }

        

    }
}
