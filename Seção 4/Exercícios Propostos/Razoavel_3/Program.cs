using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razoavel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, N, media, mediaReprovado;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0]);
            N2 = double.Parse(vet[1]);
            N3 = double.Parse(vet[2]);
            N4 = double.Parse(vet[3]);

            media = (2 * N1 + 3 * N2 + 4 * N3 + N4) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Média: " + media.ToString("F1"));
                Console.WriteLine("Aluno aprovado");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Média: " + media.ToString("F1"));
                Console.WriteLine("Aluno reprovado");
            }
            else
            {
                N = double.Parse(Console.ReadLine());
                mediaReprovado = (N + media) / 2;

                if (mediaReprovado >= 5.0)
                {
                    Console.WriteLine("Média: " + media.ToString("F1"));
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine("Nota do exame: " + N);
                    Console.WriteLine("Aluno aprovado");
                    Console.WriteLine("Média final: " + mediaReprovado.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("Média: " + media.ToString("F1"));
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine("Nota do exame: " + N);
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Média final: " + mediaReprovado.ToString("F1"));
                }
            }
            Console.ReadKey();
        }
    }
}
