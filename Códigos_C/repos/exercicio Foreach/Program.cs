using System;

namespace exercicio_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Pedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string Pedido in Pedidos)

                if (Pedido.StartsWith("B"))
            {
                Console.WriteLine(Pedido);
            }
        }
    }
}
