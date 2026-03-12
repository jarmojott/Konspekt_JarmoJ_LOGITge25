namespace TeemaStruct
{
   public enum CarMark
    {
        Toyota, Ford, Subaru
    }
    internal class Car
    {
        string Model;
        CarMark Mark;
        string Plate;
        string Color;
        int Weight = 0;
        List<string>? Assesories;

        public Car(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) {
            Model = carModel;
            Mark = carMark;
            Plate = carPlate;
            Color = carColor;
            Weight = carWeight;
            Assesories = carAssesories;
        }
        
        public string getInfo()
        {
            return $"This {Mark} {Model} car is {Color} and weighs {Weight} kg with registration {Plate}";
        }

        public void printAssecories()
        {
            Console.WriteLine("This car has: "+string.Join(',', Assesories));
        }
    }
}
