using System;

namespace Cadeia_de_Caracteres__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
