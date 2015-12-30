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
    /// Interaction logic for AddVehiclesDashboard.xaml
    /// </summary>
    public partial class AddVehiclesInterior : Window
    {
        Window lastWindow;
        VehicleFactory vehicleFactory;

        public AddVehiclesInterior(Window lastWindow, VehicleFactory vehicleFactory)
        {
            InitializeComponent();
            this.lastWindow = lastWindow;
            this.vehicleFactory = vehicleFactory;
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            lastWindow.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            vehicleFactory.UpdateInterior((bool)SeatbeltBox.IsChecked, (bool)DoorBox.IsChecked, (bool)SpeedometerBox.IsChecked, (bool)OdometerBox.IsChecked, (bool)AirbagsBox.IsChecked, (bool)ShiftingBox.IsChecked);
            AddVehiclesExternals externals = new AddVehiclesExternals(this, vehicleFactory);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearSlate();
        }

        private void ClearSlate()
        {
            SeatbeltBox.IsChecked = false; DoorBox.IsChecked = false; SpeedometerBox.IsChecked = false; OdometerBox.IsChecked = false; AirbagsBox.IsChecked = false; ShiftingBox.IsChecked = false;
        }

        private void SeatbeltBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DoorBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SpeedometerBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void OdometerBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AirbagsBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ShiftingBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
