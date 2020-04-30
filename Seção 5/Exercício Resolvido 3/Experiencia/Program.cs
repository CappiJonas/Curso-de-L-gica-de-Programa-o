using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, quantidade, soma, contC, contR, contS;
            string animal;

            quantidade = 0;
            N = int.Parse(Console.ReadLine());
            contC = 0;
            contR = 0;
            contS = 0;
            soma = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                quantidade = double.Parse(vet[0]);
                animal = vet[1];

                if (animal == "C")
                {
                    contC = contC + quantidade;
                }
                else if (animal == "R")
                {
                    contR = contR + quantidade;
                }
                else if (animal == "S")
                {
                    contS = contS + quantidade;
                }              
            }
            soma = soma + contC + contR + contS;

            Console.WriteLine($"Total: {soma} cobaias");
            Console.WriteLine($"Total de coelhos: {contC}");
            Console.WriteLine($"Total de ratos: {contR}");
            Console.WriteLine($"Total de sapos: {contS}");
            Console.WriteLine($"Percentual de coelhos: {(contC / soma * 100).ToString("F2")}%");
            Console.WriteLine($"Percentual de ratos: {(contR / soma * 100).ToString("F2")}%");
            Console.WriteLine($"Percentual de sapos: {(contS / soma * 100).ToString("F2")}%");
            Console.ReadKey();
        }
    }
}
