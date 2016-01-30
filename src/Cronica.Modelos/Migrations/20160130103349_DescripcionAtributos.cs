using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class DescripcionAtributos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.CreateTable(
                name: "TramaActiva",
                columns: table => new
                {
                    TramaActivaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cerrada = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    PersonajePersonajeId = table.Column<int>(nullable: true),
                    PostPartidaPostPartidaId = table.Column<int>(nullable: true),
                    PuntosActuales = table.Column<int>(nullable: false),
                    PuntosDePresionPorTiemppo = table.Column<int>(nullable: false),
                    PuntosNecesarios = table.Column<int>(nullable: false),
                    TextoResolucion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramaActiva", x => x.TramaActivaId);
                    table.ForeignKey(
                        name: "FK_TramaActiva_Personaje_PersonajePersonajeId",
                        column: x => x.PersonajePersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TramaActiva_PostPartida_PostPartidaPostPartidaId",
                        column: x => x.PostPartidaPostPartidaId,
                        principalTable: "PostPartida",
                        principalColumn: "PostPartidaId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AtributoTramaActiva",
                columns: table => new
                {
                    AtributoId = table.Column<int>(nullable: false),
                    TramaActivaId = table.Column<int>(nullable: false),
                    Multiplicador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributoTramaActiva", x => new { x.AtributoId, x.TramaActivaId });
                    table.ForeignKey(
                        name: "FK_AtributoTramaActiva_Atributo_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributo",
                        principalColumn: "AtributoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtributoTramaActiva_TramaActiva_TramaActivaId",
                        column: x => x.TramaActivaId,
                        principalTable: "TramaActiva",
                        principalColumn: "TramaActivaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "PuntosPasaTrama",
                columns: table => new
                {
                    TramaActivaId = table.Column<int>(nullable: false),
                    PasaTramaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    PuntosObtenidos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosPasaTrama", x => new { x.TramaActivaId, x.PasaTramaId });
                    table.ForeignKey(
                        name: "FK_PuntosPasaTrama_TramaActiva_TramaActivaId",
                        column: x => x.TramaActivaId,
                        principalTable: "TramaActiva",
                        principalColumn: "TramaActivaId",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "AtributoPersonaje",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPersonaje_Atributo_AtributoId",
                table: "AtributoPersonaje",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPersonaje_Personaje_PersonajeId",
                table: "AtributoPersonaje",
                column: "PersonajeId",
                principalTable: "Personaje",
                principalColumn: "PersonajeId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPlantillaTrama_Atributo_AtributoId",
                table: "AtributoPlantillaTrama",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId",
                table: "AtributoPlantillaTrama",
                column: "PlantillaTramaId",
                principalTable: "PlantillaTrama",
                principalColumn: "PlantillaTramaId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropColumn(name: "Descripcion", table: "AtributoPersonaje");
            migrationBuilder.DropTable("AtributoTramaActiva");
            migrationBuilder.DropTable("PuntosPasaTrama");
            migrationBuilder.DropTable("TramaActiva");
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPlantillaTrama_Atributo_AtributoId",
                table: "AtributoPlantillaTrama",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId",
                table: "AtributoPlantillaTrama",
                column: "PlantillaTramaId",
                principalTable: "PlantillaTrama",
                principalColumn: "PlantillaTramaId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPersonaje_Atributo_AtributoId",
                table: "AtributoPersonaje",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoPersonaje_Personaje_PersonajeId",
                table: "AtributoPersonaje",
                column: "PersonajeId",
                principalTable: "Personaje",
                principalColumn: "PersonajeId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
