using AsyncExe.Domain.Tasks;

namespace AsyncExe.Infra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Método prepara omelete e pao
            AsyncExemplos.OmeleteEPaoAsync();

            //Método prepara pao
            AsyncExemplos.OmeleteOuPaoAsync(7000);

            //Método prepara omelete dada a demora na tarefa de comprar farinha
            AsyncExemplos.OmeleteOuPaoAsync(9000);
        }
    }
}
