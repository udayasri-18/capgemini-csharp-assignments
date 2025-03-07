using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Multiple Inheritance Using Interfaces**
//Define two interfaces `IPrintable` (for printing details) and `ISerializable` (for saving to a file).
//Implement both in a `Report` class and demonstrate multiple interface implementation.


namespace PracticeApp
{
    interface IPrintable
    {
        void PrintDetails();
    }
    interface ISerializable
    {
        void SaveToFile(string filename);
    }
    class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Report Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filename}");
        }

        static void Main()
        {
            Report report = new Report("Weekly Report", "Performance improved by 15%.");
            report.PrintDetails();
            report.SaveToFile("report.txt");
        }
    }
}
