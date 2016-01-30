using Cronica.Modelos.ViewModels.PostPartida;
using Cronica.Modelos.ViewModels.Trama;
using Cronica.Modelos.ViewModels.GestionPersonaje;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Models
{
    public class CronicaDbContext : ApplicationDbContext
    {
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
        public DbSet<PlantillaTrama> PlantillasTrama { get; set; }
        public DbSet<PostPartida> PostPartidas { get; set; }

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

            builder.Entity<AtributoTramaActiva>()
                .HasKey(a => new { a.AtributoId, a.TramaActivaId });

            builder.Entity<PuntosPasaTrama>()
                .HasKey(a => new { a.TramaActivaId, a.PasaTramaId });
        }
    }
}
