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


        public static void CarServiceByReg(string regNo, int customerId)
        {
            var car = new Car();
            dbContext.Database.OpenConnection();
            var foundCar = dbContext.Cars.FirstOrDefault(c => c.RegistrationNumber == regNo);

            var customer = new CustomerAdd()
            {
                Id = customerId,
                FullName = "John Doe",
                PhoneNumber = "0777777",
                Email = "john.doe@example.com",
                CompanyName = "Onyx"
            };

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
                if (car.CustomerId == 1)
                {
                    addCar.customer_fullName_car.Content = customer.FullName;
                }
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

            /*var customer = new CustomerAdd()
            {
                Id = customerId,
                FullName = "John Doe",
                PhoneNumber = "0777777",
                Email = "john.doe@example.com",
                CompanyName = "Onyx"
            };*/


            // var car = new Car(regNo);
            /*var addCar = new Add_car
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
                model_car_textBox =
                {
                    Text = foundCar.Colour.ToString()
                },
                year_car_textBox =
                {
                    Text = foundCar.MonthOfFirstRegistration.ToString()
                }
            };*/
            /*if (car.CustomerId == 1)
            {
                addCar.customer_fullName_car.Content = customer.FullName;
            }
            addCar.Show();*/
        }

    }

}
