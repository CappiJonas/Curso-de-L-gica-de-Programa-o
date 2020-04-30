using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, A, P, D;

            Console.WriteLine("Qual o valor da altura do retângulo? ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("E da base? ");
            b = double.Parse(Console.ReadLine());
            A = b * h;
            Console.WriteLine("Área = " + A.ToString("F4"));
            P = 2 * b + 2 * h;
            Console.WriteLine("Perímetro = " + P.ToString("F4"));
            D = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
            Console.WriteLine("Diagonal = " + D.ToString("F4"));
            Console.ReadKey();
        }
    }
}
