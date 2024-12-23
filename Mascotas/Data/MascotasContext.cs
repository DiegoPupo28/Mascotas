using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mascotas.Models;

namespace Mascotas.Data
{
    public class MascotasContext : DbContext
    {
        public MascotasContext (DbContextOptions<MascotasContext> options)
            : base(options)
        {
        }

        public DbSet<Mascotas.Models.Mascota> Mascota { get; set; } = default!;
    }
}
