using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class SeedTaskDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 12, 23, 16, 11, 84, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.InsertData(
                table: "TasksDb",
                columns: new[] { "Id", "Description", "Name", "Note", "OrderTaskId" },
                values: new object[,]
                {
                    { 1, "15W40", "Oil Specification", "Castrol", 1 },
                    { 2, "75W90", "Gear oil Specification", "OMV", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TasksDb",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TasksDb",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 12, 20, 16, 51, 690, DateTimeKind.Local).AddTicks(6086));
        }
    }
}
