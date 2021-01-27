using System;

namespace instruções_do_while_e_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrever uma instrução do-while para interromper quando um determinado número aleatório é gerado!\n\n");

            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
        }
    }
}
