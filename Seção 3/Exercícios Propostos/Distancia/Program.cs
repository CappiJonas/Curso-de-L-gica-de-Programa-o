using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            distancia = int.Parse(Console.ReadLine());
            Console.WriteLine(distancia*2 + " minutos");
            Console.ReadKey();
        }
    }
}
