using System;

namespace Desafio_fiz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                int resultado = (i % 3);
                int resultado5 = (i % 5);

                if (resultado == 0)
                {
                    Console.WriteLine(i + " - Fizz");
                }
               else if (resultado5 == 0)
                {
                    Console.WriteLine(i + " - Buzz");
                }
               else if ((resultado == 0) && (resultado5 == 0))
                {
                    Console.WriteLine(i + " - FizzBuzz");
                }
                else
                    Console.WriteLine(i);
            }
            }
        }
}
