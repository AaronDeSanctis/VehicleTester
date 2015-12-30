using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VehicleLibrary
{
    public class VehicleFactory
    {
        public Vehicle vehicle;

        public VehicleFactory(string Make, string Model, string Year, string TotalMiles, string LicensePlate, bool CheckEngineLight, bool RecentOilChange)
        {
            CreateVehicle(Make, Model, Year, TotalMiles, LicensePlate, CheckEngineLight, RecentOilChange);
        }

        private void CreateVehicle(string Make, string Model, string Year, string TotalMiles, string LicensePlate, bool CheckEngineLight, bool RecentOilChange)
        {
            vehicle = new Vehicle();
            vehicle.SetVehicle(Make, Model, Year, TotalMiles, LicensePlate, CheckEngineLight, RecentOilChange, int.Parse(Database.GetNewID()));
            Database.SaveVehicle(vehicle);
        }

        public void UpdateFluids(string EngineOil, string TransmissionFluid, string Coolant, string BrakeFluid, string PowerSteeringFluid)
        {
            vehicle.SetFluids(float.Parse(EngineOil), float.Parse(TransmissionFluid) ,float.Parse(Coolant), float.Parse(BrakeFluid), float.Parse(PowerSteeringFluid));
            Database.UpdateCurrentVehicle(vehicle);
        }

        public void UpdateInterior(bool HasSeatbelts, bool DoorsWork, bool SpeedometerWorks, bool OdometerWorks, bool HasAirbags, bool ShiftingProblems)
        {
            vehicle.SetInterior(HasSeatbelts, DoorsWork, SpeedometerWorks, OdometerWorks, HasAirbags, ShiftingProblems);
            Database.UpdateCurrentVehicle(vehicle);
        }

        public void UpdateExternals(bool BrakesWork, bool TiresNew, bool TiresFull, bool LightsWork, bool IsLoud, bool IdolsCorrectly)
        {
            vehicle.SetExternals(BrakesWork, TiresNew, TiresFull, LightsWork, IsLoud, IdolsCorrectly);
            Database.UpdateCurrentVehicle(vehicle);
        }

        public Vehicle GetCurrentVehicle()
        {
            return vehicle;
        }
    }
}
