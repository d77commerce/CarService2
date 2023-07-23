using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class renew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "111111");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ArtEndDate", "Co2Emissions", "Colour", "CustomerId", "DateOfLastV5CIssued", "EngineCapacity", "EuroStatus", "FuelType", "Make", "MarkedForExport", "MonthOfFirstRegistration", "MotStatus", "RealDrivingEmissions", "RegistrationNumber", "RevenueWeight", "TaxDueDate", "TaxStatus", "TypeApproval", "Wheelplan", "YearOfManufacture" },
                values: new object[] { 1, "Pending", 0, "Red", 1, "Pending", 0, "EURO 3", "Pending", "Pending", false, "Pending", "Pending", "Pending", "111111", 0, "Pending", "Pending", "Pending", "Pending", 1900 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "RegistrationNumber");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegistrationNumber", "ArtEndDate", "Co2Emissions", "Colour", "CustomerId", "DateOfLastV5CIssued", "EngineCapacity", "EuroStatus", "FuelType", "Make", "MarkedForExport", "MonthOfFirstRegistration", "MotStatus", "RealDrivingEmissions", "RevenueWeight", "TaxDueDate", "TaxStatus", "TypeApproval", "Wheelplan", "YearOfManufacture" },
                values: new object[] { "111111", "Pending", 0, "Red", 1, "Pending", 0, "EURO 3", "Pending", "Pending", false, "Pending", "Pending", "Pending", 0, "Pending", "Pending", "Pending", "Pending", 1900 });
        }
    }
}
