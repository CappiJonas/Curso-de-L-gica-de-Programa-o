﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] soma = new int[M];
            for (int i = 0; i < M; i++)
            {
                soma[i] = 0;
                for (int j = 0; j < N; j++)
                {
                    soma[i] = soma[i] + mat[i, j];
                }
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(soma[i]);
            }
            Console.ReadKey();
        }
    }
}
