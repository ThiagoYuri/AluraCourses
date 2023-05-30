using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class datanacimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "79b05605-e751-4e61-bba0-a558b1be6e44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8fe75c12-11b6-4e55-8d46-add5808163c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00ab19ff-bc71-4c1c-8b5e-3f3bc7768f60", "AQAAAAEAACcQAAAAEKNTqH0ZmrfSz6beExAem+r+0OCpdMZ6uEyhPdNyKIJI4JZX2JWyqf67CX/+dxUhjQ==", "7c3de0b7-2dab-4ca9-9a17-eefcfc9c596b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "27cd2be5-ebb1-42d4-8d35-e55023fcd5ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6185fbaa-f430-4011-810a-39b3c579c461");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dc2e1a5-4332-4fbc-a8ca-673b059cce1b", "AQAAAAEAACcQAAAAEALa1iqVgGWJQDs+XKQXh3DAeq9eniKzY5DaX9Oex2X6o9cv0Ir/PX9+/jNJvqRvyw==", "bdfdb8bd-a81f-4b03-be83-bc3cbfbcaf52" });
        }
    }
}
