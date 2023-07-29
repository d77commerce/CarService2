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
using CarService2.Classes;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for Add_car.xaml
    /// </summary>
    public partial class Add_car : Window
    {
        private DvlaCarModel dvlaCarModel;
        public Add_car()
        {
            InitializeComponent();
            dvlaCarModel = new DvlaCarModel();
        }



       

        private async void Full_info_Click(object sender, RoutedEventArgs e)
        {   
            string regNo = reg_car_textBox.Text;
            string response = await dvlaCarModel.MakeApiRequest(regNo);
            var htmlDvlaModel = ConvertToHtml.ConvertJsonToHtml(response, regNo);

            ShowDvlaModel dvla = new ShowDvlaModel();
               dvla.Show();
            dvla.Display(htmlDvlaModel);

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
