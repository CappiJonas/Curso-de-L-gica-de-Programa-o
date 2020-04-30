using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            double valorPago;

            string[] vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            switch (X)
            {
                case 1:
                    valorPago = Y * 4.00;
                    Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
                    break;

                case 2:
                    valorPago = Y * 4.50;
                    Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
                    break;

                case 3:
                    valorPago = Y * 5.00;
                    Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
                    break;

                case 4:
                    valorPago = Y * 2.00;
                    Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
                    break;

                case 5:
                    valorPago = Y * 1.50;
                    Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
                    break;

                default:
                    Console.WriteLine("Código errado. O código tem que ser um número de 1 a 5");
                    break;
            }
            Console.ReadKey();
        }
    }
}
