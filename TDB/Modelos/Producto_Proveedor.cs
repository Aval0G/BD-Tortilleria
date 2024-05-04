using System.ComponentModel.DataAnnotations;

namespace TDB.Modelos
{
    public class Producto_Proveedor
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El id de producto es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de producto debe ser mayor a 0")]
        public int IdProducto { get; set; }
        [Required (ErrorMessage = "El id de proveedor es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de proveedor debe ser mayor a 0")]
        public int IdProveedor { get; set; }
    }
}
