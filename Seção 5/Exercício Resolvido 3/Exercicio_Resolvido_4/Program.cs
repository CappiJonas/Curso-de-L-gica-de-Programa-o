using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            soma = 0;

            if (X > Y)
            {
                if (Y % 2 == 0 && X % 2 == 0)
                {
                    for (int i = 1; Y <= (X - 1); i = i + 2)
                    {
                        Y = Y + i;
                        soma = soma + Y;
                    }
                    Console.WriteLine(soma);
                }
                else if (Y % 2 == 0 && X % 2 == 1)
                {
                    for (int i = 1; Y < (X - 2); i = i + 2)
                    {
                        Y = Y + i;
                        soma = soma + Y;
                    }
                    Console.WriteLine(soma);
                }
                else if (Y % 2 == 1 && X % 2 == 0)
                {
                    for (int i = 2; Y <= (X - 1); i = i + 2)
                    {
                        Y = Y + i;
                        soma = soma + Y;
                    }
                    Console.WriteLine(soma);
                }
                else
                {
                    for (int i = 2; Y < (X - 2); i = i + 2)
                    {
                        Y = Y + i;
                        soma = soma + Y;
                    }
                    Console.WriteLine(soma);
                }
            }
            else if (X < Y)
            {
                if (X % 2 == 0 && Y % 2 == 0)
                {
                    for (int i = 1; X <= (Y - 1); i = i + 2)
                    {
                        X = X + i;
                        soma = soma + X;
                    }
                    Console.WriteLine(soma);

                }
                else if (X % 2 == 0 && Y % 2 == 1)
                {
                    for (int i = 1; X < (Y - 2); i = i + 2)
                    {
                        X = X + i;
                        soma = soma + X;
                    }
                    Console.WriteLine(soma);
                }
                else if(X % 2 == 1 && Y % 2 == 0)
                {
                    for (int i = 2; X <= (Y - 1); i = i + 2)
                    {
                        X = X + i;
                        soma = soma + X;
                    }
                    Console.WriteLine(soma);
                }
                else
                {
                    for (int i = 2; X < (Y - 2); i = i + 2)
                    {
                        X = X + i;
                        soma = soma + X;
                    }
                    Console.WriteLine(soma);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
