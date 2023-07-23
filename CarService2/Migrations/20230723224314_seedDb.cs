using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class seedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegistrationNumber", "ArtEndDate", "Co2Emissions", "Colour", "CustomerId", "DateOfLastV5CIssued", "EngineCapacity", "EuroStatus", "FuelType", "Make", "MarkedForExport", "MonthOfFirstRegistration", "MotStatus", "RealDrivingEmissions", "RevenueWeight", "TaxDueDate", "TaxStatus", "TypeApproval", "Wheelplan", "YearOfManufacture" },
                values: new object[] { "111111", "Pending", 0, "Red", 1, "Pending", 0, "EURO 3", "Pending", "Pending", false, "Pending", "Pending", "Pending", 0, "Pending", "Pending", "Pending", "Pending", 1900 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "111111");
        }
    }
}
