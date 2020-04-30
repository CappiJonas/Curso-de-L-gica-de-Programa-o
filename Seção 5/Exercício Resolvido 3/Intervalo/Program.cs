using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, contEm, contFora;

            contEm = 0;
            contFora = 0;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    contEm = contEm + 1;
                }
                else
                {
                    contFora = contFora + 1;
                }
            }

            Console.WriteLine(contEm + " em");
            Console.WriteLine(contFora + " fora");
            Console.ReadKey();
        }
    }
}
