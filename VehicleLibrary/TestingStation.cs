using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public static class TestingStation
    {
        public static int RunTests(Vehicle vehicle)
        {
            int Completion = 0;
            Completion += CheckTotalMiles(vehicle);
            Completion += CheckCheckEngineLight(vehicle);
            Completion += CheckRecentOilChange(vehicle);
            Completion += CheckHasSeatbelts(vehicle);
            Completion += CheckSpeedometerWorks(vehicle);
            Completion += CheckOdometerWorks(vehicle);
            Completion += CheckDoorsWork(vehicle);
            Completion += CheckHasAirbags(vehicle);
            Completion += CheckShiftingProblems(vehicle);
            Completion += CheckBrakesWork(vehicle);
            Completion += CheckTiresNew(vehicle);
            Completion += CheckTiresFull(vehicle);
            Completion += CheckLightsWork(vehicle);
            Completion += CheckIsLoud(vehicle);
            Completion += CheckIdolsCorrectly(vehicle);
            Completion += CheckNewBattery(vehicle);
            Completion += CheckJumpstart(vehicle);
            Completion += CheckOverheat(vehicle);
            Completion += CheckDifficultBraking(vehicle);
            Completion += CheckDifficultTurning(vehicle);
            Completion += CheckLowEngineOil(vehicle);
            return Completion;
        }

        private static int CheckLowEngineOil(Vehicle vehicle)
        {
            if (vehicle.LowEngineOil)
            { 
                return 0;
            }
            else
            {
                return 2;
            }
        }

        private static int CheckDifficultTurning(Vehicle vehicle)
        {
            if (vehicle.DifficultTurning)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }

        private static int CheckDifficultBraking(Vehicle vehicle)
        {
            if (vehicle.DifficultBraking)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }

        private static int CheckOverheat(Vehicle vehicle)
        {
            if (vehicle.Overheat)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }

        private static int CheckJumpstart(Vehicle vehicle)
        {
            if (vehicle.Jumpstart)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }

        private static int CheckNewBattery(Vehicle vehicle)
        {
            if (vehicle.NewBattery)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        private static int CheckTotalMiles(Vehicle vehicle)
        {
            if(int.Parse(vehicle.TotalMiles) >= 150000)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        private static int CheckCheckEngineLight(Vehicle vehicle)
        {
            if(vehicle.CheckEngineLight)
            {
                return 0;
            }
            else
            {
                return 10;
            }
        }
        private static int CheckRecentOilChange(Vehicle vehicle)
        {
            if(vehicle.RecentOilChange)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckHasSeatbelts(Vehicle vehicle)
        {
            if(vehicle.HasSeatbelts)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckSpeedometerWorks(Vehicle vehicle)
        {
            if(vehicle.SpeedometerWorks)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckOdometerWorks(Vehicle vehicle)
        {
            if (vehicle.OdometerWorks)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckDoorsWork(Vehicle vehicle)
        {
            if(vehicle.DoorsWork)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckHasAirbags(Vehicle vehicle)
        {
            if(vehicle.HasAirbags)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckShiftingProblems(Vehicle vehicle)
        {
            if(vehicle.ShiftingProblems)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        private static int CheckBrakesWork(Vehicle vehicle)
        {
            if(vehicle.BrakesWork)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckTiresNew(Vehicle vehicle)
        {
            if(vehicle.TiresNew)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckTiresFull(Vehicle vehicle)
        {
            if(vehicle.TiresFull)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckLightsWork(Vehicle vehicle)
        {
            if(vehicle.LightsWork)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        private static int CheckIsLoud(Vehicle vehicle)
        {
            if(vehicle.IsLoud)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        private static int CheckIdolsCorrectly(Vehicle vehicle)
        {
            if(vehicle.IdolsCorrectly)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }


        //....................................
        //public float EngineOil { get; set; }
        //public float TransmissionFluid { get; set; }
        //public float Coolant { get; set; }
        //public float BrakeFluid { get; set; }
        //public float PowerSteeringFluid { get; set; }
        //public bool CanDrive { get; set; }
    }
}
