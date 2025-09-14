using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net.NetworkInformation;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Usuarios>? Usuarios { get; set; }
        public DbSet<Roles>? Roles { get; set; }
        public DbSet<Pagos>? Pagos { get; set; }
        public DbSet<Ubicaciones>? Ubicaciones { get; set; }
        public DbSet<Subcategorias>? Subcategorias { get; set; }
        public DbSet<Favoritos>? Favoritos { get; set; }
        public DbSet<Mensajes>? Mensajes { get; set; }
        public DbSet<Anuncios>? Anuncios { get; set; }
    }
}