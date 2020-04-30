using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if(a == b && b == c && a == c)
            {
                Console.WriteLine("MENOR = " + a);
            }
            else
            {
                if(a < b && a < c)
                {
                    Console.WriteLine("MENOR = " + a);
                }
                else if(b < a && b < c)
                {
                    Console.WriteLine("MENOR = " + b);
                }
                else
                {
                    Console.WriteLine("MENOR = " + c);
                }
            }
            Console.ReadKey();
        }
    }
}
