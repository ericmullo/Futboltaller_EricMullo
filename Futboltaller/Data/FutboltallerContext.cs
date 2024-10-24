using Microsoft.EntityFrameworkCore;
using Futboltaller.Models;

namespace Futboltaller.Data
{
    public class TallerFutbolContext : DbContext
    {
        public TallerFutbolContext(DbContextOptions<TallerFutbolContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
    }
}
