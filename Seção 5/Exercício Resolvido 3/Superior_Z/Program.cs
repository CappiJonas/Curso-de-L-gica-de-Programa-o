using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superior_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z, soma, cont;

            cont = 0;
            soma = 0;
            X = int.Parse(Console.ReadLine());

            do
            {
                Z = int.Parse(Console.ReadLine());
            } while (Z < X || Z == X);

            for (int i = 0; soma <= Z; i++)
            {
                soma = soma + X;
                X = X + 1;
                cont = cont + 1;
            }
            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
