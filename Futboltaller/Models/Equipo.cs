using System.ComponentModel.DataAnnotations;

namespace Futboltaller.Models
{
    public class Equipo
    {
        [Key]
         public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]

    public string Ciudad { get; set; }
    public int Títulos { get; set; }
    public bool AceptaExtranjeros { get; set; }
    public String Estadio { get; set;}
    }
}
