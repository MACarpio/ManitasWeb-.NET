using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManitasWeb.Data.Migrations
{
    public partial class imagenesproductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen2",
                table: "t_producto",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen3",
                table: "t_producto",
                type: "bytea",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen2",
                table: "t_producto");

            migrationBuilder.DropColumn(
                name: "Imagen3",
                table: "t_producto");
        }
    }
}
