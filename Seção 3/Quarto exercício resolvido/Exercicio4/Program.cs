using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, hora, minuto, resto, segundo;

            N = int.Parse(Console.ReadLine());

            hora = N / 3600;
            resto = N % 3600;
            minuto = resto / 60;
            segundo = resto % 60;

            Console.WriteLine($"{hora} : {minuto} : {segundo}");
            Console.ReadKey();
        }
    }
}
