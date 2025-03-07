using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Method Overloading in a Calculator Class**
//Implement a `Calculator` class with overloaded methods `Add()`.
//It should accept two integers, three integers, and two double values separately. Demonstrate how method overloading works.


namespace PracticeApp
{
    class Calculator
    {
        public void Add(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public void Add(int num1, int num2, int num3)
        {
            int sum = 0;
            sum = num1 + num2 + num3;
            Console.WriteLine(sum);
        }
        public void Add(double num1, double num2)
        {
            double sum = 0;
            sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void Main(string[] args)
        {
            Calculator calci = new Calculator();
            calci.Add(1, 2);
            calci.Add(1, 2, 3);
            calci.Add(1.2, 3.3);
        }
    }
}
