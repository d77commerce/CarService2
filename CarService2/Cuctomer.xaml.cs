using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Accessibility;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for Cuctomer.xaml
    /// </summary>
    public partial class Cuctomer : Window
    {
        private CarContext _dbContext = new CarContext(new DbContextOptions<CarContext>());

        public Cuctomer()
        {
            InitializeComponent();
        }

        private void Add_customer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newCustomer = new CustomerDb()
                {
                    FullName = customer_full_name.Text,
                    CompanyName = customer_company_name.Text,
                    PhoneNumber = customer_phone_No.Text,
                    Email = customer_email.Text,
                    IsDeleted = false
                };

                _dbContext.Customers.Add(newCustomer);
                _dbContext.SaveChanges(); // Save changes to the database

                MessageBox.Show("New client added successfully!");
                Close();
                var window = new MainWindow();
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
