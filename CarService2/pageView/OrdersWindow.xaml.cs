using CarService2.Classes;
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

namespace CarService2.pageView
{
    /// <summary>
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private CarContext _dbContext = new CarContext(new DbContextOptions<CarContext>());
        public OrdersWindow()
        {
            InitializeComponent();
            DataGrid_SelectionChanged(null, null);
        }

        private async void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                await _dbContext.Database.OpenConnectionAsync();
                var allOrders = await _dbContext.OrdersDbs.ToListAsync();
                MessageBox.Show(allOrders.Count.ToString());
              var orders = new List<ShowOrders>();
              //.Where(t => t.OrderTaskId == order.Id).ToListAsync());
              //  var taskUnits = await _dbContext.TasksDb.ToListAsync();
                foreach (var order in allOrders)
                {
                    var customer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == order.CustomerId);

                    if (customer == null)
                    {
                        continue;
                    }

                    orders.Add(new ShowOrders()
                    {
                        Id = order.Id,
                        RegNo = order.RegNo,
                        Tasks = order.TaskUnits.Count().ToString(),
                        PhoneNo = customer.PhoneNumber,
                        Client = customer.FullName,
                        DateTime = order.DateTime.ToString()

                    });
                }
                order_table.ItemsSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _dbContext.Database.CloseConnection();
            }
        }
    }
}
