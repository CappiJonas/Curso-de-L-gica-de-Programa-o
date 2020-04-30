using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] S = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(S[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                    Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }
    }
}
