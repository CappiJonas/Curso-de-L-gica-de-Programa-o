using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X > 0 && Math.Abs(X) % 2 == 0)
                {
                    Console.WriteLine("Par positivo");
                }
                else if (X > 0 && Math.Abs(X) % 2 == 1)
                {
                    Console.WriteLine("Ímpar positivo");
                }
                else if (X < 0 && Math.Abs(X) % 2 == 0)
                {
                    Console.WriteLine("Par negativo");
                }
                else if (X < 0 && Math.Abs(X) % 2 == 1)           
                {
                    Console.WriteLine("Ímpar negativo");
                }
                else 
                {
                    Console.WriteLine("NULL");
                }
            }
            Console.ReadKey();
        }
    }
}
