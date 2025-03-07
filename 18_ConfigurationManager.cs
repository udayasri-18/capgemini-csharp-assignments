using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Thread-Safe Singleton Pattern for Configuration Management**
//Implement a Singleton class `ConfigurationManager` that prevents multiple instances. Ensure it is thread-safe.


namespace PracticeApp
{
    using System;

    public sealed class ConfigurationManager
    {
        private ConfigurationManager()
        {
            Console.WriteLine("ConfigurationManager instance created");
        }

        private static readonly Lazy<ConfigurationManager> instance =new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        public static ConfigurationManager Instance
        {
            get { return instance.Value; }
        }

        public void ShowConfig()
        {
            Console.WriteLine("Showing configuration settings...");
        }
    }

    class Program
    {
        static void Main()
        {
            
            ConfigurationManager config1 = ConfigurationManager.Instance;
            ConfigurationManager config2 = ConfigurationManager.Instance;

            Console.WriteLine(config1 == config2); 
            config1.ShowConfig();
        }
    }

}
