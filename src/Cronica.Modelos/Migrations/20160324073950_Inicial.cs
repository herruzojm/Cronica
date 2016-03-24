using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Cuenta = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Atributo",
                columns: table => new
                {
                    AtributoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Orden = table.Column<int>(nullable: false),
                    SubTipo = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributo", x => x.AtributoId);
                });
            migrationBuilder.CreateTable(
                name: "PostPartida",
                columns: table => new
                {
                    PostPartidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cerrada = table.Column<bool>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPartida", x => x.PostPartidaId);
                });
            migrationBuilder.CreateTable(
                name: "PlantillaTrama",
                columns: table => new
                {
                    PlantillaTramaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    PuntosDePresionPorTiemppo = table.Column<int>(nullable: false),
                    PuntosNecesarios = table.Column<int>(nullable: false),
                    TipoTrama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantillaTrama", x => x.PlantillaTramaId);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Clan = table.Column<int>(nullable: false),
                    Concepto = table.Column<string>(nullable: true),
                    Conducta = table.Column<string>(nullable: true),
                    Defectos = table.Column<string>(nullable: true),
                    Experiencia = table.Column<int>(nullable: false),
                    Generacion = table.Column<int>(nullable: false),
                    Historia = table.Column<string>(nullable: true),
                    JugadorId = table.Column<string>(nullable: true),
                    Meritos = table.Column<string>(nullable: true),
                    Naturaleza = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    PotenciaSangre = table.Column<int>(nullable: false),
                    PuntosDeSangre = table.Column<int>(nullable: false),
                    Senda = table.Column<int>(nullable: false),
                    ValorSenda = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_Personaje_ApplicationUser_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "PasaTrama",
                columns: table => new
                {
                    PasaTramaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaPrevista = table.Column<DateTime>(nullable: false),
                    FechaResolucion = table.Column<DateTime>(nullable: true),
                    PostPartidaId = table.Column<int>(nullable: false),
                    Resuelto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasaTrama", x => x.PasaTramaId);
                    table.ForeignKey(
                        name: "FK_PasaTrama_PostPartida_PostPartidaId",
                        column: x => x.PostPartidaId,
                        principalTable: "PostPartida",
                        principalColumn: "PostPartidaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AtributoPlantillaTrama",
                columns: table => new
                {
                    AtributoId = table.Column<int>(nullable: false),
                    PlantillaTramaId = table.Column<int>(nullable: false),
                    Multiplicador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributoPlantillaTrama", x => new { x.AtributoId, x.PlantillaTramaId });
                    table.ForeignKey(
                        name: "FK_AtributoPlantillaTrama_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId",
                        column: x => x.PlantillaTramaId,
                        principalTable: "PlantillaTrama",
                        principalColumn: "PlantillaTramaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Trama",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cerrada = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    PlantillaId = table.Column<int>(nullable: true),
                    PostPartidaPostPartidaId = table.Column<int>(nullable: true),
                    PuntosActuales = table.Column<int>(nullable: false),
                    PuntosDePresionPorTiemppo = table.Column<int>(nullable: false),
                    PuntosNecesarios = table.Column<int>(nullable: false),
                    TextoResolucion = table.Column<string>(nullable: true),
                    TipoTrama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trama", x => x.TramaId);
                    table.ForeignKey(
                        name: "FK_Trama_PlantillaTrama_PlantillaId",
                        column: x => x.PlantillaId,
                        principalTable: "PlantillaTrama",
                        principalColumn: "PlantillaTramaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trama_PostPartida_PostPartidaPostPartidaId",
                        column: x => x.PostPartidaPostPartidaId,
                        principalTable: "PostPartida",
                        principalColumn: "PostPartidaId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AtributoPersonaje",
                columns: table => new
                {
                    AtributoId = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    ValorEnTrama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributoPersonaje", x => new { x.AtributoId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_AtributoPersonaje_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoPersonaje_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "PersonaTrasfondo",
                columns: table => new
                {
                    PersonajeJugadorId = table.Column<int>(nullable: false),
                    TrasfondoRelacionadoId = table.Column<int>(nullable: false),
                    TipoRelacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaTrasfondo", x => new { x.PersonajeJugadorId, x.TrasfondoRelacionadoId });
                    table.ForeignKey(
                        name: "FK_PersonaTrasfondo_Personaje_PersonajeJugadorId",
                        column: x => x.PersonajeJugadorId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaTrasfondo_Personaje_TrasfondoRelacionadoId",
                        column: x => x.TrasfondoRelacionadoId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AtributoTrama",
                columns: table => new
                {
                    AtributoId = table.Column<int>(nullable: false),
                    TramaId = table.Column<int>(nullable: false),
                    Multiplicador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributoTrama", x => new { x.AtributoId, x.TramaId });
                    table.ForeignKey(
                        name: "FK_AtributoTrama_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoTrama_Trama_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Trama",
                        principalColumn: "TramaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "ParticipantesTrama",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false),
                    Equipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantesTrama", x => new { x.TramaId, x.PersonajeId, x.Equipo });
                    table.ForeignKey(
                        name: "FK_ParticipantesTrama_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantesTrama_Trama_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Trama",
                        principalColumn: "TramaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "PuntosPasaTrama",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false),
                    PasaTramaId = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    PuntosObtenidos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosPasaTrama", x => new { x.TramaId, x.PasaTramaId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PuntosPasaTrama_Trama_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Trama",
                        principalColumn: "TramaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");
            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName");
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("AtributoPersonaje");
            migrationBuilder.DropTable("PersonaTrasfondo");
            migrationBuilder.DropTable("PasaTrama");
            migrationBuilder.DropTable("AtributoPlantillaTrama");
            migrationBuilder.DropTable("AtributoTrama");
            migrationBuilder.DropTable("ParticipantesTrama");
            migrationBuilder.DropTable("PuntosPasaTrama");
            migrationBuilder.DropTable("AspNetRoleClaims");
            migrationBuilder.DropTable("AspNetUserClaims");
            migrationBuilder.DropTable("AspNetUserLogins");
            migrationBuilder.DropTable("AspNetUserRoles");
            migrationBuilder.DropTable("Atributo");
            migrationBuilder.DropTable("Personaje");
            migrationBuilder.DropTable("Trama");
            migrationBuilder.DropTable("AspNetRoles");
            migrationBuilder.DropTable("AspNetUsers");
            migrationBuilder.DropTable("PlantillaTrama");
            migrationBuilder.DropTable("PostPartida");
        }
    }
}
