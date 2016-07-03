using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Cronica.Modelos.Models;

namespace Cronica.Migrations
{
    [DbContext(typeof(CronicaDbContext))]
    partial class CronicaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cronica.Modelos.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("Cuenta");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo", b =>
                {
                    b.Property<int>("AtributoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<int>("Orden");

                    b.Property<int>("SubTipo");

                    b.Property<int>("Tipo");

                    b.HasKey("AtributoId");

                    b.ToTable("Atributos");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.AtributoPersonaje", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("PersonajeId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Valor");

                    b.Property<int>("ValorEnTrama");

                    b.HasKey("AtributoId", "PersonajeId");

                    b.HasIndex("AtributoId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("AtributoPersonaje");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activo");

                    b.Property<int>("Clan");

                    b.Property<string>("Concepto");

                    b.Property<string>("Conducta");

                    b.Property<string>("Defectos");

                    b.Property<int>("Experiencia");

                    b.Property<string>("Foto");

                    b.Property<int>("Generacion");

                    b.Property<string>("Historia");

                    b.Property<string>("JugadorId");

                    b.Property<string>("Meritos");

                    b.Property<string>("Naturaleza");

                    b.Property<string>("Nombre");

                    b.Property<int>("PotenciaSangre");

                    b.Property<int>("PuntosDeSangre");

                    b.Property<int>("Senda");

                    b.Property<int>("ValorSenda");

                    b.Property<string>("Virtud");

                    b.Property<int>("Voluntad");

                    b.HasKey("PersonajeId");

                    b.HasIndex("JugadorId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.PersonaTrasfondo", b =>
                {
                    b.Property<int>("PersonajeJugadorId");

                    b.Property<int>("TrasfondoRelacionadoId");

                    b.Property<int>("TipoRelacion");

                    b.HasKey("PersonajeJugadorId", "TrasfondoRelacionadoId");

                    b.HasIndex("PersonajeJugadorId");

                    b.HasIndex("TrasfondoRelacionadoId");

                    b.ToTable("Seguidores");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.Asignacion", b =>
                {
                    b.Property<int>("AsignacionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PasaTramaId");

                    b.Property<int>("PersonajeId");

                    b.HasKey("AsignacionId");

                    b.HasIndex("PasaTramaId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("Asignaciones");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.FormularioPostPartida", b =>
                {
                    b.Property<int>("FormularioPostPartidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Acuerdos");

                    b.Property<string>("ComentariosNarrador");

                    b.Property<string>("CosasBien");

                    b.Property<string>("CosasMal");

                    b.Property<bool>("Enviado");

                    b.Property<DateTime>("FechaEnvio");

                    b.Property<string>("InformacionClave");

                    b.Property<string>("JugadorId");

                    b.Property<string>("NarradorEncargadoId");

                    b.Property<int>("PersonajeId");

                    b.Property<string>("PeticionTramas");

                    b.Property<int>("PostPartidaId");

                    b.Property<string>("Resumen")
                        .HasAnnotation("MaxLength", 9000);

                    b.Property<bool>("Tramitado");

                    b.Property<int>("ValoracionPartida");

                    b.HasKey("FormularioPostPartidaId");

                    b.HasIndex("JugadorId");

                    b.HasIndex("NarradorEncargadoId");

                    b.HasIndex("PersonajeId");

                    b.HasIndex("PostPartidaId");

                    b.ToTable("FormulariosPostPartida");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", b =>
                {
                    b.Property<int>("PasaTramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Actual");

                    b.Property<DateTime>("FechaPrevista");

                    b.Property<DateTime?>("FechaResolucion");

                    b.Property<int>("PostPartidaId");

                    b.Property<bool>("Resuelto");

                    b.HasKey("PasaTramaId");

                    b.HasIndex("PostPartidaId");

                    b.ToTable("PasaTramas");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PersonajeAsignacion", b =>
                {
                    b.Property<int>("PersonajeAsignacionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AsignacionId");

                    b.Property<int>("PersonajeId");

                    b.Property<int>("PuntosParticipacion");

                    b.Property<int>("TramaId");

                    b.HasKey("PersonajeAsignacionId");

                    b.HasIndex("AsignacionId");

                    b.HasIndex("PersonajeId");

                    b.HasIndex("TramaId");

                    b.ToTable("PersonajeAsignacion");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PostPartida", b =>
                {
                    b.Property<int>("PostPartidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activa");

                    b.Property<bool>("Cerrada");

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.HasKey("PostPartidaId");

                    b.ToTable("PostPartidas");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoPlantillaTrama", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("PlantillaTramaId");

                    b.Property<int>("Multiplicador");

                    b.HasKey("AtributoId", "PlantillaTramaId");

                    b.HasIndex("AtributoId");

                    b.HasIndex("PlantillaTramaId");

                    b.ToTable("AtributoPlantillaTrama");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoTrama", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("TramaId");

                    b.Property<int>("Multiplicador");

                    b.HasKey("AtributoId", "TramaId");

                    b.HasIndex("AtributoId");

                    b.HasIndex("TramaId");

                    b.ToTable("AtributoTrama");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.ParticipantesTrama", b =>
                {
                    b.Property<int>("TramaId");

                    b.Property<int>("PersonajeId");

                    b.Property<int>("Equipo");

                    b.HasKey("TramaId", "PersonajeId", "Equipo");

                    b.HasIndex("PersonajeId");

                    b.HasIndex("TramaId");

                    b.ToTable("ParticipantesTrama");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama", b =>
                {
                    b.Property<int>("PlantillaTramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<int>("PuntosDePresionPorTiemppo");

                    b.Property<int>("PuntosNecesarios");

                    b.Property<int>("TipoTrama");

                    b.HasKey("PlantillaTramaId");

                    b.ToTable("PlantillasTrama");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PuntosPasaTrama", b =>
                {
                    b.Property<int>("TramaId");

                    b.Property<int>("PasaTramaId");

                    b.Property<int>("PersonajeId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("PuntosObtenidos");

                    b.HasKey("TramaId", "PasaTramaId", "PersonajeId");

                    b.HasIndex("PasaTramaId");

                    b.HasIndex("TramaId");

                    b.ToTable("PuntosPasaTrama");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.Trama", b =>
                {
                    b.Property<int>("TramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cerrada");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<int?>("PlantillaId");

                    b.Property<int?>("PostPartidaId");

                    b.Property<int>("PuntosActuales");

                    b.Property<int>("PuntosDePresionPorTiemppo");

                    b.Property<int>("PuntosNecesarios");

                    b.Property<string>("TextoResolucion");

                    b.Property<int>("TipoTrama");

                    b.HasKey("TramaId");

                    b.HasIndex("PlantillaId");

                    b.HasIndex("PostPartidaId");

                    b.ToTable("Tramas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.AtributoPersonaje", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo", "Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje")
                        .WithMany("Atributos")
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.PersonaTrasfondo", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "PersonajeJugador")
                        .WithMany("Seguidores")
                        .HasForeignKey("PersonajeJugadorId");

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "TrasfondoRelacionado")
                        .WithMany("PersonajesJugadores")
                        .HasForeignKey("TrasfondoRelacionadoId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.Asignacion", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", "PasaTrama")
                        .WithMany()
                        .HasForeignKey("PasaTramaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.FormularioPostPartida", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorId");

                    b.HasOne("Cronica.Modelos.Models.ApplicationUser", "NarradorEncargado")
                        .WithMany()
                        .HasForeignKey("NarradorEncargadoId");

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PostPartida", "PostPartida")
                        .WithMany()
                        .HasForeignKey("PostPartidaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PostPartida", "PostPartida")
                        .WithMany("PasaTramas")
                        .HasForeignKey("PostPartidaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PersonajeAsignacion", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.Asignacion", "Asignacion")
                        .WithMany("Asignaciones")
                        .HasForeignKey("AsignacionId");

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama", "Trama")
                        .WithMany()
                        .HasForeignKey("TramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoPlantillaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo", "Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama")
                        .WithMany("Atributos")
                        .HasForeignKey("PlantillaTramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo", "Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama")
                        .WithMany("Atributos")
                        .HasForeignKey("TramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.ParticipantesTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", "Personaje")
                        .WithMany("TramasParticipadas")
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama", "Trama")
                        .WithMany("Participantes")
                        .HasForeignKey("TramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PuntosPasaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", "PasaTrama")
                        .WithMany()
                        .HasForeignKey("PasaTramaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama")
                        .WithMany("Puntos")
                        .HasForeignKey("TramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.Trama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama", "Plantilla")
                        .WithMany()
                        .HasForeignKey("PlantillaId");

                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PostPartida")
                        .WithMany("TramasActivas")
                        .HasForeignKey("PostPartidaId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
