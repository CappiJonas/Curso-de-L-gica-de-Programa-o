using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            DIFERENCA = A * B - C * D;
            Console.WriteLine("DIFERENÇA = " + DIFERENCA);
            Console.ReadKey();
        }
    }
}
