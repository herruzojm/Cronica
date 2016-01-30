using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class RenombrarTramas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_PuntosPasaTrama_TramaActiva_TramaActivaId", table: "PuntosPasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropPrimaryKey(name: "PK_PuntosPasaTrama", table: "PuntosPasaTrama");
            migrationBuilder.DropColumn(name: "TramaActivaId", table: "PuntosPasaTrama");
            migrationBuilder.DropTable("AtributoTramaActiva");
            migrationBuilder.DropTable("TramaActiva");
            migrationBuilder.CreateTable(
                name: "Trama",
                columns: table => new
                {
                    TramaId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Trama", x => x.TramaId);
                    table.ForeignKey(
                        name: "FK_Trama_Personaje_PersonajePersonajeId",
                        column: x => x.PersonajePersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trama_PostPartida_PostPartidaPostPartidaId",
                        column: x => x.PostPartidaPostPartidaId,
                        principalTable: "PostPartida",
                        principalColumn: "PostPartidaId",
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
            migrationBuilder.AddColumn<int>(
                name: "TramaId",
                table: "PuntosPasaTrama",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_PuntosPasaTrama",
                table: "PuntosPasaTrama",
                columns: new[] { "TramaId", "PasaTramaId" });
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
                name: "FK_PuntosPasaTrama_Trama_TramaId",
                table: "PuntosPasaTrama",
                column: "TramaId",
                principalTable: "Trama",
                principalColumn: "TramaId",
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
            migrationBuilder.DropForeignKey(name: "FK_PuntosPasaTrama_Trama_TramaId", table: "PuntosPasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropPrimaryKey(name: "PK_PuntosPasaTrama", table: "PuntosPasaTrama");
            migrationBuilder.DropColumn(name: "TramaId", table: "PuntosPasaTrama");
            migrationBuilder.DropTable("AtributoTrama");
            migrationBuilder.DropTable("Trama");
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtributoTramaActiva_TramaActiva_TramaActivaId",
                        column: x => x.TramaActivaId,
                        principalTable: "TramaActiva",
                        principalColumn: "TramaActivaId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddColumn<int>(
                name: "TramaActivaId",
                table: "PuntosPasaTrama",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_PuntosPasaTrama",
                table: "PuntosPasaTrama",
                columns: new[] { "TramaActivaId", "PasaTramaId" });
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
                name: "FK_PuntosPasaTrama_TramaActiva_TramaActivaId",
                table: "PuntosPasaTrama",
                column: "TramaActivaId",
                principalTable: "TramaActiva",
                principalColumn: "TramaActivaId",
                onDelete: ReferentialAction.Restrict);
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
