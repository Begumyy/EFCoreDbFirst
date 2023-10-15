using Microsoft.EntityFrameworkCore;
using ReceteSB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteSB.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=.;Database=ReceteSB;Integrated Security=True;TrustServerCertificate=True");

        public virtual DbSet<Doktor>Doktorlar { get; set; }
        public virtual DbSet<Ilac> Ilaclar { get; set; }
        public virtual DbSet<KullanimSekli> KullanimSekilleri { get; set; }
        public virtual DbSet<Recete> Receteler { get; set; }
        public virtual DbSet<ReceteIlac> ReceteIlaclar { get; set; }
        public virtual DbSet<Tani> Tanilar { get; set; }

    }
}
