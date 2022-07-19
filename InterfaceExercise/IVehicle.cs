using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int NumberOfWheels { get; set; }

        public string EngineType { get; set; }

        public int NumberOfSeats { get; set; }

        public int maxSpeed { get; set; }
    }

    
}

