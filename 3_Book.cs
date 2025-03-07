using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//**Constructor Overloading in a Library System**
//Implement a `Book` class with three different constructors:(1) Default constructor, (2) Constructor with `Title` and `Author`,
//(3) Constructor with `Title`, `Author`, and `ISBN`. Ensure each constructor initializes properties correctly.



namespace PracticeApp
{
    public class Book
    {
        public  Book()
        {
            Console.WriteLine("Default Constructor");
        }
        public Book(string Title,string Author)
        {
            Console.WriteLine("Title of Book: " + Title + "  Author:" + Author);
        }
        public Book(string Title, string Author,string ISBN)
        {
            Console.WriteLine("Title of Book: " + Title + "  Author:" + Author+"  ISBN:"+ISBN);
        }

        public static void Main(string[] args)
        {
            Book book = new Book();
            Book book1 = new Book("The rays", "APJ AbdulKalam");
            Book book2 = new Book("The rays of light", "Vivekananda", "33");
        }
    }
}
