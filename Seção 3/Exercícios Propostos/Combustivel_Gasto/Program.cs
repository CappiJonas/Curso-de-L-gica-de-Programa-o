using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel_Gasto
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidade;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());
            Console.WriteLine((tempo*velocidade/12).ToString("F3"));
            Console.ReadKey();
        }
    }
}
