using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                for (int i = 2; i <= N; i = i + 2)
                {
                    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i,2)}");
                }
            }
            else
            {
                for (int i = 2; i <= (N - 1); i = i + 2)
                {
                    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
                }
            }
            Console.ReadKey();
        }
    }
}
