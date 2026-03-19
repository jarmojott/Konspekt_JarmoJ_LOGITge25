using System.Drawing;
using System.Reflection;

namespace TeemaStruct.Vehicles
{
    public class Train : Vehicle
    {
        public int WagonCount;
        public int CompartmentCount;
        public bool hasCatering;


        public Train(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) : base(carModel, carMark, carPlate, carColor, carWeight, carAssesories)
        {
        }

        /// <summary>
        /// Returns info about train
        /// </summary>
        /// <returns></returns>
        public override string getInfo()

            /*
             * Kaitstud sõna 'override' abil saab ülelaadida pärineva klaasi meetodit millele on lisatud 'virtual' oamdus. 
             */
        {
            return $"This {Mark} {Model} car is {Color} and has {WagonCount} wagons with {CompartmentCount} compartments.";
        }
    }
}
