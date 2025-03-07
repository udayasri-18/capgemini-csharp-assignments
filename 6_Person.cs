using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Using Virtual Methods in Inheritance**
//Create a `Person` base class with a `GetDetails()` method.
//Derive `Student` and `Teacher` classes that override `GetDetails()` to display their respective properties. Call `GetDetails()` using a base class reference.


namespace PracticeApp
{
    class Person
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of person: " + name + " Age: " + age);
        }
    }
    class Teacher : Person
    {
        public override void GetDetails()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ID");
            String id = Console.ReadLine();
            Console.WriteLine("Name of Teacher: " + name + " Age: " + age +"Id: "+id);

        }
    }

    class Students : Person
    {
        public override void GetDetails()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            int marks= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of student: " + name + " Age: " + age+" Marks: "+marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.GetDetails();

            Teacher teacher = new Teacher();
            teacher.GetDetails();

            Person person = new Person();
            person.GetDetails();
        }
    }
}
