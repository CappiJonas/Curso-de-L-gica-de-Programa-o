using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia_IJ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("I = 1 J = 7");
                    Console.WriteLine("I = 1 J = 6");
                    Console.WriteLine("I = 1 J = 5");
                }
                else if (i == 6)
                {
                    Console.WriteLine("I = 3 J = 7");
                    Console.WriteLine("I = 3 J = 6");
                    Console.WriteLine("I = 3 J = 5");
                }
                else if (i == 9)
                {
                    Console.WriteLine("I = 6 J = 7");
                    Console.WriteLine("I = 6 J = 6");
                    Console.WriteLine("I = 6 J = 5");
                }
                else if (i == 12)
                {
                    Console.WriteLine("I = 9 J = 7");
                    Console.WriteLine("I = 9 J = 6");
                    Console.WriteLine("I = 9 J = 5");
                }
            }
            Console.ReadKey();
        }
    }
}
