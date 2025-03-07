using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Shallow Copy vs. Deep Copy**
//Create a `Department` class with a reference-type property `Manager`.
//Implement both **Shallow Copy** and **Deep Copy** to show how references are handled.


namespace PracticeApp
{
    using System;

    class Manager
    {
        public string Name { get; set; }
    }

    class Department
    {
        public string DeptName { get; set; }
        public Manager Manager { get; set; }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }
        public Department DeepCopy()
        {
            Department newDept = new Department();
            newDept.DeptName = this.DeptName;
            newDept.Manager = new Manager { Name = this.Manager.Name };
            return newDept;
        }
    }

    class Program
    {
        static void Main()
        {
            Department dept1 = new Department { DeptName = "IT", Manager = new Manager { Name = "Alice" } };

            Department shallowCopy = dept1.ShallowCopy();
            Department deepCopy = dept1.DeepCopy();

            dept1.Manager.Name = "Bob";

            Console.WriteLine("Shallow Copy Manager Name: " + shallowCopy.Manager.Name); 
            Console.WriteLine("Deep Copy Manager Name: " + deepCopy.Manager.Name); 
        }
    }
}
