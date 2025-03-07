using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Decorator Pattern in a Logger System**
//Implement an `ILogger` interface and `FileLogger` class.
//Use the **Decorator Pattern** to add extra logging features like timestamp and error categorization.


namespace PracticeApp
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
    class TimestampLogger : ILogger
    {
        private ILogger _logger;
        public TimestampLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {

            _logger.Log($"{DateTime.Now}: {message}");
        }
    }
    class ErrorLogger : ILogger
    {
        private ILogger _logger;
        public ErrorLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log($"Error: {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            TimestampLogger timestampLogger = new TimestampLogger(fileLogger);
            ErrorLogger errorLogger = new ErrorLogger(timestampLogger);
            errorLogger.Log("This is an error message");
        }
    }
}
