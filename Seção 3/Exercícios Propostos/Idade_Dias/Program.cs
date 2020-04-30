using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, ano, resto, mes, dia;

            X = int.Parse(Console.ReadLine());
            ano = X / 365;
            resto = X % 365;
            mes = resto / 30;
            dia = resto % 30;
            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
            Console.ReadKey();
        }
    }
}
