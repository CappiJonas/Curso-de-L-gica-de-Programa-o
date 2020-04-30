using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Valores Negativos: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
