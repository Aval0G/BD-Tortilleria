using TDB.Modelos;

namespace TDB.Repositorio
{
    public interface IRepositorioProducto_Proveedor
    {
        Task<List<Producto_Proveedor>> GetAll();
        Task<Producto_Proveedor?> Get(int id);

        Task<Producto_Proveedor> Add(Producto_Proveedor producto_proveedor);
        Task Update(Producto_Proveedor producto_proveedor);
        Task Delete(int id);
    }
}
