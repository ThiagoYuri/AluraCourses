using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class roleRegular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9f268e5f-fdb2-4ce9-9cd1-28edfe5b7d5e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "b7d0cf91-cfc4-4f95-aa31-607423719698", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ef5fa0-d00b-426a-bdb0-2a711ac40ae0", "AQAAAAEAACcQAAAAEKRuGstBKf9xQVk9ceDuKwp9Gbxt03YdMSE6ctD0UOugohQKRh1hsAuPqBPBGZHQ1A==", "27361404-0359-4181-80cd-e52e5db880b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "897c5a08-71f1-4500-9d1e-89761cf7b835");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b4b00c-9f44-43f8-a176-e61a8413ccc3", "AQAAAAEAACcQAAAAEPlXFVWGl0TD/N+QJmsqsFRh9p3UG/Nzju4zjE0htZgoBaot6yIkm58dn6pp5aS8Ow==", "0a49942c-a3a2-4239-bbb9-290e630405fc" });
        }
    }
}
