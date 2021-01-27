using System;

namespace Matrizes_e_foereach_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inventario = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventario)
                {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }
}
