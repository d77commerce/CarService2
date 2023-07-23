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

namespace CarService2
{
    /// <summary>
    /// Interaction logic for Add_car.xaml
    /// </summary>
    public partial class Add_car : Window
    {
        public Add_car()
        {
            InitializeComponent();
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Full_info_Click(object sender, RoutedEventArgs e)
        {
            var car = new Car()
            {
                Make = make_car_textBox.Text,
                RegistrationNumber = reg_car_textBox.Text,
                

            };
        }

        private void Add_customer_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Cuctomer();
            var customerAdd = new CustomerAdd()
            {
                Id = 1,
                FullName = "John Doe",
                PhoneNumber = "0777777",
                Email = "john.doe@example.com",
                CompanyName = "Onyx"
            };
            customer.customer_Id.Text = customerAdd.Id.ToString();
            customer.customer_full_name.Text= customerAdd.FullName.ToString();
            customer.customer_phone_No.Text = customerAdd.PhoneNumber.ToString();
            customer.customer_email.Text = customerAdd.Email.ToString();
            customer.customer_company_name.Text = customerAdd.CompanyName.ToString();
            customer.Show();
        }
    }
}
