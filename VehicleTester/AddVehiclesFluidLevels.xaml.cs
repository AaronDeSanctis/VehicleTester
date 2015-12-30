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
            vehicleFactory.UpdateFluids(EngineOilText.Text, TransmissionFluidText.Text, CoolantText.Text, BrakeFluidText.Text, PowerSteeringFluidText.Text);
            Hide();
            AddVehiclesInterior interior = new AddVehiclesInterior(this, vehicleFactory);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearSlate();
        }

        private void ClearSlate()
        {
            EngineOilText.Clear(); TransmissionFluidText.Clear(); CoolantText.Clear(); BrakeFluidText.Clear(); PowerSteeringFluidText.Clear();
        }

        private void EngineOilText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TransmissionFluidText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CoolantText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BrakeFluidText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PowerSteeringFluidText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
