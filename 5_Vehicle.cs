using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Method Overriding for a Vehicle System**
//Create a base class `Vehicle` with a method `Start()`.
//Override it in `Car` and `Bike` classes to provide specific implementations.
//Use the `override` keyword and demonstrate polymorphism.


namespace PracticeApp
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }
    }

    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new();
            Bike bike = new();
            Car car = new();

            vehicle.Start();
            car.Start();
            bike.Start();
        }
    }
}
