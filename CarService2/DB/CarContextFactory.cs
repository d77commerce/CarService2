using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class CarContextFactory : IDesignTimeDbContextFactory<CarContext>
{
    public CarContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CarContext>();
        optionsBuilder.UseSqlite("Data Source=car_database.db");
        return new CarContext(optionsBuilder.Options);
    }
}