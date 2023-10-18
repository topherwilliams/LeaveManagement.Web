using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-20623466cc9a",
                column: "ConcurrencyStamp",
                value: "6ec374a0-8267-4932-8d83-1e3e692cfe2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e39144c2-984e-47fa-a70d-90623466cc7a",
                column: "ConcurrencyStamp",
                value: "6fc88440-131f-4965-8925-480149f3483d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59144c1-984e-47fa-a70d-90323466cc7a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0721988d-234c-4dd6-af29-6cf3a1998800", "AQAAAAEAACcQAAAAEFj+qK+OKbvIDU/oS+PgnPq4wEPIjZUwtdOtplW4ussFzWENthHzCr2DFIyBp8R/9g==", "8d8b7a54-a2b4-4ced-876d-af6c5fef3f2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed4c2f2-0bd6-414a-9ac3-99ac64200ed2", "AQAAAAEAACcQAAAAEEzrLoW6REAgFk+vWNiPbMme88s6q1evUdSMPQI4rJHS6UtmNbUENakkMb6+M4a7Wg==", "b44c2911-cc93-4c89-8dc3-00e091f27d08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ca3c367-ac83-4a29-914b-7513aded3994", "AQAAAAIAAYagAAAAEBvsi09uxaIwbaCZsFjAmLXAt50W+j46cpWIXNlJ6tfNBUJSTdFeYaezuOXlUjeplQ==", "a94089eb-5fca-4d6b-b484-cf8df29cdb7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59166c1-984e-47fa-a70d-90323422cc2a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42179383-6eb3-437a-9d6e-c8664f69aded", "AQAAAAIAAYagAAAAEOh0t7l5HK+HaDV7qI5fmWts9EVbipCwqSLrRb1PRGwLSAodQEpH3/7MHR1MjcgGQg==", "c85049d6-b0a1-4c7f-b2ee-4efc4790e1c0" });
        }
    }
}
