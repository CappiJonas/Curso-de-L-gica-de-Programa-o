using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha_Fixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");

            Console.ReadKey();
        }
    }
}
