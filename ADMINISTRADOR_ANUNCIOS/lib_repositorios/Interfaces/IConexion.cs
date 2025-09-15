using Azure;
using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }


        public DbSet<Anuncios> Anuncios { get; set; }
        public DbSet<AnunciosSubcategorias> AnunciosSubcategorias { get; set; }
        public DbSet<AnunciosUbicaciones> AnunciosUbicaciones { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<ImagenesAnuncios> ImagenesAnuncios { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<PlanesDePublicacion> PlanesDePublicacion { get; set; }
        public DbSet<ReportesDeAnuncios> ReportesDeAnuncios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Subcategorias> Subcategorias { get; set; }
        public DbSet<Ubicaciones> Ubicaciones { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<UsuariosRoles> UsuariosRoles { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
