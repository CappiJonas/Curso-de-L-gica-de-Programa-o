using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {           
            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);

            double A, B, C;

            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NÃO FORMA TRIÂNGULO");
            }
            else
            {
                if(Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
                {
                    Console.WriteLine("TRIÂNGULO RETÂNGULO");
                }
                else if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
                {
                    Console.WriteLine("TRIÂNGULO OBTUSÂNGULO");
                }
                else
                {
                    Console.WriteLine("TRIÂNGULO ACUTÂNGULO");
                }
                
                if(A == B && B == C)
                {
                    Console.WriteLine("TRIÂNGULO EQUILÁTERO");
                }
                else if (A == B || B == C || C == A)
                {
                    Console.WriteLine("TRIÂNGULO ISÓSCELES");
                }
            }
            Console.ReadKey();
        }

    }
}
