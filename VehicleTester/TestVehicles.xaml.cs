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
    /// Interaction logic for TestVehicles.xaml
    /// </summary>
    public partial class TestVehicles : Window
    {
        public TestVehicles()
        {
            InitializeComponent();
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}