using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-20623466cc9a",
                column: "ConcurrencyStamp",
                value: "b0d6b810-3969-4396-add4-dcbe024f3234");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-90623466cc7a",
                column: "ConcurrencyStamp",
                value: "0aca1be8-a230-48c4-911f-742c60fc5c63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59144c1-984e-47fa-a70d-90323466cc7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75bef2e1-15fb-4a86-9de0-b8bae943974e", "AQAAAAEAACcQAAAAEHE4JJlUZC5JwLAAZqQ8SHi8LM/go12HU4OibJ8PUofrB6GLEPxQenaE2Qx1PqF0Cg==", "b6364d7f-d7c6-4b45-904d-906522a06217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d23643-17b9-483a-b9ae-f88d58fd470b", "AQAAAAEAACcQAAAAEGPghKMpCdBLfUyVJpGurCPlzhBTPNzVv4noYYGj5/iXguislvAIpbFums95FlptLg==", "69402498-1dad-4a76-a2a8-207b089d4c7d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-20623466cc9a",
                column: "ConcurrencyStamp",
                value: "bd92f388-67e0-4de9-9db0-4d3427e49db3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-90623466cc7a",
                column: "ConcurrencyStamp",
                value: "b36a93f5-74a7-4acb-92ee-a0a00a4930a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59144c1-984e-47fa-a70d-90323466cc7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a06b863-f5c9-4e6d-bc1c-46400456f0c2", "AQAAAAEAACcQAAAAECnDlVn5VwcHUwWMXxvcIQKG+KwmUJHY1irrs5WTqlPjsAHvyGP6ybxg4MtC9XjW/w==", "28ac4571-c07c-4f6f-a8d2-c74c2ef19843" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f56573b2-af9a-4ed0-84c7-7e4feefe39a7", "AQAAAAEAACcQAAAAEG9ZwnEqKeDIkZ9QBfMpQDu1pQ54nKk7GqFtCkQrOBiIhuZVPaaL/osD+h6DDqG2tw==", "82dc9f4a-1b99-41a3-a282-25aa496651fe" });
        }
    }
}
