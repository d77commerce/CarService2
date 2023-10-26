using CarService2.Classes;
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
    /// Interaction logic for ShowOrderLabel.xaml
    /// </summary>
    public partial class ShowOrderLabel : Window
    {
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
            var labelPrint = new OrderA4Print(_label);
            Close();
        }
    }
}
