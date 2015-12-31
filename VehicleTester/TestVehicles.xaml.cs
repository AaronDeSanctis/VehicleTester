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
        int ApprovedCount = 0;
        public TestVehicles()
        {
            InitializeComponent();
            UnapprovedVehicles.ItemsSource = Database.GetUnapprovedVehicles();
            ApprovedVehicles.ItemsSource = Database.GetApprovedVehicles();
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
            (App.Current.MainWindow as MainWindow).Show();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            foreach (Vehicle vehicle in Database.GetUnapprovedVehicles())
            {
                if(UnapprovedVehicles.SelectedItem.ToString() == vehicle.Title + vehicle.Completion.ToString())
                {
                    vehicle.Completion = TestingStation.RunTests(vehicle);
                    if(vehicle.Completion >= 55)
                    {
                        ApprovedCount++;
                        Database.SaveToApproved(vehicle);
                    }

                }
            }
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have approved " + ApprovedCount.ToString() + " vehicles.", "Thank you for testing");
            Close();
            (App.Current.MainWindow as MainWindow).Show();

        }

        private void UnapprovedVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ApprovedVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
