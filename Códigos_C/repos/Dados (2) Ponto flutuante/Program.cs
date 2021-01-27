using System;

namespace Dados__2__Ponto_flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usar as propriedades MinValue e MaxValue para cada tipo integral com sinal!\n\n");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }
    }
}
