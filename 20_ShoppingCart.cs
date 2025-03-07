using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Strategy Pattern for Dynamic Discount Calculation**
//Implement different discount strategies (`NoDiscount`, `PercentageDiscount`, `FixedAmountDiscount`).
//The `ShoppingCart` class should apply a strategy dynamically based on user input.


namespace PracticeApp
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;
        }
    }
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return Math.Max(0, totalAmount - _discountAmount); 
        }
    }
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal totalAmount)
        {
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter total amount: ");
            decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Choose discount type: \n1. No Discount \n2. 10% Discount \n3. $20 Fixed Discount");
            int choice = Convert.ToInt32(Console.ReadLine());

            IDiscountStrategy discountStrategy = choice switch
            {
                1 => new NoDiscount(),
                2 => new PercentageDiscount(10), 
                3 => new FixedAmountDiscount(20), 
                _ => new NoDiscount()
            };

            ShoppingCart cart = new ShoppingCart(discountStrategy);
            decimal finalAmount = cart.CalculateTotal(totalAmount);

            Console.WriteLine($"Final amount after discount: {finalAmount:C}");
        }
    }

}
