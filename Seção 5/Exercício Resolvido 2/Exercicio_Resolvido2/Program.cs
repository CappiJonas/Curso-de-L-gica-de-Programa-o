using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            cont = 0;
            soma = 0.0;
            idade = int.Parse(Console.ReadLine());

            if (idade < 0.0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                while (idade >= 0.0)
                {
                    cont = cont + 1;
                    soma = soma + idade; 
                    idade = int.Parse(Console.ReadLine());
                }
                media = soma / cont;

                Console.WriteLine(media.ToString("F2"));               
            }
            Console.ReadKey();
        }
    }
}
