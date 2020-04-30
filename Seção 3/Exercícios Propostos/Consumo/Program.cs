using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X; //Distância percorrida em KM
            float CM, Y;//Consumo total em L
            X = int.Parse(Console.ReadLine());
            Y = float.Parse(Console.ReadLine());
            CM = X / Y;
            Console.WriteLine(CM.ToString("F3") + " km/l");
            Console.ReadKey();
        }
    }
}
