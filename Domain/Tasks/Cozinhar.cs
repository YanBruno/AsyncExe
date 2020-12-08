using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Tasks
{
    public static class Cozinhar
    {
        public async static Task<Omelete> Omelete(Ovos ovos)
        {
            Console.WriteLine("Cozinhando omelete");
            await Task.Delay(1000);
            Console.WriteLine("Omelete pronto");
            return new Omelete(ovos);
        }

        public async static Task<Pao> Pao(Ovos ovos, Farinha farinha) 
        {
            Console.WriteLine("Cozinhando pão");
            await Task.Delay(2000);
            Console.WriteLine("Pão pronto");
            return new Pao(ovos, farinha);
        }
    }
}
