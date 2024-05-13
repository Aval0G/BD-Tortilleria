using Microsoft.EntityFrameworkCore;
using TDB.Modelos;

namespace TDB.Repositorio
{
    public class RepositorioProducto_Proveedor : IRepositorioProducto_Proveedor
    {
        private readonly TortilleriaDBContext _context;

        public RepositorioProducto_Proveedor(TortilleriaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Producto_Proveedor>> GetAll()
        {
            return await _context.Proveedores_Producto.ToListAsync();
        }

        public async Task<Producto_Proveedor?> Get(int id)
        {
            return await _context.Proveedores_Producto.FindAsync(id);
        }

        public async Task<Producto_Proveedor> Add(Producto_Proveedor producto_proveedor)
        {
            _context.Proveedores_Producto.Add(producto_proveedor);
            await _context.SaveChangesAsync();
            return producto_proveedor;
        }

        public async Task Update(Producto_Proveedor producto_proveedor)
        {
            _context.Entry(producto_proveedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var producto_proveedor = await _context.Proveedores_Producto.FindAsync(id);
            if (producto_proveedor != null)
            {
                _context.Proveedores_Producto.Remove(producto_proveedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
