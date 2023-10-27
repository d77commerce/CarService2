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
                _dbContext.Database.OpenConnection();
                var newCustomer = new CustomerDb()
                {
                    FullName = customer_full_name.Text,
                    CompanyName = customer_company_name.Text,
                    PhoneNumber = customer_phone_No.Text,
                    Email = customer_email.Text,
                    IsDeleted = false
                };

                if (string.IsNullOrEmpty(newCustomer.FullName) || newCustomer.FullName.Length < 7)
                {
                    MessageBox.Show("Please enter a full name!");
                    return;
                }
                if (string.IsNullOrEmpty(newCustomer.PhoneNumber) || !newCustomer.PhoneNumber.All(char.IsDigit) || newCustomer.PhoneNumber.Length < 7)
                {
                    MessageBox.Show("Please enter a valid phone number with at least 7 digits!");
                    return;
                }

                if (string.IsNullOrEmpty(newCustomer.Email) || !newCustomer.Email.Contains("@") || !newCustomer.Email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email!");
                    return;
                }

                if (string.IsNullOrEmpty(newCustomer.CompanyName) || newCustomer.CompanyName.Length < 7)
                {
                    MessageBox.Show("Please enter a company name!");
                    return;
                }
                if (_dbContext.Customers.Any(c => c.FullName == newCustomer.FullName))
                {
                    MessageBox.Show("This customer already exists!");
                    return;
                }

                _dbContext.Customers.Add(newCustomer);
                _dbContext.SaveChanges(); // Save changes to the database

                MessageBox.Show("You've added a new client successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }
        }

        private void Delete_customer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void update_customer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _dbContext.Database.OpenConnection();
                var customer = _dbContext.Customers.FirstOrDefault(c => c.FullName == customer_full_name.Text);
                if (customer == null)
                {
                    MessageBox.Show("This client does not exist!");
                    return;
                }
                customer.FullName = customer_full_name.Text;
                customer.CompanyName = customer_company_name.Text;
                customer.PhoneNumber = customer_phone_No.Text;
                customer.Email = customer_email.Text;
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges(); // Save changes to the database
                MessageBox.Show("You've updated the client successfully!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }
        }
    }
}
