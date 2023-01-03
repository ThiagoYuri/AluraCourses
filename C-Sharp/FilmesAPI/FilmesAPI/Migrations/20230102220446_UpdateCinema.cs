using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesAPI.Migrations
{
    public partial class UpdateCinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoFK",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "GerenteFK",
                table: "Cinemas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
