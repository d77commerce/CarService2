using System.Windows;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using CarService2.Classes;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for ShowDvlaModel.xaml
    /// </summary>
    public partial class ShowDvlaModel : Window
    {
        private string dvlaResultHtml;
        public ShowDvlaModel()
        {
            InitializeComponent();
          
        }

   
        public void Display(string dvlaHtml)
        {
            dvlaResultHtml=dvlaHtml;
            html_show_dvla_model.NavigateToString(dvlaHtml);
            
        }

        private void print_dvla_info_Click(object sender, RoutedEventArgs e)
        {

           SaveHtmlToFile.SaveHtml(dvlaResultHtml);


        }

        private void customer_company_name_Copy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
