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
            string[] nome;
            int[] idade;
            int idadeMaior, posicao;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            idadeMaior = 0;
            posicao = 0;
            for (int i = 0; i < N; i++)
            {
                if (idadeMaior < idade[i])
                {
                    idadeMaior = idade[i];
                    posicao = i;
                }
            }
            Console.WriteLine($"Pessoa mais velha: {nome[posicao]}");
            Console.ReadKey();
        }
    }
}
