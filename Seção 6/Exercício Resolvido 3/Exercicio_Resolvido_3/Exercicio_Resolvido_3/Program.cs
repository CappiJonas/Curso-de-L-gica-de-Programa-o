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
            int N;
            string[] nome;
            int[] idade;
            double[] altura;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            altura = new double[N];
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2]);
            }

            double alturaTotal = 0;
            for (int i = 0; i < N; i++)
            {
                alturaTotal = alturaTotal + altura[i];
            }

            double media = 0;
            media = alturaTotal / N;
            Console.WriteLine($"Altura média : {media.ToString("F2")}");

            int menorIdade = 0;
            for (int i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    menorIdade = menorIdade + 1;
                }
            }
            double porcentagem;
            porcentagem = (double) menorIdade / N * 100.0;
            Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F1")}%");
            Console.ReadKey();
        }
    }
}
