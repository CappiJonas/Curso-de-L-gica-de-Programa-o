using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
