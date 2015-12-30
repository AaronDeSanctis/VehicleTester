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
        public bool HasSeatbelts { get; set; }
        public bool SpeedometerWorks { get; set; }
        public bool OdometerWorks { get; set; }
        public bool DoorsWork { get; set; }
        public bool HasAirbags { get; set; }
        public bool ShiftingProblems { get; set; }
        public bool BrakesWork { get; set; }
        public bool TiresNew { get; set; }
        public bool TiresFull { get; set; }
        public bool LightsWork { get; set; }
        public bool IsLoud { get; set; }
        public bool IdolsCorrectly { get; set; }

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

        public void SetInterior(bool HasSeatbelts, bool DoorsWork, bool SpeedometerWorks, bool OdometerWorks, bool HasAirbags, bool ShiftingProblems)
        {
            this.HasSeatbelts = HasSeatbelts;
            this.DoorsWork = DoorsWork;
            this.SpeedometerWorks = SpeedometerWorks;
            this.OdometerWorks = OdometerWorks;
            this.HasAirbags = HasAirbags;
            this.ShiftingProblems = ShiftingProblems;
        }
        
        public void SetExternals(bool BrakesWork, bool TiresNew, bool TiresFull, bool LightsWork, bool IsLoud, bool IdolsCorrectly)
        {
            this.BrakesWork = BrakesWork;
            this.TiresNew = TiresNew;
            this.TiresFull = TiresFull;
            this.LightsWork = LightsWork;
            this.IsLoud = IsLoud;
            this.IdolsCorrectly = IdolsCorrectly;
        }
    }
}
