using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarService2.Classes;

namespace CarService2
{
    /// <summary>
    /// Interaction logic for OilLabelPrint.xaml
    /// </summary>
    public partial class OilLabelPrint : Page
    {
        private readonly PrintOilLabel label;
      public OilLabelPrint(PrintOilLabel _label)
        {
            label = _label;
            InitializeComponent();
            
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {

                printDialog.PrintVisual((Visual)this.Content, "Oniks");
            }
        }

        private void date_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            date.Text = time.ToShortDateString();
        }

        private void oil_spec_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            oil_spec_textBox.Text = label.EngineOil;
        }

        private void gearOil_spec_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            gearOil_spec_textBox.Text = label.GearOil;
        }

        private void SteeringOil_spec_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SteeringOil_spec_textBox.Text = label.HydraulicOil;
        }

        private void brand_oil_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            brand_oil_textBox.Text = label.EngineOilBrand;
        }

        private void brand_gearOil_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            brand_gearOil_textBox.Text = label.GearOilBrand;
        }

        private void brand_steeringOil_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            brand_steeringOil_textBox.Text = label.HydraulicOilBrand;
        }

        private void mileage_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mileage_textBox.Text = $"{label.Mileage+5000}";
        }

        private void oilFilter_texBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (label.OilFilter == true) oilFilter_texBox.Text = "YES";
        }

        private void airFilter_texBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (label.AirFilter == true) airFilter_texBox.Text = "YES";
        }

        private void cabinFilter_texBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (label.CabinFilter == true) cabinFilter_texBox.Text = "YES";
        }

        private void gearOilFilter_texBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (label.GearFilter == true) gearOilFilter_texBox.Text = "YES";
        }

        private void reset_texBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (label.ResetComputer == true) reset_texBox.Text = "YES";
        }
    }
}
