using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemaStruct.Vehicles
{
    internal class Ship : Vehicle
    {
        public int LifeBoatCount;
        public int DisplacementVolume;
        public int CabinCount;
        public bool hasCarStorage;

        public Ship(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) : base(carModel, carMark, carPlate, carColor, carWeight, carAssesories)
        {
        }
    }
}
