using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, soma, numeroImpar;
            
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);

                if (X > Y)
                {
                    if (Y % 2 == 0)
                    {
                        numeroImpar = Y + 1;
                        soma = 0;
                        for (int a = 0; numeroImpar < X; a++)
                        {
                            soma = soma + numeroImpar;
                            numeroImpar = numeroImpar + 2;
                        }
                    }
                    else
                    {
                        numeroImpar = Y + 2;
                        soma = 0;
                        for (int b = 0; numeroImpar < X; b++)
                        {
                            soma = soma + numeroImpar;
                            numeroImpar = numeroImpar + 2;
                        }
                    }
                    Console.WriteLine(soma);          
                }
                else if (Y > X)
                {
                    if (X % 2 == 0)
                    {
                        numeroImpar = X + 1;
                        soma = 0;
                        for (int a = 0; numeroImpar < Y; a++)
                        {
                            soma = soma + numeroImpar;
                            numeroImpar = numeroImpar + 2;
                        }
                    }
                    else
                    {
                        numeroImpar = X + 2;
                        soma = 0;
                        for (int b = 0; numeroImpar < Y; b++)
                        {
                            soma = soma + numeroImpar;
                            numeroImpar = numeroImpar + 2;
                        }
                    }
                    Console.WriteLine(soma);
                }
                else if (X == Y)
                {
                    Console.WriteLine("0 0");
                }
            }
            Console.ReadKey();
        }
    }
}
