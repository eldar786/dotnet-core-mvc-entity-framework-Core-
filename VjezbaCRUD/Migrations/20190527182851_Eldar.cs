using Microsoft.EntityFrameworkCore.Migrations;

namespace VjezbaCRUD.Migrations
{
    public partial class Eldar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Drzava",
                table: "Opstina",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Opstina",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Drzava",
                table: "Opstina");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Opstina");
        }
    }
}
