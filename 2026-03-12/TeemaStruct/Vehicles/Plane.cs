namespace TeemaStruct.Vehicles
{
    internal class Plane : Vehicle
    {
        public bool hasJetEngine;
        public int WingSpan;
        public int PassengerCount;

        public Plane(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) : base(carModel, carMark, carPlate, carColor, carWeight, carAssesories)
        {
        }
    }
}
