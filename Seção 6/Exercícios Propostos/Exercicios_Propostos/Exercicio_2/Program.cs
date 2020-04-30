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
            int N, cont;
            int[] valores;

            cont = 0;
            N = int.Parse(Console.ReadLine());
            valores = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                valores[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (valores[i] % 2 == 0)
                {
                    Console.Write($"{valores[i]} ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
