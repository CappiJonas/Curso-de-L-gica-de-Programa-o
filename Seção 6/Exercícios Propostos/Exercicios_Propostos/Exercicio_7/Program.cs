using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome;
            double[] nota1, nota2, media;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];
            media = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                nota1[i] = double.Parse(s[1]);
                nota2[i] = double.Parse(s[2]);
            }

            for (int i = 0; i < N; i++)
            {
                media[i] = (nota1[i] + nota2[i]) / 2.0;
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                if (media[i] >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
