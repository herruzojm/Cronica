using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Models
{
    public class CronicaDbContext : ApplicationDbContext
    {
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Atributo> Atributos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
