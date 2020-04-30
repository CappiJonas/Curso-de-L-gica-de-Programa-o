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
            int N, multiplicacao;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                multiplicacao = i * N;
                Console.WriteLine($"{i} x {N} = {multiplicacao}");
            }
            Console.ReadKey();
        }
    }
}
