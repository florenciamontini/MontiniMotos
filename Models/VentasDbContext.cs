using Microsoft.EntityFrameworkCore;

namespace MontiniMotos.Models
{
    public class VentasDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public VentasDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LineaOrdenDeCompra> LineaOrdenDeCompras { get; set; }
        public DbSet<LineaSolicitudPedido> LineaSolicitudPedidos { get; set; }
        public DbSet<LineaVenta> LineaVentas { get; set; }
        public DbSet<OrdenDeCompra> OrdenDeCompras { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<SolicitudPedido> SolicitudPedidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }









    }
}
