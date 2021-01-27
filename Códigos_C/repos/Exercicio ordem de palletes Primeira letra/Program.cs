using System;

namespace Exercicio_ordem_de_palletes_Primeira_letra
{
    class Program
    {
        static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');

            foreach (var item in items)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
