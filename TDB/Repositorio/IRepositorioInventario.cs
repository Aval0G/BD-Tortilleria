using TDB.Modelos;

namespace TDB.Repositorio
{
    public interface IRepositorioInventario
    {
        Task<List<Inventario>> GetAll();
        Task<Inventario?> Get(int id);

        Task<Inventario> Add(Inventario inventario);
        Task Update(Inventario inventario);
        Task Delete(int id);
    }
 }
