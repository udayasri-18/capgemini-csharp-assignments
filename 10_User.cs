using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Design a Role-Based Access System**
//Create a base class `User` with properties like `Username` and `Role`.
//Derive `Admin` and `Customer` classes that override a method `AccessControl()`, where `Admin` can access all features, but `Customer` has limited access.


namespace PracticeApp
{
    class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public virtual void AccessControl()
        {
            Console.WriteLine("USer class Access Control method");
        }
    }

    class Admin : User
    {
        public override void AccessControl()
        {
            Console.WriteLine("Admin class Access Control method");
        }

    }
    class Customer : User
    {
        public override void AccessControl()
        {
            Console.WriteLine("Customer class Access Control method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.AccessControl();

            Admin admin = new Admin();
            admin.AccessControl();

            Customer customer = new Customer();
            customer.AccessControl();
        }
    }
}
