using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Real-World Observer Pattern for Notifications**
//Implement an `INotificationObserver` interface where `EmailNotifier` and `SMSNotifier` listen for notifications.
//When a new message arrives, all observers should receive an update.


namespace PracticeApp
{
    public interface INotificationObserver
    {
        void Update(string message);
    }
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"📧 Email Notification: {message}");
        }
    }
    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"📱 SMS Notification: {message}");
        }
    }
    public class NotificationService
    {
        private readonly List<INotificationObserver> observers = new List<INotificationObserver>();
        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(INotificationObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            NotificationService notificationService = new NotificationService();

            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            notificationService.Subscribe(emailNotifier);
            notificationService.Subscribe(smsNotifier);

            Console.WriteLine("🔔 New Message: 'System maintenance at 10 PM'");
            notificationService.NotifyObservers("System maintenance at 10 PM");

            notificationService.Unsubscribe(emailNotifier);

            Console.WriteLine("\n🔔 New Message: 'New feature update available!'");
            notificationService.NotifyObservers("New feature update available!");
        }
    }

}
