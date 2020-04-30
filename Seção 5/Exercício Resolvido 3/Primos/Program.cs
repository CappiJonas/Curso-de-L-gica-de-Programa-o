using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, cont;

            
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                cont = 0;

                for (int a = X; a > 0; a--)
                {
                    if (X % a == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine(X + " é primo");
                }
                else
                {
                    Console.WriteLine(X + " não é primo");
                }
                
            }
            Console.ReadKey();
        }
    }
}
