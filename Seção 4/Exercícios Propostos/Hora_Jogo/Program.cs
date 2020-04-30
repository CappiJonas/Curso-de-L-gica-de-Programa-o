using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hora_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A < B)
            {
                duracao = B - A;
                Console.WriteLine($"O jogo durou {duracao} hora(s)");
            }
            else if (A > B)
            {
                duracao = (B + 24) - A;
                Console.WriteLine($"O jogo durou {duracao} hora(s)");
            }
            else
            {
                duracao = 24;
                Console.WriteLine($"O jogo durou {duracao} hora(s)");
            }
            Console.ReadKey();
        }
    }
}
