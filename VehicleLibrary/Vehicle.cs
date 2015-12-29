using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string TotalMiles { get; set; }
        public string LiscensePlate { get; set; }
        public bool CheckEngineLight { get; set; }
        public bool RecentOilChange { get; set; }
        public int VehicleNumber { get; set; }
        public float EngineOil { get; set; }
        public float TransmissionFluid { get; set; }
        public float Coolant { get; set; }
        public float BrakeFluid { get; set; }
        public float PowerSteeringFluid { get; set; }

        public Vehicle()
        {

        }

        public void SetVehicle(string Make, string Model, string Year, string TotalMiles, string LiscensePlate, bool CheckEngineLight, bool RecentOilChange, int VehicleNumber)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.TotalMiles = TotalMiles;
            this.LiscensePlate = LiscensePlate;
            this.CheckEngineLight = CheckEngineLight;
            this.RecentOilChange = RecentOilChange;
            this.VehicleNumber = VehicleNumber;
        }

        public void SetFluids(float EngineOil, float TransmissionFluid, float Coolant, float BrakeFluid, float PowerSteeringFluid)
        {
            this.EngineOil = EngineOil;
            this.TransmissionFluid = TransmissionFluid;
            this.Coolant = Coolant;
            this.BrakeFluid = BrakeFluid;
            this.PowerSteeringFluid = PowerSteeringFluid;
        }
    }
}
