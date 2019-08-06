using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VjezbaCRUD.EntityModels;

namespace VjezbaCRUD.EF
{
    public class MyContext:DbContext
    {

        public DbSet<Kupac> Kupac { get; set; }

        public DbSet<Faktura> Faktura { get; set; }
            
        public DbSet<Opstina> Opstina { get; set; }

        public DbSet<Proizvod> Proizvod { get; set; }

        public DbSet<StavkaFakture> StavkaFakture { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RS1_online_3;Trusted_Connection=False;MultipleActiveResultSets=true;User ID=sa;Password=root;");
        }

    }
}
