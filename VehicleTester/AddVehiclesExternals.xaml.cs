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
    /// Interaction logic for AddVehiclesExternals.xaml
    /// </summary>
    public partial class AddVehiclesExternals : Window
    {
        Window lastWindow;
        VehicleFactory vehicleFactory;
        public AddVehiclesExternals(Window lastWindow, VehicleFactory vehicleFactory)
        {
            InitializeComponent();
            this.lastWindow = lastWindow;
            this.vehicleFactory = vehicleFactory;
            Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide(); lastWindow.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            vehicleFactory.UpdateExternals((bool)BrakesBox.IsChecked, (bool)NewTiresBox.IsChecked, (bool)TiresFullBox.IsChecked, (bool)LightsBox.IsChecked, (bool)LoudBox.IsChecked, (bool)IdolBox.IsChecked);
            Hide();
            vehicleFactory.vehicle.Completion = TestingStation.RunTests(vehicleFactory.vehicle);
            ChooseNextWindow();
        }

        private void ChooseNextWindow()
        {
            if(vehicleFactory.vehicle.Completion >= 35)
            {
                MessageBox.Show("Congratulations!! Your vehicle has passed with a score of " + vehicleFactory.vehicle.Completion.ToString(), "Vehicle Approved");
                VehicleApproved vehicleApproved = new VehicleApproved(vehicleFactory, this);
            }
            else
            {
                MessageBox.Show("Your vehicle has failed with a score of  " + vehicleFactory.vehicle.Completion.ToString() + ". Please take your vehicle in to a mechanic as soon as possible. Here is a list of mechanics in your area.", "Vehicle Denied");
                VehicleUnapproved vehicleUnapproved = new VehicleUnapproved(vehicleFactory, this);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearSlate();
        }

        private void ClearSlate()
        {
            BrakesBox.IsChecked = false; NewTiresBox.IsChecked = false; TiresFullBox.IsChecked = false;
            LightsBox.IsChecked = false; LoudBox.IsChecked = false; IdolBox.IsChecked = false;
        }

        private void BrakesBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void NewTiresBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TiresFullBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LightsBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LoudBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void IdolBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
