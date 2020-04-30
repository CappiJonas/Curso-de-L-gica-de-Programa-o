using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double X, Y, Z, media;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = double.Parse(vet[0]);
                Y = double.Parse(vet[1]);
                Z = double.Parse(vet[2]);
                media = (2.0 * X + 3.0 * Y + 5 * Z)/10;
                Console.WriteLine(media.ToString("F1"));
            }
            Console.ReadKey();
        }
    }
}
