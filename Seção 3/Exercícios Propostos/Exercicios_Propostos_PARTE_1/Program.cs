using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos_PARTE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, π, R;

            π = 3.14159;

            R = double.Parse(Console.ReadLine());
            A = π * Math.Pow(R, 2.0);
            Console.WriteLine("A = " + A.ToString("F4"));
            Console.ReadKey();
        }
    }
}
