using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cem, resto100, cinquenta, resto50, vinte, resto20, dez, resto10, cinco, resto5, dois
              , um;

            N = int.Parse(Console.ReadLine());
            cem = N / 100;
            resto100 = N % 100;
            cinquenta = resto100 / 50;
            resto50 = resto100 % 50;
            vinte = resto50 / 20;
            resto20 = resto50 % 20;
            dez = resto20 / 10;
            resto10 = resto20 % 10;
            cinco = resto10 / 5;
            resto5 = resto10 % 5;
            dois = resto5 / 2;
            um = resto5 % 2;
            Console.WriteLine(N);
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{um} nota(s) de R$ 1,00");
            Console.ReadKey();
        }
    }
}
