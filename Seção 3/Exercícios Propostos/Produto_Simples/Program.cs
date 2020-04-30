using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);
            Console.ReadKey();
        }
    }
}
