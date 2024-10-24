using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Futboltaller.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }

        [MaxLength(100)]
        [Required]
        public string Direccion { get; set; }

        [MaxLength(100)]
        [Required]
        public string CiudadEstadio { get; set; }

        [Range(0, int.MaxValue)]  // Valida que Capacidad sea positiva
        public int Capacidad { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }

        public Equipo Equipo { get; set; }  // Relación con Equipo
    }
}
