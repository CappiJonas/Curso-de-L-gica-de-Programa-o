using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            int X = 0;

            Console.WriteLine("Escolha 2 valores");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine();
            Console.WriteLine("X = " + X);
            Console.ReadKey();
        }
    }
}
