using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class Mensajeria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    MensajeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Asunto = table.Column<string>(nullable: true),
                    Cuerpo = table.Column<string>(nullable: true),
                    EsAnonimo = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    NombreParaMostrar = table.Column<string>(nullable: true),
                    RemitenteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.MensajeId);
                    table.ForeignKey(
                        name: "FK_Mensajes_Personajes_RemitenteId",
                        column: x => x.RemitenteId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DestinatariosMensaje",
                columns: table => new
                {
                    DestinatarioMensajeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DestinatarioId = table.Column<int>(nullable: false),
                    EstadoMensaje = table.Column<int>(nullable: false),
                    MensajeId = table.Column<int>(nullable: true),
                    TipoDestinatario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinatariosMensaje", x => x.DestinatarioMensajeId);
                    table.ForeignKey(
                        name: "FK_DestinatariosMensaje_Personajes_DestinatarioId",
                        column: x => x.DestinatarioId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinatariosMensaje_Mensajes_MensajeId",
                        column: x => x.MensajeId,
                        principalTable: "Mensajes",
                        principalColumn: "MensajeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DestinatariosMensaje_DestinatarioId",
                table: "DestinatariosMensaje",
                column: "DestinatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinatariosMensaje_MensajeId",
                table: "DestinatariosMensaje",
                column: "MensajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_RemitenteId",
                table: "Mensajes",
                column: "RemitenteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestinatariosMensaje");

            migrationBuilder.DropTable(
                name: "Mensajes");
        }
    }
}
