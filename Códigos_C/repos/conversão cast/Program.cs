using System;

namespace conversão_cast
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            Console.WriteLine("Conversão sem perda de informações!\n\n");

            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");
           */
            Console.WriteLine("\n\nConversão com perda de informações!\n\n");

            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");


            decimal meuDecimal = 1.23456789m;
            float myFloat = (float)meuDecimal;

            Console.WriteLine($"Decimal: {meuDecimal}");
            Console.WriteLine($"Float: {myFloat}");
        }


    }
}
