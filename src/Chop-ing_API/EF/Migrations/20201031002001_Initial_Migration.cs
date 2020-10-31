using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chop_ing_API.EF.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    Articulo_Id = table.Column<string>(maxLength: 15, nullable: false),
                    CreadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(maxLength: 20, nullable: false),
                    Articulo_Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Articulo_Descripcion = table.Column<string>(maxLength: 2000, nullable: false),
                    Articulo_Precio = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.Articulo_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulo");
        }
    }
}
