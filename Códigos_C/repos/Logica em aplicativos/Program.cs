using System;

namespace Logica_em_aplicativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usar o operador de igualdade
            /*
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            string value1 = " c";
            string value2 = "C ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
              
            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);
          

            string myValue = "a";
            Console.WriteLine(myValue != "a");
            

            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            */

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));

            // These two lines of code do the same thing:

            Console.WriteLine(pangram.Contains("fox") == false);
            Console.WriteLine(!pangram.Contains("fox"));

            Console.WriteLine("\nAbaixo operador lógico\n");


            int saleAmount = 1001;

            //int discount = saleAmount > 1000 ? 100 : 50;

            //  Console.WriteLine($"Discount: {discount}");

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

        }
    }
}
