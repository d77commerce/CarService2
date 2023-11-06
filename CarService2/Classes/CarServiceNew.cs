using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;

namespace CarService2.Classes
{
    public class CarServiceNew
    {
        private static CarContext dbContext = new CarContext(new DbContextOptions<CarContext>());


        public static void CarServiceByReg(string regNo)
        {
            var car = new Car();
            dbContext.Database.OpenConnection();
            var foundCar = dbContext.Cars.FirstOrDefault(c => c.RegistrationNumber == regNo);


            if (foundCar != null)
            {
                // Display car information
                /*MessageBox.Show($"Car Reg No: {foundCar.RegistrationNumber}" +
                                $"\nMake: {foundCar.Make}" +
                                $"\nColour: {foundCar.Colour}" +
                                $"\nEngine Capacity: {foundCar.EngineCapacity}" +
                                $"\nFuel Type: {foundCar.FuelType}" +
                                $"\nFirst Reg : {foundCar.MonthOfFirstRegistration}");*/
                var addCar = new Add_car
                {
                    reg_car_textBox =
                    {
                        Text = foundCar.RegistrationNumber.ToString().ToUpper()
                    },
                    fuel_car_textBox =
                    {
                        Text = foundCar.FuelType.ToString()
                    },
                    make_car_textBox =
                    {
                        Text = foundCar.Make.ToString()
                    },
                    colour_car_textBox =
                    {
                        Text = foundCar.Colour.ToString()
                    },
                    year_car_textBox =
                    {
                        Text = foundCar.MonthOfFirstRegistration.ToString()
                    },
                    engine_textBox =
                    {
                        Text = foundCar.EngineCapacity.ToString()
                    }

                };
                var customerName = dbContext.Customers.FirstOrDefault(c => c.Id == foundCar.CustomerId)?.CompanyName.ToString();
                
                    addCar.customer_fullName_car.Content = customerName;
                addCar.customerID_label.Content = foundCar.CustomerId.ToString();
                    //foundCar.Customer.CompanyName.ToString();    // customer.FullName;
                    addCar.Show();
            }
            else
            {
                MessageBox.Show("***** Car is non exist in Database. *****");
                // Add_car add = new Add_car();
                FullDvlaInfo add = new FullDvlaInfo();
                add.FullDvlaInfoOne(regNo);
            }
            dbContext.Database.CloseConnection();

        }

    }

}
