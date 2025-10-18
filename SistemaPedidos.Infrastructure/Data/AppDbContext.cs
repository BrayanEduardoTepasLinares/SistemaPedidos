using Microsoft.EntityFrameworkCore;
using SistemaPedidos.Domain.Entities;

namespace SistemaPedidos.Infrastructure.Data
{
    // AppDbContext hereda de DbContext de Entity Framework Core
    public class AppDbContext : DbContext
    {
        // Constructor requerido para inyección de dependencias
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets para cada entidad del Dominio
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración explícita de relaciones
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol) 
                .WithMany(r => r.Usuarios) 
                .HasForeignKey(u => u.RolId); 
                
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Usuario) 
                .WithMany(u => u.Pedidos) 
                .HasForeignKey(p => p.UsuarioId); 
            
        }
    }
}