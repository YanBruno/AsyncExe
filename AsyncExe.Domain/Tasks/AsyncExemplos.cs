using System;
using System.Threading.Tasks;

namespace AsyncExe.Domain.Tasks
{
    public class AsyncExemplos
    {
        public async static void OmeleteEPaoAsync()
        {
            var tarefaMaria = Tarefas.BuscarOvos("Maria");
            var tarefaJoao = Tarefas.ComprarFarinha("João");

            _ = await Cozinhar.Omelete(await tarefaMaria);
            _ = await Cozinhar.Pao(await tarefaMaria, await tarefaJoao);

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
                Console.WriteLine($"João chegou rápido");
                _ = await Cozinhar.Pao(await tarefaLeticia, await tarefaYan);
            }
            else
            {
                Console.WriteLine($"João demorou demais");
                _ = await Cozinhar.Omelete(await tarefaLeticia);
            }
        }
    }
}
