using System;

namespace Operações_básicas_em_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            string Name1 = "Mari";
            int Number = 7;
            Console.WriteLine(Name1 + " tem " + Number + " sapatos.");

            int soma = 7 + 5;
            int diference = 7 - 5;
            int produto = 7 * 5;
            int divisor = 7 / 5;
            decimal decimaldivisao = 7.0m / 5;

            Console.WriteLine("Soma:" + soma);
            Console.WriteLine("Diferença:" + diference);
            Console.WriteLine("Produto:" + produto);
            Console.WriteLine("Divisão:" + divisor);
            Console.WriteLine("Divisão decimal:" + decimaldivisao);

            int first = 7;
            int second = 5;
            decimal quociente = (decimal)first / (decimal)second;
            Console.WriteLine(quociente);

            Console.WriteLine("Modulo de 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulo de 7 / 5 : " + (7 % 5));
            Console.WriteLine("Modulo de 7 / 4 : " + (7 % 4));

            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            //int value = 1;
            //value = value + 1;
            //Console.WriteLine("Primeiro Incremento: " + value);
            //value += 1;
            //Console.WriteLine("Secundo Incremento: " + value);
            //value++;
            //Console.WriteLine("Terceiro Incremento: " + value);
            //value = value - 1;
            //Console.WriteLine("Primeiro Decremento: " + value);
            //value -= 1;
            //Console.WriteLine("Segundo Decremento: " + value);
            //value--;
            //Console.WriteLine("Terceiro Decremento: " + value);
            int value = 1;
            value++;
            Console.WriteLine("\nFirst: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
            Console.WriteLine("\n Atividade conversão temperatura\n");


            int fahrenheit = 94;
            int celsius = 32;
            int frac1 = 5;
            int frac2 = 9;
            decimal resultado = (fahrenheit - celsius) * ((decimal)frac1 / (decimal)frac2);
            Console.WriteLine("The temperature is " + (resultado) + " Celsius.");


        }
    }
}
