using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Factory Pattern for Object Creation**
//Implement a `VehicleFactory` class that returns different vehicle objects (`Car`, `Bike`) based on an input parameter.


namespace PracticeApp
{

    interface IVehicle
    {
        void Drive();
    }
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Cars();
                case "bike":
                    return new Bikes();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
    class Cars : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car.");
        }
    }
    class Bikes : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike.");
        }
    }
    class Program
    {
        public static void Main()
        {
            IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
            vehicle1.Drive();

            IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
            vehicle2.Drive();
        }
    }

}
