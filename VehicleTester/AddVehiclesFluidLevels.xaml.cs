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
    /// Interaction logic for AddVehiclesFluidLevels.xaml
    /// </summary>
    public partial class AddVehiclesFluidLevels : Window
    {
        Window lastWindow;
        VehicleFactory vehicleFactory;
        public AddVehiclesFluidLevels(VehicleFactory vehicleFactory, Window lastWindow)
        {
            InitializeComponent();
            Show();
            this.lastWindow = lastWindow;
            this.vehicleFactory = vehicleFactory;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            lastWindow.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            vehicleFactory.UpdateFluids((bool)NewBatteryBox.IsChecked, (bool)JumpstartBox.IsChecked, (bool)OverheatBox.IsChecked, (bool)DifficultBrakingBox.IsChecked, (bool)DifficultTurningBox.IsChecked, (bool)LowEngineOilBox.IsChecked);
            Hide();
            AddVehiclesInterior interior = new AddVehiclesInterior(this, vehicleFactory);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearSlate();
        }

        private void ClearSlate()
        {
            NewBatteryBox.IsChecked = false; JumpstartBox.IsChecked = false; OverheatBox.IsChecked = false;
            DifficultBrakingBox.IsChecked = false; DifficultTurningBox.IsChecked = false; LowEngineOilBox.IsChecked = false;
        }

        private void NewBatteryBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void JumpstartBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void OverheatBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DifficultBrakingBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DifficultTurningBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LowEngineOilBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
