using System;

namespace Do_While__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escrever uma instrução while que itere somente enquanto\n um número aleatório for maior que um determinado valor!\n\n");
            Console.WriteLine(" São gerados números aleatórios entre 1 e 11\n enquanto forem maiores ou igual a 3,\n quando o número for menor que 3 ele mostra o ultimo número e finaliza\n\n");
            Random random = new Random();
            int current = random.Next(1, 11);

            /*
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            */

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
        }
    }
}
