using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, volume;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = (4.0 / 3) * pi * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
            Console.ReadKey();
        }
    }
}
