using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            if (X > Y)
            {
                Console.WriteLine("Decrescente");
            }
            else if (X < Y)
            {
                Console.WriteLine("Crescente");
            }

            while (X != Y)
            {
                string[] vet1 = Console.ReadLine().Split(' ');
                X = int.Parse(vet1[0]);
                Y = int.Parse(vet1[1]);

                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
            }
            Console.ReadKey();
        }
    }
}
