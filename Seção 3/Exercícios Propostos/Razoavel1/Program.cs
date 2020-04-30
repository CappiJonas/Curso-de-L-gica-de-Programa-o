using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razoavel1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            MEDIA = ((3.5 * A) + (7.5 * B)) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
            Console.ReadKey();
        }
    }
}
