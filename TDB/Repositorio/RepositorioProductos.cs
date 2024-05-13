using Microsoft.EntityFrameworkCore;
using TDB.Modelos;  

namespace TDB.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly TortilleriaDBContext _context;
        private readonly RepositorioInventario _repositorioInventario;

        public RepositorioProductos(TortilleriaDBContext context, RepositorioInventario repositorioInventario)
        {
            _context = context;
            _repositorioInventario = repositorioInventario;
        }

        public async Task<Producto> Add(Producto producto)
        {
            _context.Producto.Add(producto);
            await _context.SaveChangesAsync();

            await _repositorioInventario.Add(new Inventario
            {
                ProductoId = producto.Id,
                Cantidad = 0 
            });

            return producto;
        }

        public async Task Delete(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            if (producto != null)
            {
                _context.Producto.Remove(producto);
                await _context.SaveChangesAsync();
            }
            await _repositorioInventario.Delete(id);
        }

        public async Task Update(Producto producto)
        {
            var productoActual = await _context.Producto.FindAsync(producto.Id);
            if (productoActual != null) { 
                productoActual.Nombre = producto.Nombre;
            productoActual.Descripcion = producto.Descripcion;
            productoActual.Precio = producto.Precio;
            productoActual.Categoria = producto.Categoria;
            await _context.SaveChangesAsync();
            }

        }

        public async Task<Producto?> Get(int id)
        {
            return await _context.Producto.FindAsync(id);
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Producto.ToListAsync();
        }

    }
}
