﻿using System;
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
    /// Interaction logic for TaskChangeOil.xaml
    /// </summary>
    public partial class TaskChangeOil : Window
    {
        public TaskChangeOil()
        {
            InitializeComponent();
        }


        private void save_oil_task_btn_Click(object sender, RoutedEventArgs e)
        {
            var oilLabel = new PrintOilLabel()
            {
                Mileage = Convert.ToInt32(mileage_textBox.Text),
                EngineOil = engine_comboBox.SelectionBoxItem.ToString(),
                EngineOilBrand = Engine_producer_textBox.Text,
                OilFilter = filter_oil_check.IsChecked != null && filter_oil_check.IsChecked.Value,
                GearOil = gear_ComboBox.SelectionBoxItem.ToString(),
                GearOilBrand = gear_producer_textBox.Text,
                GearFilter = filter_gear_check.IsChecked != null && filter_gear_check.IsChecked.Value,
                Automatic = gear_automatic_check.IsChecked != null && gear_automatic_check.IsChecked.Value,
                HydraulicOil = hydr_comboBox.SelectionBoxItem.ToString(),
                HydraulicOilBrand = hyd_producer_textBox.Text,
                DifferentialOil = deffere_comboBox.SelectionBoxItem.ToString(),
                DifferentialOilBrand = deff_producer_textBox.Text,
                AirFilter = air_filter_check.IsChecked != null && air_filter_check.IsChecked.Value,
                CabinFilter = cabine_filter_check.IsChecked != null && cabine_filter_check.IsChecked.Value,
                ResetComputer = reset_computer_check.IsChecked != null && reset_computer_check.IsChecked.Value
            };
            if (oilLabel.Mileage == 0)
            {
                MessageBox.Show("Fill The Mileage !");
                return;
            }
            string result = TaskToHtml.ConvertTaskOilToHtml(oilLabel);
         ShowOilLabel oilLabelShow = new ShowOilLabel();
           oilLabelShow.DisplayOilLabel(result,oilLabel);
           oilLabelShow.Show();
           Close();
        }

    }
}
