using System;
using System.Text;
using System.Windows;
using VehicleLibrary;
using System.Diagnostics;
using System.Device.Location;

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
            Triangulate();
        }

        private void Triangulate()
        {
            GeoCoordinate g = new GeoCoordinate();
            double latitude = g.Latitude;
            double longitude = g.Longitude;

            StringBuilder searchstring = new StringBuilder("https://www.google.com/maps/search/mechanics/@");

            searchstring.Append(latitude + ", ");
            searchstring.Append(longitude);
            searchstring.Append(",13z");
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = searchstring.ToString();
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Form2 frm = new Form2(searchstring.ToString());
            //frm.Show();
        }

    }
}
