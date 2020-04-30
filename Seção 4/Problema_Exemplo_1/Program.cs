using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuto, diferenca;

            minuto = int.Parse(Console.ReadLine());

            if(minuto <= 100)
            {
                Console.WriteLine("Valor a pagar: R$ 50,00");
            }
            else
            {
                diferenca = 50 +(minuto - 100)*2;
                Console.WriteLine("Valor a pagar: R$ " + diferenca.ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}
