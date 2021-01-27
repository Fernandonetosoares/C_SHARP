using System;

namespace instrução_de_iteração_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adição\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nSubtração\n");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nIgnorar valores\n");
            for (int j = 0; j < 10; j+=3)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("\nCurto circuito\n");
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a);
                if (a == 7) break;
            }

            Console.WriteLine("\nPercorrer elementos de uma matriz\n");

            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\nSuperar a limitação da instrução foreach usando a instrução for\n");

            string[] nomes = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < nomes.Length; i++)
                if (nomes[i] == "David") nomes[i] = "Sammy";

            foreach (var nome in nomes) Console.WriteLine(nome);
        }
    }
}
