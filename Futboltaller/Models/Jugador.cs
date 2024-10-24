using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Futboltaller.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(100)]
        [Required]
        public string Posicion { get; set; }

        [Range(16, 37)]  // Rango de edades permitido
        public int Edad { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }

        public Equipo Equipo { get; set; }  // Relación con Equipo
    }
}
