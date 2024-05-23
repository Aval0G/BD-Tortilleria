using System.ComponentModel.DataAnnotations;

namespace TDB.Modelos
{ 
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion del producto es requerida")]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(1, 1000000, ErrorMessage = "El precio debe ser mayor a 0")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Categoria { get; set; }

        public virtual Inventario Inventario { get; set; }
    }
}