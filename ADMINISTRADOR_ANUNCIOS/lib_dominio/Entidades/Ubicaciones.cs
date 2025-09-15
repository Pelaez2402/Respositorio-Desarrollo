    
namespace lib_dominio.Entidades
{
    public class Ubicaciones
    {
        public int UbicacionID { get; set; }

        public string? Nombre { get; set; }

        public string? Direccion { get; set; }

        public string? Ciudad { get; set; }
        public string? Pais { get; set; }

        public List<AnunciosUbicaciones> AnunciosUbicaciones { get; set; } = new();


    }
}
