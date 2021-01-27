using System;

namespace Chamar_métodos_da_Biblioteca_de_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random dice = new Random();
            //int roll = dice.Next(1, 7);
            //Console.WriteLine(roll);

            Console.WriteLine();

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            Console.WriteLine("Chamando Método");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
        }
    }
}
