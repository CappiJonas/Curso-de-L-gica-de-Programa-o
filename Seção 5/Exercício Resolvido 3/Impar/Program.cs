using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                for (int i = 1; i <= (X - 1); i = i +2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i <= X; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
