using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, media, soma;
            int cont;

            cont = 0;
            soma = 0.0;
            idade = double.Parse(Console.ReadLine());
            while (idade >= 0)
            {
                cont = cont + 1;
                soma = soma + idade;
                idade = double.Parse(Console.ReadLine());
            }
            media = soma/ cont;

            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}
