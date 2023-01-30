using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "b7d0cf91-cfc4-4f95-aa31-607423719698");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9f268e5f-fdb2-4ce9-9cd1-28edfe5b7d5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ef5fa0-d00b-426a-bdb0-2a711ac40ae0", "AQAAAAEAACcQAAAAEKRuGstBKf9xQVk9ceDuKwp9Gbxt03YdMSE6ctD0UOugohQKRh1hsAuPqBPBGZHQ1A==", "27361404-0359-4181-80cd-e52e5db880b4" });
        }
    }
}
