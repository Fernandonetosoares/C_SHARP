using System;

namespace conversão_cast__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("converter um número em uma cadeia de caracteres usando o método auxiliar ToString()!\n\n");
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message);

            Console.WriteLine("\nExecutando o comando, verá a saída de uma concatenação dos dois valores.\n\n");

            Console.WriteLine("converter uma cadeia de caracteres em um número inteiro usando o método auxiliar Parse()!\n\n");

            string primeiro = "5";
            string segundo = "7";
            int soma = int.Parse(primeiro) + int.Parse(segundo);
            Console.WriteLine(soma);

            Console.WriteLine("\nExecutando o comando, verá a saída de uma Soma dos dois valores.\n\n");

            Console.WriteLine("\nconverter uma cadeia de caracteres em um número usando a classe Convert.\n\n");

            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            Console.WriteLine("\n\nComparar a conversão cast e a conversão de um decimal em um int\n");

            int valor = (int)1.5m;  // casting truncates
            Console.WriteLine(valor);

            int valor2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(valor2);

            Console.WriteLine("\nAo converter usando Convert.ToInt32(),\n o valor de float literal é corretamente arredondado para 2.\n Se alterássemos o valor literal para 1.499m,\n ele seria arredondado para baixo para 1.");
        }
    }
}
