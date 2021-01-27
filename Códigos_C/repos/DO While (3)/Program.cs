using System;

namespace DO_While__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usar a instrução continue para passar diretamente para a expressão booliana!\n\n");
            Console.WriteLine("Gera números entre 1 e 11 porém,\n com a expressão 'continue' ele não gera números acima de 8\n e quando gerado o número 7\n ele termina o ciclo\n\n");

            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */
        }
    }
}
