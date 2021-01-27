using System;

namespace Ramificar_o_fluxo_de_código_usando_o_constructo_de_mudança_de_casos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar a instrução switch

            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:

                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
    }
}
