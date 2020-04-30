using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont;
            double[] numero;
            double media, soma;

            cont = 0;
            media = 0;
            soma = 0;
            N = int.Parse(Console.ReadLine());
            numero = new double[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                numero[i] = double.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (numero[i] % 2.0 == 0)
                {
                    soma = soma + numero[i];
                    cont++;
                }
            }
            media = soma / cont;
            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}
