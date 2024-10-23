using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Futboltaller.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Dirección { get; set; }
        [MaxLength(100)]
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }



    }
}
