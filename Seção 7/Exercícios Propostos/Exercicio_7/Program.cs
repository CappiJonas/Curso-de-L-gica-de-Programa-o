using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] pelotao;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            pelotao = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    pelotao[i, j] = int.Parse(s[j]);
                }
            }

            int giraFila = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                    if (i + 1 == giraFila)
                    {
                        int[] vet = new int[N];
                        for (int k = 0; k < N; k++)
                        {
                            vet[k] = pelotao[i, k];
                        }
                        pelotao[i, 0] = vet[N - 1];
                        for (int l = 0; l + 1 < N; l++)
                        {
                            if (l != N - 1)
                            {
                                pelotao[i, l + 1] = vet[l];
                            }
                        }
                    }               
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(pelotao[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
