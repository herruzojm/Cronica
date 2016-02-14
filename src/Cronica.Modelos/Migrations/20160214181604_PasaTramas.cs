using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cronica.Modelos.Migrations
{
    public partial class PasaTramas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_PasaTrama_PostPartida_PostPartidaPostPartidaId", table: "PasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoTrama_Atributo_AtributoId", table: "AtributoTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoTrama_Trama_TramaId", table: "AtributoTrama");
            migrationBuilder.DropForeignKey(name: "FK_PuntosPasaTrama_Trama_TramaId", table: "PuntosPasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_Trama_Personaje_PersonajeId", table: "Trama");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropColumn(name: "PostPartidaPostPartidaId", table: "PasaTrama");
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaResolucion",
                table: "PasaTrama",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "PostPartidaId",
                table: "PasaTrama",
                nullable: false,
                defaultValue: 0);
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
                name: "FK_PasaTrama_PostPartida_PostPartidaId",
                table: "PasaTrama",
                column: "PostPartidaId",
                principalTable: "PostPartida",
                principalColumn: "PostPartidaId",
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
                name: "FK_AtributoTrama_Atributo_AtributoId",
                table: "AtributoTrama",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoTrama_Trama_TramaId",
                table: "AtributoTrama",
                column: "TramaId",
                principalTable: "Trama",
                principalColumn: "TramaId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_PuntosPasaTrama_Trama_TramaId",
                table: "PuntosPasaTrama",
                column: "TramaId",
                principalTable: "Trama",
                principalColumn: "TramaId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Trama_Personaje_PersonajeId",
                table: "Trama",
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
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Atributo_AtributoId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPersonaje_Personaje_PersonajeId", table: "AtributoPersonaje");
            migrationBuilder.DropForeignKey(name: "FK_PasaTrama_PostPartida_PostPartidaId", table: "PasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_Atributo_AtributoId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoPlantillaTrama_PlantillaTrama_PlantillaTramaId", table: "AtributoPlantillaTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoTrama_Atributo_AtributoId", table: "AtributoTrama");
            migrationBuilder.DropForeignKey(name: "FK_AtributoTrama_Trama_TramaId", table: "AtributoTrama");
            migrationBuilder.DropForeignKey(name: "FK_PuntosPasaTrama_Trama_TramaId", table: "PuntosPasaTrama");
            migrationBuilder.DropForeignKey(name: "FK_Trama_Personaje_PersonajeId", table: "Trama");
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropColumn(name: "PostPartidaId", table: "PasaTrama");
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaResolucion",
                table: "PasaTrama",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "PostPartidaPostPartidaId",
                table: "PasaTrama",
                nullable: true);
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
                name: "FK_PasaTrama_PostPartida_PostPartidaPostPartidaId",
                table: "PasaTrama",
                column: "PostPartidaPostPartidaId",
                principalTable: "PostPartida",
                principalColumn: "PostPartidaId",
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
                name: "FK_AtributoTrama_Atributo_AtributoId",
                table: "AtributoTrama",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "AtributoId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_AtributoTrama_Trama_TramaId",
                table: "AtributoTrama",
                column: "TramaId",
                principalTable: "Trama",
                principalColumn: "TramaId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_PuntosPasaTrama_Trama_TramaId",
                table: "PuntosPasaTrama",
                column: "TramaId",
                principalTable: "Trama",
                principalColumn: "TramaId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Trama_Personaje_PersonajeId",
                table: "Trama",
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
