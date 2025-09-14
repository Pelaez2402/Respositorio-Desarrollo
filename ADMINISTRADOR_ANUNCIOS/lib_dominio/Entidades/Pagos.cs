

namespace lib_dominio.Entidades
{
    public class Pagos
    {
        public int id_pago { get; set; }

        public decimal monto { get; set; }


        public int id_usuario { get; set; }

        public int id_plan { get; set; }

        public DateTime fecha_pago { get; set; }

        public string? metodo_pago { get; set; }



    }
}
