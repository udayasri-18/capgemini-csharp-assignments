using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Operator Overloading for Complex Numbers**
//Create a `ComplexNumber` class with properties `Real` and `Imaginary`.
//Overload the `+` operator to add two complex numbers.


namespace PracticeApp
{
    using System;

    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public static void Main()
        {
            ComplexNumber num1 = new ComplexNumber(3, 4);
            ComplexNumber num2 = new ComplexNumber(1, 2);
            ComplexNumber sum = num1 + num2;

            Console.WriteLine($"Sum: {sum}");
        }
    }

}
