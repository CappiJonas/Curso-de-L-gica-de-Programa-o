using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, media;

            Console.WriteLine("Digite o número de x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de y");
            y = double.Parse(Console.ReadLine());
            media = (x + y) / 2.0;
            Console.WriteLine("Média = " + media);
            Console.ReadKey();
        }
    }
}
