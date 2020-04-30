using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_Com_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, venda, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            venda = double.Parse(Console.ReadLine());
            total = salario + 0.15 * venda;
            Console.WriteLine("Total = " + total.ToString("F2"));
            Console.ReadKey();
        }
    }
}
