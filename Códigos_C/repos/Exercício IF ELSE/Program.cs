using System;

namespace Exercício_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here

            if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }

            if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
            {
                Console.WriteLine("Your subscription expires in " + (daysUntilExpiration) + " days!");
                discountPercentage = 10;
            }

            if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }

        }
    }
}
