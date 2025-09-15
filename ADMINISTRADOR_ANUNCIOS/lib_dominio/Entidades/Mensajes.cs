

namespace lib_dominio.Entidades
{
    public class Mensajes
    {
        public int MensajeID { get; set; }
        public string? Contenido { get; set; }
        public DateTime FechaEnvio { get; set; }

        public int UsuarioEmisorID { get; set; }
        public Usuarios Usuarios { get; set; } = null!;

        public int UsarioReceptorID { get; set; }
        public Usuarios UsuarioReceptorID { get; set; } = null!;

        public bool Leido { get; set; }
    }
}
