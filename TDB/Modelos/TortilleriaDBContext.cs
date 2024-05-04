using Microsoft.EntityFrameworkCore;

namespace TDB.Modelos
{
    public class TortilleriaDBContext : DbContext
    {
        public TortilleriaDBContext(DbContextOptions<TortilleriaDBContext> options) : base(options)
        {
        }

        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Producto> Producto  { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Producto_Proveedor> Proveedores_Producto { get; set; }   
    }
}
