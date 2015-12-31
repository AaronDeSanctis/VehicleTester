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
using VehicleLibrary;

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
            UnapprovedVehicles.ItemsSource = Database.GetUnapprovedVehicles();
            ApprovedVehicles.ItemsSource = Database.GetApprovedVehicles();
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Show();
            (App.Current.MainWindow as MainWindow).Show();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UnapprovedVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ApprovedVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
