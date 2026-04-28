using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class SiparislerTablosu2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 19, 23, 31, 41, 167, DateTimeKind.Local).AddTicks(324), new Guid("5765ca19-51cf-4aa1-838e-669cbfb7edca") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 19, 23, 31, 41, 170, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 19, 23, 31, 41, 170, DateTimeKind.Local).AddTicks(4800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TotalPrice",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 19, 23, 17, 57, 769, DateTimeKind.Local).AddTicks(3524), new Guid("38b16cc0-bc0e-4bfd-891c-7e00a3a8f683") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 19, 23, 17, 57, 772, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 19, 23, 17, 57, 772, DateTimeKind.Local).AddTicks(3881));
        }
    }
}
