using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Resolvido_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, nota;

            Console.WriteLine("Quais são as notas? ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            nota = x + y;
            Console.WriteLine();
            Console.WriteLine("NOTA FINAL= " + nota.ToString("F1"));

            if(nota < 60.00)
                Console.WriteLine("REPROVADO");

            Console.ReadKey();
        }
    }
}
