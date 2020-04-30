using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varias_Pontuacoes_Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media1;
            int escolha;

            nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Nota Inválida");
                nota1 = double.Parse(Console.ReadLine());
            }

            nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota Inválida");
                nota2 = double.Parse(Console.ReadLine());
            }

            media1 = (nota1 + nota2) / 2;
            Console.WriteLine("Média = " + media1);

            
            Console.WriteLine("Novo Cálculo (1-sim 2-não)");
            escolha = int.Parse(Console.ReadLine());
            while (escolha < 1 || escolha > 2)
            {
                Console.WriteLine("Novo Cálculo (1-sim 2 não)");
                escolha = int.Parse(Console.ReadLine());
            }
            if (escolha == 1)
            {
                while (escolha == 1)
                {
                    nota1 = double.Parse(Console.ReadLine());
                    while (nota1 < 0 || nota1 > 10)
                    {
                        Console.WriteLine("Nota Inválida");
                        nota1 = double.Parse(Console.ReadLine());
                    }

                    nota2 = double.Parse(Console.ReadLine());
                    while (nota2 < 0 || nota2 > 10)
                    {
                        Console.WriteLine("Nota Inválida");
                        nota2 = double.Parse(Console.ReadLine());
                    }

                    media1 = (nota1 + nota2) / 2;
                    Console.WriteLine("Média = " + media1);

                    Console.WriteLine("Novo Cálculo (1-sim 2 não)");
                    escolha = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
