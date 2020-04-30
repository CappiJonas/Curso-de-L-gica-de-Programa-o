using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grenal
{
    class Program
    {
        static void Main(string[] args)
        {
            int golInter, golGremio, contInter, contGremio, contEmpate, escolha;

            string[] vet = Console.ReadLine().Split(' ');
            golInter = int.Parse(vet[0]);
            golGremio = int.Parse(vet[1]);
            contInter = 0;
            contGremio = 0;
            contEmpate = 0;

            if (golInter > golGremio)
            {
                contInter = contInter + 1;
            }
            else if (golInter < golGremio)
            {
                contGremio = contGremio + 1;
            }
            else
            {
                contEmpate = contEmpate + 1;
            }
            Console.WriteLine("Novo grenal (1-sim 2-não)");
            escolha = int.Parse(Console.ReadLine());
            while (escolha < 1 || escolha > 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-não)");
                escolha = int.Parse(Console.ReadLine());
            }

            if (escolha == 1)
            {
                while (escolha == 1)
                {
                    vet = Console.ReadLine().Split(' ');
                    golInter = int.Parse(vet[0]);
                    golGremio = int.Parse(vet[1]);

                    if (golInter > golGremio)
                    {
                        contInter = contInter + 1;
                    }
                    else if (golInter < golGremio)
                    {
                        contGremio = contGremio + 1;
                    }
                    else
                    {
                        contEmpate = contEmpate + 1;
                    }
                    Console.WriteLine("Novo grenal (1-sim 2-não)");
                    escolha = int.Parse(Console.ReadLine());
                    while (escolha < 1 || escolha > 2)
                    {
                        Console.WriteLine("Novo grenal (1-sim 2-não)");
                        escolha = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Inter: " + contInter);
            Console.WriteLine("Gremio: " + contGremio);
            Console.WriteLine("Empate: " + contEmpate);

            if (contInter > contGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contInter < contGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Não houve vencedor");
            }
            Console.ReadKey();
        }
    }
}
