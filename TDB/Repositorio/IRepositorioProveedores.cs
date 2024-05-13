using TDB.Modelos;

namespace TDB.Repositorio
{
    public interface IRepositorioProveedores
    {
        Task<List<Proveedores>> GetAll();
        Task<Proveedores?> Get(int id);
        Task<Proveedores> Add(Proveedores proveedor);
        Task Update(Proveedores proveedor);
        Task Delete(int id);
    }
}
