namespace CarService2.Classes
{
    public class CarServiseNew
    {


        public static void CarServiseByNomber(string regNo, int customerId)
        {
            var customer = new CustomerAdd()
            {
                Id = customerId,
                FullName = "John Doe",
                PhoneNumber = "0777777",
                Email = "john.doe@example.com",
                CompanyName = "Onyx"
            };


            var car = new Car(regNo);
            var addCar = new Add_car();
            addCar.reg_car_textBox.Text = car.RegistrationNumber.ToString().ToUpper();
            addCar.fuel_car_textBox.Text = car.FuelType.ToString();
            addCar.make_car_textBox.Text = car.Make.ToString();
            addCar.model_car_textBox.Text = car.TypeApproval.ToString();
            addCar.year_car_textBox.Text = car.YearOfManufacture.ToString();
            if (car.CustomerId == 1)
            {
                addCar.customer_fullName_car.Content = customer.FullName;
            }
            addCar.Show();
        }
    }

}
