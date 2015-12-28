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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VehicleTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVehicle_Click(object sender, RoutedEventArgs e)
        {
            AddVehicles addVehicles = new AddVehicles();
        }

        private void TestVehicle_Click(object sender, RoutedEventArgs e)
        {
            TestVehicles testVehicles = new TestVehicles();
        }

        private void GetDirections_Click(object sender, RoutedEventArgs e)
        {
            Directions directions = new Directions();
        }
    }
}
