using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Propostos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] valores;
            double maiorValor;

            maiorValor = 0.0;
            N = int.Parse(Console.ReadLine());
            valores = new double[N];
            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                valores[i] = double.Parse(S[i]);
            }

            int posicao = 0;
            for (int i = 0; i < N; i++)
            {
                if (maiorValor < valores[i])
                {
                    maiorValor = valores[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posicao);
            Console.ReadKey();
        }
    }
}
