using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "comidas",
                columns: table => new
                {
                    ComidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Platos = table.Column<int>(nullable: false),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comidas", x => x.ComidaId);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    Usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clientes = table.Column<int>(nullable: true),
                    Comidas = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_facturas_personas_Clientes",
                        column: x => x.Clientes,
                        principalTable: "personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_comidas_Comidas",
                        column: x => x.Comidas,
                        principalTable: "comidas",
                        principalColumn: "ComidaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_Clientes",
                table: "facturas",
                column: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_Comidas",
                table: "facturas",
                column: "Comidas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "comidas");
        }
    }
}
