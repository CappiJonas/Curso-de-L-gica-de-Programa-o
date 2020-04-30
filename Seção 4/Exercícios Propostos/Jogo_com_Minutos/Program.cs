using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_com_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, duracaoHora, duracaoMinuto;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            if (A == C && B == D)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS");
            }
            else if (C > A && D == B)
            {
                duracaoHora = C - A;
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S)");
            }
            else if (C < A && D == B)
            {
                duracaoHora = C - A + 24;               
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S)");
            }
            else if (A == C && D > B)
            {
                duracaoMinuto = D - B;
                Console.WriteLine($"O JOGO DUROU {duracaoMinuto} MINUTO(S)");
            }
            else if (A == C && D < B)
            {
                duracaoMinuto = D - B + 60;
                Console.WriteLine($"O JOGO DUROU 23 HORAS E {duracaoMinuto} MNUTO(S)");
            }
            else if (C > A && D > B)
            {
                duracaoHora = C - A;
                duracaoMinuto = D - B;
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
            }
            else if (C > A && D < B)
            {
                duracaoHora = C - A - 1;
                duracaoMinuto = D - B + 60;
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
            }
            else if (C < A && D > B)
            {
                duracaoHora = C - A + 24;
                duracaoMinuto = D - B;
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
            }
            else
            {
                duracaoHora = C - A + 23;
                duracaoMinuto = D - B + 60;
                Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
            }
            Console.ReadKey();
        }
    }
}
