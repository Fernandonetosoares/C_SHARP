using System;

namespace Cadeia_de_Caracteres__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            int closingPosition = message.LastIndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
