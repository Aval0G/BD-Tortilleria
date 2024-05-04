using TDB.Modelos;

namespace TDB.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int id);
        Task<Producto> Add(Producto producto);
        Task Update(Producto producto);
        Task Delete(int id);
    }
}
