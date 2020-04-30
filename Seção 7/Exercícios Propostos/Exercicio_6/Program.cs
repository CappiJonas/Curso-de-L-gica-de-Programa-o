using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(s[j]);
                }
            }

            //Parte A

            double somaPositiva = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        somaPositiva = somaPositiva + mat[i, j];
                    }
                }
            }
            Console.WriteLine($"Soma dos Positivos: {somaPositiva}");

            //Parte B

            int indiceLinha = int.Parse(Console.ReadLine());
            Console.Write("Linha Escolhida: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[indiceLinha, i] + " ");
            }
            Console.WriteLine();

            //Parte C

            int indiceColuna = int.Parse(Console.ReadLine());
            Console.Write("Coluna Escolhida: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, indiceColuna] + " ");
            }
            Console.WriteLine();

            //Parte D

            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();

            //Parte E

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0.0)
                    {
                        mat[i, j] = Math.Pow(mat[i, j], 2.0);
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
