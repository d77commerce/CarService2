using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;

namespace CarService2.Classes
{
    public class FullDvlaInfo
    {

        private DvlaCarModel dvlaCarModel;

        public FullDvlaInfo()
        {
            dvlaCarModel = new DvlaCarModel();

        }
        public async void FullDvlaInfoOne(string Reg)
        {
            string regNo = Reg;
            var response3 = await dvlaCarModel.MakeApiRequest(regNo);

            //  JObject jsonObject = JObject.Parse(response3);
            // var htmlDvlaModel = ConvertToHtml.ConvertJsonToHtml(response3, regNo);


            var obj = JsonConvert.DeserializeObject<Car>(response3);
            int idOfCustomer = 1;

            var addCar = new Add_car
            {
                reg_car_textBox =
                {
                    Text = obj.RegistrationNumber.ToString().ToUpper()
                },
                fuel_car_textBox =
                {
                    Text = obj.FuelType.ToString()
                },
                make_car_textBox =
                {
                    Text = obj.Make.ToString()
                },
                model_car_textBox =
                {
                    Text = obj.Colour.ToString()
                },
                year_car_textBox =
                {
                    Text = obj.MonthOfFirstRegistration.ToString()
                }
            };
            addCar.Show();

            var optionsBuilder = new DbContextOptionsBuilder<CarContext>();
            optionsBuilder.UseSqlite("Data Source=car_database.db");
            using (var context = new CarContext(optionsBuilder.Options))
            {
                // Perform database operations using the context
                CarDb car = new CarDb
                {
                    RegistrationNumber = obj.RegistrationNumber,
                    FuelType = obj.FuelType,
                    Make = obj.Make,
                    Colour = obj.Colour,
                    MonthOfFirstRegistration = obj.MonthOfFirstRegistration,
                    EngineCapacity = obj.EngineCapacity,
                    CustomerId = idOfCustomer

                };
                context.Cars.Add(car);
                context.SaveChanges();

            }



        }
    }
}
