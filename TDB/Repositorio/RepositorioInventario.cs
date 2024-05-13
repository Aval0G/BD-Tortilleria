using Microsoft.EntityFrameworkCore;
using TDB.Modelos;

namespace TDB.Repositorio
{
    public class RepositorioInventario : IRepositorioInventario
    {
        private readonly TortilleriaDBContext _context;

        public RepositorioInventario(TortilleriaDBContext context)
        {
            _context = context;
        }

        public async Task<Inventario> Add(Inventario inventario)
        {
            _context.Inventario.Add(inventario);
            await _context.SaveChangesAsync();
            return inventario;
        }

        public async Task Delete(int id)
        {
            var inventario = await _context.Inventario.FindAsync(id);
            if (inventario != null)
            {
                _context.Inventario.Remove(inventario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Inventario inventario)
        {
            var inventarioActual = await _context.Inventario.FindAsync(inventario.Id);
            if (inventarioActual != null)
            {
                inventarioActual.Cantidad = inventario.Cantidad;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Inventario?> Get(int id)
        {
            return await _context.Inventario.FindAsync(id);
        }

        public async Task<List<Inventario>> GetAll()
        {
            return await _context.Inventario.ToListAsync();
        }
    }
}
