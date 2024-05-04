using System.ComponentModel.DataAnnotations;

namespace TDB.Modelos
{
    public class Proveedores
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Nombre { get; set; } = "";
        [Required (ErrorMessage = "El telefono es requerido")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string Telefono { get; set; } = "";
    }
}
