using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public string BedSize { get; set; }
        public int TowingCapacity { get; set; }
        public string Logo { get; set; }
        public string Owner { get; set; }
        public int NumberOfWheels { get; set; }
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }
        public int maxSpeed { get; set; }
    }

}