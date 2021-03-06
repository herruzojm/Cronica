﻿using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Cronica.Modelos.ViewModels.Mensajeria;
using Cronica.Modelos.ViewModels.Manage;

namespace Cronica.Modelos.Models
{
    public class CronicaDbContext : ApplicationDbContext
    {
        public CronicaDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> Usuarios { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
        public DbSet<PlantillaTrama> PlantillasTrama { get; set; }
        public DbSet<EntrePartida> EntrePartidas { get; set; }
        public DbSet<Trama> Tramas { get; set; }
        public DbSet<Interludio> Interludios { get; set; }
        public DbSet<PersonaTrasfondo> Seguidores { get; set; }
        public DbSet<ParticipantesTrama> ParticipantesTrama{ get; set; }
        public DbSet<PuntosInterludio> PuntosInterludio { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }
        public DbSet<PersonajeAsignacion> PersonajeAsignacion { get; set; }
        public DbSet<FormularioPostPartida> FormulariosPostPartida { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<DestinatarioMensaje> DestinatariosMensaje { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }



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

            builder.Entity<PuntosInterludio>()
                .HasKey(a => new { a.TramaId, a.InterludioId, a.PersonajeId });

            builder.Entity<ParticipantesTrama>()
                .HasKey(a => new { a.TramaId, a.PersonajeId, a.Equipo });            
        }
    }
}
