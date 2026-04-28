using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class HataDuzeltme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeliverygAddress",
                table: "Addresses",
                newName: "IsDeliveryAddress");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "IsDeliveryAddress",
                table: "Addresses",
                newName: "IsDeliverygAddress");

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
    }
}
