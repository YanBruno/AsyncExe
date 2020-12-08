using AsyncExe.Domain.Tasks;
using System;

namespace AsyncExe.Infra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Método prepara omelete e pao ");
            Console.WriteLine("2 - Método prepara pao");
            Console.WriteLine("3 - Método prepara omelete dada a demora na tarefa de comprar farinha");
            Console.WriteLine("");

            var opcao = Console.ReadLine();

            Console.Clear();
            switch (opcao)
            {
                case "1":
                    //Método prepara omelete e pao
                    AsyncExemplos.OmeleteEPaoAsync();
                    break;

                case "2":
                    //Método prepara pao
                    AsyncExemplos.OmeleteOuPaoAsync(7000);
                    break;

                case "3":
                    //Método prepara omelete dada a demora na tarefa de comprar farinha
                    AsyncExemplos.OmeleteOuPaoAsync(9000);
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
