using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;
using CarService2.Classes;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using static ConvertToHtml;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CarContext _dbContext = new CarContext(new DbContextOptions<CarContext>());

        public MainWindow()
        {
            InitializeComponent();
        }
        private void mine_windouw_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer _timer = new DispatcherTimer();
            _timer.Interval = new System.TimeSpan(0, 0, 1);
            // _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += TextBox_TextChanged;
            _timer.Start();

        }
        private void Find_byReg_Click(object sender, RoutedEventArgs e)
        {
            var customerId = 1;
            var regNo = reg_No_filld;
            if (regNo != null)
            {
                CarServiceNew.CarServiceByReg(regNo.Text, customerId);
            }
            else
            {
                MessageBox.Show("Reg Number is not valid!");
            }

        }

        private void TextBox_TextChanged(object? sender, EventArgs eventArgs)
        {
            if (true)
            {


                DateTime time = new DateTime();
                time = DateTime.Now;
                time_display.Text = time.ToString();
            }


        }

        private void Find_ByCustomer_Name_Click(object sender, RoutedEventArgs e)
        {
            string Reg_No = reg_No_filld.Text.ToUpper();
            string jsonData = @"
{
  ""name"": ""John Doe"",
  ""age"": 30,
  ""email"": ""john.doe@example.com"",
  ""address"": ""123 Main St""
}";

            string folderPath = "C:\\Users\\d77co\\Source\\Repos\\d77commerce\\CarService2\\CarService2\\HtmlAddJson\\"; // Provide the desired folder path here

            ConvertJsonToHtml(jsonData, Reg_No);

        }

        private void Find_full_car_history_Click(object sender, RoutedEventArgs e)
        {
            _dbContext.Database.OpenConnection();
          //  var allCars = _dbContext.Cars.ToList();

         
            string registrationNumber = regNo_full_history.Text;

            // Find the car by registration number

            var foundCar = _dbContext.Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

            if (foundCar != null)
            {
                // Display car information
                MessageBox.Show($"Car Reg No: {foundCar.RegistrationNumber}" +
                                    $"\nMake: {foundCar.Make}" +
                                    $"\nColour: {foundCar.Colour}" +
                                    $"\nEngine Capacity: {foundCar.EngineCapacity}" +
                                    $"\nFuel Type: {foundCar.FuelType}" +
                                    $"\nFirst Reg : {foundCar.MonthOfFirstRegistration}");
            }
            else
            {
                MessageBox.Show("Car not found.");
            }
            _dbContext.Database.CloseConnection();
        }
    }
}
