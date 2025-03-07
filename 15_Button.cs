using PracticeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Use of Delegates for Event Handling**
//Create a `Button` class that has a delegate `OnClick`. Implement an event that triggers when the button is clicked.


namespace PracticeApp
{
    class Button
    {
        public delegate void ClickHandler();

        public event ClickHandler OnClick;
        public void Click()
        {
            Console.WriteLine("Button Clicked!");
            OnClick?.Invoke();
        }

        public static void Main(string[] args)
        {
            Button button = new Button();
            button.Click();
        }
    }
}
