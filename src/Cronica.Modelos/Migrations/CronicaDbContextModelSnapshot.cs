using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Cronica.Modelos.Models;

namespace Cronica.Modelos.Migrations
{
    [DbContext(typeof(CronicaDbContext))]
    partial class CronicaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
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
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo", b =>
                {
                    b.Property<int>("AtributoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<int>("SubTipo");

                    b.Property<int>("Tipo");

                    b.HasKey("AtributoId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.AtributoPersonaje", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("PersonajeId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Valor");

                    b.Property<int>("ValorEnTrama");

                    b.HasKey("AtributoId", "PersonajeId");
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

                    b.HasKey("PersonajeId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.PersonaTrasfondo", b =>
                {
                    b.Property<int>("PersonajeJugadorId");

                    b.Property<int>("TrasfondoRelacionadoId");

                    b.Property<int>("TipoRelacion");

                    b.HasKey("PersonajeJugadorId", "TrasfondoRelacionadoId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", b =>
                {
                    b.Property<int>("PasaTramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaPrevista");

                    b.Property<DateTime?>("FechaResolucion");

                    b.Property<int>("PostPartidaId");

                    b.Property<bool>("Resuelto");

                    b.HasKey("PasaTramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PostPartida", b =>
                {
                    b.Property<int>("PostPartidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cerrada");

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.HasKey("PostPartidaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoPlantillaTrama", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("PlantillaTramaId");

                    b.Property<int>("Multiplicador");

                    b.HasKey("AtributoId", "PlantillaTramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoTrama", b =>
                {
                    b.Property<int>("AtributoId");

                    b.Property<int>("TramaId");

                    b.Property<int>("Multiplicador");

                    b.HasKey("AtributoId", "TramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama", b =>
                {
                    b.Property<int>("PlantillaTramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<int>("PuntosDePresionPorTiemppo");

                    b.Property<int>("PuntosNecesarios");

                    b.HasKey("PlantillaTramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PuntosPasaTrama", b =>
                {
                    b.Property<int>("TramaId");

                    b.Property<int>("PasaTramaId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("PuntosObtenidos");

                    b.HasKey("TramaId", "PasaTramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.Trama", b =>
                {
                    b.Property<int>("TramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cerrada");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<int>("PersonajeId");

                    b.Property<int?>("PlantillaId");

                    b.Property<int?>("PostPartidaPostPartidaId");

                    b.Property<int>("PuntosActuales");

                    b.Property<int>("PuntosDePresionPorTiemppo");

                    b.Property<int>("PuntosNecesarios");

                    b.Property<string>("TextoResolucion");

                    b.HasKey("TramaId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
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
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.AtributoPersonaje", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId");

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("JugadorId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.GestionPersonajes.PersonaTrasfondo", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeJugadorId");

                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje")
                        .WithMany()
                        .HasForeignKey("TrasfondoRelacionadoId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.PostPartidas.PasaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PostPartida")
                        .WithMany()
                        .HasForeignKey("PostPartidaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoPlantillaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId");

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama")
                        .WithMany()
                        .HasForeignKey("PlantillaTramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.AtributoTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Atributo")
                        .WithMany()
                        .HasForeignKey("AtributoId");

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama")
                        .WithMany()
                        .HasForeignKey("TramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.PuntosPasaTrama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.Trama")
                        .WithMany()
                        .HasForeignKey("TramaId");
                });

            modelBuilder.Entity("Cronica.Modelos.ViewModels.Tramas.Trama", b =>
                {
                    b.HasOne("Cronica.Modelos.ViewModels.GestionPersonajes.Personaje")
                        .WithMany()
                        .HasForeignKey("PersonajeId");

                    b.HasOne("Cronica.Modelos.ViewModels.Tramas.PlantillaTrama")
                        .WithMany()
                        .HasForeignKey("PlantillaId");

                    b.HasOne("Cronica.Modelos.ViewModels.PostPartidas.PostPartida")
                        .WithMany()
                        .HasForeignKey("PostPartidaPostPartidaId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Cronica.Modelos.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
