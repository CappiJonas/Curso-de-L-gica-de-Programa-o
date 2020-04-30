using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_Populacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, cont;
            double PA, PB, G1, G2;

            cont = 0;
            T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                PA = int.Parse(vet[0]);
                PB = int.Parse(vet[1]);
                G1 = double.Parse(vet[2]);
                G2 = double.Parse(vet[3]);

                for (int a = 0; PA <= PB; a++)
                {
                    PA = PA + PA * G1 / 100;
                    PB = PB + PB * G2 / 100;
                    cont = cont + 1;
                }

                if (cont < 100)
                {
                    Console.WriteLine(cont + " anos");
                }
                else
                {
                    Console.WriteLine("Mais que um século");
                }
            }
            Console.ReadKey();
        }
    }
}
