using System;

namespace Formatar_dados_alfanuméricos
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            /*
              string first = "Hello";
              string second = "World";
              Console.WriteLine("{1} {0}!", first, second);
              Console.WriteLine("{0} {0} {0}!", first, second);

            string first = "Hello";
            string second = "World";
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");
            */
            Console.WriteLine("\n\nNo exemplo a seguir, o especificador de formato de moeda :C \né usado para apresentar as variáveis price e discount como moeda\n\n");
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            Console.WriteLine("\n\normatar o número para facilitar a leitura incluindo vírgulas \npara delinear milhares, milhões, bilhões e assim por diante.\n\n");  

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");

            Console.WriteLine("\n\nFormatando números percentuais\n\n");

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");
        }
    }
}
