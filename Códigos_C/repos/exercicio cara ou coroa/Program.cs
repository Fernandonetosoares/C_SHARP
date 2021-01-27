using System;

namespace exercicio_cara_ou_coroa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "Cara" : "Coroa");


           //Solução alternativa 
/* Random dice = new Random();
 int roll = dice.Next(1, 3);

if  (roll ==1)
{
       Console.WriteLine("Cara");
   }
else
   {
       Console.WriteLine("Coroa");
   }
*/
}
}
}

