using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma, media;
            double[] vet;

            soma = 0;
            N = int.Parse(Console.ReadLine());
            string[] S = Console.ReadLine().Split(' ');
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(S[i]);
                Console.Write($"{vet[i].ToString("F1")} ");
                soma = soma + vet[i];
            }

            Console.WriteLine();
            Console.WriteLine(soma.ToString("F2"));
            media = soma / N;
            Console.WriteLine(media.ToString("F2"));
            Console.ReadKey();
        }
    }
}
