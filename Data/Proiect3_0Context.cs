using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect3._0.Models;

namespace Proiect3._0.Data
{
    public class Proiect3_0Context : DbContext
    {
        public Proiect3_0Context (DbContextOptions<Proiect3_0Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect3._0.Models.Spectacol> Spectacol { get; set; } = default!;
        public DbSet<Proiect3._0.Models.Locatia> Locatia { get; set; } = default!;
        public DbSet<Proiect3._0.Models.Regizor> Regizor { get; set; } = default!;
        public DbSet<Proiect3._0.Models.Tip> Tip { get; set; } = default!;
        public DbSet<Proiect3._0.Models.Membru> Membru { get; set; } = default!;
        public DbSet<Proiect3._0.Models.Participare> Participare { get; set; } = default!;
    }
}
