using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string CargoHoldSize { get; set; }
        public int NumberOfSeatRows { get; set; }
        public string Logo { get; set; }
        public string Owner { get; set; }
        public int NumberOfWheels { get; set; }
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }
        public int maxSpeed { get; set; }
    }
}

