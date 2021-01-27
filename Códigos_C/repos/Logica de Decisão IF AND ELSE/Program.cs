using System;

namespace Logica_de_Decisão_IF_AND_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            //roll1 = 6;
            //roll2 = 6;
            //roll3 = 5;

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            // Operador lógico "OR" "OU"   || 

            // if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            //{
            //   Console.WriteLine("You rolled doubles!  +2 bonus to total");
            //  total += 2;
            // }

            // Operador Lógico "AND" "E"   &&

            //if ((roll1 == roll2) && (roll2 == roll3))
            //{
            //   Console.WriteLine("You rolled Triples!  +6 bonus to total");
            //   total += 6;
            // }

            // Na condição Acima existe um bug que apresentará resultado duplicado e triplicado juntos

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {

                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }

                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("Você ganhou um Carro Novo!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("Você ganhou um laptop Novo !");
            }
            else if (total == 7)
            {
                Console.WriteLine("Você ganhou uma Viagem para dois!");
            }
            else
            {
                Console.WriteLine("Você ganhou um Gato!");
            }
            //  if (total >= 15)
            // {
            //     Console.WriteLine("You win");
            // }

            //   else
            //  {
            //    Console.WriteLine("Sorry, You lose!");
            // }

            //if (total < 15)
            //{
            //    Console.WriteLine("Sorry, You lose!");
            //}

            //   ==, o "operador igual" para testar a igualdade
            //   >, o "operador maior que", para testar se o valor à esquerda é maior que o valor à direita
            //   <, o "operador menor que", para testar se o valor à esquerda é menor que o valor à direita
            //   >=, o "operador maior que ou igual a"
            //   <=, o "operador menor que ou igual a"
        }
    }
}
