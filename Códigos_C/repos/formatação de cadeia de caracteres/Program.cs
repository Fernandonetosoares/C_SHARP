using System;

namespace formatação_de_cadeia_de_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello \nWorld!");
            Console.WriteLine("Hello \tWorld!");
            Console.WriteLine("Usando \"Aspas\" no meio de uma frase");
            Console.WriteLine("C:donwloads\\documents\\software");
            Console.WriteLine(" ");
            Console.WriteLine("Generating invoices for customer\"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");
            Console.WriteLine(" ");
            Console.WriteLine(@"    c:\source\repos
         (this is where your code goes)");
            Console.WriteLine("\u3053\u3093\u306B\u306F World!");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
            Console.WriteLine("Concatenação de valores ");
            string Nome = "Bob";
            string Menssagem = "Hello " + Nome;
            Console.WriteLine(Menssagem);
            string people = "Fernando";
            string Saudar = "Olá";
            string mensage = "Tudo bem?";
            string texto = $"{Saudar} {people} {mensage} !";
            Console.WriteLine(texto);

            string projeto = "projeto-interpolação";
            Console.WriteLine($@"C:\Output\{projeto}\Data");

            //string people = "Fernando";
            //string Saudar = "Olá";
            //string mensage = "Tudo bem?";
            //string texto = Saudar + " " + people + " " + mensage + "!";
            //Console.WriteLine(texto);
        }
    }
}
