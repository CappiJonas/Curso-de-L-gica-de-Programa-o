using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular__Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int COD1, unidade1, COD2, unidade2;
            float preco1, preco2, valorTotal;

            COD1 = int.Parse(Console.ReadLine());
            unidade1 = int.Parse(Console.ReadLine());
            preco1 = float.Parse(Console.ReadLine());
            COD2 = int.Parse(Console.ReadLine());
            unidade2 = int.Parse(Console.ReadLine());
            preco2 = float.Parse(Console.ReadLine());
            valorTotal = unidade1 * preco1 + unidade2 * preco2;
            Console.WriteLine("VALOR A PAGAR : R$ " + valorTotal.ToString("F2"));
            Console.ReadKey();
        }
    }
}
