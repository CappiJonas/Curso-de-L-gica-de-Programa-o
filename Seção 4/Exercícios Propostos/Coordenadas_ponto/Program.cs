using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas_ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            string[] vet = Console.ReadLine().Split(' ');
            X = double.Parse(vet[0]);
            Y = double.Parse(vet[1]);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q2");
            }
            Console.ReadKey();
        }
    }
}
