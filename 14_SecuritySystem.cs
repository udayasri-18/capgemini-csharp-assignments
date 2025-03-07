using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**Sealed Class in a Security System**
//Create a sealed class `SecuritySystem` that prevents inheritance. Show how sealing a class stops further extension.

namespace PracticeApp
{
    sealed class SecuritySystem
    {
        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Username:{username} Password:{password}");
        }

        class Child : SecuritySystem
        {
            ErrorEventArgs due to Selaed class cannot be inherited
        }
        public static void Main(string[] args)
        {
            SecuritySystem s = new();
            s.Authenticate("Testuser", "12345@12");
        }
    }
}
