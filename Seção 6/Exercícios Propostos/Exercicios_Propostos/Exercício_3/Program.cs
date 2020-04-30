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
            int[] A, B, C;

            N = int.Parse(Console.ReadLine());
            A = new int[N];
            B = new int[N];
            C = new int[N];

            string[] a = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(a[i]);
            }

            string[] b = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(b[i]);
            }

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write($"{C[i]} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
