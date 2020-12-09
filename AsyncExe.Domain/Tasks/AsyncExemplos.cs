using System;
using System.Threading.Tasks;

namespace AsyncExe.Domain.Tasks
{
    public class AsyncExemplos
    {
        public async static void OmeleteEPaoAsync()
        {
            var tarefaLeticia = Tarefas.BuscarOvos("Leticia");
            var tarefaYan = Tarefas.ComprarFarinha("Yan");

            _ = await Cozinhar.Omelete(await tarefaLeticia);
            _ = await Cozinhar.Pao(await tarefaLeticia, await tarefaYan);

        }
        public async static void OmeleteOuPaoAsync(int tempoDeEsperaDaTarefaDeEspera)
        {
            var tarefaLeticia = Tarefas.BuscarOvos("Letícia");
            var tarefaYan = Tarefas.ComprarFarinha("Yan");
            var tarefaDeEspera = Tarefas.TarefaDeEspera(tempoDeEsperaDaTarefaDeEspera);

            //Comprar farinha 8 segundos

            var tarefaTerminouprimeiro = await Task.WhenAny(tarefaDeEspera, tarefaYan);

            if (tarefaTerminouprimeiro == tarefaYan)
            {
                Console.WriteLine($"Yan chegou rápido");
                _ = await Cozinhar.Pao(await tarefaLeticia, await tarefaYan);
            }
            else
            {
                Console.WriteLine($"Yan demorou demais");
                _ = await Cozinhar.Omelete(await tarefaLeticia);
            }
        }
    }
}
