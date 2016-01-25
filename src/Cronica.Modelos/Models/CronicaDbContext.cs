using Cronica.Modelos.ViewModels.Trama;
using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
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
        public DbSet<PlantillaTrama> PlantillasTrama { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AtributoPersonaje>()
                .HasKey(p => new { p.AtributoId, p.PersonajeId });

            builder.Entity<PersonaTrasfondo>()
                .HasKey(p=> new { p.PersonajeJugadorId, p.TrasfondoRelacionadoId });

            builder.Entity<PersonaTrasfondo>()
                .HasOne(p => p.PersonajeJugador)
                .WithMany(p => p.Trasfondos)
                .HasForeignKey(p => p.PersonajeJugadorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PersonaTrasfondo>()
                .HasOne(p => p.TrasfondoRelacionado)
                .WithMany(p => p.PersonajesJugadores)
                .HasForeignKey(p => p.TrasfondoRelacionadoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AtributoPlantillaTrama>()
                .HasKey(a => new { a.AtributoId, a.PlantillaTramaId });
        }
    }
}
