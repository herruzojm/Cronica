using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

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
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atributos",
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
                    table.PrimaryKey("PK_Atributos", x => x.AtributoId);
                });

            migrationBuilder.CreateTable(
                name: "EntrePartidas",
                columns: table => new
                {
                    EntrePartidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activa = table.Column<bool>(nullable: false),
                    Cerrada = table.Column<bool>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrePartidas", x => x.EntrePartidaId);
                });

            migrationBuilder.CreateTable(
                name: "PlantillasTrama",
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
                    table.PrimaryKey("PK_PlantillasTrama", x => x.PlantillaTramaId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
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
                    Foto = table.Column<string>(nullable: true),
                    Generacion = table.Column<int>(nullable: false),
                    Historia = table.Column<string>(nullable: true),
                    JugadorId = table.Column<string>(nullable: true),
                    Meritos = table.Column<string>(nullable: true),
                    Naturaleza = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    PotenciaSangre = table.Column<int>(nullable: false),
                    PuntosDeSangre = table.Column<int>(nullable: false),
                    Senda = table.Column<int>(nullable: false),
                    ValorSenda = table.Column<int>(nullable: false),
                    Virtud = table.Column<string>(nullable: true),
                    Voluntad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_Personajes_AspNetUsers_JugadorId",
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
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
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
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interludios",
                columns: table => new
                {
                    InterludioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Actual = table.Column<bool>(nullable: false),
                    EntrePartidaId = table.Column<int>(nullable: false),
                    FechaPrevista = table.Column<DateTime>(nullable: false),
                    FechaResolucion = table.Column<DateTime>(nullable: true),
                    Resuelto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interludios", x => x.InterludioId);
                    table.ForeignKey(
                        name: "FK_Interludios_EntrePartidas_EntrePartidaId",
                        column: x => x.EntrePartidaId,
                        principalTable: "EntrePartidas",
                        principalColumn: "EntrePartidaId",
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
                        name: "FK_AtributoPlantillaTrama_Atributos_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributos",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoPlantillaTrama_PlantillasTrama_PlantillaTramaId",
                        column: x => x.PlantillaTramaId,
                        principalTable: "PlantillasTrama",
                        principalColumn: "PlantillaTramaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tramas",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cerrada = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    EntrePartidaId = table.Column<int>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    PlantillaId = table.Column<int>(nullable: true),
                    PuntosActuales = table.Column<int>(nullable: false),
                    PuntosDePresionPorTiemppo = table.Column<int>(nullable: false),
                    PuntosNecesarios = table.Column<int>(nullable: false),
                    TextoResolucion = table.Column<string>(nullable: true),
                    TipoTrama = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tramas", x => x.TramaId);
                    table.ForeignKey(
                        name: "FK_Tramas_EntrePartidas_EntrePartidaId",
                        column: x => x.EntrePartidaId,
                        principalTable: "EntrePartidas",
                        principalColumn: "EntrePartidaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tramas_PlantillasTrama_PlantillaId",
                        column: x => x.PlantillaId,
                        principalTable: "PlantillasTrama",
                        principalColumn: "PlantillaTramaId",
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
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
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
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
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
                        name: "FK_AtributoPersonaje_Atributos_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributos",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoPersonaje_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguidores",
                columns: table => new
                {
                    PersonajeJugadorId = table.Column<int>(nullable: false),
                    TrasfondoRelacionadoId = table.Column<int>(nullable: false),
                    TipoRelacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguidores", x => new { x.PersonajeJugadorId, x.TrasfondoRelacionadoId });
                    table.ForeignKey(
                        name: "FK_Seguidores_Personajes_PersonajeJugadorId",
                        column: x => x.PersonajeJugadorId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seguidores_Personajes_TrasfondoRelacionadoId",
                        column: x => x.TrasfondoRelacionadoId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormulariosPostPartida",
                columns: table => new
                {
                    FormularioPostPartidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Acuerdos = table.Column<string>(nullable: true),
                    ComentariosNarrador = table.Column<string>(nullable: true),
                    CosasBien = table.Column<string>(nullable: true),
                    CosasMal = table.Column<string>(nullable: true),
                    EntrePartidaId = table.Column<int>(nullable: false),
                    Enviado = table.Column<bool>(nullable: false),
                    FechaEnvio = table.Column<DateTime>(nullable: false),
                    InformacionClave = table.Column<string>(nullable: true),
                    JugadorId = table.Column<string>(nullable: true),
                    NarradorEncargadoId = table.Column<string>(nullable: true),
                    PersonajeId = table.Column<int>(nullable: false),
                    PeticionTramas = table.Column<string>(nullable: true),
                    Resumen = table.Column<string>(maxLength: 9000, nullable: true),
                    Tramitado = table.Column<bool>(nullable: false),
                    ValoracionPartida = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulariosPostPartida", x => x.FormularioPostPartidaId);
                    table.ForeignKey(
                        name: "FK_FormulariosPostPartida_EntrePartidas_EntrePartidaId",
                        column: x => x.EntrePartidaId,
                        principalTable: "EntrePartidas",
                        principalColumn: "EntrePartidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormulariosPostPartida_AspNetUsers_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormulariosPostPartida_AspNetUsers_NarradorEncargadoId",
                        column: x => x.NarradorEncargadoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormulariosPostPartida_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignaciones",
                columns: table => new
                {
                    AsignacionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InterludioId = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones", x => x.AsignacionId);
                    table.ForeignKey(
                        name: "FK_Asignaciones_Interludios_InterludioId",
                        column: x => x.InterludioId,
                        principalTable: "Interludios",
                        principalColumn: "InterludioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignaciones_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_AtributoTrama_Atributos_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributos",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoTrama_Tramas_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Tramas",
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
                        name: "FK_ParticipantesTrama_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantesTrama_Tramas_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Tramas",
                        principalColumn: "TramaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuntosInterludio",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false),
                    InterludioId = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    PuntosObtenidos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosInterludio", x => new { x.TramaId, x.InterludioId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PuntosInterludio_Interludios_InterludioId",
                        column: x => x.InterludioId,
                        principalTable: "Interludios",
                        principalColumn: "InterludioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PuntosInterludio_Tramas_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Tramas",
                        principalColumn: "TramaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajeAsignacion",
                columns: table => new
                {
                    PersonajeAsignacionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AsignacionId = table.Column<int>(nullable: true),
                    PersonajeId = table.Column<int>(nullable: false),
                    PuntosParticipacion = table.Column<int>(nullable: false),
                    TramaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajeAsignacion", x => x.PersonajeAsignacionId);
                    table.ForeignKey(
                        name: "FK_PersonajeAsignacion_Asignaciones_AsignacionId",
                        column: x => x.AsignacionId,
                        principalTable: "Asignaciones",
                        principalColumn: "AsignacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonajeAsignacion_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajeAsignacion_Tramas_TramaId",
                        column: x => x.TramaId,
                        principalTable: "Tramas",
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
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AtributoPersonaje_AtributoId",
                table: "AtributoPersonaje",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoPersonaje_PersonajeId",
                table: "AtributoPersonaje",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_JugadorId",
                table: "Personajes",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguidores_PersonajeJugadorId",
                table: "Seguidores",
                column: "PersonajeJugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguidores_TrasfondoRelacionadoId",
                table: "Seguidores",
                column: "TrasfondoRelacionadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_InterludioId",
                table: "Asignaciones",
                column: "InterludioId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_PersonajeId",
                table: "Asignaciones",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulariosPostPartida_EntrePartidaId",
                table: "FormulariosPostPartida",
                column: "EntrePartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulariosPostPartida_JugadorId",
                table: "FormulariosPostPartida",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulariosPostPartida_NarradorEncargadoId",
                table: "FormulariosPostPartida",
                column: "NarradorEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulariosPostPartida_PersonajeId",
                table: "FormulariosPostPartida",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interludios_EntrePartidaId",
                table: "Interludios",
                column: "EntrePartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeAsignacion_AsignacionId",
                table: "PersonajeAsignacion",
                column: "AsignacionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeAsignacion_PersonajeId",
                table: "PersonajeAsignacion",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeAsignacion_TramaId",
                table: "PersonajeAsignacion",
                column: "TramaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoPlantillaTrama_AtributoId",
                table: "AtributoPlantillaTrama",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoPlantillaTrama_PlantillaTramaId",
                table: "AtributoPlantillaTrama",
                column: "PlantillaTramaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoTrama_AtributoId",
                table: "AtributoTrama",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtributoTrama_TramaId",
                table: "AtributoTrama",
                column: "TramaId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantesTrama_PersonajeId",
                table: "ParticipantesTrama",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantesTrama_TramaId",
                table: "ParticipantesTrama",
                column: "TramaId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosInterludio_InterludioId",
                table: "PuntosInterludio",
                column: "InterludioId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosInterludio_TramaId",
                table: "PuntosInterludio",
                column: "TramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tramas_EntrePartidaId",
                table: "Tramas",
                column: "EntrePartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tramas_PlantillaId",
                table: "Tramas",
                column: "PlantillaId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtributoPersonaje");

            migrationBuilder.DropTable(
                name: "Seguidores");

            migrationBuilder.DropTable(
                name: "FormulariosPostPartida");

            migrationBuilder.DropTable(
                name: "PersonajeAsignacion");

            migrationBuilder.DropTable(
                name: "AtributoPlantillaTrama");

            migrationBuilder.DropTable(
                name: "AtributoTrama");

            migrationBuilder.DropTable(
                name: "ParticipantesTrama");

            migrationBuilder.DropTable(
                name: "PuntosInterludio");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Asignaciones");

            migrationBuilder.DropTable(
                name: "Atributos");

            migrationBuilder.DropTable(
                name: "Tramas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Interludios");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "PlantillasTrama");

            migrationBuilder.DropTable(
                name: "EntrePartidas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
