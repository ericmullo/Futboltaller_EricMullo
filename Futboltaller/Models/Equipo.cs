using System.ComponentModel.DataAnnotations;

namespace Futboltaller.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }  // Cambié 'Id' a 'IdEquipo' para coherencia con tu código.

        [MaxLength(100)]
        [Required]  // Aseguramos que sea obligatorio
        public string NombreEquipo { get; set; }

        [MaxLength(100)]
        [Required]
        public string CiudadEquipo { get; set; }

        [Range(0, int.MaxValue)]  // Asegura que Titulos sea positivo o cero
        public int Titulos { get; set; }

        [Required]  // Asegura que este campo no esté vacío
        public string AceptaExtranjeros { get; set; }

        public string Estadio { get; set; }
    }
}
