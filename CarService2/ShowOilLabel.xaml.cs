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
    /// Interaction logic for ShowOilLabel.xaml
    /// </summary>
    public partial class ShowOilLabel : Window
    {
        private PrintOilLabel _oilLabel;
        public ShowOilLabel()
        {
            InitializeComponent();
        }
        public void DisplayOilLabel(string oilLabelHtml, PrintOilLabel oilLabel)
        {
            _oilLabel = oilLabel;
            html_show_oilLabel_model.NavigateToString(oilLabelHtml);

        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void print_oil_label_Click(object sender, RoutedEventArgs e)
        {
            /*
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Next change Due : {_oilLabel.Mileage + 5000}");
            if (_oilLabel.EngineOil != null)
            {
                sb.AppendLine($"{_oilLabel.EngineOil}");
                sb.Append($" {_oilLabel.EngineOilBrand}  ");
                if (_oilLabel.OilFilter == true)
                {
                    sb.Append("oil filter  YES");
                }
            }
            if (_oilLabel.GearOil != null)
            {
                sb.AppendLine(_oilLabel.GearOil);
                sb.Append($" {_oilLabel.GearOilBrand}  ");
                if (_oilLabel.Automatic == true)
                {
                    sb.Append("Automatic  ");
                    if (_oilLabel.GearFilter == true)
                    {
                        sb.Append("Gear filter YES");
                    }
                }

            }

            if (_oilLabel.HydraulicOil != null)
            {
                sb.AppendLine(_oilLabel.HydraulicOil);
                sb.Append($" {_oilLabel.HydraulicOilBrand}");
            }
            if (_oilLabel.DifferentialOil != null)
            {
                sb.AppendLine(_oilLabel.DifferentialOil);
                sb.Append($" {_oilLabel.DifferentialOilBrand}");
            }

            sb.AppendLine();
            if (_oilLabel.AirFilter == true)
            {
                sb.AppendLine("air filter - YES");

            }
            if (_oilLabel.CabinFilter == true)
            {
                sb.AppendLine("cabin filter - YES");

            }
            if (_oilLabel.ResetComputer == true)
            {
                sb.AppendLine("reset Computer - YES");

            }

            //  MessageBox.Show(sb.ToString());
            string myContent = sb.ToString();
            string pdfFilePath = "oillabelpdf.pdf";
            float pdfWidth = 500f;  // Width in points (1 inch = 72 points).
            float pdfHeight = 200f; // Height in points (1 inch = 72 points).

           GeneratePDF.GeneratePDFfile(myContent, pdfFilePath, pdfWidth, pdfHeight);
           */
            var labelPrint = new OilLabelPrint(_oilLabel);
            Close();
        }
    }
}
