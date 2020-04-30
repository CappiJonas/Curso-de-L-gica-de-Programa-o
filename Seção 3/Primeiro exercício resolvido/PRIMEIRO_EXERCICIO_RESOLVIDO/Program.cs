using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRO_EXERCICIO_RESOLVIDO
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, valorTerreno, preco;

            Console.WriteLine("Diga os valores da largura, do comprimento e do valor por metro" +
                " quadrado, respectivamente");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("A largura do terreno é " + largura.ToString("F1"));
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("A comprimento do terreno é " + comprimento.ToString("F1"));
            valorTerreno = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor por metro quadrado é " + valorTerreno.ToString("F2"));
            Console.ReadKey();

            Console.WriteLine();

            area = largura * comprimento;
            Console.WriteLine("A área do terreno é " + area.ToString("F2"));
            Console.ReadKey();

            Console.WriteLine();

            preco = area * valorTerreno;
            Console.WriteLine("O valor do terreno é R$ " + preco.ToString("F2"));
            Console.ReadKey();
        }
    }
}
