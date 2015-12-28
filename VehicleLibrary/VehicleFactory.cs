using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class VehicleFactory
    {
        int VehiNum = 0;
        public VehicleFactory(string Make, string Model, string Year, string TotalMiles, bool CheckEngineLight, bool RecentOilChange)
        {
            CreateVehicle(Make, Model, Year, TotalMiles, CheckEngineLight, RecentOilChange, ChooseNewVehicleNumber());
        }

        private int ChooseNewVehicleNumber()
        {
            return VehiNum++;
        }

        private void CreateVehicle(string Make, string Model, string Year, string TotalMiles, bool CheckEngineLight, bool RecentOilChange, int VehicleNumber)
        {
            Vehicle vehicle = new Vehicle(Make, Model, Year, TotalMiles, CheckEngineLight, RecentOilChange, VehicleNumber);
            Database.SaveVehicle(vehicle);
        }
    }
}
