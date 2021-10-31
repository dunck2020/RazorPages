using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPages.Migrations
{
    public partial class ClientAndAnnotationsX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 31, 14, 1, 54, 137, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 31, 14, 1, 54, 161, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 31, 14, 1, 54, 161, DateTimeKind.Local).AddTicks(484));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 31, 13, 55, 25, 452, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 31, 13, 55, 25, 461, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "ClientServices",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 31, 13, 55, 25, 461, DateTimeKind.Local).AddTicks(5190));
        }
    }
}
