using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class addOrderNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "OrdersDbs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "OrderNo" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 21, 9, 668, DateTimeKind.Local).AddTicks(7030), 0 });

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "OrderNo" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 21, 9, 668, DateTimeKind.Local).AddTicks(7041), 0 });

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "OrderNo" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 21, 9, 668, DateTimeKind.Local).AddTicks(7048), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "OrdersDbs");

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7117));
        }
    }
}
