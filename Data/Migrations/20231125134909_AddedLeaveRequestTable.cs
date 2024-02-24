using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
