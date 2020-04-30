using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razoavel2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            MEDIA = ((2 * A) + (3 * B) + (5 * C)) / 10;
            Console.WriteLine("MÉDIA = " + MEDIA);
            Console.ReadKey();
        }
    }
}
