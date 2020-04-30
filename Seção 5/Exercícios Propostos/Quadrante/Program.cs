using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Primeiro");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Segundo");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Terceiro");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Quarto");
            }

            while (X != 0 || Y != 0)
            {
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("Quarto");
                }
            }
            Console.ReadKey();
        }
    }
}
