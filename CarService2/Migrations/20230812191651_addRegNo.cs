using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class addRegNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegNo",
                table: "OrdersDbs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "RegNo" },
                values: new object[] { new DateTime(2023, 8, 12, 20, 16, 51, 690, DateTimeKind.Local).AddTicks(6086), "11111" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNo",
                table: "OrdersDbs");

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 12, 20, 11, 40, 523, DateTimeKind.Local).AddTicks(2280));
        }
    }
}
