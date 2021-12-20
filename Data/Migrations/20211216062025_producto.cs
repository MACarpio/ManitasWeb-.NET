using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ManitasWeb.Data.Migrations
{
    public partial class producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    ImagenNom = table.Column<string>(type: "text", nullable: true),
                    Imagen = table.Column<byte[]>(type: "bytea", nullable: true),
                    Registro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    CategId = table.Column<int>(type: "integer", nullable: true),
                    MaterId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_t_producto_t_categoria_CategId",
                        column: x => x.CategId,
                        principalTable: "t_categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_producto_t_material_MaterId",
                        column: x => x.MaterId,
                        principalTable: "t_material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_producto_CategId",
                table: "t_producto",
                column: "CategId");

            migrationBuilder.CreateIndex(
                name: "IX_t_producto_MaterId",
                table: "t_producto",
                column: "MaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_producto");
        }
    }
}
