using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Static Members in a Banking System**
//Implement a `Bank` class with a static field `InterestRate` and a static method `SetInterestRate()`.
//Show how static members work across multiple objects.


namespace PracticeApp
{
    class Bank
    {
        public static int Interestrate { get; set; }=5;

       
        public static void SetInterestRate(int newInterestrate)
        {
            Interestrate = newInterestrate;
        }
        public void DisplayInterestRate()
        {
            Console.WriteLine(Interestrate);
        }

        public static void Main()
        {
            Bank bank = new();
            bank.DisplayInterestRate();
            Bank bank2 = new Bank();
            bank2.DisplayInterestRate();
            Bank.SetInterestRate(2);
            bank.DisplayInterestRate();
        }
    }
}
