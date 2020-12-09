using System;
using System.Threading.Tasks;

namespace AsyncExe.Domain.Tasks
{
    public class AsyncExemplos
    {
        public async static void OmeleteEPaoAsync()
        {
            var tarefaBuscarOvos = Tarefas.BuscarOvos("Leticia");
            var tarefaBuscarFarinha = Tarefas.ComprarFarinha("Yan");

            _ = await Cozinhar.Omelete(await tarefaBuscarOvos);
            _ = await Cozinhar.Pao(await tarefaBuscarOvos, await tarefaBuscarFarinha);

        }
        public async static void OmeleteOuPaoAsync(int tempoDeEsperaDaTarefaDeEspera)
        {
            var tarefaBuscarOvos = Tarefas.BuscarOvos("Letícia");
            var tarefaBuscarFarinha = Tarefas.ComprarFarinha("Yan");
            var tarefaDeEspera = Tarefas.TarefaDeEspera(tempoDeEsperaDaTarefaDeEspera);

            //Comprar farinha 8 segundos

            var tarefaTerminouPrimeiro = await Task.WhenAny(tarefaDeEspera, tarefaBuscarFarinha);

            if (tarefaTerminouPrimeiro == tarefaBuscarFarinha)
            {
                Console.WriteLine($"Yan chegou rápido");
                _ = await Cozinhar.Pao(await tarefaBuscarOvos, await tarefaBuscarFarinha);
            }
            else
            {
                Console.WriteLine($"Yan demorou demais");
                _ = await Cozinhar.Omelete(await tarefaBuscarOvos);
            }
        }
    }
}
