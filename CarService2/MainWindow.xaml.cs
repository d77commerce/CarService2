using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
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
        //  private IEnumerable<CustomerDb> Customers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LoadCustomers();
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
            var regNo = reg_No_filld;
            if (regNo != null)
            {
                CarServiceNew.CarServiceByReg(regNo.Text);
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

        /*private void customer_comboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            CustomerDb customer = new CustomerDb();
            _dbContext.Database.OpenConnection();
            CustomerDb customers = _dbContext.Customers.;
            _dbContext.Database.CloseConnection();
            customer_comboBox.Items.Clear();

            customer_comboBox.ItemsSource = customers;


        }*/

        private void LoadCustomers()
        {
            customer_comboBox.Items.Clear();

            try
            {
                _dbContext.Database.OpenConnection();
                // var foundCustomer = _dbContext.Customers;
                var foundCustomer = _dbContext.Customers;

                if (foundCustomer != null)
                {
                    foreach (var customer in foundCustomer)
                    {
                        customer_comboBox.Items.Add(customer.FullName.ToString());

                    }
                }
                else
                {
                    // Handle the case where no customers were found
                    MessageBox.Show("No customers found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the database operation
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }
        }
        private void customer_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if an item is selected (it could be null if nothing is selected)
            if (e.AddedItems.Count > 0)
            {
                // Assuming your ComboBox items are of type 'Customer', you should cast the selected item accordingly.
                string name = (string)e.AddedItems[0];
                int selectedIndex = customer_comboBox.SelectedIndex+1;
                var client = _dbContext.Customers.FirstOrDefault(c=>c.Id==selectedIndex);

               // MessageBox.Show(one);
                // Create a new instance of the 'Cuctomer' window
                Cuctomer cuctomer = new Cuctomer();
                cuctomer.customer_full_name.Text = client.FullName;
                cuctomer.customer_Id.Text =client.Id.ToString();
                cuctomer.customer_email.Text = client.Email.ToString();
                cuctomer.customer_phone_No.Text = client.PhoneNumber.ToString();
                cuctomer.customer_company_name.Text=client.CompanyName.ToString();
                /*
                // Set the 'customer_full_name' property of the 'Cuctomer' window with the selected customer's full name
                cuctomer.customer_full_name.Text = selectedCustomer.FullName;
                */

                // Show the 'Cuctomer' window
                cuctomer.Show();
            }
        }

        private void Find_byPhone_Click(object sender, RoutedEventArgs e)
        {
            string customerPhone =  phone_textBox.Text;
           
            try
            {
                _dbContext.Database.OpenConnection();
                // var foundCustomer = _dbContext.Customers;
                var foundPhone = _dbContext.Customers.FirstOrDefault(c=>c.PhoneNumber==customerPhone);

                if (foundPhone != null)
                {
                    MessageBox.Show(foundPhone.FullName);
                }
                else
                {
                    // Handle the case where no customers were found
                    MessageBox.Show("No customers found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occurred during the database operation
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }
        }

        private void add_new_customer_Click(object sender, RoutedEventArgs e)
        {
            Cuctomer cuctomer = new Cuctomer();
            cuctomer.Show();
        }
    }
}

