using Microsoft.EntityFrameworkCore;
using TDB.Modelos;

namespace TDB.Repositorio
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly TortilleriaDBContext _context;

        public RepositorioProveedores(TortilleriaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Proveedores>> GetAll()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<Proveedores?> Get(int id)
        {
            return await _context.Proveedores.FindAsync(id);
        }

        public async Task<Proveedores> Add(Proveedores proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task Update(Proveedores proveedor)
        {
            _context.Entry(proveedor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }   
    }
}
