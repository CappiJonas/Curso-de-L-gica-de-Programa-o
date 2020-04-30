using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            if (a == 0.0)
            {
                Console.WriteLine("Impossível calcular as raízes");
            }
            else
            {
                b = double.Parse(vet[1]);
                c = double.Parse(vet[2]);
                delta = Math.Pow(b, 2.0) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Impossível calcular as raízes");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                    Console.WriteLine(x1.ToString("F5"));
                    Console.WriteLine(x2.ToString("F5"));
                }               
            }
            Console.ReadKey();
        }
    }
}

