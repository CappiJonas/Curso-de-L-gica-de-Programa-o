using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
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

            for (int i = 0; i < N; i++)
            {
                int maiorValor = 0;
                for (int j = 0; j < N; j++)
                {
                    if (maiorValor < mat[i, j])
                    {
                        maiorValor = mat[i, j];
                    }
                }
                Console.WriteLine(maiorValor);
            }
            Console.ReadKey();
        }
    }
}
