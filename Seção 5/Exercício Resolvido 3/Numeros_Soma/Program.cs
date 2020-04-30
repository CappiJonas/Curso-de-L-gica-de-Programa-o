using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, soma;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            soma = 0;

            if (M != 0 && N != 0)
            {
                if (M > N)
                {
                    for (int i = 0; N <= M; i++)
                    {
                        soma = soma + N;
                        Console.Write(N + " ");
                        N = N + 1;
                    }
                    Console.Write("Soma = " + soma);
                }
                else if (N > M)
                {
                    for (int i = 1; M <= N; i++)
                    {
                        soma = soma + M;
                        Console.Write(M + " ");
                        M = M + 1;
                    }
                    Console.Write("Soma = " + soma);
                }
                else
                {
                    soma = M + N;
                    Console.Write("Soma = " + soma);
                }
            }           
            Console.ReadKey();
        }
    }
}
