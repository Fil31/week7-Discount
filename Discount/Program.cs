using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount;
            Console.WriteLine("Enter your purchase sum:");
            discount = Convert.ToInt32(Console.ReadLine());

            if (discount < 0)
            {
                Console.WriteLine("No discounts for you.");
            }
            else if (discount >= 0 && discount <= 10)
            {
                Console.WriteLine("No discounts for you.");
            }
            else if (discount >= 10 && discount <= 20)
            {
                Console.WriteLine("Your discount is 1 eur.");
            }
            else if (discount >= 20 && discount <= 50)
            {
                Console.WriteLine("Your discount is 5 eur.");
            }
            else if (discount >= 50 && discount <= 100)
            {
                Console.WriteLine("Your discount is 10 eur.");
            }
            else
            {
                Console.WriteLine("Your discount is 15 eur.");
            }
        }
    }
}
