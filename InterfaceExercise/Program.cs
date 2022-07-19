using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

           

            //Console.WriteLine("Welcome to the dealership vehicle type and feature.");
            //Console.WriteLine("Please choose which of the following types and featues you would like!\n");

            //Console.WriteLine("If you want a Car: enter 1, SUV: enter 2, Truck: enter 3\n");
            //Console.ReadLine();

            //var input = Convert.ToInt32(Console.ReadLine());

            //if (input == 1)
            //{
            //    Console.WriteLine(car1);
            //}
            //else if (input == 2)
            //{
            //    Console.WriteLine(suv1.CargoHoldSize, suv1.EngineType, suv1.Logo, suv1.maxSpeed, suv1.NumberOfSeatRows, suv1.NumberOfSeats, suv1);
            //}
            //else if (input == 3)
            //{
            //    Console.WriteLine(truck1);
            //}

            var suv1 = new SUV();
            var car1 = new Car();
            var truck1 = new Truck();

            var VehicleList = new List<IVehicle>();

            VehicleList.Add(suv1);
            VehicleList.Add(car1);
            VehicleList.Add(truck1);


            suv1.CargoHoldSize = "Large";
            suv1.NumberOfSeatRows = 3;
            suv1.NumberOfSeats = 8;
            suv1.NumberOfWheels = 4;
            suv1.maxSpeed = 125;
            suv1.Owner = "Elon Musk";
            suv1.Logo = "0000";
            suv1.EngineType = "V8";

            car1.TrunkSize = "Small";
            car1.NumberOfDoors = 2;
            car1.NumberOfSeats = 5;
            car1.NumberOfWheels = 4;
            car1.maxSpeed = 160;
            car1.Owner = "Elon Musk";
            car1.Logo = "0000";
            car1.EngineType = "V6";

            truck1.BedSize = "Large";
            truck1.TowingCapacity = 5000;
            truck1.NumberOfSeats = 5;
            truck1.NumberOfWheels = 6;
            truck1.maxSpeed = 120;
            truck1.Owner = "Elon Musk";
            truck1.Logo = "0000";
            truck1.EngineType = "Turbo Diesel V10";

            foreach (var vehicle in VehicleList)
            {
                Console.WriteLine($"{vehicle.EngineType} {vehicle.maxSpeed}");
                Console.WriteLine($"{vehicle.NumberOfSeats} {vehicle.NumberOfWheels}");
                Console.WriteLine($"{vehicle.EngineType} {vehicle.NumberOfSeats}");

                //Console.WriteLine(suv1.CargoHoldSize, suv1.EngineType, suv1.Logo, suv1.maxSpeed, suv1.NumberOfSeatRows, suv1.NumberOfSeats, suv1.NumberOfWheels, suv1.Owner);
                //Console.WriteLine(car1.EngineType, car1.Logo, car1.maxSpeed, car1.NumberOfDoors, car1.NumberOfSeats, car1.NumberOfWheels, car1.Owner, car1.TrunkSize); ;
                //Console.WriteLine(truck1.BedSize, truck1.EngineType, truck1.Logo, truck1.maxSpeed, truck1.NumberOfSeats, truck1.NumberOfWheels, truck1.Owner, truck1.TowingCapacity);
            }

        }
    }
}
