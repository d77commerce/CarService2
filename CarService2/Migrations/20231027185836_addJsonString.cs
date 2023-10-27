using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class addJsonString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataTasks",
                table: "OrdersDbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataTasks", "DateTime" },
                values: new object[] { "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n", new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataTasks", "DateTime" },
                values: new object[] { "{\r\n  \"15w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n", new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataTasks", "DateTime" },
                values: new object[] { "{\r\n  \"5w40\": \"Castrol\",\r\n  \"oilFilter\": true\r\n}\r\n", new DateTime(2023, 10, 27, 19, 58, 36, 424, DateTimeKind.Local).AddTicks(7117) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataTasks",
                table: "OrdersDbs");

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 18, 38, 32, 984, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 18, 38, 32, 984, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "OrdersDbs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 10, 27, 18, 38, 32, 984, DateTimeKind.Local).AddTicks(607));
        }
    }
}
