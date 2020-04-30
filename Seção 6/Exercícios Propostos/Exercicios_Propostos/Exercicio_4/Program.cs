using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] valor;
            double soma, media;

            media = 0;
            soma = 0;
            N = int.Parse(Console.ReadLine());
            valor = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                valor[i] = double.Parse(s[i]);
                soma = soma + valor[i];
            }

            media = soma / N;
            Console.WriteLine(media);
            for (int i = 0; i < N; i++)
            {
                if (valor[i] < media)
                {
                    Console.WriteLine(valor[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
