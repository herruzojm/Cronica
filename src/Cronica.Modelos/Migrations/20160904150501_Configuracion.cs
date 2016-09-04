using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cronica.Modelos.Migrations
{
    public partial class Configuracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracion",
                columns: table => new
                {
                    ConfiguracionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DireccionBase = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PorcentajeAliados = table.Column<int>(nullable: false),
                    PorcentajeContactos = table.Column<int>(nullable: false),
                    PorcentajeInfluencia = table.Column<int>(nullable: false),
                    PorcentajeMentor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracion", x => x.ConfiguracionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");
        }
    }
}
