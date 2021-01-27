using System;

namespace formatação_de_cadeia_de_caracteres__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("é prefixado a esquerda valores em branco \naté o número de caracteres seja igual a doze por exemplo\n\n");
            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));

            Console.WriteLine("Para adicionar espaço ou caracteres ao lado direito da cadeia de caracteres, use o método PadRight().\n\n");

            Console.WriteLine(input.PadRight(12));

            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            Console.WriteLine("\n\nCadeias de Caracteres preenchidas\n\n");

            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);
        }
    }
}
