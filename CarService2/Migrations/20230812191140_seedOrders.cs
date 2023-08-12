using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class seedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrdersDbs",
                columns: new[] { "Id", "CustomerId", "DateTime" },
                values: new object[] { 1, 1, new DateTime(2023, 8, 12, 20, 11, 40, 523, DateTimeKind.Local).AddTicks(2280) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
