using System.ComponentModel.DataAnnotations;

namespace TDB.Modelos
{
    public class Inventario
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El id de producto es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de producto debe ser mayor a 0")]

        public int IdProducto { get; set; }
        [Required (ErrorMessage = "La cantidad es requerida")]
        [Range(0, 1000000, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int Cantidad { get; set; }
    }
}
