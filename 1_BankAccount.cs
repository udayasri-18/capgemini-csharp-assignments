using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a `BankAccount` class where `balance` is a private field. Implement methods for `Deposit()` and `Withdraw()`,
//ensuring that withdrawal is only allowed if there is a sufficient balance. Prevent direct modification of `balance` from outside the class.

namespace PracticeApp
{
    public class BankAccount
    {
        private int balance = 100000;
        public void Deposit(int depositAmount)
        {
            balance += depositAmount;
            Console.WriteLine("Deposit Successful of amount: "+depositAmount);
        }
        public void Withdraw(int withdrawAmount)
        {
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient Balance");

            }
            else
            {
                balance -= withdrawAmount;
                Console.WriteLine("Withdraw Successful of amount:" + withdrawAmount);
            }
        }
        public void Balance()
        {
            Console.WriteLine("Current Balance :"+balance);
        }
        public static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            Console.Write("Enter deposit amount: ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            bankAccount.Deposit(depositAmount);
            bankAccount.Balance();

            Console.Write("Enter withdraw amount: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            bankAccount.Withdraw(withdrawAmount);
            bankAccount.Balance();

        }
    }

}
