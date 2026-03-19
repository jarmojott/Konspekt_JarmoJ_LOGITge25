namespace TeemaStruct.Vehicles
{
    /*
     * Kasutates koolonit saab annab panna 1 klassi pärinema teisest millega tulevad kõik päritud klassi omadused kaasa.
     * Uuele klassile saab alati lisada juurde unikaalseid omadusi mida päritud klassil pole.
     */
    public class Car : Vehicle
    {
        public int BootVolume;
        public int SeatCount;

        public Car(string carModel, CarMark carMark, string carPlate, string carColor, int carWeight, List<string> carAssesories) : base(carModel, carMark, carPlate, carColor, carWeight, carAssesories)
        {
        }
    }
}
