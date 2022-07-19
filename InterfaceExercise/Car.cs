using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public string TrunkSize { get; set; }
        public int NumberOfDoors { get; set; }
        public string Logo { get; set; }
        public string Owner { get; set; }
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }
        public int maxSpeed { get; set; }
        public int NumberOfWheels { get; set; }
    }
}

