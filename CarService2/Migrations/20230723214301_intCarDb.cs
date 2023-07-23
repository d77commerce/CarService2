using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarService2.Migrations
{
    /// <inheritdoc />
    public partial class intCarDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegistrationNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ArtEndDate = table.Column<string>(type: "TEXT", nullable: false),
                    Co2Emissions = table.Column<int>(type: "INTEGER", nullable: false),
                    Colour = table.Column<string>(type: "TEXT", nullable: false),
                    EngineCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelType = table.Column<string>(type: "TEXT", nullable: false),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    MarkedForExport = table.Column<bool>(type: "INTEGER", nullable: false),
                    MonthOfFirstRegistration = table.Column<string>(type: "TEXT", nullable: false),
                    MotStatus = table.Column<string>(type: "TEXT", nullable: false),
                    RevenueWeight = table.Column<int>(type: "INTEGER", nullable: false),
                    TaxDueDate = table.Column<string>(type: "TEXT", nullable: false),
                    TaxStatus = table.Column<string>(type: "TEXT", nullable: false),
                    TypeApproval = table.Column<string>(type: "TEXT", nullable: false),
                    Wheelplan = table.Column<string>(type: "TEXT", nullable: false),
                    YearOfManufacture = table.Column<int>(type: "INTEGER", nullable: false),
                    EuroStatus = table.Column<string>(type: "TEXT", nullable: false),
                    RealDrivingEmissions = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfLastV5CIssued = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegistrationNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
