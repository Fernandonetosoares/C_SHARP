using System;

namespace Cadeia_de_caracteres__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // neste programa ele busca as cadeias de caracteres dentro dos parenteses os caracteres "(" ")"

            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
