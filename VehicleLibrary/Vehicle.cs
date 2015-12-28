using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }
        public string TotalMiles { get; private set; }
        public bool CheckEngineLight { get; private set; }
        public bool RecentOilChange { get; private set; }
        public int VehicleNumber { get; private set; }

        public Vehicle(string Make, string Model, string Year, string TotalMiles, bool CheckEngineLight, bool RecentOilChange, int VehicleNumber)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.TotalMiles = TotalMiles;
            this.CheckEngineLight = CheckEngineLight;
            this.RecentOilChange = RecentOilChange;
            this.VehicleNumber = VehicleNumber;
        }
    }
}
