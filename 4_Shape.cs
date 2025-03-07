using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Abstraction with Abstract Classes**
//Design an abstract class `Shape` with an abstract method `CalculateArea()`.
//Create derived classes `Circle` and `Rectangle` that implement this method. Demonstrate abstraction by instantiating these classes.


namespace PracticeApp
{
    public abstract class Shape
    {
        public abstract void CalculateArea();
    }
    public class Circle : Shape
    {
        public override void CalculateArea()
        {
            
            Console.WriteLine("Enter Radius");
            int radius = Convert.ToInt32(Console.ReadLine());

            double area = (3.14 * radius * radius);
            Console.WriteLine("Area of circle is : " + area);
        }
    }

    public class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("\nEnter Length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            int breadth = Convert.ToInt32(Console.ReadLine());
            double area = (length * breadth);
            Console.WriteLine("Area of Rectangle is : " + area);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.CalculateArea();

            Rectangle r = new Rectangle();
            r.CalculateArea();
        }
    }
}
