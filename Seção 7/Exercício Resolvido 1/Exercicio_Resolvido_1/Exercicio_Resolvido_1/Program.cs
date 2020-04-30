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
            int[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }               
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de Negativos = {cont}");
            Console.ReadKey();
        }
    }
}
