using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacao_Pontuacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Nota inválida");
                nota1 = double.Parse(Console.ReadLine());
            }

            nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota inválida");
                nota2 = double.Parse(Console.ReadLine());
            }

            media = (nota1 + nota2) / 2;

            Console.WriteLine("Média = " + media.ToString("F2"));
            Console.ReadKey();
        }
    }
}
