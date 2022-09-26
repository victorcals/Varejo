using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Atacadista.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    ItensId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Produto = table.Column<string>(type: "TEXT", nullable: true),
                    Codigo = table.Column<string>(type: "TEXT", nullable: true),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.ItensId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Itens");
        }
    }
}
