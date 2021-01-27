using System;

namespace cadeia_de_caracteres__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "What is the value <span>between the tags</span>?";

            int openingPosition = message.IndexOf("<span>");
            int closingPosition = message.IndexOf("</span>");

            openingPosition += 6;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
