using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemaStruct.Vehicles
{
    public class Truck : Vehicle
    {

        public int LoadWeight;
        public int EnginePower;

        public Truck(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) : base(carModel, carMark, carPlate, carColor, carWeight, carAssesories)
        {
        }
    }
}
