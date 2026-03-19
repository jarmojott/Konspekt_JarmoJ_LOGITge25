namespace TeemaStruct
{
   public enum CarMark
    {
        Toyota, Ford, Subaru
    }
    public class Vehicle
    {
        public string Model;
        public CarMark Mark;
        public string Plate;
        public string Color;
        public int Weight = 0;
        public List<string>? Assesories;

        public Vehicle(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) {
            Model = carModel;
            Mark = carMark;
            Plate = carPlate;
            Color = carColor;
            Weight = carWeight;
            Assesories = carAssesories;
        }
        
        /// <summary>
        /// Returns general info about Vehicle
        /// </summary>
        /// <returns></returns>
        public virtual string getInfo()
        {
            /*
             * Kaitstud sõna virtual laseb meetodit ülelaadida (override)
             */
            return $"This {Mark} {Model} car is {Color} and weighs {Weight} kg with registration {Plate}";
        }

        public void printAssecories()
        {
            Console.WriteLine("This car has: "+string.Join(',', Assesories));
        }
    }
}
