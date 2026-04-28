using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addreslereklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 12, 23, 28, 32, 930, DateTimeKind.Local).AddTicks(423), new Guid("8ecf47a1-3377-43e3-9bab-33a80cbc01af") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 12, 23, 28, 32, 932, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 12, 23, 28, 32, 932, DateTimeKind.Local).AddTicks(4550));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 12, 22, 55, 3, 514, DateTimeKind.Local).AddTicks(1394), new Guid("dc52df7f-ec0f-47c6-b1a7-9ae698be6148") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 12, 22, 55, 3, 516, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 12, 22, 55, 3, 516, DateTimeKind.Local).AddTicks(7645));
        }
    }
}
