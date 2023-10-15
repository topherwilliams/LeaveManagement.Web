using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-20623466cc9a",
                column: "ConcurrencyStamp",
                value: "1fa75fa5-44f6-4b85-ab4b-47b81cdefdbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-90623466cc7a",
                column: "ConcurrencyStamp",
                value: "70276f23-ce08-4ab8-b01d-349bc4fb5c01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59144c1-984e-47fa-a70d-90323466cc7a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ca3c367-ac83-4a29-914b-7513aded3994", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBvsi09uxaIwbaCZsFjAmLXAt50W+j46cpWIXNlJ6tfNBUJSTdFeYaezuOXlUjeplQ==", "a94089eb-5fca-4d6b-b484-cf8df29cdb7b", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "42179383-6eb3-437a-9d6e-c8664f69aded", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOh0t7l5HK+HaDV7qI5fmWts9EVbipCwqSLrRb1PRGwLSAodQEpH3/7MHR1MjcgGQg==", "c85049d6-b0a1-4c7f-b2ee-4efc4790e1c0", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-20623466cc9a",
                column: "ConcurrencyStamp",
                value: "ded021c3-44cf-4afb-8fc4-a222046f2ba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-90623466cc7a",
                column: "ConcurrencyStamp",
                value: "b5e60b3d-b591-42c0-ab6d-b3b0e9db0b2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59144c1-984e-47fa-a70d-90323466cc7a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "426b02e8-d9fa-4798-82c6-cbfb017504ea", false, null, "AQAAAAIAAYagAAAAEHeO6Yig7jK1CJSWCPIO7oCSrxpg66p53pVCzGFFNa5ASKtZhmvWptU4mJaGFxS4Pg==", "25e92f62-bc95-496a-ac9f-bf5e31c7a98f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ade02c1-8d4c-4c49-9c3f-13c5d24149ea", false, null, "AQAAAAIAAYagAAAAEMsdLPdW7MQyvCRuSAJS9jS/MFf2Ic7DHkio08OiIR+fJ3pZXy020MMPrvn2JHxMaQ==", "ba8e5d91-7078-4fab-9e30-b0ef4e5f9066", null });
        }
    }
}
