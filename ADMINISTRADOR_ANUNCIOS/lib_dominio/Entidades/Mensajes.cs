

namespace lib_dominio.Entidades
{
    public class Mensajes
    {
        public int id_mensaje { get; set; }

        public int id_usuario_emisor { get; set; }

        public int id_usuario_receptor { get; set; }

        public string? contenido { get; set; }

        public DateTime fecha_envio { get; set; }



    }
}
