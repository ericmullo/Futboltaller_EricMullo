using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Futboltaller.Models;

namespace Futboltaller.Data
{
    public class FutboltallerContext : DbContext
    {
        public FutboltallerContext (DbContextOptions<FutboltallerContext> options)
            : base(options)
        {
        }

        public DbSet<Futboltaller.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Futboltaller.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Futboltaller.Models.Jugador> Jugador { get; set; } = default!;
    }
}
