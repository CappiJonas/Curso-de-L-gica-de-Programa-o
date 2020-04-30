using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAntigo, reajuste, salarioNovo;

            salarioAntigo = double.Parse(Console.ReadLine());

            if (salarioAntigo > 0 && salarioAntigo <= 400.00)
            {
                reajuste = 0.15 * salarioAntigo;
                salarioNovo = salarioAntigo + reajuste;
                Console.WriteLine("Novo salário: " + salarioNovo.ToString("F2"));
                Console.WriteLine("Ganho de reajuste: " + reajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 15%");
            }
            else if (salarioAntigo >= 400.01 && salarioAntigo <= 800.00)
            {
                reajuste = 0.12 * salarioAntigo;
                salarioNovo = salarioAntigo + reajuste;
                Console.WriteLine("Novo salário: " + salarioNovo.ToString("F2"));
                Console.WriteLine("Ganho de reajuste: " + reajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 12%");
            }
            else if (salarioAntigo >= 800.01 && salarioAntigo <= 1200.00)
            {
                reajuste = 0.1 * salarioAntigo;
                salarioNovo = salarioAntigo + reajuste;
                Console.WriteLine("Novo salário: " + salarioNovo.ToString("F2"));
                Console.WriteLine("Ganho de reajuste: " + reajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 10%");
            }
            else if (salarioAntigo >= 1200.01 && salarioAntigo <= 2000.00)
            {
                reajuste = 0.07 * salarioAntigo;
                salarioNovo = salarioAntigo + reajuste;
                Console.WriteLine("Novo salário: " + salarioNovo.ToString("F2"));
                Console.WriteLine("Ganho de reajuste: " + reajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 7%");
            }
            else
            {
                reajuste = 0.5 * salarioAntigo;
                salarioNovo = salarioAntigo + reajuste;
                Console.WriteLine("Novo salário: " + salarioNovo.ToString("F2"));
                Console.WriteLine("Ganho de reajuste: " + reajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 5%");
            }
            Console.ReadKey();
        }
    }
}
