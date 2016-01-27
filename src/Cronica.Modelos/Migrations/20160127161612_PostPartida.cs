using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class PostPartida : Migration
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
                name: "PasaTrama",
                columns: table => new
                {
                    PasaTramaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaPrevista = table.Column<DateTime>(nullable: false),
                    FechaResolucion = table.Column<DateTime>(nullable: false),
                    PostPartidaPostPartidaId = table.Column<int>(nullable: true),
                    Resuelto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasaTrama", x => x.PasaTramaId);
                    table.ForeignKey(
                        name: "FK_PasaTrama_PostPartida_PostPartidaPostPartidaId",
                        column: x => x.PostPartidaPostPartidaId,
                        principalTable: "PostPartida",
                        principalColumn: "PostPartidaId",
                        onDelete: ReferentialAction.Restrict);
                });
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
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropTable("PasaTrama");
            migrationBuilder.DropTable("PostPartida");
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
