﻿using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.ViewModels.GestionPersonajes;
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
        public DbSet<Trama> Tramas { get; set; }
        public DbSet<PasaTrama> PasaTramas { get; set; }
        public DbSet<PersonaTrasfondo> Seguidores { get; set; }

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
                .WithMany(p => p.Seguidores)
                .HasForeignKey(p => p.PersonajeJugadorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PersonaTrasfondo>()
                .HasOne(p => p.TrasfondoRelacionado)
                .WithMany(p => p.PersonajesJugadores)
                .HasForeignKey(p => p.TrasfondoRelacionadoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AtributoPlantillaTrama>()
                .HasKey(a => new { a.AtributoId, a.PlantillaTramaId });

            builder.Entity<AtributoTrama>()
                .HasKey(a => new { a.AtributoId, a.TramaId });

            builder.Entity<PuntosPasaTrama>()
                .HasKey(a => new { a.TramaId, a.PasaTramaId });
        }
    }
}
