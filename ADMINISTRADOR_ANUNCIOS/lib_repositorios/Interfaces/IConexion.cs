using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Usuarios>? Usuarios { get; set; }
        DbSet<Roles>? Roles  { get; set; }
        DbSet<Pagos>? Pagos { get; set; }
        DbSet<Ubicaciones>? Ubicaciones { get; set; }
        DbSet<Subcategorias>? Subcategorias { get; set; }
        DbSet<Favoritos>? Favoritos { get; set; }
        DbSet<Mensajes>? Mensajes { get; set; }
        DbSet<Anuncios>? Anuncios { get; set; }
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
