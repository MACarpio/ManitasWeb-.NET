using Microsoft.EntityFrameworkCore.Migrations;

namespace ManitasWeb.Data.Migrations
{
    public partial class homeproducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Home",
                table: "t_producto",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Home",
                table: "t_producto");
        }
    }
}
