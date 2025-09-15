

using System;

namespace lib_dominio.Entidades
{
    public class ImagenesAnuncios
    {
        public int ImagenID { get; set; }
        public string? url { get; set; }
        public int AnuncioID{get;set;}
        public Anuncios Anuncios { get; set; } = null!;
        public string? Titulo { get; set; }
    
    }
}
