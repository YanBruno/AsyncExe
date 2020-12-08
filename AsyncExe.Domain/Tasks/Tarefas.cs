using AsyncExe.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace AsyncExe.Domain.Tasks
{
    public class Tarefas
    {
        public static async Task TarefaDeEspera(int tempo)
        {
            Console.WriteLine($"Tarefa de espera inicada");
            await Task.Delay(tempo);
            Console.WriteLine($"Tarefa de espera finalizada");
        }
        public static async Task<Farinha> ComprarFarinha(string nome)
        {
            Console.WriteLine($"{nome} saiu de casa.");
            await Task.Delay(3000);

            Console.WriteLine($"{nome} chegou no mercado.");
            await Task.Delay(2000);

            Console.WriteLine($"{nome} comprou a farinha.");
            await Task.Delay(3000);

            Console.WriteLine($"{nome} chegou em casa.");

            return new Farinha();
        }
        public static async Task<Ovos> BuscarOvos(string nome)
        {
            Console.WriteLine($"{nome} foi ao galinheiro.");
            await Task.Delay(2000);

            Console.WriteLine($"{nome} pegou os ovos.");
            await Task.Delay(3000);

            Console.WriteLine($"{nome} chegou em casa.");
            await Task.Delay(2000);

            return new Ovos();
        }
    }
}
