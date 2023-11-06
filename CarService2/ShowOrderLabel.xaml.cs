using CarService2.Classes;
using CarService2.DB;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Windows;
using CarService2.DB;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for ShowOrderLabel.xaml
    /// </summary>
    public partial class ShowOrderLabel : Window
    {
        private static CarContext dbContext = new CarContext(new DbContextOptions<CarContext>());
        private PrintTaskOrder _label;
        public ShowOrderLabel()
        {

            InitializeComponent();
        }
        public void DisplayOilLabel(string oilLabelHtml, PrintTaskOrder label)
        {
            _label = label;
            html_show_orderLabel_model.NavigateToString(oilLabelHtml);

        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void print_order_label_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(_label, Formatting.Indented);
            

            var orderNo = _label.OrderNo;
            var regNo = _label.RegNo;
            var dataTasks = json;
            var customerId = _label.CustomerId;

            var order = new OrderOfTaskDb()
            {
                RegNo = regNo,
                OrderNo = Convert.ToInt32(orderNo),
                DataTasks = dataTasks,
                CustomerId = Convert.ToInt32(customerId),

            };
            dbContext.Database.OpenConnection();
            dbContext.OrdersDbs.Add(order);
            dbContext.SaveChanges();
            dbContext.Database.CloseConnection();

            // Display the JSON string in a message box
            MessageBox.Show(json);
            var labelPrint = new OrderA4Print(_label);

            Close();
        }
    }
}
