using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderStateEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderState",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 20, 1, 58, 40, 531, DateTimeKind.Local).AddTicks(2922), new Guid("09b2820f-6563-40bf-afce-d0c7c45a35c7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 20, 1, 58, 40, 533, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 20, 1, 58, 40, 533, DateTimeKind.Local).AddTicks(5413));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderState",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 5, 20, 1, 38, 44, 185, DateTimeKind.Local).AddTicks(36), new Guid("b8162c5d-c33d-4aa3-8302-5a45755da960") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 20, 1, 38, 44, 186, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 20, 1, 38, 44, 187, DateTimeKind.Local).AddTicks(556));
        }
    }
}
