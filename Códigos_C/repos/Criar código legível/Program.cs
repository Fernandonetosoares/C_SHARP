using System;

namespace Criar_código_legível
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsPurshased = 7;

            // Testar a mudança da menssagem.
            // int widgetSold = 7;
            // Console.WriteLine($"{firstName} sold {widgetSold} Widgets.");

            Console.WriteLine($"{firstName} purchased {widgetsPurshased} Widgets.");

            /*Se você precisar escrever um comentário longo ou remover muitas linhas de código,
              poderá comentar várias linhas adicionando um /* no início do código e um no final.*/

            string str = "The quick brown fox jumps over the lazy dog.";
            
            char[] charMessage = str.ToCharArray();           
            Array.Reverse(charMessage);

            int x = 0;
            
            foreach (char i in charMessage)
            { 
                if (i == 'o') { x++; } 
            }
            
            string new_message = new String(charMessage);
         
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");
        }
    }
}
