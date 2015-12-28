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

namespace VehicleTester
{
    /// <summary>
    /// Interaction logic for AddVehicles.xaml
    /// </summary>
    public partial class AddVehicles : Window
    {
        public AddVehicles()
        {
            InitializeComponent();
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            VehicleLibrary.VehicleFactory vehicleFactory = new VehicleLibrary.VehicleFactory(MakeText.Text, ModelText.Text, YearText.Text, TotalMilesText.Text, (bool)CheckEngineLight.IsChecked, (bool)Oil.IsChecked);
            Close();
        }

        private void ModelText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MakeText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void YearText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TotalMilesText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckEngineLight_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Oil_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}