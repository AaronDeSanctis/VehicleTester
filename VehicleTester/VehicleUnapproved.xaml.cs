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
    /// Interaction logic for VehicleUnapproved.xaml
    /// </summary>
    public partial class VehicleUnapproved : Window
    {
        Window lastWindow;
        VehicleFactory vehicleFactory;
        public VehicleUnapproved(VehicleFactory vehicleFactory, Window lastWindow)
        {
            InitializeComponent();
            Show();
            this.lastWindow = lastWindow;
            this.vehicleFactory = vehicleFactory;
            Failed.Content = "Your score is " + vehicleFactory.vehicle.Completion.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            lastWindow.Show();
        }


        private void RestartQuestionaire_Click(object sender, RoutedEventArgs e)
        {
            Close();
            AddVehicles addVehicles = new AddVehicles();
        }

        private void FindMechanic_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
